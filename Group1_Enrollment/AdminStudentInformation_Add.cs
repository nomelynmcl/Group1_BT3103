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

namespace EventDriven.Project.UI
{
    public partial class AdminStudentInformation_Add : Form
    {
        
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EnrollmentDB;Integrated Security=True";
        private int newlyAddedStudentId;

        public AdminStudentInformation_Add()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void btnAdminBack_Click(object sender, EventArgs e)
        {
            AdminStudentInformation adminStudInfo = new AdminStudentInformation();
            adminStudInfo.Show();
        }

        private void btnAdminAddView_Click(object sender, EventArgs e)
        {
        //    string firstname = txtAdminAddFname.Text.Trim();
        //    string middlename = txtAdminAddMname.Text.Trim();
        //    string lastname = txtAdminAddLname.Text.Trim();
        //    int age = Convert.ToInt32(txtAdminAddAge.Text);
        //    DateTime birthdate = dtAdminAddBirth.Value;
        //    string gender = cbAdminAddGender.SelectedItem.ToString();
        //    string barangay = txtAdminAddBarangay.Text.Trim();
        //    string municipality = txtAdminAddMunicipality.Text.Trim();
        //    string province = txtAdminAddProvince.Text.Trim();
        //    string contactNumber = txtAdminAddStudContact.Text.Trim();
        //    string guardianName = txtAdminAddGuardian.Text.Trim();
        //    string guardianContact = txtAdminAddGuardianContact.Text.Trim();
        //    int gradeLevel = int.Parse(cbAdminAddLevel.SelectedItem.ToString());
        //    string studentType = cbAdminAddType.SelectedItem.ToString();

        //    AdminStudentInformation_View viewForm = new AdminStudentInformation_View(
        //        firstname,
        //        middlename,
        //        lastname,
        //        age,
        //        birthdate,
        //        gender,
        //        barangay,
        //        municipality,
        //        province,
        //        contactNumber,
        //        guardianName,
        //        guardianContact,
        //        gradeLevel,
        //        studentType
        //    );

        //    viewForm.Show();
        }
    
        

        private void btnAdminOut3_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void btnAdminStudInfoAdd2_Click(object sender, EventArgs e)
        {
            string lastname = txtAdminAddLname.Text.Trim();
            string firstname = txtAdminAddFname.Text.Trim();
            string middlename = txtAdminAddMname.Text.Trim();
            int age = int.Parse(txtAdminAddAge.Text);
            DateTime birthdate = dtAdminAddBirth.Value;
            string gender = cbAdminAddGender.SelectedItem.ToString();
            string barangay = txtAdminAddBarangay.Text.Trim();
            string municipality = txtAdminAddMunicipality.Text.Trim();
            string province = txtAdminAddProvince.Text.Trim();
            string contactNumber = txtAdminAddStudContact.Text.Trim();
            string guardianName = txtAdminAddGuardian.Text.Trim();
            string guardianContact = txtAdminAddGuardianContact.Text.Trim();
            string gradeLevel = cbAdminAddLevel.SelectedItem.ToString();
            string studentType = cbAdminAddType.SelectedItem.ToString();

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

                        this.Close(); // close the Add form
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("❌ Error: " + ex.Message);
                    }
                }
            }
        }
    }
}
