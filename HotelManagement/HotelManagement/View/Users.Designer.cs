namespace HotelManagement
{






    partial class Users
    {

        private System.ComponentModel.IContainer components = null;

        /// <param name="disposing"
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code


        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            dgv_Users = new Guna.UI2.WinForms.Guna2DataGridView();
            dgv_id = new DataGridViewTextBoxColumn();
            dgv_Name = new DataGridViewTextBoxColumn();
            dgv_Email = new DataGridViewTextBoxColumn();
            dgv_Phone = new DataGridViewTextBoxColumn();
            dgv_City = new DataGridViewTextBoxColumn();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Users).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.FromArgb(55, 190, 177);
            guna2Panel1.Controls.Add(guna2CircleButton1);
            guna2Panel1.Controls.Add(guna2TextBox1);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.Controls.Add(guna2HtmlLabel1);
            guna2Panel1.CustomizableEdges = customizableEdges4;
            guna2Panel1.Dock = DockStyle.Top;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges5;
            guna2Panel1.Size = new Size(1120, 131);
            guna2Panel1.TabIndex = 0;
            // 
            // guna2CircleButton1
            // 
            guna2CircleButton1.DisabledState.BorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2CircleButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2CircleButton1.FillColor = Color.White;
            guna2CircleButton1.Font = new Font("Segoe UI", 9F);
            guna2CircleButton1.ForeColor = Color.FromArgb(55, 190, 177);
            guna2CircleButton1.Location = new Point(53, 65);
            guna2CircleButton1.Name = "guna2CircleButton1";
            guna2CircleButton1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleButton1.Size = new Size(50, 50);
            guna2CircleButton1.TabIndex = 3;
            guna2CircleButton1.Text = "+";
            guna2CircleButton1.Click += guna2CircleButton1_Click;
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2TextBox1.CustomizableEdges = customizableEdges2;
            guna2TextBox1.DefaultText = "";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Segoe UI", 9F);
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Location = new Point(877, 78);
            guna2TextBox1.Margin = new Padding(3, 4, 3, 4);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PasswordChar = '\0';
            guna2TextBox1.PlaceholderText = "Search Here !";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges3;
            guna2TextBox1.Size = new Size(210, 37);
            guna2TextBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(872, 51);
            label1.Name = "label1";
            label1.Size = new Size(63, 23);
            label1.TabIndex = 1;
            label1.Text = "Search";
            label1.Click += label1_Click;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = Color.White;
            guna2HtmlLabel1.Location = new Point(24, 22);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(119, 39);
            guna2HtmlLabel1.TabIndex = 0;
            guna2HtmlLabel1.Text = "Users list ";
            guna2HtmlLabel1.Click += guna2HtmlLabel1_Click;
            // 
            // dgv_Users
            // 
            dgv_Users.AutoGenerateColumns = false;
            dgv_Users.AllowUserToAddRows = false;
            dgv_Users.AllowUserToDeleteRows = false;
            dgv_Users.AllowUserToResizeColumns = false;
            dgv_Users.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgv_Users.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Users.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(55, 190, 177);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_Users.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_Users.ColumnHeadersHeight = 25;
            dgv_Users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv_Users.Columns.AddRange(new DataGridViewColumn[] { dgv_id, dgv_Name, dgv_Email, dgv_Phone, dgv_City });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgv_Users.DefaultCellStyle = dataGridViewCellStyle3;
            dgv_Users.GridColor = Color.FromArgb(231, 229, 255);
            dgv_Users.Location = new Point(28, 175);
            dgv_Users.Name = "dgv_Users";
            dgv_Users.ReadOnly = true;
            dgv_Users.RowHeadersVisible = false;
            dgv_Users.RowHeadersWidth = 51;
            dgv_Users.Size = new Size(1063, 438);
            dgv_Users.TabIndex = 1;
            dgv_Users.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgv_Users.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgv_Users.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgv_Users.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgv_Users.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgv_Users.ThemeStyle.BackColor = Color.White;
            dgv_Users.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgv_Users.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgv_Users.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv_Users.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgv_Users.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgv_Users.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv_Users.ThemeStyle.HeaderStyle.Height = 25;
            dgv_Users.ThemeStyle.ReadOnly = true;
            dgv_Users.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgv_Users.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_Users.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgv_Users.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgv_Users.ThemeStyle.RowsStyle.Height = 29;
            dgv_Users.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgv_Users.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgv_Users.CellContentClick += guna2DataGridView1_CellContentClick;
            // 
            // dgv_id
            // 
            dgv_id.HeaderText = "id";
            dgv_id.MinimumWidth = 6;
            dgv_id.Name = "dgv_id";
            dgv_id.ReadOnly = true;
            // 
            // dgv_Name
            // 
            dgv_Name.HeaderText = "Name";
            dgv_Name.MinimumWidth = 6;
            dgv_Name.Name = "dgv_Name";
            dgv_Name.ReadOnly = true;
            // 
            // dgv_Email
            // 
            dgv_Email.HeaderText = "Email";
            dgv_Email.MinimumWidth = 6;
            dgv_Email.Name = "dgv_Email";
            dgv_Email.ReadOnly = true;
            // 
            // dgv_Phone
            // 
            dgv_Phone.HeaderText = "Phone";
            dgv_Phone.MinimumWidth = 6;
            dgv_Phone.Name = "dgv_Phone";
            dgv_Phone.ReadOnly = true;
            // 
            // dgv_City
            // 
            dgv_City.HeaderText = "City";
            dgv_City.MinimumWidth = 6;
            dgv_City.Name = "dgv_City";
            dgv_City.ReadOnly = true;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1120, 650);
            Controls.Add(dgv_Users);
            Controls.Add(guna2Panel1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Users";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SampleAdd";
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Users).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Users;
        private DataGridViewTextBoxColumn dgv_id;
        private DataGridViewTextBoxColumn dgv_Name;
        private DataGridViewTextBoxColumn dgv_Email;
        private DataGridViewTextBoxColumn dgv_Phone;
        private DataGridViewTextBoxColumn dgv_City;



    }
}