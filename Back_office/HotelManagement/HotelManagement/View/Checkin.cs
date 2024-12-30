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
    public partial class Checkin : Form

    {
        string connectionString = "Server=localhost;Port=3306;Database=hotelmanagement;Uid=root;Pwd=;";

        public Checkin()
        {
            InitializeComponent();
            LoadRoomsData();
        }

        public void LoadRoomsData(string searchQuery = "")
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = string.IsNullOrWhiteSpace(searchQuery)
                        ? "SELECT id, number, type, bed, price FROM rooms WHERE availability = 1"
                        : "SELECT id, number, type, bed, price FROM rooms WHERE availability = 1";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dgv_Checkin.DataSource = dataTable;
                        dgv_id.DataPropertyName = "id";
                        dgv_Number.DataPropertyName = "number";
                        dgv_Type.DataPropertyName = "type";
                        dgv_Bed.DataPropertyName = "bed";
                        dgv_Price.DataPropertyName = "price";
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading room data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dgv_Checkin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
