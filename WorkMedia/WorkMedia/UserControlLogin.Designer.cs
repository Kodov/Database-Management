namespace WorkMedia
{
    partial class UserControlLogin
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
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txtbox_username = new System.Windows.Forms.TextBox();
            this.txtbox_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_createAccount = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.Brown;
            this.lbl_username.Location = new System.Drawing.Point(383, 118);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(91, 23);
            this.lbl_username.TabIndex = 29;
            this.lbl_username.Text = "Username";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.Color.Brown;
            this.lbl_password.Location = new System.Drawing.Point(383, 190);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(88, 23);
            this.lbl_password.TabIndex = 30;
            this.lbl_password.Text = "Password";
            // 
            // txtbox_username
            // 
            this.txtbox_username.Location = new System.Drawing.Point(322, 144);
            this.txtbox_username.Name = "txtbox_username";
            this.txtbox_username.Size = new System.Drawing.Size(209, 20);
            this.txtbox_username.TabIndex = 31;
            // 
            // txtbox_password
            // 
            this.txtbox_password.Location = new System.Drawing.Point(322, 216);
            this.txtbox_password.Name = "txtbox_password";
            this.txtbox_password.Size = new System.Drawing.Size(209, 20);
            this.txtbox_password.TabIndex = 32;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Brown;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.LightCoral;
            this.btn_login.Location = new System.Drawing.Point(366, 273);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(121, 42);
            this.btn_login.TabIndex = 33;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            // 
            // btn_createAccount
            // 
            this.btn_createAccount.BackColor = System.Drawing.Color.Brown;
            this.btn_createAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_createAccount.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createAccount.ForeColor = System.Drawing.Color.LightCoral;
            this.btn_createAccount.Location = new System.Drawing.Point(366, 397);
            this.btn_createAccount.Name = "btn_createAccount";
            this.btn_createAccount.Size = new System.Drawing.Size(121, 37);
            this.btn_createAccount.TabIndex = 34;
            this.btn_createAccount.Text = "Create Account";
            this.btn_createAccount.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(405, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 18);
            this.label1.TabIndex = 35;
            this.label1.Text = "- or -";
            // 
            // UserControlLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_createAccount);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txtbox_password);
            this.Controls.Add(this.txtbox_username);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Name = "UserControlLogin";
            this.Size = new System.Drawing.Size(860, 530);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txtbox_username;
        private System.Windows.Forms.TextBox txtbox_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_createAccount;
        private System.Windows.Forms.Label label1;
    }
}
