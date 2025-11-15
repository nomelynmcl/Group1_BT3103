namespace EventDriven.Project.UI
{
    partial class AdminPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPayment));
            AdminView_BTN = new Button();
            AdminCancel_BTN = new Button();
            AdminCompute_BTN = new Button();
            label9 = new Label();
            label5 = new Label();
            AdminPayment_GridView = new DataGridView();
            label1 = new Label();
            AdminConfirmPayment = new Button();
            AdminChange_LBL = new Label();
            label19 = new Label();
            AdminYLSection_LBL = new Label();
            label7 = new Label();
            label8 = new Label();
            AdminStuName_LBL = new Label();
            AdminStuID_LBL = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            pcAdminLogo2 = new PictureBox();
            btnAdminStudentInformation2 = new Button();
            btnAdminAssessment2 = new Button();
            btnAdminStudreg2 = new Button();
            btnAdminPay2 = new Button();
            btnAdminHistory2 = new Button();
            btnAdminReport2 = new Button();
            btnAdminOut2 = new Button();
            AdminPayment_SearchBTN = new Button();
            AdminPayment_TXTBOX = new TextBox();
            dtCurrDate = new DateTimePicker();
            clbModeOfPayment_AdminPay = new CheckedListBox();
            txtAdminPayment = new TextBox();
            label6 = new Label();
            lbAdminPay_Remaining = new Label();
            ((System.ComponentModel.ISupportInitialize)AdminPayment_GridView).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcAdminLogo2).BeginInit();
            SuspendLayout();
            // 
            // AdminView_BTN
            // 
            AdminView_BTN.Location = new Point(655, 461);
            AdminView_BTN.Name = "AdminView_BTN";
            AdminView_BTN.Size = new Size(110, 37);
            AdminView_BTN.TabIndex = 147;
            AdminView_BTN.Text = "View Reciept";
            AdminView_BTN.UseVisualStyleBackColor = true;
            AdminView_BTN.Click += AdminView_BTN_Click;
            // 
            // AdminCancel_BTN
            // 
            AdminCancel_BTN.Location = new Point(527, 461);
            AdminCancel_BTN.Name = "AdminCancel_BTN";
            AdminCancel_BTN.Size = new Size(110, 37);
            AdminCancel_BTN.TabIndex = 146;
            AdminCancel_BTN.Text = "Cancel";
            AdminCancel_BTN.UseVisualStyleBackColor = true;
            AdminCancel_BTN.Click += AdminCancel_BTN_Click;
            // 
            // AdminCompute_BTN
            // 
            AdminCompute_BTN.Location = new Point(270, 461);
            AdminCompute_BTN.Name = "AdminCompute_BTN";
            AdminCompute_BTN.Size = new Size(110, 37);
            AdminCompute_BTN.TabIndex = 145;
            AdminCompute_BTN.Text = "Compute";
            AdminCompute_BTN.UseVisualStyleBackColor = true;
            AdminCompute_BTN.Click += AdminCompute_BTN_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(270, 423);
            label9.Name = "label9";
            label9.Size = new Size(59, 15);
            label9.TabIndex = 143;
            label9.Text = "Payment:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(270, 385);
            label5.Name = "label5";
            label5.Size = new Size(122, 15);
            label5.TabIndex = 142;
            label5.Text = "Payment Transaction";
            // 
            // AdminPayment_GridView
            // 
            AdminPayment_GridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AdminPayment_GridView.Location = new Point(279, 170);
            AdminPayment_GridView.Name = "AdminPayment_GridView";
            AdminPayment_GridView.Size = new Size(289, 178);
            AdminPayment_GridView.TabIndex = 141;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(279, 154);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 140;
            label1.Text = "Payment Details";
            // 
            // AdminConfirmPayment
            // 
            AdminConfirmPayment.Location = new Point(399, 461);
            AdminConfirmPayment.Name = "AdminConfirmPayment";
            AdminConfirmPayment.Size = new Size(110, 37);
            AdminConfirmPayment.TabIndex = 139;
            AdminConfirmPayment.Text = "Confirm Payment";
            AdminConfirmPayment.UseVisualStyleBackColor = true;
            AdminConfirmPayment.Click += AdminConfirmPayment_Click;
            // 
            // AdminChange_LBL
            // 
            AdminChange_LBL.AutoSize = true;
            AdminChange_LBL.Location = new Point(558, 422);
            AdminChange_LBL.Name = "AdminChange_LBL";
            AdminChange_LBL.Size = new Size(28, 15);
            AdminChange_LBL.TabIndex = 138;
            AdminChange_LBL.Text = "0.00";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(489, 422);
            label19.Name = "label19";
            label19.Size = new Size(51, 15);
            label19.TabIndex = 137;
            label19.Text = "Change:";
            // 
            // AdminYLSection_LBL
            // 
            AdminYLSection_LBL.AutoSize = true;
            AdminYLSection_LBL.Location = new Point(391, 109);
            AdminYLSection_LBL.Name = "AdminYLSection_LBL";
            AdminYLSection_LBL.Size = new Size(133, 15);
            AdminYLSection_LBL.TabIndex = 136;
            AdminYLSection_LBL.Text = "<<Year Level Section>>";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(279, 109);
            label7.Name = "label7";
            label7.Size = new Size(114, 15);
            label7.TabIndex = 134;
            label7.Text = "Year Level/Section:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(574, 51);
            label8.Name = "label8";
            label8.Size = new Size(37, 15);
            label8.TabIndex = 133;
            label8.Text = "Date:";
            // 
            // AdminStuName_LBL
            // 
            AdminStuName_LBL.AutoSize = true;
            AdminStuName_LBL.Location = new Point(374, 81);
            AdminStuName_LBL.Name = "AdminStuName_LBL";
            AdminStuName_LBL.Size = new Size(115, 15);
            AdminStuName_LBL.TabIndex = 132;
            AdminStuName_LBL.Text = "<<Student Name>>";
            // 
            // AdminStuID_LBL
            // 
            AdminStuID_LBL.AutoSize = true;
            AdminStuID_LBL.Location = new Point(345, 51);
            AdminStuID_LBL.Name = "AdminStuID_LBL";
            AdminStuID_LBL.Size = new Size(94, 15);
            AdminStuID_LBL.TabIndex = 131;
            AdminStuID_LBL.Text = "<<Student ID>>";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(599, 154);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 127;
            label4.Text = "Payment Method";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(279, 81);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 126;
            label3.Text = "Student Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(279, 51);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 125;
            label2.Text = "Student ID:";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.CadetBlue;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(btnAdminStudentInformation2);
            flowLayoutPanel1.Controls.Add(btnAdminAssessment2);
            flowLayoutPanel1.Controls.Add(btnAdminStudreg2);
            flowLayoutPanel1.Controls.Add(btnAdminPay2);
            flowLayoutPanel1.Controls.Add(btnAdminHistory2);
            flowLayoutPanel1.Controls.Add(btnAdminReport2);
            flowLayoutPanel1.Controls.Add(btnAdminOut2);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(251, 522);
            flowLayoutPanel1.TabIndex = 124;
            // 
            // panel1
            // 
            panel1.Controls.Add(pcAdminLogo2);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(248, 140);
            panel1.TabIndex = 0;
            // 
            // pcAdminLogo2
            // 
            pcAdminLogo2.BackColor = Color.CadetBlue;
            pcAdminLogo2.Image = (Image)resources.GetObject("pcAdminLogo2.Image");
            pcAdminLogo2.Location = new Point(44, 14);
            pcAdminLogo2.Name = "pcAdminLogo2";
            pcAdminLogo2.Size = new Size(154, 126);
            pcAdminLogo2.SizeMode = PictureBoxSizeMode.StretchImage;
            pcAdminLogo2.TabIndex = 0;
            pcAdminLogo2.TabStop = false;
            pcAdminLogo2.Click += pcAdminLogo2_Click;
            // 
            // btnAdminStudentInformation2
            // 
            btnAdminStudentInformation2.BackColor = Color.CadetBlue;
            btnAdminStudentInformation2.FlatStyle = FlatStyle.Flat;
            btnAdminStudentInformation2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminStudentInformation2.ForeColor = SystemColors.ActiveCaptionText;
            btnAdminStudentInformation2.Location = new Point(20, 156);
            btnAdminStudentInformation2.Margin = new Padding(20, 10, 3, 3);
            btnAdminStudentInformation2.Name = "btnAdminStudentInformation2";
            btnAdminStudentInformation2.Size = new Size(211, 42);
            btnAdminStudentInformation2.TabIndex = 3;
            btnAdminStudentInformation2.Text = " STUDENT INFORMATION";
            btnAdminStudentInformation2.UseVisualStyleBackColor = false;
            btnAdminStudentInformation2.Click += btnAdminStudentInformation2_Click;
            // 
            // btnAdminAssessment2
            // 
            btnAdminAssessment2.BackColor = Color.CadetBlue;
            btnAdminAssessment2.FlatStyle = FlatStyle.Flat;
            btnAdminAssessment2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminAssessment2.ForeColor = SystemColors.ActiveCaptionText;
            btnAdminAssessment2.Location = new Point(20, 204);
            btnAdminAssessment2.Margin = new Padding(20, 3, 3, 3);
            btnAdminAssessment2.Name = "btnAdminAssessment2";
            btnAdminAssessment2.Size = new Size(211, 42);
            btnAdminAssessment2.TabIndex = 4;
            btnAdminAssessment2.Text = "ASSESSMENT";
            btnAdminAssessment2.UseVisualStyleBackColor = false;
            btnAdminAssessment2.Click += btnAdminAssessment2_Click;
            // 
            // btnAdminStudreg2
            // 
            btnAdminStudreg2.FlatStyle = FlatStyle.Flat;
            btnAdminStudreg2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminStudreg2.Location = new Point(20, 252);
            btnAdminStudreg2.Margin = new Padding(20, 3, 3, 3);
            btnAdminStudreg2.Name = "btnAdminStudreg2";
            btnAdminStudreg2.Size = new Size(211, 42);
            btnAdminStudreg2.TabIndex = 5;
            btnAdminStudreg2.Text = " STUDENT REGISTRATION";
            btnAdminStudreg2.UseVisualStyleBackColor = true;
            btnAdminStudreg2.Click += btnAdminStudreg2_Click;
            // 
            // btnAdminPay2
            // 
            btnAdminPay2.BackColor = Color.DarkSlateGray;
            btnAdminPay2.FlatStyle = FlatStyle.Flat;
            btnAdminPay2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminPay2.ForeColor = SystemColors.Control;
            btnAdminPay2.Location = new Point(20, 300);
            btnAdminPay2.Margin = new Padding(20, 3, 3, 3);
            btnAdminPay2.Name = "btnAdminPay2";
            btnAdminPay2.Size = new Size(211, 42);
            btnAdminPay2.TabIndex = 6;
            btnAdminPay2.Text = "PAYMENT";
            btnAdminPay2.UseVisualStyleBackColor = false;
            // 
            // btnAdminHistory2
            // 
            btnAdminHistory2.FlatStyle = FlatStyle.Flat;
            btnAdminHistory2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminHistory2.Location = new Point(20, 348);
            btnAdminHistory2.Margin = new Padding(20, 3, 3, 3);
            btnAdminHistory2.Name = "btnAdminHistory2";
            btnAdminHistory2.Size = new Size(211, 42);
            btnAdminHistory2.TabIndex = 7;
            btnAdminHistory2.Text = "PAYMENT HISTORY";
            btnAdminHistory2.UseVisualStyleBackColor = true;
            btnAdminHistory2.Click += btnAdminHistory2_Click;
            // 
            // btnAdminReport2
            // 
            btnAdminReport2.FlatStyle = FlatStyle.Flat;
            btnAdminReport2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminReport2.Location = new Point(20, 396);
            btnAdminReport2.Margin = new Padding(20, 3, 3, 3);
            btnAdminReport2.Name = "btnAdminReport2";
            btnAdminReport2.Size = new Size(211, 42);
            btnAdminReport2.TabIndex = 8;
            btnAdminReport2.Text = "REPORT";
            btnAdminReport2.UseVisualStyleBackColor = true;
            btnAdminReport2.Click += btnAdminReport2_Click;
            // 
            // btnAdminOut2
            // 
            btnAdminOut2.FlatStyle = FlatStyle.Flat;
            btnAdminOut2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminOut2.Location = new Point(20, 444);
            btnAdminOut2.Margin = new Padding(20, 3, 3, 3);
            btnAdminOut2.Name = "btnAdminOut2";
            btnAdminOut2.Size = new Size(211, 42);
            btnAdminOut2.TabIndex = 9;
            btnAdminOut2.Text = "LOG OUT";
            btnAdminOut2.UseVisualStyleBackColor = true;
            btnAdminOut2.Click += btnAdminOut2_Click;
            // 
            // AdminPayment_SearchBTN
            // 
            AdminPayment_SearchBTN.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AdminPayment_SearchBTN.Location = new Point(279, 12);
            AdminPayment_SearchBTN.Name = "AdminPayment_SearchBTN";
            AdminPayment_SearchBTN.Size = new Size(118, 23);
            AdminPayment_SearchBTN.TabIndex = 148;
            AdminPayment_SearchBTN.Text = "Search Student";
            AdminPayment_SearchBTN.UseVisualStyleBackColor = true;
            AdminPayment_SearchBTN.Click += AdminPayment_SearchBTN_Click;
            // 
            // AdminPayment_TXTBOX
            // 
            AdminPayment_TXTBOX.Location = new Point(403, 12);
            AdminPayment_TXTBOX.Name = "AdminPayment_TXTBOX";
            AdminPayment_TXTBOX.Size = new Size(208, 23);
            AdminPayment_TXTBOX.TabIndex = 149;
            // 
            // dtCurrDate
            // 
            dtCurrDate.Location = new Point(617, 45);
            dtCurrDate.Name = "dtCurrDate";
            dtCurrDate.Size = new Size(151, 23);
            dtCurrDate.TabIndex = 150;
            // 
            // clbModeOfPayment_AdminPay
            // 
            clbModeOfPayment_AdminPay.FormattingEnabled = true;
            clbModeOfPayment_AdminPay.Items.AddRange(new object[] { "Low Down Payment", "Low Quarterly Payment", "Cash" });
            clbModeOfPayment_AdminPay.Location = new Point(599, 171);
            clbModeOfPayment_AdminPay.Margin = new Padding(3, 2, 3, 2);
            clbModeOfPayment_AdminPay.Name = "clbModeOfPayment_AdminPay";
            clbModeOfPayment_AdminPay.Size = new Size(157, 58);
            clbModeOfPayment_AdminPay.TabIndex = 204;
            clbModeOfPayment_AdminPay.SelectedIndexChanged += clbModeOfPayment_AdminPay_SelectedIndexChanged;
            // 
            // txtAdminPayment
            // 
            txtAdminPayment.Location = new Point(335, 419);
            txtAdminPayment.Name = "txtAdminPayment";
            txtAdminPayment.Size = new Size(130, 23);
            txtAdminPayment.TabIndex = 205;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(617, 422);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 206;
            label6.Text = "Remaining:";
            // 
            // lbAdminPay_Remaining
            // 
            lbAdminPay_Remaining.AutoSize = true;
            lbAdminPay_Remaining.Location = new Point(704, 422);
            lbAdminPay_Remaining.Name = "lbAdminPay_Remaining";
            lbAdminPay_Remaining.Size = new Size(28, 15);
            lbAdminPay_Remaining.TabIndex = 207;
            lbAdminPay_Remaining.Text = "0.00";
            // 
            // AdminPayment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(780, 522);
            Controls.Add(lbAdminPay_Remaining);
            Controls.Add(label6);
            Controls.Add(txtAdminPayment);
            Controls.Add(clbModeOfPayment_AdminPay);
            Controls.Add(dtCurrDate);
            Controls.Add(AdminPayment_TXTBOX);
            Controls.Add(AdminPayment_SearchBTN);
            Controls.Add(AdminView_BTN);
            Controls.Add(AdminCancel_BTN);
            Controls.Add(AdminCompute_BTN);
            Controls.Add(label9);
            Controls.Add(label5);
            Controls.Add(AdminPayment_GridView);
            Controls.Add(label1);
            Controls.Add(AdminConfirmPayment);
            Controls.Add(AdminChange_LBL);
            Controls.Add(label19);
            Controls.Add(AdminYLSection_LBL);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(AdminStuName_LBL);
            Controls.Add(AdminStuID_LBL);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(flowLayoutPanel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AdminPayment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminPayment";
            Load += AdminPayment_Load;
            ((System.ComponentModel.ISupportInitialize)AdminPayment_GridView).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcAdminLogo2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AdminView_BTN;
        private Button AdminCancel_BTN;
        private Button AdminCompute_BTN;
        private Label label9;
        private Label label5;
        private DataGridView AdminPayment_GridView;
        private Label label1;
        private Button AdminConfirmPayment;
        private Label AdminChange_LBL;
        private Label label19;
        private Label AdminYLSection_LBL;
        private Label label7;
        private Label label8;
        private Label AdminStuName_LBL;
        private Label AdminStuID_LBL;
        private Label label4;
        private Label label3;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private PictureBox pcAdminLogo2;
        private Button btnAdminStudentInformation2;
        private Button btnAdminAssessment2;
        private Button btnAdminStudreg2;
        private Button btnAdminPay2;
        private Button btnAdminHistory2;
        private Button btnAdminReport2;
        private Button btnAdminOut2;
        private Button AdminPayment_SearchBTN;
        private TextBox AdminPayment_TXTBOX;
        private DateTimePicker dtCurrDate;
        private CheckedListBox clbModeOfPayment_AdminPay;
        private TextBox txtAdminPayment;
        private Label label6;
        private Label lbAdminPay_Remaining;
    }
}