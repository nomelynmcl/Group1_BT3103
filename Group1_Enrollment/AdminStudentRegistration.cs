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
                        dtgAdminStudentRegList.DataSource = new BindingSource { DataSource = studentSearch };
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
            AdminStudentRegistration_Add adminStudReg_add = new AdminStudentRegistration_Add();
            adminStudReg_add.Show();
            this.Hide();
        }

        private void btnEdit_AdminStudentRegis_Click(object sender, EventArgs e)
        {
            AdminStudentRegistration_Edit adminStudReg_edit = new AdminStudentRegistration_Edit();
            adminStudReg_edit.Show();
            this.Hide();
        }

        private void btnView_AdminStudReg_Click(object sender, EventArgs e)
        {
            AdminStudentRegistration_View adminStudReg_view = new AdminStudentRegistration_View();
            adminStudReg_view.Show();
            this.Hide();
        }

        private void btnSearchStudent_AdminStudentRegis_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearch_AdminStudentRegis.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchValue))
            {
                dtgAdminStudentRegList.DataSource = new BindingSource { DataSource = studentSearch };
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
    }
}
