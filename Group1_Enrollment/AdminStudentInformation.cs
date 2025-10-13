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
            AddActionButton();

        }

        private void AddActionButton()
        {
            if (dtgAdminStudentInfoList.Columns["View"] == null)
            {
                DataGridViewButtonColumn viewButton = new DataGridViewButtonColumn();
                viewButton.HeaderText = "";
                viewButton.Text = "View";
                viewButton.Name = "View";
                viewButton.UseColumnTextForButtonValue = true;
                dtgAdminStudentInfoList.Columns.Add(viewButton);
            }
        }

        private void LoadStudentRecords()
        {
            try
            {
                string query = "SELECT Id, Firstname, LastName, MiddleName, ContactNumber, Gender, Address, GradeLevel, Section FROM StudentRecord";

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
                                Firstname = reader["FirstName"].ToString(),
                                Lastname = reader["LastName"].ToString(),
                                Middlename = reader["MiddleName"].ToString(),
                                ContactNumber = reader["ContactNumber"].ToString(),
                                Gender = reader["Gender"].ToString(),
                                Address = reader["Address"].ToString(),
                                GradeLevel = Convert.ToInt32(reader["GradeLevel"].ToString())
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
        }

        private void btnAdminStudInfoEdit_Click(object sender, EventArgs e)
        {
            if (dtgAdminStudentInfoList.CurrentRow != null)
            {
                // Get data from the c
                string firstname = dtgAdminStudentInfoList.CurrentRow.Cells["FirstName"].Value.ToString();
                string lastname = dtgAdminStudentInfoList.CurrentRow.Cells["LastName"].Value.ToString();
                string middlename = dtgAdminStudentInfoList.CurrentRow.Cells["MiddleName"].Value.ToString();
                string contactNumber = dtgAdminStudentInfoList.CurrentRow.Cells["ContactNumber"].Value.ToString();
                string gender = dtgAdminStudentInfoList.CurrentRow.Cells["Gender"].Value.ToString();
                string address = dtgAdminStudentInfoList.CurrentRow.Cells["Address"].Value.ToString();
                int gradeLevel = Convert.ToInt32(dtgAdminStudentInfoList.CurrentRow.Cells["GradeLevel"].Value);


                AdminStudentInformation_Edit adStudInfo_edit = new AdminStudentInformation_Edit(
                    firstname,
                    lastname,
                    middlename,
                    contactNumber,
                    gender,
                    address,
                    gradeLevel);
                adStudInfo_edit.Show();
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
        }
    }
}
