using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Infinity_Multi_Tool.Properties;

namespace Infinity_Multi_Tool
{
    public partial class TopMostBoi : Form
    {
        private Point LastLocation;
        private bool MouseDown;
        private bool Selected;
        private IntPtr Handle;
        static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        static readonly IntPtr HWND_NOTOPMOST = new IntPtr(-2);
        const UInt32 SWP_NOSIZE = 0x0001;
        const UInt32 SWP_NOMOVE = 0x0002;
        const UInt32 SWP_SHOWWINDOW = 0x0040;

        [DllImport("user32.dll", SetLastError = true)] 
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        const int GWL_EXSTYLE = -20;
        const int WS_EX_TOPMOST = 0x0008;

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
        public static bool IsWindowTopMost(IntPtr hWnd)
        {
            int exStyle = GetWindowLong(hWnd, GWL_EXSTYLE);
            return (exStyle & WS_EX_TOPMOST) == WS_EX_TOPMOST;
        }
        public TopMostBoi()
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

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void TopMostBoi_Load(object sender, EventArgs e)
        {
            Process[] allProc = Process.GetProcesses();
            foreach (Process p in allProc)
            {
                if (p.ProcessName != "svchost" && p.ProcessName != "crss" && p.ProcessName != "conhost" && p.ProcessName != "winlogon" && p.ProcessName != "dwm" && p.ProcessName != "dllhost" && p.ProcessName != "SearchUI" && p.ProcessName != "smartscreen")
                {
                    ProcessBox.Items.Add(p.ProcessName);
                }
            }
        }

        private void ProcessBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ProcessBox_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Process[] SelectedProc = Process.GetProcessesByName($"{ProcessBox.SelectedItems[0].Text}");
                foreach (var Proc in SelectedProc)
                {
                    PName.Text = $"Process Name: {Proc.ProcessName}";
                    PID.Text = $"PID: {Proc.Id}";
                    label1.Text = $"Total Time Ussage: {Proc.TotalProcessorTime}";
                    Handle = Proc.MainWindowHandle;
                    Selected = true;
                    break;
                }
            }
            catch
            {
                Forms.Notify($"Could not grab process data, given process: {ProcessBox.SelectedItems[0].Text}", false, true);
            }
        }

        private void MD5Hash_Click(object sender, EventArgs e)
        {
            if (!Selected)
            {
                Forms.Notify("Please double click a process on the left!", false, true);
                return;
            }
            try
            {
                if (IsWindowTopMost(Handle))
                {
                    SetWindowPos(Handle, HWND_NOTOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE | SWP_SHOWWINDOW);
                    Forms.Notify($"{PName.Text.Replace("Process Name: ", "")} is no longer topmost.", false, true);
                }
                else
                {
                    SetWindowPos(Handle, HWND_TOPMOST, 0, 0, 0, 0, SWP_NOMOVE | SWP_NOSIZE | SWP_SHOWWINDOW);
                    Forms.Notify($"{PName.Text.Replace("Process Name: ", "")} is now topmost.", false, true);
                }
            }
            catch { }
        }
    }
}
