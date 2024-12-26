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

        private void button_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Number_input.Text) ||
                Type_combobox.SelectedIndex == -1 ||
                Bed_Combobox.SelectedIndex == -1 ||  
                Availability_combobox.SelectedIndex == -1 ||  
                string.IsNullOrWhiteSpace(Price_input.Text))
            {
                MessageBox.Show("All fields are required. Please fill in all the details and select a valid bed type and availability option.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO rooms (number, type, bed, price, availability) VALUES (@Number, @Type, @Bed, @Price, @Availability)";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Number", Number_input.Text);
                        command.Parameters.AddWithValue("@Type", Type_combobox.Text);
                        command.Parameters.AddWithValue("@Bed", Bed_Combobox.Text);
                        command.Parameters.AddWithValue("@Price", Price_input.Text);

                        bool selectedAvailability = Availability_combobox.SelectedIndex == 0; 
                        command.Parameters.AddWithValue("@Availability", selectedAvailability ? 1 : 0);


                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            LoadRoomsData();

                            Number_input.Text = "";
                            Price_input.Text = "";
                            Type_combobox.SelectedIndex = -1;
                            Bed_Combobox.SelectedIndex = -1;
                            Availability_combobox.SelectedIndex = -1;

                            MessageBox.Show("Room added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No rows affected. Please check your data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
