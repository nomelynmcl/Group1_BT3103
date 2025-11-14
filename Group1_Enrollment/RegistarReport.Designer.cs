namespace EventDriven.Project.UI
{
    partial class RegistarReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistarReport));
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
            btnAdminStudentInformation3 = new Button();
            btnAdminAssessment3 = new Button();
            btnAdminStudreg3 = new Button();
            btnAdminReport3 = new Button();
            btnAdminOut3 = new Button();
            pcRegistrarLogo4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)RR_LOE_GRID).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcRegistrarLogo4).BeginInit();
            SuspendLayout();
            // 
            // RR_LOE_BTN
            // 
            RR_LOE_BTN.Location = new Point(927, 168);
            RR_LOE_BTN.Name = "RR_LOE_BTN";
            RR_LOE_BTN.Size = new Size(75, 23);
            RR_LOE_BTN.TabIndex = 97;
            RR_LOE_BTN.Text = "Search";
            RR_LOE_BTN.UseVisualStyleBackColor = true;
            // 
            // RR_LOE_TXTBOX
            // 
            RR_LOE_TXTBOX.Location = new Point(723, 168);
            RR_LOE_TXTBOX.Name = "RR_LOE_TXTBOX";
            RR_LOE_TXTBOX.Size = new Size(198, 23);
            RR_LOE_TXTBOX.TabIndex = 96;
            // 
            // RR_LOE_GRID
            // 
            RR_LOE_GRID.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RR_LOE_GRID.Location = new Point(342, 211);
            RR_LOE_GRID.Name = "RR_LOE_GRID";
            RR_LOE_GRID.Size = new Size(664, 265);
            RR_LOE_GRID.TabIndex = 95;
            // 
            // RR_NOES
            // 
            RR_NOES.AutoSize = true;
            RR_NOES.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RR_NOES.Location = new Point(865, 62);
            RR_NOES.Name = "RR_NOES";
            RR_NOES.Size = new Size(56, 65);
            RR_NOES.TabIndex = 94;
            RR_NOES.Text = "0";
            // 
            // RR_NOE
            // 
            RR_NOE.AutoSize = true;
            RR_NOE.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RR_NOE.Location = new Point(395, 62);
            RR_NOE.Name = "RR_NOE";
            RR_NOE.Size = new Size(56, 65);
            RR_NOE.TabIndex = 93;
            RR_NOE.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(749, 24);
            label3.Name = "label3";
            label3.Size = new Size(257, 20);
            label3.TabIndex = 92;
            label3.Text = "NUMBER OF ENROLLED STUDENTS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(342, 24);
            label2.Name = "label2";
            label2.Size = new Size(174, 20);
            label2.TabIndex = 91;
            label2.Text = "NUMBER OF ENROLLES";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(342, 171);
            label1.Name = "label1";
            label1.Size = new Size(222, 20);
            label1.TabIndex = 90;
            label1.Text = "LIST OF ENROLLED STUDENTS";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.CadetBlue;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(btnAdminStudentInformation3);
            flowLayoutPanel1.Controls.Add(btnAdminAssessment3);
            flowLayoutPanel1.Controls.Add(btnAdminStudreg3);
            flowLayoutPanel1.Controls.Add(btnAdminReport3);
            flowLayoutPanel1.Controls.Add(btnAdminOut3);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(251, 522);
            flowLayoutPanel1.TabIndex = 89;
            // 
            // panel1
            // 
            panel1.Controls.Add(pcRegistrarLogo4);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(248, 140);
            panel1.TabIndex = 0;
            // 
            // btnAdminStudentInformation3
            // 
            btnAdminStudentInformation3.BackColor = Color.CadetBlue;
            btnAdminStudentInformation3.FlatStyle = FlatStyle.Flat;
            btnAdminStudentInformation3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminStudentInformation3.ForeColor = SystemColors.ActiveCaptionText;
            btnAdminStudentInformation3.Location = new Point(20, 156);
            btnAdminStudentInformation3.Margin = new Padding(20, 10, 3, 3);
            btnAdminStudentInformation3.Name = "btnAdminStudentInformation3";
            btnAdminStudentInformation3.Size = new Size(211, 42);
            btnAdminStudentInformation3.TabIndex = 3;
            btnAdminStudentInformation3.Text = " STUDENT INFORMATION";
            btnAdminStudentInformation3.UseVisualStyleBackColor = false;
            // 
            // btnAdminAssessment3
            // 
            btnAdminAssessment3.FlatStyle = FlatStyle.Flat;
            btnAdminAssessment3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminAssessment3.Location = new Point(20, 204);
            btnAdminAssessment3.Margin = new Padding(20, 3, 3, 3);
            btnAdminAssessment3.Name = "btnAdminAssessment3";
            btnAdminAssessment3.Size = new Size(211, 42);
            btnAdminAssessment3.TabIndex = 4;
            btnAdminAssessment3.Text = "ASSESSMENT";
            btnAdminAssessment3.UseVisualStyleBackColor = true;
            // 
            // btnAdminStudreg3
            // 
            btnAdminStudreg3.FlatStyle = FlatStyle.Flat;
            btnAdminStudreg3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminStudreg3.Location = new Point(20, 252);
            btnAdminStudreg3.Margin = new Padding(20, 3, 3, 3);
            btnAdminStudreg3.Name = "btnAdminStudreg3";
            btnAdminStudreg3.Size = new Size(211, 42);
            btnAdminStudreg3.TabIndex = 5;
            btnAdminStudreg3.Text = " STUDENT REGISTRATION";
            btnAdminStudreg3.UseVisualStyleBackColor = true;
            // 
            // btnAdminReport3
            // 
            btnAdminReport3.BackColor = Color.DarkSlateGray;
            btnAdminReport3.FlatStyle = FlatStyle.Flat;
            btnAdminReport3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminReport3.ForeColor = SystemColors.Control;
            btnAdminReport3.Location = new Point(20, 300);
            btnAdminReport3.Margin = new Padding(20, 3, 3, 3);
            btnAdminReport3.Name = "btnAdminReport3";
            btnAdminReport3.Size = new Size(211, 42);
            btnAdminReport3.TabIndex = 8;
            btnAdminReport3.Text = "REPORT";
            btnAdminReport3.UseVisualStyleBackColor = false;
            // 
            // btnAdminOut3
            // 
            btnAdminOut3.FlatStyle = FlatStyle.Flat;
            btnAdminOut3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminOut3.Location = new Point(20, 348);
            btnAdminOut3.Margin = new Padding(20, 3, 3, 3);
            btnAdminOut3.Name = "btnAdminOut3";
            btnAdminOut3.Size = new Size(211, 42);
            btnAdminOut3.TabIndex = 9;
            btnAdminOut3.Text = "LOG OUT";
            btnAdminOut3.UseVisualStyleBackColor = true;
            // 
            // pcRegistrarLogo4
            // 
            pcRegistrarLogo4.BackColor = Color.CadetBlue;
            pcRegistrarLogo4.Image = (Image)resources.GetObject("pcRegistrarLogo4.Image");
            pcRegistrarLogo4.Location = new Point(44, 11);
            pcRegistrarLogo4.Name = "pcRegistrarLogo4";
            pcRegistrarLogo4.Size = new Size(154, 126);
            pcRegistrarLogo4.SizeMode = PictureBoxSizeMode.StretchImage;
            pcRegistrarLogo4.TabIndex = 1;
            pcRegistrarLogo4.TabStop = false;
            // 
            // RegistarReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1058, 522);
            Controls.Add(RR_LOE_BTN);
            Controls.Add(RR_LOE_TXTBOX);
            Controls.Add(RR_LOE_GRID);
            Controls.Add(RR_NOES);
            Controls.Add(RR_NOE);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RegistarReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegistarReport";
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
    }
}