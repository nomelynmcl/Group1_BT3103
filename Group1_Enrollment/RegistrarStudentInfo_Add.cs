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
    public partial class RegistrarStudentInfo_Add : Form
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EnrollmentDB;Integrated Security=True";

        public RegistrarStudentInfo_Add()
        {
            InitializeComponent();
        }

        private void btnRegistrarBack_Click(object sender, EventArgs e)
        {
            Registrar___Student_Information regStudInfo = new Registrar___Student_Information();
            regStudInfo.Show();
        }

        private void btnRegistrarStudInfoAdd2_Click(object sender, EventArgs e)
        {
            string lastname = txtRegistrarAddLname.Text.Trim();
            string firstname = txtRegistrarAddFname.Text.Trim();
            string middlename = txtRegistrarAddMname.Text.Trim();
            int age = int.Parse(txtRegistrarAddAge.Text);
            DateTime birthdate = dtRegistrarAddBirth.Value;
            string gender = cbRegistrarAddGender.SelectedItem.ToString();
            string barangay = txtRegistrarAddBarangay.Text.Trim();
            string municipality = txtRegistrarAddMunicipality.Text.Trim();
            string province = txtRegistrarAddProvince.Text.Trim();
            string contactNumber = txtRegistrarAddStudContact.Text.Trim();
            string guardianName = txtRegistrarAddGuardian.Text.Trim();
            string guardianContact = txtRegistrarAddGuardianContact.Text.Trim();
            int gradeLevel = Convert.ToInt32(cbRegistrarAddLevel.SelectedItem.ToString());
            string studentType = cbRegistrarAddType.SelectedItem.ToString();

            string section = "unassigned";
            string enrollmentStatus = "unassigned";

            // 2. Insert the data into database
            string query = @"INSERT INTO StudentRecord 
                    (Lastname, Firstname, Middlename, Age, Birthdate, Gender, Barangay, Municipality, Province, ContactNumber, GuardianName, GuardianContact, GradeLevel, StudentType, Section, EnrollmentStatus) 
                    VALUES 
                    (@Lastname, @Firstname, @Middlename, @Age, @Birthdate, @Gender, @Barangay, @Municipality, @Province, @ContactNumber, @GuardianName, @GuardianContact, @GradeLevel, @StudentType, @Section, @EnrollmentStatus)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Lastname", lastname);
                    cmd.Parameters.AddWithValue("@Firstname", firstname);
                    cmd.Parameters.AddWithValue("@Middlename", middlename);
                    cmd.Parameters.AddWithValue("@Age", age);
                    cmd.Parameters.AddWithValue("@Birthdate", birthdate);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Barangay", barangay);
                    cmd.Parameters.AddWithValue("@Municipality", municipality);
                    cmd.Parameters.AddWithValue("@Province", province);
                    cmd.Parameters.AddWithValue("@ContactNumber", contactNumber);
                    cmd.Parameters.AddWithValue("@GuardianName", guardianName);
                    cmd.Parameters.AddWithValue("@GuardianContact", guardianContact);
                    cmd.Parameters.AddWithValue("@GradeLevel", gradeLevel);
                    cmd.Parameters.AddWithValue("@StudentType", studentType);
                    cmd.Parameters.AddWithValue("@Section", section);
                    cmd.Parameters.AddWithValue("@EnrollmentStatus", enrollmentStatus);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("✅ Student added successfully!");

                        // Optional: Refresh the main DataGridView if it's open
                        if (Application.OpenForms["AdminStudentInformation"] != null)
                        {
                            var mainForm = (AdminStudentInformation)Application.OpenForms["AdminStudentInformation"];
                            mainForm.LoadStudentRecords(); // make LoadStudentRecords public
                        }
                        // close the Add form
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("❌ Error: " + ex.Message);
                    }
                }
            }
        }

        private void btnRegistrarAddView_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRegistrarAddAge.Text) || !int.TryParse(txtRegistrarAddAge.Text, out int age))
            {
                MessageBox.Show("⚠ Please enter a valid age.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate grade level
            if (cbRegistrarAddLevel.SelectedItem == null || !int.TryParse(cbRegistrarAddLevel.SelectedItem.ToString(), out int gradeLevel))
            {
                MessageBox.Show("⚠ Please select a valid grade level.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string firstname = txtRegistrarAddFname.Text.Trim();
            string middlename = txtRegistrarAddMname.Text.Trim();
            string lastname = txtRegistrarAddLname.Text.Trim();
            DateTime birthdate = dtRegistrarAddBirth.Value;
            string gender = cbRegistrarAddGender.SelectedItem.ToString();
            string barangay = txtRegistrarAddBarangay.Text.Trim();
            string municipality = txtRegistrarAddMunicipality.Text.Trim();
            string province = txtRegistrarAddProvince.Text.Trim();
            string contactNumber = txtRegistrarAddStudContact.Text.Trim();
            string guardianName = txtRegistrarAddGuardian.Text.Trim();
            string guardianContact = txtRegistrarAddGuardianContact.Text.Trim();
            string studentType = cbRegistrarAddType.SelectedItem.ToString();

            AdminStudentInformation_View viewForm = new AdminStudentInformation_View(
                firstname,
                middlename,
                lastname,
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
        }

        private void btnRegistrarOut2_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void pcRegistrarLogo3_Click(object sender, EventArgs e)
        {
            RegistrarDashboard regDashboard = new RegistrarDashboard();
            regDashboard.Show();
        }
    }
}
