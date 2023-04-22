using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkMedia
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
            txtbox_report.MaxLength = 100;
            lbl_charLimit.Text = txtbox_report.Text.Length + "/100";
        }

        private void txtbox_report_TextChanged(object sender, EventArgs e)
        {
            lbl_charLimit.Text = txtbox_report.Text.Length + "/100";
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            // TODO add db query

            this.Close();

            
        }
    }
}
