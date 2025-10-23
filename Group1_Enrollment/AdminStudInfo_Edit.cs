using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace EventDriven.Project.UI
{
    public partial class AdminStudInfo_Edit : Form
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EnrollmentDB;Integrated Security=True";

        private int studentId;

        public AdminStudInfo_Edit(
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
            string studentType
            )
        {
            InitializeComponent();
            studentId = id;

            txtAdminEditFname.Text = firstname;
            txtAdminEditLname.Text = lastname;
            txtAdminEditMname.Text = middlename;
            txtAdminEditStudContact.Text = contactNumber;
            cbAdminEditGender.Text = gender;
            txtAdminEditAge.Text = age.ToString();
            dtAdminEditBirth.Value = birthdate;
            txtAdminEditBarangay.Text = barangay;
            txtAdminEditMunicipality.Text = municipality;
            txtAdminEditProvince.Text = province;
            cbAdminEditLevel.Text = gradeLevel.ToString();
            txtAdminEditGuardian.Text = guardian.ToString();
            txtAdminEditGuardianContact.Text = guardianContact;
            cbAdminEditType.Text = studentType;

        }

        private void pcAdminLogo4_Click(object sender, EventArgs e)
        {
            AdminDashboard adDashboard = new AdminDashboard();
            adDashboard.Show();
            this.Close();
        }

        private void btnAdminBack_Edit_Click(object sender, EventArgs e)
        {
            AdminStudentInformation adminStudInfo = new AdminStudentInformation();
            adminStudInfo.Show();
            this.Close();
        }

        private void btnAdminStudInfoSave_Edit_Click(object sender, EventArgs e)
        {
            string newLastName = txtAdminEditLname.Text.Trim();
            string newFirstName = txtAdminEditFname.Text.Trim();
            string newMiddleName = txtAdminEditMname.Text.Trim();
            string newGender = cbAdminEditGender.Text.Trim();
            string newBarangay = txtAdminEditBarangay.Text.Trim();
            string newMunicipality = txtAdminEditMunicipality.Text.Trim();
            string newProvince = txtAdminEditProvince.Text.Trim();
            string newContactNumber = txtAdminEditStudContact.Text.Trim();
            string newGuardian = txtAdminEditGuardian.Text.Trim();
            string newGuardianContact = txtAdminEditGuardianContact.Text.Trim();
            string newYearLevel = cbAdminEditLevel.Text.Trim();
            string newStudentType = cbAdminEditType.Text.Trim();
            string newAge = txtAdminEditAge.Text.Trim();
            DateTime newBirthdate = dtAdminEditBirth.Value;

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

        private void btnAdminStudInfoDelete_Edit_Click(object sender, EventArgs e)
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
                            AdminStudentInformation mainForm = Application.OpenForms
                                .OfType<AdminStudentInformation>()
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

        private void btnAdminEditView_Click(object sender, EventArgs e)
        {
            string firstname = txtAdminEditFname.Text.Trim();
            string middlename = txtAdminEditMname.Text.Trim();
            string lastname = txtAdminEditLname.Text.Trim();
            int age = int.Parse(txtAdminEditAge.Text.Trim());
            DateTime birthdate = dtAdminEditBirth.Value;
            string gender = cbAdminEditGender.Text.Trim();
            string barangay = txtAdminEditBarangay.Text.Trim();
            string municipality = txtAdminEditMunicipality.Text.Trim();
            string province = txtAdminEditProvince.Text.Trim();
            string contactNumber = txtAdminEditStudContact.Text.Trim();
            string guardianName = txtAdminEditGuardian.Text.Trim();
            string guardianContact = txtAdminEditGuardianContact.Text.Trim();
            int gradeLevel = Convert.ToInt32(cbAdminEditLevel.Text.Trim());
            string studentType = cbAdminEditType.Text.Trim();

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
            this.Hide();
        }
    }
}
