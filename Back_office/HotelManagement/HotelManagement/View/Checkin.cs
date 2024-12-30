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
            Type_combobox.SelectedIndexChanged += Type_combobox_SelectedIndexChanged;
            Bed_Combobox.SelectedIndexChanged += Bed_Combobox_SelectedIndexChanged;
        }

        public void LoadRoomsData(string roomType = "", string bedType = "")
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT id, number, type, bed, price FROM rooms WHERE availability = 1";

                    if (!string.IsNullOrWhiteSpace(roomType))
                        query += " AND type = @type";

                    if (!string.IsNullOrWhiteSpace(bedType))
                        query += " AND bed = @bed";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        if (!string.IsNullOrWhiteSpace(roomType))
                            cmd.Parameters.AddWithValue("@type", roomType);

                        if (!string.IsNullOrWhiteSpace(bedType))
                            cmd.Parameters.AddWithValue("@bed", bedType);

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

        private void UpdateGrid()
        {
            string selectedType = Type_combobox.SelectedItem?.ToString();
            string selectedBed = Bed_Combobox.SelectedItem?.ToString();

            LoadRoomsData(selectedType, selectedBed);
        }

        private void Type_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void Bed_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Name_input.Text = "";
            Email_input.Text = "";
            Phone_input.Text = "";
            Nationality_input.Text = "";
            Type_combobox.SelectedIndex = -1;
            Bed_Combobox.SelectedIndex = -1;
        }
    }
}
