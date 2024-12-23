namespace HotelManagement
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }



        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
        }
        private void AddControls(Form f)
        {
            CenterPanel.Controls.Clear();
            f.TopLevel = false;
            CenterPanel.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.Show();
        }




        private void guna2Button1_Click(object sender, EventArgs e)
        {
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            AddControls(new Users());

        }

        public void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
