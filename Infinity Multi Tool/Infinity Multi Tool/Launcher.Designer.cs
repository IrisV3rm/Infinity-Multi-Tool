namespace Infinity_Multi_Tool
{
    partial class Launcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher));
            this.Announcement = new System.Windows.Forms.RichTextBox();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.PercentageLabel = new System.Windows.Forms.Label();
            this.Boio = new System.Windows.Forms.RadioButton();
            this.Sniper = new System.Windows.Forms.RadioButton();
            this.DiscImage = new System.Windows.Forms.RadioButton();
            this.HashGenerator = new System.Windows.Forms.RadioButton();
            this.Credits = new System.Windows.Forms.Button();
            this.FPSUnlockerToggle = new System.Windows.Forms.RadioButton();
            this.AssetDownloader = new System.Windows.Forms.RadioButton();
            this.MultipleRobloxInstancesToggle = new System.Windows.Forms.RadioButton();
            this.DownloadTools = new System.Windows.Forms.Button();
            this.Launch = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Panel();
            this.Minimize = new System.Windows.Forms.Panel();
            this.Close = new System.Windows.Forms.Panel();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Announcement
            // 
            this.Announcement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Announcement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Announcement.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Announcement.ForeColor = System.Drawing.Color.Gainsboro;
            this.Announcement.Location = new System.Drawing.Point(4, 37);
            this.Announcement.Name = "Announcement";
            this.Announcement.ReadOnly = true;
            this.Announcement.Size = new System.Drawing.Size(179, 227);
            this.Announcement.TabIndex = 99999;
            this.Announcement.Text = "SDFSDFGSDG";
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
            this.TopPanel.Size = new System.Drawing.Size(638, 32);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // PercentageLabel
            // 
            this.PercentageLabel.AutoSize = true;
            this.PercentageLabel.ForeColor = System.Drawing.Color.White;
            this.PercentageLabel.Location = new System.Drawing.Point(192, 276);
            this.PercentageLabel.Name = "PercentageLabel";
            this.PercentageLabel.Size = new System.Drawing.Size(33, 13);
            this.PercentageLabel.TabIndex = 100005;
            this.PercentageLabel.Text = "100%";
            this.PercentageLabel.Visible = false;
            // 
            // Boio
            // 
            this.Boio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boio.ForeColor = System.Drawing.Color.Gainsboro;
            this.Boio.Image = global::Infinity_Multi_Tool.Properties.Resources.TopMostEnable;
            this.Boio.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Boio.Location = new System.Drawing.Point(202, 153);
            this.Boio.Name = "Boio";
            this.Boio.Size = new System.Drawing.Size(156, 28);
            this.Boio.TabIndex = 100012;
            this.Boio.TabStop = true;
            this.Boio.Text = "                                                             ";
            this.Boio.UseVisualStyleBackColor = true;
            this.Boio.CheckedChanged += new System.EventHandler(this.MultipleRobloxInstancesToggle_CheckedChanged);
            // 
            // Sniper
            // 
            this.Sniper.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sniper.ForeColor = System.Drawing.Color.Gainsboro;
            this.Sniper.Image = global::Infinity_Multi_Tool.Properties.Resources.NitroSniperSelector;
            this.Sniper.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Sniper.Location = new System.Drawing.Point(446, 119);
            this.Sniper.Name = "Sniper";
            this.Sniper.Size = new System.Drawing.Size(156, 28);
            this.Sniper.TabIndex = 100011;
            this.Sniper.TabStop = true;
            this.Sniper.Text = "                                                             ";
            this.Sniper.UseVisualStyleBackColor = true;
            this.Sniper.CheckedChanged += new System.EventHandler(this.MultipleRobloxInstancesToggle_CheckedChanged);
            // 
            // DiscImage
            // 
            this.DiscImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscImage.ForeColor = System.Drawing.Color.Gainsboro;
            this.DiscImage.Image = global::Infinity_Multi_Tool.Properties.Resources.DiscCacheSelector;
            this.DiscImage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DiscImage.Location = new System.Drawing.Point(202, 119);
            this.DiscImage.Name = "DiscImage";
            this.DiscImage.Size = new System.Drawing.Size(156, 28);
            this.DiscImage.TabIndex = 100010;
            this.DiscImage.TabStop = true;
            this.DiscImage.Text = "                                                             ";
            this.DiscImage.UseVisualStyleBackColor = true;
            this.DiscImage.CheckedChanged += new System.EventHandler(this.MultipleRobloxInstancesToggle_CheckedChanged);
            // 
            // HashGenerator
            // 
            this.HashGenerator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HashGenerator.ForeColor = System.Drawing.Color.Gainsboro;
            this.HashGenerator.Image = global::Infinity_Multi_Tool.Properties.Resources.MD5Gen;
            this.HashGenerator.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HashGenerator.Location = new System.Drawing.Point(446, 85);
            this.HashGenerator.Name = "HashGenerator";
            this.HashGenerator.Size = new System.Drawing.Size(156, 28);
            this.HashGenerator.TabIndex = 100009;
            this.HashGenerator.TabStop = true;
            this.HashGenerator.Text = "                                                             ";
            this.HashGenerator.UseVisualStyleBackColor = true;
            this.HashGenerator.CheckedChanged += new System.EventHandler(this.MultipleRobloxInstancesToggle_CheckedChanged);
            // 
            // Credits
            // 
            this.Credits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Credits.FlatAppearance.BorderSize = 0;
            this.Credits.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Credits.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Credits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Credits.ForeColor = System.Drawing.Color.LightGray;
            this.Credits.Image = global::Infinity_Multi_Tool.Properties.Resources.Credits;
            this.Credits.Location = new System.Drawing.Point(4, 328);
            this.Credits.Name = "Credits";
            this.Credits.Size = new System.Drawing.Size(182, 23);
            this.Credits.TabIndex = 100008;
            this.Credits.UseVisualStyleBackColor = false;
            this.Credits.Click += new System.EventHandler(this.Credits_Click);
            // 
            // FPSUnlockerToggle
            // 
            this.FPSUnlockerToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FPSUnlockerToggle.ForeColor = System.Drawing.Color.Gainsboro;
            this.FPSUnlockerToggle.Image = global::Infinity_Multi_Tool.Properties.Resources.FPSUnlocker;
            this.FPSUnlockerToggle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.FPSUnlockerToggle.Location = new System.Drawing.Point(202, 85);
            this.FPSUnlockerToggle.Name = "FPSUnlockerToggle";
            this.FPSUnlockerToggle.Size = new System.Drawing.Size(156, 28);
            this.FPSUnlockerToggle.TabIndex = 100007;
            this.FPSUnlockerToggle.TabStop = true;
            this.FPSUnlockerToggle.Text = "                                                             ";
            this.FPSUnlockerToggle.UseVisualStyleBackColor = true;
            this.FPSUnlockerToggle.CheckedChanged += new System.EventHandler(this.MultipleRobloxInstancesToggle_CheckedChanged);
            // 
            // AssetDownloader
            // 
            this.AssetDownloader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssetDownloader.ForeColor = System.Drawing.Color.Gainsboro;
            this.AssetDownloader.Image = global::Infinity_Multi_Tool.Properties.Resources.AssetDownload;
            this.AssetDownloader.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AssetDownloader.Location = new System.Drawing.Point(446, 51);
            this.AssetDownloader.Name = "AssetDownloader";
            this.AssetDownloader.Size = new System.Drawing.Size(156, 28);
            this.AssetDownloader.TabIndex = 100006;
            this.AssetDownloader.TabStop = true;
            this.AssetDownloader.Text = "                                                             ";
            this.AssetDownloader.UseVisualStyleBackColor = true;
            this.AssetDownloader.Click += new System.EventHandler(this.MultipleRobloxInstancesToggle_CheckedChanged);
            // 
            // MultipleRobloxInstancesToggle
            // 
            this.MultipleRobloxInstancesToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultipleRobloxInstancesToggle.ForeColor = System.Drawing.Color.Gainsboro;
            this.MultipleRobloxInstancesToggle.Image = global::Infinity_Multi_Tool.Properties.Resources.MultipleRobloxInstances;
            this.MultipleRobloxInstancesToggle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MultipleRobloxInstancesToggle.Location = new System.Drawing.Point(202, 51);
            this.MultipleRobloxInstancesToggle.Name = "MultipleRobloxInstancesToggle";
            this.MultipleRobloxInstancesToggle.Size = new System.Drawing.Size(156, 28);
            this.MultipleRobloxInstancesToggle.TabIndex = 100004;
            this.MultipleRobloxInstancesToggle.TabStop = true;
            this.MultipleRobloxInstancesToggle.Text = "                                                             ";
            this.MultipleRobloxInstancesToggle.UseVisualStyleBackColor = true;
            this.MultipleRobloxInstancesToggle.CheckedChanged += new System.EventHandler(this.MultipleRobloxInstancesToggle_CheckedChanged);
            // 
            // DownloadTools
            // 
            this.DownloadTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.DownloadTools.FlatAppearance.BorderSize = 0;
            this.DownloadTools.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.DownloadTools.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.DownloadTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DownloadTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadTools.ForeColor = System.Drawing.Color.LightGray;
            this.DownloadTools.Image = global::Infinity_Multi_Tool.Properties.Resources.DownloadTools;
            this.DownloadTools.Location = new System.Drawing.Point(4, 270);
            this.DownloadTools.Name = "DownloadTools";
            this.DownloadTools.Size = new System.Drawing.Size(182, 23);
            this.DownloadTools.TabIndex = 100002;
            this.DownloadTools.UseVisualStyleBackColor = false;
            this.DownloadTools.Click += new System.EventHandler(this.DownloadTools_Click);
            // 
            // Launch
            // 
            this.Launch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Launch.BackgroundImage = global::Infinity_Multi_Tool.Properties.Resources.LaunchRed;
            this.Launch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Launch.FlatAppearance.BorderSize = 0;
            this.Launch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Launch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Launch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Launch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Launch.ForeColor = System.Drawing.Color.Red;
            this.Launch.Location = new System.Drawing.Point(334, 305);
            this.Launch.Name = "Launch";
            this.Launch.Size = new System.Drawing.Size(182, 23);
            this.Launch.TabIndex = 100000;
            this.Launch.UseVisualStyleBackColor = false;
            this.Launch.Click += new System.EventHandler(this.Launch_Click);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Update.FlatAppearance.BorderSize = 0;
            this.Update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update.ForeColor = System.Drawing.Color.LightGray;
            this.Update.Image = global::Infinity_Multi_Tool.Properties.Resources.CheckForUopdates;
            this.Update.Location = new System.Drawing.Point(4, 299);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(182, 23);
            this.Update.TabIndex = 3;
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Title
            // 
            this.Title.BackgroundImage = global::Infinity_Multi_Tool.Properties.Resources.Title;
            this.Title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Title.Location = new System.Drawing.Point(-50, -100);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(263, 237);
            this.Title.TabIndex = 4;
            this.Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.Title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // Minimize
            // 
            this.Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize.BackgroundImage = global::Infinity_Multi_Tool.Properties.Resources.MacMin;
            this.Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize.Location = new System.Drawing.Point(600, 10);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(12, 12);
            this.Minimize.TabIndex = 5;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            this.Minimize.MouseEnter += new System.EventHandler(this.Minimize_MouseEnter);
            this.Minimize.MouseLeave += new System.EventHandler(this.Minimize_MouseLeave);
            // 
            // Close
            // 
            this.Close.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Close.BackgroundImage = global::Infinity_Multi_Tool.Properties.Resources.MacClose;
            this.Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Location = new System.Drawing.Point(618, 10);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(12, 12);
            this.Close.TabIndex = 4;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            this.Close.MouseEnter += new System.EventHandler(this.Close_MouseHover);
            this.Close.MouseLeave += new System.EventHandler(this.Close_MouseLeave);
            this.Close.MouseHover += new System.EventHandler(this.Close_MouseHover);
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(638, 354);
            this.Controls.Add(this.Boio);
            this.Controls.Add(this.Sniper);
            this.Controls.Add(this.DiscImage);
            this.Controls.Add(this.HashGenerator);
            this.Controls.Add(this.Credits);
            this.Controls.Add(this.FPSUnlockerToggle);
            this.Controls.Add(this.AssetDownloader);
            this.Controls.Add(this.PercentageLabel);
            this.Controls.Add(this.MultipleRobloxInstancesToggle);
            this.Controls.Add(this.DownloadTools);
            this.Controls.Add(this.Launch);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Announcement);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Launcher";
            this.Text = "MutliTool Launcher";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Launcher_FormClosing);
            this.Load += new System.EventHandler(this.Launcher_Load);
            this.TopPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox Announcement;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel Close;
        private System.Windows.Forms.Panel Minimize;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Panel Title;
        private System.Windows.Forms.Button Launch;
        private System.Windows.Forms.Button DownloadTools;
        private System.Windows.Forms.RadioButton MultipleRobloxInstancesToggle;
        private System.Windows.Forms.Label PercentageLabel;
        private System.Windows.Forms.RadioButton AssetDownloader;
        private System.Windows.Forms.RadioButton FPSUnlockerToggle;
        private System.Windows.Forms.Button Credits;
        private System.Windows.Forms.RadioButton HashGenerator;
        private System.Windows.Forms.RadioButton DiscImage;
        private System.Windows.Forms.RadioButton Sniper;
        private System.Windows.Forms.RadioButton Boio;
    }
}

