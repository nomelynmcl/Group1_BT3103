namespace EventDriven.Project.UI
{
    partial class AdminViewAssessment
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
            label21 = new Label();
            pictureBox1 = new PictureBox();
            AssessmentGrid = new DataGridView();
            label5 = new Label();
            label3 = new Label();
            label6 = new Label();
            label1 = new Label();
            label2 = new Label();
            label8 = new Label();
            STU_ID_LBL = new Label();
            type_UP_LBL = new Label();
            assessment_statuslb = new Label();
            STU_NAME_LBL = new Label();
            SECT_TION_LBL = new Label();
            MODE_LBL = new Label();
            PRIN_BUTTON = new Button();
            btnBack = new Button();
            panel1 = new Panel();
            lbSchoolYear = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AssessmentGrid).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold);
            label21.ForeColor = Color.DarkSlateGray;
            label21.Location = new Point(430, 110);
            label21.Name = "label21";
            label21.Size = new Size(304, 29);
            label21.TabIndex = 25;
            label21.Text = "Orion Tech-High School";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Add_a_heading__7__removebg_preview;
            pictureBox1.Location = new Point(221, 2);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(267, 201);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // AssessmentGrid
            // 
            AssessmentGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AssessmentGrid.Location = new Point(124, 453);
            AssessmentGrid.Margin = new Padding(3, 4, 3, 4);
            AssessmentGrid.Name = "AssessmentGrid";
            AssessmentGrid.RowHeadersWidth = 51;
            AssessmentGrid.Size = new Size(789, 268);
            AssessmentGrid.TabIndex = 26;
            AssessmentGrid.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label5.Location = new Point(124, 258);
            label5.Name = "label5";
            label5.Size = new Size(130, 31);
            label5.TabIndex = 27;
            label5.Text = "Student ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label3.Location = new Point(124, 380);
            label3.Name = "label3";
            label3.Size = new Size(156, 31);
            label3.TabIndex = 29;
            label3.Text = "Student Type:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label6.Location = new Point(124, 321);
            label6.Name = "label6";
            label6.Size = new Size(168, 31);
            label6.TabIndex = 30;
            label6.Text = "Student Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label1.Location = new Point(596, 257);
            label1.Name = "label1";
            label1.Size = new Size(138, 32);
            label1.TabIndex = 31;
            label1.Text = "Yr/Section: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            label2.Location = new Point(124, 751);
            label2.Name = "label2";
            label2.Size = new Size(204, 31);
            label2.TabIndex = 32;
            label2.Text = "Mode of Payment:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label8.Location = new Point(127, 810);
            label8.Name = "label8";
            label8.Size = new Size(87, 32);
            label8.TabIndex = 34;
            label8.Text = "Status:";
            // 
            // STU_ID_LBL
            // 
            STU_ID_LBL.AutoSize = true;
            STU_ID_LBL.Font = new Font("Segoe UI", 14F);
            STU_ID_LBL.Location = new Point(346, 258);
            STU_ID_LBL.Name = "STU_ID_LBL";
            STU_ID_LBL.Size = new Size(203, 32);
            STU_ID_LBL.TabIndex = 35;
            STU_ID_LBL.Text = "<<STUDENTID>>";
            // 
            // type_UP_LBL
            // 
            type_UP_LBL.AutoSize = true;
            type_UP_LBL.Font = new Font("Segoe UI", 14F);
            type_UP_LBL.Location = new Point(379, 379);
            type_UP_LBL.Name = "type_UP_LBL";
            type_UP_LBL.Size = new Size(129, 32);
            type_UP_LBL.TabIndex = 36;
            type_UP_LBL.Text = "<<TYPE>>";
            // 
            // assessment_statuslb
            // 
            assessment_statuslb.AutoSize = true;
            assessment_statuslb.Font = new Font("Segoe UI", 14F);
            assessment_statuslb.Location = new Point(232, 809);
            assessment_statuslb.Name = "assessment_statuslb";
            assessment_statuslb.Size = new Size(157, 32);
            assessment_statuslb.TabIndex = 38;
            assessment_statuslb.Text = "<<STATUS>>";
            // 
            // STU_NAME_LBL
            // 
            STU_NAME_LBL.AutoSize = true;
            STU_NAME_LBL.Font = new Font("Segoe UI", 14F);
            STU_NAME_LBL.Location = new Point(324, 320);
            STU_NAME_LBL.Name = "STU_NAME_LBL";
            STU_NAME_LBL.Size = new Size(247, 32);
            STU_NAME_LBL.TabIndex = 40;
            STU_NAME_LBL.Text = "<<STUDENTNAME>>";
            // 
            // SECT_TION_LBL
            // 
            SECT_TION_LBL.AutoSize = true;
            SECT_TION_LBL.Font = new Font("Segoe UI", 14F);
            SECT_TION_LBL.Location = new Point(740, 257);
            SECT_TION_LBL.Name = "SECT_TION_LBL";
            SECT_TION_LBL.Size = new Size(173, 32);
            SECT_TION_LBL.TabIndex = 41;
            SECT_TION_LBL.Text = "<<SECTION>>";
            // 
            // MODE_LBL
            // 
            MODE_LBL.AutoSize = true;
            MODE_LBL.Font = new Font("Segoe UI", 14F);
            MODE_LBL.Location = new Point(361, 751);
            MODE_LBL.Name = "MODE_LBL";
            MODE_LBL.Size = new Size(147, 32);
            MODE_LBL.TabIndex = 42;
            MODE_LBL.Text = "<<MODE>>";
            // 
            // PRIN_BUTTON
            // 
            PRIN_BUTTON.BackColor = Color.CadetBlue;
            PRIN_BUTTON.Font = new Font("Segoe UI", 14F);
            PRIN_BUTTON.ForeColor = Color.AliceBlue;
            PRIN_BUTTON.Location = new Point(580, 906);
            PRIN_BUTTON.Margin = new Padding(3, 4, 3, 4);
            PRIN_BUTTON.Name = "PRIN_BUTTON";
            PRIN_BUTTON.Size = new Size(154, 54);
            PRIN_BUTTON.TabIndex = 43;
            PRIN_BUTTON.Text = "Print";
            PRIN_BUTTON.UseVisualStyleBackColor = false;
            PRIN_BUTTON.Click += PRIN_BUTTON_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.CadetBlue;
            btnBack.Font = new Font("Segoe UI", 14F);
            btnBack.ForeColor = SystemColors.Control;
            btnBack.Location = new Point(315, 907);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(154, 54);
            btnBack.TabIndex = 44;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lbSchoolYear);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(AssessmentGrid);
            panel1.Controls.Add(SECT_TION_LBL);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(STU_NAME_LBL);
            panel1.Controls.Add(MODE_LBL);
            panel1.Controls.Add(type_UP_LBL);
            panel1.Controls.Add(PRIN_BUTTON);
            panel1.Controls.Add(STU_ID_LBL);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(assessment_statuslb);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label21);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(418, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1042, 1009);
            panel1.TabIndex = 45;
            // 
            // lbSchoolYear
            // 
            lbSchoolYear.AutoSize = true;
            lbSchoolYear.Font = new Font("Segoe UI", 14F);
            lbSchoolYear.Location = new Point(740, 320);
            lbSchoolYear.Name = "lbSchoolYear";
            lbSchoolYear.Size = new Size(231, 32);
            lbSchoolYear.TabIndex = 46;
            lbSchoolYear.Text = "<<SCHOOL YEAR>>";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label4.Location = new Point(596, 321);
            label4.Name = "label4";
            label4.Size = new Size(147, 32);
            label4.TabIndex = 45;
            label4.Text = "School Year:";
            // 
            // AdminViewAssessment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1902, 1033);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AdminViewAssessment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin_Assessment";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)AssessmentGrid).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label21;
        private PictureBox pictureBox1;
        private DataGridView AssessmentGrid;
        private Label label5;
        private Label label3;
        private Label label6;
        private Label label1;
        private Label label2;
        private Label label8;
        private Label STU_ID_LBL;
        private Label type_UP_LBL;
        private Label S_Y_LBL;
        private Label assessment_statuslb;
        private Label S_Y_BOTTOM_LBL;
        private Label STU_NAME_LBL;
        private Label SECT_TION_LBL;
        private Label MODE_LBL;
        private Button PRIN_BUTTON;
        private Button btnBack;
        private Panel panel1;
        private Label lbSchoolYear;
        private Label label4;
    }
}