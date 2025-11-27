namespace EventDriven.Project.UI
{
    partial class RegistrarViewAssessment
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
            label4 = new Label();
            lbSchoolYear = new Label();
            panel1 = new Panel();
            label9 = new Label();
            label7 = new Label();
            ckFailed = new CheckBox();
            ckPassed = new CheckBox();
            txtAverage = new TextBox();
            label16 = new Label();
            btnBack = new Button();
            ckResp = new CheckBox();
            ckPeer = new CheckBox();
            ckPart = new CheckBox();
            ckGood = new CheckBox();
            ckAct = new CheckBox();
            STU_ID_LBL_RGTR = new Label();
            ckRes = new CheckBox();
            ckAttendance = new CheckBox();
            TYPE_LBL_RGTR = new Label();
            ckExc = new CheckBox();
            label15 = new Label();
            label14 = new Label();
            label6 = new Label();
            label13 = new Label();
            label3 = new Label();
            label12 = new Label();
            label5 = new Label();
            label11 = new Label();
            STU_NAME_LBL_RGTR = new Label();
            label10 = new Label();
            PRIN_BUTTON = new Button();
            label17 = new Label();
            dtgBreak = new DataGridView();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            AssessmentGrid = new DataGridView();
            assessment_statuslb = new Label();
            label21 = new Label();
            label22 = new Label();
            MODE_LBL = new Label();
            SECT_TION_LBL = new Label();
            label23 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgBreak).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AssessmentGrid).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(553, 196);
            label4.Name = "label4";
            label4.Size = new Size(123, 28);
            label4.TabIndex = 65;
            label4.Text = "School Year:";
            // 
            // lbSchoolYear
            // 
            lbSchoolYear.AutoSize = true;
            lbSchoolYear.Font = new Font("Segoe UI", 12F);
            lbSchoolYear.Location = new Point(701, 196);
            lbSchoolYear.Name = "lbSchoolYear";
            lbSchoolYear.Size = new Size(195, 28);
            lbSchoolYear.TabIndex = 66;
            lbSchoolYear.Text = "<<SCHOOL YEAR>>";
            // 
            // panel1
            // 
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(ckFailed);
            panel1.Controls.Add(ckPassed);
            panel1.Controls.Add(txtAverage);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(ckResp);
            panel1.Controls.Add(lbSchoolYear);
            panel1.Controls.Add(ckPeer);
            panel1.Controls.Add(ckPart);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(ckGood);
            panel1.Controls.Add(ckAct);
            panel1.Controls.Add(STU_ID_LBL_RGTR);
            panel1.Controls.Add(ckRes);
            panel1.Controls.Add(ckAttendance);
            panel1.Controls.Add(TYPE_LBL_RGTR);
            panel1.Controls.Add(ckExc);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(STU_NAME_LBL_RGTR);
            panel1.Controls.Add(label10);
            panel1.Location = new Point(12, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(921, 1036);
            panel1.TabIndex = 65;
            panel1.Paint += panel1_Paint;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(67, 155);
            label9.Name = "label9";
            label9.Size = new Size(205, 28);
            label9.TabIndex = 85;
            label9.Text = "Student Information";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(67, 108);
            label7.Name = "label7";
            label7.Size = new Size(396, 31);
            label7.TabIndex = 84;
            label7.Text = "SECTION A: STUDENT ASSESSMENT";
            // 
            // ckFailed
            // 
            ckFailed.AutoSize = true;
            ckFailed.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ckFailed.Location = new Point(213, 808);
            ckFailed.Name = "ckFailed";
            ckFailed.Size = new Size(76, 24);
            ckFailed.TabIndex = 83;
            ckFailed.Text = "Failed";
            ckFailed.UseVisualStyleBackColor = true;
            ckFailed.CheckedChanged += ckFailed_CheckedChanged;
            // 
            // ckPassed
            // 
            ckPassed.AutoSize = true;
            ckPassed.Font = new Font("Microsoft Sans Serif", 10F);
            ckPassed.Location = new Point(72, 808);
            ckPassed.Name = "ckPassed";
            ckPassed.Size = new Size(87, 24);
            ckPassed.TabIndex = 82;
            ckPassed.Text = "Passed";
            ckPassed.UseVisualStyleBackColor = true;
            ckPassed.CheckedChanged += ckPassed_CheckedChanged;
            // 
            // txtAverage
            // 
            txtAverage.Location = new Point(268, 359);
            txtAverage.Name = "txtAverage";
            txtAverage.Size = new Size(226, 27);
            txtAverage.TabIndex = 81;
            txtAverage.TextChanged += txtAverage_TextChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(68, 745);
            label16.Name = "label16";
            label16.Size = new Size(238, 28);
            label16.TabIndex = 80;
            label16.Text = "Final Assessment Result";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.CadetBlue;
            btnBack.Font = new Font("Segoe UI", 14F);
            btnBack.ForeColor = Color.AliceBlue;
            btnBack.Location = new Point(733, 963);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(154, 54);
            btnBack.TabIndex = 64;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // ckResp
            // 
            ckResp.AutoSize = true;
            ckResp.Font = new Font("Microsoft Sans Serif", 10F);
            ckResp.Location = new Point(476, 675);
            ckResp.Name = "ckResp";
            ckResp.Size = new Size(155, 24);
            ckResp.TabIndex = 73;
            ckResp.Text = "Needs Guidance";
            ckResp.UseVisualStyleBackColor = true;
            ckResp.CheckedChanged += ckResp_CheckedChanged;
            // 
            // ckPeer
            // 
            ckPeer.AutoSize = true;
            ckPeer.Font = new Font("Microsoft Sans Serif", 10F);
            ckPeer.Location = new Point(476, 613);
            ckPeer.Name = "ckPeer";
            ckPeer.Size = new Size(155, 24);
            ckPeer.TabIndex = 79;
            ckPeer.Text = "Needs Guidance";
            ckPeer.UseVisualStyleBackColor = true;
            ckPeer.CheckedChanged += ckPeer_CheckedChanged;
            // 
            // ckPart
            // 
            ckPart.AutoSize = true;
            ckPart.Font = new Font("Microsoft Sans Serif", 10F);
            ckPart.Location = new Point(476, 552);
            ckPart.Name = "ckPart";
            ckPart.Size = new Size(180, 24);
            ckPart.TabIndex = 78;
            ckPart.Text = "Needs Improvement";
            ckPart.UseVisualStyleBackColor = true;
            ckPart.CheckedChanged += ckPart_CheckedChanged;
            // 
            // ckGood
            // 
            ckGood.AutoSize = true;
            ckGood.Font = new Font("Microsoft Sans Serif", 10F);
            ckGood.Location = new Point(322, 552);
            ckGood.Name = "ckGood";
            ckGood.Size = new Size(71, 24);
            ckGood.TabIndex = 74;
            ckGood.Text = "Good";
            ckGood.UseVisualStyleBackColor = true;
            ckGood.CheckedChanged += ckGood_CheckedChanged;
            // 
            // ckAct
            // 
            ckAct.AutoSize = true;
            ckAct.Font = new Font("Microsoft Sans Serif", 10F);
            ckAct.Location = new Point(322, 613);
            ckAct.Name = "ckAct";
            ckAct.Size = new Size(77, 24);
            ckAct.TabIndex = 76;
            ckAct.Text = "Active";
            ckAct.UseVisualStyleBackColor = true;
            ckAct.CheckedChanged += ckAct_CheckedChanged;
            // 
            // STU_ID_LBL_RGTR
            // 
            STU_ID_LBL_RGTR.AutoSize = true;
            STU_ID_LBL_RGTR.Font = new Font("Segoe UI", 12F);
            STU_ID_LBL_RGTR.Location = new Point(286, 196);
            STU_ID_LBL_RGTR.Name = "STU_ID_LBL_RGTR";
            STU_ID_LBL_RGTR.Size = new Size(171, 28);
            STU_ID_LBL_RGTR.TabIndex = 55;
            STU_ID_LBL_RGTR.Text = "<<STUDENTID>>";
            // 
            // ckRes
            // 
            ckRes.AutoSize = true;
            ckRes.Font = new Font("Microsoft Sans Serif", 10F);
            ckRes.Location = new Point(322, 675);
            ckRes.Name = "ckRes";
            ckRes.Size = new Size(123, 24);
            ckRes.TabIndex = 77;
            ckRes.Text = "Responsible";
            ckRes.UseVisualStyleBackColor = true;
            ckRes.CheckedChanged += ckRes_CheckedChanged;
            // 
            // ckAttendance
            // 
            ckAttendance.AutoSize = true;
            ckAttendance.Font = new Font("Microsoft Sans Serif", 10F);
            ckAttendance.Location = new Point(476, 496);
            ckAttendance.Name = "ckAttendance";
            ckAttendance.Size = new Size(180, 24);
            ckAttendance.TabIndex = 75;
            ckAttendance.Text = "Needs Improvement";
            ckAttendance.UseVisualStyleBackColor = true;
            ckAttendance.CheckedChanged += ckAttendance_CheckedChanged;
            // 
            // TYPE_LBL_RGTR
            // 
            TYPE_LBL_RGTR.AutoSize = true;
            TYPE_LBL_RGTR.Font = new Font("Segoe UI", 12F);
            TYPE_LBL_RGTR.Location = new Point(286, 296);
            TYPE_LBL_RGTR.Name = "TYPE_LBL_RGTR";
            TYPE_LBL_RGTR.Size = new Size(110, 28);
            TYPE_LBL_RGTR.TabIndex = 56;
            TYPE_LBL_RGTR.Text = "<<TYPE>>";
            // 
            // ckExc
            // 
            ckExc.AutoSize = true;
            ckExc.Font = new Font("Microsoft Sans Serif", 10F);
            ckExc.Location = new Point(322, 498);
            ckExc.Name = "ckExc";
            ckExc.Size = new Size(99, 24);
            ckExc.TabIndex = 72;
            ckExc.Text = "Excellent";
            ckExc.UseVisualStyleBackColor = true;
            ckExc.CheckedChanged += ckExc_CheckedChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(68, 669);
            label15.Name = "label15";
            label15.Size = new Size(137, 28);
            label15.TabIndex = 71;
            label15.Text = "Responsibility";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(68, 607);
            label14.Name = "label14";
            label14.Size = new Size(161, 28);
            label14.TabIndex = 70;
            label14.Text = "Peer Interaction:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(61, 247);
            label6.Name = "label6";
            label6.Size = new Size(148, 28);
            label6.TabIndex = 50;
            label6.Text = "Student Name:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(67, 546);
            label13.Name = "label13";
            label13.Size = new Size(130, 28);
            label13.TabIndex = 69;
            label13.Text = "Participation:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(61, 296);
            label3.Name = "label3";
            label3.Size = new Size(137, 28);
            label3.TabIndex = 49;
            label3.Text = "Student Type:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(68, 490);
            label12.Name = "label12";
            label12.Size = new Size(121, 28);
            label12.TabIndex = 68;
            label12.Text = "Attendance:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(61, 196);
            label5.Name = "label5";
            label5.Size = new Size(114, 28);
            label5.TabIndex = 47;
            label5.Text = "Student ID:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(68, 424);
            label11.Name = "label11";
            label11.Size = new Size(221, 28);
            label11.TabIndex = 67;
            label11.Text = "Behavior and Conduct";
            // 
            // STU_NAME_LBL_RGTR
            // 
            STU_NAME_LBL_RGTR.AutoSize = true;
            STU_NAME_LBL_RGTR.Font = new Font("Segoe UI", 12F);
            STU_NAME_LBL_RGTR.Location = new Point(286, 247);
            STU_NAME_LBL_RGTR.Name = "STU_NAME_LBL_RGTR";
            STU_NAME_LBL_RGTR.Size = new Size(208, 28);
            STU_NAME_LBL_RGTR.TabIndex = 60;
            STU_NAME_LBL_RGTR.Text = "<<STUDENTNAME>>";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(68, 354);
            label10.Name = "label10";
            label10.Size = new Size(175, 28);
            label10.TabIndex = 66;
            label10.Text = "Previous Average:";
            // 
            // PRIN_BUTTON
            // 
            PRIN_BUTTON.BackColor = Color.CadetBlue;
            PRIN_BUTTON.Font = new Font("Segoe UI", 14F);
            PRIN_BUTTON.ForeColor = Color.AliceBlue;
            PRIN_BUTTON.Location = new Point(975, 966);
            PRIN_BUTTON.Margin = new Padding(3, 4, 3, 4);
            PRIN_BUTTON.Name = "PRIN_BUTTON";
            PRIN_BUTTON.Size = new Size(154, 54);
            PRIN_BUTTON.TabIndex = 63;
            PRIN_BUTTON.Text = "Print";
            PRIN_BUTTON.UseVisualStyleBackColor = false;
            PRIN_BUTTON.Click += PRIN_BUTTON_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(772, 42);
            label17.Name = "label17";
            label17.Size = new Size(357, 38);
            label17.TabIndex = 66;
            label17.Text = "Student Assessment Form";
            // 
            // dtgBreak
            // 
            dtgBreak.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgBreak.Location = new Point(985, 678);
            dtgBreak.Margin = new Padding(3, 4, 3, 4);
            dtgBreak.Name = "dtgBreak";
            dtgBreak.RowHeadersWidth = 51;
            dtgBreak.Size = new Size(857, 265);
            dtgBreak.TabIndex = 77;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(985, 540);
            label20.Name = "label20";
            label20.Size = new Size(156, 28);
            label20.TabIndex = 74;
            label20.Text = "Fee Breakdown";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(985, 205);
            label19.Name = "label19";
            label19.Size = new Size(172, 28);
            label19.TabIndex = 75;
            label19.Text = "Weekly Schedule";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(985, 93);
            label18.Name = "label18";
            label18.Size = new Size(517, 31);
            label18.TabIndex = 76;
            label18.Text = "SECTION B: ENROLLMENT DETAILS (IF PASSED)";
            // 
            // AssessmentGrid
            // 
            AssessmentGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AssessmentGrid.Location = new Point(985, 250);
            AssessmentGrid.Margin = new Padding(3, 4, 3, 4);
            AssessmentGrid.Name = "AssessmentGrid";
            AssessmentGrid.RowHeadersWidth = 51;
            AssessmentGrid.Size = new Size(862, 279);
            AssessmentGrid.TabIndex = 67;
            // 
            // assessment_statuslb
            // 
            assessment_statuslb.AutoSize = true;
            assessment_statuslb.Font = new Font("Segoe UI", 12F);
            assessment_statuslb.Location = new Point(1095, 633);
            assessment_statuslb.Name = "assessment_statuslb";
            assessment_statuslb.Size = new Size(135, 28);
            assessment_statuslb.TabIndex = 71;
            assessment_statuslb.Text = "<<STATUS>>";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label21.Location = new Point(990, 634);
            label21.Name = "label21";
            label21.Size = new Size(72, 28);
            label21.TabIndex = 70;
            label21.Text = "Status:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label22.Location = new Point(987, 591);
            label22.Name = "label22";
            label22.Size = new Size(180, 28);
            label22.TabIndex = 69;
            label22.Text = "Mode of Payment:";
            // 
            // MODE_LBL
            // 
            MODE_LBL.AutoSize = true;
            MODE_LBL.Font = new Font("Segoe UI", 12F);
            MODE_LBL.Location = new Point(1224, 591);
            MODE_LBL.Name = "MODE_LBL";
            MODE_LBL.Size = new Size(125, 28);
            MODE_LBL.TabIndex = 73;
            MODE_LBL.Text = "<<MODE>>";
            // 
            // SECT_TION_LBL
            // 
            SECT_TION_LBL.AutoSize = true;
            SECT_TION_LBL.Font = new Font("Segoe UI", 12F);
            SECT_TION_LBL.Location = new Point(1129, 153);
            SECT_TION_LBL.Name = "SECT_TION_LBL";
            SECT_TION_LBL.Size = new Size(146, 28);
            SECT_TION_LBL.TabIndex = 72;
            SECT_TION_LBL.Text = "<<SECTION>>";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label23.Location = new Point(985, 153);
            label23.Name = "label23";
            label23.Size = new Size(116, 28);
            label23.TabIndex = 68;
            label23.Text = "Yr/Section: ";
            // 
            // RegistrarViewAssessment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1902, 1033);
            Controls.Add(dtgBreak);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(AssessmentGrid);
            Controls.Add(assessment_statuslb);
            Controls.Add(label21);
            Controls.Add(label22);
            Controls.Add(MODE_LBL);
            Controls.Add(SECT_TION_LBL);
            Controls.Add(PRIN_BUTTON);
            Controls.Add(label23);
            Controls.Add(label17);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RegistrarViewAssessment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrar_Assessment";
            Load += RegistrarViewAssessment_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgBreak).EndInit();
            ((System.ComponentModel.ISupportInitialize)AssessmentGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label lbSchoolYear;
        private Panel panel1;
        private Button btnBack;
        private Button PRIN_BUTTON;
        private Label label5;
        private Label label3;
        private Label label6;
        private Label STU_ID_LBL_RGTR;
        private Label TYPE_LBL_RGTR;
        private Label STU_NAME_LBL_RGTR;
        private TextBox txtAverage;
        private Label label16;
        private CheckBox ckResp;
        private CheckBox ckPeer;
        private CheckBox ckPart;
        private CheckBox ckGood;
        private CheckBox ckAct;
        private CheckBox ckRes;
        private CheckBox ckAttendance;
        private CheckBox ckExc;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private CheckBox ckFailed;
        private CheckBox ckPassed;
        private Label label9;
        private Label label7;
        private Label label17;
        private DataGridView dtgBreak;
        private Label label20;
        private Label label19;
        private Label label18;
        private DataGridView AssessmentGrid;
        private Label assessment_statuslb;
        private Label label21;
        private Label label22;
        private Label MODE_LBL;
        private Label SECT_TION_LBL;
        private Label label23;
    }
}