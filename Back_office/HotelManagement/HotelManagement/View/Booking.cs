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
    public partial class Booking : Form
    {
        string connectionString = "Server=localhost;Port=3306;Database=hotelmanagement;Uid=root;Pwd=;";

        public Booking()
        {
            InitializeComponent();
            LoadBookingData();
        }

        private void LoadBookingData()
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
                    Email AS Email, 
                    DateDebut AS DateStart, 
                    DateFin AS DateEnd, 
                    NumberRoom AS RoomNumber,
                    CASE 
                        WHEN CheckedOut = 1 THEN 'Completed'
                        ELSE 'In Progress'
                    END AS Status
                FROM checkin";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            dgv_Booking.DataSource = dataTable;

                            dgv_id.DataPropertyName = "ID";
                            dgv_Name.DataPropertyName = "Name";
                            dgv_Email.DataPropertyName = "Email";
                            dgv_RoomNumber.DataPropertyName = "RoomNumber";
                            dgv_dd.DataPropertyName = "DateStart";
                            dgv_df.DataPropertyName = "DateEnd";
                            dgv_status.DataPropertyName = "Status";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the booking data: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void booking_input_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string searchQuery = booking_input.Text.Trim();
                    string query = @"
                SELECT 
                    id AS ID, 
                    Name AS Name, 
                    Email AS Email, 
                    DateDebut AS DateStart, 
                    DateFin AS DateEnd, 
                    NumberRoom AS RoomNumber,
                    CASE 
                        WHEN CheckedOut = 1 THEN 'Completed'
                        ELSE 'In Progress'
                    END AS Status
                FROM checkin
                WHERE Name LIKE @Search";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Search", $"%{searchQuery}%");

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            dgv_Booking.DataSource = dataTable;

                            dgv_id.DataPropertyName = "ID";
                            dgv_Name.DataPropertyName = "Name";
                            dgv_Email.DataPropertyName = "Email";
                            dgv_RoomNumber.DataPropertyName = "RoomNumber";
                            dgv_dd.DataPropertyName = "DateStart";
                            dgv_df.DataPropertyName = "DateEnd";
                            dgv_status.DataPropertyName = "Status";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching the booking data: {ex.Message}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ExportToCsv()
        {
            try
            {

                string filePath = "C:\\Users\\Dark\\Desktop\\dotnetProject\\ReservationHotelDMI\\Back_office\\HotelManagement\\HotelManagement\\Resources\\Booking.csv";

                StringBuilder csvContent = new StringBuilder();


                for (int i = 0; i < dgv_Booking.Columns.Count; i++)
                {
                    csvContent.Append(dgv_Booking.Columns[i].HeaderText);
                    if (i < dgv_Booking.Columns.Count - 1)
                        csvContent.Append(",");
                }
                csvContent.AppendLine();


                foreach (DataGridViewRow row in dgv_Booking.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        for (int i = 0; i < dgv_Booking.Columns.Count; i++)
                        {
                            object cellValue = row.Cells[i].Value;

                            if (cellValue is DateTime dateValue)
                            {
                                csvContent.Append(dateValue.ToString("yyyy-MM-dd")); 
                            }
                            else
                            {
                                csvContent.Append(cellValue?.ToString());
                            }

                            if (i < dgv_Booking.Columns.Count - 1)
                                csvContent.Append(",");
                        }
                        csvContent.AppendLine();
                    }
                }

                File.WriteAllText(filePath, csvContent.ToString());

                MessageBox.Show("Data exported successfully to Booking.csv", "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while exporting the data: {ex.Message}", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ExportToCsv();
        }
    }
}
