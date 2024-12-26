using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.View
{
    public partial class Rooms : Form
    {
        string connectionString = "Server=localhost;Port=3306;Database=hotelmanagement;Uid=root;Pwd=;";

        public Rooms()
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
                        ? "SELECT id, number, type, bed, price, availability FROM rooms"
                        : "SELECT id, number, type, bed, price, availability FROM rooms WHERE number LIKE @SearchQuery";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        if (!string.IsNullOrWhiteSpace(searchQuery))
                        {
                            cmd.Parameters.AddWithValue("@SearchQuery", searchQuery + "%");
                        }

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dgv_Rooms.DataSource = dataTable;
                        dgv_id.DataPropertyName = "id";
                        dgv_Number.DataPropertyName = "number";
                        dgv_Type.DataPropertyName = "type";
                        dgv_Bed.DataPropertyName = "bed";
                        dgv_Price.DataPropertyName = "price";
                        dgv_Availability.DataPropertyName = "availability";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading room data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Rooms_Load(object sender, EventArgs e)
        {

        }

        private void room_input_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = room_input.Text.Trim();
            LoadRoomsData(searchQuery);
            
        }
    }
}
