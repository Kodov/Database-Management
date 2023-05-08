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
            this.components = new System.ComponentModel.Container();
            this.filter_date = new System.Windows.Forms.DateTimePicker();
            this.Filters_Check_List = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_Log = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalprojectDataSet = new WorkMedia.finalprojectDataSet();
            this.logsTableAdapter = new WorkMedia.finalprojectDataSetTableAdapters.LogsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Log)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalprojectDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // filter_date
            // 
            this.filter_date.Location = new System.Drawing.Point(627, 60);
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
            "Login",
            "Logout"});
            this.Filters_Check_List.Location = new System.Drawing.Point(627, 86);
            this.Filters_Check_List.Name = "Filters_Check_List";
            this.Filters_Check_List.Size = new System.Drawing.Size(120, 184);
            this.Filters_Check_List.TabIndex = 1;
            this.Filters_Check_List.SelectedIndexChanged += new System.EventHandler(this.Filters_Check_List_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.LightCoral;
            this.label2.Location = new System.Drawing.Point(620, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 39);
            this.label2.TabIndex = 8;
            this.label2.Text = "Filters";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(38, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "Logs";
            // 
            // dataGridView_Log
            // 
            this.dataGridView_Log.AutoGenerateColumns = false;
            this.dataGridView_Log.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Log.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.useridDataGridViewTextBoxColumn,
            this.actionDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.logoutDataGridViewTextBoxColumn});
            this.dataGridView_Log.DataSource = this.logsBindingSource;
            this.dataGridView_Log.Location = new System.Drawing.Point(45, 60);
            this.dataGridView_Log.Name = "dataGridView_Log";
            this.dataGridView_Log.Size = new System.Drawing.Size(544, 445);
            this.dataGridView_Log.TabIndex = 11;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "user_id";
            this.useridDataGridViewTextBoxColumn.HeaderText = "user_id";
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            // 
            // actionDataGridViewTextBoxColumn
            // 
            this.actionDataGridViewTextBoxColumn.DataPropertyName = "action";
            this.actionDataGridViewTextBoxColumn.HeaderText = "action";
            this.actionDataGridViewTextBoxColumn.Name = "actionDataGridViewTextBoxColumn";
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            // 
            // logoutDataGridViewTextBoxColumn
            // 
            this.logoutDataGridViewTextBoxColumn.DataPropertyName = "logout";
            this.logoutDataGridViewTextBoxColumn.HeaderText = "logout";
            this.logoutDataGridViewTextBoxColumn.Name = "logoutDataGridViewTextBoxColumn";
            // 
            // logsBindingSource
            // 
            this.logsBindingSource.DataMember = "Logs";
            this.logsBindingSource.DataSource = this.finalprojectDataSet;
            // 
            // finalprojectDataSet
            // 
            this.finalprojectDataSet.DataSetName = "finalprojectDataSet";
            this.finalprojectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // logsTableAdapter
            // 
            this.logsTableAdapter.ClearBeforeFill = true;
            // 
            // UserControlLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.Controls.Add(this.dataGridView_Log);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Filters_Check_List);
            this.Controls.Add(this.filter_date);
            this.Name = "UserControlLog";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(860, 530);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Log)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalprojectDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker filter_date;
        private System.Windows.Forms.CheckedListBox Filters_Check_List;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_Log;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource logsBindingSource;
        private finalprojectDataSet finalprojectDataSet;
        private finalprojectDataSetTableAdapters.LogsTableAdapter logsTableAdapter;
    }
}
