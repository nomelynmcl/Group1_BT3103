using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;

namespace EventDriven.Project.UI
{
    public partial class AdminPayment : Form
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EnrollmentDB;Integrated Security=True";
        private ListBox lstSuggestions;

        private string lastModeOfPayment;
        private decimal lastAmountPaid;
        private decimal lastRemainingBalance;
        private decimal lastChange;
        private int lastTransactionId;

        private PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;


        public AdminPayment()
        {
            InitializeComponent();
            InitializeSuggestionList();
        }

        private void InitializeSuggestionList()
        {
            lstSuggestions = new ListBox();
            lstSuggestions.Visible = false;
            lstSuggestions.Font = new Font("Segoe UI", 9);
            lstSuggestions.Height = 120;
            lstSuggestions.Width = AdminPayment_TXTBOX.Width;
            lstSuggestions.Location = new Point(AdminPayment_TXTBOX.Left, AdminPayment_TXTBOX.Bottom);
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
                    string id = parts[0].Trim();
                    string fullName = parts[1].Trim();
                    string gradeSection = parts[2].Trim();

                    AdminStuID_LBL.Text = id;
                    AdminStuName_LBL.Text = fullName;
                    AdminYLSection_LBL.Text = gradeSection;

                    AdminPayment_TXTBOX.Text = id;

                    LoadStudentPaymentInfo(id);
                }

