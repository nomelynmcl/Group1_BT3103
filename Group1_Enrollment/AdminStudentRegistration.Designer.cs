namespace EventDriven.Project.UI
{
    partial class AdminStudentRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminStudentRegistration));
            btnEdit_AdminStudentRegis = new Button();
            dtgAdminStudentRegList = new DataGridView();
            txtSearch_AdminStudentRegis = new TextBox();
            btnAdd_AdminStudentRegis = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            pcAdminLogo2 = new PictureBox();
            btnAdminStudentInformation2 = new Button();
            btnAdminAssessment2 = new Button();
            btnAdminStudreg2 = new Button();
            btnAdminPay2 = new Button();
            btnAdminHistory2 = new Button();
            btnAdminReport2 = new Button();
            btnAdminOut2 = new Button();
            btnSearchStudent_AdminStudentRegis = new Button();
            btnView_AdminStudReg = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgAdminStudentRegList).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcAdminLogo2).BeginInit();
            SuspendLayout();
            // 
            // btnEdit_AdminStudentRegis
            // 
            btnEdit_AdminStudentRegis.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnEdit_AdminStudentRegis.Location = new Point(370, 17);
            btnEdit_AdminStudentRegis.Margin = new Padding(3, 2, 3, 2);
            btnEdit_AdminStudentRegis.Name = "btnEdit_AdminStudentRegis";
            btnEdit_AdminStudentRegis.Size = new Size(83, 25);
            btnEdit_AdminStudentRegis.TabIndex = 94;
            btnEdit_AdminStudentRegis.Text = "Edit";
            btnEdit_AdminStudentRegis.UseVisualStyleBackColor = true;
            btnEdit_AdminStudentRegis.Click += btnEdit_AdminStudentRegis_Click;
            // 
            // dtgAdminStudentRegList
            // 
            dtgAdminStudentRegList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgAdminStudentRegList.Location = new Point(281, 58);
            dtgAdminStudentRegList.Name = "dtgAdminStudentRegList";
            dtgAdminStudentRegList.RowHeadersWidth = 51;
            dtgAdminStudentRegList.Size = new Size(742, 512);
            dtgAdminStudentRegList.TabIndex = 92;
            // 
            // txtSearch_AdminStudentRegis
            // 
            txtSearch_AdminStudentRegis.Location = new Point(620, 16);
            txtSearch_AdminStudentRegis.Name = "txtSearch_AdminStudentRegis";
            txtSearch_AdminStudentRegis.Size = new Size(276, 23);
            txtSearch_AdminStudentRegis.TabIndex = 93;
            // 
            // btnAdd_AdminStudentRegis
            // 
            btnAdd_AdminStudentRegis.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnAdd_AdminStudentRegis.Location = new Point(281, 16);
            btnAdd_AdminStudentRegis.Margin = new Padding(3, 2, 3, 2);
            btnAdd_AdminStudentRegis.Name = "btnAdd_AdminStudentRegis";
            btnAdd_AdminStudentRegis.Size = new Size(83, 25);
            btnAdd_AdminStudentRegis.TabIndex = 91;
            btnAdd_AdminStudentRegis.Text = "Add";
            btnAdd_AdminStudentRegis.UseVisualStyleBackColor = true;
            btnAdd_AdminStudentRegis.Click += btnAdd_AdminStudentRegis_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.CadetBlue;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(btnAdminStudentInformation2);
            flowLayoutPanel1.Controls.Add(btnAdminAssessment2);
            flowLayoutPanel1.Controls.Add(btnAdminStudreg2);
            flowLayoutPanel1.Controls.Add(btnAdminPay2);
            flowLayoutPanel1.Controls.Add(btnAdminHistory2);
            flowLayoutPanel1.Controls.Add(btnAdminReport2);
            flowLayoutPanel1.Controls.Add(btnAdminOut2);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(251, 522);
            flowLayoutPanel1.TabIndex = 90;
            // 
            // panel1
            // 
            panel1.Controls.Add(pcAdminLogo2);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(248, 140);
            panel1.TabIndex = 0;
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
            pcAdminLogo2.Click += pcAdminLogo2_Click;
            // 
            // btnAdminStudentInformation2
            // 
            btnAdminStudentInformation2.BackColor = Color.CadetBlue;
            btnAdminStudentInformation2.FlatStyle = FlatStyle.Flat;
            btnAdminStudentInformation2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminStudentInformation2.ForeColor = SystemColors.ControlText;
            btnAdminStudentInformation2.Location = new Point(20, 156);
            btnAdminStudentInformation2.Margin = new Padding(20, 10, 3, 3);
            btnAdminStudentInformation2.Name = "btnAdminStudentInformation2";
            btnAdminStudentInformation2.Size = new Size(211, 42);
            btnAdminStudentInformation2.TabIndex = 3;
            btnAdminStudentInformation2.Text = " STUDENT INFORMATION";
            btnAdminStudentInformation2.UseVisualStyleBackColor = false;
            btnAdminStudentInformation2.Click += btnAdminStudentInformation2_Click;
            // 
            // btnAdminAssessment2
            // 
            btnAdminAssessment2.FlatStyle = FlatStyle.Flat;
            btnAdminAssessment2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminAssessment2.Location = new Point(20, 204);
            btnAdminAssessment2.Margin = new Padding(20, 3, 3, 3);
            btnAdminAssessment2.Name = "btnAdminAssessment2";
            btnAdminAssessment2.Size = new Size(211, 42);
            btnAdminAssessment2.TabIndex = 4;
            btnAdminAssessment2.Text = "ASSESSMENT";
            btnAdminAssessment2.UseVisualStyleBackColor = true;
            // 
            // btnAdminStudreg2
            // 
            btnAdminStudreg2.BackColor = Color.DarkSlateGray;
            btnAdminStudreg2.FlatStyle = FlatStyle.Flat;
            btnAdminStudreg2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminStudreg2.ForeColor = SystemColors.ControlLight;
            btnAdminStudreg2.Location = new Point(20, 252);
            btnAdminStudreg2.Margin = new Padding(20, 3, 3, 3);
            btnAdminStudreg2.Name = "btnAdminStudreg2";
            btnAdminStudreg2.Size = new Size(211, 42);
            btnAdminStudreg2.TabIndex = 5;
            btnAdminStudreg2.Text = " STUDENT REGISTRATION";
            btnAdminStudreg2.UseVisualStyleBackColor = false;
            // 
            // btnAdminPay2
            // 
            btnAdminPay2.FlatStyle = FlatStyle.Flat;
            btnAdminPay2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminPay2.Location = new Point(20, 300);
            btnAdminPay2.Margin = new Padding(20, 3, 3, 3);
            btnAdminPay2.Name = "btnAdminPay2";
            btnAdminPay2.Size = new Size(211, 42);
            btnAdminPay2.TabIndex = 6;
            btnAdminPay2.Text = "PAYMENT";
            btnAdminPay2.UseVisualStyleBackColor = true;
            // 
            // btnAdminHistory2
            // 
            btnAdminHistory2.FlatStyle = FlatStyle.Flat;
            btnAdminHistory2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminHistory2.Location = new Point(20, 348);
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
            btnAdminReport2.Location = new Point(20, 396);
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
            btnAdminOut2.Location = new Point(20, 444);
            btnAdminOut2.Margin = new Padding(20, 3, 3, 3);
            btnAdminOut2.Name = "btnAdminOut2";
            btnAdminOut2.Size = new Size(211, 42);
            btnAdminOut2.TabIndex = 9;
            btnAdminOut2.Text = "LOG OUT";
            btnAdminOut2.UseVisualStyleBackColor = true;
            // 
            // btnSearchStudent_AdminStudentRegis
            // 
            btnSearchStudent_AdminStudentRegis.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSearchStudent_AdminStudentRegis.Location = new Point(901, 15);
            btnSearchStudent_AdminStudentRegis.Margin = new Padding(3, 2, 3, 2);
            btnSearchStudent_AdminStudentRegis.Name = "btnSearchStudent_AdminStudentRegis";
            btnSearchStudent_AdminStudentRegis.Size = new Size(122, 25);
            btnSearchStudent_AdminStudentRegis.TabIndex = 89;
            btnSearchStudent_AdminStudentRegis.Text = "Search Student";
            btnSearchStudent_AdminStudentRegis.UseVisualStyleBackColor = true;
            btnSearchStudent_AdminStudentRegis.Click += btnSearchStudent_AdminStudentRegis_Click;
            // 
            // btnView_AdminStudReg
            // 
            btnView_AdminStudReg.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnView_AdminStudReg.Location = new Point(459, 16);
            btnView_AdminStudReg.Margin = new Padding(3, 2, 3, 2);
            btnView_AdminStudReg.Name = "btnView_AdminStudReg";
            btnView_AdminStudReg.Size = new Size(83, 25);
            btnView_AdminStudReg.TabIndex = 95;
            btnView_AdminStudReg.Text = "View";
            btnView_AdminStudReg.UseVisualStyleBackColor = true;
            btnView_AdminStudReg.Click += btnView_AdminStudReg_Click;
            // 
            // AdminStudentRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1058, 522);
            Controls.Add(btnView_AdminStudReg);
            Controls.Add(btnEdit_AdminStudentRegis);
            Controls.Add(dtgAdminStudentRegList);
            Controls.Add(txtSearch_AdminStudentRegis);
            Controls.Add(btnAdd_AdminStudentRegis);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnSearchStudent_AdminStudentRegis);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AdminStudentRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminStudentRegistration";
            Load += AdminStudentRegistration_Load;
            ((System.ComponentModel.ISupportInitialize)dtgAdminStudentRegList).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcAdminLogo2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEdit_AdminStudentRegis;
        private DataGridView dtgAdminStudentRegList;
        private TextBox txtSearch_AdminStudentRegis;
        private Button btnAdd_AdminStudentRegis;
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
        private Button btnSearchStudent_AdminStudentRegis;
        private Button btnView_AdminStudReg;
    }
}