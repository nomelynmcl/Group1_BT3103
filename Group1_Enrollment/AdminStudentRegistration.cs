using EventDriven.Project.Model;
using System.Data;
using System.Data.SqlClient;

namespace EventDriven.Project.UI
{
    public partial class AdminStudentRegistration : Form
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EnrollmentDB;Integrated Security=True";
        private StudentRecordModel_Registration studentRecordModel;
        private List<StudentRecordModel_Registration> studentRecords;
        private List<StudentRecordModel_Registration> studentSearch;


        public AdminStudentRegistration()
        {
            InitializeComponent();
            studentRecordModel = new StudentRecordModel_Registration();
            studentRecords = new List<StudentRecordModel_Registration>();
            studentSearch = new List<StudentRecordModel_Registration>();
        }

        public void LoadStudentRecords()
        {
            try
            {
                string query = "SELECT Id, FirstName, LastName, MiddleName, Suffix, ContactNumber, Gender, Age, Birthdate, Barangay, Municipality, Province, GradeLevel, GuardianName, GuardianContact, StudentType, Section, Requirements, ModeOfPayment, SchoolYear FROM StudentRecord";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        List<StudentRecordModel_Registration> records = new List<StudentRecordModel_Registration>();

                        while (reader.Read())
                        {
                            records.Add(new StudentRecordModel_Registration
                            {
                                Id = Convert.ToInt32(reader["Id"].ToString()),
                                Firstname = reader["FirstName"].ToString(),
                                Lastname = reader["LastName"].ToString(),
                                Suffix = reader["Suffix"].ToString(),
                                Middlename = reader["MiddleName"].ToString(),
                                ContactNumber = reader["ContactNumber"].ToString(),
                                Gender = reader["Gender"].ToString(),
                                Age = Convert.ToInt32(reader["Age"].ToString()),
                                Birthdate = Convert.ToDateTime(reader["Birthdate"].ToString()),
                                Barangay = reader["Barangay"].ToString(),
                                Municipality = reader["Municipality"].ToString(),
                                Province = reader["Province"].ToString(),
                                GradeLevel = Convert.ToInt32(reader["GradeLevel"].ToString()),
                                GuardianName = reader["GuardianName"].ToString(),
                                GuardianContact = reader["GuardianContact"].ToString(),
                                StudentType = reader["StudentType"].ToString(),
                                Section = reader["Section"].ToString(),
                                Requirements = reader["Requirements"].ToString(),
                                ModeOfPayment = reader["ModeOfPayment"].ToString(),
                                SchoolYear = reader["SchoolYear"].ToString()

                            });

                        }

                        studentSearch = records;
                        dtgAdminStudentRegList.DataSource = new BindingSource { DataSource = studentSearch };
                        dtgAdminStudentRegList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading records: " + ex.Message);
            }
        }

        private void btnAdd_AdminStudentRegis_Click(object sender, EventArgs e)
        {
            if (dtgAdminStudentRegList.CurrentRow != null)
            {
                int studentId = Convert.ToInt32(dtgAdminStudentRegList.CurrentRow.Cells["Id"].Value.ToString());
                string lastname = dtgAdminStudentRegList.CurrentRow.Cells["LastName"].Value.ToString();
                string firstname = dtgAdminStudentRegList.CurrentRow.Cells["FirstName"].Value.ToString();
                string middlename = dtgAdminStudentRegList.CurrentRow.Cells["MiddleName"].Value.ToString();
                int age = Convert.ToInt32(dtgAdminStudentRegList.CurrentRow.Cells["Age"].Value.ToString());
                string contactNumber = dtgAdminStudentRegList.CurrentRow.Cells["ContactNumber"].Value.ToString();
                string gender = dtgAdminStudentRegList.CurrentRow.Cells["Gender"].Value.ToString();
                DateTime birthdate = Convert.ToDateTime(dtgAdminStudentRegList.CurrentRow.Cells["Birthdate"].Value.ToString());
                string barangay = dtgAdminStudentRegList.CurrentRow.Cells["Barangay"].Value.ToString();
                string municipality = dtgAdminStudentRegList.CurrentRow.Cells["Municipality"].Value.ToString();
                string province = dtgAdminStudentRegList.CurrentRow.Cells["Province"].Value.ToString();
                int gradeLevel = Convert.ToInt32(dtgAdminStudentRegList.CurrentRow.Cells["GradeLevel"].Value);
                string guardianName = dtgAdminStudentRegList.CurrentRow.Cells["GuardianName"].Value.ToString();
                string guardianContact = dtgAdminStudentRegList.CurrentRow.Cells["GuardianContact"].Value.ToString();
                string section = dtgAdminStudentRegList.CurrentRow.Cells["Section"].Value.ToString();
                string studentType = dtgAdminStudentRegList.CurrentRow.Cells["StudentType"].Value.ToString();
                string requirements = dtgAdminStudentRegList.CurrentRow.Cells["Requirements"].Value.ToString();
                string modeOfPayment = dtgAdminStudentRegList.CurrentRow.Cells["ModeOfPayment"].Value.ToString();
                string suffix = dtgAdminStudentRegList.CurrentRow.Cells["Suffix"].Value.ToString();
                string schoolyear = dtgAdminStudentRegList.CurrentRow.Cells["SchoolYear"].Value.ToString();

                AdminStudentRegistration_Add addForm = new AdminStudentRegistration_Add(
                    studentId,
                    lastname,
                    firstname,
                    middlename,
                    suffix,
                    age,
                    contactNumber,
                    gender,
                    birthdate,
                    barangay,
                    municipality,
                    province,
                    gradeLevel,
                    guardianName,
                    guardianContact,
                    section,
                    studentType,
                    requirements,
                    modeOfPayment,
                    schoolyear
                );

                addForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a student record first.");
            }
        }

