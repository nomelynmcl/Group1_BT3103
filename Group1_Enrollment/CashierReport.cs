using System.Data.SqlClient;
using System.Drawing.Printing;

namespace EventDriven.Project.UI
{
    public partial class CashierReport : Form
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EnrollmentDB;Integrated Security=True";
        private ListBox lstSuggestions;

        private string selectedStudentId = "";
        private string selectedStudentName = "";
        private string selectedGradeSection = "";
        private string selectedStudentType = "";
        private string selectedModeOfPayment = "";

        public CashierReport()
        {
            InitializeComponent();
            InitializeSuggestionList();
        }

        private void CashierReport_Load(object sender, EventArgs e)
        {
            SetupSOAGrid();
            LoadCounts();
        }

        private void LoadCounts()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd1 = new SqlCommand(
                    "SELECT COUNT(*) FROM PaymentRecord WHERE CAST(PaymentDate AS DATE) = CAST(GETDATE() AS DATE)", conn);
                SR_NOTD.Text = cmd1.ExecuteScalar().ToString();
            }
        }

        private void SetupSOAGrid()
        {
            SR_SOA_GRID.Columns.Clear();
            SR_SOA_GRID.Columns.Add("Description", "Description");
            SR_SOA_GRID.Columns.Add("Amount", "Amount");
            SR_SOA_GRID.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void InitializeSuggestionList()
        {
            lstSuggestions = new ListBox();
            lstSuggestions.Visible = false;
            lstSuggestions.Font = new Font("Segoe UI", 9);
            lstSuggestions.Height = 120;
            lstSuggestions.Width = SR_SOA_TXTBOX.Width;
            lstSuggestions.Location = new Point(SR_SOA_TXTBOX.Left, SR_SOA_TXTBOX.Bottom);
            lstSuggestions.Click += lstSuggestions_Click;
            this.Controls.Add(lstSuggestions);
        }

        private void lstSuggestions_Click(object sender, EventArgs e)
        {
            if (lstSuggestions.SelectedItem != null)
            {
                string selectedText = lstSuggestions.SelectedItem.ToString();
                string[] parts = selectedText.Split('|');
                if (parts.Length >= 3)
                {
                    selectedStudentId = parts[0].Trim();
                    selectedStudentName = parts[1].Trim();
                    selectedGradeSection = parts[2].Trim();


                    LoadStudentPaymentInfo(selectedStudentId);
                }

                lstSuggestions.Visible = false;
            }
        }

        private void LoadStudentPaymentInfo(string id)
        {
            SR_SOA_GRID.Rows.Clear();

            int studentId = int.Parse(id);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT ModeOfPayment, StudentType FROM StudentRecord WHERE Id=@id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", studentId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            selectedModeOfPayment = reader["ModeOfPayment"].ToString().Trim();
                            selectedStudentType = reader["StudentType"].ToString().Trim();
                            SetPaymentMode(selectedModeOfPayment);
                        }
                    }
                }

                decimal remaining = GetCurrentBalance(studentId);
                SR_SOA_GRID.Rows.Add("Updated Remaining",$"₱{remaining:N2}");
            }
        }

        private void SetPaymentMode(string mode)
        {

            if (mode == "Cash")
            {
                SR_SOA_GRID.Rows.Add("Tuition Fee", "₱2,000");
                SR_SOA_GRID.Rows.Add("Miscellaneous Fee", "₱1,500");
                SR_SOA_GRID.Rows.Add("Others", "₱1,700");
                SR_SOA_GRID.Rows.Add("Total", "₱5,200");
            }
            else if (mode == "Low Quarterly Payment")
            {
                SR_SOA_GRID.Rows.Add("Tuition Fee", "₱2,500");
                SR_SOA_GRID.Rows.Add("Miscellaneous Fee", "₱1,875");
                SR_SOA_GRID.Rows.Add("Others", "₱2,125");
                SR_SOA_GRID.Rows.Add("Total", "₱6,500");
                SR_SOA_GRID.Rows.Add("Required Down Payment", "₱700");
                SR_SOA_GRID.Rows.Add("");
                SR_SOA_GRID.Rows.Add("Quarterly Payment", "₱1,450");
            }
            else if (mode == "Low Down Payment")
            {
                SR_SOA_GRID.Rows.Add("Tuition Fee", "₱2,700");
                SR_SOA_GRID.Rows.Add("Miscellaneous Fee", "₱2,025");
                SR_SOA_GRID.Rows.Add("Others", "₱2,295");
                SR_SOA_GRID.Rows.Add("Total", "₱7,020");
                SR_SOA_GRID.Rows.Add("Required Down Payment", "₱500");
                SR_SOA_GRID.Rows.Add("");
                SR_SOA_GRID.Rows.Add("Quarterly Payment", "₱1,630");
            }
        }

        private decimal GetCurrentBalance(int studentId)
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

        private void SR_SOA_BTN_Click(object sender, EventArgs e)
        {
            string searchText = SR_SOA_TXTBOX.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter an ID or name to search.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                lstSuggestions.Items.Clear();

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = @"
                        SELECT Id, FirstName, MiddleName, LastName, GradeLevel, Section
                        FROM StudentRecord
                        WHERE Id LIKE @search
                           OR FirstName LIKE @search
                           OR MiddleName LIKE @search
                           OR LastName LIKE @search
                           OR CONCAT(FirstName, ' ', MiddleName, ' ', LastName) LIKE @search";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string fullName = $"{reader["FirstName"]} {reader["MiddleName"]} {reader["LastName"]}".Replace("  ", " ").Trim();
                                string gradeSection = $"{reader["GradeLevel"]} - {reader["Section"]}";
                                string item = $"{reader["Id"]} | {fullName} | {gradeSection}";
                                lstSuggestions.Items.Add(item);
                            }
                        }
                    }
                }

                if (lstSuggestions.Items.Count > 0)
                {
                    lstSuggestions.Visible = true;
                    lstSuggestions.BringToFront();
                }
                else
                {
                    lstSuggestions.Visible = false;
                    MessageBox.Show("No matching student found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during search: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SR_PRINT_BTN_Click(object sender, EventArgs e)
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

            void DrawLabelValue(string label, string value)
            {
                g.DrawString(label, labelFont, Brushes.Black, startX, startY + offsetY);
                float labelWidth = g.MeasureString(label, labelFont).Width;
                g.DrawString(value, valueFont, Brushes.Black, startX + labelWidth, startY + offsetY);
                offsetY += 25;
            }

            DrawLabelValue("Student ID: ", selectedStudentId);
            DrawLabelValue("Name: ", selectedStudentName);
            DrawLabelValue("Grade - Section: ", selectedGradeSection);
            DrawLabelValue("Student Type: ", selectedStudentType);
            DrawLabelValue("Mode of Payment: ", selectedModeOfPayment);

            offsetY += 10;

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

            foreach (DataGridViewRow row in SR_SOA_GRID.Rows)
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

        private void btnAdminPay2_Click(object sender, EventArgs e)
        {
            CashierPayment pay = new CashierPayment();
            pay.Show();
            this.Close();
        }

        private void btnAdminHistory2_Click(object sender, EventArgs e)
        {
            Cashier_PaymentHistory history = new Cashier_PaymentHistory();
            history.Show();
            this.Close();
        }

        private void btnAdminOut2_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void pcAdminLogo2_Click(object sender, EventArgs e)
        {
            CashierDashboard dashboard = new CashierDashboard();
            dashboard.Show();
            this.Close();
        }
    }
}
