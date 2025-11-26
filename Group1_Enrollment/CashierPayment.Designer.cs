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
            label6 = new Label();
            txtCashierPay = new TextBox();
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
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(474, 1033);
            flowLayoutPanel1.TabIndex = 86;
            // 
            // panel1
            // 
            panel1.Controls.Add(CashLabel);
            panel1.Controls.Add(pcAdminLogo2);
            panel1.Location = new Point(3, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(458, 277);
            panel1.TabIndex = 0;
            // 
            // CashLabel
            // 
            CashLabel.AutoSize = true;
            CashLabel.Font = new Font("Segoe UI Black", 17F, FontStyle.Bold);
            CashLabel.Location = new Point(157, 219);
            CashLabel.Name = "CashLabel";
            CashLabel.Size = new Size(143, 40);
            CashLabel.TabIndex = 124;
            CashLabel.Text = "CASHIER";
            // 
            // pcAdminLogo2
            // 
            pcAdminLogo2.BackColor = Color.CadetBlue;
            pcAdminLogo2.Image = (Image)resources.GetObject("pcAdminLogo2.Image");
            pcAdminLogo2.Location = new Point(56, 26);
            pcAdminLogo2.Margin = new Padding(3, 4, 3, 4);
            pcAdminLogo2.Name = "pcAdminLogo2";
            pcAdminLogo2.Size = new Size(333, 239);
            pcAdminLogo2.SizeMode = PictureBoxSizeMode.StretchImage;
            pcAdminLogo2.TabIndex = 0;
            pcAdminLogo2.TabStop = false;
            pcAdminLogo2.Click += pcAdminLogo2_Click;
            // 
            // btnAdminPay2
            // 
            btnAdminPay2.BackColor = Color.DarkSlateGray;
            btnAdminPay2.FlatStyle = FlatStyle.Flat;
            btnAdminPay2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnAdminPay2.ForeColor = Color.AliceBlue;
            btnAdminPay2.Location = new Point(23, 289);
            btnAdminPay2.Margin = new Padding(23, 4, 3, 4);
            btnAdminPay2.Name = "btnAdminPay2";
            btnAdminPay2.Size = new Size(421, 79);
            btnAdminPay2.TabIndex = 6;
            btnAdminPay2.Text = "PAYMENT";
            btnAdminPay2.UseVisualStyleBackColor = false;
            // 
            // btnAdminHistory2
            // 
            btnAdminHistory2.FlatStyle = FlatStyle.Flat;
            btnAdminHistory2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnAdminHistory2.ForeColor = Color.AliceBlue;
            btnAdminHistory2.Location = new Point(23, 376);
            btnAdminHistory2.Margin = new Padding(23, 4, 3, 4);
            btnAdminHistory2.Name = "btnAdminHistory2";
            btnAdminHistory2.Size = new Size(421, 79);
            btnAdminHistory2.TabIndex = 7;
            btnAdminHistory2.Text = "PAYMENT HISTORY";
            btnAdminHistory2.UseVisualStyleBackColor = true;
            btnAdminHistory2.Click += btnAdminHistory2_Click;
            // 
            // btnAdminReport2
            // 
            btnAdminReport2.FlatStyle = FlatStyle.Flat;
            btnAdminReport2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnAdminReport2.ForeColor = Color.AliceBlue;
            btnAdminReport2.Location = new Point(23, 463);
            btnAdminReport2.Margin = new Padding(23, 4, 3, 4);
            btnAdminReport2.Name = "btnAdminReport2";
            btnAdminReport2.Size = new Size(421, 79);
            btnAdminReport2.TabIndex = 8;
            btnAdminReport2.Text = "REPORT";
            btnAdminReport2.UseVisualStyleBackColor = true;
            btnAdminReport2.Click += btnAdminReport2_Click;
            // 
            // btnAdminOut2
            // 
            btnAdminOut2.FlatStyle = FlatStyle.Flat;
            btnAdminOut2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnAdminOut2.ForeColor = Color.AliceBlue;
            btnAdminOut2.Location = new Point(23, 550);
            btnAdminOut2.Margin = new Padding(23, 4, 3, 4);
            btnAdminOut2.Name = "btnAdminOut2";
            btnAdminOut2.Size = new Size(421, 79);
            btnAdminOut2.TabIndex = 9;
            btnAdminOut2.Text = "LOG OUT";
            btnAdminOut2.UseVisualStyleBackColor = true;
            btnAdminOut2.Click += btnAdminOut2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(667, 142);
            label2.Name = "label2";
            label2.Size = new Size(142, 32);
            label2.TabIndex = 88;
            label2.Text = "Student ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.Location = new Point(671, 228);
            label3.Name = "label3";
            label3.Size = new Size(183, 32);
            label3.TabIndex = 89;
            label3.Text = "Student Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.Location = new Point(1471, 308);
            label4.Name = "label4";
            label4.Size = new Size(209, 32);
            label4.TabIndex = 90;
            label4.Text = "Payment Method";
            // 
            // CashierStuName_LBL
            // 
            CashierStuName_LBL.AutoSize = true;
            CashierStuName_LBL.Font = new Font("Segoe UI", 14F);
            CashierStuName_LBL.Location = new Point(884, 228);
            CashierStuName_LBL.Name = "CashierStuName_LBL";
            CashierStuName_LBL.Size = new Size(232, 32);
            CashierStuName_LBL.TabIndex = 95;
            CashierStuName_LBL.Text = "<<Student Name>>";
            // 
            // CashierStuID_LBL
            // 
            CashierStuID_LBL.AutoSize = true;
            CashierStuID_LBL.Font = new Font("Segoe UI", 14F);
            CashierStuID_LBL.Location = new Point(897, 141);
            CashierStuID_LBL.Name = "CashierStuID_LBL";
            CashierStuID_LBL.Size = new Size(191, 32);
            CashierStuID_LBL.TabIndex = 94;
            CashierStuID_LBL.Text = "<<Student ID>>";
            // 
            // CashierYLSection_LBL
            // 
            CashierYLSection_LBL.AutoSize = true;
            CashierYLSection_LBL.Font = new Font("Segoe UI", 14F);
            CashierYLSection_LBL.Location = new Point(1442, 228);
            CashierYLSection_LBL.Name = "CashierYLSection_LBL";
            CashierYLSection_LBL.Size = new Size(270, 32);
            CashierYLSection_LBL.TabIndex = 99;
            CashierYLSection_LBL.Text = "<<Year Level Section>>";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label7.Location = new Point(1171, 228);
            label7.Name = "label7";
            label7.Size = new Size(230, 32);
            label7.TabIndex = 97;
            label7.Text = "Year Level/Section:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label8.Location = new Point(1191, 142);
            label8.Name = "label8";
            label8.Size = new Size(74, 32);
            label8.TabIndex = 96;
            label8.Text = "Date:";
            // 
            // CashierChange_LBL
            // 
            CashierChange_LBL.AutoSize = true;
            CashierChange_LBL.Font = new Font("Segoe UI", 14F);
            CashierChange_LBL.Location = new Point(1429, 747);
            CashierChange_LBL.Name = "CashierChange_LBL";
            CashierChange_LBL.Size = new Size(58, 32);
            CashierChange_LBL.TabIndex = 114;
            CashierChange_LBL.Text = "0.00";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label19.Location = new Point(1317, 746);
            label19.Name = "label19";
            label19.Size = new Size(106, 32);
            label19.TabIndex = 113;
            label19.Text = "Change:";
            // 
            // CashierConfirmPayment
            // 
            CashierConfirmPayment.BackColor = Color.CadetBlue;
            CashierConfirmPayment.Font = new Font("Segoe UI", 14F);
            CashierConfirmPayment.ForeColor = Color.AliceBlue;
            CashierConfirmPayment.Location = new Point(986, 867);
            CashierConfirmPayment.Margin = new Padding(3, 4, 3, 4);
            CashierConfirmPayment.Name = "CashierConfirmPayment";
            CashierConfirmPayment.Size = new Size(154, 54);
            CashierConfirmPayment.TabIndex = 115;
            CashierConfirmPayment.Text = "Confirm Payment";
            CashierConfirmPayment.UseVisualStyleBackColor = false;
            CashierConfirmPayment.Click += CashierConfirmPayment_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(671, 308);
            label1.Name = "label1";
            label1.Size = new Size(198, 32);
            label1.TabIndex = 116;
            label1.Text = "Payment Details";
            // 
            // CashierPayment_GridView
            // 
            CashierPayment_GridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CashierPayment_GridView.Location = new Point(671, 344);
            CashierPayment_GridView.Margin = new Padding(3, 4, 3, 4);
            CashierPayment_GridView.Name = "CashierPayment_GridView";
            CashierPayment_GridView.RowHeadersWidth = 51;
            CashierPayment_GridView.Size = new Size(789, 377);
            CashierPayment_GridView.TabIndex = 117;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label5.Location = new Point(667, 745);
            label5.Name = "label5";
            label5.Size = new Size(252, 32);
            label5.TabIndex = 118;
            label5.Text = "Payment Transaction";
            // 
            // CashierRemaining_LBL
            // 
            CashierRemaining_LBL.AutoSize = true;
            CashierRemaining_LBL.Font = new Font("Segoe UI", 14F);
            CashierRemaining_LBL.Location = new Point(1685, 746);
            CashierRemaining_LBL.Name = "CashierRemaining_LBL";
            CashierRemaining_LBL.Size = new Size(58, 32);
            CashierRemaining_LBL.TabIndex = 120;
            CashierRemaining_LBL.Text = "0.00";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label9.Location = new Point(968, 746);
            label9.Name = "label9";
            label9.Size = new Size(120, 32);
            label9.TabIndex = 119;
            label9.Text = "Payment:";
            // 
            // CashierCompute_BTN
            // 
            CashierCompute_BTN.BackColor = Color.CadetBlue;
            CashierCompute_BTN.Font = new Font("Segoe UI", 14F);
            CashierCompute_BTN.ForeColor = Color.AliceBlue;
            CashierCompute_BTN.Location = new Point(671, 868);
            CashierCompute_BTN.Margin = new Padding(3, 4, 3, 4);
            CashierCompute_BTN.Name = "CashierCompute_BTN";
            CashierCompute_BTN.Size = new Size(154, 54);
            CashierCompute_BTN.TabIndex = 121;
            CashierCompute_BTN.Text = "Compute";
            CashierCompute_BTN.UseVisualStyleBackColor = false;
            CashierCompute_BTN.Click += CashierCompute_BTN_Click;
            // 
            // CashierCancel_BTN
            // 
            CashierCancel_BTN.BackColor = Color.CadetBlue;
            CashierCancel_BTN.Font = new Font("Segoe UI", 14F);
            CashierCancel_BTN.ForeColor = Color.AliceBlue;
            CashierCancel_BTN.Location = new Point(1306, 866);
            CashierCancel_BTN.Margin = new Padding(3, 4, 3, 4);
            CashierCancel_BTN.Name = "CashierCancel_BTN";
            CashierCancel_BTN.Size = new Size(154, 54);
            CashierCancel_BTN.TabIndex = 122;
            CashierCancel_BTN.Text = "Cancel";
            CashierCancel_BTN.UseVisualStyleBackColor = false;
            CashierCancel_BTN.Click += CashierCancel_BTN_Click;
            // 
            // CashierView_BTN
            // 
            CashierView_BTN.BackColor = Color.CadetBlue;
            CashierView_BTN.Font = new Font("Segoe UI", 14F);
            CashierView_BTN.ForeColor = Color.AliceBlue;
            CashierView_BTN.Location = new Point(1589, 865);
            CashierView_BTN.Margin = new Padding(3, 4, 3, 4);
            CashierView_BTN.Name = "CashierView_BTN";
            CashierView_BTN.Size = new Size(154, 54);
            CashierView_BTN.TabIndex = 123;
            CashierView_BTN.Text = "Print Reciept";
            CashierView_BTN.UseVisualStyleBackColor = false;
            CashierView_BTN.Click += CashierView_BTN_Click;
            // 
            // CashierPayment_TXTBOX
            // 
            CashierPayment_TXTBOX.Font = new Font("Segoe UI", 14F);
            CashierPayment_TXTBOX.Location = new Point(877, 33);
            CashierPayment_TXTBOX.Margin = new Padding(3, 4, 3, 4);
            CashierPayment_TXTBOX.Multiline = true;
            CashierPayment_TXTBOX.Name = "CashierPayment_TXTBOX";
            CashierPayment_TXTBOX.Size = new Size(868, 48);
            CashierPayment_TXTBOX.TabIndex = 151;
            // 
            // CashierPayment_SearchBTN
            // 
            CashierPayment_SearchBTN.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CashierPayment_SearchBTN.Location = new Point(653, 30);
            CashierPayment_SearchBTN.Margin = new Padding(3, 4, 3, 4);
            CashierPayment_SearchBTN.Name = "CashierPayment_SearchBTN";
            CashierPayment_SearchBTN.Size = new Size(201, 50);
            CashierPayment_SearchBTN.TabIndex = 150;
            CashierPayment_SearchBTN.Text = "Search Student";
            CashierPayment_SearchBTN.UseVisualStyleBackColor = true;
            CashierPayment_SearchBTN.Click += CashierPayment_SearchBTN_Click;
            // 
            // dtRegDate
            // 
            dtRegDate.CalendarFont = new Font("Segoe UI", 14F);
            dtRegDate.Font = new Font("Segoe UI", 14F);
            dtRegDate.Location = new Point(1324, 136);
            dtRegDate.Margin = new Padding(3, 4, 3, 4);
            dtRegDate.Name = "dtRegDate";
            dtRegDate.Size = new Size(388, 39);
            dtRegDate.TabIndex = 152;
            // 
            // clbModeOfPayment_CashierPay
            // 
            clbModeOfPayment_CashierPay.Font = new Font("Segoe UI", 12F);
            clbModeOfPayment_CashierPay.FormattingEnabled = true;
            clbModeOfPayment_CashierPay.Items.AddRange(new object[] { "Low Down Payment", "Low Quarterly Payment", "Cash" });
            clbModeOfPayment_CashierPay.Location = new Point(1471, 344);
            clbModeOfPayment_CashierPay.Name = "clbModeOfPayment_CashierPay";
            clbModeOfPayment_CashierPay.Size = new Size(272, 91);
            clbModeOfPayment_CashierPay.TabIndex = 203;
            clbModeOfPayment_CashierPay.SelectedIndexChanged += clbModeOfPayment_CashierPay_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label6.Location = new Point(1537, 746);
            label6.Name = "label6";
            label6.Size = new Size(143, 32);
            label6.TabIndex = 205;
            label6.Text = "Remaining:";
            // 
            // txtCashierPay
            // 
            txtCashierPay.Font = new Font("Segoe UI", 14F);
            txtCashierPay.Location = new Point(1105, 742);
            txtCashierPay.Margin = new Padding(3, 4, 3, 4);
            txtCashierPay.Name = "txtCashierPay";
            txtCashierPay.Size = new Size(206, 39);
            txtCashierPay.TabIndex = 204;
            txtCashierPay.TextChanged += txtCashierPay_TextChanged;
            // 
            // CashierPayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1902, 1033);
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
            Margin = new Padding(3, 4, 3, 4);
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
        private Label label6;
        private TextBox txtCashierPay;
    }
}