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
    public partial class AdminDashboard : Form
    {
        string connectionStr = "Server=localhost;Database=BDMS;Trusted_Connection=True;";
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void deleteRecord(int id)
        {
            SqlConnection connection = new SqlConnection(this.connectionStr);
            connection.Open();
            try
            {
                string query = "Delete From donars where id=@id";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", id);
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Record removed!", "Success");
                }
                else
                {
                    MessageBox.Show("Unknow error", "Error");
                }
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


        private void getAllRecords()
        {

            SqlConnection connection = new SqlConnection(this.connectionStr);
            connection.Open();
            
            try
            {
                string query = "Select * From donars";
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


        private void newRecordBtn_Click(object sender, EventArgs e)
        {
            new NewRecordForm().ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                DialogResult confirm = MessageBox.Show("Are you sure?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ColumnId"].Value);
                   
                    this.deleteRecord(id);
                    this.getAllRecords();
        

                }

            }
            else if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Update")
            {
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["columnId"].Value);
                string email = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["columnEmail"].Value);
                string fullname = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["columnFullname"].Value);
                string phone = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["columnPhone"].Value);
                string bloodGroup = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["columnBloodgroup"].Value);
                string donationCount = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["columnDonationcount"].Value);
                string lastDonated = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["columnLastdonated"].Value);
                string address = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["columnAddress"].Value);
                this.Hide();
                UpdateForm uf = new UpdateForm(id, email, fullname, phone, bloodGroup, donationCount, lastDonated, address);
                uf.ShowDialog();

            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            this.getAllRecords();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().ShowDialog();
        }
    }
}
