namespace EventDriven.Project.UI
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            pcAdminLogo3 = new PictureBox();
            btnAdminStudentInformation3 = new Button();
            btnAdminStudreg3 = new Button();
            btnAdminPay3 = new Button();
            btnAdminAssessment3 = new Button();
            btnAdminHistory3 = new Button();
            btnAdminReport3 = new Button();
            btnAdminOut3 = new Button();
            label1 = new Label();
            cbSyear = new ComboBox();
            dtgAdminDashboard = new DataGridView();
            txtSearch = new TextBox();
            btnSearch = new Button();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcAdminLogo3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgAdminDashboard).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.CadetBlue;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(btnAdminStudentInformation3);
            flowLayoutPanel1.Controls.Add(btnAdminStudreg3);
            flowLayoutPanel1.Controls.Add(btnAdminPay3);
            flowLayoutPanel1.Controls.Add(btnAdminAssessment3);
            flowLayoutPanel1.Controls.Add(btnAdminHistory3);
            flowLayoutPanel1.Controls.Add(btnAdminReport3);
            flowLayoutPanel1.Controls.Add(btnAdminOut3);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(474, 1033);
            flowLayoutPanel1.TabIndex = 80;
            // 
            // panel1
            // 
            panel1.Controls.Add(pcAdminLogo3);
            panel1.Location = new Point(3, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(458, 277);
            panel1.TabIndex = 0;
            // 
            // pcAdminLogo3
            // 
            pcAdminLogo3.BackColor = Color.CadetBlue;
            pcAdminLogo3.Image = (Image)resources.GetObject("pcAdminLogo3.Image");
            pcAdminLogo3.Location = new Point(56, 27);
            pcAdminLogo3.Margin = new Padding(3, 4, 3, 4);
            pcAdminLogo3.Name = "pcAdminLogo3";
            pcAdminLogo3.Size = new Size(333, 239);
            pcAdminLogo3.SizeMode = PictureBoxSizeMode.StretchImage;
            pcAdminLogo3.TabIndex = 0;
            pcAdminLogo3.TabStop = false;
            // 
            // btnAdminStudentInformation3
            // 
            btnAdminStudentInformation3.BackColor = Color.CadetBlue;
            btnAdminStudentInformation3.FlatStyle = FlatStyle.Flat;
            btnAdminStudentInformation3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnAdminStudentInformation3.ForeColor = SystemColors.ControlLight;
            btnAdminStudentInformation3.Location = new Point(23, 298);
            btnAdminStudentInformation3.Margin = new Padding(23, 13, 3, 4);
            btnAdminStudentInformation3.Name = "btnAdminStudentInformation3";
            btnAdminStudentInformation3.Size = new Size(421, 79);
            btnAdminStudentInformation3.TabIndex = 3;
            btnAdminStudentInformation3.Text = " STUDENT INFORMATION";
            btnAdminStudentInformation3.UseVisualStyleBackColor = false;
            btnAdminStudentInformation3.Click += btnAdminStudentInformation3_Click;
            // 
            // btnAdminStudreg3
            // 
            btnAdminStudreg3.FlatStyle = FlatStyle.Flat;
            btnAdminStudreg3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnAdminStudreg3.ForeColor = Color.AliceBlue;
            btnAdminStudreg3.Location = new Point(23, 385);
            btnAdminStudreg3.Margin = new Padding(23, 4, 3, 4);
            btnAdminStudreg3.Name = "btnAdminStudreg3";
            btnAdminStudreg3.Size = new Size(421, 79);
            btnAdminStudreg3.TabIndex = 5;
            btnAdminStudreg3.Text = " STUDENT REGISTRATION";
            btnAdminStudreg3.UseVisualStyleBackColor = true;
            btnAdminStudreg3.Click += btnAdminStudreg3_Click;
            // 
            // btnAdminPay3
            // 
            btnAdminPay3.FlatStyle = FlatStyle.Flat;
            btnAdminPay3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnAdminPay3.ForeColor = Color.AliceBlue;
            btnAdminPay3.Location = new Point(23, 472);
            btnAdminPay3.Margin = new Padding(23, 4, 3, 4);
            btnAdminPay3.Name = "btnAdminPay3";
            btnAdminPay3.Size = new Size(421, 79);
            btnAdminPay3.TabIndex = 6;
            btnAdminPay3.Text = "PAYMENT";
            btnAdminPay3.UseVisualStyleBackColor = true;
            btnAdminPay3.Click += btnAdminPay3_Click;
            // 
            // btnAdminAssessment3
            // 
            btnAdminAssessment3.FlatStyle = FlatStyle.Flat;
            btnAdminAssessment3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnAdminAssessment3.ForeColor = Color.AliceBlue;
            btnAdminAssessment3.Location = new Point(23, 559);
            btnAdminAssessment3.Margin = new Padding(23, 4, 3, 4);
            btnAdminAssessment3.Name = "btnAdminAssessment3";
            btnAdminAssessment3.Size = new Size(421, 79);
            btnAdminAssessment3.TabIndex = 4;
            btnAdminAssessment3.Text = "ASSESSMENT";
            btnAdminAssessment3.UseVisualStyleBackColor = true;
            btnAdminAssessment3.Click += btnAdminAssessment3_Click;
            // 
            // btnAdminHistory3
            // 
            btnAdminHistory3.FlatStyle = FlatStyle.Flat;
            btnAdminHistory3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnAdminHistory3.ForeColor = Color.AliceBlue;
            btnAdminHistory3.Location = new Point(23, 646);
            btnAdminHistory3.Margin = new Padding(23, 4, 3, 4);
            btnAdminHistory3.Name = "btnAdminHistory3";
            btnAdminHistory3.Size = new Size(421, 79);
            btnAdminHistory3.TabIndex = 7;
            btnAdminHistory3.Text = "PAYMENT HISTORY";
            btnAdminHistory3.UseVisualStyleBackColor = true;
            btnAdminHistory3.Click += btnAdminHistory3_Click;
            // 
            // btnAdminReport3
            // 
            btnAdminReport3.FlatStyle = FlatStyle.Flat;
            btnAdminReport3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnAdminReport3.ForeColor = Color.AliceBlue;
            btnAdminReport3.Location = new Point(23, 733);
            btnAdminReport3.Margin = new Padding(23, 4, 3, 4);
            btnAdminReport3.Name = "btnAdminReport3";
            btnAdminReport3.Size = new Size(421, 79);
            btnAdminReport3.TabIndex = 8;
            btnAdminReport3.Text = "REPORT";
            btnAdminReport3.UseVisualStyleBackColor = true;
            btnAdminReport3.Click += btnAdminReport3_Click;
            // 
            // btnAdminOut3
            // 
            btnAdminOut3.FlatStyle = FlatStyle.Flat;
            btnAdminOut3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnAdminOut3.ForeColor = Color.AliceBlue;
            btnAdminOut3.Location = new Point(23, 820);
            btnAdminOut3.Margin = new Padding(23, 4, 3, 4);
            btnAdminOut3.Name = "btnAdminOut3";
            btnAdminOut3.Size = new Size(421, 79);
            btnAdminOut3.TabIndex = 9;
            btnAdminOut3.Text = "LOG OUT";
            btnAdminOut3.UseVisualStyleBackColor = true;
            btnAdminOut3.Click += btnAdminOut3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(528, 42);
            label1.Name = "label1";
            label1.Size = new Size(307, 38);
            label1.TabIndex = 81;
            label1.Text = "ENROLLED STUDENTS";
            // 
            // cbSyear
            // 
            cbSyear.FormattingEnabled = true;
            cbSyear.Items.AddRange(new object[] { "2024-2025", "2025-2026" });
            cbSyear.Location = new Point(853, 52);
            cbSyear.Name = "cbSyear";
            cbSyear.Size = new Size(234, 28);
            cbSyear.TabIndex = 82;
            cbSyear.SelectedIndexChanged += cbSyear_SelectedIndexChanged;
            // 
            // dtgAdminDashboard
            // 
            dtgAdminDashboard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgAdminDashboard.Location = new Point(528, 109);
            dtgAdminDashboard.Margin = new Padding(3, 4, 3, 4);
            dtgAdminDashboard.Name = "dtgAdminDashboard";
            dtgAdminDashboard.RowHeadersWidth = 51;
            dtgAdminDashboard.Size = new Size(1332, 924);
            dtgAdminDashboard.TabIndex = 94;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(1364, 52);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(377, 27);
            txtSearch.TabIndex = 101;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.CadetBlue;
            btnSearch.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = SystemColors.Control;
            btnSearch.Location = new Point(1747, 46);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(113, 37);
            btnSearch.TabIndex = 100;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1902, 1033);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(dtgAdminDashboard);
            Controls.Add(cbSyear);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminDashboard";
            Load += AdminDashboard_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcAdminLogo3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgAdminDashboard).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private PictureBox pcAdminLogo3;
        private Button btnAdminStudentInformation3;
        private Button btnAdminStudreg3;
        private Button btnAdminPay3;
        private Button btnAdminAssessment3;
        private Button btnAdminHistory3;
        private Button btnAdminReport3;
        private Button btnAdminOut3;
        private Label label1;
        private ComboBox cbSyear;
        private DataGridView dtgAdminDashboard;
        private TextBox txtSearch;
        private Button btnSearch;
    }
}