using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkMedia
{
    public partial class UserControlContacts : UserControl
    {
        string text = null;
        public UserControlContacts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // when clicked, check the if the text matches any names in the database
            // for ( int i = 0; i < number of columns in the database for users; i ++)
            // if(text == "**Name of anyone in the database**")
            // {
            //    add that name to the user's friend list
            //    text = null;
            // }
            // 

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            text = AddFriendsBox.Text;
        }

        private void showAll()
        {
            // call this method to show all friends, regardless of status in 
            // the friends text box

        }

        private void showOnline()
        {
            // call this to show friends that are online in the friends text box
        }

        private void showOffline()
        {
            // call to show friends that are offline

        }

        private void showBusy()
        {
            // Call method to show friends that are busy
        }
    }
}
