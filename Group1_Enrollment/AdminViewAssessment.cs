using System.Drawing.Printing;

namespace EventDriven.Project.UI
{
    public partial class AdminViewAssessment : Form
    {

        private string fullName;
        private string yearSec;

        public AdminViewAssessment(
                int id,
                string firstName,
                string middleName,
                string lastName,
                int age,
                DateTime birthdate,
                string gender,
                int gradeLevel,
                string section,
                string studentType,
                string modeOfPayment,
                string enrollmentStatus,
                string schoolYear
                )
        {
            InitializeComponent();

            this.fullName = $"{lastName} {firstName} {middleName}".Replace("  ", " ").Trim();
            this.yearSec = $"{gradeLevel} {section}".Replace(" ", " ").Trim();
            STU_ID_LBL.Text = id.ToString();
            STU_NAME_LBL.Text = fullName;
            SECT_TION_LBL.Text = yearSec;
            type_UP_LBL.Text = studentType;
            assessment_statuslb.Text = enrollmentStatus;
            MODE_LBL.Text = modeOfPayment;
            lbSchoolYear.Text = schoolYear;
            LoadFeeBreakdown(modeOfPayment);
            LoadWeeklySchedule(gradeLevel);

            dtgBreak.Visible = false;       // Hide FEES
            AssessmentGrid.Visible = false; // Hide SCHEDULE

                MODE_LBL.Visible = false;
                SECT_TION_LBL.Visible=false;
                assessment_statuslb.Visible = false;
            


        }

