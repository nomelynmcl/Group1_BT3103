using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Security.Cryptography;
using EventDriven.Project.Model;

namespace EventDriven.Project.UI
{
    public partial class AdminReport : Form
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EnrollmentDB;Integrated Security=True";
        private List<StudentAssessmentModel> studentSearch;

        private string selectedStudentId = "";
        private string selectedStudentName = "";
        private string selectedGradeSection = "";
        private string selectedStudentType = "";
        private string selectedModeOfPayment = "";

        public AdminReport()
        {
            InitializeComponent();
            studentSearch = new List<StudentAssessmentModel>();

        }

        private void AdminReport_Load(object sender, EventArgs e)
        {
            LoadCounts();
            LoadEnrolledStudents();
            SetupSOAGrid();
            LoadStudentRecords();

        }

        private void LoadCounts()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd1 = new SqlCommand(
                    "SELECT COUNT(DISTINCT Id) FROM PaymentRecord WHERE AmountPaid >= 500", conn);
                AR_NOES.Text = cmd1.ExecuteScalar().ToString();

                SqlCommand cmd2 = new SqlCommand(
                    "SELECT COUNT(*) FROM StudentRecord WHERE Id NOT IN (SELECT DISTINCT Id FROM PaymentRecord)", conn);
                AR_NOE.Text = cmd2.ExecuteScalar().ToString();

