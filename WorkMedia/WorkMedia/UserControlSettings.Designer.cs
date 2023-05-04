namespace WorkMedia
{
    partial class UserControlSettings
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
            this.Delete_Account = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Delete_Account
            // 
            this.Delete_Account.BackColor = System.Drawing.Color.Brown;
            this.Delete_Account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_Account.Font = new System.Drawing.Font("Impact", 18F);
            this.Delete_Account.ForeColor = System.Drawing.Color.LightCoral;
            this.Delete_Account.Location = new System.Drawing.Point(690, 428);
            this.Delete_Account.Name = "Delete_Account";
            this.Delete_Account.Size = new System.Drawing.Size(170, 43);
            this.Delete_Account.TabIndex = 7;
            this.Delete_Account.Text = "Delete Account";
            this.Delete_Account.UseVisualStyleBackColor = false;
            this.Delete_Account.Click += new System.EventHandler(this.Delete_Account_Click);
            // 
            // UserControlSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.Controls.Add(this.Delete_Account);
            this.Name = "UserControlSettings";
            this.Size = new System.Drawing.Size(860, 530);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Delete_Account;
    }
}
