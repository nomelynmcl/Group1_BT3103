namespace EventDriven.Project.UI
{
    partial class CashierPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierPayment));
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            CashLabel = new Label();
            pcAdminLogo2 = new PictureBox();
            btnAdminPay2 = new Button();
            btnAdminHistory2 = new Button();
            btnAdminReport2 = new Button();
            btnAdminOut2 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            CashierStuName_LBL = new Label();
            CashierStuID_LBL = new Label();
            CashierYLSection_LBL = new Label();
            label7 = new Label();
            label8 = new Label();
            CashierChange_LBL = new Label();
            label19 = new Label();
            CashierConfirmPayment = new Button();
            label1 = new Label();
            CashierPayment_GridView = new DataGridView();
            label5 = new Label();
            CashierRemaining_LBL = new Label();
            label9 = new Label();
            CashierCompute_BTN = new Button();
            CashierCancel_BTN = new Button();
            CashierView_BTN = new Button();
            CashierPayment_TXTBOX = new TextBox();
            CashierPayment_SearchBTN = new Button();
            dtRegDate = new DateTimePicker();
            clbModeOfPayment_CashierPay = new CheckedListBox();
            txtCashierPay = new TextBox();
            label6 = new Label();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcAdminLogo2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CashierPayment_GridView).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.CadetBlue;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(btnAdminPay2);
            flowLayoutPanel1.Controls.Add(btnAdminHistory2);
            flowLayoutPanel1.Controls.Add(btnAdminReport2);
            flowLayoutPanel1.Controls.Add(btnAdminOut2);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(251, 522);
            flowLayoutPanel1.TabIndex = 86;
            // 
            // panel1
            // 
            panel1.Controls.Add(CashLabel);
            panel1.Controls.Add(pcAdminLogo2);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(248, 140);
            panel1.TabIndex = 0;
            // 
            // CashLabel
            // 
            CashLabel.AutoSize = true;
            CashLabel.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CashLabel.Location = new Point(84, 115);
            CashLabel.Name = "CashLabel";
            CashLabel.Size = new Size(73, 20);
            CashLabel.TabIndex = 124;
            CashLabel.Text = "CASHIER";
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
            // 
            // btnAdminPay2
            // 
            btnAdminPay2.BackColor = Color.DarkSlateGray;
            btnAdminPay2.FlatStyle = FlatStyle.Flat;
            btnAdminPay2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminPay2.ForeColor = SystemColors.Control;
            btnAdminPay2.Location = new Point(20, 149);
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
            btnAdminHistory2.Location = new Point(20, 197);
            btnAdminHistory2.Margin = new Padding(20, 3, 3, 3);
            btnAdminHistory2.Name = "btnAdminHistory2";
            btnAdminHistory2.Size = new Size(211, 42);
            btnAdminHistory2.TabIndex = 7;
            btnAdminHistory2.Text = "PAYMENT HISTORY";
            btnAdminHistory2.UseVisualStyleBackColor = true;
            // 
            // btnAdminReport2
            // 
            btnAdminReport2.FlatStyle = FlatStyle.Flat;
            btnAdminReport2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminReport2.Location = new Point(20, 245);
            btnAdminReport2.Margin = new Padding(20, 3, 3, 3);
            btnAdminReport2.Name = "btnAdminReport2";
            btnAdminReport2.Size = new Size(211, 42);
            btnAdminReport2.TabIndex = 8;
            btnAdminReport2.Text = "REPORT";
            btnAdminReport2.UseVisualStyleBackColor = true;
            // 
            // btnAdminOut2
            // 
            btnAdminOut2.FlatStyle = FlatStyle.Flat;
            btnAdminOut2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminOut2.Location = new Point(20, 293);
            btnAdminOut2.Margin = new Padding(20, 3, 3, 3);
            btnAdminOut2.Name = "btnAdminOut2";
            btnAdminOut2.Size = new Size(211, 42);
            btnAdminOut2.TabIndex = 9;
            btnAdminOut2.Text = "LOG OUT";
            btnAdminOut2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(277, 48);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 88;
            label2.Text = "Student ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(277, 78);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 89;
            label3.Text = "Student Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(605, 151);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 90;
            label4.Text = "Payment Method";
            // 
            // CashierStuName_LBL
            // 
            CashierStuName_LBL.AutoSize = true;
            CashierStuName_LBL.Location = new Point(372, 78);
            CashierStuName_LBL.Name = "CashierStuName_LBL";
            CashierStuName_LBL.Size = new Size(115, 15);
            CashierStuName_LBL.TabIndex = 95;
            CashierStuName_LBL.Text = "<<Student Name>>";
            // 
            // CashierStuID_LBL
            // 
            CashierStuID_LBL.AutoSize = true;
            CashierStuID_LBL.Location = new Point(343, 48);
            CashierStuID_LBL.Name = "CashierStuID_LBL";
            CashierStuID_LBL.Size = new Size(94, 15);
            CashierStuID_LBL.TabIndex = 94;
            CashierStuID_LBL.Text = "<<Student ID>>";
            // 
            // CashierYLSection_LBL
            // 
            CashierYLSection_LBL.AutoSize = true;
            CashierYLSection_LBL.Location = new Point(389, 106);
            CashierYLSection_LBL.Name = "CashierYLSection_LBL";
            CashierYLSection_LBL.Size = new Size(133, 15);
            CashierYLSection_LBL.TabIndex = 99;
            CashierYLSection_LBL.Text = "<<Year Level Section>>";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(277, 106);
            label7.Name = "label7";
            label7.Size = new Size(114, 15);
            label7.TabIndex = 97;
            label7.Text = "Year Level/Section:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(572, 48);
            label8.Name = "label8";
            label8.Size = new Size(37, 15);
            label8.TabIndex = 96;
            label8.Text = "Date:";
            // 
            // CashierChange_LBL
            // 
            CashierChange_LBL.AutoSize = true;
            CashierChange_LBL.Location = new Point(553, 419);
            CashierChange_LBL.Name = "CashierChange_LBL";
            CashierChange_LBL.Size = new Size(28, 15);
            CashierChange_LBL.TabIndex = 114;
            CashierChange_LBL.Text = "0.00";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(471, 419);
            label19.Name = "label19";
            label19.Size = new Size(51, 15);
            label19.TabIndex = 113;
            label19.Text = "Change:";
            // 
            // CashierConfirmPayment
            // 
            CashierConfirmPayment.Location = new Point(398, 461);
            CashierConfirmPayment.Name = "CashierConfirmPayment";
            CashierConfirmPayment.Size = new Size(110, 37);
            CashierConfirmPayment.TabIndex = 115;
            CashierConfirmPayment.Text = "Confirm Payment";
            CashierConfirmPayment.UseVisualStyleBackColor = true;
            CashierConfirmPayment.Click += CashierConfirmPayment_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(277, 151);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 116;
            label1.Text = "Payment Details";
            // 
            // CashierPayment_GridView
            // 
            CashierPayment_GridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CashierPayment_GridView.Location = new Point(277, 167);
            CashierPayment_GridView.Name = "CashierPayment_GridView";
            CashierPayment_GridView.Size = new Size(289, 178);
            CashierPayment_GridView.TabIndex = 117;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(277, 380);
            label5.Name = "label5";
            label5.Size = new Size(122, 15);
            label5.TabIndex = 118;
            label5.Text = "Payment Transaction";
            // 
            // CashierRemaining_LBL
            // 
            CashierRemaining_LBL.AutoSize = true;
            CashierRemaining_LBL.Location = new Point(710, 419);
            CashierRemaining_LBL.Name = "CashierRemaining_LBL";
            CashierRemaining_LBL.Size = new Size(28, 15);
            CashierRemaining_LBL.TabIndex = 120;
            CashierRemaining_LBL.Text = "0.00";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(277, 419);
            label9.Name = "label9";
            label9.Size = new Size(59, 15);
            label9.TabIndex = 119;
            label9.Text = "Payment:";
            // 
            // CashierCompute_BTN
            // 
            CashierCompute_BTN.Location = new Point(273, 461);
            CashierCompute_BTN.Name = "CashierCompute_BTN";
            CashierCompute_BTN.Size = new Size(110, 37);
            CashierCompute_BTN.TabIndex = 121;
            CashierCompute_BTN.Text = "Compute";
            CashierCompute_BTN.UseVisualStyleBackColor = true;
            CashierCompute_BTN.Click += CashierCompute_BTN_Click;
            // 
            // CashierCancel_BTN
            // 
            CashierCancel_BTN.Location = new Point(525, 461);
            CashierCancel_BTN.Name = "CashierCancel_BTN";
            CashierCancel_BTN.Size = new Size(110, 37);
            CashierCancel_BTN.TabIndex = 122;
            CashierCancel_BTN.Text = "Cancel";
            CashierCancel_BTN.UseVisualStyleBackColor = true;
            // 
            // CashierView_BTN
            // 
            CashierView_BTN.Location = new Point(653, 461);
            CashierView_BTN.Name = "CashierView_BTN";
            CashierView_BTN.Size = new Size(110, 37);
            CashierView_BTN.TabIndex = 123;
            CashierView_BTN.Text = "View Reciept";
            CashierView_BTN.UseVisualStyleBackColor = true;
            // 
            // CashierPayment_TXTBOX
            // 
            CashierPayment_TXTBOX.Location = new Point(401, 12);
            CashierPayment_TXTBOX.Name = "CashierPayment_TXTBOX";
            CashierPayment_TXTBOX.Size = new Size(208, 23);
            CashierPayment_TXTBOX.TabIndex = 151;
            // 
            // CashierPayment_SearchBTN
            // 
            CashierPayment_SearchBTN.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CashierPayment_SearchBTN.Location = new Point(277, 12);
            CashierPayment_SearchBTN.Name = "CashierPayment_SearchBTN";
            CashierPayment_SearchBTN.Size = new Size(118, 23);
            CashierPayment_SearchBTN.TabIndex = 150;
            CashierPayment_SearchBTN.Text = "Search Student";
            CashierPayment_SearchBTN.UseVisualStyleBackColor = true;
            CashierPayment_SearchBTN.Click += CashierPayment_SearchBTN_Click;
            // 
            // dtRegDate
            // 
            dtRegDate.Location = new Point(615, 40);
            dtRegDate.Name = "dtRegDate";
            dtRegDate.Size = new Size(153, 23);
            dtRegDate.TabIndex = 152;
            // 
            // clbModeOfPayment_CashierPay
            // 
            clbModeOfPayment_CashierPay.FormattingEnabled = true;
            clbModeOfPayment_CashierPay.Items.AddRange(new object[] { "Low Down Payment", "Low Quarterly Payment", "Cash" });
            clbModeOfPayment_CashierPay.Location = new Point(595, 181);
            clbModeOfPayment_CashierPay.Margin = new Padding(3, 2, 3, 2);
            clbModeOfPayment_CashierPay.Name = "clbModeOfPayment_CashierPay";
            clbModeOfPayment_CashierPay.Size = new Size(157, 58);
            clbModeOfPayment_CashierPay.TabIndex = 203;
            clbModeOfPayment_CashierPay.SelectedIndexChanged += clbModeOfPayment_CashierPay_SelectedIndexChanged;
            // 
            // txtCashierPay
            // 
            txtCashierPay.Location = new Point(343, 416);
            txtCashierPay.Name = "txtCashierPay";
            txtCashierPay.Size = new Size(108, 23);
            txtCashierPay.TabIndex = 204;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(612, 419);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 205;
            label6.Text = "Remaining:";
            // 
            // CashierPayment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(780, 522);
            Controls.Add(label6);
            Controls.Add(txtCashierPay);
            Controls.Add(clbModeOfPayment_CashierPay);
            Controls.Add(dtRegDate);
            Controls.Add(CashierPayment_TXTBOX);
            Controls.Add(CashierPayment_SearchBTN);
            Controls.Add(CashierView_BTN);
            Controls.Add(CashierCancel_BTN);
            Controls.Add(CashierCompute_BTN);
            Controls.Add(CashierRemaining_LBL);
            Controls.Add(label9);
            Controls.Add(label5);
            Controls.Add(CashierPayment_GridView);
            Controls.Add(label1);
            Controls.Add(CashierConfirmPayment);
            Controls.Add(CashierChange_LBL);
            Controls.Add(label19);
            Controls.Add(CashierYLSection_LBL);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(CashierStuName_LBL);
            Controls.Add(CashierStuID_LBL);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(flowLayoutPanel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CashierPayment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CashierPayment";
            Load += CashierPayment_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcAdminLogo2).EndInit();
            ((System.ComponentModel.ISupportInitialize)CashierPayment_GridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private PictureBox pcAdminLogo2;
        private Button btnAdminPay2;
        private Button btnAdminHistory2;
        private Button btnAdminReport2;
        private Button btnAdminOut2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label CashierStuName_LBL;
        private Label CashierStuID_LBL;
        private Label CashierYLSection_LBL;
        private Label label7;
        private Label label8;
        private Label CashierChange_LBL;
        private Label label19;
        private Button CashierConfirmPayment;
        private Label label1;
        private DataGridView CashierPayment_GridView;
        private Label label5;
        private Label CashierRemaining_LBL;
        private Label label9;
        private Button CashierCompute_BTN;
        private Button CashierCancel_BTN;
        private Button CashierView_BTN;
        private Label CashLabel;
        private TextBox CashierPayment_TXTBOX;
        private Button CashierPayment_SearchBTN;
        private DateTimePicker dtRegDate;
        private CheckedListBox clbModeOfPayment_CashierPay;
        private TextBox txtCashierPay;
        private Label label6;
    }
}