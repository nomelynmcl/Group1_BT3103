using System.Data;
using System.Data.SqlClient;

namespace EventDriven.Project.UI
{
    public partial class AdminDashboard : Form
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EnrollmentDB;Integrated Security=True";

        public AdminDashboard()
        {
            InitializeComponent();
        }


        private void btnAdminStudentInformation3_Click(object sender, EventArgs e)
        {
            AdminStudentInformation adminStudentInformation = new AdminStudentInformation();
            adminStudentInformation.Show();
            this.Close();
        }

        private void btnAdminStudreg3_Click(object sender, EventArgs e)
        {
            AdminStudentRegistration adminStudentRegistration = new AdminStudentRegistration();
            adminStudentRegistration.Show();
            this.Close();
        }

        private void btnAdminPay3_Click(object sender, EventArgs e)
        {
            AdminPayment payment = new AdminPayment();
            payment.Show();
            this.Close();
        }

        private void btnAdminAssessment3_Click(object sender, EventArgs e)
        {
            AdminAssesment assesment = new AdminAssesment();
            assesment.Show();
            this.Close();
        }

        private void btnAdminHistory3_Click(object sender, EventArgs e)
        {
            AdminPaymentHistory paymentHistory = new AdminPaymentHistory();
            paymentHistory.Show();
            this.Close();
        }

        private void btnAdminReport3_Click(object sender, EventArgs e)
        {
            AdminReport report = new AdminReport();
            report.Show();
            this.Close();
        }

        private void btnAdminOut3_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            if (cbSyear.Items.Count > 0)
            {
                cbSyear.SelectedIndex = 0;
            }
        }
        private void LoadEnrolledStudents(string schoolYear)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT s.Id, s.FirstName, s.MiddleName, s.LastName, 
                                s.GradeLevel, s.Section, s.StudentType, s.SchoolYear
                         FROM StudentRecord s
                         INNER JOIN PaymentRecord p ON s.Id = p.Id
                         WHERE p.AmountPaid >= 500 AND s.SchoolYear = @SchoolYear
                         ORDER BY s.LastName ASC";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SchoolYear", schoolYear);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dtgAdminDashboard.DataSource = dt;


                dtgAdminDashboard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void cbSyear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSyear.SelectedItem != null)
            {
                string selectedYear = cbSyear.SelectedItem.ToString();
                LoadEnrolledStudents(selectedYear);
            }
        }
    }
}
