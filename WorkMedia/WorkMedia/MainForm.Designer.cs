namespace WorkMedia
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel_header = new System.Windows.Forms.Panel();
            this.label_TabHeader = new System.Windows.Forms.Label();
            this.picbox_report = new System.Windows.Forms.PictureBox();
            this.picbox_close = new System.Windows.Forms.PictureBox();
            this.label_WorkMedia = new System.Windows.Forms.Label();
            this.panel_headerStrip = new System.Windows.Forms.Panel();
            this.panel_tabs = new System.Windows.Forms.Panel();
            this.panel_ActiveTab = new System.Windows.Forms.Panel();
            this.picbox_settings = new System.Windows.Forms.PictureBox();
            this.picbox_log = new System.Windows.Forms.PictureBox();
            this.picbox_poll = new System.Windows.Forms.PictureBox();
            this.picbox_event = new System.Windows.Forms.PictureBox();
            this.picbox_post = new System.Windows.Forms.PictureBox();
            this.picbox_messages = new System.Windows.Forms.PictureBox();
            this.picbox_teams = new System.Windows.Forms.PictureBox();
            this.picbox_contacts = new System.Windows.Forms.PictureBox();
            this.picbox_home = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.picBox_UpArrow = new System.Windows.Forms.PictureBox();
            this.picBox_DownArrow = new System.Windows.Forms.PictureBox();
            this.btn_check = new System.Windows.Forms.Button();
            this.panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_report)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_close)).BeginInit();
            this.panel_tabs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_log)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_poll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_event)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_post)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_messages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_teams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_contacts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_UpArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_DownArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.Brown;
            this.panel_header.Controls.Add(this.label_TabHeader);
            this.panel_header.Controls.Add(this.picbox_report);
            this.panel_header.Controls.Add(this.picbox_close);
            this.panel_header.Controls.Add(this.label_WorkMedia);
            this.panel_header.Controls.Add(this.panel_headerStrip);
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1000, 70);
            this.panel_header.TabIndex = 0;
            // 
            // label_TabHeader
            // 
            this.label_TabHeader.BackColor = System.Drawing.Color.Transparent;
            this.label_TabHeader.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TabHeader.ForeColor = System.Drawing.Color.LightCoral;
            this.label_TabHeader.Location = new System.Drawing.Point(3, 17);
            this.label_TabHeader.Name = "label_TabHeader";
            this.label_TabHeader.Size = new System.Drawing.Size(241, 36);
            this.label_TabHeader.TabIndex = 7;
            this.label_TabHeader.Text = "Tab Header";
            this.label_TabHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picbox_report
            // 
            this.picbox_report.Image = ((System.Drawing.Image)(resources.GetObject("picbox_report.Image")));
            this.picbox_report.Location = new System.Drawing.Point(889, 8);
            this.picbox_report.Name = "picbox_report";
            this.picbox_report.Size = new System.Drawing.Size(51, 49);
            this.picbox_report.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox_report.TabIndex = 6;
            this.picbox_report.TabStop = false;
            this.picbox_report.Click += new System.EventHandler(this.picbox_report_Click);
            // 
            // picbox_close
            // 
            this.picbox_close.Image = ((System.Drawing.Image)(resources.GetObject("picbox_close.Image")));
            this.picbox_close.Location = new System.Drawing.Point(946, 8);
            this.picbox_close.Name = "picbox_close";
            this.picbox_close.Size = new System.Drawing.Size(51, 49);
            this.picbox_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox_close.TabIndex = 5;
            this.picbox_close.TabStop = false;
            this.picbox_close.Click += new System.EventHandler(this.picbox_close_Click);
            // 
            // label_WorkMedia
            // 
            this.label_WorkMedia.BackColor = System.Drawing.Color.Transparent;
            this.label_WorkMedia.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_WorkMedia.ForeColor = System.Drawing.Color.LightCoral;
            this.label_WorkMedia.Location = new System.Drawing.Point(351, 0);
            this.label_WorkMedia.Name = "label_WorkMedia";
            this.label_WorkMedia.Size = new System.Drawing.Size(306, 57);
            this.label_WorkMedia.TabIndex = 4;
            this.label_WorkMedia.Text = "Work Media";
            this.label_WorkMedia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_headerStrip
            // 
            this.panel_headerStrip.BackColor = System.Drawing.Color.Maroon;
            this.panel_headerStrip.Location = new System.Drawing.Point(0, 60);
            this.panel_headerStrip.Name = "panel_headerStrip";
            this.panel_headerStrip.Size = new System.Drawing.Size(1000, 10);
            this.panel_headerStrip.TabIndex = 3;
            // 
            // panel_tabs
            // 
            this.panel_tabs.BackColor = System.Drawing.Color.Brown;
            this.panel_tabs.Controls.Add(this.panel_ActiveTab);
            this.panel_tabs.Controls.Add(this.picbox_settings);
            this.panel_tabs.Controls.Add(this.picbox_log);
            this.panel_tabs.Controls.Add(this.picbox_poll);
            this.panel_tabs.Controls.Add(this.picbox_event);
            this.panel_tabs.Controls.Add(this.picbox_post);
            this.panel_tabs.Controls.Add(this.picbox_messages);
            this.panel_tabs.Controls.Add(this.picbox_teams);
            this.panel_tabs.Controls.Add(this.picbox_contacts);
            this.panel_tabs.Controls.Add(this.picbox_home);
            this.panel_tabs.Location = new System.Drawing.Point(0, 70);
            this.panel_tabs.Name = "panel_tabs";
            this.panel_tabs.Size = new System.Drawing.Size(70, 531);
            this.panel_tabs.TabIndex = 1;
            // 
            // panel_ActiveTab
            // 
            this.panel_ActiveTab.BackColor = System.Drawing.Color.LightCoral;
            this.panel_ActiveTab.Location = new System.Drawing.Point(3, 6);
            this.panel_ActiveTab.Name = "panel_ActiveTab";
            this.panel_ActiveTab.Size = new System.Drawing.Size(10, 50);
            this.panel_ActiveTab.TabIndex = 0;
            // 
            // picbox_settings
            // 
            this.picbox_settings.Image = ((System.Drawing.Image)(resources.GetObject("picbox_settings.Image")));
            this.picbox_settings.Location = new System.Drawing.Point(16, 474);
            this.picbox_settings.Name = "picbox_settings";
            this.picbox_settings.Size = new System.Drawing.Size(51, 49);
            this.picbox_settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox_settings.TabIndex = 13;
            this.picbox_settings.TabStop = false;
            this.picbox_settings.Click += new System.EventHandler(this.picbox_settings_Click);
            // 
            // picbox_log
            // 
            this.picbox_log.Image = ((System.Drawing.Image)(resources.GetObject("picbox_log.Image")));
            this.picbox_log.Location = new System.Drawing.Point(16, 412);
            this.picbox_log.Name = "picbox_log";
            this.picbox_log.Size = new System.Drawing.Size(51, 49);
            this.picbox_log.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox_log.TabIndex = 12;
            this.picbox_log.TabStop = false;
            this.picbox_log.Click += new System.EventHandler(this.picbox_log_Click);
            // 
            // picbox_poll
            // 
            this.picbox_poll.Image = ((System.Drawing.Image)(resources.GetObject("picbox_poll.Image")));
            this.picbox_poll.Location = new System.Drawing.Point(16, 351);
            this.picbox_poll.Name = "picbox_poll";
            this.picbox_poll.Size = new System.Drawing.Size(51, 49);
            this.picbox_poll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox_poll.TabIndex = 11;
            this.picbox_poll.TabStop = false;
            this.picbox_poll.Click += new System.EventHandler(this.picbox_poll_Click);
            // 
            // picbox_event
            // 
            this.picbox_event.Image = ((System.Drawing.Image)(resources.GetObject("picbox_event.Image")));
            this.picbox_event.Location = new System.Drawing.Point(16, 292);
            this.picbox_event.Name = "picbox_event";
            this.picbox_event.Size = new System.Drawing.Size(51, 49);
            this.picbox_event.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox_event.TabIndex = 10;
            this.picbox_event.TabStop = false;
            this.picbox_event.Click += new System.EventHandler(this.picbox_event_Click);
            // 
            // picbox_post
            // 
            this.picbox_post.Image = ((System.Drawing.Image)(resources.GetObject("picbox_post.Image")));
            this.picbox_post.Location = new System.Drawing.Point(16, 232);
            this.picbox_post.Name = "picbox_post";
            this.picbox_post.Size = new System.Drawing.Size(51, 49);
            this.picbox_post.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox_post.TabIndex = 9;
            this.picbox_post.TabStop = false;
            this.picbox_post.Click += new System.EventHandler(this.picbox_post_Click);
            // 
            // picbox_messages
            // 
            this.picbox_messages.Image = ((System.Drawing.Image)(resources.GetObject("picbox_messages.Image")));
            this.picbox_messages.Location = new System.Drawing.Point(16, 175);
            this.picbox_messages.Name = "picbox_messages";
            this.picbox_messages.Size = new System.Drawing.Size(51, 49);
            this.picbox_messages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox_messages.TabIndex = 8;
            this.picbox_messages.TabStop = false;
            this.picbox_messages.Click += new System.EventHandler(this.picbox_messages_Click);
            // 
            // picbox_teams
            // 
            this.picbox_teams.Image = ((System.Drawing.Image)(resources.GetObject("picbox_teams.Image")));
            this.picbox_teams.Location = new System.Drawing.Point(16, 120);
            this.picbox_teams.Name = "picbox_teams";
            this.picbox_teams.Size = new System.Drawing.Size(51, 49);
            this.picbox_teams.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox_teams.TabIndex = 7;
            this.picbox_teams.TabStop = false;
            this.picbox_teams.Click += new System.EventHandler(this.picbox_teams_Click);
            // 
            // picbox_contacts
            // 
            this.picbox_contacts.Image = ((System.Drawing.Image)(resources.GetObject("picbox_contacts.Image")));
            this.picbox_contacts.Location = new System.Drawing.Point(16, 65);
            this.picbox_contacts.Name = "picbox_contacts";
            this.picbox_contacts.Size = new System.Drawing.Size(51, 49);
            this.picbox_contacts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox_contacts.TabIndex = 6;
            this.picbox_contacts.TabStop = false;
            this.picbox_contacts.Click += new System.EventHandler(this.picbox_contacts_Click);
            // 
            // picbox_home
            // 
            this.picbox_home.Image = ((System.Drawing.Image)(resources.GetObject("picbox_home.Image")));
            this.picbox_home.Location = new System.Drawing.Point(16, 6);
            this.picbox_home.Name = "picbox_home";
            this.picbox_home.Size = new System.Drawing.Size(51, 49);
            this.picbox_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox_home.TabIndex = 5;
            this.picbox_home.TabStop = false;
            this.picbox_home.Click += new System.EventHandler(this.picbox_home_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Location = new System.Drawing.Point(70, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 531);
            this.panel1.TabIndex = 4;
            // 
            // FlowLayoutPanel
            // 
            this.FlowLayoutPanel.Location = new System.Drawing.Point(79, 70);
            this.FlowLayoutPanel.Name = "FlowLayoutPanel";
            this.FlowLayoutPanel.Size = new System.Drawing.Size(860, 530);
            this.FlowLayoutPanel.TabIndex = 5;
            // 
            // picBox_UpArrow
            // 
            this.picBox_UpArrow.BackColor = System.Drawing.Color.MistyRose;
            this.picBox_UpArrow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBox_UpArrow.Image = ((System.Drawing.Image)(resources.GetObject("picBox_UpArrow.Image")));
            this.picBox_UpArrow.Location = new System.Drawing.Point(942, 270);
            this.picBox_UpArrow.Name = "picBox_UpArrow";
            this.picBox_UpArrow.Size = new System.Drawing.Size(55, 55);
            this.picBox_UpArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_UpArrow.TabIndex = 6;
            this.picBox_UpArrow.TabStop = false;
            this.picBox_UpArrow.Click += new System.EventHandler(this.picBox_UpArrow_Click);
            this.picBox_UpArrow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBox_UpArrow_MouseDown);
            this.picBox_UpArrow.MouseEnter += new System.EventHandler(this.picBox_UpArrow_MouseEnter);
            this.picBox_UpArrow.MouseLeave += new System.EventHandler(this.picBox_UpArrow_MouseLeave);
            this.picBox_UpArrow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picBox_UpArrow_MouseUp);
            // 
            // picBox_DownArrow
            // 
            this.picBox_DownArrow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBox_DownArrow.Image = ((System.Drawing.Image)(resources.GetObject("picBox_DownArrow.Image")));
            this.picBox_DownArrow.Location = new System.Drawing.Point(942, 331);
            this.picBox_DownArrow.Name = "picBox_DownArrow";
            this.picBox_DownArrow.Size = new System.Drawing.Size(55, 54);
            this.picBox_DownArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_DownArrow.TabIndex = 7;
            this.picBox_DownArrow.TabStop = false;
            this.picBox_DownArrow.Click += new System.EventHandler(this.picBox_DownArrow_Click);
            this.picBox_DownArrow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBox_DownArrow_MouseDown);
            this.picBox_DownArrow.MouseEnter += new System.EventHandler(this.picBox_DownArrow_MouseEnter);
            this.picBox_DownArrow.MouseLeave += new System.EventHandler(this.picBox_DownArrow_MouseLeave);
            this.picBox_DownArrow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picBox_DownArrow_MouseUp);
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(942, 161);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(54, 23);
            this.btn_check.TabIndex = 8;
            this.btn_check.Text = "check";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.picBox_DownArrow);
            this.Controls.Add(this.picBox_UpArrow);
            this.Controls.Add(this.FlowLayoutPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_tabs);
            this.Controls.Add(this.panel_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.panel_header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_report)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_close)).EndInit();
            this.panel_tabs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_log)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_poll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_event)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_post)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_messages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_teams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_contacts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_UpArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_DownArrow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Panel panel_tabs;
        private System.Windows.Forms.Panel panel_headerStrip;
        private System.Windows.Forms.PictureBox picbox_settings;
        private System.Windows.Forms.PictureBox picbox_log;
        private System.Windows.Forms.PictureBox picbox_poll;
        private System.Windows.Forms.PictureBox picbox_event;
        private System.Windows.Forms.PictureBox picbox_post;
        private System.Windows.Forms.PictureBox picbox_messages;
        private System.Windows.Forms.PictureBox picbox_teams;
        private System.Windows.Forms.PictureBox picbox_contacts;
        private System.Windows.Forms.PictureBox picbox_home;
        private System.Windows.Forms.Label label_WorkMedia;
        private System.Windows.Forms.PictureBox picbox_report;
        private System.Windows.Forms.PictureBox picbox_close;
        private System.Windows.Forms.Panel panel_ActiveTab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_TabHeader;
        private System.Windows.Forms.PictureBox picBox_UpArrow;
        private System.Windows.Forms.PictureBox picBox_DownArrow;
        public System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel;
        private System.Windows.Forms.Button btn_check;
    }
}

