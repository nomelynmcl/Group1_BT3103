using System.Data;
using System.Data.SqlClient;
using EventDriven.Project.Model;

namespace EventDriven.Project.UI
{
    public partial class RegistrarReport : Form
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EnrollmentDB;Integrated Security=True";
        private List<StudentAssessmentModel> studentSearch;

        public RegistrarReport()
        {
            InitializeComponent();
            studentSearch = new List<StudentAssessmentModel>();
        }

        private void RR_LOE_BTN_Click(object sender, EventArgs e)
        {
            string searchValue = RR_LOE_TXTBOX.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchValue))
            {
                RR_LOE_GRID.DataSource = new BindingSource { DataSource = studentSearch };
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
            RR_LOE_GRID.DataSource = new BindingSource { DataSource = filtered };
        }

        private void RegistarReport_Load(object sender, EventArgs e)
        {
            LoadCounts();
            LoadEnrolledStudents();
            LoadStudentRecords();
        }
        private void LoadCounts()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd1 = new SqlCommand(
                    "SELECT COUNT(DISTINCT Id) FROM PaymentRecord WHERE AmountPaid >= 500", conn);
                RR_NOES.Text = cmd1.ExecuteScalar().ToString();

                SqlCommand cmd2 = new SqlCommand(
                    "SELECT COUNT(*) FROM StudentRecord WHERE Id NOT IN (SELECT DISTINCT Id FROM PaymentRecord)", conn);
                RR_NOE.Text = cmd2.ExecuteScalar().ToString();

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

                RR_LOE_GRID.DataSource = dt;
            }
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
                        RR_LOE_GRID.DataSource = new BindingSource { DataSource = studentSearch };
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
            Registrar___Student_Information studInfo = new Registrar___Student_Information();
            studInfo.Show();
            this.Close();
        }

        private void btnAdminAssessment3_Click(object sender, EventArgs e)
        {
            RegistrarAssesment assessment = new RegistrarAssesment();
            assessment.Show();
            this.Close();
        }

        private void btnAdminStudreg3_Click(object sender, EventArgs e)
        {
            RegistrarStudentRegistration studReg = new RegistrarStudentRegistration();
            studReg.Show();
            this.Close();
        }

        private void btnAdminOut3_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void pcRegistrarLogo4_Click(object sender, EventArgs e)
        {
            RegistrarDashboard dashboard = new RegistrarDashboard();
            dashboard.Show();
            this.Close();
        }

        private void RR_LOE_TXTBOX_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
