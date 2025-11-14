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
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(251, 522);
            flowLayoutPanel1.TabIndex = 87;
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
            btnAdminPay2.BackColor = Color.CadetBlue;
            btnAdminPay2.FlatStyle = FlatStyle.Flat;
            btnAdminPay2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminPay2.ForeColor = SystemColors.ActiveCaptionText;
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
            btnAdminReport2.BackColor = Color.DarkSlateGray;
            btnAdminReport2.FlatStyle = FlatStyle.Flat;
            btnAdminReport2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminReport2.ForeColor = SystemColors.Control;
            btnAdminReport2.Location = new Point(20, 245);
            btnAdminReport2.Margin = new Padding(20, 3, 3, 3);
            btnAdminReport2.Name = "btnAdminReport2";
            btnAdminReport2.Size = new Size(211, 42);
            btnAdminReport2.TabIndex = 8;
            btnAdminReport2.Text = "REPORT";
            btnAdminReport2.UseVisualStyleBackColor = false;
            // 
            // btnAdminOut2
            // 
            btnAdminOut2.BackColor = Color.CadetBlue;
            btnAdminOut2.FlatStyle = FlatStyle.Flat;
            btnAdminOut2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminOut2.ForeColor = SystemColors.ActiveCaptionText;
            btnAdminOut2.Location = new Point(20, 293);
            btnAdminOut2.Margin = new Padding(20, 3, 3, 3);
            btnAdminOut2.Name = "btnAdminOut2";
            btnAdminOut2.Size = new Size(211, 42);
            btnAdminOut2.TabIndex = 9;
            btnAdminOut2.Text = "LOG OUT";
            btnAdminOut2.UseVisualStyleBackColor = false;
            // 
            // SR_SOA_BTN
            // 
            SR_SOA_BTN.Location = new Point(923, 161);
            SR_SOA_BTN.Name = "SR_SOA_BTN";
            SR_SOA_BTN.Size = new Size(75, 23);
            SR_SOA_BTN.TabIndex = 101;
            SR_SOA_BTN.Text = "Search";
            SR_SOA_BTN.UseVisualStyleBackColor = true;
            // 
            // SR_SOA_TXTBOX
            // 
            SR_SOA_TXTBOX.Location = new Point(719, 161);
            SR_SOA_TXTBOX.Name = "SR_SOA_TXTBOX";
            SR_SOA_TXTBOX.Size = new Size(198, 23);
            SR_SOA_TXTBOX.TabIndex = 100;
            // 
            // SR_SOA_GRID
            // 
            SR_SOA_GRID.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SR_SOA_GRID.Location = new Point(333, 197);
            SR_SOA_GRID.Name = "SR_SOA_GRID";
            SR_SOA_GRID.Size = new Size(664, 265);
            SR_SOA_GRID.TabIndex = 99;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(333, 161);
            label1.Name = "label1";
            label1.Size = new Size(194, 20);
            label1.TabIndex = 98;
            label1.Text = "STATEMENT OF ACCOUNT";
            // 
            // SR_NOTD
            // 
            SR_NOTD.AutoSize = true;
            SR_NOTD.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SR_NOTD.Location = new Point(614, 55);
            SR_NOTD.Name = "SR_NOTD";
            SR_NOTD.Size = new Size(56, 65);
            SR_NOTD.TabIndex = 103;
            SR_NOTD.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(516, 17);
            label2.Name = "label2";
            label2.Size = new Size(250, 20);
            label2.TabIndex = 102;
            label2.Text = "NUMBER OF TRANSACTION DATE";
            // 
            // SR_PRINT_BTN
            // 
            SR_PRINT_BTN.Location = new Point(959, 487);
            SR_PRINT_BTN.Name = "SR_PRINT_BTN";
            SR_PRINT_BTN.Size = new Size(75, 23);
            SR_PRINT_BTN.TabIndex = 104;
            SR_PRINT_BTN.Text = "Print";
            SR_PRINT_BTN.UseVisualStyleBackColor = true;
            // 
            // CashierReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1058, 522);
            Controls.Add(SR_PRINT_BTN);
            Controls.Add(SR_NOTD);
            Controls.Add(label2);
            Controls.Add(SR_SOA_BTN);
            Controls.Add(SR_SOA_TXTBOX);
            Controls.Add(SR_SOA_GRID);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
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