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
            lblAdmin.Location = new Point(91, 128);
            lblAdmin.Name = "lblAdmin";
            lblAdmin.Size = new Size(137, 45);
            lblAdmin.TabIndex = 0;
            lblAdmin.Text = "ADMIN";
            lblAdmin.Click += lblAdmin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(48, 9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 142);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblStudentInformation
            // 
            lblStudentInformation.AutoSize = true;
            lblStudentInformation.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentInformation.Location = new Point(66, 199);
            lblStudentInformation.Name = "lblStudentInformation";
            lblStudentInformation.Size = new Size(194, 20);
            lblStudentInformation.TabIndex = 2;
            lblStudentInformation.Text = "STUDENT INFORMATION";
            lblStudentInformation.Click += lblStudentInformation_Click;
            // 
            // lblAssessment
            // 
            lblAssessment.AutoSize = true;
            lblAssessment.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAssessment.Location = new Point(66, 236);
            lblAssessment.Name = "lblAssessment";
            lblAssessment.Size = new Size(109, 20);
            lblAssessment.TabIndex = 3;
            lblAssessment.Text = "ASSESSMENT";
            // 
            // lblStudentRegistration
            // 
            lblStudentRegistration.AutoSize = true;
            lblStudentRegistration.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentRegistration.Location = new Point(66, 270);
            lblStudentRegistration.Name = "lblStudentRegistration";
            lblStudentRegistration.Size = new Size(196, 60);
            lblStudentRegistration.TabIndex = 4;
            lblStudentRegistration.Text = "STUDENT REGISTRATION\r\n\r\n\r\n";
            lblStudentRegistration.Click += lblStudentRegistration_Click;
            // 
            // lblReport
            // 
            lblReport.AutoSize = true;
            lblReport.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReport.Location = new Point(66, 388);
            lblReport.Name = "lblReport";
            lblReport.Size = new Size(68, 20);
            lblReport.TabIndex = 5;
            lblReport.Text = "REPORT";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(360, 114);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(700, 282);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // btnLogoutAdmin
            // 
            btnLogoutAdmin.BackColor = Color.LightGray;
            btnLogoutAdmin.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogoutAdmin.Location = new Point(1054, 24);
            btnLogoutAdmin.Margin = new Padding(3, 2, 3, 2);
            btnLogoutAdmin.Name = "btnLogoutAdmin";
            btnLogoutAdmin.Size = new Size(79, 24);
            btnLogoutAdmin.TabIndex = 8;
            btnLogoutAdmin.Text = "Logout";
            btnLogoutAdmin.UseVisualStyleBackColor = false;
            btnLogoutAdmin.Click += btnLogoutAdmin_Click;
            // 
            // btnAdminOverview
            // 
            btnAdminOverview.BackColor = Color.LightGray;
            btnAdminOverview.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminOverview.ForeColor = Color.SteelBlue;
            btnAdminOverview.Location = new Point(585, 427);
            btnAdminOverview.Margin = new Padding(3, 2, 3, 2);
            btnAdminOverview.Name = "btnAdminOverview";
            btnAdminOverview.Size = new Size(253, 34);
            btnAdminOverview.TabIndex = 11;
            btnAdminOverview.Text = "ADMIN OVERVIEW";
            btnAdminOverview.UseVisualStyleBackColor = false;
            // 
            // btnSearchStudentAdmn
            // 
            btnSearchStudentAdmn.BackColor = Color.LightGray;
            btnSearchStudentAdmn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearchStudentAdmn.Location = new Point(934, 70);
            btnSearchStudentAdmn.Margin = new Padding(3, 2, 3, 2);
            btnSearchStudentAdmn.Name = "btnSearchStudentAdmn";
            btnSearchStudentAdmn.Size = new Size(126, 28);
            btnSearchStudentAdmn.TabIndex = 12;
            btnSearchStudentAdmn.Text = "Search Student";
            btnSearchStudentAdmn.UseVisualStyleBackColor = false;
            // 
            // txtAdminSearch
            // 
            txtAdminSearch.Location = new Point(357, 75);
            txtAdminSearch.Margin = new Padding(3, 2, 3, 2);
            txtAdminSearch.Name = "txtAdminSearch";
            txtAdminSearch.Size = new Size(572, 23);
            txtAdminSearch.TabIndex = 13;
            // 
            // lblPayment
            // 
            lblPayment.AutoSize = true;
            lblPayment.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPayment.Location = new Point(66, 308);
            lblPayment.Name = "lblPayment";
            lblPayment.Size = new Size(85, 20);
            lblPayment.TabIndex = 14;
            lblPayment.Text = "PAYMENT";
            // 
            // lblPaymentHistory
            // 
            lblPaymentHistory.AutoSize = true;
            lblPaymentHistory.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPaymentHistory.Location = new Point(66, 349);
            lblPaymentHistory.Name = "lblPaymentHistory";
            lblPaymentHistory.Size = new Size(156, 20);
            lblPaymentHistory.TabIndex = 15;
            lblPaymentHistory.Text = "PAYMENT HISTORY";
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1155, 499);
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
            Margin = new Padding(3, 2, 3, 2);
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