namespace WorkMedia
{
    partial class UserControlHome
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
            this.btn_loadFeed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_loadFeed
            // 
            this.btn_loadFeed.BackColor = System.Drawing.Color.Brown;
            this.btn_loadFeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loadFeed.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loadFeed.ForeColor = System.Drawing.Color.LightCoral;
            this.btn_loadFeed.Location = new System.Drawing.Point(368, 233);
            this.btn_loadFeed.Name = "btn_loadFeed";
            this.btn_loadFeed.Size = new System.Drawing.Size(121, 42);
            this.btn_loadFeed.TabIndex = 34;
            this.btn_loadFeed.Text = "Load Feed";
            this.btn_loadFeed.UseVisualStyleBackColor = false;
            this.btn_loadFeed.Click += new System.EventHandler(this.btn_loadFeed_Click);
            // 
            // UserControlHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.Controls.Add(this.btn_loadFeed);
            this.Name = "UserControlHome";
            this.Size = new System.Drawing.Size(860, 530);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_loadFeed;
    }
}
