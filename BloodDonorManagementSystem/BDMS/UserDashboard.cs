using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BDMS
{
    public partial class UserDashboard : Form
    {
        string connectionStr = "Server=localhost;Database=BDMS;Trusted_Connection=True;";
        string fullname;
        public UserDashboard()
        {
            InitializeComponent();
        }  
        public UserDashboard(string f)
        {
            this.fullname=f;
            InitializeComponent();
        }


        private void getAllRecords()
        {

            SqlConnection connection = new SqlConnection(this.connectionStr);
            connection.Open();

            try
            {
                string query = "Select id,email,full_name,phone,blood_group,donation_count,last_donated,address From donars";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }
            finally
            {
                connection.Close();
            }



        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
            this.getAllRecords();
            usernameText.Text = this.fullname;
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().ShowDialog();
        }
    }
}
