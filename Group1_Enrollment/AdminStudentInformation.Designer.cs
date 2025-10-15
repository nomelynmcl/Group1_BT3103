namespace EventDriven.Project.UI
{
    partial class AdminStudentInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminStudentInformation));
            btnAdminStudInfoAdd = new Button();
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
            btnAdminStudInfoSearch = new Button();
            dtgAdminStudentInfoList = new DataGridView();
            txtAdminStudInfoSearch = new TextBox();
            btnAdminStudInfoEdit = new Button();
            btnAdminStudInfoView = new Button();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcAdminLogo2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgAdminStudentInfoList).BeginInit();
            SuspendLayout();
            // 
            // btnAdminStudInfoAdd
            // 
            btnAdminStudInfoAdd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnAdminStudInfoAdd.Location = new Point(283, 17);
            btnAdminStudInfoAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdminStudInfoAdd.Name = "btnAdminStudInfoAdd";
            btnAdminStudInfoAdd.Size = new Size(83, 25);
            btnAdminStudInfoAdd.TabIndex = 79;
            btnAdminStudInfoAdd.Text = "Add";
            btnAdminStudInfoAdd.UseVisualStyleBackColor = true;
            btnAdminStudInfoAdd.Click += btnAdminStudInfoAdd_Click;
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
            flowLayoutPanel1.TabIndex = 78;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
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
            // 
            // btnAdminStudentInformation2
            // 
            btnAdminStudentInformation2.BackColor = Color.DarkSlateGray;
            btnAdminStudentInformation2.FlatStyle = FlatStyle.Flat;
            btnAdminStudentInformation2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminStudentInformation2.ForeColor = SystemColors.ControlLight;
            btnAdminStudentInformation2.Location = new Point(20, 156);
            btnAdminStudentInformation2.Margin = new Padding(20, 10, 3, 3);
            btnAdminStudentInformation2.Name = "btnAdminStudentInformation2";
            btnAdminStudentInformation2.Size = new Size(211, 42);
            btnAdminStudentInformation2.TabIndex = 3;
            btnAdminStudentInformation2.Text = " STUDENT INFORMATION";
            btnAdminStudentInformation2.UseVisualStyleBackColor = false;
            btnAdminStudentInformation2.Click += button4_Click;
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
            btnAdminStudreg2.FlatStyle = FlatStyle.Flat;
            btnAdminStudreg2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminStudreg2.Location = new Point(20, 252);
            btnAdminStudreg2.Margin = new Padding(20, 3, 3, 3);
            btnAdminStudreg2.Name = "btnAdminStudreg2";
            btnAdminStudreg2.Size = new Size(211, 42);
            btnAdminStudreg2.TabIndex = 5;
            btnAdminStudreg2.Text = " STUDENT REGISTRATION";
            btnAdminStudreg2.UseVisualStyleBackColor = true;
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
            btnAdminOut2.Click += btnAdminOut2_Click;
            // 
            // btnAdminStudInfoSearch
            // 
            btnAdminStudInfoSearch.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnAdminStudInfoSearch.Location = new Point(903, 17);
            btnAdminStudInfoSearch.Margin = new Padding(3, 2, 3, 2);
            btnAdminStudInfoSearch.Name = "btnAdminStudInfoSearch";
            btnAdminStudInfoSearch.Size = new Size(122, 25);
            btnAdminStudInfoSearch.TabIndex = 47;
            btnAdminStudInfoSearch.Text = "Search Student";
            btnAdminStudInfoSearch.UseVisualStyleBackColor = true;
            btnAdminStudInfoSearch.Click += btnAdminStudInfoSearch_Click;
            // 
            // dtgAdminStudentInfoList
            // 
            dtgAdminStudentInfoList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgAdminStudentInfoList.Location = new Point(283, 56);
            dtgAdminStudentInfoList.Name = "dtgAdminStudentInfoList";
            dtgAdminStudentInfoList.Size = new Size(742, 512);
            dtgAdminStudentInfoList.TabIndex = 80;
            dtgAdminStudentInfoList.CellContentClick += dtgAdminStudentInfoList_CellContentClick;
            // 
            // txtAdminStudInfoSearch
            // 
            txtAdminStudInfoSearch.Location = new Point(621, 19);
            txtAdminStudInfoSearch.Name = "txtAdminStudInfoSearch";
            txtAdminStudInfoSearch.Size = new Size(276, 23);
            txtAdminStudInfoSearch.TabIndex = 81;
            // 
            // btnAdminStudInfoEdit
            // 
            btnAdminStudInfoEdit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnAdminStudInfoEdit.Location = new Point(372, 17);
            btnAdminStudInfoEdit.Margin = new Padding(3, 2, 3, 2);
            btnAdminStudInfoEdit.Name = "btnAdminStudInfoEdit";
            btnAdminStudInfoEdit.Size = new Size(83, 25);
            btnAdminStudInfoEdit.TabIndex = 82;
            btnAdminStudInfoEdit.Text = "Edit";
            btnAdminStudInfoEdit.UseVisualStyleBackColor = true;
            btnAdminStudInfoEdit.Click += btnAdminStudInfoEdit_Click;
            // 
            // btnAdminStudInfoView
            // 
            btnAdminStudInfoView.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnAdminStudInfoView.Location = new Point(461, 17);
            btnAdminStudInfoView.Margin = new Padding(3, 2, 3, 2);
            btnAdminStudInfoView.Name = "btnAdminStudInfoView";
            btnAdminStudInfoView.Size = new Size(83, 25);
            btnAdminStudInfoView.TabIndex = 83;
            btnAdminStudInfoView.Text = "View";
            btnAdminStudInfoView.UseVisualStyleBackColor = true;
            // 
            // AdminStudentInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1058, 522);
            Controls.Add(btnAdminStudInfoView);
            Controls.Add(btnAdminStudInfoEdit);
            Controls.Add(dtgAdminStudentInfoList);
            Controls.Add(txtAdminStudInfoSearch);
            Controls.Add(btnAdminStudInfoAdd);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnAdminStudInfoSearch);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AdminStudentInformation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin - Student Information";
            Load += AdminStudentInformation_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcAdminLogo2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgAdminStudentInfoList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdminStudInfoAdd;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private PictureBox pcAdminLogo2;
        private Button btnAdminStudInfoSearch;
        private DataGridView dtgAdminStudentInfoList;
        private TextBox txtAdminStudInfoSearch;
        private Button btnAdminStudentInformation2;
        private Button btnAdminAssessment2;
        private Button btnAdminStudreg2;
        private Button btnAdminPay2;
        private Button btnAdminHistory2;
        private Button btnAdminReport2;
        private Button btnAdminOut2;
        private Button btnAdminStudInfoEdit;
        private Button btnAdminStudInfoView;
    }
}