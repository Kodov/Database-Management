﻿namespace WorkMedia
{
    partial class UserControlPollView
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lbl_PollTitle = new System.Windows.Forms.Label();
            this.checkBox_Option1 = new System.Windows.Forms.CheckBox();
            this.checkBox_Option2 = new System.Windows.Forms.CheckBox();
            this.checkBox_Option3 = new System.Windows.Forms.CheckBox();
            this.checkBox_Option4 = new System.Windows.Forms.CheckBox();
            this.checkBox_Option5 = new System.Windows.Forms.CheckBox();
            this.PollChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.PollChart)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_PollTitle
            // 
            this.lbl_PollTitle.AutoSize = true;
            this.lbl_PollTitle.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PollTitle.ForeColor = System.Drawing.Color.Brown;
            this.lbl_PollTitle.Location = new System.Drawing.Point(82, 77);
            this.lbl_PollTitle.Name = "lbl_PollTitle";
            this.lbl_PollTitle.Size = new System.Drawing.Size(95, 29);
            this.lbl_PollTitle.TabIndex = 29;
            this.lbl_PollTitle.Text = "Poll Title";
            // 
            // checkBox_Option1
            // 
            this.checkBox_Option1.AutoSize = true;
            this.checkBox_Option1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Option1.ForeColor = System.Drawing.Color.IndianRed;
            this.checkBox_Option1.Location = new System.Drawing.Point(87, 133);
            this.checkBox_Option1.Name = "checkBox_Option1";
            this.checkBox_Option1.Size = new System.Drawing.Size(90, 27);
            this.checkBox_Option1.TabIndex = 31;
            this.checkBox_Option1.Text = "Option 1";
            this.checkBox_Option1.UseVisualStyleBackColor = true;
            this.checkBox_Option1.CheckedChanged += new System.EventHandler(this.checkBox_Option1_CheckedChanged);
            // 
            // checkBox_Option2
            // 
            this.checkBox_Option2.AutoSize = true;
            this.checkBox_Option2.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Option2.ForeColor = System.Drawing.Color.IndianRed;
            this.checkBox_Option2.Location = new System.Drawing.Point(87, 206);
            this.checkBox_Option2.Name = "checkBox_Option2";
            this.checkBox_Option2.Size = new System.Drawing.Size(93, 27);
            this.checkBox_Option2.TabIndex = 32;
            this.checkBox_Option2.Text = "Option 2";
            this.checkBox_Option2.UseVisualStyleBackColor = true;
            this.checkBox_Option2.CheckedChanged += new System.EventHandler(this.checkBox_Option2_CheckedChanged);
            // 
            // checkBox_Option3
            // 
            this.checkBox_Option3.AutoSize = true;
            this.checkBox_Option3.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Option3.ForeColor = System.Drawing.Color.IndianRed;
            this.checkBox_Option3.Location = new System.Drawing.Point(87, 279);
            this.checkBox_Option3.Name = "checkBox_Option3";
            this.checkBox_Option3.Size = new System.Drawing.Size(93, 27);
            this.checkBox_Option3.TabIndex = 33;
            this.checkBox_Option3.Text = "Option 3";
            this.checkBox_Option3.UseVisualStyleBackColor = true;
            this.checkBox_Option3.CheckedChanged += new System.EventHandler(this.checkBox_Option3_CheckedChanged);
            // 
            // checkBox_Option4
            // 
            this.checkBox_Option4.AutoSize = true;
            this.checkBox_Option4.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Option4.ForeColor = System.Drawing.Color.IndianRed;
            this.checkBox_Option4.Location = new System.Drawing.Point(87, 352);
            this.checkBox_Option4.Name = "checkBox_Option4";
            this.checkBox_Option4.Size = new System.Drawing.Size(92, 27);
            this.checkBox_Option4.TabIndex = 34;
            this.checkBox_Option4.Text = "Option 4";
            this.checkBox_Option4.UseVisualStyleBackColor = true;
            this.checkBox_Option4.CheckedChanged += new System.EventHandler(this.checkBox_Option4_CheckedChanged);
            // 
            // checkBox_Option5
            // 
            this.checkBox_Option5.AutoSize = true;
            this.checkBox_Option5.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_Option5.ForeColor = System.Drawing.Color.IndianRed;
            this.checkBox_Option5.Location = new System.Drawing.Point(87, 425);
            this.checkBox_Option5.Name = "checkBox_Option5";
            this.checkBox_Option5.Size = new System.Drawing.Size(93, 27);
            this.checkBox_Option5.TabIndex = 35;
            this.checkBox_Option5.Text = "Option 5";
            this.checkBox_Option5.UseVisualStyleBackColor = true;
            this.checkBox_Option5.CheckedChanged += new System.EventHandler(this.checkBox_Option5_CheckedChanged);
            // 
            // PollChart
            // 
            chartArea1.Name = "ChartArea1";
            this.PollChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.PollChart.Legends.Add(legend1);
            this.PollChart.Location = new System.Drawing.Point(329, 77);
            this.PollChart.Name = "PollChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.PollChart.Series.Add(series1);
            this.PollChart.Size = new System.Drawing.Size(485, 409);
            this.PollChart.TabIndex = 36;
            this.PollChart.Text = "PollChart";
            // 
            // UserControlPollView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.Controls.Add(this.PollChart);
            this.Controls.Add(this.checkBox_Option5);
            this.Controls.Add(this.checkBox_Option4);
            this.Controls.Add(this.checkBox_Option3);
            this.Controls.Add(this.checkBox_Option2);
            this.Controls.Add(this.checkBox_Option1);
            this.Controls.Add(this.lbl_PollTitle);
            this.Name = "UserControlPollView";
            this.Size = new System.Drawing.Size(860, 530);
            ((System.ComponentModel.ISupportInitialize)(this.PollChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_PollTitle;
        public System.Windows.Forms.CheckBox checkBox_Option1;
        public System.Windows.Forms.CheckBox checkBox_Option2;
        public System.Windows.Forms.CheckBox checkBox_Option3;
        public System.Windows.Forms.CheckBox checkBox_Option4;
        public System.Windows.Forms.CheckBox checkBox_Option5;
        public System.Windows.Forms.DataVisualization.Charting.Chart PollChart;
    }
}
