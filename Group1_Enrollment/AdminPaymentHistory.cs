using System.Data;
using System.Data.SqlClient;
using EventDriven.Project.Model;

namespace EventDriven.Project.UI
{
    public partial class AdminPaymentHistory : Form
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EnrollmentDB;Integrated Security=True";
        private StudentPaymentModel studentPayment;
        private List<StudentPaymentModel> studentPayHis;
        private List<StudentPaymentModel> studentSearch;
        public AdminPaymentHistory()
        {
            InitializeComponent();
            studentPayment = new StudentPaymentModel();
            studentPayHis = new List<StudentPaymentModel>();
            studentSearch = new List<StudentPaymentModel>();
        }

        public void LoadStudentRecords()
        {
            try
            {
                string query = "SELECT s.Id, s.FirstName, s.LastName, s.MiddleName, s.Gender, s.Age, s.GradeLevel, s.Section, s.StudentType, s.ModeOfPayment, s.EnrollmentStatus, t.TransactionId, t.PaymentDate, t.AmountPaid FROM StudentRecord s " +
                    "LEFT JOIN (SELECT Id, TransactionId, PaymentDate, AmountPaid FROM PaymentRecord WHERE TransactionId IN ( SELECT MAX(TransactionId) FROM PaymentRecord GROUP BY Id )) t ON s.Id = t.Id ORDER BY t.TransactionId DESC;";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        List<StudentPaymentModel> records = new List<StudentPaymentModel>();

                        while (reader.Read())
                        {
                            records.Add(new StudentPaymentModel
                            {
                                Id = reader["Id"] != DBNull.Value ? Convert.ToInt32(reader["Id"]) : 0,
                                Firstname = reader["FirstName"]?.ToString() ?? "",
                                Lastname = reader["LastName"]?.ToString() ?? "",
                                Middlename = reader["MiddleName"]?.ToString() ?? "",
                                GradeLevel = reader["GradeLevel"] != DBNull.Value ? Convert.ToInt32(reader["GradeLevel"]) : 0,
                                Section = reader["Section"]?.ToString() ?? "",
                                StudentType = reader["StudentType"]?.ToString() ?? "",
                                ModeOfPayment = reader["ModeOfPayment"]?.ToString() ?? "",
                                EnrollmentStatus = reader["EnrollmentStatus"]?.ToString() ?? "",

                                TransactionId = reader["TransactionId"] != DBNull.Value ? Convert.ToInt32(reader["TransactionId"]) : 0,
                                PaymentDate = reader["PaymentDate"] != DBNull.Value ? Convert.ToDateTime(reader["PaymentDate"]) : DateTime.MinValue,
                                AmountPaid = reader["AmountPaid"] != DBNull.Value ? Convert.ToDecimal(reader["AmountPaid"]) : 0
                            });
                        }

                    

                    studentSearch = records;
                        dtgAdminPaymentHistory.DataSource = new BindingSource { DataSource = studentSearch };
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading records: " + ex.Message);
            }
        }



        private void btnSearchStudent_AdminPaymentHistory_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearch_AdminPaymentHistory.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchValue))
            {
                dtgAdminPaymentHistory.DataSource = new BindingSource { DataSource = studentSearch };
                return;
            }

            var filtered = studentSearch.Where(s =>
                s.Id.ToString().ToLower().Contains(searchValue) ||
                (!string.IsNullOrEmpty(s.Firstname) && s.Firstname.ToLower().Contains(searchValue)) ||
                (!string.IsNullOrEmpty(s.Middlename) && s.Middlename.ToLower().Contains(searchValue)) ||
                (!string.IsNullOrEmpty(s.Lastname) && s.Lastname.ToLower().Contains(searchValue)) ||
                (!string.IsNullOrEmpty(s.Section) && s.Section.ToLower().Contains(searchValue)));

            if (filtered.Count() == 0)
            {
                MessageBox.Show("No matching student found.");
            }
            dtgAdminPaymentHistory.DataSource = new BindingSource { DataSource = filtered };
        }

        private void AdminPaymentHistory_Load(object sender, EventArgs e)
        {
            LoadStudentRecords();
        }

        private void btnViewHistory_AdminPaymentHistory_Click(object sender, EventArgs e)
        {
            if (dtgAdminPaymentHistory.CurrentRow != null)
            {

                int id = Convert.ToInt32(dtgAdminPaymentHistory.CurrentRow.Cells["Id"].Value.ToString());
                string firstName = dtgAdminPaymentHistory.CurrentRow.Cells["FirstName"].Value.ToString();
                string middleName = dtgAdminPaymentHistory.CurrentRow.Cells["MiddleName"].Value.ToString();
                string lastName = dtgAdminPaymentHistory.CurrentRow.Cells["LastName"].Value.ToString();
                int gradeLevel = Convert.ToInt32(dtgAdminPaymentHistory.CurrentRow.Cells["GradeLevel"].Value.ToString());
                string section = dtgAdminPaymentHistory.CurrentRow.Cells["Section"].Value.ToString();
                string studentType = dtgAdminPaymentHistory.CurrentRow.Cells["StudentType"].Value.ToString();
                string enrollmentStatus = dtgAdminPaymentHistory.CurrentRow.Cells["EnrollmentStatus"].Value.ToString();
                string modeOfPayment = dtgAdminPaymentHistory.CurrentRow.Cells["ModeOfPayment"].Value.ToString();
                int transactionId = Convert.ToInt32(dtgAdminPaymentHistory.CurrentRow.Cells["TransactionId"].Value.ToString());
                DateTime paymentDate = Convert.ToDateTime(dtgAdminPaymentHistory.CurrentRow.Cells["PaymentDate"].Value.ToString());
                decimal amountPaid = Convert.ToDecimal(dtgAdminPaymentHistory.CurrentRow.Cells["AmountPaid"].Value.ToString());

                AdminViewPaymentHistory viewForm = new AdminViewPaymentHistory(
                id,
                firstName,
                middleName,
                lastName,
                gradeLevel,
                section,
                studentType,
                modeOfPayment,
                enrollmentStatus,
                transactionId,
                paymentDate,
                amountPaid
            );

                viewForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a student to view.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pcAdminPaymentHistory_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Close();
        }

        private void btnAdminStuedntInfo_PaymentHistory_Click(object sender, EventArgs e)
        {
            AdminStudentInformation adminStudentInformation = new AdminStudentInformation();
            adminStudentInformation.Show();
            this.Close();
        }

        private void btnAdminAssessment_PaymentHistory_Click(object sender, EventArgs e)
        {
            AdminAssesment adminAssesment = new AdminAssesment();
            adminAssesment.Show();
            this.Close();
        }

        private void btnStudentRegistration_PaymentHistory_Admin_Click(object sender, EventArgs e)
        {
            AdminStudentRegistration adminStudentRegistration = new AdminStudentRegistration();
            adminStudentRegistration.Show();
            this.Close();
        }

        private void btnPayment_PaymentHistory_Admin_Click(object sender, EventArgs e)
        {
            AdminPayment adminPayment = new AdminPayment();
            adminPayment.Show();
            this.Close();
        }

        private void btnLogout_PaymentHistory_Admin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void btnReport_PaymentHistory_Admin_Click(object sender, EventArgs e)
        {
            AdminReport adminReport = new AdminReport();
            adminReport.Show();
            this.Close();
        }
    }
}
 