        private void LoadFeeBreakdown(string modeOfPayment)
        {
            dtgBreak.Columns.Clear();
            dtgBreak.Columns.Add("Description", "Description");
            dtgBreak.Columns.Add("Amount", "Amount");
            dtgBreak.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (modeOfPayment == "Cash")
            {
                dtgBreak.Rows.Add("Tuition Fee", "₱2,000");
                dtgBreak.Rows.Add("Miscellaneous Fee", "₱1,500");
                dtgBreak.Rows.Add("Others", "₱1,700");
                dtgBreak.Rows.Add("Total", "₱5,200");
            }
            else if (modeOfPayment == "Low Quarterly Payment")
            {
                dtgBreak.Rows.Add("Tuition Fee", "₱2,500");
                dtgBreak.Rows.Add("Miscellaneous Fee", "₱1,875");
                dtgBreak.Rows.Add("Others", "₱2,125");
                dtgBreak.Rows.Add("Total", "₱6,500");
                dtgBreak.Rows.Add("Required Down Payment", "₱700");
                dtgBreak.Rows.Add("");
                dtgBreak.Rows.Add("Quarterly Payment (4x)", "₱1,450");
            }
            else if (modeOfPayment == "Low Down Payment")
            {
                dtgBreak.Rows.Add("Tuition Fee", "₱2,700");
                dtgBreak.Rows.Add("Miscellaneous Fee", "₱2,025");
                dtgBreak.Rows.Add("Others", "₱2,295");
                dtgBreak.Rows.Add("Total", "7,020");
                dtgBreak.Rows.Add("Required Down Payment", "₱500");
                dtgBreak.Rows.Add("");
                dtgBreak.Rows.Add("Quarterly Payment (4x)", "₱1,630");
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminAssesment adminAssesment = new AdminAssesment();
            adminAssesment.Show();
            this.Close();
        }

        private void PRIN_BUTTON_Click(object sender, EventArgs e)
        {
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += new PrintPageEventHandler(PrintDoc_PrintPage);

            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = printDoc;
            preview.ShowDialog();
        }

        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            int left = 60;
            int right = e.PageBounds.Width - 60;
            int width = right - left;

            Font titleFont = new Font("Arial", 22, FontStyle.Bold);
            Font schoolFont = new Font("Arial", 14, FontStyle.Bold);
            Font sectionFont = new Font("Arial", 13, FontStyle.Bold);
            Font labelFont = new Font("Arial", 11, FontStyle.Bold);
            Font valueFont = new Font("Arial", 11);
            Font gridFont = new Font("Arial", 10);
            Font footerFont = new Font("Arial", 9, FontStyle.Italic);

            Pen thickPen = new Pen(Color.Black, 2);
            Pen thinPen = new Pen(Color.Black, 1);

            float y = 80;

            // ------------------- LOGO -------------------
            try
            {
                Image logo = Image.FromFile("C:\\Enrollment\\Orion_Logo.png");
                g.DrawImage(logo, left, 30, 85, 85);
            }
            catch { }

            // ----------------- SCHOOL HEADER -----------------
            StringFormat center = new StringFormat();
            center.Alignment = StringAlignment.Center;

            g.DrawString("ORION TECH-HIGH SCHOOL", titleFont, Brushes.Black,
                e.PageBounds.Width / 2, 35, center);

            g.DrawString("Official Enrollment Assessment Form", schoolFont, Brushes.Black,
                e.PageBounds.Width / 2, 78, center);

            y = 135;

            // -------- OUTER BORDER --------
            g.DrawRectangle(thickPen, left - 20, y, width + 40, 970);

            y += 30;

            // =====================================================
            //           STUDENT IDENTIFICATION DETAILS
            // =====================================================
            g.DrawString("STUDENT INFORMATION", sectionFont, Brushes.Black, left, y);
            y += 28;

            void DrawField(string label, string value)
            {
                g.DrawString(label, labelFont, Brushes.Black, left, y);
                g.DrawString(value, valueFont, Brushes.Black, left + 180, y);
                y += 25;
            }

            // Basic student info
            DrawField("Student ID:", STU_ID_LBL.Text);
            DrawField("Full Name:", STU_NAME_LBL.Text);
            DrawField("Grade / Section:", SECT_TION_LBL.Text);
            DrawField("Classification:", type_UP_LBL.Text);

            y += 25;

            // =====================================================
            //           SECTION A – ACADEMIC ASSESSMENT
            // =====================================================
            g.DrawString("SECTION A – ACADEMIC ASSESSMENT", sectionFont, Brushes.Black, left, y);
            y += 28;

            DrawField("General Average:", txtAverage.Text);

            g.DrawString("Assessment Result:", labelFont, Brushes.Black, left, y);
            g.DrawString(
                ckPassed.Checked ? "Eligible for Enrollment" : "Not Eligible for Enrollment",
                valueFont,
                Brushes.Black,
                left + 180,
                y);
            y += 25;

            DrawField("Attendance Standing:", ckExc.Checked ? "Excellent" : "Needs Improvement");
            DrawField("Conduct Evaluation:", ckGood.Checked ? "Good" : "Needs Improvement");
            DrawField("Class Participation:", ckAct.Checked ? "Active" : "Passive");
            DrawField("Behavioral Standing:", ckRes.Checked ? "Respectful" : "Needs Guidance");

            y += 25;

            // =====================================================
            //           SECTION B – BREAKDOWN OF FEES
            // =====================================================
            g.DrawString("SECTION B – BREAKDOWN OF SCHOOL FEES", sectionFont, Brushes.Black, left, y);
            y += 28;

            int col1 = 300;   // Description column
            int col2 = 180;   // Amount
            int rowH = 24;

            // Table Header
            g.DrawRectangle(thinPen, left, y, col1, rowH);
            g.DrawRectangle(thinPen, left + col1, y, col2, rowH);

            g.DrawString("Fee Description", labelFont, Brushes.Black, left + 5, y + 4);
            g.DrawString("Amount (PHP)", labelFont, Brushes.Black, left + col1 + 5, y + 4);

            y += rowH;

            // Table Rows
            foreach (DataGridViewRow row in dtgBreak.Rows)
            {
                if (!row.IsNewRow)
                {
                    g.DrawRectangle(thinPen, left, y, col1, rowH);
                    g.DrawRectangle(thinPen, left + col1, y, col2, rowH);

                    g.DrawString(row.Cells[0].Value?.ToString(), gridFont, Brushes.Black, left + 5, y + 5);
                    g.DrawString(row.Cells[1].Value?.ToString(), gridFont, Brushes.Black, left + col1 + 5, y + 5);

                    y += rowH;
                }
            }

            y += 30;

            // =====================================================
            //           SECTION C – STUDENT CLASS SCHEDULE
            // =====================================================
            g.DrawString("SECTION C – OFFICIAL CLASS SCHEDULE", sectionFont, Brushes.Black, left, y);
            y += 28;

            int subjectCol = 260;
            int timeCol = 200;
            int teacherCol = 180;

            // Header
            g.DrawRectangle(thinPen, left, y, subjectCol, rowH);
            g.DrawRectangle(thinPen, left + subjectCol, y, timeCol, rowH);
            g.DrawRectangle(thinPen, left + subjectCol + timeCol, y, teacherCol, rowH);

            g.DrawString("Subject", labelFont, Brushes.Black, left + 5, y + 4);
            g.DrawString("Schedule", labelFont, Brushes.Black, left + subjectCol + 5, y + 4);
            g.DrawString("Instructor", labelFont, Brushes.Black, left + subjectCol + timeCol + 5, y + 4);

            y += rowH;

            // Rows
            foreach (DataGridViewRow row in AssessmentGrid.Rows)
            {
                if (!row.IsNewRow)
                {
                    g.DrawRectangle(thinPen, left, y, subjectCol, rowH);
                    g.DrawRectangle(thinPen, left + subjectCol, y, timeCol, rowH);
                    g.DrawRectangle(thinPen, left + subjectCol + timeCol, y, teacherCol, rowH);

                    g.DrawString(row.Cells[0].Value?.ToString(), gridFont, Brushes.Black, left + 5, y + 5);
                    g.DrawString(row.Cells[1].Value?.ToString(), gridFont, Brushes.Black, left + subjectCol + 5, y + 5);
                    g.DrawString(row.Cells[2].Value?.ToString(), gridFont, Brushes.Black, left + subjectCol + timeCol + 5, y + 5);

                    y += rowH;
                }
            }

            y += 35;

            // Enrollment Metadata
            DrawField("Mode of Payment:", MODE_LBL.Text);
            DrawField("Assessment Status:", assessment_statuslb.Text);

            y += 40;

            // =====================================================
            //                  SIGNATURE BLOCKS
            // =====================================================

            g.DrawLine(thinPen, left, y, left + 220, y);
            g.DrawString("Student Signature", valueFont, Brushes.Black, left, y + 5);

            g.DrawLine(thinPen, right - 220, y, right, y);
            g.DrawString("Parent/Guardian Signature", valueFont, Brushes.Black, right - 220, y + 5);

            y += 60;

            g.DrawLine(thinPen, left, y, left + 220, y);
            g.DrawString("Registrar", valueFont, Brushes.Black, left, y + 5);

            g.DrawLine(thinPen, right - 220, y, right, y);
            g.DrawString("School Principal", valueFont, Brushes.Black, right - 220, y + 5);

            y += 55;

            // =====================================================
            //                        FOOTER
            // =====================================================

            g.DrawLine(thinPen, left, y, right, y);
            y += 10;

            g.DrawString($"Printed on: {DateTime.Now:MMMM dd, yyyy   hh:mm tt}",
                         footerFont, Brushes.Gray, left, y);
        }


        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (ckPart.Checked)
            {
                ckGood.Checked = false;
            }
        }

