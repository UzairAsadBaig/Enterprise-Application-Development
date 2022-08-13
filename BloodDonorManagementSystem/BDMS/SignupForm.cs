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
    public partial class SignupForm : Form
    {
        string connectionStr = "Server=localhost;Database=BDMS;Trusted_Connection=True;";

        public SignupForm()
        {
            InitializeComponent();
        }

       private void clearForm()
        {
            email.Text = "";
            password.Text = "";
            confirmPassword.Text = "";

        }
     

        

        private void haveAccountBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().ShowDialog();
        }

        private void signupBtn_Click_1(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(this.connectionStr);



            SqlCommand cmd = new SqlCommand("insert into users values (@email,@password,@role)", cn);

            if (email.Text != string.Empty && password.Text != string.Empty && confirmPassword.Text != string.Empty)
            {

                if (password.Text != confirmPassword.Text)
                {
                    MessageBox.Show("Password and Confirm Password are not same", "Error");

                }
                else
                {
                    cmd.Parameters.AddWithValue("@email", email.Text);
                    cmd.Parameters.AddWithValue("@password", password.Text);
                    cmd.Parameters.AddWithValue("@role", "user");

                    cn.Open();
                    int effRows = cmd.ExecuteNonQuery();

                    if (effRows > 0)
                    {
                        this.clearForm();
                        MessageBox.Show("Signed up successfully!", "Success");
                        LoginForm login = new LoginForm();
                        this.Hide();
                        login.ShowDialog();

                        cn.Close();

                    }

                }



            }
            else
            {
                MessageBox.Show("Please Fill out all the fields to signup", "Error");

            }
        }
    }
}
