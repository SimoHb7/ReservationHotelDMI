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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebClients));
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            Search_input = new Guna.UI2.WinForms.Guna2TextBox();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            dgv_webclients = new Guna.UI2.WinForms.Guna2DataGridView();
            dgv_Name = new DataGridViewTextBoxColumn();
            dgv_Email = new DataGridViewTextBoxColumn();
            dgv_dd = new DataGridViewTextBoxColumn();
            dgv_df = new DataGridViewTextBoxColumn();
            dgv_Rt = new DataGridViewTextBoxColumn();
            dgv_Bed = new DataGridViewTextBoxColumn();
            dgv_refused = new DataGridViewImageColumn();
            dgv_accepted = new DataGridViewImageColumn();
            dgv_Checkin = new Guna.UI2.WinForms.Guna2DataGridView();
            dgv_id = new DataGridViewTextBoxColumn();
            dgv_Number = new DataGridViewTextBoxColumn();
            dgv_Type = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dgv_Price = new DataGridViewTextBoxColumn();
            Room_number_input = new Guna.UI2.WinForms.Guna2TextBox();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_webclients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Checkin).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.FromArgb(55, 190, 177);
            guna2Panel1.Controls.Add(Search_input);
            guna2Panel1.Controls.Add(guna2HtmlLabel2);
            guna2Panel1.Controls.Add(guna2HtmlLabel1);
            guna2Panel1.CustomizableEdges = customizableEdges9;
            guna2Panel1.Dock = DockStyle.Top;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2Panel1.Size = new Size(1102, 131);
            guna2Panel1.TabIndex = 0;
            // 
            // Search_input
            // 
            Search_input.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Search_input.CustomizableEdges = customizableEdges7;
            Search_input.DefaultText = "";
            Search_input.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Search_input.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Search_input.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Search_input.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Search_input.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Search_input.Font = new Font("Segoe UI", 9F);
            Search_input.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Search_input.Location = new Point(884, 84);
            Search_input.Margin = new Padding(3, 4, 3, 4);
            Search_input.Name = "Search_input";
            Search_input.PasswordChar = '\0';
            Search_input.PlaceholderText = "Search by Name ";
            Search_input.SelectedText = "";
            Search_input.ShadowDecoration.CustomizableEdges = customizableEdges8;
            Search_input.Size = new Size(210, 37);
            Search_input.TabIndex = 4;
            Search_input.TextChanged += Search_input_TextChanged;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel2.ForeColor = Color.White;
            guna2HtmlLabel2.Location = new Point(884, 52);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(56, 25);
            guna2HtmlLabel2.TabIndex = 3;
            guna2HtmlLabel2.Text = "Search";
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.Anchor = AnchorStyles.None;
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = Color.White;
            guna2HtmlLabel1.Location = new Point(467, 38);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(156, 39);
            guna2HtmlLabel1.TabIndex = 1;
            guna2HtmlLabel1.Text = "Web Clients";
            // 
            // dgv_webclients
            // 
            dgv_webclients.AllowUserToAddRows = false;
            dgv_webclients.AllowUserToDeleteRows = false;
            dgv_webclients.AllowUserToResizeColumns = false;
            dgv_webclients.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(179, 223, 219);
            dgv_webclients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dgv_webclients.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgv_webclients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgv_webclients.ColumnHeadersHeight = 25;
            dgv_webclients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv_webclients.Columns.AddRange(new DataGridViewColumn[] { dgv_Name, dgv_Email, dgv_dd, dgv_df, dgv_Rt, dgv_Bed, dgv_refused, dgv_accepted });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(204, 233, 231);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(85, 185, 175);
            dataGridViewCellStyle9.SelectionForeColor = Color.Black;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dgv_webclients.DefaultCellStyle = dataGridViewCellStyle9;
            dgv_webclients.GridColor = Color.FromArgb(177, 222, 218);
            dgv_webclients.Location = new Point(21, 148);
            dgv_webclients.Name = "dgv_webclients";
            dgv_webclients.ReadOnly = true;
            dgv_webclients.RowHeadersVisible = false;
            dgv_webclients.RowHeadersWidth = 51;
            dgv_webclients.Size = new Size(1063, 329);
            dgv_webclients.TabIndex = 2;
            dgv_webclients.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Teal;
            dgv_webclients.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(179, 223, 219);
            dgv_webclients.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgv_webclients.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgv_webclients.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgv_webclients.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgv_webclients.ThemeStyle.BackColor = Color.White;
            dgv_webclients.ThemeStyle.GridColor = Color.FromArgb(177, 222, 218);
            dgv_webclients.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(0, 150, 136);
            dgv_webclients.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv_webclients.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgv_webclients.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgv_webclients.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv_webclients.ThemeStyle.HeaderStyle.Height = 25;
            dgv_webclients.ThemeStyle.ReadOnly = true;
            dgv_webclients.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(204, 233, 231);
            dgv_webclients.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_webclients.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgv_webclients.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            dgv_webclients.ThemeStyle.RowsStyle.Height = 29;
            dgv_webclients.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(85, 185, 175);
            dgv_webclients.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black;
            dgv_webclients.CellContentClick += dgv_webclients_CellContentClick;
            dgv_webclients.SelectionChanged += dgv_webclients_SelectionChanged;
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
            // dgv_Checkin
            // 
            dgv_Checkin.AutoGenerateColumns = false;
            dgv_Checkin.AllowUserToAddRows = false;
            dgv_Checkin.AllowUserToDeleteRows = false;
            dgv_Checkin.AllowUserToResizeColumns = false;
            dgv_Checkin.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(179, 223, 219);
            dgv_Checkin.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dgv_Checkin.Anchor = AnchorStyles.None;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(0, 150, 136);
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dgv_Checkin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dgv_Checkin.ColumnHeadersHeight = 25;
            dgv_Checkin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv_Checkin.Columns.AddRange(new DataGridViewColumn[] { dgv_id, dgv_Number, dgv_Type, dataGridViewTextBoxColumn1, dgv_Price });
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(204, 233, 231);
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle12.ForeColor = Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(85, 185, 175);
            dataGridViewCellStyle12.SelectionForeColor = Color.Black;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dgv_Checkin.DefaultCellStyle = dataGridViewCellStyle12;
            dgv_Checkin.GridColor = Color.FromArgb(177, 222, 218);
            dgv_Checkin.Location = new Point(123, 567);
            dgv_Checkin.Name = "dgv_Checkin";
            dgv_Checkin.ReadOnly = true;
            dgv_Checkin.RowHeadersVisible = false;
            dgv_Checkin.RowHeadersWidth = 51;
            dgv_Checkin.Size = new Size(852, 296);
            dgv_Checkin.TabIndex = 41;
            dgv_Checkin.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Teal;
            dgv_Checkin.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(179, 223, 219);
            dgv_Checkin.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgv_Checkin.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgv_Checkin.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgv_Checkin.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgv_Checkin.ThemeStyle.BackColor = Color.White;
            dgv_Checkin.ThemeStyle.GridColor = Color.FromArgb(177, 222, 218);
            dgv_Checkin.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(0, 150, 136);
            dgv_Checkin.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv_Checkin.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgv_Checkin.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgv_Checkin.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv_Checkin.ThemeStyle.HeaderStyle.Height = 25;
            dgv_Checkin.ThemeStyle.ReadOnly = true;
            dgv_Checkin.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(204, 233, 231);
            dgv_Checkin.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_Checkin.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgv_Checkin.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            dgv_Checkin.ThemeStyle.RowsStyle.Height = 29;
            dgv_Checkin.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(85, 185, 175);
            dgv_Checkin.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black;
            dgv_Checkin.CellContentClick += dgv_Checkin_CellContentClick;
            // 
            // dgv_id
            // 
            dgv_id.FillWeight = 56.738163F;
            dgv_id.HeaderText = "id";
            dgv_id.MinimumWidth = 6;
            dgv_id.Name = "dgv_id";
            dgv_id.ReadOnly = true;
            // 
            // dgv_Number
            // 
            dgv_Number.FillWeight = 56.738163F;
            dgv_Number.HeaderText = "Number";
            dgv_Number.MinimumWidth = 6;
            dgv_Number.Name = "dgv_Number";
            dgv_Number.ReadOnly = true;
            // 
            // dgv_Type
            // 
            dgv_Type.FillWeight = 56.738163F;
            dgv_Type.HeaderText = "Type";
            dgv_Type.MinimumWidth = 6;
            dgv_Type.Name = "dgv_Type";
            dgv_Type.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.FillWeight = 56.738163F;
            dataGridViewTextBoxColumn1.HeaderText = "Bed";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dgv_Price
            // 
            dgv_Price.FillWeight = 56.738163F;
            dgv_Price.HeaderText = "Price";
            dgv_Price.MinimumWidth = 6;
            dgv_Price.Name = "dgv_Price";
            dgv_Price.ReadOnly = true;
            // 
            // Room_number_input
            // 
            Room_number_input.Anchor = AnchorStyles.None;
            Room_number_input.BorderColor = Color.FromArgb(55, 190, 177);
            Room_number_input.CustomizableEdges = customizableEdges11;
            Room_number_input.DefaultText = "";
            Room_number_input.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Room_number_input.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Room_number_input.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Room_number_input.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Room_number_input.Enabled = false;
            Room_number_input.FillColor = Color.WhiteSmoke;
            Room_number_input.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Room_number_input.Font = new Font("Segoe UI", 9F);
            Room_number_input.ForeColor = Color.Black;
            Room_number_input.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Room_number_input.Location = new Point(425, 506);
            Room_number_input.Margin = new Padding(3, 4, 3, 4);
            Room_number_input.Name = "Room_number_input";
            Room_number_input.PasswordChar = '\0';
            Room_number_input.PlaceholderText = "Room Number";
            Room_number_input.SelectedText = "";
            Room_number_input.ShadowDecoration.CustomizableEdges = customizableEdges12;
            Room_number_input.Size = new Size(273, 40);
            Room_number_input.TabIndex = 53;
            // 
            // WebClients
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1102, 875);
            Controls.Add(Room_number_input);
            Controls.Add(dgv_Checkin);
            Controls.Add(dgv_webclients);
            Controls.Add(guna2Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "WebClients";
            Text = "Booking";
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_webclients).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Checkin).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        public Guna.UI2.WinForms.Guna2DataGridView dgv_webclients;
        private DataGridViewTextBoxColumn dgv_Name;
        private DataGridViewTextBoxColumn dgv_Email;
        private DataGridViewTextBoxColumn dgv_dd;
        private DataGridViewTextBoxColumn dgv_df;
        private DataGridViewTextBoxColumn dgv_Rt;
        private DataGridViewTextBoxColumn dgv_Bed;
        private DataGridViewImageColumn dgv_refused;
        private DataGridViewImageColumn dgv_accepted;
        public Guna.UI2.WinForms.Guna2DataGridView dgv_Checkin;
        private DataGridViewTextBoxColumn dgv_id;
        private DataGridViewTextBoxColumn dgv_Number;
        private DataGridViewTextBoxColumn dgv_Type;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dgv_Price;
        private Guna.UI2.WinForms.Guna2TextBox Room_number_input;
        private Guna.UI2.WinForms.Guna2TextBox Search_input;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
    }
}