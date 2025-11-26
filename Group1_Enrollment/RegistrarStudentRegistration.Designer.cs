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
            dtgRegistrar_StudRegList = new DataGridView();
            txtRegistrarStudReg_Search = new TextBox();
            btnRegistrarStudReg_Add = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            pcRegistrarLogo2 = new PictureBox();
            btnRegistrar_StudInfo = new Button();
            btnRegistrar_StudRegistration = new Button();
            btnRegistrar_Assessment = new Button();
            btnRegistrar_Report = new Button();
            btnRegistrar_Out = new Button();
            btnRegistrarStudReg_Search = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgRegistrar_StudRegList).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcRegistrarLogo2).BeginInit();
            SuspendLayout();
            // 
            // dtgRegistrar_StudRegList
            // 
            dtgRegistrar_StudRegList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgRegistrar_StudRegList.Location = new Point(526, 138);
            dtgRegistrar_StudRegList.Margin = new Padding(3, 4, 3, 4);
            dtgRegistrar_StudRegList.Name = "dtgRegistrar_StudRegList";
            dtgRegistrar_StudRegList.RowHeadersWidth = 51;
            dtgRegistrar_StudRegList.Size = new Size(1332, 895);
            dtgRegistrar_StudRegList.TabIndex = 93;
            // 
            // txtRegistrarStudReg_Search
            // 
            txtRegistrarStudReg_Search.Font = new Font("Segoe UI", 14F);
            txtRegistrarStudReg_Search.Location = new Point(1125, 47);
            txtRegistrarStudReg_Search.Margin = new Padding(3, 4, 3, 4);
            txtRegistrarStudReg_Search.Multiline = true;
            txtRegistrarStudReg_Search.Name = "txtRegistrarStudReg_Search";
            txtRegistrarStudReg_Search.Size = new Size(510, 48);
            txtRegistrarStudReg_Search.TabIndex = 94;
            // 
            // btnRegistrarStudReg_Add
            // 
            btnRegistrarStudReg_Add.BackColor = Color.CadetBlue;
            btnRegistrarStudReg_Add.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnRegistrarStudReg_Add.ForeColor = Color.AliceBlue;
            btnRegistrarStudReg_Add.Location = new Point(526, 46);
            btnRegistrarStudReg_Add.Name = "btnRegistrarStudReg_Add";
            btnRegistrarStudReg_Add.Size = new Size(154, 54);
            btnRegistrarStudReg_Add.TabIndex = 92;
            btnRegistrarStudReg_Add.Text = "Register";
            btnRegistrarStudReg_Add.UseVisualStyleBackColor = false;
            btnRegistrarStudReg_Add.Click += btnRegistrarStudReg_Add_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.CadetBlue;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(btnRegistrar_StudInfo);
            flowLayoutPanel1.Controls.Add(btnRegistrar_StudRegistration);
            flowLayoutPanel1.Controls.Add(btnRegistrar_Assessment);
            flowLayoutPanel1.Controls.Add(btnRegistrar_Report);
            flowLayoutPanel1.Controls.Add(btnRegistrar_Out);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(474, 1033);
            flowLayoutPanel1.TabIndex = 91;
            // 
            // panel1
            // 
            panel1.Controls.Add(pcRegistrarLogo2);
            panel1.Location = new Point(3, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(458, 277);
            panel1.TabIndex = 0;
            // 
            // pcRegistrarLogo2
            // 
            pcRegistrarLogo2.BackColor = Color.CadetBlue;
            pcRegistrarLogo2.Image = (Image)resources.GetObject("pcRegistrarLogo2.Image");
            pcRegistrarLogo2.Location = new Point(56, 27);
            pcRegistrarLogo2.Margin = new Padding(3, 4, 3, 4);
            pcRegistrarLogo2.Name = "pcRegistrarLogo2";
            pcRegistrarLogo2.Size = new Size(333, 239);
            pcRegistrarLogo2.SizeMode = PictureBoxSizeMode.StretchImage;
            pcRegistrarLogo2.TabIndex = 0;
            pcRegistrarLogo2.TabStop = false;
            pcRegistrarLogo2.Click += pcRegistrarLogo2_Click;
            // 
            // btnRegistrar_StudInfo
            // 
            btnRegistrar_StudInfo.BackColor = Color.CadetBlue;
            btnRegistrar_StudInfo.FlatStyle = FlatStyle.Flat;
            btnRegistrar_StudInfo.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnRegistrar_StudInfo.ForeColor = Color.AliceBlue;
            btnRegistrar_StudInfo.Location = new Point(23, 298);
            btnRegistrar_StudInfo.Margin = new Padding(23, 13, 3, 4);
            btnRegistrar_StudInfo.Name = "btnRegistrar_StudInfo";
            btnRegistrar_StudInfo.Size = new Size(421, 79);
            btnRegistrar_StudInfo.TabIndex = 3;
            btnRegistrar_StudInfo.Text = " STUDENT INFORMATION";
            btnRegistrar_StudInfo.UseVisualStyleBackColor = false;
            btnRegistrar_StudInfo.Click += btnRegistrarStudentInformation_Click;
            // 
            // btnRegistrar_StudRegistration
            // 
            btnRegistrar_StudRegistration.BackColor = Color.DarkSlateGray;
            btnRegistrar_StudRegistration.FlatStyle = FlatStyle.Flat;
            btnRegistrar_StudRegistration.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnRegistrar_StudRegistration.ForeColor = Color.AliceBlue;
            btnRegistrar_StudRegistration.Location = new Point(23, 385);
            btnRegistrar_StudRegistration.Margin = new Padding(23, 4, 3, 4);
            btnRegistrar_StudRegistration.Name = "btnRegistrar_StudRegistration";
            btnRegistrar_StudRegistration.Size = new Size(421, 79);
            btnRegistrar_StudRegistration.TabIndex = 5;
            btnRegistrar_StudRegistration.Text = " STUDENT REGISTRATION";
            btnRegistrar_StudRegistration.UseVisualStyleBackColor = false;
            // 
            // btnRegistrar_Assessment
            // 
            btnRegistrar_Assessment.FlatStyle = FlatStyle.Flat;
            btnRegistrar_Assessment.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnRegistrar_Assessment.ForeColor = Color.AliceBlue;
            btnRegistrar_Assessment.Location = new Point(23, 472);
            btnRegistrar_Assessment.Margin = new Padding(23, 4, 3, 4);
            btnRegistrar_Assessment.Name = "btnRegistrar_Assessment";
            btnRegistrar_Assessment.Size = new Size(421, 79);
            btnRegistrar_Assessment.TabIndex = 4;
            btnRegistrar_Assessment.Text = "ASSESSMENT";
            btnRegistrar_Assessment.UseVisualStyleBackColor = true;
            btnRegistrar_Assessment.Click += btnRegistrar_Assessment_Click;
            // 
            // btnRegistrar_Report
            // 
            btnRegistrar_Report.FlatStyle = FlatStyle.Flat;
            btnRegistrar_Report.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnRegistrar_Report.ForeColor = Color.AliceBlue;
            btnRegistrar_Report.Location = new Point(23, 559);
            btnRegistrar_Report.Margin = new Padding(23, 4, 3, 4);
            btnRegistrar_Report.Name = "btnRegistrar_Report";
            btnRegistrar_Report.Size = new Size(421, 79);
            btnRegistrar_Report.TabIndex = 8;
            btnRegistrar_Report.Text = "REPORT";
            btnRegistrar_Report.UseVisualStyleBackColor = true;
            btnRegistrar_Report.Click += btnRegistrar_Report_Click;
            // 
            // btnRegistrar_Out
            // 
            btnRegistrar_Out.FlatStyle = FlatStyle.Flat;
            btnRegistrar_Out.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnRegistrar_Out.ForeColor = Color.AliceBlue;
            btnRegistrar_Out.Location = new Point(23, 646);
            btnRegistrar_Out.Margin = new Padding(23, 4, 3, 4);
            btnRegistrar_Out.Name = "btnRegistrar_Out";
            btnRegistrar_Out.Size = new Size(421, 79);
            btnRegistrar_Out.TabIndex = 9;
            btnRegistrar_Out.Text = "LOG OUT";
            btnRegistrar_Out.UseVisualStyleBackColor = true;
            btnRegistrar_Out.Click += btnRegistrarOut_Click;
            // 
            // btnRegistrarStudReg_Search
            // 
            btnRegistrarStudReg_Search.BackColor = Color.CadetBlue;
            btnRegistrarStudReg_Search.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnRegistrarStudReg_Search.ForeColor = Color.AliceBlue;
            btnRegistrarStudReg_Search.Location = new Point(1657, 46);
            btnRegistrarStudReg_Search.Name = "btnRegistrarStudReg_Search";
            btnRegistrarStudReg_Search.Size = new Size(201, 50);
            btnRegistrarStudReg_Search.TabIndex = 90;
            btnRegistrarStudReg_Search.Text = "Search Student";
            btnRegistrarStudReg_Search.UseVisualStyleBackColor = false;
            btnRegistrarStudReg_Search.Click += btnRegistrarStudReg_Search_Click;
            // 
            // RegistrarStudentRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1902, 1033);
            Controls.Add(dtgRegistrar_StudRegList);
            Controls.Add(txtRegistrarStudReg_Search);
            Controls.Add(btnRegistrarStudReg_Add);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnRegistrarStudReg_Search);
            Margin = new Padding(3, 4, 3, 4);
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
        private DataGridView dtgRegistrar_StudRegList;
        private TextBox txtRegistrarStudReg_Search;
        private Button btnRegistrarStudReg_Add;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private PictureBox pcRegistrarLogo2;
        private Button btnRegistrar_StudInfo;
        private Button btnRegistrar_Assessment;
        private Button btnRegistrar_StudRegistration;
        private Button btnRegistrar_Report;
        private Button btnRegistrar_Out;
        private Button btnRegistrarStudReg_Search;
    }
}