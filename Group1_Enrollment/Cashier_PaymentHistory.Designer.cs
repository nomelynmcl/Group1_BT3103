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
            btnViewHistory_PaymentHistory_Cashier.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnViewHistory_PaymentHistory_Cashier.Location = new Point(289, 17);
            btnViewHistory_PaymentHistory_Cashier.Margin = new Padding(3, 2, 3, 2);
            btnViewHistory_PaymentHistory_Cashier.Name = "btnViewHistory_PaymentHistory_Cashier";
            btnViewHistory_PaymentHistory_Cashier.Size = new Size(125, 25);
            btnViewHistory_PaymentHistory_Cashier.TabIndex = 102;
            btnViewHistory_PaymentHistory_Cashier.Text = "View History";
            btnViewHistory_PaymentHistory_Cashier.UseVisualStyleBackColor = true;
            btnViewHistory_PaymentHistory_Cashier.Click += btnViewHistory_PaymentHistory_Cashier_Click;
            // 
            // dtgPaymentHistory_Cashier
            // 
            dtgPaymentHistory_Cashier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgPaymentHistory_Cashier.Location = new Point(289, 54);
            dtgPaymentHistory_Cashier.Name = "dtgPaymentHistory_Cashier";
            dtgPaymentHistory_Cashier.RowHeadersWidth = 51;
            dtgPaymentHistory_Cashier.Size = new Size(742, 512);
            dtgPaymentHistory_Cashier.TabIndex = 99;
            // 
            // txtSearch_PaymentHistory_Cashier
            // 
            txtSearch_PaymentHistory_Cashier.Location = new Point(620, 16);
            txtSearch_PaymentHistory_Cashier.Name = "txtSearch_PaymentHistory_Cashier";
            txtSearch_PaymentHistory_Cashier.Size = new Size(276, 23);
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
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(251, 522);
            flowLayoutPanel1.TabIndex = 97;
            // 
            // panel1
            // 
            panel1.Controls.Add(pcCashier_PaymentHistory_);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(248, 140);
            panel1.TabIndex = 0;
            // 
            // pcCashier_PaymentHistory_
            // 
            pcCashier_PaymentHistory_.BackColor = Color.CadetBlue;
            pcCashier_PaymentHistory_.Image = (Image)resources.GetObject("pcCashier_PaymentHistory_.Image");
            pcCashier_PaymentHistory_.Location = new Point(44, 14);
            pcCashier_PaymentHistory_.Name = "pcCashier_PaymentHistory_";
            pcCashier_PaymentHistory_.Size = new Size(154, 126);
            pcCashier_PaymentHistory_.SizeMode = PictureBoxSizeMode.StretchImage;
            pcCashier_PaymentHistory_.TabIndex = 0;
            pcCashier_PaymentHistory_.TabStop = false;
            pcCashier_PaymentHistory_.Click += pcCashier_PaymentHistory__Click;
            // 
            // btnPayment_PaymentHistory_Cashier
            // 
            btnPayment_PaymentHistory_Cashier.BackColor = Color.CadetBlue;
            btnPayment_PaymentHistory_Cashier.FlatStyle = FlatStyle.Flat;
            btnPayment_PaymentHistory_Cashier.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPayment_PaymentHistory_Cashier.ForeColor = SystemColors.ControlText;
            btnPayment_PaymentHistory_Cashier.Location = new Point(20, 156);
            btnPayment_PaymentHistory_Cashier.Margin = new Padding(20, 10, 3, 3);
            btnPayment_PaymentHistory_Cashier.Name = "btnPayment_PaymentHistory_Cashier";
            btnPayment_PaymentHistory_Cashier.Size = new Size(211, 42);
            btnPayment_PaymentHistory_Cashier.TabIndex = 3;
            btnPayment_PaymentHistory_Cashier.Text = "PAYMENT ";
            btnPayment_PaymentHistory_Cashier.UseVisualStyleBackColor = false;
            btnPayment_PaymentHistory_Cashier.Click += btnPayment_PaymentHistory_Cashier_Click;
            // 
            // btnPaymentHistory_Cashier
            // 
            btnPaymentHistory_Cashier.BackColor = Color.DarkSlateGray;
            btnPaymentHistory_Cashier.FlatStyle = FlatStyle.Flat;
            btnPaymentHistory_Cashier.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPaymentHistory_Cashier.ForeColor = SystemColors.ControlLight;
            btnPaymentHistory_Cashier.Location = new Point(20, 204);
            btnPaymentHistory_Cashier.Margin = new Padding(20, 3, 3, 3);
            btnPaymentHistory_Cashier.Name = "btnPaymentHistory_Cashier";
            btnPaymentHistory_Cashier.Size = new Size(211, 42);
            btnPaymentHistory_Cashier.TabIndex = 4;
            btnPaymentHistory_Cashier.Text = "PAYMENT HISTORY";
            btnPaymentHistory_Cashier.UseVisualStyleBackColor = false;
            // 
            // btnReport_PaymentHistory_Cashier
            // 
            btnReport_PaymentHistory_Cashier.BackColor = Color.CadetBlue;
            btnReport_PaymentHistory_Cashier.FlatStyle = FlatStyle.Flat;
            btnReport_PaymentHistory_Cashier.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReport_PaymentHistory_Cashier.ForeColor = SystemColors.ControlText;
            btnReport_PaymentHistory_Cashier.Location = new Point(20, 252);
            btnReport_PaymentHistory_Cashier.Margin = new Padding(20, 3, 3, 3);
            btnReport_PaymentHistory_Cashier.Name = "btnReport_PaymentHistory_Cashier";
            btnReport_PaymentHistory_Cashier.Size = new Size(211, 42);
            btnReport_PaymentHistory_Cashier.TabIndex = 5;
            btnReport_PaymentHistory_Cashier.Text = "REPORT";
            btnReport_PaymentHistory_Cashier.UseVisualStyleBackColor = false;
            btnReport_PaymentHistory_Cashier.Click += btnReport_PaymentHistory_Cashier_Click;
            // 
            // btnLogout_PaymentHistory_Cashier
            // 
            btnLogout_PaymentHistory_Cashier.FlatStyle = FlatStyle.Flat;
            btnLogout_PaymentHistory_Cashier.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout_PaymentHistory_Cashier.Location = new Point(20, 300);
            btnLogout_PaymentHistory_Cashier.Margin = new Padding(20, 3, 3, 3);
            btnLogout_PaymentHistory_Cashier.Name = "btnLogout_PaymentHistory_Cashier";
            btnLogout_PaymentHistory_Cashier.Size = new Size(211, 42);
            btnLogout_PaymentHistory_Cashier.TabIndex = 9;
            btnLogout_PaymentHistory_Cashier.Text = "LOG OUT";
            btnLogout_PaymentHistory_Cashier.UseVisualStyleBackColor = true;
            btnLogout_PaymentHistory_Cashier.Click += btnLogout_PaymentHistory_Cashier_Click;
            // 
            // btnSearchStudent_PaymentHistory_Cashier
            // 
            btnSearchStudent_PaymentHistory_Cashier.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSearchStudent_PaymentHistory_Cashier.Location = new Point(909, 14);
            btnSearchStudent_PaymentHistory_Cashier.Margin = new Padding(3, 2, 3, 2);
            btnSearchStudent_PaymentHistory_Cashier.Name = "btnSearchStudent_PaymentHistory_Cashier";
            btnSearchStudent_PaymentHistory_Cashier.Size = new Size(122, 25);
            btnSearchStudent_PaymentHistory_Cashier.TabIndex = 96;
            btnSearchStudent_PaymentHistory_Cashier.Text = "Search Student";
            btnSearchStudent_PaymentHistory_Cashier.UseVisualStyleBackColor = true;
            btnSearchStudent_PaymentHistory_Cashier.Click += btnSearchStudent_PaymentHistory_Cashier_Click;
            // 
            // Cashier_PaymentHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1058, 522);
            Controls.Add(btnViewHistory_PaymentHistory_Cashier);
            Controls.Add(dtgPaymentHistory_Cashier);
            Controls.Add(txtSearch_PaymentHistory_Cashier);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnSearchStudent_PaymentHistory_Cashier);
            Margin = new Padding(3, 2, 3, 2);
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