        private void btnView_AdminStudReg_Click(object sender, EventArgs e)
        {
            if (dtgAdminStudentRegList.CurrentRow != null)
            {

                int id = Convert.ToInt32(dtgAdminStudentRegList.CurrentRow.Cells["Id"].Value.ToString());
                string firstName = dtgAdminStudentRegList.CurrentRow.Cells["FirstName"].Value.ToString();
                string middleName = dtgAdminStudentRegList.CurrentRow.Cells["MiddleName"].Value.ToString();
                string lastName = dtgAdminStudentRegList.CurrentRow.Cells["LastName"].Value.ToString();
                int age = Convert.ToInt32(dtgAdminStudentRegList.CurrentRow.Cells["Age"].Value.ToString());
                DateTime birthdate = Convert.ToDateTime(dtgAdminStudentRegList.CurrentRow.Cells["Birthdate"].Value.ToString());
                string gender = dtgAdminStudentRegList.CurrentRow.Cells["Gender"].Value.ToString();
                string barangay = dtgAdminStudentRegList.CurrentRow.Cells["Barangay"].Value.ToString();
                string municipality = dtgAdminStudentRegList.CurrentRow.Cells["Municipality"].Value.ToString();
                string province = dtgAdminStudentRegList.CurrentRow.Cells["Province"].Value.ToString();
                string contactNumber = dtgAdminStudentRegList.CurrentRow.Cells["ContactNumber"].Value.ToString();
                string guardianName = dtgAdminStudentRegList.CurrentRow.Cells["GuardianName"].Value.ToString();
                string guardianContact = dtgAdminStudentRegList.CurrentRow.Cells["GuardianContact"].Value.ToString();
                int gradeLevel = Convert.ToInt32(dtgAdminStudentRegList.CurrentRow.Cells["GradeLevel"].Value.ToString());
                string studentType = dtgAdminStudentRegList.CurrentRow.Cells["StudentType"].Value.ToString();
                string requirements = dtgAdminStudentRegList.CurrentRow.Cells["Requirements"].Value.ToString();
                string modeOfPayment = dtgAdminStudentRegList.CurrentRow.Cells["ModeOfPayment"].Value.ToString();
                string section = dtgAdminStudentRegList.CurrentRow.Cells["Section"].Value.ToString();
                string suffix = dtgAdminStudentRegList.CurrentRow.Cells["Suffix"].Value.ToString();
                string schoolYear = dtgAdminStudentRegList.CurrentRow.Cells["SchoolYear"].Value.ToString();


                AdminStudentRegistration_View viewForm = new AdminStudentRegistration_View(
                id,
                firstName,
                middleName,
                lastName,
                suffix,
                age,
                birthdate,
                gender,
                barangay,
                municipality,
                province,
                contactNumber,
                guardianName,
                guardianContact,
                gradeLevel,
                studentType,
                section,
                requirements,
                modeOfPayment,
                schoolYear
            );

                viewForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a student to view.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSearchStudent_AdminStudentRegis_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearch_AdminStudentRegis.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchValue))
            {
                dtgAdminStudentRegList.DataSource = new BindingSource { DataSource = studentSearch };
                return;
            }
            var filtered = studentSearch.Where(s =>
                (!string.IsNullOrEmpty(s.Firstname) && s.Firstname.ToLower().Contains(searchValue)) ||
                (!string.IsNullOrEmpty(s.Middlename) && s.Middlename.ToLower().Contains(searchValue)) ||
                (!string.IsNullOrEmpty(s.Lastname) && s.Lastname.ToLower().Contains(searchValue)));

            if (filtered.Count() == 0)
            {
                MessageBox.Show("No matching student found.");
            }

            dtgAdminStudentRegList.DataSource = new BindingSource { DataSource = filtered };
        }

        private void AdminStudentRegistration_Load(object sender, EventArgs e)
        {
            LoadStudentRecords();
        }

        private void pcAdminLogo2_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Close();
        }

        private void btnAdminStudentInformation2_Click(object sender, EventArgs e)
        {
            AdminStudentInformation adminStudInfo = new AdminStudentInformation();
            adminStudInfo.Show();
            this.Hide();
        }

        private void btnAdminOut2_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void btnAdminAssessment2_Click(object sender, EventArgs e)
        {
            AdminAssesment adminAssesment = new AdminAssesment();
            adminAssesment.Show();
            this.Close();
        }

        private void btnAdminPay2_Click(object sender, EventArgs e)
        {
            AdminPayment adminPayment = new AdminPayment();
            adminPayment.Show();
            this.Close();
        }

        private void btnAdminHistory2_Click(object sender, EventArgs e)
        {
            AdminPaymentHistory adminHistory = new AdminPaymentHistory();
            adminHistory.Show();
            this.Close();
        }

        private void btnAdminReport2_Click(object sender, EventArgs e)
        {
            AdminReport adminReport = new AdminReport();
            adminReport.Show();
            this.Close();
        }
    }
}
