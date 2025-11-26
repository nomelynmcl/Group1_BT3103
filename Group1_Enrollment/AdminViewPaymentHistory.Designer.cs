namespace EventDriven.Project.UI
{
    partial class AdminViewPaymentHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminViewPaymentHistory));
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            pcAdminViewPaymentHistory = new PictureBox();
            btnAdminStuedntInfo_ViewPaymentHistory = new Button();
            btnAdminAssessment_ViewPaymentHistory = new Button();
            btnStudentRegistration_ViewPaymentHistory_Admin = new Button();
            btnPayment_ViewPaymentHistory_Admin = new Button();
            btnPaymentHistory_ViewPaymentHistory_Admin = new Button();
            btnReport_ViewPaymentHistory_Admin = new Button();
            btnLogout_ViewPaymentHistory_Admin = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblStudentID_ViewPaymentHistory_Admin = new Label();
            lblStudentName_ViewPaymentHistory_Admin = new Label();
            lblYearLevelSection_ViewPaymentHistory_Admin = new Label();
            label7 = new Label();
            dtgCharges_AdminViewPaymentHistory = new DataGridView();
            label9 = new Label();
            dtgPayment_ViewPaymentHistory_Admin = new DataGridView();
            label10 = new Label();
            btnBack_ViewPaymentHistory_Admin = new Button();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            lbStudentType_History = new Label();
            lbStatusHistory = new Label();
            label6 = new Label();
            lbModeHistory = new Label();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcAdminViewPaymentHistory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgCharges_AdminViewPaymentHistory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgPayment_ViewPaymentHistory_Admin).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.CadetBlue;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(btnAdminStuedntInfo_ViewPaymentHistory);
            flowLayoutPanel1.Controls.Add(btnStudentRegistration_ViewPaymentHistory_Admin);
            flowLayoutPanel1.Controls.Add(btnPayment_ViewPaymentHistory_Admin);
            flowLayoutPanel1.Controls.Add(btnAdminAssessment_ViewPaymentHistory);
            flowLayoutPanel1.Controls.Add(btnPaymentHistory_ViewPaymentHistory_Admin);
            flowLayoutPanel1.Controls.Add(btnReport_ViewPaymentHistory_Admin);
            flowLayoutPanel1.Controls.Add(btnLogout_ViewPaymentHistory_Admin);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(474, 1033);
            flowLayoutPanel1.TabIndex = 236;
            // 
            // panel1
            // 
            panel1.Controls.Add(pcAdminViewPaymentHistory);
            panel1.Location = new Point(3, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(458, 277);
            panel1.TabIndex = 0;
            // 
            // pcAdminViewPaymentHistory
            // 
            pcAdminViewPaymentHistory.BackColor = Color.CadetBlue;
            pcAdminViewPaymentHistory.Image = (Image)resources.GetObject("pcAdminViewPaymentHistory.Image");
            pcAdminViewPaymentHistory.Location = new Point(50, 27);
            pcAdminViewPaymentHistory.Margin = new Padding(3, 4, 3, 4);
            pcAdminViewPaymentHistory.Name = "pcAdminViewPaymentHistory";
            pcAdminViewPaymentHistory.Size = new Size(333, 239);
            pcAdminViewPaymentHistory.SizeMode = PictureBoxSizeMode.StretchImage;
            pcAdminViewPaymentHistory.TabIndex = 0;
            pcAdminViewPaymentHistory.TabStop = false;
            pcAdminViewPaymentHistory.Click += pcAdminViewPaymentHistory_Click;
            // 
            // btnAdminStuedntInfo_ViewPaymentHistory
            // 
            btnAdminStuedntInfo_ViewPaymentHistory.BackColor = Color.CadetBlue;
            btnAdminStuedntInfo_ViewPaymentHistory.FlatStyle = FlatStyle.Flat;
            btnAdminStuedntInfo_ViewPaymentHistory.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnAdminStuedntInfo_ViewPaymentHistory.ForeColor = SystemColors.ControlText;
            btnAdminStuedntInfo_ViewPaymentHistory.Location = new Point(23, 298);
            btnAdminStuedntInfo_ViewPaymentHistory.Margin = new Padding(23, 13, 3, 4);
            btnAdminStuedntInfo_ViewPaymentHistory.Name = "btnAdminStuedntInfo_ViewPaymentHistory";
            btnAdminStuedntInfo_ViewPaymentHistory.Size = new Size(421, 79);
            btnAdminStuedntInfo_ViewPaymentHistory.TabIndex = 3;
            btnAdminStuedntInfo_ViewPaymentHistory.Text = " STUDENT INFORMATION";
            btnAdminStuedntInfo_ViewPaymentHistory.UseVisualStyleBackColor = false;
            btnAdminStuedntInfo_ViewPaymentHistory.Click += btnAdminStuedntInfo_ViewPaymentHistory_Click;
            // 
            // btnAdminAssessment_ViewPaymentHistory
            // 
            btnAdminAssessment_ViewPaymentHistory.FlatStyle = FlatStyle.Flat;
            btnAdminAssessment_ViewPaymentHistory.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnAdminAssessment_ViewPaymentHistory.Location = new Point(23, 559);
            btnAdminAssessment_ViewPaymentHistory.Margin = new Padding(23, 4, 3, 4);
            btnAdminAssessment_ViewPaymentHistory.Name = "btnAdminAssessment_ViewPaymentHistory";
            btnAdminAssessment_ViewPaymentHistory.Size = new Size(421, 79);
            btnAdminAssessment_ViewPaymentHistory.TabIndex = 4;
            btnAdminAssessment_ViewPaymentHistory.Text = "ASSESSMENT";
            btnAdminAssessment_ViewPaymentHistory.UseVisualStyleBackColor = true;
            btnAdminAssessment_ViewPaymentHistory.Click += btnAdminAssessment_ViewPaymentHistory_Click;
            // 
            // btnStudentRegistration_ViewPaymentHistory_Admin
            // 
            btnStudentRegistration_ViewPaymentHistory_Admin.BackColor = Color.CadetBlue;
            btnStudentRegistration_ViewPaymentHistory_Admin.FlatStyle = FlatStyle.Flat;
            btnStudentRegistration_ViewPaymentHistory_Admin.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnStudentRegistration_ViewPaymentHistory_Admin.ForeColor = SystemColors.ControlText;
            btnStudentRegistration_ViewPaymentHistory_Admin.Location = new Point(23, 385);
            btnStudentRegistration_ViewPaymentHistory_Admin.Margin = new Padding(23, 4, 3, 4);
            btnStudentRegistration_ViewPaymentHistory_Admin.Name = "btnStudentRegistration_ViewPaymentHistory_Admin";
            btnStudentRegistration_ViewPaymentHistory_Admin.Size = new Size(421, 79);
            btnStudentRegistration_ViewPaymentHistory_Admin.TabIndex = 5;
            btnStudentRegistration_ViewPaymentHistory_Admin.Text = " STUDENT REGISTRATION";
            btnStudentRegistration_ViewPaymentHistory_Admin.UseVisualStyleBackColor = false;
            btnStudentRegistration_ViewPaymentHistory_Admin.Click += btnStudentRegistration_ViewPaymentHistory_Admin_Click;
            // 
            // btnPayment_ViewPaymentHistory_Admin
            // 
            btnPayment_ViewPaymentHistory_Admin.BackColor = Color.CadetBlue;
            btnPayment_ViewPaymentHistory_Admin.FlatStyle = FlatStyle.Flat;
            btnPayment_ViewPaymentHistory_Admin.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnPayment_ViewPaymentHistory_Admin.ForeColor = SystemColors.ControlText;
            btnPayment_ViewPaymentHistory_Admin.Location = new Point(23, 472);
            btnPayment_ViewPaymentHistory_Admin.Margin = new Padding(23, 4, 3, 4);
            btnPayment_ViewPaymentHistory_Admin.Name = "btnPayment_ViewPaymentHistory_Admin";
            btnPayment_ViewPaymentHistory_Admin.Size = new Size(421, 79);
            btnPayment_ViewPaymentHistory_Admin.TabIndex = 6;
            btnPayment_ViewPaymentHistory_Admin.Text = "PAYMENT";
            btnPayment_ViewPaymentHistory_Admin.UseVisualStyleBackColor = false;
            btnPayment_ViewPaymentHistory_Admin.Click += btnPayment_ViewPaymentHistory_Admin_Click;
            // 
            // btnPaymentHistory_ViewPaymentHistory_Admin
            // 
            btnPaymentHistory_ViewPaymentHistory_Admin.BackColor = Color.DarkSlateGray;
            btnPaymentHistory_ViewPaymentHistory_Admin.FlatStyle = FlatStyle.Flat;
            btnPaymentHistory_ViewPaymentHistory_Admin.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnPaymentHistory_ViewPaymentHistory_Admin.ForeColor = SystemColors.ControlLight;
            btnPaymentHistory_ViewPaymentHistory_Admin.Location = new Point(23, 646);
            btnPaymentHistory_ViewPaymentHistory_Admin.Margin = new Padding(23, 4, 3, 4);
            btnPaymentHistory_ViewPaymentHistory_Admin.Name = "btnPaymentHistory_ViewPaymentHistory_Admin";
            btnPaymentHistory_ViewPaymentHistory_Admin.Size = new Size(421, 79);
            btnPaymentHistory_ViewPaymentHistory_Admin.TabIndex = 7;
            btnPaymentHistory_ViewPaymentHistory_Admin.Text = "PAYMENT HISTORY";
            btnPaymentHistory_ViewPaymentHistory_Admin.UseVisualStyleBackColor = false;
            // 
            // btnReport_ViewPaymentHistory_Admin
            // 
            btnReport_ViewPaymentHistory_Admin.FlatStyle = FlatStyle.Flat;
            btnReport_ViewPaymentHistory_Admin.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnReport_ViewPaymentHistory_Admin.Location = new Point(23, 733);
            btnReport_ViewPaymentHistory_Admin.Margin = new Padding(23, 4, 3, 4);
            btnReport_ViewPaymentHistory_Admin.Name = "btnReport_ViewPaymentHistory_Admin";
            btnReport_ViewPaymentHistory_Admin.Size = new Size(421, 79);
            btnReport_ViewPaymentHistory_Admin.TabIndex = 8;
            btnReport_ViewPaymentHistory_Admin.Text = "REPORT";
            btnReport_ViewPaymentHistory_Admin.UseVisualStyleBackColor = true;
            btnReport_ViewPaymentHistory_Admin.Click += btnReport_ViewPaymentHistory_Admin_Click;
            // 
            // btnLogout_ViewPaymentHistory_Admin
            // 
            btnLogout_ViewPaymentHistory_Admin.FlatStyle = FlatStyle.Flat;
            btnLogout_ViewPaymentHistory_Admin.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnLogout_ViewPaymentHistory_Admin.Location = new Point(23, 820);
            btnLogout_ViewPaymentHistory_Admin.Margin = new Padding(23, 4, 3, 4);
            btnLogout_ViewPaymentHistory_Admin.Name = "btnLogout_ViewPaymentHistory_Admin";
            btnLogout_ViewPaymentHistory_Admin.Size = new Size(421, 79);
            btnLogout_ViewPaymentHistory_Admin.TabIndex = 9;
            btnLogout_ViewPaymentHistory_Admin.Text = "LOG OUT";
            btnLogout_ViewPaymentHistory_Admin.UseVisualStyleBackColor = true;
            btnLogout_ViewPaymentHistory_Admin.Click += btnLogout_ViewPaymentHistory_Admin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(611, 84);
            label1.Name = "label1";
            label1.Size = new Size(142, 32);
            label1.TabIndex = 237;
            label1.Text = "Student ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(611, 155);
            label2.Name = "label2";
            label2.Size = new Size(183, 32);
            label2.TabIndex = 238;
            label2.Text = "Student Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.Location = new Point(611, 225);
            label3.Name = "label3";
            label3.Size = new Size(230, 32);
            label3.TabIndex = 239;
            label3.Text = "Year Level/Section:";
            // 
            // lblStudentID_ViewPaymentHistory_Admin
            // 
            lblStudentID_ViewPaymentHistory_Admin.AutoSize = true;
            lblStudentID_ViewPaymentHistory_Admin.Font = new Font("Segoe UI", 14F);
            lblStudentID_ViewPaymentHistory_Admin.Location = new Point(871, 79);
            lblStudentID_ViewPaymentHistory_Admin.Name = "lblStudentID_ViewPaymentHistory_Admin";
            lblStudentID_ViewPaymentHistory_Admin.Size = new Size(191, 32);
            lblStudentID_ViewPaymentHistory_Admin.TabIndex = 240;
            lblStudentID_ViewPaymentHistory_Admin.Text = "<<Student ID>>";
            // 
            // lblStudentName_ViewPaymentHistory_Admin
            // 
            lblStudentName_ViewPaymentHistory_Admin.AutoSize = true;
            lblStudentName_ViewPaymentHistory_Admin.Font = new Font("Segoe UI", 14F);
            lblStudentName_ViewPaymentHistory_Admin.Location = new Point(871, 155);
            lblStudentName_ViewPaymentHistory_Admin.Name = "lblStudentName_ViewPaymentHistory_Admin";
            lblStudentName_ViewPaymentHistory_Admin.Size = new Size(232, 32);
            lblStudentName_ViewPaymentHistory_Admin.TabIndex = 241;
            lblStudentName_ViewPaymentHistory_Admin.Text = "<<Student Name>>";
            // 
            // lblYearLevelSection_ViewPaymentHistory_Admin
            // 
            lblYearLevelSection_ViewPaymentHistory_Admin.AutoSize = true;
            lblYearLevelSection_ViewPaymentHistory_Admin.Font = new Font("Segoe UI", 14F);
            lblYearLevelSection_ViewPaymentHistory_Admin.Location = new Point(871, 225);
            lblYearLevelSection_ViewPaymentHistory_Admin.Name = "lblYearLevelSection_ViewPaymentHistory_Admin";
            lblYearLevelSection_ViewPaymentHistory_Admin.Size = new Size(272, 32);
            lblYearLevelSection_ViewPaymentHistory_Admin.TabIndex = 242;
            lblYearLevelSection_ViewPaymentHistory_Admin.Text = "<<Year Level/Section>>";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label7.Location = new Point(1217, 70);
            label7.Name = "label7";
            label7.Size = new Size(74, 32);
            label7.TabIndex = 243;
            label7.Text = "Date:";
            // 
            // dtgCharges_AdminViewPaymentHistory
            // 
            dtgCharges_AdminViewPaymentHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgCharges_AdminViewPaymentHistory.Location = new Point(611, 405);
            dtgCharges_AdminViewPaymentHistory.Margin = new Padding(3, 4, 3, 4);
            dtgCharges_AdminViewPaymentHistory.Name = "dtgCharges_AdminViewPaymentHistory";
            dtgCharges_AdminViewPaymentHistory.RowHeadersWidth = 51;
            dtgCharges_AdminViewPaymentHistory.Size = new Size(1123, 214);
            dtgCharges_AdminViewPaymentHistory.TabIndex = 245;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label9.Location = new Point(611, 345);
            label9.Name = "label9";
            label9.Size = new Size(285, 32);
            label9.TabIndex = 246;
            label9.Text = "Chargers for 2025-2026";
            // 
            // dtgPayment_ViewPaymentHistory_Admin
            // 
            dtgPayment_ViewPaymentHistory_Admin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgPayment_ViewPaymentHistory_Admin.Location = new Point(611, 699);
            dtgPayment_ViewPaymentHistory_Admin.Margin = new Padding(3, 4, 3, 4);
            dtgPayment_ViewPaymentHistory_Admin.Name = "dtgPayment_ViewPaymentHistory_Admin";
            dtgPayment_ViewPaymentHistory_Admin.RowHeadersWidth = 51;
            dtgPayment_ViewPaymentHistory_Admin.Size = new Size(1123, 200);
            dtgPayment_ViewPaymentHistory_Admin.TabIndex = 247;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label10.Location = new Point(611, 646);
            label10.Name = "label10";
            label10.Size = new Size(283, 32);
            label10.TabIndex = 248;
            label10.Text = "Payment for 2025-2026";
            // 
            // btnBack_ViewPaymentHistory_Admin
            // 
            btnBack_ViewPaymentHistory_Admin.BackColor = Color.CadetBlue;
            btnBack_ViewPaymentHistory_Admin.Font = new Font("Segoe UI", 14F);
            btnBack_ViewPaymentHistory_Admin.ForeColor = Color.AliceBlue;
            btnBack_ViewPaymentHistory_Admin.Location = new Point(1137, 953);
            btnBack_ViewPaymentHistory_Admin.Name = "btnBack_ViewPaymentHistory_Admin";
            btnBack_ViewPaymentHistory_Admin.Size = new Size(154, 54);
            btnBack_ViewPaymentHistory_Admin.TabIndex = 249;
            btnBack_ViewPaymentHistory_Admin.Text = "Back";
            btnBack_ViewPaymentHistory_Admin.UseVisualStyleBackColor = false;
            btnBack_ViewPaymentHistory_Admin.Click += btnBack_ViewPaymentHistory_Admin_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 14F);
            dateTimePicker1.Location = new Point(1337, 70);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(372, 39);
            dateTimePicker1.TabIndex = 250;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.Location = new Point(1218, 155);
            label4.Name = "label4";
            label4.Size = new Size(170, 32);
            label4.TabIndex = 251;
            label4.Text = "Student Type:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label5.Location = new Point(1218, 225);
            label5.Name = "label5";
            label5.Size = new Size(223, 32);
            label5.TabIndex = 252;
            label5.Text = "Enrollment Status:";
            // 
            // lbStudentType_History
            // 
            lbStudentType_History.AutoSize = true;
            lbStudentType_History.Font = new Font("Segoe UI", 14F);
            lbStudentType_History.Location = new Point(1484, 155);
            lbStudentType_History.Name = "lbStudentType_History";
            lbStudentType_History.Size = new Size(129, 32);
            lbStudentType_History.TabIndex = 253;
            lbStudentType_History.Text = "<<Type>>";
            // 
            // lbStatusHistory
            // 
            lbStatusHistory.AutoSize = true;
            lbStatusHistory.Font = new Font("Segoe UI", 14F);
            lbStatusHistory.Location = new Point(1484, 225);
            lbStatusHistory.Name = "lbStatusHistory";
            lbStatusHistory.Size = new Size(142, 32);
            lbStatusHistory.TabIndex = 254;
            lbStatusHistory.Text = "<<Status>>";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label6.Location = new Point(1223, 333);
            label6.Name = "label6";
            label6.Size = new Size(227, 32);
            label6.TabIndex = 255;
            label6.Text = "Mode Of Payment:";
            // 
            // lbModeHistory
            // 
            lbModeHistory.AutoSize = true;
            lbModeHistory.Font = new Font("Segoe UI", 14F);
            lbModeHistory.Location = new Point(1506, 333);
            lbModeHistory.Name = "lbModeHistory";
            lbModeHistory.Size = new Size(141, 32);
            lbModeHistory.TabIndex = 256;
            lbModeHistory.Text = "<<Mode>>";
            // 
            // AdminViewPaymentHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1902, 1033);
            Controls.Add(lbModeHistory);
            Controls.Add(label6);
            Controls.Add(lbStatusHistory);
            Controls.Add(lbStudentType_History);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnBack_ViewPaymentHistory_Admin);
            Controls.Add(label10);
            Controls.Add(dtgPayment_ViewPaymentHistory_Admin);
            Controls.Add(label9);
            Controls.Add(dtgCharges_AdminViewPaymentHistory);
            Controls.Add(label7);
            Controls.Add(lblYearLevelSection_ViewPaymentHistory_Admin);
            Controls.Add(lblStudentName_ViewPaymentHistory_Admin);
            Controls.Add(lblStudentID_ViewPaymentHistory_Admin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AdminViewPaymentHistory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminViewPaymentHistory";
            Load += AdminViewPaymentHistory_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcAdminViewPaymentHistory).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgCharges_AdminViewPaymentHistory).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgPayment_ViewPaymentHistory_Admin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private PictureBox pcAdminViewPaymentHistory;
        private Button btnAdminStuedntInfo_ViewPaymentHistory;
        private Button btnAdminAssessment_ViewPaymentHistory;
        private Button btnStudentRegistration_ViewPaymentHistory_Admin;
        private Button btnPayment_ViewPaymentHistory_Admin;
        private Button btnPaymentHistory_ViewPaymentHistory_Admin;
        private Button btnReport_ViewPaymentHistory_Admin;
        private Button btnLogout_ViewPaymentHistory_Admin;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblStudentID_ViewPaymentHistory_Admin;
        private Label lblStudentName_ViewPaymentHistory_Admin;
        private Label lblYearLevelSection_ViewPaymentHistory_Admin;
        private Label label7;
        private DataGridView dtgCharges_AdminViewPaymentHistory;
        private Label label9;
        private DataGridView dtgPayment_ViewPaymentHistory_Admin;
        private Label label10;
        private Button btnBack_ViewPaymentHistory_Admin;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label5;
        private Label lbStudentType_History;
        private Label lbStatusHistory;
        private Label label6;
        private Label lbModeHistory;
    }
}