        private void txtAverage_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtAverage.Text, out int avg))
            {
                if (avg >= 80)
                {
                    ckPassed.Checked = true;
                    ckFailed.Checked = false;
                }
                else
                {
                    ckPassed.Checked = false;
                    ckFailed.Checked = true;
                }

                assessment_statuslb.Text = "Assessed"; // AUTO STATUS

                dtgBreak.Visible = true;
                AssessmentGrid.Visible = true;

                MODE_LBL.Visible = true;
                SECT_TION_LBL.Visible = true;
                assessment_statuslb.Visible = true;


            }
        }
        private void LoadWeeklySchedule(int gradeLevel)
        {
            AssessmentGrid.Rows.Clear();

            List<(string Subject, string Time, string Teacher)> schedule = new();
            AssessmentGrid.Columns.Clear();
            AssessmentGrid.Columns.Add("Subject", "Subject");
            AssessmentGrid.Columns.Add("Time", "Time");
            AssessmentGrid.Columns.Add("Teacher", "Teacher");

            AssessmentGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            switch (gradeLevel)
            {
                case 7:
                    schedule = new()
            {
                ("English", "8:00 - 9:00 AM", "Mrs. Cruz"),
                ("Mathematics", "9:00 - 10:00 AM", "Mr. De Leon"),
                ("Science", "10:20 - 11:20 AM", "Ms. Ramos"),
                ("Filipino", "1:00 - 2:00 PM", "Mrs. Aquino"),
                ("MAPEH", "2:00 - 3:00 PM", "Coach Santos")
            };
                    break;

                case 8:
                    schedule = new()
            {
                ("English", "8:00 - 9:00 AM", "Ms. Ortega"),
                ("Math", "9:00 - 10:00 AM", "Mr. Velasquez"),
                ("Biology", "10:20 - 11:20 AM", "Ms. Navarro"),
                ("Araling Panlipunan", "1:00 - 2:00 PM", "Mr. Torres"),
                ("TLE", "2:00 - 3:00 PM", "Mrs. Castillo")
            };
                    break;

                case 9:
                    schedule = new()
            {
                ("English", "8:00 - 9:00 AM", "Mrs. Javier"),
                ("Algebra", "9:00 - 10:00 AM", "Mr. Reyes"),
                ("Physics", "10:20 - 11:20 AM", "Mr. Castillo"),
                ("Filipino", "1:00 - 2:00 PM", "Mrs. Valdez"),
                ("Computer", "2:00 - 3:00 PM", "Sir Miranda")
            };
                    break;

                case 10:
                    schedule = new()
            {
                ("English", "8:00 - 9:00 AM", "Ms. Santos"),
                ("Geometry", "9:00 - 10:00 AM", "Mr. Hernandez"),
                ("Chemistry", "10:20 - 11:20 AM", "Mrs. Gomez"),
                ("AP", "1:00 - 2:00 PM", "Ms. Pascual"),
                ("MAPEH", "2:00 - 3:00 PM", "Coach Rafael")
            };
                    break;
            }

            foreach (var s in schedule)
            {
                AssessmentGrid.Rows.Add(s.Subject, s.Time, s.Teacher);
            }
        }

        private void ckPassed_CheckedChanged(object sender, EventArgs e)
        {
            if (ckPassed.Checked)
            {
                ckFailed.Checked = false;
            }
        }

        private void ckFailed_CheckedChanged(object sender, EventArgs e)
        {
            if (ckFailed.Checked)
            {
                ckPassed.Checked = false;
            }
        }

        private void ckExc_CheckedChanged(object sender, EventArgs e)
        {
            if (ckExc.Checked)
            {
                ckAttendance.Checked = false;
            }
        }

        private void ckAttendance_CheckedChanged(object sender, EventArgs e)
        {
            if (ckAttendance.Checked)
            {
                ckExc.Checked = false;
            }
        }

        private void ckGood_CheckedChanged(object sender, EventArgs e)
        {
            if (ckGood.Checked)
            {
                ckPart.Checked = false;
            }
        }

        private void ckAct_CheckedChanged(object sender, EventArgs e)
        {
            if (ckAct.Checked)
            {
                ckPeer.Checked = false;
            }
        }

        private void ckPeer_CheckedChanged(object sender, EventArgs e)
        {
            if (ckPeer.Checked)
            {
                ckAct.Checked = false;
            }
        }

        private void ckRes_CheckedChanged(object sender, EventArgs e)
        {
            if (ckRes.Checked)
            {
                ckResp.Checked = false;
            }
        }

        private void ckResp_CheckedChanged(object sender, EventArgs e)
        {
            if (ckResp.Checked)
            {
                ckRes.Checked = false;
            }
        }
    }
}
