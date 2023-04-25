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
    public partial class UserControlTeams : UserControl
    {
        string createTeam = null;
        string joinTeam;
        string leaveTeam;
        public UserControlTeams()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            createTeam = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            joinTeam = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            leaveTeam = textBox3.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // creates a team if there is a name in the team name box
            // that is not a duplicate team name
            // for (int i = 0; i < numOfTeams; i ++)
            // {
            //    if(text != null && text != "** other team names**")
            //    {
            //        addTeam;
            //    }
            // }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // joins a team if the name entered in the text box exists

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // leaves a team if the name entered in the text box exists

        }

        private void showTeams()
        {
            // show all the teams
        }
    }
}
