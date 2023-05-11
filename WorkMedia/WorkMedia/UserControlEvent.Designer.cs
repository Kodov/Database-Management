namespace WorkMedia
{
    partial class UserControlEvent
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
            this.date_Time_Picker = new System.Windows.Forms.DateTimePicker();
            this.Header_Label = new System.Windows.Forms.Label();
            this.Event_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Event_description = new System.Windows.Forms.TextBox();
            this.Post_event_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // date_Time_Picker
            // 
            this.date_Time_Picker.Location = new System.Drawing.Point(629, 75);
            this.date_Time_Picker.Name = "date_Time_Picker";
            this.date_Time_Picker.Size = new System.Drawing.Size(200, 20);
            this.date_Time_Picker.TabIndex = 0;
            this.date_Time_Picker.ValueChanged += new System.EventHandler(this.date_Time_Picker_ValueChanged);
            // 
            // Header_Label
            // 
            this.Header_Label.AutoSize = true;
            this.Header_Label.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold);
            this.Header_Label.ForeColor = System.Drawing.Color.LightCoral;
            this.Header_Label.Location = new System.Drawing.Point(29, 32);
            this.Header_Label.Name = "Header_Label";
            this.Header_Label.Size = new System.Drawing.Size(117, 39);
            this.Header_Label.TabIndex = 2;
            this.Header_Label.Text = "Header";
            // 
            // Event_name
            // 
            this.Event_name.Location = new System.Drawing.Point(36, 75);
            this.Event_name.Multiline = true;
            this.Event_name.Name = "Event_name";
            this.Event_name.Size = new System.Drawing.Size(431, 39);
            this.Event_name.TabIndex = 3;
            this.Event_name.TextChanged += new System.EventHandler(this.Event_name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(29, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Description";
            // 
            // Event_description
            // 
            this.Event_description.Location = new System.Drawing.Point(36, 177);
            this.Event_description.Multiline = true;
            this.Event_description.Name = "Event_description";
            this.Event_description.Size = new System.Drawing.Size(431, 183);
            this.Event_description.TabIndex = 5;
            this.Event_description.TextChanged += new System.EventHandler(this.Event_description_TextChanged);
            // 
            // Post_event_button
            // 
            this.Post_event_button.BackColor = System.Drawing.Color.Brown;
            this.Post_event_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Post_event_button.Font = new System.Drawing.Font("Impact", 18F);
            this.Post_event_button.ForeColor = System.Drawing.Color.LightCoral;
            this.Post_event_button.Location = new System.Drawing.Point(729, 463);
            this.Post_event_button.Name = "Post_event_button";
            this.Post_event_button.Size = new System.Drawing.Size(100, 43);
            this.Post_event_button.TabIndex = 6;
            this.Post_event_button.Text = "Post";
            this.Post_event_button.UseVisualStyleBackColor = false;
            this.Post_event_button.Click += new System.EventHandler(this.Post_event_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.LightCoral;
            this.label2.Location = new System.Drawing.Point(622, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 39);
            this.label2.TabIndex = 7;
            this.label2.Text = "Event Date";
            // 
            // UserControlEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Post_event_button);
            this.Controls.Add(this.Event_description);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Event_name);
            this.Controls.Add(this.Header_Label);
            this.Controls.Add(this.date_Time_Picker);
            this.Name = "UserControlEvent";
            this.Size = new System.Drawing.Size(860, 530);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker date_Time_Picker;
        private System.Windows.Forms.Label Header_Label;
        private System.Windows.Forms.TextBox Event_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Event_description;
        private System.Windows.Forms.Button Post_event_button;
        private System.Windows.Forms.Label label2;
    }
}
