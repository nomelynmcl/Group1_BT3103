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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AssessmentGrid).BeginInit();
            SuspendLayout();
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.ForeColor = Color.DarkSlateGray;
            label21.Location = new Point(184, 55);
            label21.Name = "label21";
            label21.Size = new Size(238, 24);
            label21.TabIndex = 25;
            label21.Text = "Orion Tech-High School";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Add_a_heading__7__removebg_preview;
            pictureBox1.Location = new Point(67, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // AssessmentGrid
            // 
            AssessmentGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AssessmentGrid.Location = new Point(23, 249);
            AssessmentGrid.Name = "AssessmentGrid";
            AssessmentGrid.Size = new Size(462, 201);
            AssessmentGrid.TabIndex = 26;
            AssessmentGrid.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.Location = new Point(23, 173);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 27;
            label5.Text = "Student ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(23, 228);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 29;
            label3.Text = "Student Type:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.Location = new Point(23, 198);
            label6.Name = "label6";
            label6.Size = new Size(87, 15);
            label6.TabIndex = 30;
            label6.Text = "Student Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.Location = new Point(269, 173);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 31;
            label1.Text = "Yr/Section: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(23, 461);
            label2.Name = "label2";
            label2.Size = new Size(105, 15);
            label2.TabIndex = 32;
            label2.Text = "Mode of Payment:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(23, 489);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 34;
            label8.Text = "Status:";
            // 
            // STU_ID_LBL
            // 
            STU_ID_LBL.AutoSize = true;
            STU_ID_LBL.Location = new Point(94, 173);
            STU_ID_LBL.Name = "STU_ID_LBL";
            STU_ID_LBL.Size = new Size(101, 15);
            STU_ID_LBL.TabIndex = 35;
            STU_ID_LBL.Text = "<<STUDENTID>>";
            // 
            // type_UP_LBL
            // 
            type_UP_LBL.AutoSize = true;
            type_UP_LBL.Location = new Point(109, 228);
            type_UP_LBL.Name = "type_UP_LBL";
            type_UP_LBL.Size = new Size(66, 15);
            type_UP_LBL.TabIndex = 36;
            type_UP_LBL.Text = "<<TYPE>>";
            // 
            // assessment_statuslb
            // 
            assessment_statuslb.AutoSize = true;
            assessment_statuslb.Location = new Point(71, 489);
            assessment_statuslb.Name = "assessment_statuslb";
            assessment_statuslb.Size = new Size(79, 15);
            assessment_statuslb.TabIndex = 38;
            assessment_statuslb.Text = "<<STATUS>>";
            // 
            // STU_NAME_LBL
            // 
            STU_NAME_LBL.AutoSize = true;
            STU_NAME_LBL.Location = new Point(115, 198);
            STU_NAME_LBL.Name = "STU_NAME_LBL";
            STU_NAME_LBL.Size = new Size(124, 15);
            STU_NAME_LBL.TabIndex = 40;
            STU_NAME_LBL.Text = "<<STUDENTNAME>>";
            // 
            // SECT_TION_LBL
            // 
            SECT_TION_LBL.AutoSize = true;
            SECT_TION_LBL.Location = new Point(338, 173);
            SECT_TION_LBL.Name = "SECT_TION_LBL";
            SECT_TION_LBL.Size = new Size(87, 15);
            SECT_TION_LBL.TabIndex = 41;
            SECT_TION_LBL.Text = "<<SECTION>>";
            // 
            // MODE_LBL
            // 
            MODE_LBL.AutoSize = true;
            MODE_LBL.Location = new Point(134, 461);
            MODE_LBL.Name = "MODE_LBL";
            MODE_LBL.Size = new Size(73, 15);
            MODE_LBL.TabIndex = 42;
            MODE_LBL.Text = "<<MODE>>";
            // 
            // PRIN_BUTTON
            // 
            PRIN_BUTTON.Location = new Point(410, 542);
            PRIN_BUTTON.Name = "PRIN_BUTTON";
            PRIN_BUTTON.Size = new Size(75, 23);
            PRIN_BUTTON.TabIndex = 43;
            PRIN_BUTTON.Text = "Print";
            PRIN_BUTTON.UseVisualStyleBackColor = true;
            PRIN_BUTTON.Click += PRIN_BUTTON_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(23, 542);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 44;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // AdminViewAssessment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(525, 587);
            Controls.Add(btnBack);
            Controls.Add(PRIN_BUTTON);
            Controls.Add(MODE_LBL);
            Controls.Add(SECT_TION_LBL);
            Controls.Add(STU_NAME_LBL);
            Controls.Add(assessment_statuslb);
            Controls.Add(type_UP_LBL);
            Controls.Add(STU_ID_LBL);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(AssessmentGrid);
            Controls.Add(label21);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AdminViewAssessment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin_Assessment";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)AssessmentGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label21;
        private PictureBox pictureBox1;
        private DataGridView AssessmentGrid;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label1;
        private Label label2;
        private Label label7;
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
    }
}