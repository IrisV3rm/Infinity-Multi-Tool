namespace Infinity_Multi_Tool
{
    partial class TopMostBoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopMostBoi));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Panel();
            this.Minimize = new System.Windows.Forms.Panel();
            this.Close = new System.Windows.Forms.Panel();
            this.ProcessBox = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PName = new System.Windows.Forms.Label();
            this.PID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MD5Hash = new System.Windows.Forms.Button();
            this.TopPanel.SuspendLayout();
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
            this.TopPanel.Size = new System.Drawing.Size(509, 32);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.TopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // Title
            // 
            this.Title.BackgroundImage = global::Infinity_Multi_Tool.Properties.Resources.Title;
            this.Title.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Title.Location = new System.Drawing.Point(-50, -100);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(312, 237);
            this.Title.TabIndex = 6;
            this.Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            this.Title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseUp);
            // 
            // Minimize
            // 
            this.Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize.BackgroundImage = global::Infinity_Multi_Tool.Properties.Resources.MacMin;
            this.Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize.Location = new System.Drawing.Point(471, 10);
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
            this.Close.Location = new System.Drawing.Point(489, 10);
            this.Close.MaximumSize = new System.Drawing.Size(12, 12);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(12, 12);
            this.Close.TabIndex = 4;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            this.Close.MouseEnter += new System.EventHandler(this.Close_MouseHover);
            this.Close.MouseLeave += new System.EventHandler(this.Close_MouseLeave);
            this.Close.MouseHover += new System.EventHandler(this.Close_MouseHover);
            // 
            // ProcessBox
            // 
            this.ProcessBox.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.ProcessBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ProcessBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProcessBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.ProcessBox.ForeColor = System.Drawing.Color.LightGray;
            this.ProcessBox.HideSelection = false;
            this.ProcessBox.Location = new System.Drawing.Point(12, 40);
            this.ProcessBox.MultiSelect = false;
            this.ProcessBox.Name = "ProcessBox";
            this.ProcessBox.Size = new System.Drawing.Size(197, 233);
            this.ProcessBox.TabIndex = 1;
            this.ProcessBox.UseCompatibleStateImageBehavior = false;
            this.ProcessBox.View = System.Windows.Forms.View.Details;
            this.ProcessBox.SelectedIndexChanged += new System.EventHandler(this.ProcessBox_SelectedIndexChanged);
            this.ProcessBox.DoubleClick += new System.EventHandler(this.ProcessBox_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Processes";
            this.columnHeader1.Width = 186;
            // 
            // PName
            // 
            this.PName.AutoSize = true;
            this.PName.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PName.ForeColor = System.Drawing.Color.LightGray;
            this.PName.Location = new System.Drawing.Point(215, 87);
            this.PName.Name = "PName";
            this.PName.Size = new System.Drawing.Size(120, 18);
            this.PName.TabIndex = 2;
            this.PName.Text = "Proccess Name:";
            // 
            // PID
            // 
            this.PID.AutoSize = true;
            this.PID.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PID.ForeColor = System.Drawing.Color.LightGray;
            this.PID.Location = new System.Drawing.Point(215, 118);
            this.PID.Name = "PID";
            this.PID.Size = new System.Drawing.Size(40, 18);
            this.PID.TabIndex = 3;
            this.PID.Text = "PID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(215, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total Time Ussage:";
            // 
            // MD5Hash
            // 
            this.MD5Hash.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MD5Hash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.MD5Hash.FlatAppearance.BorderSize = 0;
            this.MD5Hash.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MD5Hash.ForeColor = System.Drawing.Color.LightGray;
            this.MD5Hash.Location = new System.Drawing.Point(297, 225);
            this.MD5Hash.Name = "MD5Hash";
            this.MD5Hash.Size = new System.Drawing.Size(119, 23);
            this.MD5Hash.TabIndex = 5;
            this.MD5Hash.Text = "Toggle TopMost";
            this.MD5Hash.UseVisualStyleBackColor = false;
            this.MD5Hash.Click += new System.EventHandler(this.MD5Hash_Click);
            // 
            // TopMostBoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(509, 285);
            this.Controls.Add(this.MD5Hash);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PID);
            this.Controls.Add(this.PName);
            this.Controls.Add(this.ProcessBox);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TopMostBoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MutliTool Launcher";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.TopMostBoi_Load);
            this.TopPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel Close;
        private System.Windows.Forms.Panel Minimize;
        private System.Windows.Forms.Panel Title;
        private System.Windows.Forms.ListView ProcessBox;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label PName;
        private System.Windows.Forms.Label PID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MD5Hash;
    }
}

