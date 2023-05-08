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
    public partial class UserControlHome : UserControl
    {
        public UserControlHome()
        {
            InitializeComponent();
        }

        MainForm mf;

        private void btn_loadFeed_Click(object sender, EventArgs e)
        {
            //TODO: GET FIRST ITEM FOR PAGE? OR LEAVE IT UP TO ARROW CLICKS
        }
    }
}
