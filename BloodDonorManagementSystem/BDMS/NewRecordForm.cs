using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace BDMS
{
    public partial class NewRecordForm : Form
    {
        string connectionStr = @"Server=localhost;Database=BDMS;Trusted_Connection=True;";

        public NewRecordForm()
        {
            InitializeComponent();
        }
        private void clearForm()
        {
            email.Text = "";
            fullname.Text = "";
            phone.Text = "";
            bloodGroup.Text = "";
            donationCount.Text = "";
            lastDonated.Text = "";
            address.Text = "";

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(this.connectionStr);
            connection.Open();
            try
            {
                string query = "insert into donars values (@email,@fullname,@phone,@bloodgroup,@donationcount,@lastdonated,@address)";
                SqlCommand cmd = new SqlCommand(query, connection);

                if (fullname.Text != string.Empty && email.Text != string.Empty && phone.Text != string.Empty && bloodGroup.Text != string.Empty && donationCount.Text!=string.Empty && lastDonated.Text != string.Empty && address.Text!=string.Empty)
                {


                    

                    CultureInfo culture = new CultureInfo("en-US");
                    cmd.Parameters.AddWithValue("@email", email.Text);
                    cmd.Parameters.AddWithValue("@lastdonated", Convert.ToDateTime(lastDonated.Text, culture));
                    cmd.Parameters.AddWithValue("@fullname", fullname.Text);
                    cmd.Parameters.AddWithValue("@phone", phone.Text);
                    cmd.Parameters.AddWithValue("@bloodgroup", bloodGroup.Text);
                    cmd.Parameters.AddWithValue("@address", address.Text);
                    cmd.Parameters.AddWithValue("@donationcount", donationCount.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record has been added!", "Success");
                    this.clearForm();
                    this.Hide();
                    AdminDashboard dash = new AdminDashboard();
                    dash.ShowDialog();



                }
                else
                {
                    MessageBox.Show("Fill out all the fields!", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                connection.Close();
            }

        
    }
    }
}
