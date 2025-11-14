using System.Data.SqlClient;

namespace EventDriven.Project.UI
{
    public partial class Cashier_ViewPaymentHistory : Form
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EnrollmentDB;Integrated Security=True";
        private string fullName;
        private string yearSec;

        public Cashier_ViewPaymentHistory(
            int id,
                string firstName,
                string middleName,
                string lastName,
                int gradeLevel,
                string section,
                string studentType,
                string modeOfPayment,
                string enrollmentStatus,
                int transactionId,
                DateTime paymentDate,
                decimal amountPaid)
        {
            InitializeComponent();

            this.fullName = $"{lastName}, {firstName} {middleName}".Replace("  ", " ").Trim();
            this.yearSec = $"{gradeLevel} - {section}".Replace(" ", " ").Trim();
            lblStudentID_ViewPaymentHistory_Cashier.Text = id.ToString();
            lblStudentName_ViewPaymentHistory_Cashier.Text = fullName;
            lblYearLevelSection_ViewPaymentHistory_Cashier.Text = yearSec;
            lbtypeHistory.Text = studentType;
            lbStatusHistory.Text = enrollmentStatus;
            lbModeHistory.Text = modeOfPayment;

            LoadCharges(modeOfPayment);
            SetupPaymentGrid();
            LoadPaymentTransactions(id);
        }

        private void LoadCharges(string modeOfPayment)
        {
            dtgCharges_ViewPaymentHistory_Cashier.Columns.Clear();
            dtgCharges_ViewPaymentHistory_Cashier.Columns.Add("Description", "Description");
            dtgCharges_ViewPaymentHistory_Cashier.Columns.Add("Amount", "Amount");
            dtgCharges_ViewPaymentHistory_Cashier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (modeOfPayment == "Cash")
            {
                dtgCharges_ViewPaymentHistory_Cashier.Rows.Add("Tuition Fee", "2,000");
                dtgCharges_ViewPaymentHistory_Cashier.Rows.Add("Miscellaneous Fee", "1,500");
                dtgCharges_ViewPaymentHistory_Cashier.Rows.Add("Others", "1,700");
                dtgCharges_ViewPaymentHistory_Cashier.Rows.Add("Total", "5,200");
            }
            else if (modeOfPayment == "Low Down Payment")
            {
                dtgCharges_ViewPaymentHistory_Cashier.Rows.Add("Tuition Fee", "2,500");
                dtgCharges_ViewPaymentHistory_Cashier.Rows.Add("Miscellaneous Fee", "1,875");
                dtgCharges_ViewPaymentHistory_Cashier.Rows.Add("Others", "2,125");
                dtgCharges_ViewPaymentHistory_Cashier.Rows.Add("Total", "6,500");
                dtgCharges_ViewPaymentHistory_Cashier.Rows.Add("");
                dtgCharges_ViewPaymentHistory_Cashier.Rows.Add("Down Payment", "500");
                dtgCharges_ViewPaymentHistory_Cashier.Rows.Add("Remaining Balance", "6,000");
                dtgCharges_ViewPaymentHistory_Cashier.Rows.Add("Quarterly Payment (4x)", "1,500");
            }
            else if (modeOfPayment == "Low Quarterly Payment")
            {
                dtgCharges_ViewPaymentHistory_Cashier.Rows.Add("Tuition Fee", "2,700");
                dtgCharges_ViewPaymentHistory_Cashier.Rows.Add("Miscellaneous Fee", "2,025");
                dtgCharges_ViewPaymentHistory_Cashier.Rows.Add("Others", "2,295");
                dtgCharges_ViewPaymentHistory_Cashier.Rows.Add("Total", "7,020");
                dtgCharges_ViewPaymentHistory_Cashier.Rows.Add("Down Payment", "500");
                dtgCharges_ViewPaymentHistory_Cashier.Rows.Add("");
                dtgCharges_ViewPaymentHistory_Cashier.Rows.Add("Remaining Balance", "6,520");
                dtgCharges_ViewPaymentHistory_Cashier.Rows.Add("Quarterly Payment (4x)", "1,630");
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
                            // ✅ We don’t clear the grid so that the breakdown stays
                            bool hasTransaction = false;
                            decimal latestRemaining = 0;

                            while (reader.Read())
                            {
                                hasTransaction = true;

                                int transactionId = Convert.ToInt32(reader["TransactionId"]);
                                string date = Convert.ToDateTime(reader["PaymentDate"]).ToString("MM/dd/yyyy");
                                string mode = reader["ModeOfPayment"].ToString();
                                decimal amountPaid = Convert.ToDecimal(reader["AmountPaid"]);
                                decimal remaining = Convert.ToDecimal(reader["RemainingBalance"]);
                                latestRemaining = remaining;

                                dtgPayment_ViewPaymentHistory_Cashier.Rows.Add(transactionId, $"{date} ",
                                    $"₱{amountPaid:N2}", $"₱{remaining:N2}");
                            }

                            if (hasTransaction)
                            {
                                dtgPayment_ViewPaymentHistory_Cashier.Rows.Add("", "", "");
                                dtgPayment_ViewPaymentHistory_Cashier.Rows.Add("Current Remaining Balance", "", $"₱{latestRemaining:N2}");

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

        private void SetupPaymentGrid()
        {
            dtgPayment_ViewPaymentHistory_Cashier.Columns.Clear();
            dtgPayment_ViewPaymentHistory_Cashier.Columns.Add("TransactionId", "Transaction ID");
            dtgPayment_ViewPaymentHistory_Cashier.Columns.Add("PaymentDate", "Payment Date (Mode)");
            dtgPayment_ViewPaymentHistory_Cashier.Columns.Add("AmountPaid", "Amount Paid");
            dtgPayment_ViewPaymentHistory_Cashier.Columns.Add("RemainingBalance", "Remaining Balance");
            dtgPayment_ViewPaymentHistory_Cashier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnBack_ViewPaymentHistory_Cashier_Click(object sender, EventArgs e)
        {
            Cashier_PaymentHistory history = new Cashier_PaymentHistory();
            history.Show();
            this.Close();
        }

        private void btnPayment_ViewPaymentHistory_Cashier_Click(object sender, EventArgs e)
        {
            CashierPayment payment = new CashierPayment();
            payment.Show();
            this.Close();
        }

        private void btnLogout_ViewPaymentHistory_Cashier_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void pcCashier_ViewPaymentHistory__Click(object sender, EventArgs e)
        {
            CashierDashboard cashierDashboard = new CashierDashboard();
            cashierDashboard.Show();
            this.Close();
        }
    }
}
