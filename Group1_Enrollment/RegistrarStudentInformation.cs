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
    public partial class Registrar___Student_Information : Form
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EnrollmentDB;Integrated Security=True";
        private StudentRecordModel studentRecordModel;
        private List<StudentRecordModel> studentRecords;
        private List<StudentRecordModel> studentSearch;

        public Registrar___Student_Information()
        {
            InitializeComponent();
            studentRecordModel = new StudentRecordModel();
            studentRecords = new List<StudentRecordModel>();
            studentSearch = new List<StudentRecordModel>();
        }

        private void btnAdminAssessment2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarStudInfo_Add_Click(object sender, EventArgs e)
        {
            RegistrarStudentInfo_Add regStudInfo_Add = new RegistrarStudentInfo_Add();
            regStudInfo_Add.Show();
        }

        private void btnRegistrarStudInfo_Edit_Click(object sender, EventArgs e)
        {
            if (dtgRegistrarStudentInfoList.CurrentRow != null)
            {
                // Get data from the cell
                int id = Convert.ToInt32(dtgRegistrarStudentInfoList.CurrentRow.Cells["Id"].Value.ToString());
                string firstname = dtgRegistrarStudentInfoList.CurrentRow.Cells["FirstName"].Value.ToString();
                string lastname = dtgRegistrarStudentInfoList.CurrentRow.Cells["LastName"].Value.ToString();
                string middlename = dtgRegistrarStudentInfoList.CurrentRow.Cells["MiddleName"].Value.ToString();
                string contactNumber = dtgRegistrarStudentInfoList.CurrentRow.Cells["ContactNumber"].Value.ToString();
                string gender = dtgRegistrarStudentInfoList.CurrentRow.Cells["Gender"].Value.ToString();
                string barangay = dtgRegistrarStudentInfoList.CurrentRow.Cells["Barangay"].Value.ToString();
                string municipality = dtgRegistrarStudentInfoList.CurrentRow.Cells["Municipality"].Value.ToString();
                string province = dtgRegistrarStudentInfoList.CurrentRow.Cells["Province"].Value.ToString();
                int gradeLevel = Convert.ToInt32(dtgRegistrarStudentInfoList.CurrentRow.Cells["GradeLevel"].Value);
                DateTime birthdate = Convert.ToDateTime(dtgRegistrarStudentInfoList.CurrentRow.Cells["Birthdate"].Value.ToString());
                int age = Convert.ToInt32(dtgRegistrarStudentInfoList.CurrentRow.Cells["Age"].Value.ToString());
                string guardian = dtgRegistrarStudentInfoList.CurrentRow.Cells["GuardianName"].Value.ToString();
                string guardianContact = dtgRegistrarStudentInfoList.CurrentRow.Cells["GuardianContact"].Value.ToString();
                string studentType = dtgRegistrarStudentInfoList.CurrentRow.Cells["StudentType"].Value.ToString();

                RegistrarStudentInfo_Edit adStudInfo_edit = new RegistrarStudentInfo_Edit(
                    id,
                    firstname,
                    lastname,
                    middlename,
                    contactNumber,
                    gender,
                    age,
                    birthdate,
                    barangay,
                    municipality,
                    province,
                    gradeLevel,
                    guardian,
                    guardianContact,
                    studentType);
                adStudInfo_edit.Show();
            }
            else
            {
                MessageBox.Show("Select a student record first.");
            }
        }

        private void Registrar___Student_Information_Load(object sender, EventArgs e)
        {
            LoadStudentRecords();
        }

        public void LoadStudentRecords()
        {
            try
            {
                string query = "SELECT Id, FirstName, LastName, MiddleName, ContactNumber, Gender, Age, Birthdate, Barangay, Municipality, Province, GradeLevel, GuardianName, GuardianContact, StudentType, Section FROM StudentRecord";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        List<StudentRecordModel> records = new List<StudentRecordModel>();

                        while (reader.Read())
                        {
                            records.Add(new StudentRecordModel
                            {
                                Id = Convert.ToInt32(reader["Id"].ToString()),
                                Firstname = reader["FirstName"].ToString(),
                                Lastname = reader["LastName"].ToString(),
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
                                StudentType = reader["StudentType"].ToString()
                            });
                        }

                        studentSearch = records;
                        dtgRegistrarStudentInfoList.DataSource = new BindingSource { DataSource = studentSearch };
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading records: " + ex.Message);
            }
        }

        private void btnRegistrarStudInfo_View_Click(object sender, EventArgs e)
        {
            if (dtgRegistrarStudentInfoList.CurrentRow != null)
            {

                string firstName = dtgRegistrarStudentInfoList.CurrentRow.Cells["FirstName"].Value.ToString();
                string middleName = dtgRegistrarStudentInfoList.CurrentRow.Cells["MiddleName"].Value.ToString();
                string lastName = dtgRegistrarStudentInfoList.CurrentRow.Cells["LastName"].Value.ToString();
                int age = Convert.ToInt32(dtgRegistrarStudentInfoList.CurrentRow.Cells["Age"].Value.ToString());
                DateTime birthdate = Convert.ToDateTime(dtgRegistrarStudentInfoList.CurrentRow.Cells["Birthdate"].Value.ToString());
                string gender = dtgRegistrarStudentInfoList.CurrentRow.Cells["Gender"].Value.ToString();
                string barangay = dtgRegistrarStudentInfoList.CurrentRow.Cells["Barangay"].Value.ToString();
                string municipality = dtgRegistrarStudentInfoList.CurrentRow.Cells["Municipality"].Value.ToString();
                string province = dtgRegistrarStudentInfoList.CurrentRow.Cells["Province"].Value.ToString();
                string contactNumber = dtgRegistrarStudentInfoList.CurrentRow.Cells["ContactNumber"].Value.ToString();
                string guardianName = dtgRegistrarStudentInfoList.CurrentRow.Cells["GuardianName"].Value.ToString();
                string guardianContact = dtgRegistrarStudentInfoList.CurrentRow.Cells["GuardianContact"].Value.ToString();
                int gradeLevel = Convert.ToInt32(dtgRegistrarStudentInfoList.CurrentRow.Cells["GradeLevel"].Value.ToString());
                string studentType = dtgRegistrarStudentInfoList.CurrentRow.Cells["StudentType"].Value.ToString();

                AdminStudentInformation_View viewForm = new AdminStudentInformation_View(
                firstName,
                middleName,
                lastName,
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
                studentType
            );

                viewForm.ShowDialog(); // open the view form
            }
            else
            {
                MessageBox.Show("Please select a student to view.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRegistrarOut_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void Registrar___Student_Information_Load_1(object sender, EventArgs e)
        {
            LoadStudentRecords();
        }

        private void btnRegistrarStudInfo_Search_Click(object sender, EventArgs e)
        {
            string searchValue = txtRegistrarStudInfo_Search.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchValue))
            {
                dtgRegistrarStudentInfoList.DataSource = new BindingSource { DataSource = studentSearch };
                return;
            }

            // Filter the student list
            var filtered = studentSearch.Where(s =>
                (!string.IsNullOrEmpty(s.Firstname) && s.Firstname.ToLower().Contains(searchValue)) ||
                (!string.IsNullOrEmpty(s.Middlename) && s.Middlename.ToLower().Contains(searchValue)) ||
                (!string.IsNullOrEmpty(s.Lastname) && s.Lastname.ToLower().Contains(searchValue)));

            if (filtered.Count() == 0)
            {
                MessageBox.Show("No matching student found.");
            }

            // Rebind the filtered results to the grid
            dtgRegistrarStudentInfoList.DataSource = new BindingSource { DataSource = filtered };
        }
    }
}
