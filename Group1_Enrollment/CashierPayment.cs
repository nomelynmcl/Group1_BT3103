using System.Data.SqlClient;
using System.Drawing.Printing;

namespace EventDriven.Project.UI
{
    public partial class CashierPayment : Form
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EnrollmentDB;Integrated Security=True";
        private ListBox lstSuggestions;

        // Variables to hold latest transaction for printing
        private string lastModeOfPayment;
        private decimal lastAmountPaid;
        private decimal lastRemainingBalance;
        private decimal lastChange;
        private int lastTransactionId;

        private PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;

        public CashierPayment()
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
            lstSuggestions.Width = CashierPayment_TXTBOX.Width;
            lstSuggestions.Location = new Point(CashierPayment_TXTBOX.Left, CashierPayment_TXTBOX.Bottom);
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

                    // Fill labels on form
                    CashierStuID_LBL.Text = id;
                    CashierStuName_LBL.Text = fullName;
                    CashierYLSection_LBL.Text = gradeSection;

                    CashierPayment_TXTBOX.Text = id;

                    // Load the payment mode for this student
                    LoadStudentPaymentInfo(id); // now studentId exists
                }

                lstSuggestions.Visible = false;
            }
        }


        private void CashierPayment_Load(object sender, EventArgs e)
        {
            dtRegDate.Text = DateTime.Now.ToString("MM/dd/yyyy");

            // Initialize CheckedListBox with payment modes
            clbModeOfPayment_CashierPay.Items.Clear();
            clbModeOfPayment_CashierPay.Items.Add("Cash");
            clbModeOfPayment_CashierPay.Items.Add("Low Down Payment");
            clbModeOfPayment_CashierPay.Items.Add("Low Quarterly Payment");

            // Ensure only one mode can be checked at a time
            clbModeOfPayment_CashierPay.ItemCheck += clbModeOfPayment_CashierPay_ItemCheck;

            // Initialize DataGridView
            CashierPayment_GridView.Columns.Clear();
            CashierPayment_GridView.Columns.Add("Item", "Item");
            CashierPayment_GridView.Columns.Add("BaseAmount", "Base Amount (₱)");
            CashierPayment_GridView.Columns.Add("AdjustedAmount", "Adjusted Amount (₱)");
        }

        private void CashierPayment_SearchBTN_Click(object sender, EventArgs e)
        {
            string searchText = CashierPayment_TXTBOX.Text.Trim();

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
                        SetPaymentMode(mode); // this will auto-check and autofill
                    }
                }
                LoadPaymentTransactions(studentId);


                // Then check if fully paid
                decimal remaining = GetCurrentBalance(studentId);
                CheckIfFullyPaid(remaining);
            }
        }
        private void CheckIfFullyPaid(decimal balance)
        {
            if (balance <= 0)
            {
                // Disable payment input and button
                txtCashierPay.Enabled = false;
                CashierConfirmPayment.Enabled = false;
            }
            else
            {
                // Enable again for future transactions
                txtCashierPay.Enabled = true;
                CashierConfirmPayment.Enabled = true;
            }
        }

        private void SetPaymentMode(string mode)
        {
            string normalizedMode = mode.Trim().ToLower();

            // Uncheck all first
            for (int i = 0; i < clbModeOfPayment_CashierPay.Items.Count; i++)
                clbModeOfPayment_CashierPay.SetItemChecked(i, false);

            // Determine which mode to check
            if (normalizedMode.Contains("cash"))
            {
                clbModeOfPayment_CashierPay.SetItemChecked(0, true);
                FillPaymentBreakdown("Cash");
            }
            else if (normalizedMode.Contains("low down"))
            {
                clbModeOfPayment_CashierPay.SetItemChecked(1, true);
                FillPaymentBreakdown("Low Down Payment");
            }
            else if (normalizedMode.Contains("low quarterly") || normalizedMode.Contains("installment"))
            {
                clbModeOfPayment_CashierPay.SetItemChecked(2, true);
                FillPaymentBreakdown("Low Quarterly Payment");
            }
            else
            {
                MessageBox.Show($"Unrecognized payment mode: {mode}", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void clbModeOfPayment_CashierPay_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Allow only one mode checked at a time
            if (e.NewValue == CheckState.Checked)
            {
                for (int i = 0; i < clbModeOfPayment_CashierPay.Items.Count; i++)
                {
                    if (i != e.Index)
                        clbModeOfPayment_CashierPay.SetItemChecked(i, false);
                }

                string selectedMode = clbModeOfPayment_CashierPay.Items[e.Index].ToString();
                FillPaymentBreakdown(selectedMode);
            }
        }

        private void FillPaymentBreakdown(string method)
        {
            CashierPayment_GridView.DataSource = null;
            CashierPayment_GridView.Rows.Clear();

            if (method == "Cash")
            {
                CashierPayment_GridView.Rows.Add("Tuition Fee", "2,000", "2,000");
                CashierPayment_GridView.Rows.Add("Miscellaneous Fee", "1,500", "1,500");
                CashierPayment_GridView.Rows.Add("Others", "1,700", "1,700");
                CashierPayment_GridView.Rows.Add("Total", "5,200", "5,200");
            }
            else if (method == "Low Down Payment")
            {
                CashierPayment_GridView.Rows.Add("Tuition Fee", "2,000", "2,500");
                CashierPayment_GridView.Rows.Add("Miscellaneous Fee", "1,500", "1,875");
                CashierPayment_GridView.Rows.Add("Others", "1,700", "2,125");
                CashierPayment_GridView.Rows.Add("Total", "5,200", "6,500");
                CashierPayment_GridView.Rows.Add("Down Payment", "-", "500");
                CashierPayment_GridView.Rows.Add("Remaining Balance", "-", "6,000");
                CashierPayment_GridView.Rows.Add("Quarterly Payment (4x)", "-", "1,500");
            }
            else if (method == "Low Quarterly Payment")
            {
                CashierPayment_GridView.Rows.Add("Tuition Fee", "2,000", "2,700");
                CashierPayment_GridView.Rows.Add("Miscellaneous Fee", "1,500", "2,025");
                CashierPayment_GridView.Rows.Add("Others", "1,700", "2,295");
                CashierPayment_GridView.Rows.Add("Total", "5,200", "7,020");
                CashierPayment_GridView.Rows.Add("Down Payment", "-", "500");
                CashierPayment_GridView.Rows.Add("Remaining Balance", "-", "6,520");
                CashierPayment_GridView.Rows.Add("Quarterly Payment (4x)", "-", "1,630");
            }
        }

        private void clbModeOfPayment_CashierPay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clbModeOfPayment_CashierPay.SelectedIndex == -1) return;

            // Allow only one checked at a time
            for (int i = 0; i < clbModeOfPayment_CashierPay.Items.Count; i++)
            {
                if (i != clbModeOfPayment_CashierPay.SelectedIndex)
                    clbModeOfPayment_CashierPay.SetItemChecked(i, false);
            }

            string selected = clbModeOfPayment_CashierPay.SelectedItem.ToString();
            FillPaymentBreakdown(selected);
        }

        private void CashierCompute_BTN_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(txtCashierPay.Text))
            {
                MessageBox.Show("Please enter the payment amount.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!decimal.TryParse(txtCashierPay.Text, out decimal payment))
            {
                MessageBox.Show("Invalid amount entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get selected mode
            string selectedMode = clbModeOfPayment_CashierPay.CheckedItems.Count > 0
                ? clbModeOfPayment_CashierPay.CheckedItems[0].ToString()
                : "";

            if (string.IsNullOrEmpty(selectedMode))
            {
                MessageBox.Show("Please select a mode of payment first.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int studentId = int.Parse(CashierStuID_LBL.Text);
            // Get total fee from DataGridView (assuming "Total" row or last row has the adjusted total)
            decimal totalAmount = 0;
            foreach (DataGridViewRow row in CashierPayment_GridView.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString().ToLower().Contains("total"))
                {
                    decimal.TryParse(row.Cells[2].Value.ToString(), out totalAmount);
                    break;
                }
            }

            // Reset labels
            CashierChange_LBL.Text = "";
            CashierRemaining_LBL.Text = "";

            // ---- CASH MODE ----
            if (selectedMode == "Cash")
            {
                if (payment < totalAmount)
                {
                    MessageBox.Show("Insufficient payment. Must be equal or greater than total.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                decimal change = totalAmount - payment;
                CashierChange_LBL.Text = $"₱{change:N2}";
                CashierRemaining_LBL.Text = "₱0.00";
            }

            // ---- INSTALLMENT (LDP / LMP) ----
            else
            {
                if (payment < 500)
                {
                    MessageBox.Show("Minimum down payment is ₱500.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal currentBalance = GetCurrentBalance(studentId);
                decimal remainingBalance = currentBalance - payment;

                if (remainingBalance > 0)
                {
                    CashierRemaining_LBL.Text = $"₱{remainingBalance.ToString()}";
                    CashierChange_LBL.Text = "₱0.00";
                }
                else
                {
                    decimal change = Math.Abs(remainingBalance); // payment > total
                    CashierRemaining_LBL.Text = "₱0.00";
                    CashierChange_LBL.Text = $"₱{change.ToString()}";
                }
            }
        }

        private void CashierConfirmPayment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CashierStuID_LBL.Text))
            {
                MessageBox.Show("Please select a student first.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int studentId = int.Parse(CashierStuID_LBL.Text);

            if (!decimal.TryParse(txtCashierPay.Text, out decimal amountPaid) || amountPaid <= 0)
            {
                MessageBox.Show("Please enter a valid payment amount.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (clbModeOfPayment_CashierPay.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select a mode of payment.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string modeOfPayment = clbModeOfPayment_CashierPay.CheckedItems[0].ToString();
            decimal currentBalance = GetCurrentBalance(studentId);
            decimal remainingBalance = currentBalance - amountPaid;
            decimal change = 0;

            if (remainingBalance < 0)
            {
                change = Math.Abs(remainingBalance);
                remainingBalance = 0;
            }

            // --- Insert the transaction and capture the TransactionId ---
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = @"INSERT INTO PaymentRecord 
             (Id, PaymentDate, ModeOfPayment, AmountPaid, RemainingBalance)
             VALUES (@StudentId, @PaymentDate, @ModeOfPayment, @AmountPaid, @RemainingBalance);
             SELECT SCOPE_IDENTITY();";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@StudentId", studentId);
                    cmd.Parameters.AddWithValue("@PaymentDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@ModeOfPayment", modeOfPayment);
                    cmd.Parameters.AddWithValue("@AmountPaid", amountPaid);
                    cmd.Parameters.AddWithValue("@RemainingBalance", remainingBalance);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        lastTransactionId = Convert.ToInt32(result);
                    }
                }
            }

            // --- Save details for printing ---
            lastModeOfPayment = modeOfPayment;
            lastAmountPaid = amountPaid;
            lastRemainingBalance = remainingBalance;
            lastChange = change;
            // --- Reload payment history ---
            LoadPaymentTransactions(studentId);

            CashierChange_LBL.Text = $"₱{change:N2}";
            CashierRemaining_LBL.Text = $"₱{remainingBalance:N2}";

            // --- Show confirmation with transaction ID ---
            MessageBox.Show($"Payment recorded successfully!\nTransaction ID: {lastTransactionId}",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            // --- Disable controls if fully paid ---
            if (remainingBalance <= 0)
            {
                txtCashierPay.Enabled = false;
                clbModeOfPayment_CashierPay.Enabled = false;
                CashierConfirmPayment.Enabled = false;
                MessageBox.Show("Payment completed. Student has fully settled.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ResetTransactionForm();
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
                            // ✅ We don’t clear the grid so that the breakdown stays
                            bool hasTransaction = false;
                            decimal latestRemaining = 0;

                            if (reader.HasRows)
                            {
                                // Add separation for clarity
                                CashierPayment_GridView.Rows.Add("", "", "");
                                CashierPayment_GridView.Rows.Add("— Past Transactions —", "", "");
                                CashierPayment_GridView.Rows.Add("", "", "");

                                while (reader.Read())
                                {
                                    hasTransaction = true;

                                    string date = Convert.ToDateTime(reader["PaymentDate"]).ToString("MM/dd/yyyy");
                                    string mode = reader["ModeOfPayment"].ToString();
                                    decimal amountPaid = Convert.ToDecimal(reader["AmountPaid"]);
                                    decimal remaining = Convert.ToDecimal(reader["RemainingBalance"]);
                                    latestRemaining = remaining;

                                    CashierPayment_GridView.Rows.Add($"{date} ({mode})",
                                        $"₱{amountPaid:N2}", $"₱{remaining:N2}");
                                }

                                if (hasTransaction)
                                {
                                    // Add final summary row
                                    CashierPayment_GridView.Rows.Add("", "", "");
                                    CashierPayment_GridView.Rows.Add("Current Remaining Balance", "", $"₱{latestRemaining:N2}");

                                    // Update label too
                                    CashierRemaining_LBL.Text = $"₱{latestRemaining:N2}";
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
            txtCashierPay.Text = "";
            CashierChange_LBL.Text = "₱0.00";
            // Keep payment mode selection for installments if needed
            CashierRemaining_LBL.Text = "";
        }

        private void CashierCancel_BTN_Click(object sender, EventArgs e)
        {
            CashierDashboard cashierDashboard = new CashierDashboard();
            cashierDashboard.Show();
            this.Close();
        }

        private void CashierView_BTN_Click(object sender, EventArgs e)
        {
            PrintReceipt();
        }

        private void PrintReceipt()
        {
            try
            {
                PrintDocument printDocument1 = new PrintDocument();
                printDocument1.PrintPage += PrintDocument1_PrintPage;

                // Set receipt-style paper size: 80mm x arbitrary height
                int width = 370;  // 80mm ≈ 3.15 inch → 315
                int height = 1000; // enough height for receipt content
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


            // Get the printable width of the page
            int pageWidth = e.PageBounds.Width;
            int rightMargin = e.MarginBounds.Right;

            // Helper function to center text
            void DrawCenteredString(string text, Font font, int yPos)
            {
                float textWidth = e.Graphics.MeasureString(text, font).Width;
                float x = (pageWidth - textWidth) / 2;  // compute center position
                e.Graphics.DrawString(text, font, Brushes.Black, x, yPos);
            }

            // Example usage:
            DrawCenteredString("ORION TECH-HIGH SCHOOL", headerFont, y);
            y += 25;
            DrawCenteredString("PAYMENT RECEIPT", headerFont, y);
            y += 25;
            g.DrawString("---------------------------------------------", regularFont, Brushes.Black, leftMargin, y);
            y += 15;

            g.DrawString($"Transaction ID: {lastTransactionId}", regularFont, Brushes.Black, leftMargin, y); y += 15;
            g.DrawString($"Date: {DateTime.Now}", regularFont, Brushes.Black, leftMargin, y); y += 15;

            g.DrawString($"Student ID: {CashierStuID_LBL.Text}", regularFont, Brushes.Black, leftMargin, y); y += 15;
            g.DrawString($"Name: {CashierStuName_LBL.Text}", regularFont, Brushes.Black, leftMargin, y); y += 20;


            // ✅ Get mode of payment safely
            string modeOfPayment = string.Empty;

            // Try from CheckedListBox first
            if (clbModeOfPayment_CashierPay.CheckedItems.Count > 0)
                modeOfPayment = clbModeOfPayment_CashierPay.CheckedItems[0].ToString();
            else if (clbModeOfPayment_CashierPay.SelectedItem != null)
                modeOfPayment = clbModeOfPayment_CashierPay.SelectedItem.ToString();
            // Fallback to stored value if available
            else if (!string.IsNullOrEmpty(lastModeOfPayment))
                modeOfPayment = lastModeOfPayment;
            else
                modeOfPayment = "N/A";
            // Optional: include Grade/Section if you store it
            g.DrawString($"Mode of Payment: {modeOfPayment}", regularFont, Brushes.Black, leftMargin, y); y += 20;

            // --- PAYMENT DETAILS ---
            g.DrawString("---------------------------------------------", regularFont, Brushes.Black, leftMargin, y); y += 15;
            g.DrawString("DESCRIPTION                           AMOUNT", regularFont, Brushes.Black, leftMargin, y); y += 15;
            g.DrawString("---------------------------------------------", regularFont, Brushes.Black, leftMargin, y); y += 15;

            // ✅ Safe conversions for numeric values
            decimal amountPaid = 0;
            decimal change = 0;
            decimal remaining = 0;

            decimal.TryParse(txtCashierPay.Text.Replace("₱", "").Trim(), out amountPaid);
            decimal.TryParse(CashierChange_LBL.Text.Replace("₱", "").Trim(), out change);
            decimal.TryParse(CashierRemaining_LBL.Text.Replace("₱", "").Trim(), out remaining);
            g.DrawString($"Amount Paid: ₱{lastAmountPaid}", regularFont, Brushes.Black, leftMargin, y); y += 15;
            g.DrawString($"Change: ₱{lastChange}", regularFont, Brushes.Black, leftMargin, y); y += 15;
            g.DrawString($"Remaining Balance: ₱{lastRemainingBalance}", regularFont, Brushes.Black, leftMargin, y); y += 15;

            g.DrawString("---------------------------------------------", regularFont, Brushes.Black, 10, y);
            y += 20;
            g.DrawString("Items Breakdown:", regularFont, Brushes.Black, 10, y);
            y += 20;

            // Add breakdown from DataGridView (optional)
            foreach (DataGridViewRow row in CashierPayment_GridView.Rows)
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
    }
}