                lstSuggestions.Visible = false;
            }
        }


        private void AdminPayment_Load(object sender, EventArgs e)
        {
            dtCurrDate.Value = DateTime.Now;

            clbModeOfPayment_AdminPay.Items.Clear();
            clbModeOfPayment_AdminPay.Items.Add("Cash");
            clbModeOfPayment_AdminPay.Items.Add("Low Down Payment");
            clbModeOfPayment_AdminPay.Items.Add("Low Quarterly Payment");

            clbModeOfPayment_AdminPay.ItemCheck += clbModeOfPayment_AdminPay_ItemCheck;

            AdminPayment_GridView.Columns.Clear();
            AdminPayment_GridView.Columns.Add("Item", "Item");
            AdminPayment_GridView.Columns.Add("BaseAmount", "Base Amount (₱)");
            AdminPayment_GridView.Columns.Add("AdjustedAmount", "Adjusted Amount (₱)");


        }

        private void AdminPayment_SearchBTN_Click(object sender, EventArgs e)
        {
            string searchText = AdminPayment_TXTBOX.Text.Trim();

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

        private void LoadStudentPaymentInfo(string id)
        {
            int studentId = int.Parse(id);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT ModeOfPayment FROM StudentRecord WHERE Id=@id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", studentId);
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string mode = result.ToString().Trim();
                        SetPaymentMode(mode);
                    }
                }
                LoadPaymentTransactions(studentId);

                decimal? remaining = GetCurrentBalance(studentId);
                CheckIfFullyPaid(remaining);
            }
        }

        private void CheckIfFullyPaid(decimal? balance)
        {
            if (!balance.HasValue)
            {
                txtAdminPayment.Enabled = true;
                AdminConfirmPayment.Enabled = true;
            }
            else if (balance.Value <= 0)
            {
                txtAdminPayment.Enabled = false;
                AdminConfirmPayment.Enabled = false;
            }
            else
            {
                txtAdminPayment.Enabled = true;
                AdminConfirmPayment.Enabled = true;
            }
        }

        private void SetPaymentMode(string mode)
        {
            string normalizedMode = mode.Trim().ToLower();

            for (int i = 0; i < clbModeOfPayment_AdminPay.Items.Count; i++)
                clbModeOfPayment_AdminPay.SetItemChecked(i, false);

            if (normalizedMode.Contains("cash"))
            {
                clbModeOfPayment_AdminPay.SetItemChecked(0, true);
                FillPaymentBreakdown("Cash");
            }
            else if (normalizedMode.Contains("low down"))
            {
                clbModeOfPayment_AdminPay.SetItemChecked(1, true);
                FillPaymentBreakdown("Low Down Payment");
            }
            else if (normalizedMode.Contains("low quarterly") || normalizedMode.Contains("installment"))
            {
                clbModeOfPayment_AdminPay.SetItemChecked(2, true);
                FillPaymentBreakdown("Low Quarterly Payment");
            }
            else
            {
                MessageBox.Show($"Unrecognized payment mode: {mode}", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void clbModeOfPayment_AdminPay_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                for (int i = 0; i < clbModeOfPayment_AdminPay.Items.Count; i++)
                {
                    if (i != e.Index)
                        clbModeOfPayment_AdminPay.SetItemChecked(i, false);
                }

                string selectedMode = clbModeOfPayment_AdminPay.Items[e.Index].ToString();
                FillPaymentBreakdown(selectedMode);
            }
        }

        private void FillPaymentBreakdown(string method)
        {
            AdminPayment_GridView.DataSource = null;
            AdminPayment_GridView.Rows.Clear();
            AdminPayment_GridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            int studentId = 0;
            if (!int.TryParse(AdminStuID_LBL.Text, out studentId))
                return;

            bool firstPayment = false;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM PaymentRecord WHERE Id=@Id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", studentId);
                    int count = (int)cmd.ExecuteScalar();
                    firstPayment = count == 0;
                }
            }

            if (method == "Cash")
            {
                AdminPayment_GridView.Rows.Add("Tuition Fee", "₱2,000", "₱2,000");
                AdminPayment_GridView.Rows.Add("Miscellaneous Fee", "₱1,500", "₱1,500");
                AdminPayment_GridView.Rows.Add("Others", "₱1,700", "₱1,700");
                AdminPayment_GridView.Rows.Add("Total", "₱5,200", "₱5,200");
            }
            else if (method == "Low Quarterly Payment")
            {
                if (firstPayment)
                {
                    AdminPayment_GridView.Rows.Add("Down Payment (Minimum)", "₱700", "₱700");
                    AdminPayment_GridView.Rows.Add("Tuition Fee", "₱2,000", "₱2,500");
                    AdminPayment_GridView.Rows.Add("Miscellaneous Fee", "₱1,500", "₱1,875");
                    AdminPayment_GridView.Rows.Add("Others", "₱1,700", "₱2,125");
                    AdminPayment_GridView.Rows.Add("Total", "₱5,200", "₱6,500");
                    AdminPayment_GridView.Rows.Add("Quarterly Payment (4x)", "", "₱1,450");
                }
            }
            else if (method == "Low Down Payment")
            {
                if (firstPayment)
                {
                    AdminPayment_GridView.Rows.Add("Down Payment (Minimum)", "₱500", "₱500");
                    AdminPayment_GridView.Rows.Add("Tuition Fee", "₱2,000", "₱2,700");
                    AdminPayment_GridView.Rows.Add("Miscellaneous Fee", "₱1,500", "₱2,025");
                    AdminPayment_GridView.Rows.Add("Others", "₱1,700", "₱2,295");
                    AdminPayment_GridView.Rows.Add("Total", "₱5,200", "₱7,020");
                    AdminPayment_GridView.Rows.Add("Quarterly Payment (4x)", "", "₱1,630");
                }
            }
        }

        private void clbModeOfPayment_AdminPay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clbModeOfPayment_AdminPay.SelectedIndex == -1) return;

            for (int i = 0; i < clbModeOfPayment_AdminPay.Items.Count; i++)
            {
                if (i != clbModeOfPayment_AdminPay.SelectedIndex)
                    clbModeOfPayment_AdminPay.SetItemChecked(i, false);
            }

            string selected = clbModeOfPayment_AdminPay.SelectedItem.ToString();
            FillPaymentBreakdown(selected);
        }

        private void AdminCompute_BTN_Click(object sender, EventArgs e)
        {
            decimal cashGiven = Convert.ToDecimal(txtCash.Text.Replace("₱", "").Replace(",", "").Trim());
            if (string.IsNullOrWhiteSpace(txtAdminPayment.Text))
            {
                MessageBox.Show("Please enter the payment amount.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string cleanPayment = txtAdminPayment.Text.Replace("₱", "").Replace(",", "").Trim();

            if (!decimal.TryParse(cleanPayment, out decimal payment))
            {
                MessageBox.Show("Invalid amount entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (clbModeOfPayment_AdminPay.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select a mode of payment first.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int studentId = int.Parse(AdminStuID_LBL.Text);
            string selectedMode = clbModeOfPayment_AdminPay.CheckedItems[0].ToString();
            bool firstPayment = false;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM PaymentRecord WHERE Id=@Id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", studentId);
                    int count = (int)cmd.ExecuteScalar();
                    firstPayment = count == 0;
                }
            }

            if (selectedMode == "Low Quarterly Payment")
            {
                if (firstPayment && payment < 700)
                {
                    MessageBox.Show("Down payment for Low Quarterly Payment must be at least ₱700.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (selectedMode == "Low Down Payment")
            {
                if (firstPayment && payment < 500)
                {
                    MessageBox.Show("Down payment for Low Down Payment must be at least ₱500.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            decimal? currentBalance = GetCurrentBalance(studentId);

            if (currentBalance == null)
            {
                foreach (DataGridViewRow row in AdminPayment_GridView.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString().ToLower().Contains("total"))
                    {
                        decimal.TryParse(row.Cells[2].Value.ToString().Replace(",", "").Replace("₱", ""), out decimal total);
                        currentBalance = total;
                        break;
                    }
                }
            }

            decimal change = cashGiven - payment;
            decimal newBalance = currentBalance.Value - payment;

            lbAdminPay_Remaining.Text = $"₱{newBalance:N2}";
            AdminChange_LBL.Text = $"₱{change:N2}";

            lastAmountPaid = payment;
            lastRemainingBalance = newBalance;
            lastChange = change;
            lastModeOfPayment = selectedMode;
        }

        private void AdminConfirmPayment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AdminStuID_LBL.Text))
            {
                MessageBox.Show("Please select a student first.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int studentId = int.Parse(AdminStuID_LBL.Text);

            if (!decimal.TryParse(txtAdminPayment.Text.Replace("₱", "").Trim(), out decimal amountPaid) || amountPaid <= 0)
            {
                MessageBox.Show("Please enter a valid payment amount.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (clbModeOfPayment_AdminPay.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select a mode of payment.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string modeOfPayment = clbModeOfPayment_AdminPay.CheckedItems[0].ToString();
            decimal? currentBalance = GetCurrentBalance(studentId);

            if (currentBalance == null)
            {
                foreach (DataGridViewRow row in AdminPayment_GridView.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString().ToLower().Contains("total"))
                    {
                        decimal.TryParse(row.Cells[2].Value.ToString().Replace(",", "").Replace("₱", ""), out decimal total);
                        currentBalance = total;
                        break;
                    }
                }
            }

            decimal remainingBalance = Math.Max(currentBalance.Value - amountPaid, 0);
            decimal change = Math.Max(amountPaid - currentBalance.Value, 0);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = @"INSERT INTO PaymentRecord 
                         (Id, PaymentDate, ModeOfPayment, AmountPaid, RemainingBalance)
                         VALUES (@StudentId, @PaymentDate, @ModeOfPayment, @AmountPaid, @RemainingBalance)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@StudentId", studentId);
                    cmd.Parameters.AddWithValue("@PaymentDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@ModeOfPayment", modeOfPayment);
                    cmd.Parameters.AddWithValue("@AmountPaid", amountPaid);
                    cmd.Parameters.AddWithValue("@RemainingBalance", remainingBalance);
                    cmd.ExecuteNonQuery();
                }

                if (amountPaid > 0)
                {
                    string updateStatusQuery = "UPDATE StudentRecord SET EnrollmentStatus=@Status WHERE Id=@StudentId";
                    using (SqlCommand cmd = new SqlCommand(updateStatusQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@Status", "Enrolled");
                        cmd.Parameters.AddWithValue("@StudentId", studentId);
                        cmd.ExecuteNonQuery();
                    }
                }

                string idQuery = "SELECT TOP 1 TransactionId FROM PaymentRecord WHERE Id=@Id ORDER BY TransactionId DESC";
                using (SqlCommand cmd = new SqlCommand(idQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Id", studentId);
                    object result = cmd.ExecuteScalar();
                    lastTransactionId = result != null ? Convert.ToInt32(result) : 0;
                }
            }

            lastAmountPaid = amountPaid;
            lastRemainingBalance = remainingBalance;
            lastChange = change;
            lastModeOfPayment = modeOfPayment;

            lbAdminPay_Remaining.Text = $"₱{remainingBalance:N2}";
            AdminChange_LBL.Text = $"₱{change:N2}";

            LoadPaymentTransactions(studentId);

            if (remainingBalance <= 0)
            {
                txtAdminPayment.Enabled = false;
                clbModeOfPayment_AdminPay.Enabled = false;
                AdminConfirmPayment.Enabled = false;
                MessageBox.Show($"Payment completed. Student has fully settled.\nTransaction ID: {lastTransactionId}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ResetTransactionForm();
                MessageBox.Show($"Payment recorded. You can proceed with next transaction.\nTransaction ID: {lastTransactionId}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private decimal? GetCurrentBalance(int studentId)
        {
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
                        return Convert.ToDecimal(result);
                    else
                        return null;
                }
            }
        }


        private void LoadPaymentTransactions(int studentId)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT TransactionId, PaymentDate, ModeOfPayment, AmountPaid, RemainingBalance " +
                                   "FROM PaymentRecord WHERE Id=@StudentId ORDER BY TransactionId ASC";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@StudentId", studentId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            bool hasTransaction = false;
                            decimal latestRemaining = 0;

                            if (reader.HasRows)
                            {
                                AdminPayment_GridView.Rows.Add("", "", "");
                                AdminPayment_GridView.Rows.Add("— Past Transactions —", "", "");
                                AdminPayment_GridView.Rows.Add("", "", "");

                                while (reader.Read())
                                {
                                    hasTransaction = true;

                                    string date = Convert.ToDateTime(reader["PaymentDate"]).ToString("MM/dd/yyyy");
                                    string mode = reader["ModeOfPayment"].ToString();
                                    decimal amountPaid = Convert.ToDecimal(reader["AmountPaid"]);
                                    decimal remaining = Convert.ToDecimal(reader["RemainingBalance"]);
                                    latestRemaining = remaining;

                                    AdminPayment_GridView.Rows.Add($"{date} ({mode})",
                                        $"₱{amountPaid:N2}", $"₱{remaining:N2}");
                                }

                                if (hasTransaction)
                                {
                                    AdminPayment_GridView.Rows.Add("", "", "");
                                    AdminPayment_GridView.Rows.Add("Current Remaining Balance", "", $"₱{latestRemaining:N2}");

                                    lbAdminPay_Remaining.Text = $"₱{latestRemaining:N2}";
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading payment transactions: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ResetTransactionForm()
        {
            txtAdminPayment.Text = "";
            AdminChange_LBL.Text = "₱0.00";
            lbAdminPay_Remaining.Text = "";
        }

        private void AdminCancel_BTN_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Close();
        }

        private void AdminView_BTN_Click(object sender, EventArgs e)
        {
            PrintReceipt();
        }

        private void PrintReceipt()
        {
            try
            {
                PrintDocument printDocument1 = new PrintDocument();
                printDocument1.PrintPage += PrintDocument1_PrintPage;

                int width = 370;
                int height = 1000;
                PaperSize receiptSize = new PaperSize("Receipt", width, height);

                printDocument1.DefaultPageSettings.PaperSize = receiptSize;
                printDocument1.DefaultPageSettings.Margins = new Margins(10, 10, 10, 10);
                printDocument1.DefaultPageSettings.Landscape = false;

                PrintPreviewDialog preview = new PrintPreviewDialog();
                preview.Document = printDocument1;
                preview.Width = 400;
                preview.Height = 600;
                preview.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error printing receipt: " + ex.Message);
            }
        }


        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font headerFont = new Font("Courier New", 12, FontStyle.Bold);
            Font regularFont = new Font("Courier New", 9);
            int y = 20;
            int leftMargin = 10;


            int pageWidth = e.PageBounds.Width;
            int rightMargin = e.MarginBounds.Right;

            void DrawCenteredString(string text, Font font, int yPos)
            {
                float textWidth = e.Graphics.MeasureString(text, font).Width;
                float x = (pageWidth - textWidth) / 2;
                e.Graphics.DrawString(text, font, Brushes.Black, x, yPos);
            }

            DrawCenteredString("ORION TECH-HIGH SCHOOL", headerFont, y);
            y += 25;
            DrawCenteredString("PAYMENT RECEIPT", headerFont, y);
            y += 25;

            g.DrawString($"Transaction ID: {lastTransactionId}", regularFont, Brushes.Black, leftMargin, y); y += 15;
            g.DrawString($"Date: {DateTime.Now}", regularFont, Brushes.Black, leftMargin, y); y += 15;

            g.DrawString($"Student ID: {AdminStuID_LBL.Text}", regularFont, Brushes.Black, leftMargin, y); y += 15;
            g.DrawString($"Name: {AdminStuName_LBL.Text}", regularFont, Brushes.Black, leftMargin, y); y += 20;

            string modeOfPayment = string.Empty;

            if (clbModeOfPayment_AdminPay.CheckedItems.Count > 0)
                modeOfPayment = clbModeOfPayment_AdminPay.CheckedItems[0].ToString();
            else if (clbModeOfPayment_AdminPay.SelectedItem != null)
                modeOfPayment = clbModeOfPayment_AdminPay.SelectedItem.ToString();
            else if (!string.IsNullOrEmpty(lastModeOfPayment))
                modeOfPayment = lastModeOfPayment;
            else
                modeOfPayment = "N/A";
            g.DrawString($"Mode of Payment: {modeOfPayment}", regularFont, Brushes.Black, leftMargin, y); y += 20;


            g.DrawString("---------------------------------------------", regularFont, Brushes.Black, leftMargin, y); y += 15;
            g.DrawString("DESCRIPTION                           AMOUNT", regularFont, Brushes.Black, leftMargin, y); y += 15;
            g.DrawString("---------------------------------------------", regularFont, Brushes.Black, leftMargin, y); y += 15;


            decimal amountPaid = 0;
            decimal change = 0;
            decimal remaining = 0;

            decimal.TryParse(txtAdminPayment.Text.Replace("₱", "").Trim(), out amountPaid);
            decimal.TryParse(AdminChange_LBL.Text.Replace("₱", "").Trim(), out change);
            decimal.TryParse(lbAdminPay_Remaining.Text.Replace("₱", "").Trim(), out remaining);
            g.DrawString($"Amount Paid: ₱{lastAmountPaid}", regularFont, Brushes.Black, leftMargin, y); y += 15;
            g.DrawString($"Change: ₱{lastChange}", regularFont, Brushes.Black, leftMargin, y); y += 15;
            g.DrawString($"Remaining Balance: ₱{lastRemainingBalance}", regularFont, Brushes.Black, leftMargin, y); y += 15;

            g.DrawString("---------------------------------------------", regularFont, Brushes.Black, 10, y);
            y += 20;
            g.DrawString("Items Breakdown:", regularFont, Brushes.Black, 10, y);
            y += 20;

            foreach (DataGridViewRow row in AdminPayment_GridView.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[1].Value != null && row.Cells[2].Value != null)
                {
                    string item = row.Cells[0].Value.ToString();
                    string baseAmt = row.Cells[1].Value.ToString();
                    string adjustedAmt = row.Cells[2].Value.ToString();

                    g.DrawString($"{item}: {adjustedAmt}", regularFont, Brushes.Black, 10, y);
                    y += 20;
                }
            }

            y += 10;
            g.DrawString("---------------------------------------------", regularFont, Brushes.Black, 10, y);
            y += 20;
            DrawCenteredString("Keep this receipt as proof of payment", regularFont, y);
        }

        private void pcAdminLogo2_Click(object sender, EventArgs e)
        {
            AdminDashboard dashboard = new AdminDashboard();
            dashboard.Show();
            this.Close();
        }

        private void btnAdminStudentInformation2_Click(object sender, EventArgs e)
        {
            AdminStudentInformation adminStudentInformation = new AdminStudentInformation();
            adminStudentInformation.Show();
            this.Close();
        }

        private void btnAdminAssessment2_Click(object sender, EventArgs e)
        {
            AdminAssesment assessment = new AdminAssesment();
            assessment.Show();
            this.Close();
        }

        private void btnAdminStudreg2_Click(object sender, EventArgs e)
        {
            AdminStudentRegistration adminStudentRegistration = new AdminStudentRegistration();
            adminStudentRegistration.Show();
            this.Close();
        }

        private void btnAdminHistory2_Click(object sender, EventArgs e)
        {
            AdminPaymentHistory adminPaymentHistory = new AdminPaymentHistory();
            adminPaymentHistory.Show();
            this.Close();
        }

        private void btnAdminReport2_Click(object sender, EventArgs e)
        {
            AdminReport adminReport = new AdminReport();
            adminReport.Show();
            this.Close();
        }

        private void btnAdminOut2_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void txtAdminPayment_TextChanged(object sender, EventArgs e)
        {
            if (txtAdminPayment.Text.StartsWith("₱"))
                return;

            string raw = txtAdminPayment.Text.Replace("₱", "").Trim();

            txtAdminPayment.Text = "₱" + raw;
            txtAdminPayment.SelectionStart = txtAdminPayment.Text.Length;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void AdminChange_LBL_Click(object sender, EventArgs e)
        {

        }
        
        private void txtCash_TextChanged_1(object sender, EventArgs e)
        {
            if (txtCash.Text.StartsWith("₱"))
                return;

            string raw = txtCash.Text.Replace("₱", "").Replace(",", "").Trim();

            txtCash.Text = "₱" + raw;
            txtCash.SelectionStart = txtCash.Text.Length;
        }
    }
}
