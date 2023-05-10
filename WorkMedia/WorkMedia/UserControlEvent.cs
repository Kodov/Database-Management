using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WorkMedia
{
    public partial class UserControlEvent : UserControl
    {
        public int currentUserId;
        string filePath;
        string fileName;
        string getfilePath;
        Image image;

        public UserControlEvent()
        {
            InitializeComponent();
        }

        private void Discard()
        {
            Event_name.Clear();
            Event_description.Clear();
            image.Dispose();
            file_label.Text = string.Empty;
        }

        private void Event_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Event_description_TextChanged(object sender, EventArgs e)
        {

        }

        private void Post_event_button_Click(object sender, EventArgs e)
        {
            MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            mainForm.SetCurrentUserIdEvent();
            int user_id = currentUserId;


            // TODO: send event info to events table
            string title = Event_name.Text;
            string description = Event_description.Text;
            string date = date_Time_Picker.Value.ToString("yyyy-MM-dd");
            image = Image.FromFile(getfilePath);

            string connectionString = "Data Source=localhost;Initial Catalog=finalproject;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "Insert INTO events ( title, date, image, description, user_id, created) " +
                        "VALUES ( @title, @date, @image, @description, @user_id, @created)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Set parameter values
                        command.Parameters.AddWithValue("@title", title);
                        command.Parameters.AddWithValue("@description", description);
                        command.Parameters.AddWithValue("@date", date);
                        command.Parameters.AddWithValue("@image", image);
                        command.Parameters.AddWithValue("@user_id", user_id);
                        command.Parameters.AddWithValue("@created", DateTime.Now);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Event created successfully!");
                            Discard();
                        }
                        else
                        {
                            MessageBox.Show("Event creation failed!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

        }

        private void date_Time_Picker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Image_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //openFileDialog1.Filter = "Image Files|.png;.jpg;*.img";
            // TODO: find a way so only these file types can be chosen ^

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // The user selected a file, do something with it
                filePath = openFileDialog1.FileName;
                getfilePath = Path.GetFullPath(openFileDialog1.FileName);
                // ... Do something with the file path
                fileName = Path.GetFileName(openFileDialog1.FileName);
                file_label.Text = "Selected File: " + fileName;
                file_label.Visible = true;
            }
        }
    }
}
