namespace EventDriven.Project.UI
{
    partial class RegistrarStudentRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarStudentRegistration));
            btnRegistrarStudReg_Edit = new Button();
            dtgRegistrar_StudRegList = new DataGridView();
            txtRegistrarStudReg_Search = new TextBox();
            btnRegistrarStudReg_Add = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            pcRegistrarLogo2 = new PictureBox();
            btnRegistrar_StudInfo = new Button();
            btnRegistrar_Assessment = new Button();
            btnRegistrar_StudRegistration = new Button();
            btnRegistrar_Pay = new Button();
            btnRegistrar_PayHistory = new Button();
            btnRegistrar_Report = new Button();
            btnRegistrar_Out = new Button();
            btnRegistrarStudReg_View = new Button();
            btnRegistrarStudReg_Search = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgRegistrar_StudRegList).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcRegistrarLogo2).BeginInit();
            SuspendLayout();
            // 
            // btnRegistrarStudReg_Edit
            // 
            btnRegistrarStudReg_Edit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnRegistrarStudReg_Edit.Location = new Point(377, 20);
            btnRegistrarStudReg_Edit.Margin = new Padding(3, 2, 3, 2);
            btnRegistrarStudReg_Edit.Name = "btnRegistrarStudReg_Edit";
            btnRegistrarStudReg_Edit.Size = new Size(83, 25);
            btnRegistrarStudReg_Edit.TabIndex = 95;
            btnRegistrarStudReg_Edit.Text = "Edit";
            btnRegistrarStudReg_Edit.UseVisualStyleBackColor = true;
            btnRegistrarStudReg_Edit.Click += btnRegistrarStudReg_Edit_Click;
            // 
            // dtgRegistrar_StudRegList
            // 
            dtgRegistrar_StudRegList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgRegistrar_StudRegList.Location = new Point(288, 61);
            dtgRegistrar_StudRegList.Name = "dtgRegistrar_StudRegList";
            dtgRegistrar_StudRegList.RowHeadersWidth = 51;
            dtgRegistrar_StudRegList.Size = new Size(742, 512);
            dtgRegistrar_StudRegList.TabIndex = 93;
            // 
            // txtRegistrarStudReg_Search
            // 
            txtRegistrarStudReg_Search.Location = new Point(626, 19);
            txtRegistrarStudReg_Search.Name = "txtRegistrarStudReg_Search";
            txtRegistrarStudReg_Search.Size = new Size(276, 23);
            txtRegistrarStudReg_Search.TabIndex = 94;
            // 
            // btnRegistrarStudReg_Add
            // 
            btnRegistrarStudReg_Add.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnRegistrarStudReg_Add.Location = new Point(288, 19);
            btnRegistrarStudReg_Add.Margin = new Padding(3, 2, 3, 2);
            btnRegistrarStudReg_Add.Name = "btnRegistrarStudReg_Add";
            btnRegistrarStudReg_Add.Size = new Size(83, 25);
            btnRegistrarStudReg_Add.TabIndex = 92;
            btnRegistrarStudReg_Add.Text = "Add";
            btnRegistrarStudReg_Add.UseVisualStyleBackColor = true;
            btnRegistrarStudReg_Add.Click += btnRegistrarStudReg_Add_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.CadetBlue;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(btnRegistrar_StudInfo);
            flowLayoutPanel1.Controls.Add(btnRegistrar_Assessment);
            flowLayoutPanel1.Controls.Add(btnRegistrar_StudRegistration);
            flowLayoutPanel1.Controls.Add(btnRegistrar_Pay);
            flowLayoutPanel1.Controls.Add(btnRegistrar_PayHistory);
            flowLayoutPanel1.Controls.Add(btnRegistrar_Report);
            flowLayoutPanel1.Controls.Add(btnRegistrar_Out);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(251, 522);
            flowLayoutPanel1.TabIndex = 91;
            // 
            // panel1
            // 
            panel1.Controls.Add(pcRegistrarLogo2);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(248, 140);
            panel1.TabIndex = 0;
            // 
            // pcRegistrarLogo2
            // 
            pcRegistrarLogo2.BackColor = Color.CadetBlue;
            pcRegistrarLogo2.Image = (Image)resources.GetObject("pcRegistrarLogo2.Image");
            pcRegistrarLogo2.Location = new Point(44, 14);
            pcRegistrarLogo2.Name = "pcRegistrarLogo2";
            pcRegistrarLogo2.Size = new Size(154, 126);
            pcRegistrarLogo2.SizeMode = PictureBoxSizeMode.StretchImage;
            pcRegistrarLogo2.TabIndex = 0;
            pcRegistrarLogo2.TabStop = false;
            pcRegistrarLogo2.Click += pcRegistrarLogo2_Click;
            // 
            // btnRegistrar_StudInfo
            // 
            btnRegistrar_StudInfo.BackColor = Color.CadetBlue;
            btnRegistrar_StudInfo.FlatStyle = FlatStyle.Flat;
            btnRegistrar_StudInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar_StudInfo.ForeColor = SystemColors.ControlText;
            btnRegistrar_StudInfo.Location = new Point(20, 156);
            btnRegistrar_StudInfo.Margin = new Padding(20, 10, 3, 3);
            btnRegistrar_StudInfo.Name = "btnRegistrar_StudInfo";
            btnRegistrar_StudInfo.Size = new Size(211, 42);
            btnRegistrar_StudInfo.TabIndex = 3;
            btnRegistrar_StudInfo.Text = " STUDENT INFORMATION";
            btnRegistrar_StudInfo.UseVisualStyleBackColor = false;
            btnRegistrar_StudInfo.Click += btnRegistrarStudentInformation_Click;
            // 
            // btnRegistrar_Assessment
            // 
            btnRegistrar_Assessment.FlatStyle = FlatStyle.Flat;
            btnRegistrar_Assessment.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar_Assessment.Location = new Point(20, 204);
            btnRegistrar_Assessment.Margin = new Padding(20, 3, 3, 3);
            btnRegistrar_Assessment.Name = "btnRegistrar_Assessment";
            btnRegistrar_Assessment.Size = new Size(211, 42);
            btnRegistrar_Assessment.TabIndex = 4;
            btnRegistrar_Assessment.Text = "ASSESSMENT";
            btnRegistrar_Assessment.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar_StudRegistration
            // 
            btnRegistrar_StudRegistration.BackColor = Color.DarkSlateGray;
            btnRegistrar_StudRegistration.FlatStyle = FlatStyle.Flat;
            btnRegistrar_StudRegistration.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar_StudRegistration.ForeColor = SystemColors.ControlLight;
            btnRegistrar_StudRegistration.Location = new Point(20, 252);
            btnRegistrar_StudRegistration.Margin = new Padding(20, 3, 3, 3);
            btnRegistrar_StudRegistration.Name = "btnRegistrar_StudRegistration";
            btnRegistrar_StudRegistration.Size = new Size(211, 42);
            btnRegistrar_StudRegistration.TabIndex = 5;
            btnRegistrar_StudRegistration.Text = " STUDENT REGISTRATION";
            btnRegistrar_StudRegistration.UseVisualStyleBackColor = false;
            // 
            // btnRegistrar_Pay
            // 
            btnRegistrar_Pay.FlatStyle = FlatStyle.Flat;
            btnRegistrar_Pay.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar_Pay.Location = new Point(20, 300);
            btnRegistrar_Pay.Margin = new Padding(20, 3, 3, 3);
            btnRegistrar_Pay.Name = "btnRegistrar_Pay";
            btnRegistrar_Pay.Size = new Size(211, 42);
            btnRegistrar_Pay.TabIndex = 6;
            btnRegistrar_Pay.Text = "PAYMENT";
            btnRegistrar_Pay.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar_PayHistory
            // 
            btnRegistrar_PayHistory.FlatStyle = FlatStyle.Flat;
            btnRegistrar_PayHistory.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar_PayHistory.Location = new Point(20, 348);
            btnRegistrar_PayHistory.Margin = new Padding(20, 3, 3, 3);
            btnRegistrar_PayHistory.Name = "btnRegistrar_PayHistory";
            btnRegistrar_PayHistory.Size = new Size(211, 42);
            btnRegistrar_PayHistory.TabIndex = 7;
            btnRegistrar_PayHistory.Text = "PAYMENT HISTORY";
            btnRegistrar_PayHistory.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar_Report
            // 
            btnRegistrar_Report.FlatStyle = FlatStyle.Flat;
            btnRegistrar_Report.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar_Report.Location = new Point(20, 396);
            btnRegistrar_Report.Margin = new Padding(20, 3, 3, 3);
            btnRegistrar_Report.Name = "btnRegistrar_Report";
            btnRegistrar_Report.Size = new Size(211, 42);
            btnRegistrar_Report.TabIndex = 8;
            btnRegistrar_Report.Text = "REPORT";
            btnRegistrar_Report.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar_Out
            // 
            btnRegistrar_Out.FlatStyle = FlatStyle.Flat;
            btnRegistrar_Out.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar_Out.Location = new Point(20, 444);
            btnRegistrar_Out.Margin = new Padding(20, 3, 3, 3);
            btnRegistrar_Out.Name = "btnRegistrar_Out";
            btnRegistrar_Out.Size = new Size(211, 42);
            btnRegistrar_Out.TabIndex = 9;
            btnRegistrar_Out.Text = "LOG OUT";
            btnRegistrar_Out.UseVisualStyleBackColor = true;
            btnRegistrar_Out.Click += btnRegistrarOut_Click;
            // 
            // btnRegistrarStudReg_View
            // 
            btnRegistrarStudReg_View.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnRegistrarStudReg_View.Location = new Point(466, 20);
            btnRegistrarStudReg_View.Margin = new Padding(3, 2, 3, 2);
            btnRegistrarStudReg_View.Name = "btnRegistrarStudReg_View";
            btnRegistrarStudReg_View.Size = new Size(83, 25);
            btnRegistrarStudReg_View.TabIndex = 96;
            btnRegistrarStudReg_View.Text = "View";
            btnRegistrarStudReg_View.UseVisualStyleBackColor = true;
            btnRegistrarStudReg_View.Click += btnRegistrarStudReg_View_Click;
            // 
            // btnRegistrarStudReg_Search
            // 
            btnRegistrarStudReg_Search.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnRegistrarStudReg_Search.Location = new Point(908, 18);
            btnRegistrarStudReg_Search.Margin = new Padding(3, 2, 3, 2);
            btnRegistrarStudReg_Search.Name = "btnRegistrarStudReg_Search";
            btnRegistrarStudReg_Search.Size = new Size(122, 25);
            btnRegistrarStudReg_Search.TabIndex = 90;
            btnRegistrarStudReg_Search.Text = "Search Student";
            btnRegistrarStudReg_Search.UseVisualStyleBackColor = true;
            btnRegistrarStudReg_Search.Click += btnRegistrarStudReg_Search_Click;
            // 
            // RegistrarStudentRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1058, 522);
            Controls.Add(btnRegistrarStudReg_Edit);
            Controls.Add(dtgRegistrar_StudRegList);
            Controls.Add(txtRegistrarStudReg_Search);
            Controls.Add(btnRegistrarStudReg_Add);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnRegistrarStudReg_View);
            Controls.Add(btnRegistrarStudReg_Search);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RegistrarStudentRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar Student Registration";
            Load += RegistrarStudentRegistration_Load;
            ((System.ComponentModel.ISupportInitialize)dtgRegistrar_StudRegList).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcRegistrarLogo2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrarStudReg_Edit;
        private DataGridView dtgRegistrar_StudRegList;
        private TextBox txtRegistrarStudReg_Search;
        private Button btnRegistrarStudReg_Add;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private PictureBox pcRegistrarLogo2;
        private Button btnRegistrar_StudInfo;
        private Button btnRegistrar_Assessment;
        private Button btnRegistrar_StudRegistration;
        private Button btnRegistrar_Pay;
        private Button btnRegistrar_PayHistory;
        private Button btnRegistrar_Report;
        private Button btnRegistrar_Out;
        private Button btnRegistrarStudReg_View;
        private Button btnRegistrarStudReg_Search;
    }
}