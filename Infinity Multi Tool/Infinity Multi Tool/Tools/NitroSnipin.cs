using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using Infinity_Multi_Tool.Properties;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Discord.Gateway;
using Discord;
using System.Threading;
using System.Threading.Tasks;

namespace Infinity_Multi_Tool
{
    public partial class NitroSnipin : Form
    {
        private Point LastLocation;
        private bool MouseDown;
        private bool Resizing;
        private string MainDirectory = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\InfTools";
        DiscordSocketClient _client = new DiscordSocketClient();
        DiscordClient Client = new DiscordClient();
        private string FinalToken = "";
        public NitroSnipin()
        {
            InitializeComponent();
        }
        public string GetToken()
        {
            string Token;
            string Tokens = "";
            var files = SearchForFile(); // to get ldb files
            if (files.Count == 0)
            {
                Forms.Notify("Could not automatically find token.", false, true);
                return "";
            }
            foreach (string token in files)
            {
                foreach (Match match in Regex.Matches(token, "[^\"]*"))
                {
                    Task.Delay(1000);
                    if (match.ToString().Length == 59)
                    {
                        using (StreamWriter Writer = new StreamWriter($"{MainDirectory}\\TempFiles\\TokenData.txt"))
                        {
                            try
                            {
                                string p1 = string.Join(" ", match.ToString());
                                string Final = p1.Substring(p1.IndexOf(".") - 24);
                                if (Final.Length == 59)
                                {
                                    Tokens = Tokens + "|" + Final;
                                }
                            }
                            catch { }
                        }
                    }
                }

                FinalToken = Tokens.Substring(Tokens.LastIndexOf("|")).Replace("|", "");
            }
            try
            {
                _client.Login(FinalToken);
            }
            catch
            {
                Forms.Notify("Token could not be found.", false, true);
                DiscordToken.Text = "Discord Token";
                return "";
            }
            Forms.Notify("Automatically Found token!", false, true);
            DiscordToken.Text = FinalToken;
            DiscordToken.Text.Replace(" ", "").Replace("\n", "");
            return FinalToken;
        }

        private List<string> SearchForFile()
        {
            List<string> ldbFiles = new List<string>();
            string discordPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Discord\\Local Storage\\leveldb\\";

            if (!Directory.Exists(discordPath))
            {
                Console.WriteLine("Discord path not found");
                return ldbFiles;
            }

            foreach (string file in Directory.GetFiles(discordPath, "*.ldb", SearchOption.TopDirectoryOnly))
            {
                string rawText = File.ReadAllText(file);
                if (rawText.Contains("oken"))
                {
                    ldbFiles.Add(rawText);
                }
            }
            return ldbFiles;
        }
        public void Log(string message, int type)
        {
            BeginInvoke((MethodInvoker)delegate ()
            {
                if (type == 1)
                {
                    LogBox.BindText(Color.DimGray, $"{ "[" + DateTime.Now.ToString("h:mm:ss") + "]"} ");
                    LogBox.BindText(Color.DimGray, "[");
                    LogBox.BindText(Color.DimGray, "SYSTEM");
                    LogBox.BindText(Color.DimGray, "] -");
                    LogBox.BindText(Color.White, " " + message + "\n");
                }
                else if (type == 2)
                {
                    LogBox.BindText(Color.DimGray, $"{ "[" + DateTime.Now.ToString("h:mm:ss") + "]"} ");
                    LogBox.BindText(Color.DimGray, "[");
                    LogBox.BindText(Color.DimGray, "LOG");
                    LogBox.BindText(Color.DimGray, "] -");
                    LogBox.BindText(Color.FromArgb(85, 136, 238), " " + message + "\n");
                }
                else if (type == 3)
                {
                    LogBox.BindText(Color.DimGray, $"{ "[" + DateTime.Now.ToString("h:mm:ss") + "]"} ");
                    LogBox.BindText(Color.DimGray, "[");
                    LogBox.BindText(Color.DimGray, "ERROR");
                    LogBox.BindText(Color.DimGray, "] -");
                    LogBox.BindText(Color.Red, " " + message + "\n");
                }
            });
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
            Forms.Launcher.Show();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void RemoveText(object sender, EventArgs e)
        {
            if (textBox1.Text == "Discord Token")
            {
                textBox1.Text = "";
            }
        }

        private void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
                textBox1.Text = "Discord Token";
        }

        public bool SignIn(string Token)
        {

            return false;
        }

        private void NitroSnipin_Load(object sender, EventArgs e)
        {
            GetToken();
            Log("Initiating log...", 1);
        }

        private void LoginBegin_Click(object sender, EventArgs e)
        {
            Log("Signing in...", 2);

            try
            {
                _client.Login(DiscordToken.Text);
                Client.Token = DiscordToken.Text;
            }
            catch
            {
                Forms.Notify("Failed to sign in!", false, true);
                return;
            }
            Log($"Signed in with token: {DiscordToken.Text}", 2);
            Log($"Server setup...", 2);
            _client.OnMessageReceived += _client_OnMessageReceived;
            ServerSetup();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Log($"Logging out of token: {DiscordToken.Text}", 2);
            _client.Logout();
        }

        private void GuildSetup(PartialGuild guild)
        {
            Log($"Setting up server: {guild.Name}",2);
        }

        private void _client_OnMessageReceived(DiscordSocketClient client, MessageEventArgs args)
        {
            try
            {
                if (args.Message.Content.Contains("discord.gift"))
                {
                    Log("Gift found", 2);
                    string p1 = args.Message.Content.Substring(args.Message.Content.IndexOf("discord.gift"));
                    string p2 = p1.Substring(p1.IndexOf("discord.gift"), p1.IndexOf(" "));
                    string p3 = p2.Substring(p2.IndexOf("/"));
                    string Final = p3.Replace("/", "");
                    Log($"Gift link code: {Final}", 2);
                    Log($"Attempting to redeem code: {Final}", 2);
                    try
                    {
                        Client.RedeemNitroGift(Final);
                    }
                    catch
                    {
                        Log("Code either invalid or api rate limit.", 3);
                        return;
                    }
                }
            }
            catch
            {
                Log("You shouldn't see this", 3);
            }
        }

        private void ServerSetup()
        {
            foreach (PartialGuild Guild in Client.GetGuilds())
            {
                GuildSetup(Guild);
            }
            Log("All servers setup!", 2);
        }

        private void LogBox_TextChanged(object sender, EventArgs e)
        {
            LogBox.SelectionStart = LogBox.Text.Length;
            LogBox.ScrollToCaret();
        }
    }
}
