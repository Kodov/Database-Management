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
    public partial class UserControlSettings : UserControl
    {
        public UserControlSettings()
        {
            InitializeComponent();
        }

        private void Delete_Account_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {

            }
            else if (result == DialogResult.Cancel)
            {

            }

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            mainForm.isAuthorized = false;
            mainForm.picbox_home_Click(this, EventArgs.Empty);
        }
    }
}
