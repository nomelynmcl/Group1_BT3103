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
    public partial class RegistrarStudentInfo_Edit : Form
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EnrollmentDB;Integrated Security=True";
        private int studentId;

        public RegistrarStudentInfo_Edit(
            int id,
            string firstname,
            string lastname,
            string middlename,
            string contactNumber,
            string gender,
            int age,
            DateTime birthdate,
            string barangay,
            string municipality,
            string province,
            int gradeLevel,
            string guardian,
            string guardianContact,
            string studentType)
        {
            InitializeComponent();
            studentId = id;

            txtRegistrarEditFname.Text = firstname;
            txtRegistrarEditLname.Text = lastname;
            txtRegistrarEditMname.Text = middlename;
            txtRegistrarEditStudContact.Text = contactNumber;
            cbRegistrarEditGender.Text = gender;
            txtRegistrarEditAge.Text = age.ToString();
            dtRegistrarEditBirth.Value = birthdate;
            txtRegistrarEditBarangay.Text = barangay;
            txtRegistrarEditMunicipality.Text = municipality;
            txtRegistrarEditProvince.Text = province;
            cbRegistrarEditLevel.Text = gradeLevel.ToString();
            txtRegistrarEditGuardian.Text = guardian.ToString();
            txtRegistrarEditGuardianContact.Text = guardianContact;
            cbRegistrarEditType.Text = studentType;
        }

        private void btnRegistrarBack_Edit_Click(object sender, EventArgs e)
        {
            Registrar___Student_Information regStudInfo = new Registrar___Student_Information();
            regStudInfo.Show();
            this.Hide();
        }

        private void btnRegistrarStudInfoSave_Edit_Click(object sender, EventArgs e)
        {
            string newLastName = txtRegistrarEditLname.Text.Trim();
            string newFirstName = txtRegistrarEditFname.Text.Trim();
            string newMiddleName = txtRegistrarEditMname.Text.Trim();
            string newGender = cbRegistrarEditGender.Text.Trim();
            string newBarangay = txtRegistrarEditBarangay.Text.Trim();
            string newMunicipality = txtRegistrarEditMunicipality.Text.Trim();
            string newProvince = txtRegistrarEditProvince.Text.Trim();
            string newContactNumber = txtRegistrarEditStudContact.Text.Trim();
            string newGuardian = txtRegistrarEditGuardian.Text.Trim();
            string newGuardianContact = txtRegistrarEditGuardianContact.Text.Trim();
            string newYearLevel = cbRegistrarEditLevel.Text.Trim();
            string newStudentType = cbRegistrarEditType.Text.Trim();
            string newAge = txtRegistrarEditAge.Text.Trim();
            DateTime newBirthdate = dtRegistrarEditBirth.Value;

            if (string.IsNullOrEmpty(newFirstName) || string.IsNullOrEmpty(newLastName))
            {
                MessageBox.Show("First and Last name are required.");
                return;
            }

            string query = @"UPDATE StudentRecord
                             SET LastName = @LastName,
                                 FirstName = @FirstName,
                                 MiddleName = @MiddleName,
                                 Gender = @Gender,
                                 Age = @Age,
                                 Birthdate = @Birthdate,
                                 Barangay = @Barangay,
                                 Municipality = @Municipality,
                                 Province = @Province,
                                 ContactNumber = @ContactNumber,
                                 GuardianName = @GuardianName,
                                 GuardianContact = @GuardianContact,
                                 GradeLevel = @GradeLevel,
                                 StudentType = @StudentType
                             WHERE Id = @Id";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@LastName", newLastName);
                    cmd.Parameters.AddWithValue("@FirstName", newFirstName);
                    cmd.Parameters.AddWithValue("@MiddleName", newMiddleName);
                    cmd.Parameters.AddWithValue("@Gender", newGender);
                    cmd.Parameters.AddWithValue("@Barangay", newBarangay);
                    cmd.Parameters.AddWithValue("@Municipality", newMunicipality);
                    cmd.Parameters.AddWithValue("@Province", newProvince);
                    cmd.Parameters.AddWithValue("@ContactNumber", newContactNumber);
                    cmd.Parameters.AddWithValue("@GuardianName", newGuardian);
                    cmd.Parameters.AddWithValue("@GuardianContact", newGuardianContact);
                    cmd.Parameters.AddWithValue("@GradeLevel", newYearLevel);
                    cmd.Parameters.AddWithValue("@StudentType", newStudentType);
                    cmd.Parameters.AddWithValue("Id", studentId);
                    cmd.Parameters.AddWithValue("@Age", newAge);
                    cmd.Parameters.AddWithValue("@Birthdate", newBirthdate);


                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (rows > 0)
                    {
                        MessageBox.Show("✅ Record updated successfully!");

                    }
                    else
                    {
                        MessageBox.Show("❌ No matching record found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating record: " + ex.Message);
            }
        }

        private void btnRegistrarStudInfoDelete_Edit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this student record?", "Confirm Deletion",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Warning
    );

            if (result == DialogResult.Yes)
            {
                string deleteQuery = "DELETE FROM StudentRecord WHERE Id = @Id";

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", studentId);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        conn.Close();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("🗑️ Record deleted successfully!");

                            // Close edit form after deletion
                            this.Close();

                            // Optional: Refresh main form's DataGridView
                            Registrar___Student_Information mainForm = Application.OpenForms
                                .OfType<Registrar___Student_Information>()
                                .FirstOrDefault();

                            if (mainForm != null)
                            {
                                mainForm.LoadStudentRecords();
                            }
                        }
                        else
                        {
                            MessageBox.Show("❌ No record found to delete.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting record: " + ex.Message);
                }

            }
        }

        private void btnRegistrarEditView_Click(object sender, EventArgs e)
        {
            string firstname = txtRegistrarEditFname.Text.Trim();
            string middlename = txtRegistrarEditMname.Text.Trim();
            string lastname = txtRegistrarEditLname.Text.Trim();
            int age = int.Parse(txtRegistrarEditAge.Text.Trim());
            DateTime birthdate = dtRegistrarEditBirth.Value;
            string gender = cbRegistrarEditGender.Text.Trim();
            string barangay = txtRegistrarEditBarangay.Text.Trim();
            string municipality = txtRegistrarEditMunicipality.Text.Trim();
            string province = txtRegistrarEditProvince.Text.Trim();
            string contactNumber = txtRegistrarEditStudContact.Text.Trim();
            string guardianName = txtRegistrarEditGuardian.Text.Trim();
            string guardianContact = txtRegistrarEditGuardianContact.Text.Trim();
            int gradeLevel = Convert.ToInt32(cbRegistrarEditLevel.Text.Trim());
            string studentType = cbRegistrarEditType.Text.Trim();

            RegistrarStudentInfo_View viewForm = new RegistrarStudentInfo_View(
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
            this.Hide();
        }

        private void btnRegistrarOut3_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void pcRegistrarLogo4_Click(object sender, EventArgs e)
        {
            RegistrarDashboard regDashboard = new RegistrarDashboard();
            regDashboard.Show();
            this.Close();
        }
    }
}
