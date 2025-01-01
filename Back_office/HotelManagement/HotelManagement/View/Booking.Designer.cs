namespace HotelManagement.View
{
    partial class Booking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            booking_input = new Guna.UI2.WinForms.Guna2TextBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            dgv_Booking = new Guna.UI2.WinForms.Guna2DataGridView();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            dgv_id = new DataGridViewTextBoxColumn();
            dgv_Name = new DataGridViewTextBoxColumn();
            dgv_Email = new DataGridViewTextBoxColumn();
            dgv_RoomNumber = new DataGridViewTextBoxColumn();
            dgv_dd = new DataGridViewTextBoxColumn();
            dgv_df = new DataGridViewTextBoxColumn();
            dgv_status = new DataGridViewTextBoxColumn();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Booking).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.FromArgb(55, 190, 177);
            guna2Panel1.Controls.Add(guna2HtmlLabel5);
            guna2Panel1.Controls.Add(booking_input);
            guna2Panel1.Controls.Add(guna2HtmlLabel1);
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.Dock = DockStyle.Top;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new Size(1102, 131);
            guna2Panel1.TabIndex = 0;
            // 
            // guna2HtmlLabel5
            // 
            guna2HtmlLabel5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2HtmlLabel5.BackColor = Color.Transparent;
            guna2HtmlLabel5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel5.ForeColor = Color.White;
            guna2HtmlLabel5.Location = new Point(881, 53);
            guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            guna2HtmlLabel5.Size = new Size(56, 25);
            guna2HtmlLabel5.TabIndex = 5;
            guna2HtmlLabel5.Text = "Search";
            // 
            // booking_input
            // 
            booking_input.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            booking_input.CustomizableEdges = customizableEdges1;
            booking_input.DefaultText = "";
            booking_input.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            booking_input.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            booking_input.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            booking_input.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            booking_input.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            booking_input.Font = new Font("Segoe UI", 9F);
            booking_input.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            booking_input.Location = new Point(881, 85);
            booking_input.Margin = new Padding(3, 4, 3, 4);
            booking_input.Name = "booking_input";
            booking_input.PasswordChar = '\0';
            booking_input.PlaceholderText = "Search by name";
            booking_input.SelectedText = "";
            booking_input.ShadowDecoration.CustomizableEdges = customizableEdges2;
            booking_input.Size = new Size(210, 37);
            booking_input.TabIndex = 4;
            booking_input.TextChanged += booking_input_TextChanged;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.Anchor = AnchorStyles.None;
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = Color.White;
            guna2HtmlLabel1.Location = new Point(431, 31);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(212, 39);
            guna2HtmlLabel1.TabIndex = 2;
            guna2HtmlLabel1.Text = "Booking History";
            // 
            // dgv_Booking
            //
            //
            dgv_Booking.AutoGenerateColumns = false;
            dgv_Booking.AllowUserToAddRows = false;
            dgv_Booking.AllowUserToDeleteRows = false;
            dgv_Booking.AllowUserToResizeColumns = false;
            dgv_Booking.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(179, 223, 219);
            dgv_Booking.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Booking.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_Booking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_Booking.ColumnHeadersHeight = 25;
            dgv_Booking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv_Booking.Columns.AddRange(new DataGridViewColumn[] { dgv_id, dgv_Name, dgv_Email, dgv_RoomNumber, dgv_dd, dgv_df, dgv_status });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(204, 233, 231);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(85, 185, 175);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgv_Booking.DefaultCellStyle = dataGridViewCellStyle3;
            dgv_Booking.GridColor = Color.FromArgb(177, 222, 218);
            dgv_Booking.Location = new Point(19, 152);
            dgv_Booking.Name = "dgv_Booking";
            dgv_Booking.ReadOnly = true;
            dgv_Booking.RowHeadersVisible = false;
            dgv_Booking.RowHeadersWidth = 51;
            dgv_Booking.Size = new Size(1063, 589);
            dgv_Booking.TabIndex = 3;
            dgv_Booking.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Teal;
            dgv_Booking.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(179, 223, 219);
            dgv_Booking.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgv_Booking.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgv_Booking.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgv_Booking.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgv_Booking.ThemeStyle.BackColor = Color.White;
            dgv_Booking.ThemeStyle.GridColor = Color.FromArgb(177, 222, 218);
            dgv_Booking.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(0, 150, 136);
            dgv_Booking.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv_Booking.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgv_Booking.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgv_Booking.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv_Booking.ThemeStyle.HeaderStyle.Height = 25;
            dgv_Booking.ThemeStyle.ReadOnly = true;
            dgv_Booking.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(204, 233, 231);
            dgv_Booking.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_Booking.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgv_Booking.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            dgv_Booking.ThemeStyle.RowsStyle.Height = 29;
            dgv_Booking.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(85, 185, 175);
            dgv_Booking.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black;
            // 
            // guna2Button1
            // 
            guna2Button1.Anchor = AnchorStyles.None;
            guna2Button1.BorderRadius = 3;
            guna2Button1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            guna2Button1.CustomizableEdges = customizableEdges5;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(55, 190, 177);
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(418, 818);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button1.Size = new Size(225, 56);
            guna2Button1.TabIndex = 4;
            guna2Button1.Text = "Export Data";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // dgv_id
            // 
            dgv_id.HeaderText = "Id";
            dgv_id.MinimumWidth = 6;
            dgv_id.Name = "dgv_id";
            dgv_id.ReadOnly = true;
            // 
            // dgv_Name
            // 
            dgv_Name.FillWeight = 56.738163F;
            dgv_Name.HeaderText = "Full Name";
            dgv_Name.MinimumWidth = 6;
            dgv_Name.Name = "dgv_Name";
            dgv_Name.ReadOnly = true;
            // 
            // dgv_Email
            // 
            dgv_Email.FillWeight = 56.738163F;
            dgv_Email.HeaderText = "Email";
            dgv_Email.MinimumWidth = 6;
            dgv_Email.Name = "dgv_Email";
            dgv_Email.ReadOnly = true;
            // 
            // dgv_RoomNumber
            // 
            dgv_RoomNumber.HeaderText = "Room Number";
            dgv_RoomNumber.MinimumWidth = 6;
            dgv_RoomNumber.Name = "dgv_RoomNumber";
            dgv_RoomNumber.ReadOnly = true;
            // 
            // dgv_dd
            // 
            dgv_dd.HeaderText = "Date Start";
            dgv_dd.MinimumWidth = 6;
            dgv_dd.Name = "dgv_dd";
            dgv_dd.ReadOnly = true;
            // 
            // dgv_df
            // 
            dgv_df.HeaderText = "Date End";
            dgv_df.MinimumWidth = 6;
            dgv_df.Name = "dgv_df";
            dgv_df.ReadOnly = true;
            // 
            // dgv_status
            // 
            dgv_status.HeaderText = "Status";
            dgv_status.MinimumWidth = 6;
            dgv_status.Name = "dgv_status";
            dgv_status.ReadOnly = true;
            // 
            // Booking
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1102, 875);
            Controls.Add(guna2Button1);
            Controls.Add(dgv_Booking);
            Controls.Add(guna2Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Booking";
            Text = "Booking";
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Booking).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox booking_input;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        public Guna.UI2.WinForms.Guna2DataGridView dgv_Booking;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private DataGridViewTextBoxColumn dgv_id;
        private DataGridViewTextBoxColumn dgv_Name;
        private DataGridViewTextBoxColumn dgv_Email;
        private DataGridViewTextBoxColumn dgv_RoomNumber;
        private DataGridViewTextBoxColumn dgv_dd;
        private DataGridViewTextBoxColumn dgv_df;
        private DataGridViewTextBoxColumn dgv_status;
    }
}