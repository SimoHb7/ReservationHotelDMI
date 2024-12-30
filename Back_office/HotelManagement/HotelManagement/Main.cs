using HotelManagement.View;

namespace HotelManagement
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

        }

        private void Main_Load(object sender, EventArgs e)
        {
            time_label.Text = DateTime.Now.ToString();
            timer1.Start();
        }


        private void guna2Button6_Click(object sender, EventArgs e)
        {
            AddControls(new Users());
        }
        private void time_label_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            time_label.Text = DateTime.Now.ToString();
            timer1.Start();
        }

        private void Customers_main_Click(object sender, EventArgs e)
        {
            AddControls(new Customers());
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            AddControls(new Rooms());
        }

        private void checkOut_Click(object sender, EventArgs e)
        {
            AddControls(new Checkout());
        }

        private void checkIn_Click(object sender, EventArgs e)
        {
            AddControls(new Checkin());
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddControls(new Home());
        }

        private void Online_booking_Click(object sender, EventArgs e)
        {
            AddControls(new Booking());
        }
    }
}
