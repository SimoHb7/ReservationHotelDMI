using MySql.Data.MySqlClient;
using System.Data;
using System.Data;
using System.Data.SqlClient;


namespace HotelManagement.View
{
    public partial class Customers : Form
    {

        string connectionString = "Server=localhost;Port=3306;Database=hotelmanagement;Uid=root;Pwd=;";
        private string selectedCustomerId = string.Empty;
        public Customers()
        {
            InitializeComponent();
            LoadCustomersData();

        }


        public void LoadCustomersData(string searchQuery = "")
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = string.IsNullOrWhiteSpace(searchQuery)
                        ? "SELECT id, Name, Email, Phone, Nationality FROM customers"
                        : "SELECT id, Name, Email, Phone, Nationality FROM customers WHERE " +
                          "Name LIKE @SearchQuery OR Email LIKE @SearchQuery OR Phone LIKE @SearchQuery " +
                          "OR Nationality LIKE @SearchQuery";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        if (!string.IsNullOrWhiteSpace(searchQuery))
                        {
                            cmd.Parameters.AddWithValue("@SearchQuery", "%" + searchQuery + "%");
                        }

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dgv_Customers.DataSource = dataTable;
                        dgv_id.DataPropertyName = "id";
                        dgv_Name.DataPropertyName = "Name";
                        dgv_Email.DataPropertyName = "Email";
                        dgv_Phone.DataPropertyName = "Phone";
                        dgv_Nationality.DataPropertyName = "Nationality";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void button_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Name_input.Text) ||
                string.IsNullOrWhiteSpace(Email_input.Text) ||
                string.IsNullOrWhiteSpace(Phone_input.Text) ||
                string.IsNullOrWhiteSpace(Nationality_input.Text))
            {
                MessageBox.Show("All fields are required. Please fill in all the details.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO customers (Name, Email, Phone, Nationality) VALUES (@Name, @Email, @Phone, @Nationality)";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", Name_input.Text);
                        command.Parameters.AddWithValue("@Email", Email_input.Text);
                        command.Parameters.AddWithValue("@Phone", Phone_input.Text);
                        command.Parameters.AddWithValue("@Nationality", Nationality_input.Text);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            LoadCustomersData();

                            Name_input.Text = "";
                            Email_input.Text = "";
                            Phone_input.Text = "";
                            Nationality_input.Text = "";

                            MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dgv_Customers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }




        private void UpdateCustomersInDatabase(string customerId)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(Name_input.Text) ||
                string.IsNullOrWhiteSpace(Email_input.Text) ||
                string.IsNullOrWhiteSpace(Phone_input.Text) ||
                string.IsNullOrWhiteSpace(Nationality_input.Text))
            {
                MessageBox.Show("All fields are required. Please fill in all the details.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if customerId is valid
            if (string.IsNullOrEmpty(customerId))
            {
                MessageBox.Show("No customer selected to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Update customer data in the database
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                UPDATE customers 
                SET 
                    Name = @Name, 
                    Email = @Email, 
                    Phone = @Phone, 
                    Nationality = @Nationality 
                WHERE 
                    id = @CustomerId";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // Bind parameters
                        command.Parameters.AddWithValue("@Name", Name_input.Text.Trim());
                        command.Parameters.AddWithValue("@Email", Email_input.Text.Trim());
                        command.Parameters.AddWithValue("@Phone", Phone_input.Text.Trim());
                        command.Parameters.AddWithValue("@Nationality", Nationality_input.Text.Trim());
                        command.Parameters.AddWithValue("@CustomerId", customerId);

                        // Execute the update query
                        int rowsAffected = command.ExecuteNonQuery();

                        // Notify user about the result
                        if (rowsAffected > 0)
                        {
                            LoadCustomersData();
                            MessageBox.Show("Customer updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No rows were updated. Please ensure the customer ID is valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle errors gracefully
                MessageBox.Show($"An error occurred while updating the customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void updateButton_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(selectedCustomerId))
            {
                MessageBox.Show("No customer selected to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                UpdateCustomersInDatabase(selectedCustomerId);
            }
        }


    }
}