                SqlCommand cmd3 = new SqlCommand(
                    "SELECT COUNT(*) FROM PaymentRecord WHERE CAST(PaymentDate AS DATE) = CAST(GETDATE() AS DATE)", conn);
                AR_NOTD.Text = cmd3.ExecuteScalar().ToString();
            }
        }

        private void LoadEnrolledStudents()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT DISTINCT s.Id, s.FirstName, s.MiddleName, s.LastName, 
                                s.GradeLevel, s.Section, s.StudentType, s.ModeOfPayment
                         FROM StudentRecord s
                         INNER JOIN PaymentRecord p ON s.Id = p.Id
                         WHERE p.AmountPaid >= 500
                         ORDER BY s.LastName ASC";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                AR_LOE_GRID.DataSource = dt;
            }
        }


        private void SetupSOAGrid()
        {
            AR_SOA_GRID.Columns.Clear();
            AR_SOA_GRID.Columns.Add("Description", "Description");
            AR_SOA_GRID.Columns.Add("Amount", "Amount");

            AR_SOA_GRID.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void AR_LOE_GRID_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void LoadSOA(string modeOfPayment)
        {
            AR_SOA_GRID.Rows.Add("FEE BREAKDOWN", "", "", "", "", "");

            if (string.IsNullOrEmpty(modeOfPayment)) return;


            if (modeOfPayment == "Cash")
            {
                AR_SOA_GRID.Rows.Add("Tuition Fee", "₱2,000");
                AR_SOA_GRID.Rows.Add("Miscellaneous Fee", "₱1,500");
                AR_SOA_GRID.Rows.Add("Others", "₱1,700");
                AR_SOA_GRID.Rows.Add("Total", "₱5,200");
            }
            else if (modeOfPayment == "Low Quarterly Payment")
            {
                AR_SOA_GRID.Rows.Add("Tuition Fee", "₱2,500");
                AR_SOA_GRID.Rows.Add("Miscellaneous Fee", "₱1,875");
                AR_SOA_GRID.Rows.Add("Others", "₱2,125");
                AR_SOA_GRID.Rows.Add("Total", "₱6,500");
                AR_SOA_GRID.Rows.Add("");
                AR_SOA_GRID.Rows.Add("Required Down Payment", "₱700");
                AR_SOA_GRID.Rows.Add("Quarterly Payment", "₱1,450");
            }
            else if (modeOfPayment == "Low Down Payment")
            {
                AR_SOA_GRID.Rows.Add("Tuition Fee", "₱2,700");
                AR_SOA_GRID.Rows.Add("Miscellaneous Fee", "₱2,025");
                AR_SOA_GRID.Rows.Add("Others", "₱2,295");
                AR_SOA_GRID.Rows.Add("Total", "₱7,020");
                AR_SOA_GRID.Rows.Add("Required Down Payment", "₱500");
                AR_SOA_GRID.Rows.Add("");
                AR_SOA_GRID.Rows.Add("Quarterly Payment", "₱1,630");
            }
        }

        

        private void btnViewSOA_Click_1(object sender, EventArgs e)
        {
            if (AR_LOE_GRID.CurrentRow == null) return;

            int studentId = Convert.ToInt32(AR_LOE_GRID.CurrentRow.Cells["Id"].Value);
            string modeOfPayment = AR_LOE_GRID.CurrentRow.Cells["ModeOfPayment"].Value.ToString();

            AR_SOA_GRID.Rows.Clear();

            LoadSOA(modeOfPayment);

            decimal latestRemaining = GetUpdatedRemainingBalance(studentId);
            AR_SOA_GRID.Rows.Add("Updated Remaining", $"₱{latestRemaining:N2}");

        }

        private decimal GetUpdatedRemainingBalance(int studentId)
        {
            decimal remainingBalance = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = @"SELECT TOP 1 RemainingBalance 
                                 FROM PaymentRecord 
                                 WHERE Id=@Id 
                                 ORDER BY TransactionId DESC";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", studentId);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                        remainingBalance = Convert.ToDecimal(result);
                }
            }
            return remainingBalance;
        }


        private void AR_PRINT_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                PrintDocument printDocument1 = new PrintDocument();
                printDocument1.PrintPage += PrintDocument1_PrintPage;

                int width = 500;  
                int height = 700; 
                PaperSize receiptSize = new PaperSize("Receipt", width, height);

                printDocument1.DefaultPageSettings.PaperSize = receiptSize;
                printDocument1.DefaultPageSettings.Margins = new Margins(10, 10, 10, 10);
                printDocument1.DefaultPageSettings.Landscape = false;

                PrintPreviewDialog preview = new PrintPreviewDialog();
                preview.Document = printDocument1;
                preview.Width = 500;
                preview.Height = 700;
                preview.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error printing receipt: " + ex.Message);
            }
        }

        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            Font schoolFont = new Font("Cambria", 16, FontStyle.Bold);
            Font titleFont = new Font("Cambria", 14, FontStyle.Bold);
            Font labelFont = new Font("Cambria", 12, FontStyle.Bold);
            Font valueFont = new Font("Cambria", 12);

            int pageWidth = e.PageBounds.Width;
            int pageHeight = e.PageBounds.Height;
            int startX = 50;
            int startY = 50;
            float offsetY = 0;

            string schoolName = "Orion Tech-High School";
            SizeF schoolSize = g.MeasureString(schoolName, schoolFont);
            g.DrawString(schoolName, schoolFont, Brushes.Black, (pageWidth - schoolSize.Width) / 2, startY + offsetY);
            offsetY += 40;

            string title = "STATEMENT OF ACCOUNT";
            SizeF titleSize = g.MeasureString(title, titleFont);
            g.DrawString(title, titleFont, Brushes.Black, (pageWidth - titleSize.Width) / 2, startY + offsetY);
            offsetY += 40;

            if (AR_LOE_GRID.CurrentRow != null)
            {
                string studentId = AR_LOE_GRID.CurrentRow.Cells["Id"].Value.ToString();
                string studentName = $"{AR_LOE_GRID.CurrentRow.Cells["FirstName"].Value} {AR_LOE_GRID.CurrentRow.Cells["MiddleName"].Value} {AR_LOE_GRID.CurrentRow.Cells["LastName"].Value}";
                string gradeSection = $"{AR_LOE_GRID.CurrentRow.Cells["GradeLevel"].Value} - {AR_LOE_GRID.CurrentRow.Cells["Section"].Value}";
                string studentType = AR_LOE_GRID.CurrentRow.Cells["StudentType"].Value.ToString();
                string modeOfPayment = AR_LOE_GRID.CurrentRow.Cells["ModeOfPayment"].Value.ToString();

                void DrawLabelValue(string label, string value)
                {
                    g.DrawString(label, labelFont, Brushes.Black, startX, startY + offsetY);
                    float labelWidth = g.MeasureString(label, labelFont).Width;
                    g.DrawString(value, valueFont, Brushes.Black, startX + labelWidth, startY + offsetY);
                    offsetY += 25;
                }

                DrawLabelValue("Student ID: ", studentId);
                DrawLabelValue("Name: ", studentName);
                DrawLabelValue("Grade - Section: ", gradeSection);
                DrawLabelValue("Student Type: ", studentType);
                DrawLabelValue("Mode of Payment: ", modeOfPayment);

                offsetY += 10; 
            }

            int tableStartY = startY + (int)offsetY;
            int rowHeight = 25;
            int col1Width = 250;
            int col2Width = 100;
            int col1X = startX;
            int col2X = col1X + col1Width; 

            g.FillRectangle(Brushes.LightGray, col1X, tableStartY, col1Width, rowHeight);
            g.FillRectangle(Brushes.LightGray, col2X, tableStartY, col2Width, rowHeight);
            g.DrawRectangle(Pens.Black, col1X, tableStartY, col1Width, rowHeight);
            g.DrawRectangle(Pens.Black, col2X, tableStartY, col2Width, rowHeight);
            g.DrawString("Description", labelFont, Brushes.Black, col1X + 5, tableStartY + 5);
            g.DrawString("Amount", labelFont, Brushes.Black, col2X + 5, tableStartY + 5);

            float currentY = tableStartY + rowHeight;

            foreach (DataGridViewRow row in AR_SOA_GRID.Rows)
            {
                if (row.IsNewRow) continue;

                string description = row.Cells["Description"].Value?.ToString() ?? "";
                string amount = row.Cells["Amount"].Value?.ToString() ?? "";

                if (string.IsNullOrEmpty(description) && string.IsNullOrEmpty(amount))
                    continue; 

                g.DrawRectangle(Pens.Black, col1X, currentY, col1Width, rowHeight);
                g.DrawRectangle(Pens.Black, col2X, currentY, col2Width, rowHeight);
                g.DrawString(description, valueFont, Brushes.Black, col1X + 5, currentY + 5);
                g.DrawString(amount, valueFont, Brushes.Black, col2X + 5, currentY + 5);

                currentY += rowHeight; 
            }

            string printedOn = $"Printed on: {DateTime.Now:MMMM dd, yyyy hh:mm tt}";
            SizeF printedSize = g.MeasureString(printedOn, valueFont);
            g.DrawString(printedOn, valueFont, Brushes.Gray, (pageWidth - printedSize.Width) / 2, pageHeight - 40);
        }




        private void AR_LOE_BTN_Click(object sender, EventArgs e)
        {
            string searchValue = AR_LOE_TXTBOX.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchValue))
            {
                AR_LOE_GRID.DataSource = new BindingSource { DataSource = studentSearch };
                return;
            }

            var filtered = studentSearch.Where(s =>
                s.Id.ToString().ToLower().Contains(searchValue) ||
                (!string.IsNullOrEmpty(s.Firstname) && s.Firstname.ToLower().Contains(searchValue)) ||
                (!string.IsNullOrEmpty(s.Middlename) && s.Middlename.ToLower().Contains(searchValue)) ||
                (!string.IsNullOrEmpty(s.Lastname) && s.Lastname.ToLower().Contains(searchValue)));

            if (filtered.Count() == 0)
            {
                MessageBox.Show("No matching student found.");
            }
            AR_LOE_GRID.DataSource = new BindingSource { DataSource = filtered };
        }

        public void LoadStudentRecords()
        {
            try
            {
                string query = "SELECT Id, FirstName, LastName, MiddleName, Gender, Age, Birthdate, GradeLevel, Section, StudentType, ModeOfPayment, EnrollmentStatus FROM StudentRecord";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        List<StudentAssessmentModel> records = new List<StudentAssessmentModel>();

                        while (reader.Read())
                        {
                            records.Add(new StudentAssessmentModel
                            {
                                Id = Convert.ToInt32(reader["Id"].ToString()),
                                Firstname = reader["FirstName"].ToString(),
                                Lastname = reader["LastName"].ToString(),
                                Middlename = reader["MiddleName"].ToString(),
                                Age = Convert.ToInt32(reader["Age"].ToString()),
                                Birthdate = Convert.ToDateTime(reader["Birthdate"].ToString()),
                                Gender = reader["Gender"].ToString(),
                                GradeLevel = Convert.ToInt32(reader["GradeLevel"].ToString()),
                                Section = reader["Section"].ToString(),
                                StudentType = reader["StudentType"].ToString(),
                                ModeOfPayment = reader["ModeOfPayment"].ToString(),
                                EnrollmentStatus = reader["EnrollmentStatus"].ToString()
                            });
                        }

                        studentSearch = records;
                        AR_LOE_GRID.DataSource = new BindingSource { DataSource = studentSearch };
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading records: " + ex.Message);
            }

        }

        private void btnAdminStudentInformation3_Click(object sender, EventArgs e)
        {
            AdminStudentInformation info = new AdminStudentInformation();
            info.Show();
            this.Close();
        }

        private void btnAdminAssessment3_Click(object sender, EventArgs e)
        {
            AdminAssesment assessment = new AdminAssesment();
            assessment.Show();
            this.Close();
        }

        private void btnAdminStudreg3_Click(object sender, EventArgs e)
        {
            AdminStudentRegistration registration = new AdminStudentRegistration();
            registration.Show();
            this.Close();
        }

        private void btnAdminPay3_Click(object sender, EventArgs e)
        {
            AdminPayment pay = new AdminPayment();
            pay.Show();
            this.Close();
        }

        private void btnAdminHistory3_Click(object sender, EventArgs e)
        {
            AdminPaymentHistory history = new AdminPaymentHistory();
            history.Show();
            this.Close();
        }

        private void btnAdminOut3_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void pcAdminLogo3_Click(object sender, EventArgs e)
        {
            AdminDashboard dashboard = new AdminDashboard();
            dashboard.Show();
            this.Close();
        }
    }
}

