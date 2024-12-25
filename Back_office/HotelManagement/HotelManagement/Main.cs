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
    }
}
