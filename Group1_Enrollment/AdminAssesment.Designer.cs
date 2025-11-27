namespace EventDriven.Project.UI
{
    partial class AdminAssesment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAssesment));
            btnAdminStudInfoView = new Button();
            txtAdminStudInfoSearch = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            pcAdminLogo2 = new PictureBox();
            btnAdminStudentInformation2 = new Button();
            btnAdminStudreg2 = new Button();
            btnAdminPay2 = new Button();
            btnAdminAssessment2 = new Button();
            btnAdminHistory2 = new Button();
            btnAdminReport2 = new Button();
            btnAdminOut2 = new Button();
            btnAdminStudInfoSearch = new Button();
            dtgAdminAssessment = new DataGridView();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcAdminLogo2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgAdminAssessment).BeginInit();
            SuspendLayout();
            // 
            // btnAdminStudInfoView
            // 
            btnAdminStudInfoView.BackColor = Color.CadetBlue;
            btnAdminStudInfoView.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            btnAdminStudInfoView.ForeColor = Color.AliceBlue;
            btnAdminStudInfoView.Location = new Point(526, 46);
            btnAdminStudInfoView.Name = "btnAdminStudInfoView";
            btnAdminStudInfoView.Size = new Size(154, 54);
            btnAdminStudInfoView.TabIndex = 90;
            btnAdminStudInfoView.Text = "View  Assessment";
            btnAdminStudInfoView.UseVisualStyleBackColor = false;
            btnAdminStudInfoView.Click += btnAdminStudInfoView_Click;
            // 
            // txtAdminStudInfoSearch
            // 
            txtAdminStudInfoSearch.Font = new Font("Segoe UI", 14F);
            txtAdminStudInfoSearch.Location = new Point(1045, 47);
            txtAdminStudInfoSearch.Margin = new Padding(3, 4, 3, 4);
            txtAdminStudInfoSearch.Multiline = true;
            txtAdminStudInfoSearch.Name = "txtAdminStudInfoSearch";
            txtAdminStudInfoSearch.Size = new Size(590, 48);
            txtAdminStudInfoSearch.TabIndex = 88;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.CadetBlue;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(btnAdminStudentInformation2);
            flowLayoutPanel1.Controls.Add(btnAdminStudreg2);
            flowLayoutPanel1.Controls.Add(btnAdminPay2);
            flowLayoutPanel1.Controls.Add(btnAdminAssessment2);
            flowLayoutPanel1.Controls.Add(btnAdminHistory2);
            flowLayoutPanel1.Controls.Add(btnAdminReport2);
            flowLayoutPanel1.Controls.Add(btnAdminOut2);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(474, 1033);
            flowLayoutPanel1.TabIndex = 85;
            // 
            // panel1
            // 
            panel1.Controls.Add(pcAdminLogo2);
            panel1.Location = new Point(3, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(458, 277);
            panel1.TabIndex = 0;
            // 
            // pcAdminLogo2
            // 
            pcAdminLogo2.BackColor = Color.CadetBlue;
            pcAdminLogo2.Image = (Image)resources.GetObject("pcAdminLogo2.Image");
            pcAdminLogo2.Location = new Point(56, 27);
            pcAdminLogo2.Margin = new Padding(3, 4, 3, 4);
            pcAdminLogo2.Name = "pcAdminLogo2";
            pcAdminLogo2.Size = new Size(333, 239);
            pcAdminLogo2.SizeMode = PictureBoxSizeMode.StretchImage;
            pcAdminLogo2.TabIndex = 0;
            pcAdminLogo2.TabStop = false;
            pcAdminLogo2.Click += pcAdminLogo2_Click;
            // 
            // btnAdminStudentInformation2
            // 
            btnAdminStudentInformation2.BackColor = Color.CadetBlue;
            btnAdminStudentInformation2.FlatStyle = FlatStyle.Flat;
            btnAdminStudentInformation2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnAdminStudentInformation2.ForeColor = Color.AliceBlue;
            btnAdminStudentInformation2.Location = new Point(23, 298);
            btnAdminStudentInformation2.Margin = new Padding(23, 13, 3, 4);
            btnAdminStudentInformation2.Name = "btnAdminStudentInformation2";
            btnAdminStudentInformation2.Size = new Size(421, 79);
            btnAdminStudentInformation2.TabIndex = 3;
            btnAdminStudentInformation2.Text = " STUDENT INFORMATION";
            btnAdminStudentInformation2.UseVisualStyleBackColor = false;
            btnAdminStudentInformation2.Click += btnAdminStudentInformation2_Click;
            // 
            // btnAdminStudreg2
            // 
            btnAdminStudreg2.FlatStyle = FlatStyle.Flat;
            btnAdminStudreg2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnAdminStudreg2.ForeColor = Color.AliceBlue;
            btnAdminStudreg2.Location = new Point(23, 385);
            btnAdminStudreg2.Margin = new Padding(23, 4, 3, 4);
            btnAdminStudreg2.Name = "btnAdminStudreg2";
            btnAdminStudreg2.Size = new Size(421, 79);
            btnAdminStudreg2.TabIndex = 5;
            btnAdminStudreg2.Text = " STUDENT REGISTRATION";
            btnAdminStudreg2.UseVisualStyleBackColor = true;
            btnAdminStudreg2.Click += btnAdminStudreg2_Click;
            // 
            // btnAdminPay2
            // 
            btnAdminPay2.FlatStyle = FlatStyle.Flat;
            btnAdminPay2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnAdminPay2.ForeColor = Color.AliceBlue;
            btnAdminPay2.Location = new Point(23, 472);
            btnAdminPay2.Margin = new Padding(23, 4, 3, 4);
            btnAdminPay2.Name = "btnAdminPay2";
            btnAdminPay2.Size = new Size(421, 79);
            btnAdminPay2.TabIndex = 6;
            btnAdminPay2.Text = "PAYMENT";
            btnAdminPay2.UseVisualStyleBackColor = true;
            btnAdminPay2.Click += btnAdminPay2_Click;
            // 
            // btnAdminAssessment2
            // 
            btnAdminAssessment2.BackColor = Color.DarkSlateGray;
            btnAdminAssessment2.FlatStyle = FlatStyle.Flat;
            btnAdminAssessment2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnAdminAssessment2.ForeColor = Color.AliceBlue;
            btnAdminAssessment2.Location = new Point(23, 559);
            btnAdminAssessment2.Margin = new Padding(23, 4, 3, 4);
            btnAdminAssessment2.Name = "btnAdminAssessment2";
            btnAdminAssessment2.Size = new Size(421, 79);
            btnAdminAssessment2.TabIndex = 4;
            btnAdminAssessment2.Text = "ASSESSMENT";
            btnAdminAssessment2.UseVisualStyleBackColor = false;
            // 
            // btnAdminHistory2
            // 
            btnAdminHistory2.FlatStyle = FlatStyle.Flat;
            btnAdminHistory2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnAdminHistory2.ForeColor = Color.AliceBlue;
            btnAdminHistory2.Location = new Point(23, 646);
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
            btnAdminReport2.Location = new Point(23, 733);
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
            btnAdminOut2.Location = new Point(23, 820);
            btnAdminOut2.Margin = new Padding(23, 4, 3, 4);
            btnAdminOut2.Name = "btnAdminOut2";
            btnAdminOut2.Size = new Size(421, 79);
            btnAdminOut2.TabIndex = 9;
            btnAdminOut2.Text = "LOG OUT";
            btnAdminOut2.UseVisualStyleBackColor = true;
            btnAdminOut2.Click += btnAdminOut2_Click;
            // 
            // btnAdminStudInfoSearch
            // 
            btnAdminStudInfoSearch.BackColor = Color.CadetBlue;
            btnAdminStudInfoSearch.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnAdminStudInfoSearch.ForeColor = Color.AliceBlue;
            btnAdminStudInfoSearch.Location = new Point(1657, 46);
            btnAdminStudInfoSearch.Name = "btnAdminStudInfoSearch";
            btnAdminStudInfoSearch.Size = new Size(201, 50);
            btnAdminStudInfoSearch.TabIndex = 84;
            btnAdminStudInfoSearch.Text = "Search Student";
            btnAdminStudInfoSearch.UseVisualStyleBackColor = false;
            btnAdminStudInfoSearch.Click += btnAdminStudInfoSearch_Click;
            // 
            // dtgAdminAssessment
            // 
            dtgAdminAssessment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgAdminAssessment.Location = new Point(526, 138);
            dtgAdminAssessment.Margin = new Padding(3, 4, 3, 4);
            dtgAdminAssessment.Name = "dtgAdminAssessment";
            dtgAdminAssessment.RowHeadersWidth = 51;
            dtgAdminAssessment.Size = new Size(1332, 895);
            dtgAdminAssessment.TabIndex = 87;
            // 
            // AdminAssesment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1902, 1033);
            Controls.Add(btnAdminStudInfoView);
            Controls.Add(dtgAdminAssessment);
            Controls.Add(txtAdminStudInfoSearch);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnAdminStudInfoSearch);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AdminAssesment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Assesment";
            Load += AdminAssesment_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcAdminLogo2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgAdminAssessment).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdminStudInfoView;
        private TextBox txtAdminStudInfoSearch;
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
        private Button btnAdminStudInfoSearch;
        private DataGridView dtgAdminAssessment;
    }
}