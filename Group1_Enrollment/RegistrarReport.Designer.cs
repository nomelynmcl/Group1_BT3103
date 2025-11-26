namespace EventDriven.Project.UI
{
    partial class RegistrarReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarReport));
            RR_LOE_BTN = new Button();
            RR_LOE_TXTBOX = new TextBox();
            RR_LOE_GRID = new DataGridView();
            RR_NOES = new Label();
            RR_NOE = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            pcRegistrarLogo4 = new PictureBox();
            btnAdminStudentInformation3 = new Button();
            btnAdminStudreg3 = new Button();
            btnAdminAssessment3 = new Button();
            btnAdminReport3 = new Button();
            btnAdminOut3 = new Button();
            cbSection = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)RR_LOE_GRID).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcRegistrarLogo4).BeginInit();
            SuspendLayout();
            // 
            // RR_LOE_BTN
            // 
            RR_LOE_BTN.BackColor = Color.CadetBlue;
            RR_LOE_BTN.Font = new Font("Segoe UI", 14F);
            RR_LOE_BTN.Location = new Point(585, 261);
            RR_LOE_BTN.Margin = new Padding(3, 4, 3, 4);
            RR_LOE_BTN.Name = "RR_LOE_BTN";
            RR_LOE_BTN.Size = new Size(154, 54);
            RR_LOE_BTN.TabIndex = 97;
            RR_LOE_BTN.Text = "Search";
            RR_LOE_BTN.UseVisualStyleBackColor = false;
            RR_LOE_BTN.Click += RR_LOE_BTN_Click;
            // 
            // RR_LOE_TXTBOX
            // 
            RR_LOE_TXTBOX.Font = new Font("Segoe UI", 14F);
            RR_LOE_TXTBOX.Location = new Point(745, 263);
            RR_LOE_TXTBOX.Margin = new Padding(3, 4, 3, 4);
            RR_LOE_TXTBOX.Multiline = true;
            RR_LOE_TXTBOX.Name = "RR_LOE_TXTBOX";
            RR_LOE_TXTBOX.Size = new Size(1050, 48);
            RR_LOE_TXTBOX.TabIndex = 96;
            RR_LOE_TXTBOX.TextChanged += RR_LOE_TXTBOX_TextChanged;
            // 
            // RR_LOE_GRID
            // 
            RR_LOE_GRID.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RR_LOE_GRID.Location = new Point(585, 408);
            RR_LOE_GRID.Margin = new Padding(3, 4, 3, 4);
            RR_LOE_GRID.Name = "RR_LOE_GRID";
            RR_LOE_GRID.RowHeadersWidth = 51;
            RR_LOE_GRID.Size = new Size(1210, 625);
            RR_LOE_GRID.TabIndex = 95;
            // 
            // RR_NOES
            // 
            RR_NOES.AutoSize = true;
            RR_NOES.Font = new Font("Segoe UI", 46F, FontStyle.Bold);
            RR_NOES.Location = new Point(1371, 112);
            RR_NOES.Name = "RR_NOES";
            RR_NOES.Size = new Size(87, 102);
            RR_NOES.TabIndex = 94;
            RR_NOES.Text = "0";
            // 
            // RR_NOE
            // 
            RR_NOE.AutoSize = true;
            RR_NOE.Font = new Font("Segoe UI", 46F, FontStyle.Bold);
            RR_NOE.Location = new Point(870, 112);
            RR_NOE.Name = "RR_NOE";
            RR_NOE.Size = new Size(87, 102);
            RR_NOE.TabIndex = 93;
            RR_NOE.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.Location = new Point(1216, 61);
            label3.Name = "label3";
            label3.Size = new Size(410, 32);
            label3.TabIndex = 92;
            label3.Text = "NUMBER OF ENROLLED STUDENTS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.Location = new Point(789, 61);
            label2.Name = "label2";
            label2.Size = new Size(277, 32);
            label2.TabIndex = 91;
            label2.Text = "NUMBER OF ENROLLES";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(585, 360);
            label1.Name = "label1";
            label1.Size = new Size(354, 32);
            label1.TabIndex = 90;
            label1.Text = "LIST OF ENROLLED STUDENTS";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.CadetBlue;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(btnAdminStudentInformation3);
            flowLayoutPanel1.Controls.Add(btnAdminStudreg3);
            flowLayoutPanel1.Controls.Add(btnAdminAssessment3);
            flowLayoutPanel1.Controls.Add(btnAdminReport3);
            flowLayoutPanel1.Controls.Add(btnAdminOut3);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(474, 1033);
            flowLayoutPanel1.TabIndex = 89;
            // 
            // panel1
            // 
            panel1.Controls.Add(pcRegistrarLogo4);
            panel1.Location = new Point(3, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(458, 277);
            panel1.TabIndex = 0;
            // 
            // pcRegistrarLogo4
            // 
            pcRegistrarLogo4.BackColor = Color.CadetBlue;
            pcRegistrarLogo4.Image = (Image)resources.GetObject("pcRegistrarLogo4.Image");
            pcRegistrarLogo4.Location = new Point(56, 27);
            pcRegistrarLogo4.Margin = new Padding(3, 4, 3, 4);
            pcRegistrarLogo4.Name = "pcRegistrarLogo4";
            pcRegistrarLogo4.Size = new Size(333, 239);
            pcRegistrarLogo4.SizeMode = PictureBoxSizeMode.StretchImage;
            pcRegistrarLogo4.TabIndex = 1;
            pcRegistrarLogo4.TabStop = false;
            pcRegistrarLogo4.Click += pcRegistrarLogo4_Click;
            // 
            // btnAdminStudentInformation3
            // 
            btnAdminStudentInformation3.BackColor = Color.CadetBlue;
            btnAdminStudentInformation3.FlatStyle = FlatStyle.Flat;
            btnAdminStudentInformation3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnAdminStudentInformation3.ForeColor = Color.AliceBlue;
            btnAdminStudentInformation3.Location = new Point(23, 298);
            btnAdminStudentInformation3.Margin = new Padding(23, 13, 3, 4);
            btnAdminStudentInformation3.Name = "btnAdminStudentInformation3";
            btnAdminStudentInformation3.Size = new Size(421, 79);
            btnAdminStudentInformation3.TabIndex = 3;
            btnAdminStudentInformation3.Text = " STUDENT INFORMATION";
            btnAdminStudentInformation3.UseVisualStyleBackColor = false;
            btnAdminStudentInformation3.Click += btnAdminStudentInformation3_Click;
            // 
            // btnAdminStudreg3
            // 
            btnAdminStudreg3.FlatStyle = FlatStyle.Flat;
            btnAdminStudreg3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnAdminStudreg3.ForeColor = Color.AliceBlue;
            btnAdminStudreg3.Location = new Point(23, 385);
            btnAdminStudreg3.Margin = new Padding(23, 4, 3, 4);
            btnAdminStudreg3.Name = "btnAdminStudreg3";
            btnAdminStudreg3.Size = new Size(421, 79);
            btnAdminStudreg3.TabIndex = 5;
            btnAdminStudreg3.Text = " STUDENT REGISTRATION";
            btnAdminStudreg3.UseVisualStyleBackColor = true;
            btnAdminStudreg3.Click += btnAdminStudreg3_Click;
            // 
            // btnAdminAssessment3
            // 
            btnAdminAssessment3.FlatStyle = FlatStyle.Flat;
            btnAdminAssessment3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnAdminAssessment3.ForeColor = Color.AliceBlue;
            btnAdminAssessment3.Location = new Point(23, 472);
            btnAdminAssessment3.Margin = new Padding(23, 4, 3, 4);
            btnAdminAssessment3.Name = "btnAdminAssessment3";
            btnAdminAssessment3.Size = new Size(421, 79);
            btnAdminAssessment3.TabIndex = 4;
            btnAdminAssessment3.Text = "ASSESSMENT";
            btnAdminAssessment3.UseVisualStyleBackColor = true;
            btnAdminAssessment3.Click += btnAdminAssessment3_Click;
            // 
            // btnAdminReport3
            // 
            btnAdminReport3.BackColor = Color.DarkSlateGray;
            btnAdminReport3.FlatStyle = FlatStyle.Flat;
            btnAdminReport3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnAdminReport3.ForeColor = Color.AliceBlue;
            btnAdminReport3.Location = new Point(23, 559);
            btnAdminReport3.Margin = new Padding(23, 4, 3, 4);
            btnAdminReport3.Name = "btnAdminReport3";
            btnAdminReport3.Size = new Size(421, 79);
            btnAdminReport3.TabIndex = 8;
            btnAdminReport3.Text = "REPORT";
            btnAdminReport3.UseVisualStyleBackColor = false;
            // 
            // btnAdminOut3
            // 
            btnAdminOut3.FlatStyle = FlatStyle.Flat;
            btnAdminOut3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnAdminOut3.ForeColor = Color.AliceBlue;
            btnAdminOut3.Location = new Point(23, 646);
            btnAdminOut3.Margin = new Padding(23, 4, 3, 4);
            btnAdminOut3.Name = "btnAdminOut3";
            btnAdminOut3.Size = new Size(421, 79);
            btnAdminOut3.TabIndex = 9;
            btnAdminOut3.Text = "LOG OUT";
            btnAdminOut3.UseVisualStyleBackColor = true;
            btnAdminOut3.Click += btnAdminOut3_Click;
            // 
            // cbSection
            // 
            cbSection.FormattingEnabled = true;
            cbSection.Items.AddRange(new object[] { "Sirius", "Rigel", "Polaris", "Vega", "Phoenix", "Altair", "Pegasus", "Deneb" });
            cbSection.Location = new Point(1412, 366);
            cbSection.Name = "cbSection";
            cbSection.Size = new Size(383, 28);
            cbSection.TabIndex = 98;
            cbSection.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // RegistrarReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1902, 1033);
            Controls.Add(cbSection);
            Controls.Add(RR_LOE_BTN);
            Controls.Add(RR_LOE_TXTBOX);
            Controls.Add(RR_LOE_GRID);
            Controls.Add(RR_NOES);
            Controls.Add(RR_NOE);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RegistrarReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistarReport";
            Load += RegistarReport_Load;
            ((System.ComponentModel.ISupportInitialize)RR_LOE_GRID).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcRegistrarLogo4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RR_LOE_BTN;
        private TextBox RR_LOE_TXTBOX;
        private DataGridView RR_LOE_GRID;
        private Label RR_NOES;
        private Label RR_NOE;
        private Label label3;
        private Label label2;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Button btnAdminStudentInformation3;
        private Button btnAdminAssessment3;
        private Button btnAdminStudreg3;
        private Button btnAdminReport3;
        private Button btnAdminOut3;
        private PictureBox pcRegistrarLogo4;
        private ComboBox cbSection;
    }
}