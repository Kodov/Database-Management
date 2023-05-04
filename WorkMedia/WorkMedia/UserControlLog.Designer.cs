namespace WorkMedia
{
    partial class UserControlLog
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
            this.filter_date = new System.Windows.Forms.DateTimePicker();
            this.Filters_Check_List = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Log_text_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // filter_date
            // 
            this.filter_date.Location = new System.Drawing.Point(634, 60);
            this.filter_date.Name = "filter_date";
            this.filter_date.Size = new System.Drawing.Size(200, 20);
            this.filter_date.TabIndex = 0;
            this.filter_date.ValueChanged += new System.EventHandler(this.filter_date_ValueChanged);
            // 
            // Filters_Check_List
            // 
            this.Filters_Check_List.FormattingEnabled = true;
            this.Filters_Check_List.Items.AddRange(new object[] {
            "Home",
            "Contacts",
            "Teams",
            "Messages",
            "Post",
            "Event",
            "Poll",
            "Log",
            "Settings",
            "Bug Report",
            "Login"});
            this.Filters_Check_List.Location = new System.Drawing.Point(634, 86);
            this.Filters_Check_List.Name = "Filters_Check_List";
            this.Filters_Check_List.Size = new System.Drawing.Size(120, 169);
            this.Filters_Check_List.TabIndex = 1;
            this.Filters_Check_List.SelectedIndexChanged += new System.EventHandler(this.Filters_Check_List_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.LightCoral;
            this.label2.Location = new System.Drawing.Point(627, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 39);
            this.label2.TabIndex = 8;
            this.label2.Text = "Filters";
            // 
            // Log_text_box
            // 
            this.Log_text_box.Location = new System.Drawing.Point(29, 63);
            this.Log_text_box.Multiline = true;
            this.Log_text_box.Name = "Log_text_box";
            this.Log_text_box.ReadOnly = true;
            this.Log_text_box.Size = new System.Drawing.Size(576, 436);
            this.Log_text_box.TabIndex = 9;
            this.Log_text_box.TextChanged += new System.EventHandler(this.Log_text_box_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "Logs";
            // 
            // UserControlLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Log_text_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Filters_Check_List);
            this.Controls.Add(this.filter_date);
            this.Name = "UserControlLog";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(860, 530);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker filter_date;
        private System.Windows.Forms.CheckedListBox Filters_Check_List;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Log_text_box;
        private System.Windows.Forms.Label label1;
    }
}
