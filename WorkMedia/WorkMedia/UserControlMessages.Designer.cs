namespace WorkMedia
{
    partial class UserControlMessages
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
            this.Previous_messages = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_TabHeader = new System.Windows.Forms.Label();
            this.sending_message_label = new System.Windows.Forms.Label();
            this.send_message_text = new System.Windows.Forms.RichTextBox();
            this.friend_list = new System.Windows.Forms.ComboBox();
            this.message_send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Previous_messages
            // 
            this.Previous_messages.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Previous_messages.Location = new System.Drawing.Point(19, 100);
            this.Previous_messages.Name = "Previous_messages";
            this.Previous_messages.ReadOnly = true;
            this.Previous_messages.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.Previous_messages.Size = new System.Drawing.Size(623, 315);
            this.Previous_messages.TabIndex = 18;
            this.Previous_messages.Text = "";
            this.Previous_messages.TextChanged += new System.EventHandler(this.Previous_messages_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 40);
            this.label1.TabIndex = 17;
            this.label1.Text = "Message History";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_TabHeader
            // 
            this.label_TabHeader.BackColor = System.Drawing.Color.Transparent;
            this.label_TabHeader.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Bold);
            this.label_TabHeader.ForeColor = System.Drawing.Color.LightCoral;
            this.label_TabHeader.Location = new System.Drawing.Point(644, 15);
            this.label_TabHeader.Name = "label_TabHeader";
            this.label_TabHeader.Size = new System.Drawing.Size(134, 19);
            this.label_TabHeader.TabIndex = 16;
            this.label_TabHeader.Text = "Contacts";
            this.label_TabHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sending_message_label
            // 
            this.sending_message_label.BackColor = System.Drawing.Color.Transparent;
            this.sending_message_label.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sending_message_label.ForeColor = System.Drawing.Color.LightCoral;
            this.sending_message_label.Location = new System.Drawing.Point(12, 418);
            this.sending_message_label.Name = "sending_message_label";
            this.sending_message_label.Size = new System.Drawing.Size(244, 36);
            this.sending_message_label.TabIndex = 15;
            this.sending_message_label.Text = "Send Message";
            this.sending_message_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // send_message_text
            // 
            this.send_message_text.BackColor = System.Drawing.Color.WhiteSmoke;
            this.send_message_text.Location = new System.Drawing.Point(19, 457);
            this.send_message_text.Name = "send_message_text";
            this.send_message_text.Size = new System.Drawing.Size(623, 59);
            this.send_message_text.TabIndex = 14;
            this.send_message_text.Text = "";
            this.send_message_text.TextChanged += new System.EventHandler(this.send_message_text_TextChanged);
            // 
            // friend_list
            // 
            this.friend_list.BackColor = System.Drawing.Color.Black;
            this.friend_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.friend_list.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.friend_list.FormattingEnabled = true;
            this.friend_list.Location = new System.Drawing.Point(648, 37);
            this.friend_list.Name = "friend_list";
            this.friend_list.Size = new System.Drawing.Size(209, 21);
            this.friend_list.TabIndex = 13;
            this.friend_list.SelectedIndexChanged += new System.EventHandler(this.friend_list_SelectedIndexChanged);
            // 
            // message_send
            // 
            this.message_send.BackColor = System.Drawing.Color.Brown;
            this.message_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.message_send.ForeColor = System.Drawing.Color.LightCoral;
            this.message_send.Location = new System.Drawing.Point(648, 493);
            this.message_send.Name = "message_send";
            this.message_send.Size = new System.Drawing.Size(75, 23);
            this.message_send.TabIndex = 12;
            this.message_send.Text = "Send";
            this.message_send.UseVisualStyleBackColor = false;
            this.message_send.Click += new System.EventHandler(this.message_send_Click);
            // 
            // UserControlMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.Controls.Add(this.Previous_messages);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_TabHeader);
            this.Controls.Add(this.sending_message_label);
            this.Controls.Add(this.send_message_text);
            this.Controls.Add(this.friend_list);
            this.Controls.Add(this.message_send);
            this.Name = "UserControlMessages";
            this.Size = new System.Drawing.Size(860, 530);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Previous_messages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_TabHeader;
        private System.Windows.Forms.Label sending_message_label;
        private System.Windows.Forms.RichTextBox send_message_text;
        private System.Windows.Forms.ComboBox friend_list;
        private System.Windows.Forms.Button message_send;
    }
}
