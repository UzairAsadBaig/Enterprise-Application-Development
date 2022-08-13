using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BDMS
{
    public partial class UpdateForm : Form
    {
        string connectionStr = "Server=localhost;Database=BDMS;Trusted_Connection=True;";
        int id;
        string EMAIL;
        string FULLNAME;
        string PHONE;
        string BLOOD_GROUP;
        string DONATION_COUNT;
        string LAST_DONATED;
        string ADDRESS;
        public UpdateForm()
        {
            InitializeComponent();
        }
        public UpdateForm(int id,string e,string fn,string ph,string bg, string dc,string ld,string add)
        {
            this.id = id;
            this.EMAIL = e;
            this.FULLNAME = fn;
            this.PHONE = ph;
            this.BLOOD_GROUP = bg;
            this.DONATION_COUNT = dc;
            this.LAST_DONATED = ld;
            this.ADDRESS = add;

            InitializeComponent();


        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(this.connectionStr);
            connection.Open();
            try
            {

                CultureInfo culture = new CultureInfo("en-US");



                string query = "UPDATE donars SET email=@email, full_name=@fullname , phone=@phone , blood_group= @bloodgroup, donation_count= @donationcount, last_donated=@lastdonated, address=@address WHERE id=@id; ";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", this.id);
                cmd.Parameters.AddWithValue("@email", email.Text);
                cmd.Parameters.AddWithValue("@fullname", fullname.Text);
                cmd.Parameters.AddWithValue("@phone", phone.Text);
                cmd.Parameters.AddWithValue("@bloodgroup", bloodGroup.Text);
                cmd.Parameters.AddWithValue("@donationcount", donationCount.Text);
                cmd.Parameters.AddWithValue("@address", address.Text);
                cmd.Parameters.AddWithValue("@lastdonated", Convert.ToDateTime(lastDonated.Text, culture));

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Record has been updated successfully!", "Success");
                    this.Hide();
                    AdminDashboard d = new AdminDashboard();

                    d.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Unknown Error!", "Error");
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

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            fullname.Text = this.FULLNAME;
            email.Text = this.EMAIL;
            phone.Text = this.PHONE;
           bloodGroup.Text= this.BLOOD_GROUP;
           donationCount.Text= this.DONATION_COUNT;
           lastDonated.Text= this.LAST_DONATED;
           address.Text= this.ADDRESS;
        }
    }
}
