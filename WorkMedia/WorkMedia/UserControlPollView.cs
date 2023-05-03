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
    public partial class UserControlPollView : UserControl
    {

        public UserControlPollView()
        {
            InitializeComponent();
            PollChart.Visible = false;

        }

        private void DisableAllCheckboxes()
        {
            checkBox_Option1.Enabled = false;
            checkBox_Option2.Enabled = false;
            checkBox_Option3.Enabled = false;
            checkBox_Option4.Enabled = false;
            checkBox_Option5.Enabled = false;

            checkBox_Option1.ForeColor = SystemColors.GrayText;
            checkBox_Option2.ForeColor = SystemColors.GrayText;
            checkBox_Option3.ForeColor = SystemColors.GrayText;
            checkBox_Option4.ForeColor = SystemColors.GrayText;
            checkBox_Option5.ForeColor = SystemColors.GrayText;
        }

        private void checkBox_Option1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Option1.Checked)
            {
                DisableAllCheckboxes();
                PollChart.Visible = true;
            }
        }

        private void checkBox_Option2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Option2.Checked)
            {
                DisableAllCheckboxes();
                PollChart.Visible = true;
            }
        }

        private void checkBox_Option3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Option3.Checked)
            {
                DisableAllCheckboxes();
                PollChart.Visible = true;
            }
        }

        private void checkBox_Option4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Option4.Checked)
            {
                DisableAllCheckboxes();
                PollChart.Visible = true;
            }
        }

        private void checkBox_Option5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Option5.Checked)
            {
                DisableAllCheckboxes();
                PollChart.Visible = true;
            }
        }
    }
}
