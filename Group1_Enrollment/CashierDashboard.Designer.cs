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
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            CashLabel = new Label();
            pcAdminLogo2 = new PictureBox();
            btnAdminPay2 = new Button();
            btnAdminHistory2 = new Button();
            btnAdminReport2 = new Button();
            btnAdminOut2 = new Button();
            dtgCashier = new DataGridView();
            cbSyear = new ComboBox();
            label1 = new Label();
            btnSearch = new Button();
            txtSearch = new TextBox();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcAdminLogo2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgCashier).BeginInit();
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
            flowLayoutPanel1.TabIndex = 87;
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
            // 
            // btnAdminPay2
            // 
            btnAdminPay2.BackColor = Color.CadetBlue;
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
            btnAdminPay2.Click += btnAdminPay2_Click;
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
            // dtgCashier
            // 
            dtgCashier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgCashier.Location = new Point(524, 109);
            dtgCashier.Margin = new Padding(3, 4, 3, 4);
            dtgCashier.Name = "dtgCashier";
            dtgCashier.RowHeadersWidth = 51;
            dtgCashier.Size = new Size(1332, 924);
            dtgCashier.TabIndex = 97;
            // 
            // cbSyear
            // 
            cbSyear.FormattingEnabled = true;
            cbSyear.Items.AddRange(new object[] { "2024-2025", "2025-2026" });
            cbSyear.Location = new Point(849, 53);
            cbSyear.Name = "cbSyear";
            cbSyear.Size = new Size(234, 28);
            cbSyear.TabIndex = 96;
            cbSyear.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(524, 42);
            label1.Name = "label1";
            label1.Size = new Size(307, 38);
            label1.TabIndex = 95;
            label1.Text = "ENROLLED STUDENTS";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.CadetBlue;
            btnSearch.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = SystemColors.Control;
            btnSearch.Location = new Point(1743, 46);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(113, 37);
            btnSearch.TabIndex = 98;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(1360, 52);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(377, 27);
            txtSearch.TabIndex = 99;
            // 
            // CashierDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1902, 1033);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(dtgCashier);
            Controls.Add(cbSyear);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Name = "CashierDashboard";
            Text = "CashierDashboard";
            Load += CashierDashboard_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcAdminLogo2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgCashier).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label CashLabel;
        private PictureBox pcAdminLogo2;
        private Button btnAdminPay2;
        private Button btnAdminHistory2;
        private Button btnAdminReport2;
        private Button btnAdminOut2;
        private DataGridView dtgCashier;
        private ComboBox cbSyear;
        private Label label1;
        private Button btnSearch;
        private TextBox txtSearch;
    }
}