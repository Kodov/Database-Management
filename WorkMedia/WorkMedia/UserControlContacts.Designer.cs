﻿namespace WorkMedia
{
    partial class UserControlContacts
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
            this.button1 = new System.Windows.Forms.Button();
            this.finalprojectDataSet1 = new WorkMedia.finalprojectDataSet1();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new WorkMedia.finalprojectDataSet1TableAdapters.usersTableAdapter();
            this.finalprojectDataSet2 = new WorkMedia.finalprojectDataSet2();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter1 = new WorkMedia.finalprojectDataSet2TableAdapters.usersTableAdapter();
            this.finalprojectDataSet = new WorkMedia.finalprojectDataSet();
            this.logsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logsTableAdapter = new WorkMedia.finalprojectDataSetTableAdapters.LogsTableAdapter();
            this.usersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.finalprojectDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalprojectDataSet4 = new WorkMedia.finalprojectDataSet4();
            this.finalprojectDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.finalprojectDataSet5 = new WorkMedia.finalprojectDataSet5();
            this.usersTableAdapter2 = new WorkMedia.finalprojectDataSet5TableAdapters.usersTableAdapter();
            this.finalprojectDataSet7 = new WorkMedia.finalprojectDataSet7();
            this.usersBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter3 = new WorkMedia.finalprojectDataSet7TableAdapters.usersTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.friend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.friendsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalprojectDataSet8 = new WorkMedia.finalprojectDataSet8();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_updateFriends = new System.Windows.Forms.Button();
            this.btn_removeFriend = new System.Windows.Forms.Button();
            this.friendsTableAdapter = new WorkMedia.finalprojectDataSet8TableAdapters.friendsTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.finalprojectDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalprojectDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalprojectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalprojectDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalprojectDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalprojectDataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalprojectDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalprojectDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalprojectDataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.LightCoral;
            this.button1.Location = new System.Drawing.Point(572, 426);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add Friend";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // finalprojectDataSet1
            // 
            this.finalprojectDataSet1.DataSetName = "finalprojectDataSet1";
            this.finalprojectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.finalprojectDataSet1;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // finalprojectDataSet2
            // 
            this.finalprojectDataSet2.DataSetName = "finalprojectDataSet2";
            this.finalprojectDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "users";
            this.usersBindingSource1.DataSource = this.finalprojectDataSet2;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // finalprojectDataSet
            // 
            this.finalprojectDataSet.DataSetName = "finalprojectDataSet";
            this.finalprojectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // logsBindingSource
            // 
            this.logsBindingSource.DataMember = "Logs";
            this.logsBindingSource.DataSource = this.finalprojectDataSet;
            // 
            // logsTableAdapter
            // 
            this.logsTableAdapter.ClearBeforeFill = true;
            // 
            // usersBindingSource2
            // 
            this.usersBindingSource2.DataMember = "users";
            this.usersBindingSource2.DataSource = this.finalprojectDataSet1;
            // 
            // finalprojectDataSetBindingSource
            // 
            this.finalprojectDataSetBindingSource.DataSource = this.finalprojectDataSet;
            this.finalprojectDataSetBindingSource.Position = 0;
            // 
            // finalprojectDataSet4
            // 
            this.finalprojectDataSet4.DataSetName = "finalprojectDataSet4";
            this.finalprojectDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // finalprojectDataSet4BindingSource
            // 
            this.finalprojectDataSet4BindingSource.DataSource = this.finalprojectDataSet4;
            this.finalprojectDataSet4BindingSource.Position = 0;
            // 
            // usersBindingSource3
            // 
            this.usersBindingSource3.DataMember = "users";
            this.usersBindingSource3.DataSource = this.finalprojectDataSet5;
            // 
            // finalprojectDataSet5
            // 
            this.finalprojectDataSet5.DataSetName = "finalprojectDataSet5";
            this.finalprojectDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter2
            // 
            this.usersTableAdapter2.ClearBeforeFill = true;
            // 
            // finalprojectDataSet7
            // 
            this.finalprojectDataSet7.DataSetName = "finalprojectDataSet7";
            this.finalprojectDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource4
            // 
            this.usersBindingSource4.DataMember = "users";
            this.usersBindingSource4.DataSource = this.finalprojectDataSet7;
            // 
            // usersTableAdapter3
            // 
            this.usersTableAdapter3.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.username,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usersBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(389, 56);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(428, 347);
            this.dataGridView1.TabIndex = 4;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "username";
            this.username.MinimumWidth = 6;
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.username.Width = 125;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "first_name";
            this.firstnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstnameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.firstnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "last_name";
            this.lastnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastnameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.lastnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.friend});
            this.dataGridView2.DataSource = this.friendsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(126, 56);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(144, 347);
            this.dataGridView2.TabIndex = 5;
            // 
            // friend
            // 
            this.friend.DataPropertyName = "friend";
            this.friend.HeaderText = "friend";
            this.friend.Name = "friend";
            this.friend.ReadOnly = true;
            this.friend.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // friendsBindingSource
            // 
            this.friendsBindingSource.DataMember = "friends";
            this.friendsBindingSource.DataSource = this.finalprojectDataSet8;
            // 
            // finalprojectDataSet8
            // 
            this.finalprojectDataSet8.DataSetName = "finalprojectDataSet8";
            this.finalprojectDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Brown;
            this.label7.Location = new System.Drawing.Point(122, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 23);
            this.label7.TabIndex = 29;
            this.label7.Text = "Friends";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(385, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 30;
            this.label1.Text = "Contacts";
            // 
            // btn_updateFriends
            // 
            this.btn_updateFriends.BackColor = System.Drawing.Color.Brown;
            this.btn_updateFriends.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateFriends.ForeColor = System.Drawing.Color.LightCoral;
            this.btn_updateFriends.Location = new System.Drawing.Point(158, 426);
            this.btn_updateFriends.Margin = new System.Windows.Forms.Padding(2);
            this.btn_updateFriends.Name = "btn_updateFriends";
            this.btn_updateFriends.Size = new System.Drawing.Size(75, 25);
            this.btn_updateFriends.TabIndex = 31;
            this.btn_updateFriends.Text = "Update";
            this.btn_updateFriends.UseVisualStyleBackColor = false;
            this.btn_updateFriends.Click += new System.EventHandler(this.btn_updateFriends_Click);
            // 
            // btn_removeFriend
            // 
            this.btn_removeFriend.BackColor = System.Drawing.Color.Brown;
            this.btn_removeFriend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_removeFriend.ForeColor = System.Drawing.Color.LightCoral;
            this.btn_removeFriend.Location = new System.Drawing.Point(158, 467);
            this.btn_removeFriend.Margin = new System.Windows.Forms.Padding(2);
            this.btn_removeFriend.Name = "btn_removeFriend";
            this.btn_removeFriend.Size = new System.Drawing.Size(75, 25);
            this.btn_removeFriend.TabIndex = 32;
            this.btn_removeFriend.Text = "Remove";
            this.btn_removeFriend.UseVisualStyleBackColor = false;
            this.btn_removeFriend.Click += new System.EventHandler(this.btn_removeFriend_Click);
            // 
            // friendsTableAdapter
            // 
            this.friendsTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(569, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "(Select left-most cell to get proper results)";
            // 
            // UserControlContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_removeFriend);
            this.Controls.Add(this.btn_updateFriends);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "UserControlContacts";
            this.Size = new System.Drawing.Size(860, 530);
            ((System.ComponentModel.ISupportInitialize)(this.finalprojectDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalprojectDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalprojectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalprojectDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalprojectDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalprojectDataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalprojectDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalprojectDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalprojectDataSet8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private finalprojectDataSet1 finalprojectDataSet1;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private finalprojectDataSet1TableAdapters.usersTableAdapter usersTableAdapter;
        private finalprojectDataSet2 finalprojectDataSet2;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private finalprojectDataSet2TableAdapters.usersTableAdapter usersTableAdapter1;
        private finalprojectDataSet finalprojectDataSet;
        private System.Windows.Forms.BindingSource logsBindingSource;
        private finalprojectDataSetTableAdapters.LogsTableAdapter logsTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource2;
        private System.Windows.Forms.BindingSource finalprojectDataSetBindingSource;
        private finalprojectDataSet4 finalprojectDataSet4;
        private System.Windows.Forms.BindingSource finalprojectDataSet4BindingSource;
        private System.Windows.Forms.BindingSource usersBindingSource3;
        private finalprojectDataSet5 finalprojectDataSet5;
        private finalprojectDataSet5TableAdapters.usersTableAdapter usersTableAdapter2;
        private System.Windows.Forms.BindingSource usersBindingSource4;
        private finalprojectDataSet7 finalprojectDataSet7;
        private finalprojectDataSet7TableAdapters.usersTableAdapter usersTableAdapter3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_updateFriends;
        private System.Windows.Forms.Button btn_removeFriend;
        private System.Windows.Forms.BindingSource friendsBindingSource;
        private finalprojectDataSet8 finalprojectDataSet8;
        private finalprojectDataSet8TableAdapters.friendsTableAdapter friendsTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn friend;
    }
}
