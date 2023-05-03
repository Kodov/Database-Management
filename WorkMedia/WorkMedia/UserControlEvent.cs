using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkMedia
{
    public partial class UserControlEvent : UserControl
    {
        public UserControlEvent()
        {
            InitializeComponent();
        }

        private void Event_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Event_description_TextChanged(object sender, EventArgs e)
        {

        }

        private void Post_event_button_Click(object sender, EventArgs e)
        {

        }

        private void date_Time_Picker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Image_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //openFileDialog1.Filter = "Image Files|.png;.jpg;*.img";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // The user selected a file, do something with it
                string filePath = openFileDialog1.FileName;
                // ... Do something with the file path
                string fileName = Path.GetFileName(openFileDialog1.FileName);
                file_label.Text = "Selected File: " + fileName;
                file_label.Visible = true;
            }
        }
    }
}
