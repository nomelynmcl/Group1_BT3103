namespace EventDriven.Project.UI
{
    partial class Cashier_ViewPaymentHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cashier_ViewPaymentHistory));
            dtgCharges_ViewPaymentHistory_Cashier = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            pcCashier_ViewPaymentHistory_ = new PictureBox();
            btnPayment_ViewPaymentHistory_Cashier = new Button();
            btnPaymentHistory_ViewPaymentHistory_Cashier = new Button();
            btnReport_ViewPaymentHistory_Cashier = new Button();
            btnLogout_ViewPaymentHistory_Cashier = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblStudentID_ViewPaymentHistory_Cashier = new Label();
            lblStudentName_ViewPaymentHistory_Cashier = new Label();
            lblYearLevelSection_ViewPaymentHistory_Cashier = new Label();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            dtgPayment_ViewPaymentHistory_Cashier = new DataGridView();
            btnBack_ViewPaymentHistory_Cashier = new Button();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            lbtypeHistory = new Label();
            lbStatusHistory = new Label();
            label6 = new Label();
            lbModeHistory = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgCharges_ViewPaymentHistory_Cashier).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcCashier_ViewPaymentHistory_).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgPayment_ViewPaymentHistory_Cashier).BeginInit();
            SuspendLayout();
            // 
            // dtgCharges_ViewPaymentHistory_Cashier
            // 
            dtgCharges_ViewPaymentHistory_Cashier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgCharges_ViewPaymentHistory_Cashier.Location = new Point(304, 148);
            dtgCharges_ViewPaymentHistory_Cashier.Name = "dtgCharges_ViewPaymentHistory_Cashier";
            dtgCharges_ViewPaymentHistory_Cashier.RowHeadersWidth = 51;
            dtgCharges_ViewPaymentHistory_Cashier.Size = new Size(704, 103);
            dtgCharges_ViewPaymentHistory_Cashier.TabIndex = 105;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.CadetBlue;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(btnPayment_ViewPaymentHistory_Cashier);
            flowLayoutPanel1.Controls.Add(btnPaymentHistory_ViewPaymentHistory_Cashier);
            flowLayoutPanel1.Controls.Add(btnReport_ViewPaymentHistory_Cashier);
            flowLayoutPanel1.Controls.Add(btnLogout_ViewPaymentHistory_Cashier);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(251, 522);
            flowLayoutPanel1.TabIndex = 104;
            // 
            // panel1
            // 
            panel1.Controls.Add(pcCashier_ViewPaymentHistory_);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(248, 140);
            panel1.TabIndex = 0;
            // 
            // pcCashier_ViewPaymentHistory_
            // 
            pcCashier_ViewPaymentHistory_.BackColor = Color.CadetBlue;
            pcCashier_ViewPaymentHistory_.Image = (Image)resources.GetObject("pcCashier_ViewPaymentHistory_.Image");
            pcCashier_ViewPaymentHistory_.Location = new Point(44, 14);
            pcCashier_ViewPaymentHistory_.Name = "pcCashier_ViewPaymentHistory_";
            pcCashier_ViewPaymentHistory_.Size = new Size(154, 126);
            pcCashier_ViewPaymentHistory_.SizeMode = PictureBoxSizeMode.StretchImage;
            pcCashier_ViewPaymentHistory_.TabIndex = 0;
            pcCashier_ViewPaymentHistory_.TabStop = false;
            pcCashier_ViewPaymentHistory_.Click += pcCashier_ViewPaymentHistory__Click;
            // 
            // btnPayment_ViewPaymentHistory_Cashier
            // 
            btnPayment_ViewPaymentHistory_Cashier.BackColor = Color.CadetBlue;
            btnPayment_ViewPaymentHistory_Cashier.FlatStyle = FlatStyle.Flat;
            btnPayment_ViewPaymentHistory_Cashier.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPayment_ViewPaymentHistory_Cashier.ForeColor = SystemColors.ControlText;
            btnPayment_ViewPaymentHistory_Cashier.Location = new Point(20, 156);
            btnPayment_ViewPaymentHistory_Cashier.Margin = new Padding(20, 10, 3, 3);
            btnPayment_ViewPaymentHistory_Cashier.Name = "btnPayment_ViewPaymentHistory_Cashier";
            btnPayment_ViewPaymentHistory_Cashier.Size = new Size(211, 42);
            btnPayment_ViewPaymentHistory_Cashier.TabIndex = 3;
            btnPayment_ViewPaymentHistory_Cashier.Text = "PAYMENT ";
            btnPayment_ViewPaymentHistory_Cashier.UseVisualStyleBackColor = false;
            btnPayment_ViewPaymentHistory_Cashier.Click += btnPayment_ViewPaymentHistory_Cashier_Click;
            // 
            // btnPaymentHistory_ViewPaymentHistory_Cashier
            // 
            btnPaymentHistory_ViewPaymentHistory_Cashier.BackColor = Color.DarkSlateGray;
            btnPaymentHistory_ViewPaymentHistory_Cashier.FlatStyle = FlatStyle.Flat;
            btnPaymentHistory_ViewPaymentHistory_Cashier.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPaymentHistory_ViewPaymentHistory_Cashier.ForeColor = SystemColors.ControlLight;
            btnPaymentHistory_ViewPaymentHistory_Cashier.Location = new Point(20, 204);
            btnPaymentHistory_ViewPaymentHistory_Cashier.Margin = new Padding(20, 3, 3, 3);
            btnPaymentHistory_ViewPaymentHistory_Cashier.Name = "btnPaymentHistory_ViewPaymentHistory_Cashier";
            btnPaymentHistory_ViewPaymentHistory_Cashier.Size = new Size(211, 42);
            btnPaymentHistory_ViewPaymentHistory_Cashier.TabIndex = 4;
            btnPaymentHistory_ViewPaymentHistory_Cashier.Text = "PAYMENT HISTORY";
            btnPaymentHistory_ViewPaymentHistory_Cashier.UseVisualStyleBackColor = false;
            // 
            // btnReport_ViewPaymentHistory_Cashier
            // 
            btnReport_ViewPaymentHistory_Cashier.BackColor = Color.CadetBlue;
            btnReport_ViewPaymentHistory_Cashier.FlatStyle = FlatStyle.Flat;
            btnReport_ViewPaymentHistory_Cashier.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReport_ViewPaymentHistory_Cashier.ForeColor = SystemColors.ControlText;
            btnReport_ViewPaymentHistory_Cashier.Location = new Point(20, 252);
            btnReport_ViewPaymentHistory_Cashier.Margin = new Padding(20, 3, 3, 3);
            btnReport_ViewPaymentHistory_Cashier.Name = "btnReport_ViewPaymentHistory_Cashier";
            btnReport_ViewPaymentHistory_Cashier.Size = new Size(211, 42);
            btnReport_ViewPaymentHistory_Cashier.TabIndex = 5;
            btnReport_ViewPaymentHistory_Cashier.Text = "REPORT";
            btnReport_ViewPaymentHistory_Cashier.UseVisualStyleBackColor = false;
            // 
            // btnLogout_ViewPaymentHistory_Cashier
            // 
            btnLogout_ViewPaymentHistory_Cashier.FlatStyle = FlatStyle.Flat;
            btnLogout_ViewPaymentHistory_Cashier.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout_ViewPaymentHistory_Cashier.Location = new Point(20, 300);
            btnLogout_ViewPaymentHistory_Cashier.Margin = new Padding(20, 3, 3, 3);
            btnLogout_ViewPaymentHistory_Cashier.Name = "btnLogout_ViewPaymentHistory_Cashier";
            btnLogout_ViewPaymentHistory_Cashier.Size = new Size(211, 42);
            btnLogout_ViewPaymentHistory_Cashier.TabIndex = 9;
            btnLogout_ViewPaymentHistory_Cashier.Text = "LOG OUT";
            btnLogout_ViewPaymentHistory_Cashier.UseVisualStyleBackColor = true;
            btnLogout_ViewPaymentHistory_Cashier.Click += btnLogout_ViewPaymentHistory_Cashier_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(304, 18);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 108;
            label1.Text = "Student ID: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(304, 47);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 109;
            label2.Text = "Student Name: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(304, 74);
            label3.Name = "label3";
            label3.Size = new Size(117, 15);
            label3.TabIndex = 110;
            label3.Text = "Year Level/Section: ";
            // 
            // lblStudentID_ViewPaymentHistory_Cashier
            // 
            lblStudentID_ViewPaymentHistory_Cashier.AutoSize = true;
            lblStudentID_ViewPaymentHistory_Cashier.Location = new Point(390, 18);
            lblStudentID_ViewPaymentHistory_Cashier.Name = "lblStudentID_ViewPaymentHistory_Cashier";
            lblStudentID_ViewPaymentHistory_Cashier.Size = new Size(94, 15);
            lblStudentID_ViewPaymentHistory_Cashier.TabIndex = 111;
            lblStudentID_ViewPaymentHistory_Cashier.Text = "<<Student ID>>";
            // 
            // lblStudentName_ViewPaymentHistory_Cashier
            // 
            lblStudentName_ViewPaymentHistory_Cashier.AutoSize = true;
            lblStudentName_ViewPaymentHistory_Cashier.Location = new Point(413, 47);
            lblStudentName_ViewPaymentHistory_Cashier.Name = "lblStudentName_ViewPaymentHistory_Cashier";
            lblStudentName_ViewPaymentHistory_Cashier.Size = new Size(115, 15);
            lblStudentName_ViewPaymentHistory_Cashier.TabIndex = 112;
            lblStudentName_ViewPaymentHistory_Cashier.Text = "<<Student Name>>";
            // 
            // lblYearLevelSection_ViewPaymentHistory_Cashier
            // 
            lblYearLevelSection_ViewPaymentHistory_Cashier.AutoSize = true;
            lblYearLevelSection_ViewPaymentHistory_Cashier.Location = new Point(437, 74);
            lblYearLevelSection_ViewPaymentHistory_Cashier.Name = "lblYearLevelSection_ViewPaymentHistory_Cashier";
            lblYearLevelSection_ViewPaymentHistory_Cashier.Size = new Size(135, 15);
            lblYearLevelSection_ViewPaymentHistory_Cashier.TabIndex = 113;
            lblYearLevelSection_ViewPaymentHistory_Cashier.Text = "<<Year Level/Section>>";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(775, 18);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 114;
            label7.Text = "Date: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(304, 126);
            label9.Name = "label9";
            label9.Size = new Size(143, 15);
            label9.TabIndex = 116;
            label9.Text = "Chargers for 2025-2026 ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(304, 272);
            label10.Name = "label10";
            label10.Size = new Size(140, 15);
            label10.TabIndex = 117;
            label10.Text = "Payment for 2025-2026";
            // 
            // dtgPayment_ViewPaymentHistory_Cashier
            // 
            dtgPayment_ViewPaymentHistory_Cashier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgPayment_ViewPaymentHistory_Cashier.Location = new Point(304, 300);
            dtgPayment_ViewPaymentHistory_Cashier.Name = "dtgPayment_ViewPaymentHistory_Cashier";
            dtgPayment_ViewPaymentHistory_Cashier.RowHeadersWidth = 51;
            dtgPayment_ViewPaymentHistory_Cashier.Size = new Size(704, 130);
            dtgPayment_ViewPaymentHistory_Cashier.TabIndex = 118;
            // 
            // btnBack_ViewPaymentHistory_Cashier
            // 
            btnBack_ViewPaymentHistory_Cashier.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack_ViewPaymentHistory_Cashier.Location = new Point(598, 470);
            btnBack_ViewPaymentHistory_Cashier.Margin = new Padding(3, 2, 3, 2);
            btnBack_ViewPaymentHistory_Cashier.Name = "btnBack_ViewPaymentHistory_Cashier";
            btnBack_ViewPaymentHistory_Cashier.Size = new Size(92, 28);
            btnBack_ViewPaymentHistory_Cashier.TabIndex = 119;
            btnBack_ViewPaymentHistory_Cashier.Text = "Back";
            btnBack_ViewPaymentHistory_Cashier.UseVisualStyleBackColor = true;
            btnBack_ViewPaymentHistory_Cashier.Click += btnBack_ViewPaymentHistory_Cashier_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(821, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 120;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(775, 47);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 121;
            label4.Text = "Student Type: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(775, 74);
            label5.Name = "label5";
            label5.Size = new Size(109, 15);
            label5.TabIndex = 122;
            label5.Text = "Enrollment Status:";
            // 
            // lbtypeHistory
            // 
            lbtypeHistory.AutoSize = true;
            lbtypeHistory.Location = new Point(868, 47);
            lbtypeHistory.Name = "lbtypeHistory";
            lbtypeHistory.Size = new Size(64, 15);
            lbtypeHistory.TabIndex = 123;
            lbtypeHistory.Text = "<<Type>>";
            // 
            // lbStatusHistory
            // 
            lbStatusHistory.AutoSize = true;
            lbStatusHistory.Location = new Point(899, 74);
            lbStatusHistory.Name = "lbStatusHistory";
            lbStatusHistory.Size = new Size(71, 15);
            lbStatusHistory.TabIndex = 124;
            lbStatusHistory.Text = "<<Status>>";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(728, 126);
            label6.Name = "label6";
            label6.Size = new Size(109, 15);
            label6.TabIndex = 125;
            label6.Text = "Enrollment Status:";
            // 
            // lbModeHistory
            // 
            lbModeHistory.AutoSize = true;
            lbModeHistory.Location = new Point(843, 126);
            lbModeHistory.Name = "lbModeHistory";
            lbModeHistory.Size = new Size(70, 15);
            lbModeHistory.TabIndex = 126;
            lbModeHistory.Text = "<<Mode>>";
            // 
            // Cashier_ViewPaymentHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1058, 522);
            Controls.Add(lbModeHistory);
            Controls.Add(label6);
            Controls.Add(lbStatusHistory);
            Controls.Add(lbtypeHistory);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dateTimePicker1);
            Controls.Add(btnBack_ViewPaymentHistory_Cashier);
            Controls.Add(dtgPayment_ViewPaymentHistory_Cashier);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(lblYearLevelSection_ViewPaymentHistory_Cashier);
            Controls.Add(lblStudentName_ViewPaymentHistory_Cashier);
            Controls.Add(lblStudentID_ViewPaymentHistory_Cashier);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtgCharges_ViewPaymentHistory_Cashier);
            Controls.Add(flowLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Cashier_ViewPaymentHistory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cashier_ViewPaymentHistory";
            ((System.ComponentModel.ISupportInitialize)dtgCharges_ViewPaymentHistory_Cashier).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcCashier_ViewPaymentHistory_).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgPayment_ViewPaymentHistory_Cashier).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dtgCharges_ViewPaymentHistory_Cashier;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private PictureBox pcCashier_ViewPaymentHistory_;
        private Button btnPayment_ViewPaymentHistory_Cashier;
        private Button btnPaymentHistory_ViewPaymentHistory_Cashier;
        private Button btnReport_ViewPaymentHistory_Cashier;
        private Button btnLogout_ViewPaymentHistory_Cashier;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblStudentID_ViewPaymentHistory_Cashier;
        private Label lblStudentName_ViewPaymentHistory_Cashier;
        private Label lblYearLevelSection_ViewPaymentHistory_Cashier;
        private Label label7;
        private Label label9;
        private Label label10;
        private DataGridView dtgPayment_ViewPaymentHistory_Cashier;
        private Button btnBack_ViewPaymentHistory_Cashier;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label5;
        private Label lbtypeHistory;
        private Label lbStatusHistory;
        private Label label6;
        private Label lbModeHistory;
    }
}