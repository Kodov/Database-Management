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
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbl_likeCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_Like)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_dislike)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_postHeader
            // 
            this.lbl_postHeader.AutoSize = true;
            this.lbl_postHeader.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_postHeader.ForeColor = System.Drawing.Color.Brown;
            this.lbl_postHeader.Location = new System.Drawing.Point(222, 42);
            this.lbl_postHeader.Name = "lbl_postHeader";
            this.lbl_postHeader.Size = new System.Drawing.Size(129, 29);
            this.lbl_postHeader.TabIndex = 0;
            this.lbl_postHeader.Text = "Post Header";
            // 
            // txtbox_PostBody
            // 
            this.txtbox_PostBody.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_PostBody.ForeColor = System.Drawing.Color.LightCoral;
            this.txtbox_PostBody.Location = new System.Drawing.Point(227, 74);
            this.txtbox_PostBody.Multiline = true;
            this.txtbox_PostBody.Name = "txtbox_PostBody";
            this.txtbox_PostBody.Size = new System.Drawing.Size(435, 407);
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
            this.picbox_Like.Location = new System.Drawing.Point(166, 195);
            this.picbox_Like.Name = "picbox_Like";
            this.picbox_Like.Size = new System.Drawing.Size(55, 50);
            this.picbox_Like.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picbox_Like.TabIndex = 4;
            this.picbox_Like.TabStop = false;
            // 
            // picbox_dislike
            // 
            this.picbox_dislike.Image = ((System.Drawing.Image)(resources.GetObject("picbox_dislike.Image")));
            this.picbox_dislike.Location = new System.Drawing.Point(166, 251);
            this.picbox_dislike.Name = "picbox_dislike";
            this.picbox_dislike.Size = new System.Drawing.Size(55, 50);
            this.picbox_dislike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picbox_dislike.TabIndex = 5;
            this.picbox_dislike.TabStop = false;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // lbl_likeCount
            // 
            this.lbl_likeCount.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_likeCount.ForeColor = System.Drawing.Color.Brown;
            this.lbl_likeCount.Location = new System.Drawing.Point(119, 233);
            this.lbl_likeCount.Name = "lbl_likeCount";
            this.lbl_likeCount.Size = new System.Drawing.Size(44, 29);
            this.lbl_likeCount.TabIndex = 9;
            this.lbl_likeCount.Text = "0";
            // 
            // UserControlPostView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.Controls.Add(this.lbl_likeCount);
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Label lbl_likeCount;
    }
}
