using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using Infinity_Multi_Tool.Properties;

namespace Infinity_Multi_Tool
{
    public partial class HashGen : Form
    {
        private Point LastLocation;
        private bool MouseDown;
        public HashGen()
        {
            InitializeComponent();
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

        private void Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(OutputBox.Text);
            Forms.Notify("Hash copied to clipboard!", false, true);
        }
        static string GetMd5Hash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
        static string GetMd5Hashs(byte[] data)
        {
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

        private void MD5Hash_Click(object sender, EventArgs e)
        {
            using (MD5 Hash = MD5.Create())
            { 
                OutputBox.Text = GetMd5Hash(Hash, InputBox.Text);
            }
        }

        private void Sha512Hash_Click(object sender, EventArgs e)
        {
            byte[] String = Encoding.UTF8.GetBytes(InputBox.Text);

            OutputBox.Text = GetMd5Hashs(new SHA512Managed().ComputeHash(String));
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
