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
            this.Attendees_header = new System.Windows.Forms.Label();
            this.Attend_event_button = new System.Windows.Forms.Button();
            this.lbl_attendCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Header_Label
            // 
            this.Header_Label.AutoSize = true;
            this.Header_Label.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold);
            this.Header_Label.ForeColor = System.Drawing.Color.LightCoral;
            this.Header_Label.Location = new System.Drawing.Point(273, 117);
            this.Header_Label.Name = "Header_Label";
            this.Header_Label.Size = new System.Drawing.Size(178, 39);
            this.Header_Label.TabIndex = 3;
            this.Header_Label.Text = "Event Name";
            this.Header_Label.Click += new System.EventHandler(this.Header_Label_Click);
            // 
            // Event_description
            // 
            this.Event_description.Location = new System.Drawing.Point(280, 179);
            this.Event_description.Multiline = true;
            this.Event_description.Name = "Event_description";
            this.Event_description.Size = new System.Drawing.Size(393, 88);
            this.Event_description.TabIndex = 7;
            this.Event_description.TextChanged += new System.EventHandler(this.Event_description_TextChanged);
            // 
            // Attendees_header
            // 
            this.Attendees_header.AutoSize = true;
            this.Attendees_header.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold);
            this.Attendees_header.ForeColor = System.Drawing.Color.LightCoral;
            this.Attendees_header.Location = new System.Drawing.Point(273, 270);
            this.Attendees_header.Name = "Attendees_header";
            this.Attendees_header.Size = new System.Drawing.Size(159, 39);
            this.Attendees_header.TabIndex = 11;
            this.Attendees_header.Text = "Attendees";
            this.Attendees_header.Click += new System.EventHandler(this.Attendees_header_Click);
            // 
            // Attend_event_button
            // 
            this.Attend_event_button.BackColor = System.Drawing.Color.Brown;
            this.Attend_event_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Attend_event_button.Font = new System.Drawing.Font("Impact", 18F);
            this.Attend_event_button.ForeColor = System.Drawing.Color.LightCoral;
            this.Attend_event_button.Location = new System.Drawing.Point(280, 338);
            this.Attend_event_button.Name = "Attend_event_button";
            this.Attend_event_button.Size = new System.Drawing.Size(99, 43);
            this.Attend_event_button.TabIndex = 13;
            this.Attend_event_button.Text = "Join";
            this.Attend_event_button.UseVisualStyleBackColor = false;
            this.Attend_event_button.Click += new System.EventHandler(this.Attend_event_button_Click);
            // 
            // lbl_attendCount
            // 
            this.lbl_attendCount.AutoSize = true;
            this.lbl_attendCount.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold);
            this.lbl_attendCount.ForeColor = System.Drawing.Color.Brown;
            this.lbl_attendCount.Location = new System.Drawing.Point(438, 270);
            this.lbl_attendCount.Name = "lbl_attendCount";
            this.lbl_attendCount.Size = new System.Drawing.Size(35, 39);
            this.lbl_attendCount.TabIndex = 14;
            this.lbl_attendCount.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(276, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Event Date";
            // 
            // UserControlEventView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_attendCount);
            this.Controls.Add(this.Attend_event_button);
            this.Controls.Add(this.Attendees_header);
            this.Controls.Add(this.Event_description);
            this.Controls.Add(this.Header_Label);
            this.Name = "UserControlEventView";
            this.Size = new System.Drawing.Size(860, 530);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Header_Label;
        private System.Windows.Forms.TextBox Event_description;
        private System.Windows.Forms.Label Attendees_header;
        private System.Windows.Forms.Button Attend_event_button;
        private System.Windows.Forms.Label lbl_attendCount;
        private System.Windows.Forms.Label label1;
    }
}
