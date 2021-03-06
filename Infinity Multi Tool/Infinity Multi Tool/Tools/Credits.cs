﻿using System;
using System.Drawing;
using System.Windows.Forms;
using Infinity_Multi_Tool.Properties;

namespace Infinity_Multi_Tool
{
    public partial class Credits : Form
    {
        private Point LastLocation;
        private bool MouseDown;
        public Credits()
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
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
