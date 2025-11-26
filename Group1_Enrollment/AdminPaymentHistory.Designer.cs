namespace EventDriven.Project.UI
{
    partial class AdminPaymentHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPaymentHistory));
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            pcAdminPaymentHistory = new PictureBox();
            btnAdminStuedntInfo_PaymentHistory = new Button();
            btnAdminAssessment_PaymentHistory = new Button();
            btnStudentRegistration_PaymentHistory_Admin = new Button();
            btnPayment_PaymentHistory_Admin = new Button();
            btnPaymentHistory_Admin = new Button();
            btnReport_PaymentHistory_Admin = new Button();
            btnLogout_PaymentHistory_Admin = new Button();
            btnViewHistory_AdminPaymentHistory = new Button();
            dtgAdminPaymentHistory = new DataGridView();
            txtSearch_AdminPaymentHistory = new TextBox();
            btnSearchStudent_AdminPaymentHistory = new Button();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcAdminPaymentHistory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgAdminPaymentHistory).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.CadetBlue;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(btnAdminStuedntInfo_PaymentHistory);
            flowLayoutPanel1.Controls.Add(btnAdminAssessment_PaymentHistory);
            flowLayoutPanel1.Controls.Add(btnStudentRegistration_PaymentHistory_Admin);
            flowLayoutPanel1.Controls.Add(btnPayment_PaymentHistory_Admin);
            flowLayoutPanel1.Controls.Add(btnPaymentHistory_Admin);
            flowLayoutPanel1.Controls.Add(btnReport_PaymentHistory_Admin);
            flowLayoutPanel1.Controls.Add(btnLogout_PaymentHistory_Admin);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(474, 1033);
            flowLayoutPanel1.TabIndex = 235;
            // 
            // panel1
            // 
            panel1.Controls.Add(pcAdminPaymentHistory);
            panel1.Location = new Point(3, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(458, 277);
            panel1.TabIndex = 0;
            // 
            // pcAdminPaymentHistory
            // 
            pcAdminPaymentHistory.BackColor = Color.CadetBlue;
            pcAdminPaymentHistory.Image = (Image)resources.GetObject("pcAdminPaymentHistory.Image");
            pcAdminPaymentHistory.Location = new Point(56, 26);
            pcAdminPaymentHistory.Margin = new Padding(3, 4, 3, 4);
            pcAdminPaymentHistory.Name = "pcAdminPaymentHistory";
            pcAdminPaymentHistory.Size = new Size(333, 239);
            pcAdminPaymentHistory.SizeMode = PictureBoxSizeMode.StretchImage;
            pcAdminPaymentHistory.TabIndex = 0;
            pcAdminPaymentHistory.TabStop = false;
            pcAdminPaymentHistory.Click += pcAdminPaymentHistory_Click;
            // 
            // btnAdminStuedntInfo_PaymentHistory
            // 
            btnAdminStuedntInfo_PaymentHistory.BackColor = Color.CadetBlue;
            btnAdminStuedntInfo_PaymentHistory.FlatStyle = FlatStyle.Flat;
            btnAdminStuedntInfo_PaymentHistory.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnAdminStuedntInfo_PaymentHistory.ForeColor = Color.AliceBlue;
            btnAdminStuedntInfo_PaymentHistory.Location = new Point(23, 298);
            btnAdminStuedntInfo_PaymentHistory.Margin = new Padding(23, 13, 3, 4);
            btnAdminStuedntInfo_PaymentHistory.Name = "btnAdminStuedntInfo_PaymentHistory";
            btnAdminStuedntInfo_PaymentHistory.Size = new Size(421, 79);
            btnAdminStuedntInfo_PaymentHistory.TabIndex = 3;
            btnAdminStuedntInfo_PaymentHistory.Text = " STUDENT INFORMATION";
            btnAdminStuedntInfo_PaymentHistory.UseVisualStyleBackColor = false;
            btnAdminStuedntInfo_PaymentHistory.Click += btnAdminStuedntInfo_PaymentHistory_Click;
            // 
            // btnAdminAssessment_PaymentHistory
            // 
            btnAdminAssessment_PaymentHistory.FlatStyle = FlatStyle.Flat;
            btnAdminAssessment_PaymentHistory.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnAdminAssessment_PaymentHistory.ForeColor = Color.AliceBlue;
            btnAdminAssessment_PaymentHistory.Location = new Point(23, 385);
            btnAdminAssessment_PaymentHistory.Margin = new Padding(23, 4, 3, 4);
            btnAdminAssessment_PaymentHistory.Name = "btnAdminAssessment_PaymentHistory";
            btnAdminAssessment_PaymentHistory.Size = new Size(421, 79);
            btnAdminAssessment_PaymentHistory.TabIndex = 4;
            btnAdminAssessment_PaymentHistory.Text = "ASSESSMENT";
            btnAdminAssessment_PaymentHistory.UseVisualStyleBackColor = true;
            btnAdminAssessment_PaymentHistory.Click += btnAdminAssessment_PaymentHistory_Click;
            // 
            // btnStudentRegistration_PaymentHistory_Admin
            // 
            btnStudentRegistration_PaymentHistory_Admin.BackColor = Color.CadetBlue;
            btnStudentRegistration_PaymentHistory_Admin.FlatStyle = FlatStyle.Flat;
            btnStudentRegistration_PaymentHistory_Admin.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnStudentRegistration_PaymentHistory_Admin.ForeColor = Color.AliceBlue;
            btnStudentRegistration_PaymentHistory_Admin.Location = new Point(23, 472);
            btnStudentRegistration_PaymentHistory_Admin.Margin = new Padding(23, 4, 3, 4);
            btnStudentRegistration_PaymentHistory_Admin.Name = "btnStudentRegistration_PaymentHistory_Admin";
            btnStudentRegistration_PaymentHistory_Admin.Size = new Size(421, 79);
            btnStudentRegistration_PaymentHistory_Admin.TabIndex = 5;
            btnStudentRegistration_PaymentHistory_Admin.Text = " STUDENT REGISTRATION";
            btnStudentRegistration_PaymentHistory_Admin.UseVisualStyleBackColor = false;
            btnStudentRegistration_PaymentHistory_Admin.Click += btnStudentRegistration_PaymentHistory_Admin_Click;
            // 
            // btnPayment_PaymentHistory_Admin
            // 
            btnPayment_PaymentHistory_Admin.BackColor = Color.CadetBlue;
            btnPayment_PaymentHistory_Admin.FlatStyle = FlatStyle.Flat;
            btnPayment_PaymentHistory_Admin.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnPayment_PaymentHistory_Admin.ForeColor = Color.AliceBlue;
            btnPayment_PaymentHistory_Admin.Location = new Point(23, 559);
            btnPayment_PaymentHistory_Admin.Margin = new Padding(23, 4, 3, 4);
            btnPayment_PaymentHistory_Admin.Name = "btnPayment_PaymentHistory_Admin";
            btnPayment_PaymentHistory_Admin.Size = new Size(421, 79);
            btnPayment_PaymentHistory_Admin.TabIndex = 6;
            btnPayment_PaymentHistory_Admin.Text = "PAYMENT";
            btnPayment_PaymentHistory_Admin.UseVisualStyleBackColor = false;
            btnPayment_PaymentHistory_Admin.Click += btnPayment_PaymentHistory_Admin_Click;
            // 
            // btnPaymentHistory_Admin
            // 
            btnPaymentHistory_Admin.BackColor = Color.DarkSlateGray;
            btnPaymentHistory_Admin.FlatStyle = FlatStyle.Flat;
            btnPaymentHistory_Admin.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnPaymentHistory_Admin.ForeColor = Color.AliceBlue;
            btnPaymentHistory_Admin.Location = new Point(23, 646);
            btnPaymentHistory_Admin.Margin = new Padding(23, 4, 3, 4);
            btnPaymentHistory_Admin.Name = "btnPaymentHistory_Admin";
            btnPaymentHistory_Admin.Size = new Size(421, 79);
            btnPaymentHistory_Admin.TabIndex = 7;
            btnPaymentHistory_Admin.Text = "PAYMENT HISTORY";
            btnPaymentHistory_Admin.UseVisualStyleBackColor = false;
            // 
            // btnReport_PaymentHistory_Admin
            // 
            btnReport_PaymentHistory_Admin.FlatStyle = FlatStyle.Flat;
            btnReport_PaymentHistory_Admin.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnReport_PaymentHistory_Admin.ForeColor = Color.AliceBlue;
            btnReport_PaymentHistory_Admin.Location = new Point(23, 733);
            btnReport_PaymentHistory_Admin.Margin = new Padding(23, 4, 3, 4);
            btnReport_PaymentHistory_Admin.Name = "btnReport_PaymentHistory_Admin";
            btnReport_PaymentHistory_Admin.Size = new Size(421, 79);
            btnReport_PaymentHistory_Admin.TabIndex = 8;
            btnReport_PaymentHistory_Admin.Text = "REPORT";
            btnReport_PaymentHistory_Admin.UseVisualStyleBackColor = true;
            btnReport_PaymentHistory_Admin.Click += btnReport_PaymentHistory_Admin_Click;
            // 
            // btnLogout_PaymentHistory_Admin
            // 
            btnLogout_PaymentHistory_Admin.FlatStyle = FlatStyle.Flat;
            btnLogout_PaymentHistory_Admin.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnLogout_PaymentHistory_Admin.ForeColor = Color.AliceBlue;
            btnLogout_PaymentHistory_Admin.Location = new Point(23, 820);
            btnLogout_PaymentHistory_Admin.Margin = new Padding(23, 4, 3, 4);
            btnLogout_PaymentHistory_Admin.Name = "btnLogout_PaymentHistory_Admin";
            btnLogout_PaymentHistory_Admin.Size = new Size(421, 79);
            btnLogout_PaymentHistory_Admin.TabIndex = 9;
            btnLogout_PaymentHistory_Admin.Text = "LOG OUT";
            btnLogout_PaymentHistory_Admin.UseVisualStyleBackColor = true;
            btnLogout_PaymentHistory_Admin.Click += btnLogout_PaymentHistory_Admin_Click;
            // 
            // btnViewHistory_AdminPaymentHistory
            // 
            btnViewHistory_AdminPaymentHistory.BackColor = Color.CadetBlue;
            btnViewHistory_AdminPaymentHistory.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnViewHistory_AdminPaymentHistory.ForeColor = Color.AliceBlue;
            btnViewHistory_AdminPaymentHistory.Location = new Point(526, 60);
            btnViewHistory_AdminPaymentHistory.Name = "btnViewHistory_AdminPaymentHistory";
            btnViewHistory_AdminPaymentHistory.Size = new Size(201, 50);
            btnViewHistory_AdminPaymentHistory.TabIndex = 241;
            btnViewHistory_AdminPaymentHistory.Text = "View History";
            btnViewHistory_AdminPaymentHistory.UseVisualStyleBackColor = false;
            btnViewHistory_AdminPaymentHistory.Click += btnViewHistory_AdminPaymentHistory_Click;
            // 
            // dtgAdminPaymentHistory
            // 
            dtgAdminPaymentHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgAdminPaymentHistory.Location = new Point(526, 138);
            dtgAdminPaymentHistory.Margin = new Padding(3, 4, 3, 4);
            dtgAdminPaymentHistory.Name = "dtgAdminPaymentHistory";
            dtgAdminPaymentHistory.RowHeadersWidth = 51;
            dtgAdminPaymentHistory.Size = new Size(1332, 895);
            dtgAdminPaymentHistory.TabIndex = 238;
            // 
            // txtSearch_AdminPaymentHistory
            // 
            txtSearch_AdminPaymentHistory.Font = new Font("Segoe UI", 14F);
            txtSearch_AdminPaymentHistory.Location = new Point(783, 58);
            txtSearch_AdminPaymentHistory.Margin = new Padding(3, 4, 3, 4);
            txtSearch_AdminPaymentHistory.Multiline = true;
            txtSearch_AdminPaymentHistory.Name = "txtSearch_AdminPaymentHistory";
            txtSearch_AdminPaymentHistory.Size = new Size(868, 48);
            txtSearch_AdminPaymentHistory.TabIndex = 239;
            // 
            // btnSearchStudent_AdminPaymentHistory
            // 
            btnSearchStudent_AdminPaymentHistory.BackColor = Color.CadetBlue;
            btnSearchStudent_AdminPaymentHistory.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnSearchStudent_AdminPaymentHistory.ForeColor = Color.AliceBlue;
            btnSearchStudent_AdminPaymentHistory.Location = new Point(1657, 56);
            btnSearchStudent_AdminPaymentHistory.Name = "btnSearchStudent_AdminPaymentHistory";
            btnSearchStudent_AdminPaymentHistory.Size = new Size(201, 50);
            btnSearchStudent_AdminPaymentHistory.TabIndex = 236;
            btnSearchStudent_AdminPaymentHistory.Text = "Search Student";
            btnSearchStudent_AdminPaymentHistory.UseVisualStyleBackColor = false;
            btnSearchStudent_AdminPaymentHistory.Click += btnSearchStudent_AdminPaymentHistory_Click;
            // 
            // AdminPaymentHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1902, 1033);
            Controls.Add(btnViewHistory_AdminPaymentHistory);
            Controls.Add(dtgAdminPaymentHistory);
            Controls.Add(txtSearch_AdminPaymentHistory);
            Controls.Add(btnSearchStudent_AdminPaymentHistory);
            Controls.Add(flowLayoutPanel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AdminPaymentHistory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminPaymentHistory";
            Load += AdminPaymentHistory_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcAdminPaymentHistory).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgAdminPaymentHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private PictureBox pcAdminPaymentHistory;
        private Button btnAdminStuedntInfo_PaymentHistory;
        private Button btnAdminAssessment_PaymentHistory;
        private Button btnStudentRegistration_PaymentHistory_Admin;
        private Button btnPayment_PaymentHistory_Admin;
        private Button btnPaymentHistory_Admin;
        private Button btnReport_PaymentHistory_Admin;
        private Button btnLogout_PaymentHistory_Admin;
        private Button btnViewHistory_AdminPaymentHistory;
        private DataGridView dtgAdminPaymentHistory;
        private TextBox txtSearch_AdminPaymentHistory;
        private Button btnSearchStudent_AdminPaymentHistory;
    }
}