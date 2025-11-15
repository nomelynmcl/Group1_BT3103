namespace EventDriven.Project.UI
{
    partial class CashierDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierDashboard));
            lblCashierPayHistory = new Label();
            lblCashierPayment = new Label();
            btnCashierOverview = new Button();
            btnLogoutCashier = new Button();
            lblCashierReport = new Label();
            lblCashier = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // lblCashierPayHistory
            // 
            lblCashierPayHistory.AutoSize = true;
            lblCashierPayHistory.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCashierPayHistory.Location = new Point(48, 244);
            lblCashierPayHistory.Name = "lblCashierPayHistory";
            lblCashierPayHistory.Size = new Size(156, 20);
            lblCashierPayHistory.TabIndex = 28;
            lblCashierPayHistory.Text = "PAYMENT HISTORY";
            lblCashierPayHistory.Click += lblCashierPayHistory_Click;
            // 
            // lblCashierPayment
            // 
            lblCashierPayment.AutoSize = true;
            lblCashierPayment.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCashierPayment.Location = new Point(48, 203);
            lblCashierPayment.Name = "lblCashierPayment";
            lblCashierPayment.Size = new Size(85, 20);
            lblCashierPayment.TabIndex = 27;
            lblCashierPayment.Text = "PAYMENT";
            lblCashierPayment.Click += lblCashierPayment_Click;
            // 
            // btnCashierOverview
            // 
            btnCashierOverview.BackColor = Color.LightGray;
            btnCashierOverview.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCashierOverview.ForeColor = Color.SteelBlue;
            btnCashierOverview.Location = new Point(542, 431);
            btnCashierOverview.Margin = new Padding(3, 2, 3, 2);
            btnCashierOverview.Name = "btnCashierOverview";
            btnCashierOverview.Size = new Size(253, 34);
            btnCashierOverview.TabIndex = 24;
            btnCashierOverview.Text = "CASHIER OVERVIEW";
            btnCashierOverview.UseVisualStyleBackColor = false;
            btnCashierOverview.Click += btnCashierOverview_Click;
            // 
            // btnLogoutCashier
            // 
            btnLogoutCashier.BackColor = Color.LightGray;
            btnLogoutCashier.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogoutCashier.Location = new Point(1011, 28);
            btnLogoutCashier.Margin = new Padding(3, 2, 3, 2);
            btnLogoutCashier.Name = "btnLogoutCashier";
            btnLogoutCashier.Size = new Size(79, 28);
            btnLogoutCashier.TabIndex = 23;
            btnLogoutCashier.Text = "Logout";
            btnLogoutCashier.UseVisualStyleBackColor = false;
            btnLogoutCashier.Click += btnLogoutCashier_Click;
            // 
            // lblCashierReport
            // 
            lblCashierReport.AutoSize = true;
            lblCashierReport.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCashierReport.Location = new Point(48, 283);
            lblCashierReport.Name = "lblCashierReport";
            lblCashierReport.Size = new Size(68, 20);
            lblCashierReport.TabIndex = 21;
            lblCashierReport.Text = "REPORT";
            lblCashierReport.Click += lblCashierReport_Click;
            // 
            // lblCashier
            // 
            lblCashier.AutoSize = true;
            lblCashier.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCashier.ForeColor = Color.SteelBlue;
            lblCashier.Location = new Point(48, 132);
            lblCashier.Name = "lblCashier";
            lblCashier.Size = new Size(159, 45);
            lblCashier.TabIndex = 16;
            lblCashier.Text = "CASHIER";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(5, 13);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 142);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(314, 80);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(700, 324);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 29;
            pictureBox3.TabStop = false;
            // 
            // CashierDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 500);
            Controls.Add(pictureBox3);
            Controls.Add(lblCashierPayHistory);
            Controls.Add(lblCashierPayment);
            Controls.Add(btnCashierOverview);
            Controls.Add(btnLogoutCashier);
            Controls.Add(lblCashierReport);
            Controls.Add(lblCashier);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CashierDashboard";
            Text = "CashierDashboard";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Button btnCashierOverview;
        private Button btnLogoutCashier;
        private Label lblCashierReport;
        private Label lblCashier;
        private PictureBox pictureBox1;
        private Label lblCashierPayHistory;
        private Label lblCashierPayment;
        private PictureBox pictureBox3;
    }
}