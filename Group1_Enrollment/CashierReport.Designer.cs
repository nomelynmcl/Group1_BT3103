namespace EventDriven.Project.UI
{
    partial class CashierReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierReport));
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            CashLabel = new Label();
            pcAdminLogo2 = new PictureBox();
            btnAdminPay2 = new Button();
            btnAdminHistory2 = new Button();
            btnAdminReport2 = new Button();
            btnAdminOut2 = new Button();
            SR_SOA_BTN = new Button();
            SR_SOA_TXTBOX = new TextBox();
            SR_SOA_GRID = new DataGridView();
            label1 = new Label();
            SR_NOTD = new Label();
            label2 = new Label();
            SR_PRINT_BTN = new Button();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcAdminLogo2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SR_SOA_GRID).BeginInit();
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
            pcAdminLogo2.Click += pcAdminLogo2_Click;
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
            btnAdminReport2.BackColor = Color.DarkSlateGray;
            btnAdminReport2.FlatStyle = FlatStyle.Flat;
            btnAdminReport2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnAdminReport2.ForeColor = Color.AliceBlue;
            btnAdminReport2.Location = new Point(23, 463);
            btnAdminReport2.Margin = new Padding(23, 4, 3, 4);
            btnAdminReport2.Name = "btnAdminReport2";
            btnAdminReport2.Size = new Size(421, 79);
            btnAdminReport2.TabIndex = 8;
            btnAdminReport2.Text = "REPORT";
            btnAdminReport2.UseVisualStyleBackColor = false;
            // 
            // btnAdminOut2
            // 
            btnAdminOut2.BackColor = Color.CadetBlue;
            btnAdminOut2.FlatStyle = FlatStyle.Flat;
            btnAdminOut2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnAdminOut2.ForeColor = Color.AliceBlue;
            btnAdminOut2.Location = new Point(23, 550);
            btnAdminOut2.Margin = new Padding(23, 4, 3, 4);
            btnAdminOut2.Name = "btnAdminOut2";
            btnAdminOut2.Size = new Size(421, 79);
            btnAdminOut2.TabIndex = 9;
            btnAdminOut2.Text = "LOG OUT";
            btnAdminOut2.UseVisualStyleBackColor = false;
            btnAdminOut2.Click += btnAdminOut2_Click;
            // 
            // SR_SOA_BTN
            // 
            SR_SOA_BTN.BackColor = Color.CadetBlue;
            SR_SOA_BTN.Font = new Font("Segoe UI", 14F);
            SR_SOA_BTN.Location = new Point(585, 261);
            SR_SOA_BTN.Margin = new Padding(3, 4, 3, 4);
            SR_SOA_BTN.Name = "SR_SOA_BTN";
            SR_SOA_BTN.Size = new Size(154, 54);
            SR_SOA_BTN.TabIndex = 101;
            SR_SOA_BTN.Text = "Search";
            SR_SOA_BTN.UseVisualStyleBackColor = false;
            SR_SOA_BTN.Click += SR_SOA_BTN_Click;
            // 
            // SR_SOA_TXTBOX
            // 
            SR_SOA_TXTBOX.Font = new Font("Segoe UI", 14F);
            SR_SOA_TXTBOX.Location = new Point(745, 263);
            SR_SOA_TXTBOX.Margin = new Padding(3, 4, 3, 4);
            SR_SOA_TXTBOX.Multiline = true;
            SR_SOA_TXTBOX.Name = "SR_SOA_TXTBOX";
            SR_SOA_TXTBOX.Size = new Size(1050, 48);
            SR_SOA_TXTBOX.TabIndex = 100;
            // 
            // SR_SOA_GRID
            // 
            SR_SOA_GRID.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SR_SOA_GRID.Location = new Point(585, 431);
            SR_SOA_GRID.Margin = new Padding(3, 4, 3, 4);
            SR_SOA_GRID.Name = "SR_SOA_GRID";
            SR_SOA_GRID.RowHeadersWidth = 51;
            SR_SOA_GRID.Size = new Size(1210, 410);
            SR_SOA_GRID.TabIndex = 99;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(585, 362);
            label1.Name = "label1";
            label1.Size = new Size(308, 32);
            label1.TabIndex = 98;
            label1.Text = "STATEMENT OF ACCOUNT";
            // 
            // SR_NOTD
            // 
            SR_NOTD.AutoSize = true;
            SR_NOTD.Font = new Font("Segoe UI", 46F, FontStyle.Bold);
            SR_NOTD.Location = new Point(1152, 106);
            SR_NOTD.Name = "SR_NOTD";
            SR_NOTD.Size = new Size(87, 102);
            SR_NOTD.TabIndex = 103;
            SR_NOTD.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(997, 59);
            label2.Name = "label2";
            label2.Size = new Size(398, 32);
            label2.TabIndex = 102;
            label2.Text = "NUMBER OF TRANSACTION DATE";
            // 
            // SR_PRINT_BTN
            // 
            SR_PRINT_BTN.BackColor = Color.CadetBlue;
            SR_PRINT_BTN.Font = new Font("Segoe UI", 14F);
            SR_PRINT_BTN.ForeColor = Color.AliceBlue;
            SR_PRINT_BTN.Location = new Point(1113, 913);
            SR_PRINT_BTN.Margin = new Padding(3, 4, 3, 4);
            SR_PRINT_BTN.Name = "SR_PRINT_BTN";
            SR_PRINT_BTN.Size = new Size(154, 54);
            SR_PRINT_BTN.TabIndex = 104;
            SR_PRINT_BTN.Text = "Print";
            SR_PRINT_BTN.UseVisualStyleBackColor = false;
            SR_PRINT_BTN.Click += SR_PRINT_BTN_Click;
            // 
            // CashierReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1902, 1033);
            Controls.Add(SR_PRINT_BTN);
            Controls.Add(SR_NOTD);
            Controls.Add(label2);
            Controls.Add(SR_SOA_BTN);
            Controls.Add(SR_SOA_TXTBOX);
            Controls.Add(SR_SOA_GRID);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CashierReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CashierReport";
            Load += CashierReport_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcAdminLogo2).EndInit();
            ((System.ComponentModel.ISupportInitialize)SR_SOA_GRID).EndInit();
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
        private Button SR_SOA_BTN;
        private TextBox SR_SOA_TXTBOX;
        private DataGridView SR_SOA_GRID;
        private Label label1;
        private Label SR_NOTD;
        private Label label2;
        private Button SR_PRINT_BTN;
    }
}