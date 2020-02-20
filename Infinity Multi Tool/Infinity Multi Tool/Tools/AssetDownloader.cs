﻿using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Infinity_Multi_Tool.Properties;

namespace Infinity_Multi_Tool
{
    public partial class AssetDownloader : Form
    {
        private string MainDirectory = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\InfTools";
        private string AudioURL;
        private bool MouseDown = false;
        private Point LastLocation;
        private bool Resizing;
        private bool Loaded = false;
        private string CurrentSelection;
        public AssetDownloader()
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

        private void BottomPanel_MouseDown(object sender, MouseEventArgs e)
        {
            Resizing = true;
        }

        private void BottomPanel_MouseUp(object sender, MouseEventArgs e)
        {
            Resizing = false;
        }

        private void BottomPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (Resizing)
            {
                int w = Size.Width;
                int h = Size.Height;

                if (Cursor.Current.ToString() == "[Cursor: SizeNS]")
                {
                    Size = new Size(w, h + (e.Location.Y));
                }
                else if (Cursor.Current.ToString() == "[Cursor: SizeWE]")
                {
                    Size = new Size(w + (e.Location.X), h);
                }
                else if (Cursor.Current.ToString() == "[Cursor: SizeNWSE]")
                {
                    Size = new Size(w + (e.Location.X), h + (e.Location.Y));
                }
            }
        }

