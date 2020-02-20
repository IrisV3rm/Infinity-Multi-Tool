namespace Infinity_Multi_Tool
{
    partial class NitroSnipin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NitroSnipin));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Panel();
            this.Minimize = new System.Windows.Forms.Panel();
            this.Close = new System.Windows.Forms.Panel();
            this.LoginBegin = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DiscordToken = new System.Windows.Forms.TextBox();
            this.LogBox = new VertexFramework.UIControls.VRichTextBox();
            this.Bottom = new System.Windows.Forms.Panel();
            this.BottomRight = new System.Windows.Forms.Panel();
            this.Right = new System.Windows.Forms.Panel();
            this.Logout = new System.Windows.Forms.Button();
            this.TopPanel.SuspendLayout();
            this.Bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TopPanel.Controls.Add(this.Title);
            this.TopPanel.Controls.Add(this.Minimize);
            this.TopPanel.Controls.Add(this.Close);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(653, 32);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // Title
            // 
            this.Title.BackgroundImage = global::Infinity_Multi_Tool.Properties.Resources.Title;
            this.Title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Title.Location = new System.Drawing.Point(-50, -100);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(263, 237);
            this.Title.TabIndex = 6;
            // 
            // Minimize
            // 
            this.Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize.BackgroundImage = global::Infinity_Multi_Tool.Properties.Resources.MacMin;
            this.Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize.Location = new System.Drawing.Point(615, 10);
            this.Minimize.MaximumSize = new System.Drawing.Size(12, 12);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(12, 12);
            this.Minimize.TabIndex = 5;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            this.Minimize.MouseEnter += new System.EventHandler(this.Minimize_MouseEnter);
            this.Minimize.MouseLeave += new System.EventHandler(this.Minimize_MouseLeave);
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.BackgroundImage = global::Infinity_Multi_Tool.Properties.Resources.MacClose;
            this.Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Location = new System.Drawing.Point(633, 10);
            this.Close.MaximumSize = new System.Drawing.Size(12, 12);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(12, 12);
            this.Close.TabIndex = 4;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            this.Close.MouseEnter += new System.EventHandler(this.Close_MouseHover);
            this.Close.MouseLeave += new System.EventHandler(this.Close_MouseLeave);
            this.Close.MouseHover += new System.EventHandler(this.Close_MouseHover);
            // 
            // LoginBegin
            // 
            this.LoginBegin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.LoginBegin.FlatAppearance.BorderSize = 0;
            this.LoginBegin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoginBegin.ForeColor = System.Drawing.Color.LightGray;
            this.LoginBegin.Location = new System.Drawing.Point(34, 69);
            this.LoginBegin.Name = "LoginBegin";
            this.LoginBegin.Size = new System.Drawing.Size(265, 23);
            this.LoginBegin.TabIndex = 6;
            this.LoginBegin.Text = "Login";
            this.LoginBegin.UseVisualStyleBackColor = false;
            this.LoginBegin.Click += new System.EventHandler(this.LoginBegin_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.Color.LightGray;
            this.textBox1.Location = new System.Drawing.Point(221, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Asset ID";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DiscordToken
            // 
            this.DiscordToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DiscordToken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.DiscordToken.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DiscordToken.ForeColor = System.Drawing.Color.LightGray;
            this.DiscordToken.Location = new System.Drawing.Point(105, 43);
            this.DiscordToken.Name = "DiscordToken";
            this.DiscordToken.Size = new System.Drawing.Size(443, 20);
            this.DiscordToken.TabIndex = 7;
            this.DiscordToken.Text = "Discord Token";
            this.DiscordToken.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DiscordToken.Enter += new System.EventHandler(this.AddText);
            this.DiscordToken.Leave += new System.EventHandler(this.RemoveText);
            // 
            // LogBox
            // 
            this.LogBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogBox.BackColor = System.Drawing.Color.Black;
            this.LogBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogBox.ForeColor = System.Drawing.Color.Black;
            this.LogBox.Location = new System.Drawing.Point(13, 101);
            this.LogBox.Name = "LogBox";
            this.LogBox.ReadOnly = true;
            this.LogBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.LogBox.Size = new System.Drawing.Size(628, 240);
            this.LogBox.TabIndex = 8;
            this.LogBox.Text = "";
            this.LogBox.TextChanged += new System.EventHandler(this.LogBox_TextChanged);
            // 
            // Bottom
            // 
            this.Bottom.Controls.Add(this.BottomRight);
            this.Bottom.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Bottom.Location = new System.Drawing.Point(0, 343);
            this.Bottom.Name = "Bottom";
            this.Bottom.Size = new System.Drawing.Size(653, 10);
            this.Bottom.TabIndex = 9;
            this.Bottom.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BottomPanel_MouseDown);
            this.Bottom.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BottomPanel_MouseMove);
            this.Bottom.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BottomPanel_MouseUp);
            // 
            // BottomRight
            // 
            this.BottomRight.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.BottomRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.BottomRight.Location = new System.Drawing.Point(643, 0);
            this.BottomRight.Name = "BottomRight";
            this.BottomRight.Size = new System.Drawing.Size(10, 10);
            this.BottomRight.TabIndex = 0;
            this.BottomRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BottomPanel_MouseDown);
            this.BottomRight.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BottomPanel_MouseMove);
            this.BottomRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BottomPanel_MouseUp);
            // 
            // Right
            // 
            this.Right.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.Right.Location = new System.Drawing.Point(643, 32);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(10, 311);
            this.Right.TabIndex = 10;
            this.Right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BottomPanel_MouseDown);
            this.Right.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BottomPanel_MouseMove);
            this.Right.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BottomPanel_MouseUp);
            // 
            // Logout
            // 
            this.Logout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Logout.FlatAppearance.BorderSize = 0;
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Logout.ForeColor = System.Drawing.Color.LightGray;
            this.Logout.Location = new System.Drawing.Point(341, 69);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(265, 23);
            this.Logout.TabIndex = 11;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // NitroSnipin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(653, 353);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Right);
            this.Controls.Add(this.Bottom);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.DiscordToken);
            this.Controls.Add(this.LoginBegin);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(653, 353);
            this.Name = "NitroSnipin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MutliTool Launcher";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.NitroSnipin_Load);
            this.TopPanel.ResumeLayout(false);
            this.Bottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel Close;
        private System.Windows.Forms.Panel Minimize;
        private System.Windows.Forms.Panel Title;
        private System.Windows.Forms.Button LoginBegin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox DiscordToken;
        private VertexFramework.UIControls.VRichTextBox LogBox;
        private System.Windows.Forms.Panel Bottom;
        private System.Windows.Forms.Panel BottomRight;
        private System.Windows.Forms.Panel Right;
        private System.Windows.Forms.Button Logout;
    }
}

