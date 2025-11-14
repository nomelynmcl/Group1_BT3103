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
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(251, 522);
            flowLayoutPanel1.TabIndex = 235;
            // 
            // panel1
            // 
            panel1.Controls.Add(pcAdminPaymentHistory);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(248, 140);
            panel1.TabIndex = 0;
            // 
            // pcAdminPaymentHistory
            // 
            pcAdminPaymentHistory.BackColor = Color.CadetBlue;
            pcAdminPaymentHistory.Image = (Image)resources.GetObject("pcAdminPaymentHistory.Image");
            pcAdminPaymentHistory.Location = new Point(44, 14);
            pcAdminPaymentHistory.Name = "pcAdminPaymentHistory";
            pcAdminPaymentHistory.Size = new Size(154, 126);
            pcAdminPaymentHistory.SizeMode = PictureBoxSizeMode.StretchImage;
            pcAdminPaymentHistory.TabIndex = 0;
            pcAdminPaymentHistory.TabStop = false;
            pcAdminPaymentHistory.Click += pcAdminPaymentHistory_Click;
            // 
            // btnAdminStuedntInfo_PaymentHistory
            // 
            btnAdminStuedntInfo_PaymentHistory.BackColor = Color.CadetBlue;
            btnAdminStuedntInfo_PaymentHistory.FlatStyle = FlatStyle.Flat;
            btnAdminStuedntInfo_PaymentHistory.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminStuedntInfo_PaymentHistory.ForeColor = SystemColors.ControlText;
            btnAdminStuedntInfo_PaymentHistory.Location = new Point(20, 156);
            btnAdminStuedntInfo_PaymentHistory.Margin = new Padding(20, 10, 3, 3);
            btnAdminStuedntInfo_PaymentHistory.Name = "btnAdminStuedntInfo_PaymentHistory";
            btnAdminStuedntInfo_PaymentHistory.Size = new Size(211, 42);
            btnAdminStuedntInfo_PaymentHistory.TabIndex = 3;
            btnAdminStuedntInfo_PaymentHistory.Text = " STUDENT INFORMATION";
            btnAdminStuedntInfo_PaymentHistory.UseVisualStyleBackColor = false;
            btnAdminStuedntInfo_PaymentHistory.Click += btnAdminStuedntInfo_PaymentHistory_Click;
            // 
            // btnAdminAssessment_PaymentHistory
            // 
            btnAdminAssessment_PaymentHistory.FlatStyle = FlatStyle.Flat;
            btnAdminAssessment_PaymentHistory.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminAssessment_PaymentHistory.Location = new Point(20, 204);
            btnAdminAssessment_PaymentHistory.Margin = new Padding(20, 3, 3, 3);
            btnAdminAssessment_PaymentHistory.Name = "btnAdminAssessment_PaymentHistory";
            btnAdminAssessment_PaymentHistory.Size = new Size(211, 42);
            btnAdminAssessment_PaymentHistory.TabIndex = 4;
            btnAdminAssessment_PaymentHistory.Text = "ASSESSMENT";
            btnAdminAssessment_PaymentHistory.UseVisualStyleBackColor = true;
            btnAdminAssessment_PaymentHistory.Click += btnAdminAssessment_PaymentHistory_Click;
            // 
            // btnStudentRegistration_PaymentHistory_Admin
            // 
            btnStudentRegistration_PaymentHistory_Admin.BackColor = Color.CadetBlue;
            btnStudentRegistration_PaymentHistory_Admin.FlatStyle = FlatStyle.Flat;
            btnStudentRegistration_PaymentHistory_Admin.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudentRegistration_PaymentHistory_Admin.ForeColor = SystemColors.ControlText;
            btnStudentRegistration_PaymentHistory_Admin.Location = new Point(20, 252);
            btnStudentRegistration_PaymentHistory_Admin.Margin = new Padding(20, 3, 3, 3);
            btnStudentRegistration_PaymentHistory_Admin.Name = "btnStudentRegistration_PaymentHistory_Admin";
            btnStudentRegistration_PaymentHistory_Admin.Size = new Size(211, 42);
            btnStudentRegistration_PaymentHistory_Admin.TabIndex = 5;
            btnStudentRegistration_PaymentHistory_Admin.Text = " STUDENT REGISTRATION";
            btnStudentRegistration_PaymentHistory_Admin.UseVisualStyleBackColor = false;
            btnStudentRegistration_PaymentHistory_Admin.Click += btnStudentRegistration_PaymentHistory_Admin_Click;
            // 
            // btnPayment_PaymentHistory_Admin
            // 
            btnPayment_PaymentHistory_Admin.BackColor = Color.CadetBlue;
            btnPayment_PaymentHistory_Admin.FlatStyle = FlatStyle.Flat;
            btnPayment_PaymentHistory_Admin.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPayment_PaymentHistory_Admin.ForeColor = SystemColors.ControlText;
            btnPayment_PaymentHistory_Admin.Location = new Point(20, 300);
            btnPayment_PaymentHistory_Admin.Margin = new Padding(20, 3, 3, 3);
            btnPayment_PaymentHistory_Admin.Name = "btnPayment_PaymentHistory_Admin";
            btnPayment_PaymentHistory_Admin.Size = new Size(211, 42);
            btnPayment_PaymentHistory_Admin.TabIndex = 6;
            btnPayment_PaymentHistory_Admin.Text = "PAYMENT";
            btnPayment_PaymentHistory_Admin.UseVisualStyleBackColor = false;
            btnPayment_PaymentHistory_Admin.Click += btnPayment_PaymentHistory_Admin_Click;
            // 
            // btnPaymentHistory_Admin
            // 
            btnPaymentHistory_Admin.BackColor = Color.DarkSlateGray;
            btnPaymentHistory_Admin.FlatStyle = FlatStyle.Flat;
            btnPaymentHistory_Admin.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPaymentHistory_Admin.ForeColor = SystemColors.ControlLight;
            btnPaymentHistory_Admin.Location = new Point(20, 348);
            btnPaymentHistory_Admin.Margin = new Padding(20, 3, 3, 3);
            btnPaymentHistory_Admin.Name = "btnPaymentHistory_Admin";
            btnPaymentHistory_Admin.Size = new Size(211, 42);
            btnPaymentHistory_Admin.TabIndex = 7;
            btnPaymentHistory_Admin.Text = "PAYMENT HISTORY";
            btnPaymentHistory_Admin.UseVisualStyleBackColor = false;
            // 
            // btnReport_PaymentHistory_Admin
            // 
            btnReport_PaymentHistory_Admin.FlatStyle = FlatStyle.Flat;
            btnReport_PaymentHistory_Admin.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReport_PaymentHistory_Admin.Location = new Point(20, 396);
            btnReport_PaymentHistory_Admin.Margin = new Padding(20, 3, 3, 3);
            btnReport_PaymentHistory_Admin.Name = "btnReport_PaymentHistory_Admin";
            btnReport_PaymentHistory_Admin.Size = new Size(211, 42);
            btnReport_PaymentHistory_Admin.TabIndex = 8;
            btnReport_PaymentHistory_Admin.Text = "REPORT";
            btnReport_PaymentHistory_Admin.UseVisualStyleBackColor = true;
            // 
            // btnLogout_PaymentHistory_Admin
            // 
            btnLogout_PaymentHistory_Admin.FlatStyle = FlatStyle.Flat;
            btnLogout_PaymentHistory_Admin.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout_PaymentHistory_Admin.Location = new Point(20, 444);
            btnLogout_PaymentHistory_Admin.Margin = new Padding(20, 3, 3, 3);
            btnLogout_PaymentHistory_Admin.Name = "btnLogout_PaymentHistory_Admin";
            btnLogout_PaymentHistory_Admin.Size = new Size(211, 42);
            btnLogout_PaymentHistory_Admin.TabIndex = 9;
            btnLogout_PaymentHistory_Admin.Text = "LOG OUT";
            btnLogout_PaymentHistory_Admin.UseVisualStyleBackColor = true;
            btnLogout_PaymentHistory_Admin.Click += btnLogout_PaymentHistory_Admin_Click;
            // 
            // btnViewHistory_AdminPaymentHistory
            // 
            btnViewHistory_AdminPaymentHistory.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnViewHistory_AdminPaymentHistory.Location = new Point(290, 12);
            btnViewHistory_AdminPaymentHistory.Margin = new Padding(3, 2, 3, 2);
            btnViewHistory_AdminPaymentHistory.Name = "btnViewHistory_AdminPaymentHistory";
            btnViewHistory_AdminPaymentHistory.Size = new Size(116, 25);
            btnViewHistory_AdminPaymentHistory.TabIndex = 241;
            btnViewHistory_AdminPaymentHistory.Text = "View History";
            btnViewHistory_AdminPaymentHistory.UseVisualStyleBackColor = true;
            btnViewHistory_AdminPaymentHistory.Click += btnViewHistory_AdminPaymentHistory_Click;
            // 
            // dtgAdminPaymentHistory
            // 
            dtgAdminPaymentHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgAdminPaymentHistory.Location = new Point(290, 55);
            dtgAdminPaymentHistory.Name = "dtgAdminPaymentHistory";
            dtgAdminPaymentHistory.RowHeadersWidth = 51;
            dtgAdminPaymentHistory.Size = new Size(742, 512);
            dtgAdminPaymentHistory.TabIndex = 238;
            // 
            // txtSearch_AdminPaymentHistory
            // 
            txtSearch_AdminPaymentHistory.Location = new Point(630, 13);
            txtSearch_AdminPaymentHistory.Name = "txtSearch_AdminPaymentHistory";
            txtSearch_AdminPaymentHistory.Size = new Size(276, 23);
            txtSearch_AdminPaymentHistory.TabIndex = 239;
            // 
            // btnSearchStudent_AdminPaymentHistory
            // 
            btnSearchStudent_AdminPaymentHistory.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSearchStudent_AdminPaymentHistory.Location = new Point(911, 12);
            btnSearchStudent_AdminPaymentHistory.Margin = new Padding(3, 2, 3, 2);
            btnSearchStudent_AdminPaymentHistory.Name = "btnSearchStudent_AdminPaymentHistory";
            btnSearchStudent_AdminPaymentHistory.Size = new Size(122, 25);
            btnSearchStudent_AdminPaymentHistory.TabIndex = 236;
            btnSearchStudent_AdminPaymentHistory.Text = "Search Student";
            btnSearchStudent_AdminPaymentHistory.UseVisualStyleBackColor = true;
            btnSearchStudent_AdminPaymentHistory.Click += btnSearchStudent_AdminPaymentHistory_Click;
            // 
            // AdminPaymentHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1058, 522);
            Controls.Add(btnViewHistory_AdminPaymentHistory);
            Controls.Add(dtgAdminPaymentHistory);
            Controls.Add(txtSearch_AdminPaymentHistory);
            Controls.Add(btnSearchStudent_AdminPaymentHistory);
            Controls.Add(flowLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
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