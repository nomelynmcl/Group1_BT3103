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
    public partial class AdminStudentRegistration_Add : Form
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EnrollmentDB;Integrated Security=True";
        private bool isEdited = false;

        public AdminStudentRegistration_Add(
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

            lblStudentID_AdminStudentRegisAdd.Text = studentId.ToString();
            txtLastname_AdminStudentRegistrationAdd.Text = lastname;
            txtFirstName_AdminStudentRegistrationAdd.Text = firstname;
            txtMiddleName_AdminStudentRegistrationAdd.Text = middlename;
            txtAge_AdminStudentRegistrationAdd.Text = age.ToString();
            txtContactNumber_AdminStudentRegistrationAdd.Text = contactNumber;
            cbGender_AdminStudentRegistrationAdd.Text = gender;
            dtAdminAddBirthdate.Value = birthdate;
            txtBarangay_AdminStudentRegistrationAdd.Text = barangay;
            txtMunicipality_AdminStudentRegistrationAdd.Text = municipality;
            txtProvince_AdminStudentRegistrationAdd.Text = province;
            cbYearLevel_AdminStudentRegistrationAdd.Text = gradeLevel.ToString();
            txtGuardianName_AdminStudentRegistrationAdd.Text = guardianName;
            txtGuardianContactNumber_AdminStudentRegistrationAdd.Text = guardianContact;
            cbStudentType_AdminStudentRegistrationAdd.Text = studentType;

            lbAdminStudReg_SectionAdd.Text = GetSectionByGradeLevel(gradeLevel);

            if (!string.IsNullOrEmpty(requirements))
            {
                var reqItems = requirements.Split(',').Select(r => r.Trim()).ToList();
                for (int i = 0; i < clbRequirements_AdminStudentRegistrationAdd.Items.Count; i++)
                {
                    if (reqItems.Contains(clbRequirements_AdminStudentRegistrationAdd.Items[i].ToString()))
                        clbRequirements_AdminStudentRegistrationAdd.SetItemChecked(i, true);
                }
            }

            // Fill checked items for Mode of Payment
            if (!string.IsNullOrEmpty(modeOfPayment))
            {
                var payItems = modeOfPayment.Split(',').Select(p => p.Trim()).ToList();
                for (int i = 0; i < clbModeOfPayment_AdminStudentRegistrationAdd.Items.Count; i++)
                {
                    if (payItems.Contains(clbModeOfPayment_AdminStudentRegistrationAdd.Items[i].ToString()))
                        clbModeOfPayment_AdminStudentRegistrationAdd.SetItemChecked(i, true);
                }
            }

            //Detect when any field is edited
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                    (ctrl as TextBox).TextChanged += (s, e) => isEdited = true;
                else if (ctrl is ComboBox)
                    (ctrl as ComboBox).SelectedIndexChanged += (s, e) => isEdited = true;
                else if (ctrl is CheckedListBox)
                    (ctrl as CheckedListBox).ItemCheck += (s, e) => isEdited = true;
                else if (ctrl is DateTimePicker)
                    (ctrl as DateTimePicker).ValueChanged += (s, e) => isEdited = true;
            }

            // Auto-change section when grade level changes
            cbYearLevel_AdminStudentRegistrationAdd.SelectedIndexChanged += (s, e) =>
            {
                if (int.TryParse(cbYearLevel_AdminStudentRegistrationAdd.Text, out int selectedGrade))
                {
                    lbAdminStudReg_SectionAdd.Text = GetSectionByGradeLevel(selectedGrade);
                    isEdited = true; // Mark as edited
                }
            };
        }

        private string GetSectionByGradeLevel(int gradeLevel)
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

        private void btnAdd_AdminStudentRegistrationAdd_Click(object sender, EventArgs e)
        {
            string newLastName = txtLastname_AdminStudentRegistrationAdd.Text.Trim();
            string newFirstName = txtFirstName_AdminStudentRegistrationAdd.Text.Trim();
            string newMiddleName = txtMiddleName_AdminStudentRegistrationAdd.Text.Trim();
            string newGender = cbGender_AdminStudentRegistrationAdd.Text.Trim();
            string newBarangay = txtBarangay_AdminStudentRegistrationAdd.Text.Trim();
            string newMunicipality = txtMunicipality_AdminStudentRegistrationAdd.Text.Trim();
            string newProvince = txtProvince_AdminStudentRegistrationAdd.Text.Trim();
            string newContactNumber = txtContactNumber_AdminStudentRegistrationAdd.Text.Trim();
            string newGuardian = txtGuardianName_AdminStudentRegistrationAdd.Text.Trim();
            string newGuardianContact = txtGuardianContactNumber_AdminStudentRegistrationAdd.Text.Trim();
            string newYearLevel = cbYearLevel_AdminStudentRegistrationAdd.Text.Trim();
            string newStudentType = cbStudentType_AdminStudentRegistrationAdd.Text.Trim();
            string newAge = txtAge_AdminStudentRegistrationAdd.Text.Trim();
            DateTime newBirthdate = dtAdminAddBirthdate.Value;
            string studentId = lblStudentID_AdminStudentRegisAdd.Text.Trim();

            string section = GetSectionByGradeLevel(int.Parse(newYearLevel));

            // Convert checked items to comma-separated strings
            string requirements = string.Join(", ",
                clbRequirements_AdminStudentRegistrationAdd.CheckedItems.Cast<string>());

            string modeOfPayment = string.Join(", ",
                clbModeOfPayment_AdminStudentRegistrationAdd.CheckedItems.Cast<string>());

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

        private void btnAdminOut4_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_AdminStudentRegisAdd_Click(object sender, EventArgs e)
        {
            if (isEdited)
            {
                DialogResult result = MessageBox.Show(
                    "You have unsaved changes. Do you want to save before going back?",
                    "Unsaved Changes",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    btnAdd_AdminStudentRegistrationAdd.PerformClick(); // Save first
                    AdminStudentRegistration adminStudentRegistration = new AdminStudentRegistration();
                    adminStudentRegistration.Show();
                    this.Close();
                }
                else if (result == DialogResult.No)
                {
                    AdminStudentRegistration adminStudentRegistration = new AdminStudentRegistration();
                    adminStudentRegistration.Show();
                    this.Close();
                }
            }
            else
            {
                AdminStudentRegistration adminStudentRegistration = new AdminStudentRegistration();
                adminStudentRegistration.Show();
                this.Close();
            }
        }

        private void btnView_AdminStudentRegisAdd_Click(object sender, EventArgs e)
        {
            AdminStudentRegistration_View adminStudReg_view = new AdminStudentRegistration_View();
            adminStudReg_view.Show();
            this.Hide();
        }
    }
}
