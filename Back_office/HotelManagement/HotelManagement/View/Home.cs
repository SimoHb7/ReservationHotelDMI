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
    public partial class Home : Form
    {
        string connectionString = "Server=localhost;Port=3306;Database=hotelmanagement;Uid=root;Pwd=;";

        public Home()
        {
            InitializeComponent();
            UpdateUI();
            
        }

        private void UpdateUI()
        {
            customers1.Text = GetCustomerCount();
            employees1.Text = GetUserCount();
            checkin.Text = GetActiveCheckIns();
            webc1.Text = GetWebClientsInProgress();
            checkout.Text = GetCheckedOutCount();
            single.Text = GetRoomSingle();
            double1.Text = GetRoomDouble();
            suite1.Text = GetRoomSuite();
            deluxe1.Text = GetRoomDeluxe();
        }


        public string GetCustomerCount()
        {
            int customerCount = 0;
            string query = "SELECT COUNT(*) FROM customers";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        customerCount = Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return customerCount.ToString();
        }


        public string GetUserCount()
        {
            int userCount = 0;
            string query = "SELECT COUNT(*) FROM users"; 

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        userCount = Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return userCount.ToString();
        }

        public string GetActiveCheckIns()
        {
            int activeCheckIns = 0;
            string query = "SELECT COUNT(*) FROM checkin WHERE CheckedOut = 0";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        activeCheckIns = Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return activeCheckIns.ToString();
        }

        public string GetWebClientsInProgress()
        {
            int inProgressCount = 0;
            string query = "SELECT COUNT(*) FROM webclients WHERE status = 'in progress'";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        inProgressCount = Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return inProgressCount.ToString();
        }

        public string GetCheckedOutCount()
        {
            int checkedOutCount = 0;
            string query = "SELECT COUNT(*) FROM checkin WHERE CheckedOut = 1";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        checkedOutCount = Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return checkedOutCount.ToString();
        }

        public string GetRoomSingle()
        {
            int totalSingleRooms = 0;
            int availableSingleRooms = 0;
            string queryTotalSingle = "SELECT COUNT(*) FROM rooms WHERE type = 'single'";
            string queryAvailableSingle = "SELECT COUNT(*) FROM rooms WHERE type = 'single' AND availability = 1";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(queryTotalSingle, connection))
                    {
                        totalSingleRooms = Convert.ToInt32(command.ExecuteScalar());
                    }

                    using (MySqlCommand command = new MySqlCommand(queryAvailableSingle, connection))
                    {
                        availableSingleRooms = Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return $"{availableSingleRooms}/{totalSingleRooms}";
        }

        public string GetRoomDouble()
        {
            int totalSingleRooms = 0;
            int availableSingleRooms = 0;
            string queryTotalSingle = "SELECT COUNT(*) FROM rooms WHERE type = 'double'";
            string queryAvailableSingle = "SELECT COUNT(*) FROM rooms WHERE type = 'double' AND availability = 1";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(queryTotalSingle, connection))
                    {
                        totalSingleRooms = Convert.ToInt32(command.ExecuteScalar());
                    }

                    using (MySqlCommand command = new MySqlCommand(queryAvailableSingle, connection))
                    {
                        availableSingleRooms = Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return $"{availableSingleRooms}/{totalSingleRooms}";
        }

        public string GetRoomSuite()
        {
            int totalSingleRooms = 0;
            int availableSingleRooms = 0;
            string queryTotalSingle = "SELECT COUNT(*) FROM rooms WHERE type = 'suite'";
            string queryAvailableSingle = "SELECT COUNT(*) FROM rooms WHERE type = 'suite' AND availability = 1";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(queryTotalSingle, connection))
                    {
                        totalSingleRooms = Convert.ToInt32(command.ExecuteScalar());
                    }

                    using (MySqlCommand command = new MySqlCommand(queryAvailableSingle, connection))
                    {
                        availableSingleRooms = Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return $"{availableSingleRooms}/{totalSingleRooms}";
        }

        public string GetRoomDeluxe()
        {
            int totalSingleRooms = 0;
            int availableSingleRooms = 0;
            string queryTotalSingle = "SELECT COUNT(*) FROM rooms WHERE type = 'deluxe'";
            string queryAvailableSingle = "SELECT COUNT(*) FROM rooms WHERE type = 'deluxe' AND availability = 1";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(queryTotalSingle, connection))
                    {
                        totalSingleRooms = Convert.ToInt32(command.ExecuteScalar());
                    }

                    using (MySqlCommand command = new MySqlCommand(queryAvailableSingle, connection))
                    {
                        availableSingleRooms = Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return $"{availableSingleRooms}/{totalSingleRooms}";
        }

    }
}
