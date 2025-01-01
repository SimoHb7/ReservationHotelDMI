using MySql.Data.MySqlClient; 
using System.Data;


namespace HotelManagement
{
    public partial class Users : Form
    {
        string connectionString = "Server=localhost;Port=3306;Database=hotelmanagement;Uid=root;Pwd=;";
        private string selectedUserId = string.Empty;

        public Users()
        {
            InitializeComponent();
            LoadUsersData();
        }

        public void LoadUsersData(string searchQuery = "")
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = string.IsNullOrWhiteSpace(searchQuery)
                        ? "SELECT id, Name, Email, Profession, Phone, City FROM users"
                        : "SELECT id, Name, Email, Profession, Phone, City FROM users WHERE Name LIKE @SearchQuery";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        if (!string.IsNullOrWhiteSpace(searchQuery))
                        {
                            cmd.Parameters.AddWithValue("@SearchQuery", searchQuery + "%");
                        }

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dgv_Users.DataSource = dataTable;
                        dgv_id.DataPropertyName = "id";
                        dgv_Name.DataPropertyName = "Name";
                        dgv_Email.DataPropertyName = "Email";
                        dgv_Profession.DataPropertyName = "Profession";
                        dgv_Phone.DataPropertyName = "Phone";
                        dgv_City.DataPropertyName = "City";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void guna2Button1_Click(object sender, EventArgs e)
        {
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }



        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
        }



        private void button_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Name_input.Text) ||
                string.IsNullOrWhiteSpace(Email_input.Text) ||
                string.IsNullOrWhiteSpace(Profession_input.Text) ||
                string.IsNullOrWhiteSpace(Phone_input.Text) ||
                string.IsNullOrWhiteSpace(City_input.Text))
            {
                MessageBox.Show("All fields are required. Please fill in all the details.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO users (Name, Email, Profession, Phone, City) VALUES (@Name, @Email, @Profession, @Phone, @City)";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", Name_input.Text);
                        command.Parameters.AddWithValue("@Email", Email_input.Text);
                        command.Parameters.AddWithValue("@Profession", Profession_input.Text);
                        command.Parameters.AddWithValue("@Phone", Phone_input.Text);
                        command.Parameters.AddWithValue("@City", City_input.Text);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            LoadUsersData();
                            Name_input.Text = "";
                            Email_input.Text = "";
                            Profession_input.Text = "";
                            Phone_input.Text = "";
                            City_input.Text = "";

                            MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dgv_Users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Users.Columns[e.ColumnIndex].Name == "dgv_Edit")
            {
                DataGridViewRow selectedRow = dgv_Users.Rows[e.RowIndex];

                selectedUserId = selectedRow.Cells["dgv_id"].Value.ToString();

                Name_input.Text = selectedRow.Cells["dgv_Name"].Value.ToString();
                Email_input.Text = selectedRow.Cells["dgv_Email"].Value.ToString();
                Profession_input.Text = selectedRow.Cells["dgv_Profession"].Value.ToString();
                Phone_input.Text = selectedRow.Cells["dgv_Phone"].Value.ToString();
                City_input.Text = selectedRow.Cells["dgv_City"].Value.ToString();
            }

            if (dgv_Users.Columns[e.ColumnIndex].Name == "dgv_Remove")
            {
                DataGridViewRow selectedRow = dgv_Users.Rows[e.RowIndex];
                string userId = selectedRow.Cells["dgv_id"].Value.ToString();

                var confirmResult = MessageBox.Show("Are you sure you want to delete this user?",
                    "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    DeleteUserFromDatabase(userId);
                }
            }
        }


        private void UpdateUserInDatabase(string userId)
        {
            string query = "UPDATE users SET Name = @Name, Email = @Email, Profession = @Profession, Phone = @Phone, City = @City WHERE ID = @ID";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", Name_input.Text);
                        command.Parameters.AddWithValue("@Email", Email_input.Text);
                        command.Parameters.AddWithValue("@Profession", Profession_input.Text);
                        command.Parameters.AddWithValue("@Phone", Phone_input.Text);
                        command.Parameters.AddWithValue("@City", City_input.Text);
                        command.Parameters.AddWithValue("@ID", userId);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {

                            Name_input.Text = "";
                            Email_input.Text = "";
                            Profession_input.Text = "";
                            Phone_input.Text = "";
                            City_input.Text = "";
                            LoadUsersData();
                            MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Update failed. Please check your data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void updateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedUserId))
            {
                MessageBox.Show("Please select a user to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UpdateUserInDatabase(selectedUserId);
            Search_input.Text = "";

        }

        private void DeleteUserFromDatabase(string userId)
        {
            string query = "DELETE FROM users WHERE ID = @ID";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", userId);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            LoadUsersData();
                            MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Deletion failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void Users_Load(object sender, EventArgs e)
        {
        }


        private void Search_input_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = Search_input.Text.Trim();
            LoadUsersData(searchQuery);
        }
    }
}
