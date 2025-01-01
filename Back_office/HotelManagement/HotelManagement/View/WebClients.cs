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
using System.Net;
using System.Net.Mail;
using MySql.Data.MySqlClient;
namespace HotelManagement.View
{
    public partial class WebClients : Form
    {
        string connectionString = "Server=localhost;Port=3306;Database=hotelmanagement;Uid=root;Pwd=;";

        public WebClients()
        {
            InitializeComponent();
            LoadData();
            LoadRoomsData();
        }
        private void LoadData(string searchTerm = "")
        {
            string query = @"
                        SELECT Name, Email, DateDebut AS DateStart, DateFin AS DateEnd, RoomType, BedType
                        FROM webclients
                        WHERE status = 'in progress'";

            if (!string.IsNullOrWhiteSpace(searchTerm))
            {
                query += " AND (Name LIKE @search OR Email LIKE @search)";
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        if (!string.IsNullOrWhiteSpace(searchTerm))
                        {
                            adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + searchTerm + "%");
                        }

                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dgv_Name.DataPropertyName = "Name";
                        dgv_Email.DataPropertyName = "Email";
                        dgv_dd.DataPropertyName = "DateStart";
                        dgv_df.DataPropertyName = "DateEnd";
                        dgv_Rt.DataPropertyName = "RoomType";
                        dgv_Bed.DataPropertyName = "BedType";

                        dgv_webclients.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void LoadRoomsData(string roomType = "", string bedType = "")
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                        SELECT id, number, type, bed, price 
                        FROM rooms 
                        WHERE availability = 1 
                        AND (@type = '' OR type = @type) 
                        AND (@bed = '' OR bed = @bed)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@type", roomType);
                        cmd.Parameters.AddWithValue("@bed", bedType);

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dgv_Checkin.DataSource = dataTable;
                        dgv_id.DataPropertyName = "id";
                        dgv_Number.DataPropertyName = "number";
                        dgv_Type.DataPropertyName = "type";
                        dataGridViewTextBoxColumn1.DataPropertyName = "bed";
                        dgv_Price.DataPropertyName = "price";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading room data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_webclients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_webclients_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_webclients.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_webclients.SelectedRows[0];

                string selectedRoomType = selectedRow.Cells["dgv_Rt"].Value?.ToString() ?? "";
                string selectedBedType = selectedRow.Cells["dgv_Bed"].Value?.ToString() ?? "";

                LoadRoomsData(selectedRoomType, selectedBedType);
            }
        }

        private void Search_input_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = Search_input.Text.Trim();
            LoadData(searchTerm);
        }

        private void dgv_Checkin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgv_Checkin.Rows[e.RowIndex];
                string roomNumber = selectedRow.Cells["dgv_Number"].Value?.ToString() ?? "";

                Room_number_input.Text = roomNumber;
            }

            if (dgv_webclients.Columns[e.ColumnIndex].Name == "dgv_refused")
            {
                DataGridViewRow selectedClientRow = dgv_webclients.Rows[e.RowIndex];
                int id = Convert.ToInt32(selectedClientRow.Cells["id"].Value);

                UpdatewebclientsStatus(id, "Refused");
            }

            if (dgv_webclients.Columns[e.ColumnIndex].Name == "dgv_accepted")
            {
               
            }
        }

        private void UpdatewebclientsStatus(int id, string newStatus)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE webclients SET status = @status WHERE id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@status", newStatus);
                        cmd.Parameters.AddWithValue("@id", id);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Client status updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to update client status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the status: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void SendEmailConfirmation(string name, string email, string roomNumber, DateTime startDate, DateTime endDate)
        {
            try
            {
                string subject = "Your Booking Confirmation at Desert Mirage Inn";
                string body = $@"
                <html>
                <head>
                    <style>
                        body {{
                            font-family: Arial, sans-serif;
                            color: #333333;
                            line-height: 1.6;
                        }}
                        .container {{
                            max-width: 600px;
                            margin: 0 auto;
                            padding: 20px;
                            border: 1px solid #ddd;
                            background-color: #f9f9f9;
                        }}
                        .header {{
                            background-color: #0066cc;
                            color: #ffffff;
                            padding: 10px;
                            text-align: center;
                            font-size: 24px;
                        }}
                        .content {{
                            padding: 20px;
                        }}
                        .content p {{
                            font-size: 16px;
                        }}
                        .footer {{
                            font-size: 14px;
                            text-align: center;
                            color: #666666;
                            padding: 10px;
                            border-top: 1px solid #ddd;
                        }}
                    </style>
                </head>
                <body>
                    <div class='container'>
                        <div class='header'>
                            Desert Mirage Inn
                        </div>
                        <div class='content'>
                            <p>Dear {name},</p>
                            <p>Thank you for choosing Desert Mirage Inn! We are excited to confirm your reservation.</p>
                            <p><strong>Booking Details:</strong></p>
                            <ul>
                                <li><strong>Room Number:</strong> {roomNumber}</li>
                                <li><strong>Check-in Date:</strong> {startDate:MMMM dd, yyyy}</li>
                                <li><strong>Check-out Date:</strong> {endDate:MMMM dd, yyyy}</li>
                            </ul>
                            <p>We look forward to welcoming you to Desert Mirage Inn. Should you have any special requests or need assistance, feel free to contact us.</p>
                        </div>
                        <div class='footer'>
                            <p>Best regards,<br>Desert Mirage Inn Team<br>Contact: info@desertmirageinn.com</p>
                        </div>
                    </div>
                </body>
                </html>";

                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress("elbelaidisaad16@gmail.com");
                    mail.To.Add(email);
                    mail.Subject = subject;
                    mail.Body = body;
                    mail.IsBodyHtml = true;

                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.Credentials = new NetworkCredential("elbelaidisaad16@gmail.com", "");
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                    }
                }

                MessageBox.Show("Email confirmation sent successfully.", "Email Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to send email: {ex.Message}", "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
