namespace WorkMedia
{
    partial class ReportForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_TabHeader = new System.Windows.Forms.Label();
            this.txtbox_report = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.lbl_charLimit = new System.Windows.Forms.Label();
            this.txtbox_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label_TabHeader);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 58);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(0, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 10);
            this.panel2.TabIndex = 5;
            // 
            // label_TabHeader
            // 
            this.label_TabHeader.BackColor = System.Drawing.Color.Transparent;
            this.label_TabHeader.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TabHeader.ForeColor = System.Drawing.Color.LightCoral;
            this.label_TabHeader.Location = new System.Drawing.Point(96, 7);
            this.label_TabHeader.Name = "label_TabHeader";
            this.label_TabHeader.Size = new System.Drawing.Size(111, 36);
            this.label_TabHeader.TabIndex = 8;
            this.label_TabHeader.Text = "Report";
            this.label_TabHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtbox_report
            // 
            this.txtbox_report.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtbox_report.Location = new System.Drawing.Point(34, 214);
            this.txtbox_report.Multiline = true;
            this.txtbox_report.Name = "txtbox_report";
            this.txtbox_report.Size = new System.Drawing.Size(225, 105);
            this.txtbox_report.TabIndex = 1;
            this.txtbox_report.TextChanged += new System.EventHandler(this.txtbox_report_TextChanged);
            // 
            // btn_submit
            // 
            this.btn_submit.BackColor = System.Drawing.Color.Brown;
            this.btn_submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_submit.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit.ForeColor = System.Drawing.Color.LightCoral;
            this.btn_submit.Location = new System.Drawing.Point(87, 379);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(121, 42);
            this.btn_submit.TabIndex = 2;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = false;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // lbl_charLimit
            // 
            this.lbl_charLimit.AutoSize = true;
            this.lbl_charLimit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_charLimit.ForeColor = System.Drawing.Color.Brown;
            this.lbl_charLimit.Location = new System.Drawing.Point(31, 195);
            this.lbl_charLimit.Name = "lbl_charLimit";
            this.lbl_charLimit.Size = new System.Drawing.Size(60, 16);
            this.lbl_charLimit.TabIndex = 3;
            this.lbl_charLimit.Text = "char limit";
            this.lbl_charLimit.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // txtbox_email
            // 
            this.txtbox_email.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtbox_email.Location = new System.Drawing.Point(34, 141);
            this.txtbox_email.Name = "txtbox_email";
            this.txtbox_email.Size = new System.Drawing.Size(225, 20);
            this.txtbox_email.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(30, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Email";
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(304, 451);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_email);
            this.Controls.Add(this.lbl_charLimit);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txtbox_report);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ReportForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_TabHeader;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtbox_report;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label lbl_charLimit;
        private System.Windows.Forms.TextBox txtbox_email;
        private System.Windows.Forms.Label label1;
    }
}