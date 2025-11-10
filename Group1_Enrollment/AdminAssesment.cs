using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventDriven.Project.Model;

namespace EventDriven.Project.UI
{
    public partial class AdminAssesment : Form
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EnrollmentDB;Integrated Security=True";
        private StudentAssessmentModel studentAssessmentModel;
        private List<StudentAssessmentModel> studentAssement;
        private List<StudentAssessmentModel> studentSearch;
        public AdminAssesment()
        {
            InitializeComponent();
            studentAssessmentModel = new StudentAssessmentModel();
            studentAssement = new List<StudentAssessmentModel>();
            studentSearch = new List<StudentAssessmentModel>();

        }

        public void LoadStudentRecords()
        {
            try
            {
                string query = "SELECT Id, FirstName, LastName, MiddleName, Gender, Age, Birthdate, GradeLevel, Section, StudentType FROM StudentRecord";

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
                                StudentType = reader["StudentType"].ToString()
                            });
                        }

                        studentSearch = records;
                        dtgAdminAssessment.DataSource = new BindingSource { DataSource = studentSearch };
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading records: " + ex.Message);
            }

        }

        private void btnAdminStudInfoSearch_Click(object sender, EventArgs e)
        {
            string searchValue = txtAdminStudInfoSearch.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchValue))
            {
                dtgAdminAssessment.DataSource = new BindingSource { DataSource = studentSearch };
                return;
            }

            // Filter the student list
            var filtered = studentSearch.Where(s =>
                s.Id.ToString().ToLower().Contains(searchValue) ||
                (!string.IsNullOrEmpty(s.Firstname) && s.Firstname.ToLower().Contains(searchValue)) ||
                (!string.IsNullOrEmpty(s.Middlename) && s.Middlename.ToLower().Contains(searchValue)) ||
                (!string.IsNullOrEmpty(s.Lastname) && s.Lastname.ToLower().Contains(searchValue)));

            if (filtered.Count() == 0)
            {
                MessageBox.Show("No matching student found.");
            }

            // Rebind the filtered results to the grid
            dtgAdminAssessment.DataSource = new BindingSource { DataSource = filtered };
        }

        private void AdminAssesment_Load(object sender, EventArgs e)
        {
            LoadStudentRecords();
        }

        private void btnAdminStudInfoView_Click(object sender, EventArgs e)
        {
            if (dtgAdminAssessment.CurrentRow != null)
            {

                int id = Convert.ToInt32(dtgAdminAssessment.CurrentRow.Cells["Id"].Value.ToString());
                string firstName = dtgAdminAssessment.CurrentRow.Cells["FirstName"].Value.ToString();
                string middleName = dtgAdminAssessment.CurrentRow.Cells["MiddleName"].Value.ToString();
                string lastName = dtgAdminAssessment.CurrentRow.Cells["LastName"].Value.ToString();
                int age = Convert.ToInt32(dtgAdminAssessment.CurrentRow.Cells["Age"].Value.ToString());
                DateTime birthdate = Convert.ToDateTime(dtgAdminAssessment.CurrentRow.Cells["Birthdate"].Value.ToString());
                string gender = dtgAdminAssessment.CurrentRow.Cells["Gender"].Value.ToString();
                int gradeLevel = Convert.ToInt32(dtgAdminAssessment.CurrentRow.Cells["GradeLevel"].Value.ToString());
                string section = dtgAdminAssessment.CurrentRow.Cells["Section"].Value.ToString();
                string studentType = dtgAdminAssessment.CurrentRow.Cells["StudentType"].Value.ToString();

                AdminViewAssessment viewForm = new AdminViewAssessment(
                id,
                firstName,
                middleName,
                lastName,
                age,
                birthdate,
                gender,
                gradeLevel,
                section,
                studentType
            );

                viewForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a student to view.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAdminStudentInformation2_Click(object sender, EventArgs e)
        {
            AdminStudentInformation adminStudentInformation = new AdminStudentInformation();
            adminStudentInformation.Show();
            this.Close();
        }

        private void btnAdminStudreg2_Click(object sender, EventArgs e)
        {
            AdminStudentRegistration adminStudentRegistration = new AdminStudentRegistration();
            adminStudentRegistration.Show();
            this.Close();
        }

        private void btnAdminPay2_Click(object sender, EventArgs e)
        {
        }

        private void btnAdminHistory2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdminReport2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdminOut2_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}
