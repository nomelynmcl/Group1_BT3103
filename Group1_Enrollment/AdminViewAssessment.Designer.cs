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
            txtAverage = new TextBox();
            ckFailed = new CheckBox();
            ckPassed = new CheckBox();
            label16 = new Label();
            ckResp = new CheckBox();
            ckPeer = new CheckBox();
            ckPart = new CheckBox();
            ckGood = new CheckBox();
            ckAct = new CheckBox();
            ckRes = new CheckBox();
            ckAttendance = new CheckBox();
            ckExc = new CheckBox();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            lbSchoolYear = new Label();
            label7 = new Label();
            label4 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            dtgBreak = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)AssessmentGrid).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgBreak).BeginInit();
            SuspendLayout();
            // 
            // AssessmentGrid
            // 
            AssessmentGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AssessmentGrid.Location = new Point(915, 285);
            AssessmentGrid.Margin = new Padding(3, 4, 3, 4);
            AssessmentGrid.Name = "AssessmentGrid";
            AssessmentGrid.RowHeadersWidth = 51;
            AssessmentGrid.Size = new Size(862, 279);
            AssessmentGrid.TabIndex = 26;
            AssessmentGrid.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(47, 231);
            label5.Name = "label5";
            label5.Size = new Size(114, 28);
            label5.TabIndex = 27;
            label5.Text = "Student ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(47, 352);
            label3.Name = "label3";
            label3.Size = new Size(137, 28);
            label3.TabIndex = 29;
            label3.Text = "Student Type:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(47, 293);
            label6.Name = "label6";
            label6.Size = new Size(148, 28);
            label6.TabIndex = 30;
            label6.Text = "Student Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(915, 188);
            label1.Name = "label1";
            label1.Size = new Size(116, 28);
            label1.TabIndex = 31;
            label1.Text = "Yr/Section: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(917, 626);
            label2.Name = "label2";
            label2.Size = new Size(180, 28);
            label2.TabIndex = 32;
            label2.Text = "Mode of Payment:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label8.Location = new Point(920, 669);
            label8.Name = "label8";
            label8.Size = new Size(72, 28);
            label8.TabIndex = 34;
            label8.Text = "Status:";
            // 
            // STU_ID_LBL
            // 
            STU_ID_LBL.AutoSize = true;
            STU_ID_LBL.Font = new Font("Segoe UI", 12F);
            STU_ID_LBL.Location = new Point(247, 230);
            STU_ID_LBL.Name = "STU_ID_LBL";
            STU_ID_LBL.Size = new Size(171, 28);
            STU_ID_LBL.TabIndex = 35;
            STU_ID_LBL.Text = "<<STUDENTID>>";
            // 
            // type_UP_LBL
            // 
            type_UP_LBL.AutoSize = true;
            type_UP_LBL.Font = new Font("Segoe UI", 12F);
            type_UP_LBL.Location = new Point(247, 352);
            type_UP_LBL.Name = "type_UP_LBL";
            type_UP_LBL.Size = new Size(110, 28);
            type_UP_LBL.TabIndex = 36;
            type_UP_LBL.Text = "<<TYPE>>";
            // 
            // assessment_statuslb
            // 
            assessment_statuslb.AutoSize = true;
            assessment_statuslb.Font = new Font("Segoe UI", 12F);
            assessment_statuslb.Location = new Point(1025, 668);
            assessment_statuslb.Name = "assessment_statuslb";
            assessment_statuslb.Size = new Size(135, 28);
            assessment_statuslb.TabIndex = 38;
            assessment_statuslb.Text = "<<STATUS>>";
            // 
            // STU_NAME_LBL
            // 
            STU_NAME_LBL.AutoSize = true;
            STU_NAME_LBL.Font = new Font("Segoe UI", 12F);
            STU_NAME_LBL.Location = new Point(247, 292);
            STU_NAME_LBL.Name = "STU_NAME_LBL";
            STU_NAME_LBL.Size = new Size(208, 28);
            STU_NAME_LBL.TabIndex = 40;
            STU_NAME_LBL.Text = "<<STUDENTNAME>>";
            // 
            // SECT_TION_LBL
            // 
            SECT_TION_LBL.AutoSize = true;
            SECT_TION_LBL.Font = new Font("Segoe UI", 12F);
            SECT_TION_LBL.Location = new Point(1059, 188);
            SECT_TION_LBL.Name = "SECT_TION_LBL";
            SECT_TION_LBL.Size = new Size(146, 28);
            SECT_TION_LBL.TabIndex = 41;
            SECT_TION_LBL.Text = "<<SECTION>>";
            // 
            // MODE_LBL
            // 
            MODE_LBL.AutoSize = true;
            MODE_LBL.Font = new Font("Segoe UI", 12F);
            MODE_LBL.Location = new Point(1154, 626);
            MODE_LBL.Name = "MODE_LBL";
            MODE_LBL.Size = new Size(125, 28);
            MODE_LBL.TabIndex = 42;
            MODE_LBL.Text = "<<MODE>>";
            // 
            // PRIN_BUTTON
            // 
            PRIN_BUTTON.BackColor = Color.CadetBlue;
            PRIN_BUTTON.Font = new Font("Segoe UI", 12F);
            PRIN_BUTTON.ForeColor = Color.AliceBlue;
            PRIN_BUTTON.Location = new Point(951, 979);
            PRIN_BUTTON.Margin = new Padding(3, 4, 3, 4);
            PRIN_BUTTON.Name = "PRIN_BUTTON";
            PRIN_BUTTON.Size = new Size(120, 41);
            PRIN_BUTTON.TabIndex = 43;
            PRIN_BUTTON.Text = "Print";
            PRIN_BUTTON.UseVisualStyleBackColor = false;
            PRIN_BUTTON.Click += PRIN_BUTTON_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.CadetBlue;
            btnBack.Font = new Font("Microsoft Sans Serif", 12F);
            btnBack.ForeColor = SystemColors.Control;
            btnBack.Location = new Point(692, 967);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(154, 41);
            btnBack.TabIndex = 44;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Azure;
            panel1.Controls.Add(txtAverage);
            panel1.Controls.Add(ckFailed);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(ckPassed);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(ckResp);
            panel1.Controls.Add(ckPeer);
            panel1.Controls.Add(ckPart);
            panel1.Controls.Add(ckGood);
            panel1.Controls.Add(ckAct);
            panel1.Controls.Add(ckRes);
            panel1.Controls.Add(ckAttendance);
            panel1.Controls.Add(ckExc);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(lbSchoolYear);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(STU_ID_LBL);
            panel1.Controls.Add(STU_NAME_LBL);
            panel1.Controls.Add(type_UP_LBL);
            panel1.Font = new Font("Microsoft Sans Serif", 8.25F);
            panel1.Location = new Point(30, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(860, 1031);
            panel1.TabIndex = 45;
            // 
            // txtAverage
            // 
            txtAverage.Location = new Point(247, 412);
            txtAverage.Name = "txtAverage";
            txtAverage.Size = new Size(226, 23);
            txtAverage.TabIndex = 64;
            txtAverage.TextChanged += txtAverage_TextChanged;
            // 
            // ckFailed
            // 
            ckFailed.AutoSize = true;
            ckFailed.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ckFailed.Location = new Point(187, 876);
            ckFailed.Name = "ckFailed";
            ckFailed.Size = new Size(76, 24);
            ckFailed.TabIndex = 63;
            ckFailed.Text = "Failed";
            ckFailed.UseVisualStyleBackColor = true;
            ckFailed.CheckedChanged += ckFailed_CheckedChanged;
            // 
            // ckPassed
            // 
            ckPassed.AutoSize = true;
            ckPassed.Font = new Font("Microsoft Sans Serif", 10F);
            ckPassed.Location = new Point(46, 876);
            ckPassed.Name = "ckPassed";
            ckPassed.Size = new Size(87, 24);
            ckPassed.TabIndex = 62;
            ckPassed.Text = "Passed";
            ckPassed.UseVisualStyleBackColor = true;
            ckPassed.CheckedChanged += ckPassed_CheckedChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(46, 803);
            label16.Name = "label16";
            label16.Size = new Size(238, 28);
            label16.TabIndex = 61;
            label16.Text = "Final Assessment Result";
            // 
            // ckResp
            // 
            ckResp.AutoSize = true;
            ckResp.Font = new Font("Microsoft Sans Serif", 10F);
            ckResp.Location = new Point(455, 728);
            ckResp.Name = "ckResp";
            ckResp.Size = new Size(155, 24);
            ckResp.TabIndex = 56;
            ckResp.Text = "Needs Guidance";
            ckResp.UseVisualStyleBackColor = true;
            ckResp.CheckedChanged += ckResp_CheckedChanged;
            // 
            // ckPeer
            // 
            ckPeer.AutoSize = true;
            ckPeer.Font = new Font("Microsoft Sans Serif", 10F);
            ckPeer.Location = new Point(455, 666);
            ckPeer.Name = "ckPeer";
            ckPeer.Size = new Size(155, 24);
            ckPeer.TabIndex = 60;
            ckPeer.Text = "Needs Guidance";
            ckPeer.UseVisualStyleBackColor = true;
            ckPeer.CheckedChanged += ckPeer_CheckedChanged;
            // 
            // ckPart
            // 
            ckPart.AutoSize = true;
            ckPart.Font = new Font("Microsoft Sans Serif", 10F);
            ckPart.Location = new Point(455, 605);
            ckPart.Name = "ckPart";
            ckPart.Size = new Size(180, 24);
            ckPart.TabIndex = 59;
            ckPart.Text = "Needs Improvement";
            ckPart.UseVisualStyleBackColor = true;
            ckPart.CheckedChanged += checkBox6_CheckedChanged;
            // 
            // ckGood
            // 
            ckGood.AutoSize = true;
            ckGood.Font = new Font("Microsoft Sans Serif", 10F);
            ckGood.Location = new Point(301, 605);
            ckGood.Name = "ckGood";
            ckGood.Size = new Size(71, 24);
            ckGood.TabIndex = 56;
            ckGood.Text = "Good";
            ckGood.UseVisualStyleBackColor = true;
            ckGood.CheckedChanged += ckGood_CheckedChanged;
            // 
            // ckAct
            // 
            ckAct.AutoSize = true;
            ckAct.Font = new Font("Microsoft Sans Serif", 10F);
            ckAct.Location = new Point(301, 666);
            ckAct.Name = "ckAct";
            ckAct.Size = new Size(77, 24);
            ckAct.TabIndex = 57;
            ckAct.Text = "Active";
            ckAct.UseVisualStyleBackColor = true;
            ckAct.CheckedChanged += ckAct_CheckedChanged;
            // 
            // ckRes
            // 
            ckRes.AutoSize = true;
            ckRes.Font = new Font("Microsoft Sans Serif", 10F);
            ckRes.Location = new Point(301, 728);
            ckRes.Name = "ckRes";
            ckRes.Size = new Size(123, 24);
            ckRes.TabIndex = 58;
            ckRes.Text = "Responsible";
            ckRes.UseVisualStyleBackColor = true;
            ckRes.CheckedChanged += ckRes_CheckedChanged;
            // 
            // ckAttendance
            // 
            ckAttendance.AutoSize = true;
            ckAttendance.Font = new Font("Microsoft Sans Serif", 10F);
            ckAttendance.Location = new Point(455, 549);
            ckAttendance.Name = "ckAttendance";
            ckAttendance.Size = new Size(180, 24);
            ckAttendance.TabIndex = 56;
            ckAttendance.Text = "Needs Improvement";
            ckAttendance.UseVisualStyleBackColor = true;
            ckAttendance.CheckedChanged += ckAttendance_CheckedChanged;
            // 
            // ckExc
            // 
            ckExc.AutoSize = true;
            ckExc.Font = new Font("Microsoft Sans Serif", 10F);
            ckExc.Location = new Point(301, 551);
            ckExc.Name = "ckExc";
            ckExc.Size = new Size(99, 24);
            ckExc.TabIndex = 55;
            ckExc.Text = "Excellent";
            ckExc.UseVisualStyleBackColor = true;
            ckExc.CheckedChanged += ckExc_CheckedChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(47, 722);
            label15.Name = "label15";
            label15.Size = new Size(137, 28);
            label15.TabIndex = 54;
            label15.Text = "Responsibility";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(47, 660);
            label14.Name = "label14";
            label14.Size = new Size(161, 28);
            label14.TabIndex = 53;
            label14.Text = "Peer Interaction:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(46, 599);
            label13.Name = "label13";
            label13.Size = new Size(130, 28);
            label13.TabIndex = 52;
            label13.Text = "Participation:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(47, 543);
            label12.Name = "label12";
            label12.Size = new Size(121, 28);
            label12.TabIndex = 51;
            label12.Text = "Attendance:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(47, 477);
            label11.Name = "label11";
            label11.Size = new Size(221, 28);
            label11.TabIndex = 50;
            label11.Text = "Behavior and Conduct";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(47, 407);
            label10.Name = "label10";
            label10.Size = new Size(175, 28);
            label10.TabIndex = 49;
            label10.Text = "Previous Average:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(46, 166);
            label9.Name = "label9";
            label9.Size = new Size(205, 28);
            label9.TabIndex = 48;
            label9.Text = "Student Information";
            // 
            // lbSchoolYear
            // 
            lbSchoolYear.AutoSize = true;
            lbSchoolYear.Font = new Font("Segoe UI", 12F);
            lbSchoolYear.Location = new Point(663, 230);
            lbSchoolYear.Name = "lbSchoolYear";
            lbSchoolYear.Size = new Size(195, 28);
            lbSchoolYear.TabIndex = 46;
            lbSchoolYear.Text = "<<SCHOOL YEAR>>";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(46, 119);
            label7.Name = "label7";
            label7.Size = new Size(396, 31);
            label7.TabIndex = 47;
            label7.Text = "SECTION A: STUDENT ASSESSMENT";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(519, 231);
            label4.Name = "label4";
            label4.Size = new Size(123, 28);
            label4.TabIndex = 45;
            label4.Text = "School Year:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(722, 31);
            label17.Name = "label17";
            label17.Size = new Size(357, 38);
            label17.TabIndex = 64;
            label17.Text = "Student Assessment Form";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(915, 128);
            label18.Name = "label18";
            label18.Size = new Size(517, 31);
            label18.TabIndex = 65;
            label18.Text = "SECTION B: ENROLLMENT DETAILS (IF PASSED)";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(915, 240);
            label19.Name = "label19";
            label19.Size = new Size(172, 28);
            label19.TabIndex = 64;
            label19.Text = "Weekly Schedule";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(915, 575);
            label20.Name = "label20";
            label20.Size = new Size(156, 28);
            label20.TabIndex = 64;
            label20.Text = "Fee Breakdown";
            // 
            // dtgBreak
            // 
            dtgBreak.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgBreak.Location = new Point(920, 705);
            dtgBreak.Margin = new Padding(3, 4, 3, 4);
            dtgBreak.Name = "dtgBreak";
            dtgBreak.RowHeadersWidth = 51;
            dtgBreak.Size = new Size(857, 265);
            dtgBreak.TabIndex = 66;
            // 
            // AdminViewAssessment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1902, 1033);
            Controls.Add(dtgBreak);
            Controls.Add(PRIN_BUTTON);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(panel1);
            Controls.Add(AssessmentGrid);
            Controls.Add(assessment_statuslb);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(MODE_LBL);
            Controls.Add(SECT_TION_LBL);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AdminViewAssessment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin_Assessment";
            ((System.ComponentModel.ISupportInitialize)AssessmentGrid).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgBreak).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private Label label9;
        private Label label7;
        private Label label10;
        private CheckBox ckAttendance;
        private CheckBox ckExc;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private CheckBox ckGood;
        private CheckBox ckAct;
        private CheckBox ckRes;
        private CheckBox ckResp;
        private CheckBox ckPeer;
        private CheckBox ckPart;
        private CheckBox ckFailed;
        private CheckBox ckPassed;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private DataGridView dtgBreak;
        private TextBox txtAverage;
    }
}