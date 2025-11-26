namespace EventDriven.Project.UI
{
    partial class Cashier_PaymentHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cashier_PaymentHistory));
            btnViewHistory_PaymentHistory_Cashier = new Button();
            dtgPaymentHistory_Cashier = new DataGridView();
            txtSearch_PaymentHistory_Cashier = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            pcCashier_PaymentHistory_ = new PictureBox();
            btnPayment_PaymentHistory_Cashier = new Button();
            btnPaymentHistory_Cashier = new Button();
            btnReport_PaymentHistory_Cashier = new Button();
            btnLogout_PaymentHistory_Cashier = new Button();
            btnSearchStudent_PaymentHistory_Cashier = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgPaymentHistory_Cashier).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcCashier_PaymentHistory_).BeginInit();
            SuspendLayout();
            // 
            // btnViewHistory_PaymentHistory_Cashier
            // 
            btnViewHistory_PaymentHistory_Cashier.BackColor = Color.CadetBlue;
            btnViewHistory_PaymentHistory_Cashier.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnViewHistory_PaymentHistory_Cashier.ForeColor = Color.AliceBlue;
            btnViewHistory_PaymentHistory_Cashier.Location = new Point(526, 60);
            btnViewHistory_PaymentHistory_Cashier.Name = "btnViewHistory_PaymentHistory_Cashier";
            btnViewHistory_PaymentHistory_Cashier.Size = new Size(201, 50);
            btnViewHistory_PaymentHistory_Cashier.TabIndex = 102;
            btnViewHistory_PaymentHistory_Cashier.Text = "View History";
            btnViewHistory_PaymentHistory_Cashier.UseVisualStyleBackColor = false;
            btnViewHistory_PaymentHistory_Cashier.Click += btnViewHistory_PaymentHistory_Cashier_Click;
            // 
            // dtgPaymentHistory_Cashier
            // 
            dtgPaymentHistory_Cashier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgPaymentHistory_Cashier.Location = new Point(526, 138);
            dtgPaymentHistory_Cashier.Margin = new Padding(3, 4, 3, 4);
            dtgPaymentHistory_Cashier.Name = "dtgPaymentHistory_Cashier";
            dtgPaymentHistory_Cashier.RowHeadersWidth = 51;
            dtgPaymentHistory_Cashier.Size = new Size(1332, 895);
            dtgPaymentHistory_Cashier.TabIndex = 99;
            // 
            // txtSearch_PaymentHistory_Cashier
            // 
            txtSearch_PaymentHistory_Cashier.Font = new Font("Segoe UI", 14F);
            txtSearch_PaymentHistory_Cashier.Location = new Point(783, 58);
            txtSearch_PaymentHistory_Cashier.Margin = new Padding(3, 4, 3, 4);
            txtSearch_PaymentHistory_Cashier.Multiline = true;
            txtSearch_PaymentHistory_Cashier.Name = "txtSearch_PaymentHistory_Cashier";
            txtSearch_PaymentHistory_Cashier.Size = new Size(868, 48);
            txtSearch_PaymentHistory_Cashier.TabIndex = 100;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.CadetBlue;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(btnPayment_PaymentHistory_Cashier);
            flowLayoutPanel1.Controls.Add(btnPaymentHistory_Cashier);
            flowLayoutPanel1.Controls.Add(btnReport_PaymentHistory_Cashier);
            flowLayoutPanel1.Controls.Add(btnLogout_PaymentHistory_Cashier);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(474, 1033);
            flowLayoutPanel1.TabIndex = 97;
            // 
            // panel1
            // 
            panel1.Controls.Add(pcCashier_PaymentHistory_);
            panel1.Location = new Point(3, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(458, 277);
            panel1.TabIndex = 0;
            // 
            // pcCashier_PaymentHistory_
            // 
            pcCashier_PaymentHistory_.BackColor = Color.CadetBlue;
            pcCashier_PaymentHistory_.Image = (Image)resources.GetObject("pcCashier_PaymentHistory_.Image");
            pcCashier_PaymentHistory_.Location = new Point(56, 26);
            pcCashier_PaymentHistory_.Margin = new Padding(3, 4, 3, 4);
            pcCashier_PaymentHistory_.Name = "pcCashier_PaymentHistory_";
            pcCashier_PaymentHistory_.Size = new Size(333, 239);
            pcCashier_PaymentHistory_.SizeMode = PictureBoxSizeMode.StretchImage;
            pcCashier_PaymentHistory_.TabIndex = 0;
            pcCashier_PaymentHistory_.TabStop = false;
            pcCashier_PaymentHistory_.Click += pcCashier_PaymentHistory__Click;
            // 
            // btnPayment_PaymentHistory_Cashier
            // 
            btnPayment_PaymentHistory_Cashier.BackColor = Color.CadetBlue;
            btnPayment_PaymentHistory_Cashier.FlatStyle = FlatStyle.Flat;
            btnPayment_PaymentHistory_Cashier.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnPayment_PaymentHistory_Cashier.ForeColor = Color.AliceBlue;
            btnPayment_PaymentHistory_Cashier.Location = new Point(23, 298);
            btnPayment_PaymentHistory_Cashier.Margin = new Padding(23, 13, 3, 4);
            btnPayment_PaymentHistory_Cashier.Name = "btnPayment_PaymentHistory_Cashier";
            btnPayment_PaymentHistory_Cashier.Size = new Size(421, 79);
            btnPayment_PaymentHistory_Cashier.TabIndex = 3;
            btnPayment_PaymentHistory_Cashier.Text = "PAYMENT ";
            btnPayment_PaymentHistory_Cashier.UseVisualStyleBackColor = false;
            btnPayment_PaymentHistory_Cashier.Click += btnPayment_PaymentHistory_Cashier_Click;
            // 
            // btnPaymentHistory_Cashier
            // 
            btnPaymentHistory_Cashier.BackColor = Color.DarkSlateGray;
            btnPaymentHistory_Cashier.FlatStyle = FlatStyle.Flat;
            btnPaymentHistory_Cashier.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnPaymentHistory_Cashier.ForeColor = Color.AliceBlue;
            btnPaymentHistory_Cashier.Location = new Point(23, 385);
            btnPaymentHistory_Cashier.Margin = new Padding(23, 4, 3, 4);
            btnPaymentHistory_Cashier.Name = "btnPaymentHistory_Cashier";
            btnPaymentHistory_Cashier.Size = new Size(421, 79);
            btnPaymentHistory_Cashier.TabIndex = 4;
            btnPaymentHistory_Cashier.Text = "PAYMENT HISTORY";
            btnPaymentHistory_Cashier.UseVisualStyleBackColor = false;
            // 
            // btnReport_PaymentHistory_Cashier
            // 
            btnReport_PaymentHistory_Cashier.BackColor = Color.CadetBlue;
            btnReport_PaymentHistory_Cashier.FlatStyle = FlatStyle.Flat;
            btnReport_PaymentHistory_Cashier.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnReport_PaymentHistory_Cashier.ForeColor = Color.AliceBlue;
            btnReport_PaymentHistory_Cashier.Location = new Point(23, 472);
            btnReport_PaymentHistory_Cashier.Margin = new Padding(23, 4, 3, 4);
            btnReport_PaymentHistory_Cashier.Name = "btnReport_PaymentHistory_Cashier";
            btnReport_PaymentHistory_Cashier.Size = new Size(421, 79);
            btnReport_PaymentHistory_Cashier.TabIndex = 5;
            btnReport_PaymentHistory_Cashier.Text = "REPORT";
            btnReport_PaymentHistory_Cashier.UseVisualStyleBackColor = false;
            btnReport_PaymentHistory_Cashier.Click += btnReport_PaymentHistory_Cashier_Click;
            // 
            // btnLogout_PaymentHistory_Cashier
            // 
            btnLogout_PaymentHistory_Cashier.FlatStyle = FlatStyle.Flat;
            btnLogout_PaymentHistory_Cashier.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnLogout_PaymentHistory_Cashier.ForeColor = Color.AliceBlue;
            btnLogout_PaymentHistory_Cashier.Location = new Point(23, 559);
            btnLogout_PaymentHistory_Cashier.Margin = new Padding(23, 4, 3, 4);
            btnLogout_PaymentHistory_Cashier.Name = "btnLogout_PaymentHistory_Cashier";
            btnLogout_PaymentHistory_Cashier.Size = new Size(421, 79);
            btnLogout_PaymentHistory_Cashier.TabIndex = 9;
            btnLogout_PaymentHistory_Cashier.Text = "LOG OUT";
            btnLogout_PaymentHistory_Cashier.UseVisualStyleBackColor = true;
            btnLogout_PaymentHistory_Cashier.Click += btnLogout_PaymentHistory_Cashier_Click;
            // 
            // btnSearchStudent_PaymentHistory_Cashier
            // 
            btnSearchStudent_PaymentHistory_Cashier.BackColor = Color.CadetBlue;
            btnSearchStudent_PaymentHistory_Cashier.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnSearchStudent_PaymentHistory_Cashier.ForeColor = Color.AliceBlue;
            btnSearchStudent_PaymentHistory_Cashier.Location = new Point(1657, 56);
            btnSearchStudent_PaymentHistory_Cashier.Name = "btnSearchStudent_PaymentHistory_Cashier";
            btnSearchStudent_PaymentHistory_Cashier.Size = new Size(201, 50);
            btnSearchStudent_PaymentHistory_Cashier.TabIndex = 96;
            btnSearchStudent_PaymentHistory_Cashier.Text = "Search Student";
            btnSearchStudent_PaymentHistory_Cashier.UseVisualStyleBackColor = false;
            btnSearchStudent_PaymentHistory_Cashier.Click += btnSearchStudent_PaymentHistory_Cashier_Click;
            // 
            // Cashier_PaymentHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1902, 1033);
            Controls.Add(btnViewHistory_PaymentHistory_Cashier);
            Controls.Add(dtgPaymentHistory_Cashier);
            Controls.Add(txtSearch_PaymentHistory_Cashier);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnSearchStudent_PaymentHistory_Cashier);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Cashier_PaymentHistory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cashier_PaymentHistory";
            Load += Cashier_PaymentHistory_Load;
            ((System.ComponentModel.ISupportInitialize)dtgPaymentHistory_Cashier).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcCashier_PaymentHistory_).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnViewHistory_PaymentHistory_Cashier;
        private DataGridView dtgPaymentHistory_Cashier;
        private TextBox txtSearch_PaymentHistory_Cashier;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private PictureBox pcCashier_PaymentHistory_;
        private Button btnPayment_PaymentHistory_Cashier;
        private Button btnPaymentHistory_Cashier;
        private Button btnReport_PaymentHistory_Cashier;
        private Button btnLogout_PaymentHistory_Cashier;
        private Button btnSearchStudent_PaymentHistory_Cashier;
    }
}