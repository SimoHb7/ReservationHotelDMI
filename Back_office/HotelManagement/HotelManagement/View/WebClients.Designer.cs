namespace HotelManagement.View
{
    partial class WebClients
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebClients));
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            dgv_Booking = new Guna.UI2.WinForms.Guna2DataGridView();
            dgv_Name = new DataGridViewTextBoxColumn();
            dgv_Email = new DataGridViewTextBoxColumn();
            dgv_dd = new DataGridViewTextBoxColumn();
            dgv_df = new DataGridViewTextBoxColumn();
            dgv_Rt = new DataGridViewTextBoxColumn();
            dgv_Bed = new DataGridViewTextBoxColumn();
            dgv_status = new DataGridViewTextBoxColumn();
            dgv_refused = new DataGridViewImageColumn();
            dgv_accepted = new DataGridViewImageColumn();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Booking).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.FromArgb(55, 190, 177);
            guna2Panel1.Controls.Add(guna2HtmlLabel1);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Dock = DockStyle.Top;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(1102, 131);
            guna2Panel1.TabIndex = 0;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.Anchor = AnchorStyles.None;
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = Color.White;
            guna2HtmlLabel1.Location = new Point(467, 44);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(156, 39);
            guna2HtmlLabel1.TabIndex = 1;
            guna2HtmlLabel1.Text = "Web Clients";
            // 
            // dgv_Booking
            // 
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
            dgv_Booking.Columns.AddRange(new DataGridViewColumn[] { dgv_Name, dgv_Email, dgv_dd, dgv_df, dgv_Rt, dgv_Bed, dgv_status, dgv_refused, dgv_accepted });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(204, 233, 231);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(85, 185, 175);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgv_Booking.DefaultCellStyle = dataGridViewCellStyle3;
            dgv_Booking.GridColor = Color.FromArgb(177, 222, 218);
            dgv_Booking.Location = new Point(21, 148);
            dgv_Booking.Name = "dgv_Booking";
            dgv_Booking.ReadOnly = true;
            dgv_Booking.RowHeadersVisible = false;
            dgv_Booking.RowHeadersWidth = 51;
            dgv_Booking.Size = new Size(1063, 638);
            dgv_Booking.TabIndex = 2;
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
            // dgv_dd
            // 
            dgv_dd.HeaderText = "Date début";
            dgv_dd.MinimumWidth = 6;
            dgv_dd.Name = "dgv_dd";
            dgv_dd.ReadOnly = true;
            // 
            // dgv_df
            // 
            dgv_df.HeaderText = "Date fin";
            dgv_df.MinimumWidth = 6;
            dgv_df.Name = "dgv_df";
            dgv_df.ReadOnly = true;
            // 
            // dgv_Rt
            // 
            dgv_Rt.HeaderText = "Room type";
            dgv_Rt.MinimumWidth = 6;
            dgv_Rt.Name = "dgv_Rt";
            dgv_Rt.ReadOnly = true;
            // 
            // dgv_Bed
            // 
            dgv_Bed.HeaderText = "Bed";
            dgv_Bed.MinimumWidth = 6;
            dgv_Bed.Name = "dgv_Bed";
            dgv_Bed.ReadOnly = true;
            // 
            // dgv_status
            // 
            dgv_status.HeaderText = "Status";
            dgv_status.MinimumWidth = 6;
            dgv_status.Name = "dgv_status";
            dgv_status.ReadOnly = true;
            // 
            // dgv_refused
            // 
            dgv_refused.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_refused.FillWeight = 56.738163F;
            dgv_refused.HeaderText = "Refuse";
            dgv_refused.Image = (Image)resources.GetObject("dgv_refused.Image");
            dgv_refused.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgv_refused.MinimumWidth = 6;
            dgv_refused.Name = "dgv_refused";
            dgv_refused.ReadOnly = true;
            dgv_refused.Resizable = DataGridViewTriState.True;
            dgv_refused.Width = 64;
            // 
            // dgv_accepted
            // 
            dgv_accepted.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_accepted.FillWeight = 56.738163F;
            dgv_accepted.HeaderText = "Accepte";
            dgv_accepted.Image = (Image)resources.GetObject("dgv_accepted.Image");
            dgv_accepted.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgv_accepted.MinimumWidth = 6;
            dgv_accepted.Name = "dgv_accepted";
            dgv_accepted.ReadOnly = true;
            dgv_accepted.Resizable = DataGridViewTriState.True;
            dgv_accepted.Width = 75;
            // 
            // WebClients
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1102, 875);
            Controls.Add(dgv_Booking);
            Controls.Add(guna2Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "WebClients";
            Text = "Booking";
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Booking).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        public Guna.UI2.WinForms.Guna2DataGridView dgv_Booking;
        private DataGridViewTextBoxColumn dgv_Name;
        private DataGridViewTextBoxColumn dgv_Email;
        private DataGridViewTextBoxColumn dgv_dd;
        private DataGridViewTextBoxColumn dgv_df;
        private DataGridViewTextBoxColumn dgv_Rt;
        private DataGridViewTextBoxColumn dgv_Bed;
        private DataGridViewTextBoxColumn dgv_status;
        private DataGridViewImageColumn dgv_refused;
        private DataGridViewImageColumn dgv_accepted;
    }
}