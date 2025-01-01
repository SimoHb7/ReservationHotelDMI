using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_Checkin.Rows[e.RowIndex];
                selectedRoomId = Convert.ToInt32(row.Cells["dgv_id"].Value);
            }
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
            Room_number.Text= "";
        }

        private int selectedRoomId = -1;


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (selectedRoomId == -1)
            {
                MessageBox.Show("Please select a room from the grid before booking.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = Name_input.Text.Trim();
            string email = Email_input.Text.Trim();
            string phone = Phone_input.Text.Trim();
            string roomNumber = Room_number.Text.Trim();
            DateTime startDate = DateStart.Value;
            DateTime endDate = DateEnd.Value;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(roomNumber))
            {
                MessageBox.Show("Please fill in all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string checkCustomerQuery = "SELECT id FROM customers WHERE Name = @name";
                    object customerId = null;

                    using (MySqlCommand checkCmd = new MySqlCommand(checkCustomerQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@name", name);
                        customerId = checkCmd.ExecuteScalar();
                    }

                    if (customerId == null)
                    {
                        string insertCustomerQuery = @"
                                                    INSERT INTO customers (Name, Email, Phone, Nationality)
                                                    VALUES (@name, @email, @phone, @nationality)";

                        using (MySqlCommand insertCustomerCmd = new MySqlCommand(insertCustomerQuery, conn))
                        {
                            insertCustomerCmd.Parameters.AddWithValue("@name", name);
                            insertCustomerCmd.Parameters.AddWithValue("@email", email);
                            insertCustomerCmd.Parameters.AddWithValue("@phone", phone);
                            insertCustomerCmd.Parameters.AddWithValue("@nationality", Nationality_input.Text.Trim());
                            insertCustomerCmd.ExecuteNonQuery();
                        }
                    }

                    string insertReservationQuery = @"
                                                    INSERT INTO checkin (Name, Email, Phone, DateDebut, DateFin, NumberRoom)
                                                    VALUES (@name, @email, @phone, @startDate, @endDate, @roomNumber)";

                    using (MySqlCommand insertReservationCmd = new MySqlCommand(insertReservationQuery, conn))
                    {
                        insertReservationCmd.Parameters.AddWithValue("@name", name);
                        insertReservationCmd.Parameters.AddWithValue("@email", email);
                        insertReservationCmd.Parameters.AddWithValue("@phone", phone);
                        insertReservationCmd.Parameters.AddWithValue("@startDate", startDate);
                        insertReservationCmd.Parameters.AddWithValue("@endDate", endDate);
                        insertReservationCmd.Parameters.AddWithValue("@roomNumber", roomNumber);
                        insertReservationCmd.ExecuteNonQuery();
                    }

                    string updateRoomQuery = "UPDATE rooms SET availability = 0 WHERE id = @roomId";
                    using (MySqlCommand updateRoomCmd = new MySqlCommand(updateRoomQuery, conn))
                    {
                        updateRoomCmd.Parameters.AddWithValue("@roomId", selectedRoomId);
                        updateRoomCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Booking and customer record successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //SendEmailConfirmation(name, email, roomNumber, startDate, endDate);
                    Name_input.Text = "";
                    Email_input.Text = "";
                    Phone_input.Text = "";
                    Nationality_input.Text = "";
                    Type_combobox.SelectedIndex = -1;
                    Bed_Combobox.SelectedIndex = -1;
                    Room_number.Text = "";
                    LoadRoomsData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while booking the room: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        private void dgv_Checkin_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_Checkin.Rows[e.RowIndex];

                if (row.Cells["dgv_id"].Value != null && row.Cells["dgv_Number"].Value != null)
                {
                    selectedRoomId = Convert.ToInt32(row.Cells["dgv_id"].Value); 
                    string roomNumber = row.Cells["dgv_Number"].Value.ToString();

                    Room_number.Text = roomNumber;
                }
                else
                {
                    MessageBox.Show("Selected row does not contain valid data.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

    }
}
