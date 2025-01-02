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
            if (dgv_webclients.Columns[e.ColumnIndex].Name == "dgv_refused")
            {
                DataGridViewRow selectedClientRow = dgv_webclients.Rows[e.RowIndex];
                string clientName = Convert.ToString(selectedClientRow.Cells["dgv_Name"].Value);

                UpdatewebclientsStatus(clientName, "Refused");
                LoadData();
            }

            if (dgv_webclients.Columns[e.ColumnIndex].Name == "dgv_accepted")
            {
                DataGridViewRow selectedClientRow = dgv_webclients.Rows[e.RowIndex];
                string clientName = Convert.ToString(selectedClientRow.Cells["dgv_Name"].Value);
                string roomNumber = Room_number_input.Text;  
                DateTime startDate = DateTime.Parse(selectedClientRow.Cells["dgv_dd"].Value.ToString()); 
                DateTime endDate = DateTime.Parse(selectedClientRow.Cells["dgv_df"].Value.ToString());
                string email = Convert.ToString(selectedClientRow.Cells["dgv_Email"].Value);
                string phone = string.Empty;
                string nationality = string.Empty;

                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = @"
                    SELECT Phone, Nationality
                    FROM webclients
                    WHERE Name = @Name";

                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@Name", clientName);

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    phone = reader["Phone"].ToString();
                                    nationality = reader["Nationality"].ToString();
                                }
                                else
                                {
                                    MessageBox.Show("Client not found in webclients table.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error retrieving client data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                checkinWebWlient(clientName, roomNumber, startDate, endDate);
                InsertCustomer(clientName, email, phone, nationality);
                UpdatewebclientsStatusA(clientName, "Accepted");
                LoadData();
                UpdateRoomAvailability(roomNumber);
                LoadRoomsData();
                SendEmailConfirmation(clientName,email,roomNumber, startDate, endDate);
            }
        }

        private void UpdateRoomAvailability(string roomNumber)
        {
            try
            {

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE rooms SET Availability = 0 WHERE number = @RoomNumber";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@RoomNumber", roomNumber);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Room availability updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Room number not found or already unavailable.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating room availability: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

            
        }

        private void UpdatewebclientsStatus(string clientName, string newStatus)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE webclients SET status = @status WHERE name = @name";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@status", newStatus);
                        cmd.Parameters.AddWithValue("@name", clientName); 

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
        private void UpdatewebclientsStatusA(string clientName, string newStatus)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE webclients SET status = @status WHERE name = @name";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@status", newStatus);
                        cmd.Parameters.AddWithValue("@name", clientName);

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
        private void checkinWebWlient(string clientName, string roomNumber, DateTime startDate, DateTime endDate)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                INSERT INTO checkin (Name, Email, Phone, DateDebut, DateFin, NumberRoom, CheckedOut)
                SELECT Name, Email, Phone, @DateDebut, @DateFin, @NumberRoom, 0
                FROM webclients
                WHERE Name = @Name";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Name", clientName);
                        cmd.Parameters.AddWithValue("@DateDebut", startDate);
                        cmd.Parameters.AddWithValue("@DateFin", endDate);
                        cmd.Parameters.AddWithValue("@NumberRoom", roomNumber);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Client added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to add client.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the client: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertCustomer(string name, string email, string phone, string nationality)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                INSERT INTO customers (Name, Email, Phone, Nationality)
                VALUES (@name, @email, @phone, @nationality)";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@nationality", nationality);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Client added successfully to the customers table.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to add client to the customers table.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the client: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
