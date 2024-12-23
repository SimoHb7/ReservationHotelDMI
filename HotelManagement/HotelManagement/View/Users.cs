using HotelManagement.View;
using MySql.Data.MySqlClient; 
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class Users : Form
    {
        string connectionString = "Server=localhost;Port=3306;Database=hotelmanagement;Uid=root;Pwd=;";

        public Users()
        {
            InitializeComponent();
            LoadUsersData();
        }

        private void LoadUsersData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT id, Name, Email, Phone, City FROM users";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgv_Users.DataSource = dataTable;
                    dgv_id.DataPropertyName = "id";
                    dgv_Name.DataPropertyName = "Name";
                    dgv_Email.DataPropertyName = "Email";
                    dgv_Phone.DataPropertyName = "Phone";
                    dgv_City.DataPropertyName = "City";


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void guna2Button1_Click(object sender, EventArgs e)
        {
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            UserAdd userAdd = new UserAdd();
            userAdd.ShowDialog();


        }
    }
}
