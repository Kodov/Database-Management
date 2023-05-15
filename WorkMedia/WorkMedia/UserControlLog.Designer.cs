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
            this.logsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.finalprojectDataSet3 = new WorkMedia.finalprojectDataSet3();
            this.logsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalprojectDataSet = new WorkMedia.finalprojectDataSet();
            this.logsTableAdapter = new WorkMedia.finalprojectDataSetTableAdapters.LogsTableAdapter();
            this.btn_search = new System.Windows.Forms.Button();
            this.finalprojectDataSet1 = new WorkMedia.finalprojectDataSet1();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new WorkMedia.finalprojectDataSet1TableAdapters.usersTableAdapter();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.finalprojectDataSet2 = new WorkMedia.finalprojectDataSet2();
            this.usersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter1 = new WorkMedia.finalprojectDataSet2TableAdapters.usersTableAdapter();
            this.checkbox_dateFilter = new System.Windows.Forms.CheckBox();
            this.logsTableAdapter1 = new WorkMedia.finalprojectDataSet3TableAdapters.LogsTableAdapter();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Log)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalprojectDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalprojectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalprojectDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalprojectDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // filter_date
            // 
            this.filter_date.Location = new System.Drawing.Point(627, 89);
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
            "Bug Report"});
            this.Filters_Check_List.Location = new System.Drawing.Point(627, 138);
            this.Filters_Check_List.Name = "Filters_Check_List";
            this.Filters_Check_List.Size = new System.Drawing.Size(120, 154);
            this.Filters_Check_List.TabIndex = 1;
            this.Filters_Check_List.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.Filters_Check_List_ItemCheck);
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
            this.dataGridView_Log.AllowUserToAddRows = false;
            this.dataGridView_Log.AllowUserToDeleteRows = false;
            this.dataGridView_Log.AutoGenerateColumns = false;
            this.dataGridView_Log.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Log.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.useridDataGridViewTextBoxColumn,
            this.action,
            this.login});
            this.dataGridView_Log.DataSource = this.logsBindingSource1;
            this.dataGridView_Log.Location = new System.Drawing.Point(45, 60);
            this.dataGridView_Log.Name = "dataGridView_Log";
            this.dataGridView_Log.ReadOnly = true;
            this.dataGridView_Log.Size = new System.Drawing.Size(409, 445);
            this.dataGridView_Log.TabIndex = 11;
            // 
            // logsBindingSource1
            // 
            this.logsBindingSource1.DataMember = "Logs";
            this.logsBindingSource1.DataSource = this.finalprojectDataSet3;
            // 
            // finalprojectDataSet3
            // 
            this.finalprojectDataSet3.DataSetName = "finalprojectDataSet3";
            this.finalprojectDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Brown;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.LightCoral;
            this.btn_search.Location = new System.Drawing.Point(627, 322);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(121, 42);
            this.btn_search.TabIndex = 34;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
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
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "users";
            this.usersBindingSource1.DataSource = this.finalprojectDataSet1;
            // 
            // finalprojectDataSet2
            // 
            this.finalprojectDataSet2.DataSetName = "finalprojectDataSet2";
            this.finalprojectDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource2
            // 
            this.usersBindingSource2.DataMember = "users";
            this.usersBindingSource2.DataSource = this.finalprojectDataSet2;
            // 
            // usersTableAdapter1
            // 
            this.usersTableAdapter1.ClearBeforeFill = true;
            // 
            // checkbox_dateFilter
            // 
            this.checkbox_dateFilter.AutoSize = true;
            this.checkbox_dateFilter.Location = new System.Drawing.Point(627, 66);
            this.checkbox_dateFilter.Name = "checkbox_dateFilter";
            this.checkbox_dateFilter.Size = new System.Drawing.Size(110, 17);
            this.checkbox_dateFilter.TabIndex = 35;
            this.checkbox_dateFilter.Text = "Enable Date Filter";
            this.checkbox_dateFilter.UseVisualStyleBackColor = true;
            this.checkbox_dateFilter.CheckedChanged += new System.EventHandler(this.checkbox_dateFilter_CheckedChanged);
            // 
            // logsTableAdapter1
            // 
            this.logsTableAdapter1.ClearBeforeFill = true;
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "user_id";
            this.useridDataGridViewTextBoxColumn.HeaderText = "user_id";
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            this.useridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // action
            // 
            this.action.DataPropertyName = "action";
            this.action.HeaderText = "action";
            this.action.Name = "action";
            this.action.ReadOnly = true;
            this.action.Width = 125;
            // 
            // login
            // 
            this.login.DataPropertyName = "login";
            this.login.HeaderText = "login";
            this.login.Name = "login";
            this.login.ReadOnly = true;
            this.login.Width = 140;
            // 
            // UserControlLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.Controls.Add(this.checkbox_dateFilter);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.dataGridView_Log);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Filters_Check_List);
            this.Controls.Add(this.filter_date);
            this.Name = "UserControlLog";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(860, 530);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Log)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalprojectDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalprojectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalprojectDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalprojectDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker filter_date;
        private System.Windows.Forms.CheckedListBox Filters_Check_List;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_Log;
        private System.Windows.Forms.BindingSource logsBindingSource;
        private finalprojectDataSet finalprojectDataSet;
        private finalprojectDataSetTableAdapters.LogsTableAdapter logsTableAdapter;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.BindingSource usersBindingSource2;
        private finalprojectDataSet2 finalprojectDataSet2;
        private finalprojectDataSet1 finalprojectDataSet1;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private finalprojectDataSet1TableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private finalprojectDataSet2TableAdapters.usersTableAdapter usersTableAdapter1;
        private System.Windows.Forms.CheckBox checkbox_dateFilter;
        private System.Windows.Forms.BindingSource logsBindingSource1;
        private finalprojectDataSet3 finalprojectDataSet3;
        private finalprojectDataSet3TableAdapters.LogsTableAdapter logsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn action;
        private System.Windows.Forms.DataGridViewTextBoxColumn login;
    }
}
