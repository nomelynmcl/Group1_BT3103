using System.Data.SqlClient;

namespace EventDriven.Project.UI
{
    public partial class AdminViewPaymentHistory : Form
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EnrollmentDB;Integrated Security=True";
        private string fullName;
        private string yearSec;

        public AdminViewPaymentHistory(
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
            lblStudentID_ViewPaymentHistory_Admin.Text = id.ToString();
            lblStudentName_ViewPaymentHistory_Admin.Text = fullName;
            lblYearLevelSection_ViewPaymentHistory_Admin.Text = yearSec;
            lbStudentType_History.Text = studentType;
            lbStatusHistory.Text = enrollmentStatus;
            lbModeHistory.Text = modeOfPayment;

            LoadCharges(modeOfPayment);
            SetupPaymentGrid();
            LoadPaymentTransactions(id);

        }

        private void LoadCharges(string modeOfPayment)
        {
            dtgCharges_AdminViewPaymentHistory.Columns.Clear();
            dtgCharges_AdminViewPaymentHistory.Columns.Add("Description", "Description");
            dtgCharges_AdminViewPaymentHistory.Columns.Add("Amount", "Amount");
            dtgCharges_AdminViewPaymentHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (modeOfPayment == "Cash")
            {
                dtgCharges_AdminViewPaymentHistory.Rows.Add("Tuition Fee", "₱2,000");
                dtgCharges_AdminViewPaymentHistory.Rows.Add("Miscellaneous Fee", "₱1,500");
                dtgCharges_AdminViewPaymentHistory.Rows.Add("Others", "₱1,700");
                dtgCharges_AdminViewPaymentHistory.Rows.Add("Total", "₱5,200");
            }
            else if (modeOfPayment == "Low Quarterly Payment")
            {
                dtgCharges_AdminViewPaymentHistory.Rows.Add("Tuition Fee", "₱2,500");
                dtgCharges_AdminViewPaymentHistory.Rows.Add("Miscellaneous Fee", "₱1,875");
                dtgCharges_AdminViewPaymentHistory.Rows.Add("Others", "₱2,125");
                dtgCharges_AdminViewPaymentHistory.Rows.Add("Total", "₱6,500");
                dtgCharges_AdminViewPaymentHistory.Rows.Add("Required Down Payment", "₱700");
                dtgCharges_AdminViewPaymentHistory.Rows.Add("");
                dtgCharges_AdminViewPaymentHistory.Rows.Add("Quarterly Payment (4x)", "₱1,500");
            }
            else if (modeOfPayment == "Low Down Payment")
            {
                dtgCharges_AdminViewPaymentHistory.Rows.Add("Tuition Fee", "₱2,700");
                dtgCharges_AdminViewPaymentHistory.Rows.Add("Miscellaneous Fee", "₱2,025");
                dtgCharges_AdminViewPaymentHistory.Rows.Add("Others", "₱2,295");
                dtgCharges_AdminViewPaymentHistory.Rows.Add("Total", "₱7,020");
                dtgCharges_AdminViewPaymentHistory.Rows.Add("Required Down Payment", "₱500");
                dtgCharges_AdminViewPaymentHistory.Rows.Add("");
                dtgCharges_AdminViewPaymentHistory.Rows.Add("Quarterly Payment (4x)", "₱1,630");
            }
        }

        private void btnBack_ViewPaymentHistory_Admin_Click(object sender, EventArgs e)
        {
            AdminPaymentHistory history = new AdminPaymentHistory();
            history.Show();
            this.Close();
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

                            while (reader.Read())
                            {
                                hasTransaction = true;

                                int transactionId = Convert.ToInt32(reader["TransactionId"]);
                                string date = Convert.ToDateTime(reader["PaymentDate"]).ToString("MM/dd/yyyy");
                                string mode = reader["ModeOfPayment"].ToString();
                                decimal amountPaid = Convert.ToDecimal(reader["AmountPaid"]);
                                decimal remaining = Convert.ToDecimal(reader["RemainingBalance"]);
                                latestRemaining = remaining;

                                dtgPayment_ViewPaymentHistory_Admin.Rows.Add(transactionId, $"{date} ",
                                    $"₱{amountPaid:N2}", $"₱{remaining:N2}");
                            }

                            if (hasTransaction)
                            {
                                dtgPayment_ViewPaymentHistory_Admin.Rows.Add("", "", "");
                                dtgPayment_ViewPaymentHistory_Admin.Rows.Add("Current Remaining Balance", "", $"₱{latestRemaining:N2}");

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
            dtgPayment_ViewPaymentHistory_Admin.Columns.Clear();
            dtgPayment_ViewPaymentHistory_Admin.Columns.Add("TransactionId", "Transaction ID");
            dtgPayment_ViewPaymentHistory_Admin.Columns.Add("PaymentDate", "Payment Date (Mode)");
            dtgPayment_ViewPaymentHistory_Admin.Columns.Add("AmountPaid", "Amount Paid");
            dtgPayment_ViewPaymentHistory_Admin.Columns.Add("RemainingBalance", "Remaining Balance");
            dtgPayment_ViewPaymentHistory_Admin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void AdminViewPaymentHistory_Load(object sender, EventArgs e)
        {

        }

        private void btnAdminStuedntInfo_ViewPaymentHistory_Click(object sender, EventArgs e)
        {
            AdminStudentInformation adminStudentInformation = new AdminStudentInformation();
            adminStudentInformation.Show();
            this.Close();
        }

        private void btnAdminAssessment_ViewPaymentHistory_Click(object sender, EventArgs e)
        {
            AdminAssesment adminAssesment = new AdminAssesment();
            adminAssesment.Show();
            this.Close();
        }

        private void btnStudentRegistration_ViewPaymentHistory_Admin_Click(object sender, EventArgs e)
        {
            AdminStudentRegistration adminStudentRegistration = new AdminStudentRegistration();
            adminStudentRegistration.Show();
            this.Close();
        }

        private void btnPayment_ViewPaymentHistory_Admin_Click(object sender, EventArgs e)
        {
            AdminPayment adminPayment = new AdminPayment();
            adminPayment.Show();
            this.Close();
        }

        private void btnLogout_ViewPaymentHistory_Admin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void pcAdminViewPaymentHistory_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Close();
        }

        private void btnReport_ViewPaymentHistory_Admin_Click(object sender, EventArgs e)
        {
            AdminReport adminReport = new AdminReport();
            adminReport.Show();
            this.Close();
        }
    }
}
