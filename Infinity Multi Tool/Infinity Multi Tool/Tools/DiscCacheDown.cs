using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Infinity_Multi_Tool.Properties;

namespace Infinity_Multi_Tool
{
    public partial class DiscCacheDown : Form
    {
        private bool OmgPlsStop = false;
        private bool MouseDown = false;
        private Point LastLocation;
        public DiscCacheDown()
        {
            InitializeComponent();
            //Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
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
            OmgPlsStop = true;
            Hide();
            try
            {
                Forms.Launcher.ShowDialog();
            }
            catch { Forms.Launcher.Show();}
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private async void MD5Hash_Click(object sender, EventArgs e)
        {
            int TotalFiles;
            int FilesDone;
            bool Delete;
            string RoamingFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string DiscordImg = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\DiscordImageCache";
            if (!Directory.Exists($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\DiscordImageCache"))
                Directory.CreateDirectory($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\DiscordImageCache");

            DialogResult Dialog = Forms.Notify("Would you like to clear the cache when completed?", true, false);
            if (Dialog == DialogResult.Yes)
            {
                Delete = true;
            }
            else
            {
                Delete = false;
            }

            Process.Start("explorer.exe",
                $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\DiscordImageCache");
            if (Directory.Exists($"{RoamingFolder}\\Discord"))
            {
                TotalFiles = Directory.GetFiles($"{RoamingFolder}\\Discord\\Cache").Length;
                FilesDone = 0;
                label1.Text = $"{FilesDone.ToString()}/{TotalFiles}";
                FileCompelte.Maximum = TotalFiles;
                foreach (string CurrFile in Directory.GetFiles($"{RoamingFolder}\\Discord\\Cache"))
                {
                    if (OmgPlsStop)
                    {
                        break;
                    }
                    if (CurrFile.Contains("f_0"))
                    {
                        File.Copy(CurrFile, $"{DiscordImg}\\{CurrFile.Substring(CurrFile.LastIndexOf("\\") + 1)}.png");
                        FileCompelte.Value++;
                        FilesDone++;
                        label1.Text = $"{FilesDone.ToString()}/{TotalFiles}";
                        if (Delete)
                        {
                            File.Delete(CurrFile);
                        }
                    }
                    else
                    {
                        FileCompelte.Value++;
                        FilesDone++;
                        label1.Text = $"{FilesDone.ToString()}/{TotalFiles}";
                    }
                    await Task.Delay(50);
                }
            }
            else if (Directory.Exists($"{RoamingFolder}\\discordptb"))
            {

                TotalFiles = Directory.GetFiles($"{RoamingFolder}\\discordptb\\Cache").Length;
                FilesDone = 0;
                label1.Text = $"{FilesDone.ToString()}/{TotalFiles}";
                FileCompelte.Maximum = TotalFiles;
                foreach (string CurrFile in Directory.GetFiles($"{RoamingFolder}\\discordptb\\Cache"))
                {
                    if (OmgPlsStop)
                    {
                        break;
                    }
                    if (CurrFile.Contains("f_0"))
                    {
                        File.Copy(CurrFile, $"{DiscordImg}\\{CurrFile.Substring(CurrFile.LastIndexOf("\\") + 1)}.png");
                        FileCompelte.Value++;
                        FilesDone++;
                        label1.Text = $"{FilesDone.ToString()}/{TotalFiles}";
                        if (Delete)
                        {
                            File.Delete(CurrFile);
                        }
                    }
                    else
                    {
                        FileCompelte.Value++;
                        FilesDone++;
                        label1.Text = $"{FilesDone.ToString()}/{TotalFiles}";
                    }
                    await Task.Delay(50);
                }
            }
            else if (Directory.Exists($"{RoamingFolder}\\discordcanary"))
            {

                TotalFiles = Directory.GetFiles($"{RoamingFolder}\\discordcanary\\Cache").Length;
                FilesDone = 0;
                label1.Text = $"{FilesDone.ToString()}/{TotalFiles}";
                FileCompelte.Maximum = TotalFiles;
                foreach (string CurrFile in Directory.GetFiles($"{RoamingFolder}\\discordcanary\\Cache"))
                {
                    if (OmgPlsStop)
                    {
                        break;
                    }
                    if (CurrFile.Contains("f_0"))
                    {
                        File.Copy(CurrFile, $"{DiscordImg}\\{CurrFile.Substring(CurrFile.LastIndexOf("\\") + 1)}.png");
                        FileCompelte.Value++;
                        FilesDone++;
                        label1.Text = $"{FilesDone.ToString()}/{TotalFiles}";
                        if (Delete)
                        {
                            File.Delete(CurrFile);
                        }
                    }
                    else
                    {
                        FileCompelte.Value++;
                        FilesDone++;
                        label1.Text = $"{FilesDone.ToString()}/{TotalFiles}";
                    }
                    await Task.Delay(50);
                }
            }
            else
            {
                Forms.Notify("Discord not detected.", false, true);
            }
        }
    }
}
