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
    public partial class RegistrarStudentRegistration : Form
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EnrollmentDB;Integrated Security=True";
        private StudentRecordModel_Registration studentRecordModel;
        private List<StudentRecordModel_Registration> studentRecords;
        private List<StudentRecordModel_Registration> studentSearch;

        public RegistrarStudentRegistration()
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
                string query = "SELECT Id, FirstName, LastName, MiddleName, ContactNumber, Gender, Age, Birthdate, Barangay, Municipality, Province, GradeLevel, GuardianName, GuardianContact, StudentType, Section, Requirements, ModeOfPayment FROM StudentRecord";

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
                                ModeOfPayment = reader["ModeOfPayment"].ToString()

                            });

                        }

                        studentSearch = records;
                        dtgRegistrar_StudRegList.DataSource = new BindingSource { DataSource = studentSearch };
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading records: " + ex.Message);
            }
        }

        private void btnRegistrarStudentInformation_Click(object sender, EventArgs e)
        {
            Registrar___Student_Information regStudInfo = new Registrar___Student_Information();
            regStudInfo.Show();
            this.Hide();
        }

        private void btnRegistrarOut_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void pcRegistrarLogo2_Click(object sender, EventArgs e)
        {
            RegistrarDashboard registrarDashboard = new RegistrarDashboard();
            registrarDashboard.Show();
            this.Hide();
        }

        private void RegistrarStudentRegistration_Load(object sender, EventArgs e)
        {
            LoadStudentRecords();
        }

        private void btnRegistrarStudReg_Add_Click(object sender, EventArgs e)
        {
            if (dtgRegistrar_StudRegList.CurrentRow != null)
            {
                // Get data from the selected row
                int studentId = Convert.ToInt32(dtgRegistrar_StudRegList.CurrentRow.Cells["Id"].Value.ToString());
                string lastname = dtgRegistrar_StudRegList.CurrentRow.Cells["LastName"].Value.ToString();
                string firstname = dtgRegistrar_StudRegList.CurrentRow.Cells["FirstName"].Value.ToString();
                string middlename = dtgRegistrar_StudRegList.CurrentRow.Cells["MiddleName"].Value.ToString();
                int age = Convert.ToInt32(dtgRegistrar_StudRegList.CurrentRow.Cells["Age"].Value.ToString());
                string contactNumber = dtgRegistrar_StudRegList.CurrentRow.Cells["ContactNumber"].Value.ToString();
                string gender = dtgRegistrar_StudRegList.CurrentRow.Cells["Gender"].Value.ToString();
                DateTime birthdate = Convert.ToDateTime(dtgRegistrar_StudRegList.CurrentRow.Cells["Birthdate"].Value.ToString());
                string barangay = dtgRegistrar_StudRegList.CurrentRow.Cells["Barangay"].Value.ToString();
                string municipality = dtgRegistrar_StudRegList.CurrentRow.Cells["Municipality"].Value.ToString();
                string province = dtgRegistrar_StudRegList.CurrentRow.Cells["Province"].Value.ToString();
                int gradeLevel = Convert.ToInt32(dtgRegistrar_StudRegList.CurrentRow.Cells["GradeLevel"].Value);
                string guardianName = dtgRegistrar_StudRegList.CurrentRow.Cells["GuardianName"].Value.ToString();
                string guardianContact = dtgRegistrar_StudRegList.CurrentRow.Cells["GuardianContact"].Value.ToString();
                string section = dtgRegistrar_StudRegList.CurrentRow.Cells["Section"].Value.ToString();
                string studentType = dtgRegistrar_StudRegList.CurrentRow.Cells["StudentType"].Value.ToString();
                string requirements = dtgRegistrar_StudRegList.CurrentRow.Cells["Requirements"].Value.ToString();
                string modeOfPayment = dtgRegistrar_StudRegList.CurrentRow.Cells["ModeOfPayment"].Value.ToString();

                // Open registration form with prefilled data
                RegistrarStudentRegistration_Add addForm = new RegistrarStudentRegistration_Add(
                    studentId,
                    lastname,
                    firstname,
                    middlename,
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
                    modeOfPayment
                );

                addForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please select a student record first.");
            }
        }

        private void btnRegistrarStudReg_Edit_Click(object sender, EventArgs e)
        {
            RegistrarStudentRegistration_Edit regStudReg_edit = new RegistrarStudentRegistration_Edit();
            regStudReg_edit.Show();
            this.Hide();
        }

        private void btnRegistrarStudReg_View_Click(object sender, EventArgs e)
        {
            RegistrarStudentRegistration_View regStudReg_view = new RegistrarStudentRegistration_View();
            regStudReg_view.Show();
            this.Hide();
        }

        private void btnRegistrarStudReg_Search_Click(object sender, EventArgs e)
        {
            string searchValue = txtRegistrarStudReg_Search.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchValue))
            {
                dtgRegistrar_StudRegList.DataSource = new BindingSource { DataSource = studentSearch };
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
            dtgRegistrar_StudRegList.DataSource = new BindingSource { DataSource = filtered };
        }
    }
}
