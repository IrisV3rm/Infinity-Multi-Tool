using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Infinity_Multi_Tool.Properties;

namespace Infinity_Multi_Tool
{
    public partial class Launcher : Form
    {
#pragma warning disable CS0108
        private string MainDirectory = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\InfTools";
        private string TempFileDir;
        private string CurrentDir = Environment.CurrentDirectory;
        private string Version;
        private string CurrentVersion = Settings.Default.Version;
        private bool MouseDown = false;
        private Point LastLocation;
        private bool DownloadFinished = false;
        private bool Toggled;
        private RadioButton CurrentButton;
        private bool ToolsDownloaded = false;
#pragma warning restore CS0108 
        public Launcher()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        
        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown = true;
            LastLocation = e.Location;

        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseDown)
            {
                Location = new Point(
                    Location.X - LastLocation.X + e.X, Location.Y - LastLocation.Y + e.Y);

                Update();
            }
        }
        private static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://clients3.google.com/generate_204"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        private void ProgChange(object sender, DownloadProgressChangedEventArgs e)
        {
            try
            {
                double bytesIn = double.Parse(e.BytesReceived.ToString());
                double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
                var Percentage = Math.Truncate(bytesIn / totalBytes * 100).ToString();

                PercentageLabel.Text = $"{Percentage}%";
            }
            catch { }
        }

        private void StartDownload()
        {
            if (CheckForInternetConnection())
            {

                using (WebClient web = new WebClient())
                {
                    ToolsDownloaded = false;
                    PercentageLabel.Visible = true;
                    PercentageLabel.Text = "0%";
                    foreach (var file in Directory.GetFiles($"{MainDirectory}\\Tools"))
                    {
                        string cf = file.Replace($"{MainDirectory}\\Tools\\", "");
                        string CurrentFile = cf.Replace(".exe", "");
                        foreach (Process Proc in Process.GetProcessesByName(CurrentFile))
                        {
                            Proc.Kill();
                        }
                    }
                    web.DownloadFileAsync(new Uri("https://xn--i77c.com/InfinityHosting/MultiTool/ToolsUpdate.zip"), $"{MainDirectory}\\TempFiles\\ToolsUpdate.zip");
                    web.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgChange);
                    web.DownloadFileCompleted += new AsyncCompletedEventHandler(Tools_DownloadFileCompleted);
                }
            }
            else
            {
                Forms.Notify("This requries an internet connection!", false, true);
                Environment.Exit(0);
            }
        }

        private async void Tools_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            foreach (var file in Directory.GetFiles($"{MainDirectory}\\Tools"))
            {
                File.Delete(file);
            }
            ZipFile.ExtractToDirectory($"{MainDirectory}\\TempFiles\\ToolsUpdate.zip", $"{MainDirectory}\\Tools");
            Forms.Notify("Tools finished feel free to proceed.", false, true);
            ToolsDownloaded = true;
            await Task.Delay(1500);
            PercentageLabel.Visible = false;
        }

        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            MouseDown = false;
        }
        
        private void Close_MouseHover(object sender, EventArgs e)
        {
            Close.BackgroundImage = Resources.MacHover;
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            Close.BackgroundImage = Resources.MacClose;
        }

        private void Minimize_MouseEnter(object sender, EventArgs e)
        {
            Minimize.BackgroundImage = Resources.MacHoverMin;
        }

        private void Minimize_MouseLeave(object sender, EventArgs e)
        {
            Minimize.BackgroundImage = Resources.MacMin;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Log(params string[] Str)
        {
            using (StreamWriter Writer = File.AppendText($"{MainDirectory}\\TempFiles\\Log.txt"))
            {
                Writer.WriteLine($"{string.Join(" ",  Str)}");
            }
        }

        private async void CheckForUpdates()
        {
            Log("Grabbing version data...");
            using (WebClient Web = new WebClient())
            {
                Version = Web.DownloadString("https://xn--i77c.com/InfinityHosting/MultiTool/Version");
                Log($"Grabbed version: {Version}");
                Log($"Current version: {Settings.Default.Version}");
            }
            Log($"Comparing versions and proceeding...");
            if (Version != CurrentVersion)
            {
                DialogResult dia = Forms.Notify("Update Found, would you like to continue with the update?", true, false);
                if (dia == DialogResult.Yes)
                {
                    Log($"Version is outdated updating...");
                    using (WebClient Web = new WebClient())
                    {
                        Web.DownloadFileAsync(
                            new Uri("https://xn--i77c.com/InfinityHosting/MultiTool/Infinity%20Multi%20Tool.exe"),
                            $"{Application.StartupPath}\\{Process.GetCurrentProcess().ProcessName}.temp");
                        Web.DownloadFileCompleted += Web_DownloadFileCompleted;
                        TempFileDir = $"{Application.StartupPath}\\{Process.GetCurrentProcess().ProcessName}.temp";
                    }

                    Log($"Finished Downloading...");
                    while (!DownloadFinished)
                    {
                        await Task.Delay(50);
                    }

                    using (StreamWriter Writer = new StreamWriter($"{MainDirectory}\\TempFiles\\Update.bat"))
                    {
                        Writer.Write(
                            $"TaskKill /F /IM \"{Process.GetCurrentProcess().ProcessName}.exe\" & ping 127.0.0.1 -n 2 > nul & del \"{Application.ExecutablePath.Replace("/", "\\")}\" /F /Q & rename \"{TempFileDir.Replace("/", "\\")}\" \"{Process.GetCurrentProcess().ProcessName}.exe\" & cd \"{Application.StartupPath.Replace("/", "\\")}\" & \"{Process.GetCurrentProcess().ProcessName}.exe\"");
                        Writer.Dispose();
                    }

                    using (StreamWriter Writer = new StreamWriter($"{MainDirectory}\\__VERSION"))
                    {
                        Settings.Default.Version = Version;
                        Settings.Default.Save();
                        Writer.Write(Settings.Default.Version);
                        Writer.Dispose();
                    }

                    Log($"ReNaming and Relaunching...");
                    using (Process Proc = new Process())
                    {
                        Proc.StartInfo.UseShellExecute = false;
                        Proc.StartInfo.CreateNoWindow = true;
                        Proc.StartInfo.FileName = $"{MainDirectory}\\TempFiles\\Update.bat";
                        Proc.Start();
                    }

                    return;
                }
            }
            else
            {
                Forms.Notify("You are currently running the latest version!", false, true);
                Log($"Version is up to date!");
            }
        }

        private void Web_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            DownloadFinished = true;
        }

        private void Launcher_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(MainDirectory) || !File.Exists($"{MainDirectory}\\TempFiles\\Log.txt"))
            {
                Directory.CreateDirectory(MainDirectory);
                Directory.CreateDirectory($"{MainDirectory}\\Tools");
                Directory.CreateDirectory($"{MainDirectory}\\TempFiles");
                using (StreamWriter Writer = new StreamWriter($"{MainDirectory}\\__VERSION"))
                {
                    Writer.Write(Settings.Default.Version);
                    Writer.Dispose();
                }
                File.CreateText($"{MainDirectory}\\TempFiles\\Log.txt").Dispose();
                Log($"== Log Started {string.Format("{0:HH:mm:ss tt}", DateTime.Now)} ==\n");
            }
            else
            {
                File.CreateText($"{MainDirectory}\\TempFiles\\Log.txt").Dispose();
                Log($"== Log Started {string.Format("{0:HH:mm:ss tt}", DateTime.Now)} ==\n");
                using (StreamWriter Writer = new StreamWriter($"{MainDirectory}\\__VERSION"))
                {
                    Writer.Write(Settings.Default.Version);
                }
            }

            using (WebClient Web = new WebClient())
            {
                Announcement.Text = Web.DownloadString("https://xn--i77c.com/InfinityHosting/MultiTool/Announcement");
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            CheckForUpdates();
        }

        private void Launcher_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (string CurrFile in Directory.GetFiles($"{MainDirectory}\\TempFiles")) File.Delete(CurrFile);
            Settings.Default.Save();
        }

        private void MultipleRobloxInstancesToggle_CheckedChanged(object sender, EventArgs e)
        {
            CurrentButton = sender as RadioButton;
            Toggled = CurrentButton.Checked;

            if (Toggled)
            {
                Launch.BackgroundImage = Resources.LaunchGreen;
            }
            else
            {
                Launch.BackgroundImage = Resources.LaunchRed;
            }
        }

        private void DownloadTools_Click(object sender, EventArgs e)
        {
            StartDownload();
        }

        private async void Launch_Click(object sender, EventArgs e)
        {

            if (Launch.BackgroundImage != Resources.LaunchRed)
            {
                string CurrentSelected;
                try
                {
                    CurrentSelected = CurrentButton.Name;
                }
                catch
                {
                    return;
                }

                if (CurrentSelected.Contains("Multiple"))
                {
                    if (!File.Exists($"{MainDirectory}\\Tools\\Multiple_Roblox.exe"))
                    {
                        DialogResult dia = Forms.Notify("Tool not found, would you like to download the tools?", true, false);
                        if (dia == DialogResult.Yes)
                        {
                            StartDownload();
                        }
                        else
                        {
                            return;
                        }

                        while (!ToolsDownloaded)
                        {
                            await Task.Delay(50);
                        }
                        foreach (Process Proc in Process.GetProcessesByName("Multiple_Roblox")) Proc.Kill();
                        Process.Start($"{MainDirectory}\\Tools\\Multiple_Roblox.exe");
                    }
                    else
                    {
                        foreach (Process Proc in Process.GetProcessesByName("Multiple_Roblox")) Proc.Kill();
                        Process.Start($"{MainDirectory}\\Tools\\Multiple_Roblox.exe");
                    }
                }
                else if (CurrentSelected.Contains("Asset"))
                {
                    Hide();
                    try
                    {
                        Forms.AssetDownloader.ShowDialog();
                    }
                    catch
                    {
                        Forms.AssetDownloader.Show();
                    }
                }
                else if (CurrentSelected.Contains("Sniper"))
                {
                    Hide();
                    try
                    {
                        Forms.Snip.ShowDialog();
                    }
                    catch
                    {
                        Forms.Snip.Show();
                    }
                }
                else if (CurrentSelected.Contains("Boi"))
                {
                    Hide();
                    try
                    {
                        Forms.Boio.ShowDialog();
                    }
                    catch
                    {
                        Forms.Boio.Show();
                    }
                }
                else if (CurrentSelected.Contains("Disc"))
                {
                    Hide();
                    try
                    {
                        Forms.DiscCache.ShowDialog();
                    }
                    catch
                    {
                        Forms.DiscCache.Show();
                    }
                }
                else if (CurrentSelected.Contains("Hash"))
                {
                    Hide();
                    try
                    {
                        Forms.HashGen.ShowDialog();
                    }
                    catch
                    {
                        Forms.HashGen.Show();
                    }
                }
                else if (CurrentSelected.Contains("FPS"))
                {
                    if (!File.Exists($"{MainDirectory}\\Tools\\rbxfpsunlocker.exe"))
                    {
                        DialogResult dia = Forms.Notify("Tool not found, would you like to download the tools?", true, false);
                        if (dia == DialogResult.Yes)
                        {
                            StartDownload();
                        }
                        else
                        {
                            return;
                        }

                        while (!ToolsDownloaded)
                        {
                            await Task.Delay(50);
                        }
                        foreach (Process Proc in Process.GetProcessesByName("rbxfpsunlocker")) Proc.Kill();
                        Process.Start($"{MainDirectory}\\Tools\\rbxfpsunlocker.exe");
                    }
                    else
                    {
                        foreach (Process Proc in Process.GetProcessesByName("rbxfpsunlocker")) Proc.Kill();
                        Process.Start($"{MainDirectory}\\Tools\\rbxfpsunlocker.exe");
                    }
                }
            }
        }

        private void Credits_Click(object sender, EventArgs e)
        {
            Forms.Credit.ShowDialog();
        }
    }
}