        private String GetUrl(string Data)
        {
            string Source = Data;

            var pfrom = Source.IndexOf("data-mediathumb-url=\"") + "data-mediathumb-url=\"".Length;
            var pto = Source.LastIndexOf("asset-status-icon") - 62;

            return Source.Substring(pfrom, pto - pfrom);
        }
        private String GetShirtAsset(string Data)
        {
            string Source = Data;

            var pfrom = Source.IndexOf("<url>") + "<url>".Length;
            var pto = Source.LastIndexOf("</url>");

            return Source.Substring(pfrom, pto - pfrom);
        }
        private async void AudioDown(string ID)
        {
            try
            {
                Loaded = false;
                Browser.Url = new Uri($"https://www.roblox.com/library/{ID}/#");

                while (!Loaded)
                {
                    await Task.Delay(50);
                }

                AudioURL = GetUrl(Browser.DocumentText);
                string SongName = Browser.Url.ToString().Replace("#", "")
                    .Substring(Browser.Url.ToString().LastIndexOf("/") + 1);
                if (!Directory.Exists($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\AssetDownloader\\Audio")) Directory.CreateDirectory($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\AssetDownloader\\Audio");

                using (WebClient Web = new WebClient())
                {
                    Web.DownloadFile(AudioURL, $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\AssetDownloader\\Audio\\{SongName}_{ID}.mp3");
                    DialogResult dialog = Forms.Notify("Audio has finished downloading, would you like to open the directory?", true, false);
                    if (dialog == DialogResult.Yes)
                    {
                        Process.Start("explorer.exe",
                            $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\AssetDownloader\\Audio\\");
                    }
                }
            }
            catch
            {
                Forms.Notify("Failed to download, do you have the correct ID?", false, true);
            }
        }
        

        private void Browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Loaded = true;
        }

        private void Shirts(string ItemID)
        {
            try
            {
                if (!Directory.Exists(
                    $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\AssetDownloader\\Shirts"))
                    Directory.CreateDirectory(
                        $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\AssetDownloader\\Shirts");

                string ID = $"https://www.roblox.com/asset/?id={ItemID}";
                string FileSource;
                using (WebClient web = new WebClient())
                {
                    web.DownloadFile(ID, $"{MainDirectory}\\TempFiles\\{ItemID}");
                }

                FileSource = File.ReadAllText($"{MainDirectory}\\TempFiles\\{ItemID}");

                if (FileSource.Contains("<url>"))
                {
                    using (WebClient Web = new WebClient())
                    {
                        File.Delete($"{MainDirectory}\\TempFiles\\{ItemID}");
                        Web.DownloadFile(GetShirtAsset(FileSource),
                            $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\AssetDownloader\\Shirts\\{ItemID}.png");
                        DialogResult dialog =
                            Forms.Notify(
                                "Shirt template has finished downloading, would you like to open the directory?", true,
                                false);
                        if (dialog == DialogResult.Yes)
                        {
                            Process.Start("explorer.exe",
                                $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\AssetDownloader\\Shirts\\");
                        }
                    }
                }
                else
                {
                    File.Move($"{MainDirectory}\\TempFiles\\{ItemID}",
                        $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\AssetDownloader\\Shirts\\{ItemID}.png");
                    DialogResult dialog =
                        Forms.Notify("Shirt template has finished downloading, would you like to open the directory?",
                            true, false);
                    if (dialog == DialogResult.Yes)
                    {
                        Process.Start("explorer.exe",
                            $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\AssetDownloader\\Shirts\\");
                    }
                }
            }
            catch
            {
                Forms.Notify("Failed to download, do you have the correct ID?", false, true);
            }
        }

        private void Pant(string ItemID)
        {
            try
            {
                if (!Directory.Exists(
                    $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\AssetDownloader\\Pants"))
                    Directory.CreateDirectory(
                        $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\AssetDownloader\\Pants");

                string ID = $"https://www.roblox.com/asset/?id={ItemID}";
                string FileSource;
                using (WebClient web = new WebClient())
                {
                    web.DownloadFile(ID, $"{MainDirectory}\\TempFiles\\{ItemID}");
                }

                FileSource = File.ReadAllText($"{MainDirectory}\\TempFiles\\{ItemID}");

                if (FileSource.Contains("<url>"))
                {
                    using (WebClient Web = new WebClient())
                    {
                        File.Delete($"{MainDirectory}\\TempFiles\\{ItemID}");
                        Web.DownloadFile(GetShirtAsset(FileSource),
                            $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\AssetDownloader\\Pants\\{ItemID}.png");
                        DialogResult dialog =
                            Forms.Notify(
                                "Pants template has finished downloading, would you like to open the directory?", true,
                                false);
                        if (dialog == DialogResult.Yes)
                        {
                            Process.Start("explorer.exe",
                                $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\AssetDownloader\\Pants");
                        }
                    }
                }
                else
                {
                    File.Move($"{MainDirectory}\\TempFiles\\{ItemID}",
                        $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\AssetDownloader\\Pants\\{ItemID}.png");
                    DialogResult dialog =
                        Forms.Notify("Pants template has finished downloading, would you like to open the directory?",
                            true, false);
                    if (dialog == DialogResult.Yes)
                    {
                        Process.Start("explorer.exe",
                            $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\AssetDownloader\\Pants");
                    }
                }

            }
            catch
            {
                Forms.Notify("Failed to download, do you have the correct ID?", false, true);
            }
        }

        private void AccessorySave(string ID)
        {
            try { 
                if (!Directory.Exists($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\AssetDownloader\\Accessories")) Directory.CreateDirectory($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\AssetDownloader\\Accessories");

                using (WebClient web = new WebClient())
                {
                    web.DownloadFile($"https://www.roblox.com/asset/?id={ID}", $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\AssetDownloader\\Accessories\\{ID}.rbxm");
                }
                DialogResult dialog = Forms.Notify("Accessory has finished downloading, would you like to open the directory?", true, false);
                if (dialog == DialogResult.Yes)
                {
                    Process.Start("explorer.exe",
                        $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\AssetDownloader\\Accessories");
                }
            }
            catch
            {
                Forms.Notify("Failed to download, do you have the correct ID?", false, true);
            }
        }
        private void Faces(string ItemID)
        {
            try
            {
                if (!Directory.Exists(
                    $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\AssetDownloader\\Faces"))
                    Directory.CreateDirectory(
                        $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\AssetDownloader\\Faces");

                string ID = $"https://www.roblox.com/asset/?id={ItemID}";
                string FileSource;
                using (WebClient web = new WebClient())
                {
                    web.DownloadFile(ID, $"{MainDirectory}\\TempFiles\\{ItemID}");
                }

                FileSource = File.ReadAllText($"{MainDirectory}\\TempFiles\\{ItemID}");

                if (FileSource.Contains("<url>"))
                {
                    using (WebClient Web = new WebClient())
                    {
                        File.Delete($"{MainDirectory}\\TempFiles\\{ItemID}");
                        Web.DownloadFile(GetShirtAsset(FileSource),
                            $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\AssetDownloader\\Faces\\{ItemID}.png");
                        DialogResult dialog =
                            Forms.Notify("Face has finished downloading, would you like to open the directory?", true,
                                false);
                        if (dialog == DialogResult.Yes)
                        {
                            Process.Start("explorer.exe",
                                $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\AssetDownloader\\Faces");
                        }
                    }
                }
                else
                {
                    File.Move($"{MainDirectory}\\TempFiles\\{ItemID}",
                        $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\AssetDownloader\\Faces\\{ItemID}.png");
                    DialogResult dialog =
                        Forms.Notify("Face has finished downloading, would you like to open the directory?", true,
                            false);
                    if (dialog == DialogResult.Yes)
                    {
                        Process.Start("explorer.exe",
                            $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\AssetDownloader\\Faces");
                    }
                }
            }
            catch
            {
                Forms.Notify("Failed to download, do you have the correct ID?", false, true);
            }
        }
        
        private void Animations(string ID)
        {
            try
            {
                if (!Directory.Exists(
                    $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\AssetDownloader\\Animations"))
                {
                    Directory.CreateDirectory(
                        $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\AssetDownloader\\Animations");
                    File.WriteAllText(
                        $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\AssetDownloader\\Animations\\_README.txt",
                        "TO GET THE KEYFRAMES PUT THE RBXM INTO STUDIO, COPY THE ANIMATION ID AND REDOWNLOAD");
                }

                using (WebClient web = new WebClient())
                {
                    web.DownloadFile($"https://www.roblox.com/asset/?id={ID}",
                        $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\AssetDownloader\\Animations\\{ID}.rbxm");
                }

                DialogResult dialog =
                    Forms.Notify("Accessory has finished downloading, would you like to open the directory?", true,
                        false);
                if (dialog == DialogResult.Yes)
                {
                    Process.Start("explorer.exe",
                        $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\\AssetDownloader\\Animations");
                }
            } 
            catch
            {
                Forms.Notify("Failed to download, do you have the correct ID?", false, true);
            }
        }
        private void RemoveText(object sender, EventArgs e)
        {
            if (textBox1.Text == "Asset ID")
            {
                textBox1.Text = "";
            }
        }

        private void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
                textBox1.Text = "Asset ID";
        }

        private void InitSave(string Type, string ID)
        {
            if (Type == "Accessory")
            {
                AccessorySave(ID);
            }
            else if (Type == "Face") 
            {
                Faces(ID);
            }
            else if (Type == "Animation") 
            {
                Animations(ID);
            }
            else if (Type == "Pants")
            {
                Pant(ID);
            }
            else if (Type == "Shirt")
            {
                Shirts(ID);
            }
            else if (Type == "Audio")
            {
                AudioDown(ID);
            }
            else
            {
                Forms.Notify("No type selected, please select one first!", false, true);
            }

        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            RadioButton CurrentButton = sender as RadioButton;
            CurrentSelection = CurrentButton.Name;
        }

        private void Download_Click(object sender, EventArgs e)
        {
            string ID = textBox1.Text.Replace(" ", "");
            if (long.TryParse(ID, out long NewID))
            {
                InitSave(CurrentSelection, NewID.ToString());
            }
            else
            {
                Forms.Notify("Invalid ID, please only insert the numbers! (123432)", false, true);
            }
        }

        private void AssetDownloader_Load(object sender, EventArgs e)
        {

        }
    }
}
