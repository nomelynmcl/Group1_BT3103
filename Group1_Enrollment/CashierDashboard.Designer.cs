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
            this.lblCashierPayHistory = new Label();
            this.lblCashierPayment = new Label();
            this.txtCashierSearch = new TextBox();
            this.btnCashierSearch = new Button();
            btnCashierOverview = new Button();
            this.btnLogoutCashier = new Button();
            pictureBox2 = new PictureBox();
            this.lblCashierReport = new Label();
            lblCashier = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblCashierPayHistory
            // 
            this.lblCashierPayHistory.AutoSize = true;
            this.lblCashierPayHistory.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lblCashierPayHistory.Location = new Point(48, 244);
            this.lblCashierPayHistory.Name = "lblCashierPayHistory";
            this.lblCashierPayHistory.Size = new Size(156, 20);
            this.lblCashierPayHistory.TabIndex = 28;
            this.lblCashierPayHistory.Text = "PAYMENT HISTORY";
            // 
            // lblCashierPayment
            // 
            this.lblCashierPayment.AutoSize = true;
            this.lblCashierPayment.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lblCashierPayment.Location = new Point(48, 203);
            this.lblCashierPayment.Name = "lblCashierPayment";
            this.lblCashierPayment.Size = new Size(85, 20);
            this.lblCashierPayment.TabIndex = 27;
            this.lblCashierPayment.Text = "PAYMENT";
            // 
            // txtCashierSearch
            // 
            this.txtCashierSearch.Location = new Point(314, 79);
            this.txtCashierSearch.Margin = new Padding(3, 2, 3, 2);
            this.txtCashierSearch.Name = "txtCashierSearch";
            this.txtCashierSearch.Size = new Size(572, 23);
            this.txtCashierSearch.TabIndex = 26;
            // 
            // btnCashierSearch
            // 
            this.btnCashierSearch.BackColor = Color.LightGray;
            this.btnCashierSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnCashierSearch.Location = new Point(891, 74);
            this.btnCashierSearch.Margin = new Padding(3, 2, 3, 2);
            this.btnCashierSearch.Name = "btnCashierSearch";
            this.btnCashierSearch.Size = new Size(126, 28);
            this.btnCashierSearch.TabIndex = 25;
            this.btnCashierSearch.Text = "Search Student";
            this.btnCashierSearch.UseVisualStyleBackColor = false;
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
            // 
            // btnLogoutCashier
            // 
            this.btnLogoutCashier.BackColor = Color.LightGray;
            this.btnLogoutCashier.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.btnLogoutCashier.Location = new Point(1011, 28);
            this.btnLogoutCashier.Margin = new Padding(3, 2, 3, 2);
            this.btnLogoutCashier.Name = "btnLogoutCashier";
            this.btnLogoutCashier.Size = new Size(79, 28);
            this.btnLogoutCashier.TabIndex = 23;
            this.btnLogoutCashier.Text = "Logout";
            this.btnLogoutCashier.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(317, 118);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(700, 282);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // lblCashierReport
            // 
            this.lblCashierReport.AutoSize = true;
            this.lblCashierReport.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lblCashierReport.Location = new Point(48, 283);
            this.lblCashierReport.Name = "lblCashierReport";
            this.lblCashierReport.Size = new Size(68, 20);
            this.lblCashierReport.TabIndex = 21;
            this.lblCashierReport.Text = "REPORT";
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
            // CashierDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 500);
            Controls.Add(this.lblCashierPayHistory);
            Controls.Add(this.lblCashierPayment);
            Controls.Add(this.txtCashierSearch);
            Controls.Add(this.btnCashierSearch);
            Controls.Add(btnCashierOverview);
            Controls.Add(this.btnLogoutCashier);
            Controls.Add(pictureBox2);
            Controls.Add(this.lblCashierReport);
            Controls.Add(lblCashier);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CashierDashboard";
            Text = "CashierDashboard";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPaymentHistory;
        private Label lblPayment;
        private TextBox txtAdminSearch;
        private Button btnSearchStudentAdmn;
        private Button btnCashierOverview;
        private Button btnLogoutAdmin;
        private PictureBox pictureBox2;
        private Label lblReport;
        private Label lblStudentRegistration;
        private Label lblAssessment;
        private Label lblStudentInformation;
        private Label lblCashier;
        private PictureBox pictureBox1;
    }
}