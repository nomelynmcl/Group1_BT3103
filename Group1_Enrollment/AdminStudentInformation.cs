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
using EventDriven.Project.Businesslogic.Controller;
using EventDriven.Project.Businesslogic.Repository;
using EventDriven.Project.Model;

namespace EventDriven.Project.UI
{
    public partial class AdminStudentInformation : Form
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EnrollmentDB;Integrated Security=True";
        private StudentRecordModel studentRecordModel;
        private List<StudentRecordModel> studentRecords;
        private List<StudentRecordModel> studentSearch;

        public AdminStudentInformation()
        {
            InitializeComponent();
            studentRecordModel = new StudentRecordModel();
            studentRecords = new List<StudentRecordModel>();
            studentSearch = new List<StudentRecordModel>();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void AdminStudentInformation_Load(object sender, EventArgs e)
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
                        dtgAdminStudentInfoList.DataSource = new BindingSource { DataSource = studentSearch };
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading records: " + ex.Message);
            }

        }

        private void btnAdminStudInfoAdd_Click(object sender, EventArgs e)
        {
            AdminStudentInformation_Add adStudInfo_add = new AdminStudentInformation_Add();
            adStudInfo_add.Show();
            this.Hide();
        }

        private void btnAdminStudInfoEdit_Click(object sender, EventArgs e)
        {
            if (dtgAdminStudentInfoList.CurrentRow != null)
            {
                // Get data from the c
                int id = Convert.ToInt32(dtgAdminStudentInfoList.CurrentRow.Cells["Id"].Value.ToString());
                string firstname = dtgAdminStudentInfoList.CurrentRow.Cells["FirstName"].Value.ToString();
                string lastname = dtgAdminStudentInfoList.CurrentRow.Cells["LastName"].Value.ToString();
                string middlename = dtgAdminStudentInfoList.CurrentRow.Cells["MiddleName"].Value.ToString();
                string contactNumber = dtgAdminStudentInfoList.CurrentRow.Cells["ContactNumber"].Value.ToString();
                string gender = dtgAdminStudentInfoList.CurrentRow.Cells["Gender"].Value.ToString();
                string barangay = dtgAdminStudentInfoList.CurrentRow.Cells["Barangay"].Value.ToString();
                string municipality = dtgAdminStudentInfoList.CurrentRow.Cells["Municipality"].Value.ToString();
                string province = dtgAdminStudentInfoList.CurrentRow.Cells["Province"].Value.ToString();
                int gradeLevel = Convert.ToInt32(dtgAdminStudentInfoList.CurrentRow.Cells["GradeLevel"].Value);
                DateTime birthdate = Convert.ToDateTime(dtgAdminStudentInfoList.CurrentRow.Cells["Birthdate"].Value.ToString());
                int age = Convert.ToInt32(dtgAdminStudentInfoList.CurrentRow.Cells["Age"].Value.ToString());
                string guardian = dtgAdminStudentInfoList.CurrentRow.Cells["GuardianName"].Value.ToString();
                string guardianContact = dtgAdminStudentInfoList.CurrentRow.Cells["GuardianContact"].Value.ToString();
                string studentType = dtgAdminStudentInfoList.CurrentRow.Cells["StudentType"].Value.ToString();

                AdminStudInfo_Edit adStudInfo_edit = new AdminStudInfo_Edit(
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
                this.Hide();
            }
            else
            {
                MessageBox.Show("Select a student record first.");
            }
        }

        private void dtgAdminStudentInfoList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdminStudInfoSearch_Click(object sender, EventArgs e)
        {
            string searchValue = txtAdminStudInfoSearch.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchValue))
            {
                dtgAdminStudentInfoList.DataSource = new BindingSource { DataSource = studentSearch };
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
            dtgAdminStudentInfoList.DataSource = new BindingSource { DataSource = filtered };
        }

        private void btnAdminOut2_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }


        private void btnAdminStudInfoView_Click_1(object sender, EventArgs e)
        {
            if (dtgAdminStudentInfoList.CurrentRow != null)
            {

                string firstName = dtgAdminStudentInfoList.CurrentRow.Cells["FirstName"].Value.ToString();
                string middleName = dtgAdminStudentInfoList.CurrentRow.Cells["MiddleName"].Value.ToString();
                string lastName = dtgAdminStudentInfoList.CurrentRow.Cells["LastName"].Value.ToString();
                int age = Convert.ToInt32(dtgAdminStudentInfoList.CurrentRow.Cells["Age"].Value.ToString());
                DateTime birthdate = Convert.ToDateTime(dtgAdminStudentInfoList.CurrentRow.Cells["Birthdate"].Value.ToString());
                string gender = dtgAdminStudentInfoList.CurrentRow.Cells["Gender"].Value.ToString();
                string barangay = dtgAdminStudentInfoList.CurrentRow.Cells["Barangay"].Value.ToString();
                string municipality = dtgAdminStudentInfoList.CurrentRow.Cells["Municipality"].Value.ToString();
                string province = dtgAdminStudentInfoList.CurrentRow.Cells["Province"].Value.ToString();
                string contactNumber = dtgAdminStudentInfoList.CurrentRow.Cells["ContactNumber"].Value.ToString();
                string guardianName = dtgAdminStudentInfoList.CurrentRow.Cells["GuardianName"].Value.ToString();
                string guardianContact = dtgAdminStudentInfoList.CurrentRow.Cells["GuardianContact"].Value.ToString();
                int gradeLevel = Convert.ToInt32(dtgAdminStudentInfoList.CurrentRow.Cells["GradeLevel"].Value.ToString());
                string studentType = dtgAdminStudentInfoList.CurrentRow.Cells["StudentType"].Value.ToString();

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

                viewForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a student to view.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAdminStudreg2_Click(object sender, EventArgs e)
        {
            AdminStudentRegistration adminStudReg = new AdminStudentRegistration();
            adminStudReg.Show();
            this.Hide();
        }
    }
}

