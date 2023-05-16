namespace WorkMedia
{
    partial class UserControlTeams
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
            this.teamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalprojectDataSet6 = new WorkMedia.finalprojectDataSet6();
            this.teamsTableAdapter = new WorkMedia.finalprojectDataSet6TableAdapters.TeamsTableAdapter();
            this.dataGridView_Teams = new System.Windows.Forms.DataGridView();
            this.teamsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.finalprojectDataSet9 = new WorkMedia.finalprojectDataSet9();
            this.teamsTableAdapter1 = new WorkMedia.finalprojectDataSet9TableAdapters.TeamsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_viewTeam = new System.Windows.Forms.Button();
            this.btn_joinTeam = new System.Windows.Forms.Button();
            this.txtbox_createTeam = new System.Windows.Forms.TextBox();
            this.dataGridView_Members = new System.Windows.Forms.DataGridView();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalprojectDataSet11 = new WorkMedia.finalprojectDataSet11();
            this.finalprojectDataSet10 = new WorkMedia.finalprojectDataSet10();
            this.teamsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.teamsTableAdapter2 = new WorkMedia.finalprojectDataSet10TableAdapters.TeamsTableAdapter();
            this.usersTableAdapter = new WorkMedia.finalprojectDataSet11TableAdapters.usersTableAdapter();
            this.btn_createTeam = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_LeaveTeam = new System.Windows.Forms.Button();
            this.team_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.member_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_updateTeam = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalprojectDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Teams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalprojectDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Members)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalprojectDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalprojectDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // teamsBindingSource
            // 
            this.teamsBindingSource.DataMember = "Teams";
            this.teamsBindingSource.DataSource = this.finalprojectDataSet6;
            // 
            // finalprojectDataSet6
            // 
            this.finalprojectDataSet6.DataSetName = "finalprojectDataSet6";
            this.finalprojectDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teamsTableAdapter
            // 
            this.teamsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView_Teams
            // 
            this.dataGridView_Teams.AllowUserToAddRows = false;
            this.dataGridView_Teams.AllowUserToDeleteRows = false;
            this.dataGridView_Teams.AutoGenerateColumns = false;
            this.dataGridView_Teams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Teams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.team_name,
            this.member_id});
            this.dataGridView_Teams.DataSource = this.teamsBindingSource1;
            this.dataGridView_Teams.Location = new System.Drawing.Point(226, 75);
            this.dataGridView_Teams.Name = "dataGridView_Teams";
            this.dataGridView_Teams.ReadOnly = true;
            this.dataGridView_Teams.Size = new System.Drawing.Size(243, 359);
            this.dataGridView_Teams.TabIndex = 0;
            // 
            // teamsBindingSource1
            // 
            this.teamsBindingSource1.DataMember = "Teams";
            this.teamsBindingSource1.DataSource = this.finalprojectDataSet9;
            // 
            // finalprojectDataSet9
            // 
            this.finalprojectDataSet9.DataSetName = "finalprojectDataSet9";
            this.finalprojectDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teamsTableAdapter1
            // 
            this.teamsTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(222, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 31;
            this.label1.Text = "Teams";
            // 
            // btn_viewTeam
            // 
            this.btn_viewTeam.BackColor = System.Drawing.Color.Brown;
            this.btn_viewTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_viewTeam.ForeColor = System.Drawing.Color.LightCoral;
            this.btn_viewTeam.Location = new System.Drawing.Point(225, 484);
            this.btn_viewTeam.Margin = new System.Windows.Forms.Padding(2);
            this.btn_viewTeam.Name = "btn_viewTeam";
            this.btn_viewTeam.Size = new System.Drawing.Size(78, 25);
            this.btn_viewTeam.TabIndex = 32;
            this.btn_viewTeam.Text = "View Team";
            this.btn_viewTeam.UseVisualStyleBackColor = false;
            this.btn_viewTeam.Click += new System.EventHandler(this.btn_viewTeam_Click);
            // 
            // btn_joinTeam
            // 
            this.btn_joinTeam.BackColor = System.Drawing.Color.Brown;
            this.btn_joinTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_joinTeam.ForeColor = System.Drawing.Color.LightCoral;
            this.btn_joinTeam.Location = new System.Drawing.Point(306, 484);
            this.btn_joinTeam.Margin = new System.Windows.Forms.Padding(2);
            this.btn_joinTeam.Name = "btn_joinTeam";
            this.btn_joinTeam.Size = new System.Drawing.Size(78, 25);
            this.btn_joinTeam.TabIndex = 33;
            this.btn_joinTeam.Text = "Join Team";
            this.btn_joinTeam.UseVisualStyleBackColor = false;
            this.btn_joinTeam.Click += new System.EventHandler(this.btn_joinTeam_Click);
            // 
            // txtbox_createTeam
            // 
            this.txtbox_createTeam.Location = new System.Drawing.Point(32, 231);
            this.txtbox_createTeam.Name = "txtbox_createTeam";
            this.txtbox_createTeam.Size = new System.Drawing.Size(158, 20);
            this.txtbox_createTeam.TabIndex = 34;
            // 
            // dataGridView_Members
            // 
            this.dataGridView_Members.AllowUserToAddRows = false;
            this.dataGridView_Members.AllowUserToDeleteRows = false;
            this.dataGridView_Members.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Members.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.username,
            this.first_name,
            this.last_name});
            this.dataGridView_Members.Location = new System.Drawing.Point(498, 75);
            this.dataGridView_Members.Name = "dataGridView_Members";
            this.dataGridView_Members.ReadOnly = true;
            this.dataGridView_Members.Size = new System.Drawing.Size(343, 359);
            this.dataGridView_Members.TabIndex = 35;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.finalprojectDataSet11;
            // 
            // finalprojectDataSet11
            // 
            this.finalprojectDataSet11.DataSetName = "finalprojectDataSet11";
            this.finalprojectDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // finalprojectDataSet10
            // 
            this.finalprojectDataSet10.DataSetName = "finalprojectDataSet10";
            this.finalprojectDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teamsBindingSource2
            // 
            this.teamsBindingSource2.DataMember = "Teams";
            this.teamsBindingSource2.DataSource = this.finalprojectDataSet10;
            // 
            // teamsTableAdapter2
            // 
            this.teamsTableAdapter2.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // btn_createTeam
            // 
            this.btn_createTeam.BackColor = System.Drawing.Color.Brown;
            this.btn_createTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_createTeam.ForeColor = System.Drawing.Color.LightCoral;
            this.btn_createTeam.Location = new System.Drawing.Point(65, 266);
            this.btn_createTeam.Margin = new System.Windows.Forms.Padding(2);
            this.btn_createTeam.Name = "btn_createTeam";
            this.btn_createTeam.Size = new System.Drawing.Size(95, 25);
            this.btn_createTeam.TabIndex = 36;
            this.btn_createTeam.Text = "Create Team";
            this.btn_createTeam.UseVisualStyleBackColor = false;
            this.btn_createTeam.Click += new System.EventHandler(this.btn_createTeam_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(494, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 37;
            this.label2.Text = "Members";
            // 
            // btn_LeaveTeam
            // 
            this.btn_LeaveTeam.BackColor = System.Drawing.Color.Brown;
            this.btn_LeaveTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LeaveTeam.ForeColor = System.Drawing.Color.LightCoral;
            this.btn_LeaveTeam.Location = new System.Drawing.Point(387, 484);
            this.btn_LeaveTeam.Margin = new System.Windows.Forms.Padding(2);
            this.btn_LeaveTeam.Name = "btn_LeaveTeam";
            this.btn_LeaveTeam.Size = new System.Drawing.Size(82, 25);
            this.btn_LeaveTeam.TabIndex = 38;
            this.btn_LeaveTeam.Text = "Leave Team";
            this.btn_LeaveTeam.UseVisualStyleBackColor = false;
            this.btn_LeaveTeam.Click += new System.EventHandler(this.btn_LeaveTeam_Click);
            // 
            // team_name
            // 
            this.team_name.DataPropertyName = "team_name";
            this.team_name.HeaderText = "team_name";
            this.team_name.Name = "team_name";
            this.team_name.ReadOnly = true;
            this.team_name.Width = 200;
            // 
            // member_id
            // 
            this.member_id.DataPropertyName = "member_id";
            this.member_id.HeaderText = "member_id";
            this.member_id.Name = "member_id";
            this.member_id.ReadOnly = true;
            this.member_id.Visible = false;
            // 
            // btn_updateTeam
            // 
            this.btn_updateTeam.BackColor = System.Drawing.Color.Brown;
            this.btn_updateTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updateTeam.ForeColor = System.Drawing.Color.LightCoral;
            this.btn_updateTeam.Location = new System.Drawing.Point(302, 439);
            this.btn_updateTeam.Margin = new System.Windows.Forms.Padding(2);
            this.btn_updateTeam.Name = "btn_updateTeam";
            this.btn_updateTeam.Size = new System.Drawing.Size(88, 25);
            this.btn_updateTeam.TabIndex = 39;
            this.btn_updateTeam.Text = "Update Teams";
            this.btn_updateTeam.UseVisualStyleBackColor = false;
            this.btn_updateTeam.Click += new System.EventHandler(this.btn_updateTeam_Click);
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "username";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // first_name
            // 
            this.first_name.DataPropertyName = "first_name";
            this.first_name.HeaderText = "first_name";
            this.first_name.Name = "first_name";
            this.first_name.ReadOnly = true;
            // 
            // last_name
            // 
            this.last_name.DataPropertyName = "last_name";
            this.last_name.HeaderText = "last_name";
            this.last_name.Name = "last_name";
            this.last_name.ReadOnly = true;
            // 
            // UserControlTeams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.Controls.Add(this.btn_updateTeam);
            this.Controls.Add(this.btn_LeaveTeam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_createTeam);
            this.Controls.Add(this.dataGridView_Members);
            this.Controls.Add(this.txtbox_createTeam);
            this.Controls.Add(this.btn_joinTeam);
            this.Controls.Add(this.btn_viewTeam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_Teams);
            this.ForeColor = System.Drawing.Color.LightCoral;
            this.Name = "UserControlTeams";
            this.Size = new System.Drawing.Size(860, 530);
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalprojectDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Teams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalprojectDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Members)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalprojectDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalprojectDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamsBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource teamsBindingSource;
        private finalprojectDataSet6 finalprojectDataSet6;
        private finalprojectDataSet6TableAdapters.TeamsTableAdapter teamsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView_Teams;
        private System.Windows.Forms.BindingSource teamsBindingSource1;
        private finalprojectDataSet9 finalprojectDataSet9;
        private finalprojectDataSet9TableAdapters.TeamsTableAdapter teamsTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_viewTeam;
        private System.Windows.Forms.Button btn_joinTeam;
        private System.Windows.Forms.TextBox txtbox_createTeam;
        private System.Windows.Forms.DataGridView dataGridView_Members;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private finalprojectDataSet11 finalprojectDataSet11;
        private finalprojectDataSet10 finalprojectDataSet10;
        private System.Windows.Forms.BindingSource teamsBindingSource2;
        private finalprojectDataSet10TableAdapters.TeamsTableAdapter teamsTableAdapter2;
        private finalprojectDataSet11TableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Button btn_createTeam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_LeaveTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn team_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn member_id;
        private System.Windows.Forms.Button btn_updateTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name;
    }
}
