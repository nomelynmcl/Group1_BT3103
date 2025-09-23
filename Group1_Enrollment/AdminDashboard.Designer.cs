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
            lblAdmin = new Label();
            pictureBox1 = new PictureBox();
            lblStudentInformation = new Label();
            lblAssessment = new Label();
            lblStudentRegistration = new Label();
            lblReport = new Label();
            pictureBox2 = new PictureBox();
            btnLogoutAdmin = new Button();
            btnAdminOverview = new Button();
            btnSearchStudentAdmn = new Button();
            txtAdminSearch = new TextBox();
            lblPayment = new Label();
            lblPaymentHistory = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblAdmin
            // 
            lblAdmin.AutoSize = true;
            lblAdmin.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdmin.ForeColor = Color.SteelBlue;
            lblAdmin.Location = new Point(104, 170);
            lblAdmin.Name = "lblAdmin";
            lblAdmin.Size = new Size(168, 54);
            lblAdmin.TabIndex = 0;
            lblAdmin.Text = "ADMIN";
            lblAdmin.Click += lblAdmin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(55, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 189);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblStudentInformation
            // 
            lblStudentInformation.AutoSize = true;
            lblStudentInformation.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentInformation.Location = new Point(75, 265);
            lblStudentInformation.Name = "lblStudentInformation";
            lblStudentInformation.Size = new Size(236, 25);
            lblStudentInformation.TabIndex = 2;
            lblStudentInformation.Text = "STUDENT INFORMATION";
            // 
            // lblAssessment
            // 
            lblAssessment.AutoSize = true;
            lblAssessment.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAssessment.Location = new Point(75, 314);
            lblAssessment.Name = "lblAssessment";
            lblAssessment.Size = new Size(120, 25);
            lblAssessment.TabIndex = 3;
            lblAssessment.Text = "ASSESMENT";
            // 
            // lblStudentRegistration
            // 
            lblStudentRegistration.AutoSize = true;
            lblStudentRegistration.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentRegistration.Location = new Point(75, 360);
            lblStudentRegistration.Name = "lblStudentRegistration";
            lblStudentRegistration.Size = new Size(235, 75);
            lblStudentRegistration.TabIndex = 4;
            lblStudentRegistration.Text = "STUDENT REGISTRATION\r\n\r\n\r\n";
            // 
            // lblReport
            // 
            lblReport.AutoSize = true;
            lblReport.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReport.Location = new Point(75, 517);
            lblReport.Name = "lblReport";
            lblReport.Size = new Size(83, 25);
            lblReport.TabIndex = 5;
            lblReport.Text = "REPORT";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(411, 152);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(800, 376);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // btnLogoutAdmin
            // 
            btnLogoutAdmin.BackColor = Color.LightGray;
            btnLogoutAdmin.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogoutAdmin.Location = new Point(1205, 32);
            btnLogoutAdmin.Name = "btnLogoutAdmin";
            btnLogoutAdmin.Size = new Size(90, 32);
            btnLogoutAdmin.TabIndex = 8;
            btnLogoutAdmin.Text = "Logout";
            btnLogoutAdmin.UseVisualStyleBackColor = false;
            // 
            // btnAdminOverview
            // 
            btnAdminOverview.BackColor = Color.LightGray;
            btnAdminOverview.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminOverview.ForeColor = Color.SteelBlue;
            btnAdminOverview.Location = new Point(669, 569);
            btnAdminOverview.Name = "btnAdminOverview";
            btnAdminOverview.Size = new Size(289, 45);
            btnAdminOverview.TabIndex = 11;
            btnAdminOverview.Text = "ADMIN OVERVIEW";
            btnAdminOverview.UseVisualStyleBackColor = false;
            // 
            // btnSearchStudentAdmn
            // 
            btnSearchStudentAdmn.BackColor = Color.LightGray;
            btnSearchStudentAdmn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearchStudentAdmn.Location = new Point(1067, 94);
            btnSearchStudentAdmn.Name = "btnSearchStudentAdmn";
            btnSearchStudentAdmn.Size = new Size(144, 37);
            btnSearchStudentAdmn.TabIndex = 12;
            btnSearchStudentAdmn.Text = "Search Student";
            btnSearchStudentAdmn.UseVisualStyleBackColor = false;
            // 
            // txtAdminSearch
            // 
            txtAdminSearch.Location = new Point(408, 100);
            txtAdminSearch.Name = "txtAdminSearch";
            txtAdminSearch.Size = new Size(653, 27);
            txtAdminSearch.TabIndex = 13;
            // 
            // lblPayment
            // 
            lblPayment.AutoSize = true;
            lblPayment.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPayment.Location = new Point(75, 410);
            lblPayment.Name = "lblPayment";
            lblPayment.Size = new Size(104, 25);
            lblPayment.TabIndex = 14;
            lblPayment.Text = "PAYMENT";
            // 
            // lblPaymentHistory
            // 
            lblPaymentHistory.AutoSize = true;
            lblPaymentHistory.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPaymentHistory.Location = new Point(75, 465);
            lblPaymentHistory.Name = "lblPaymentHistory";
            lblPaymentHistory.Size = new Size(188, 25);
            lblPaymentHistory.TabIndex = 15;
            lblPaymentHistory.Text = "PAYMENT HISTORY";
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1320, 665);
            Controls.Add(lblPaymentHistory);
            Controls.Add(lblPayment);
            Controls.Add(txtAdminSearch);
            Controls.Add(btnSearchStudentAdmn);
            Controls.Add(btnAdminOverview);
            Controls.Add(btnLogoutAdmin);
            Controls.Add(pictureBox2);
            Controls.Add(lblReport);
            Controls.Add(lblStudentRegistration);
            Controls.Add(lblAssessment);
            Controls.Add(lblStudentInformation);
            Controls.Add(lblAdmin);
            Controls.Add(pictureBox1);
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminDashboard";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAdmin;
        private PictureBox pictureBox1;
        private Label lblStudentInformation;
        private Label lblAssessment;
        private Label lblStudentRegistration;
        private Label lblReport;
        private PictureBox pictureBox2;
        private Button btnLogoutAdmin;
        private Button btnAdminOverview;
        private Button btnSearchStudentAdmn;
        private TextBox txtAdminSearch;
        private Label lblPayment;
        private Label lblPaymentHistory;
    }
}