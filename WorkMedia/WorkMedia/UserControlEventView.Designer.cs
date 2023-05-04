namespace WorkMedia
{
    partial class UserControlEventView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Header_Label = new System.Windows.Forms.Label();
            this.Event_description = new System.Windows.Forms.TextBox();
            this.Event_picture = new System.Windows.Forms.PictureBox();
            this.Attendees_header = new System.Windows.Forms.Label();
            this.Attendees = new System.Windows.Forms.TextBox();
            this.Attend_event_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Event_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Header_Label
            // 
            this.Header_Label.AutoSize = true;
            this.Header_Label.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold);
            this.Header_Label.ForeColor = System.Drawing.Color.LightCoral;
            this.Header_Label.Location = new System.Drawing.Point(152, 18);
            this.Header_Label.Name = "Header_Label";
            this.Header_Label.Size = new System.Drawing.Size(256, 39);
            this.Header_Label.TabIndex = 3;
            this.Header_Label.Text = "Event Name/Date";
            this.Header_Label.Click += new System.EventHandler(this.Header_Label_Click);
            // 
            // Event_description
            // 
            this.Event_description.Location = new System.Drawing.Point(159, 60);
            this.Event_description.Multiline = true;
            this.Event_description.Name = "Event_description";
            this.Event_description.Size = new System.Drawing.Size(393, 99);
            this.Event_description.TabIndex = 7;
            this.Event_description.TextChanged += new System.EventHandler(this.Event_description_TextChanged);
            // 
            // Event_picture
            // 
            this.Event_picture.Location = new System.Drawing.Point(159, 165);
            this.Event_picture.Name = "Event_picture";
            this.Event_picture.Size = new System.Drawing.Size(393, 344);
            this.Event_picture.TabIndex = 10;
            this.Event_picture.TabStop = false;
            this.Event_picture.Click += new System.EventHandler(this.Event_picture_Click);
            // 
            // Attendees_header
            // 
            this.Attendees_header.AutoSize = true;
            this.Attendees_header.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold);
            this.Attendees_header.ForeColor = System.Drawing.Color.LightCoral;
            this.Attendees_header.Location = new System.Drawing.Point(553, 18);
            this.Attendees_header.Name = "Attendees_header";
            this.Attendees_header.Size = new System.Drawing.Size(159, 39);
            this.Attendees_header.TabIndex = 11;
            this.Attendees_header.Text = "Attendees";
            this.Attendees_header.Click += new System.EventHandler(this.Attendees_header_Click);
            // 
            // Attendees
            // 
            this.Attendees.Location = new System.Drawing.Point(558, 60);
            this.Attendees.Multiline = true;
            this.Attendees.Name = "Attendees";
            this.Attendees.Size = new System.Drawing.Size(148, 449);
            this.Attendees.TabIndex = 12;
            this.Attendees.TextChanged += new System.EventHandler(this.Attendees_TextChanged);
            // 
            // Attend_event_button
            // 
            this.Attend_event_button.BackColor = System.Drawing.Color.Brown;
            this.Attend_event_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Attend_event_button.Font = new System.Drawing.Font("Impact", 18F);
            this.Attend_event_button.ForeColor = System.Drawing.Color.LightCoral;
            this.Attend_event_button.Location = new System.Drawing.Point(737, 466);
            this.Attend_event_button.Name = "Attend_event_button";
            this.Attend_event_button.Size = new System.Drawing.Size(99, 43);
            this.Attend_event_button.TabIndex = 13;
            this.Attend_event_button.Text = "Attend";
            this.Attend_event_button.UseVisualStyleBackColor = false;
            this.Attend_event_button.Click += new System.EventHandler(this.Attend_event_button_Click);
            // 
            // UserControlEventView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.Controls.Add(this.Attend_event_button);
            this.Controls.Add(this.Attendees);
            this.Controls.Add(this.Attendees_header);
            this.Controls.Add(this.Event_picture);
            this.Controls.Add(this.Event_description);
            this.Controls.Add(this.Header_Label);
            this.Name = "UserControlEventView";
            this.Size = new System.Drawing.Size(860, 530);
            ((System.ComponentModel.ISupportInitialize)(this.Event_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Header_Label;
        private System.Windows.Forms.TextBox Event_description;
        private System.Windows.Forms.PictureBox Event_picture;
        private System.Windows.Forms.Label Attendees_header;
        private System.Windows.Forms.TextBox Attendees;
        private System.Windows.Forms.Button Attend_event_button;
    }
}
