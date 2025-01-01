using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net;
using System.Net.Mail;


namespace HotelManagement.View
{
    public partial class Checkout : Form
    {
        string connectionString = "Server=localhost;Port=3306;Database=hotelmanagement;Uid=root;Pwd=;";
        private void LoadCheckoutData(string roomNumber = null)
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
                        Phone AS Phone, 
                        DateDebut AS DateStart, 
                        DateFin AS DateEnd, 
                        NumberRoom AS RoomNumber 
                    FROM checkin 
                    WHERE CheckedOut = 0";

                    if (!string.IsNullOrEmpty(roomNumber))
                    {
                        query += " AND NumberRoom LIKE @RoomNumber";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(roomNumber))
                        {
                            cmd.Parameters.AddWithValue("@RoomNumber", $"%{roomNumber}%");
                        }

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            dgv_Checkout.DataSource = dataTable;

                            dgv_id.DataPropertyName = "ID";
                            dgv_Name.DataPropertyName = "Name";
                            dgv_Email.DataPropertyName = "Email";
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

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_Checkout_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgv_Checkout.Rows[e.RowIndex];
                Name_input.Text = selectedRow.Cells["dgv_Name"].Value.ToString();
                Phone_input.Text = selectedRow.Cells["dgv_Phone"].Value.ToString();
                Room_input.Text = selectedRow.Cells["dgv_Number"].Value.ToString();
                DateStart_input.Text = Convert.ToDateTime(selectedRow.Cells["dgv_DateStart"].Value).ToString("yyyy-MM-dd");
                DateEnd_input.Text = Convert.ToDateTime(selectedRow.Cells["dgv_DateEnd"].Value).ToString("yyyy-MM-dd");
                Price_input.Text = CalculateAmount();

            }
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            if (dgv_Checkout.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_Checkout.SelectedRows[0];

                int id = Convert.ToInt32(selectedRow.Cells["dgv_id"].Value);
                string name = selectedRow.Cells["dgv_Name"].Value.ToString();
                string email = selectedRow.Cells["dgv_Email"].Value.ToString();
                string phone = selectedRow.Cells["dgv_Phone"].Value.ToString();
                int numberRoom = Convert.ToInt32(selectedRow.Cells["dgv_Number"].Value);
                DateTime dateDebut = Convert.ToDateTime(selectedRow.Cells["dgv_DateStart"].Value);
                DateTime dateFin = Convert.ToDateTime(selectedRow.Cells["dgv_DateEnd"].Value);

                string connectionString = "Server=localhost;Port=3306;Database=hotelmanagement;Uid=root;Pwd=;";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    string amount = CalculateAmount();

                    string queryInsert = "INSERT INTO checkout (ID, Name, Email, Phone, DateDebut, DateFin, NumberRoom, Amount) " +
                                         "VALUES (@ID, @Name, @Email, @Phone, @DateDebut, @DateFin, @NumberRoom, @Amount)";
                    MySqlCommand cmdInsert = new MySqlCommand(queryInsert, conn);
                    cmdInsert.Parameters.AddWithValue("@ID", id);
                    cmdInsert.Parameters.AddWithValue("@Name", name);
                    cmdInsert.Parameters.AddWithValue("@Email", email);
                    cmdInsert.Parameters.AddWithValue("@Phone", phone);
                    cmdInsert.Parameters.AddWithValue("@DateDebut", dateDebut);
                    cmdInsert.Parameters.AddWithValue("@DateFin", dateFin);
                    cmdInsert.Parameters.AddWithValue("@NumberRoom", numberRoom);
                    cmdInsert.Parameters.AddWithValue("@Amount", amount);  

                    string queryUpdateCheckin = "UPDATE checkin SET CheckedOut = 1 WHERE id = @ID";
                    MySqlCommand cmdUpdateCheckin = new MySqlCommand(queryUpdateCheckin, conn);
                    cmdUpdateCheckin.Parameters.AddWithValue("@ID", id);

                    string queryUpdateRooms = "UPDATE rooms SET Availability = 1 WHERE Number = @NumberRoom";
                    MySqlCommand cmdUpdateRooms = new MySqlCommand(queryUpdateRooms, conn);
                    cmdUpdateRooms.Parameters.AddWithValue("@NumberRoom", numberRoom);

                    try
                    {
                        conn.Open();

                        cmdInsert.ExecuteNonQuery();
                        cmdUpdateCheckin.ExecuteNonQuery();
                        cmdUpdateRooms.ExecuteNonQuery();

                        checkout_search.Text = "";
                        Name_input.Text = "";
                        Phone_input.Text = "";
                        DateStart_input.Text = "";
                        DateEnd_input.Text = "";
                        Price_input.Text = "";

                        SendCheckoutEmail(name, email, numberRoom.ToString(), dateDebut, dateFin, amount);
                        LoadCheckoutData();

                        MessageBox.Show("Checkout record has been added, checkin updated, room availability set to true, and the amount has been recorded.",
                                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


            }
            else
            {
                MessageBox.Show("Please select a row first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string CalculateAmount()
        {
            if (dgv_Checkout.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_Checkout.SelectedRows[0];

                int roomNumber = Convert.ToInt32(selectedRow.Cells["dgv_Number"].Value);
                DateTime dateStart = Convert.ToDateTime(selectedRow.Cells["dgv_DateStart"].Value);
                DateTime dateEnd = Convert.ToDateTime(selectedRow.Cells["dgv_DateEnd"].Value);

                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();

                        string query = "SELECT Price FROM rooms WHERE Number = @RoomNumber";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@RoomNumber", roomNumber);
                            object result = cmd.ExecuteScalar();

                            if (result != null && decimal.TryParse(result.ToString(), out decimal roomPrice))
                            {
                                int duration = (dateEnd - dateStart).Days;

                                if (duration <= 0)
                                {
                                    MessageBox.Show("Invalid date range. Please check the booking dates.",
                                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return "0.00";
                                }

                                decimal totalAmount = duration * roomPrice;

                                return totalAmount.ToString("F2");
                            }
                            else
                            {
                                MessageBox.Show("Room price not found. Please check the room number.",
                                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return "0.00";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "0.00";
                }
            }
            else
            {
                MessageBox.Show("Please select a row first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "0.00";
            }
        }



        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = checkout_search.Text.Trim();
            LoadCheckoutData(searchQuery);
        }
        private void SendCheckoutEmail(string name, string email, string roomNumber, DateTime startDate, DateTime endDate, string amount)
        {
            try
            {
                string subject = "Your Checkout Confirmation at Desert Mirage Inn";
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
                    <p>Thank you for staying with us at Desert Mirage Inn! We hope you had a pleasant experience. Below are your checkout details:</p>
                    <p><strong>Checkout Details:</strong></p>
                    <ul>
                        <li><strong>Room Number:</strong> {roomNumber}</li>
                        <li><strong>Check-in Date:</strong> {startDate:MMMM dd, yyyy}</li>
                        <li><strong>Check-out Date:</strong> {endDate:MMMM dd, yyyy}</li>
                        <li><strong>Total Amount:</strong> ${amount}</li>
                    </ul>
                    <p>We hope to welcome you back soon. Should you have any further inquiries or feedback, feel free to contact us.</p>
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

                MessageBox.Show("Checkout email confirmation sent successfully.", "Email Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to send email: {ex.Message}", "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
