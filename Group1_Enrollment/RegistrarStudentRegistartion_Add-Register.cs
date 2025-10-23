using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventDriven.Project.UI
{
    public partial class RegistrarStudentRegistration_Add : Form
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EnrollmentDB;Integrated Security=True";

        public RegistrarStudentRegistration_Add(
            int studentId,
            string lastname,
            string firstname,
            string middlename,
            int age,
            string contactNumber,
            string gender,
            DateTime birthdate,
            string barangay,
            string municipality,
            string province,
            int gradeLevel,
            string guardianName,
            string guardianContact,
            string section,
            string studentType,
            string requirements,
            string modeOfPayment)
        {
            InitializeComponent();

            lblStudentID_RegistrarStudentRegistrationEdit.Text = studentId.ToString();
            txtLname_RegistrarStudentInformationEdit.Text = lastname;
            txtFirstName_RegistrarStudentInformationEdit.Text = firstname;
            txtMiddleName_RegistrarStudentInformationEdit.Text = middlename;
            txtAge_RegistrarStudentInformationEdit.Text = age.ToString();
            txtContactNumber_RegistrarStudentInformationEdit.Text = contactNumber;
            cbGender_RegistrarStudentInformationEdit.Text = gender;
            dtAdminEditBirthdate.Value = birthdate;
            txtBarangay_RegistrarStudentInformationEdit.Text = barangay;
            txtMunicipality_RegistrarStudentInformationEdit.Text = municipality;
            txtProvince_RegistrarStudentInformationEdit.Text = province;
            cbYearLevel_RegistrarStudentInformationEdit.Text = gradeLevel.ToString();
            txtGuardiansName_RegistrarStudentInformationEdit.Text = guardianName;
            txtGuardiansContactNumber_RegistrarStudentInformationEdit.Text = guardianContact;
            cbStudentType_RegistrarStudentInformationEdit.Text = studentType;

            txtSection_RegistrarStudRegAdd.Text = GetSectionByGradeLevel(gradeLevel);

            if (!string.IsNullOrEmpty(requirements))
            {
                var reqItems = requirements.Split(',').Select(r => r.Trim()).ToList();
                for (int i = 0; i < clbRequirements_RegistrarStudentInformationEdit.Items.Count; i++)
                {
                    if (reqItems.Contains(clbRequirements_RegistrarStudentInformationEdit.Items[i].ToString()))
                        clbRequirements_RegistrarStudentInformationEdit.SetItemChecked(i, true);
                }
            }

            // Fill checked items for Mode of Payment
            if (!string.IsNullOrEmpty(modeOfPayment))
            {
                var payItems = modeOfPayment.Split(',').Select(p => p.Trim()).ToList();
                for (int i = 0; i < clbModeOfPayment_RegistrarStudentInformationEdit.Items.Count; i++)
                {
                    if (payItems.Contains(clbModeOfPayment_RegistrarStudentInformationEdit.Items[i].ToString()))
                        clbModeOfPayment_RegistrarStudentInformationEdit.SetItemChecked(i, true);
                }
            }
        }

        public string GetSectionByGradeLevel(int gradeLevel)
        {
            switch (gradeLevel)
            {
                case 7: return "Sirius";
                case 8: return "Polaris";
                case 9: return "Phoenix";
                case 10: return "Pegasus";
                default: return "Unassigned";
            }
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_RegistrarStudentInformationEdit_Click(object sender, EventArgs e)
        {
            RegistrarStudentRegistration regStudReg = new RegistrarStudentRegistration();
            regStudReg.Show();
            this.Close();
        }

        private void btnAdminOut4_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void btnRegister_RegistrarStudentInformationEdit_Click(object sender, EventArgs e)
        {
            string newLastName = txtLname_RegistrarStudentInformationEdit.Text.Trim();
            string newFirstName = txtFirstName_RegistrarStudentInformationEdit.Text.Trim();
            string newMiddleName = txtMiddleName_RegistrarStudentInformationEdit.Text.Trim();
            string newGender = cbGender_RegistrarStudentInformationEdit.Text.Trim();
            string newBarangay = txtBarangay_RegistrarStudentInformationEdit.Text.Trim();
            string newMunicipality = txtMunicipality_RegistrarStudentInformationEdit.Text.Trim();
            string newProvince = txtProvince_RegistrarStudentInformationEdit.Text.Trim();
            string newContactNumber = txtContactNumber_RegistrarStudentInformationEdit.Text.Trim();
            string newGuardian = txtGuardiansName_RegistrarStudentInformationEdit.Text.Trim();
            string newGuardianContact = txtGuardiansContactNumber_RegistrarStudentInformationEdit.Text.Trim();
            string newYearLevel = cbYearLevel_RegistrarStudentInformationEdit.Text.Trim();
            string newStudentType = cbStudentType_RegistrarStudentInformationEdit.Text.Trim();
            string newAge = txtAge_RegistrarStudentInformationEdit.Text.Trim();
            DateTime newBirthdate = dtAdminEditBirthdate.Value;
            string studentId = lblStudentID_RegistrarStudentRegistrationEdit.Text.Trim();

            string section = GetSectionByGradeLevel(int.Parse(newYearLevel));

            // Convert checked items to comma-separated strings
            string requirements = string.Join(", ",
                clbRequirements_RegistrarStudentInformationEdit.CheckedItems.Cast<string>());

            string modeOfPayment = string.Join(", ",
                clbModeOfPayment_RegistrarStudentInformationEdit.CheckedItems.Cast<string>());

            if (string.IsNullOrEmpty(newFirstName) || string.IsNullOrEmpty(newLastName))
            {
                MessageBox.Show("First and Last name are required.");
                return;
            }

            // Update existing student record with registration info
            string query = @"UPDATE StudentRecord
                             SET Requirements = @Requirements,
                                 ModeOfPayment = @ModeOfPayment,
                                 LastName = @LastName,
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
                                 StudentType = @StudentType,
                                 Section = @Section
                             WHERE Id = @Id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Requirements", requirements);
                    cmd.Parameters.AddWithValue("@ModeOfPayment", modeOfPayment);
                    cmd.Parameters.AddWithValue("@StudentID", studentId);
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
                    cmd.Parameters.AddWithValue("@Id", studentId);
                    cmd.Parameters.AddWithValue("@Age", newAge);
                    cmd.Parameters.AddWithValue("@Birthdate", newBirthdate);
                    cmd.Parameters.AddWithValue("@Section", section);

                    try
                    {
                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                            MessageBox.Show("✅ Student registration completed successfully!");
                        else
                            MessageBox.Show("❌ Student ID not found in records.");

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

