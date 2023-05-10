namespace WorkMedia
{
    partial class UserControlPost
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
            this.Header_box = new System.Windows.Forms.TextBox();
            this.Text_body_box = new System.Windows.Forms.TextBox();
            this.text_body = new System.Windows.Forms.Label();
            this.Post_button = new System.Windows.Forms.Button();
            this.Discard_button = new System.Windows.Forms.Button();
            this.tags = new System.Windows.Forms.Label();
            this.Filters_Check_List = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // Header_Label
            // 
            this.Header_Label.AutoSize = true;
            this.Header_Label.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold);
            this.Header_Label.ForeColor = System.Drawing.Color.LightCoral;
            this.Header_Label.Location = new System.Drawing.Point(20, 17);
            this.Header_Label.Name = "Header_Label";
            this.Header_Label.Size = new System.Drawing.Size(117, 39);
            this.Header_Label.TabIndex = 0;
            this.Header_Label.Text = "Header";
            // 
            // Header_box
            // 
            this.Header_box.Location = new System.Drawing.Point(23, 58);
            this.Header_box.Multiline = true;
            this.Header_box.Name = "Header_box";
            this.Header_box.Size = new System.Drawing.Size(581, 39);
            this.Header_box.TabIndex = 1;
            // 
            // Text_body_box
            // 
            this.Text_body_box.Location = new System.Drawing.Point(27, 152);
            this.Text_body_box.Multiline = true;
            this.Text_body_box.Name = "Text_body_box";
            this.Text_body_box.Size = new System.Drawing.Size(581, 337);
            this.Text_body_box.TabIndex = 2;
            // 
            // text_body
            // 
            this.text_body.AutoSize = true;
            this.text_body.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold);
            this.text_body.ForeColor = System.Drawing.Color.LightCoral;
            this.text_body.Location = new System.Drawing.Point(20, 110);
            this.text_body.Name = "text_body";
            this.text_body.Size = new System.Drawing.Size(74, 39);
            this.text_body.TabIndex = 3;
            this.text_body.Text = "Text";
            // 
            // Post_button
            // 
            this.Post_button.BackColor = System.Drawing.Color.Brown;
            this.Post_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Post_button.Font = new System.Drawing.Font("Impact", 18F);
            this.Post_button.ForeColor = System.Drawing.Color.LightCoral;
            this.Post_button.Location = new System.Drawing.Point(663, 432);
            this.Post_button.Name = "Post_button";
            this.Post_button.Size = new System.Drawing.Size(100, 58);
            this.Post_button.TabIndex = 4;
            this.Post_button.Text = "Post";
            this.Post_button.UseVisualStyleBackColor = false;
            this.Post_button.Click += new System.EventHandler(this.Post_button_Click);
            // 
            // Discard_button
            // 
            this.Discard_button.BackColor = System.Drawing.Color.Brown;
            this.Discard_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Discard_button.Font = new System.Drawing.Font("Impact", 18F);
            this.Discard_button.ForeColor = System.Drawing.Color.LightCoral;
            this.Discard_button.Location = new System.Drawing.Point(663, 386);
            this.Discard_button.Name = "Discard_button";
            this.Discard_button.Size = new System.Drawing.Size(100, 40);
            this.Discard_button.TabIndex = 5;
            this.Discard_button.Text = "Discard Post";
            this.Discard_button.UseVisualStyleBackColor = false;
            this.Discard_button.Click += new System.EventHandler(this.Discard_button_Click);
            // 
            // tags
            // 
            this.tags.AutoSize = true;
            this.tags.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold);
            this.tags.ForeColor = System.Drawing.Color.LightCoral;
            this.tags.Location = new System.Drawing.Point(645, 110);
            this.tags.Name = "tags";
            this.tags.Size = new System.Drawing.Size(83, 39);
            this.tags.TabIndex = 7;
            this.tags.Text = "Tags";
            // 
            // Filters_Check_List
            // 
            this.Filters_Check_List.FormattingEnabled = true;
            this.Filters_Check_List.Items.AddRange(new object[] {
            "TO-DO",
            "Discussion",
            "HR",
            "Success Story",
            "Training",
            "News",
            "Update",
            "Alert",
            "Urgent"});
            this.Filters_Check_List.Location = new System.Drawing.Point(652, 152);
            this.Filters_Check_List.Name = "Filters_Check_List";
            this.Filters_Check_List.Size = new System.Drawing.Size(120, 139);
            this.Filters_Check_List.TabIndex = 17;
            this.Filters_Check_List.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.Filters_Check_List_ItemCheck);
            // 
            // UserControlPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.Controls.Add(this.Filters_Check_List);
            this.Controls.Add(this.tags);
            this.Controls.Add(this.Discard_button);
            this.Controls.Add(this.Post_button);
            this.Controls.Add(this.text_body);
            this.Controls.Add(this.Text_body_box);
            this.Controls.Add(this.Header_box);
            this.Controls.Add(this.Header_Label);
            this.Name = "UserControlPost";
            this.Size = new System.Drawing.Size(860, 530);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Header_Label;
        private System.Windows.Forms.TextBox Header_box;
        private System.Windows.Forms.TextBox Text_body_box;
        private System.Windows.Forms.Label text_body;
        private System.Windows.Forms.Button Post_button;
        private System.Windows.Forms.Button Discard_button;
        private System.Windows.Forms.Label tags;
        private System.Windows.Forms.CheckedListBox Filters_Check_List;
    }
}
