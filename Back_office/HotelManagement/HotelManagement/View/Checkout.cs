using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HotelManagement.View
{
    public partial class Checkout : Form
    {
        string connectionString = "Server=localhost;Port=3306;Database=hotelmanagement;Uid=root;Pwd=;";
        private void LoadCheckoutData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    id AS ID, 
                    Name AS Name, 
                    Phone AS Phone, 
                    DateDebut AS DateStart, 
                    DateFin AS DateEnd, 
                    NumberRoom AS RoomNumber 
                FROM reservations";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            dgv_Checkout.DataSource = dataTable;

                            dgv_id.DataPropertyName = "ID";
                            dgv_Name.DataPropertyName = "Name";
                            dgv_Phone.DataPropertyName = "Phone";
                            dgv_Number.DataPropertyName = "RoomNumber";
                            dgv_DateStart.DataPropertyName = "DateStart";
                            dgv_DateEnd.DataPropertyName = "DateEnd";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the data: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public Checkout()
        {
            InitializeComponent();
            LoadCheckoutData();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Checkout_Load(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
