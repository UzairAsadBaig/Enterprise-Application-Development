using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDMS
{
    public partial class LoginForm : Form
    {
        string connectionStr = "Server=localhost;Database=BDMS;Trusted_Connection=True;";

        public LoginForm()
        {
            InitializeComponent();
        }


        private void dontHaveAccountBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SignupForm().ShowDialog();
        }

        private void loginBtn_Click_1(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(this.connectionStr);



            SqlCommand cmd = new SqlCommand("select * from users where email=@email and password=@password", cn);
            cmd.Parameters.AddWithValue("@email", email.Text);
            cmd.Parameters.AddWithValue("@password", password.Text);

            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                if(dr.GetString(dr.GetOrdinal("role")) == "admin")
                {
                    MessageBox.Show("Logged in successfully", "Success");
                    AdminDashboard d = new AdminDashboard();

                    this.Hide();
                    d.ShowDialog();
                }
                else if(dr.GetString(dr.GetOrdinal("role")) == "user")
                {
                    MessageBox.Show("Logged in successfully", "Success");
                    UserDashboard ud=new UserDashboard(dr.GetString(dr.GetOrdinal("email")));

                    this.Hide();
                    ud.ShowDialog();
                }

            }
            else
            {
                MessageBox.Show("Incorrect email or password!", "Error");
            }
        }

        private void dontHaveAccountBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new SignupForm().ShowDialog();
        }
    }
}
