namespace WorkMedia
{
    partial class UserControlPostView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlPostView));
            this.lbl_postHeader = new System.Windows.Forms.Label();
            this.txtbox_PostBody = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.picbox_Like = new System.Windows.Forms.PictureBox();
            this.picbox_dislike = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Post_button = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Like)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_dislike)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_postHeader
            // 
            this.lbl_postHeader.AutoSize = true;
            this.lbl_postHeader.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_postHeader.ForeColor = System.Drawing.Color.Brown;
            this.lbl_postHeader.Location = new System.Drawing.Point(196, 17);
            this.lbl_postHeader.Name = "lbl_postHeader";
            this.lbl_postHeader.Size = new System.Drawing.Size(129, 29);
            this.lbl_postHeader.TabIndex = 0;
            this.lbl_postHeader.Text = "Post Header";
            // 
            // txtbox_PostBody
            // 
            this.txtbox_PostBody.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_PostBody.ForeColor = System.Drawing.Color.LightCoral;
            this.txtbox_PostBody.Location = new System.Drawing.Point(201, 49);
            this.txtbox_PostBody.Multiline = true;
            this.txtbox_PostBody.Name = "txtbox_PostBody";
            this.txtbox_PostBody.Size = new System.Drawing.Size(272, 356);
            this.txtbox_PostBody.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // picbox_Like
            // 
            this.picbox_Like.Image = ((System.Drawing.Image)(resources.GetObject("picbox_Like.Image")));
            this.picbox_Like.Location = new System.Drawing.Point(140, 170);
            this.picbox_Like.Name = "picbox_Like";
            this.picbox_Like.Size = new System.Drawing.Size(55, 50);
            this.picbox_Like.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picbox_Like.TabIndex = 4;
            this.picbox_Like.TabStop = false;
            // 
            // picbox_dislike
            // 
            this.picbox_dislike.Image = ((System.Drawing.Image)(resources.GetObject("picbox_dislike.Image")));
            this.picbox_dislike.Location = new System.Drawing.Point(140, 226);
            this.picbox_dislike.Name = "picbox_dislike";
            this.picbox_dislike.Size = new System.Drawing.Size(55, 50);
            this.picbox_dislike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picbox_dislike.TabIndex = 5;
            this.picbox_dislike.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.LightCoral;
            this.textBox1.Location = new System.Drawing.Point(201, 432);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(342, 63);
            this.textBox1.TabIndex = 6;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // Post_button
            // 
            this.Post_button.BackColor = System.Drawing.Color.Brown;
            this.Post_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Post_button.Font = new System.Drawing.Font("Impact", 18F);
            this.Post_button.ForeColor = System.Drawing.Color.LightCoral;
            this.Post_button.Location = new System.Drawing.Point(549, 432);
            this.Post_button.Name = "Post_button";
            this.Post_button.Size = new System.Drawing.Size(74, 63);
            this.Post_button.TabIndex = 8;
            this.Post_button.Text = "Send";
            this.Post_button.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.LightCoral;
            this.textBox2.Location = new System.Drawing.Point(479, 49);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(144, 356);
            this.textBox2.TabIndex = 9;
            // 
            // UserControlPostView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Post_button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.picbox_dislike);
            this.Controls.Add(this.picbox_Like);
            this.Controls.Add(this.txtbox_PostBody);
            this.Controls.Add(this.lbl_postHeader);
            this.Name = "UserControlPostView";
            this.Size = new System.Drawing.Size(860, 530);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Like)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_dislike)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_postHeader;
        private System.Windows.Forms.TextBox txtbox_PostBody;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox picbox_Like;
        private System.Windows.Forms.PictureBox picbox_dislike;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Button Post_button;
        private System.Windows.Forms.TextBox textBox2;
    }
}
