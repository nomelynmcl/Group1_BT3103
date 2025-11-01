using System.Data;
using System.Data.SqlClient;

namespace EventDriven.Project.UI
{
    public partial class AdminStudentRegistration_Edit : Form
    {
        private int studentId;
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EnrollmentDB;Integrated Security=True";
        private bool isSaved;
        private bool isEdited;

        public AdminStudentRegistration_Edit(
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
                    string studentType,
                    string section,
                    string requirements,
                    string modeOfPayment)
        {
            InitializeComponent();

            studentId = id;
            lblStudentID_AdminStudentRegis.Text = id.ToString();
            txtFirstName_AdminStudentRegistration.Text = firstname;
            txtLname_AdminStudentRegistration.Text = lastname;
            txtMiddleName_AdminStudentRegistration.Text = middlename;
            txtContactNumber_AdminStudentRegistration.Text = contactNumber;
            cbGender_AdminStudentRegistration.Text = gender;
            txtAge_AdminStudentRegistration.Text = age.ToString();
            dtAdminEditBirthdate.Value = birthdate;
            txtBarangay_AdminStudentRegistration.Text = barangay;
            txtMunicipality_AdminStudentRegistration.Text = municipality;
            txtProvince_AdminStudentRegistration.Text = province;
            cbYearLevel_AdminStudentRegistration.Text = gradeLevel.ToString();
            txtGuardianName_AdminStudentRegistration.Text = guardian.ToString();
            txtGuardianContactNumber_AdminStudentRegistrationEdit.Text = guardianContact;
            cbStudentType_AdminStudentRegistration.Text = studentType;

            //  Auto-set section based on grade
            lbAdminStudReg_SectionEdit.Text = string.IsNullOrWhiteSpace(section)
                ? GetSectionByGradeLevel(gradeLevel)
                : section;

            //  Auto-check Requirements
            if (!string.IsNullOrWhiteSpace(requirements))
            {
                var reqItems = requirements.Split(',').Select(r => r.Trim().ToLower()).ToList();
                for (int i = 0; i < clbRequirements_AdminStudentRegistration.Items.Count; i++)
                {
                    string itemText = clbRequirements_AdminStudentRegistration.Items[i].ToString().ToLower();
                    if (reqItems.Contains(itemText))
                        clbRequirements_AdminStudentRegistration.SetItemChecked(i, true);
                }
            }

            //  Auto-check Mode of Payment
            if (!string.IsNullOrWhiteSpace(modeOfPayment))
            {
                var payItems = modeOfPayment.Split(',').Select(p => p.Trim().ToLower()).ToList();
                for (int i = 0; i < clbModeOfPayment_AdminStudentRegistration.Items.Count; i++)
                {
                    string itemText = clbModeOfPayment_AdminStudentRegistration.Items[i].ToString().ToLower();
                    if (payItems.Contains(itemText))
                        clbModeOfPayment_AdminStudentRegistration.SetItemChecked(i, true);
                }
            }

            // Track unsaved changes for Requirements
            clbRequirements_AdminStudentRegistration.ItemCheck += (s, e) =>
            {
                this.BeginInvoke(new Action(() => isEdited = true));
            };

            // Allow only one mode of payment and track unsaved changes
            clbModeOfPayment_AdminStudentRegistration.ItemCheck += (s, e) =>
            {
                if (e.NewValue == CheckState.Checked)
                {
                    for (int i = 0; i < clbModeOfPayment_AdminStudentRegistration.Items.Count; i++)
                    {
                        if (i != e.Index)
                        {
                            clbModeOfPayment_AdminStudentRegistration.SetItemChecked(i, false);
                        }
                    }
                }

                this.BeginInvoke(new Action(() => isEdited = true));
            };

            //  Update section instantly when grade changes
            cbYearLevel_AdminStudentRegistration.SelectedIndexChanged += UpdateSectionInstantly;
            cbYearLevel_AdminStudentRegistration.TextChanged += UpdateSectionInstantly;

            //  Track edited fields
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox || ctrl is ComboBox || ctrl is CheckedListBox || ctrl is DateTimePicker)
                {
                    ctrl.TextChanged += (s, e) => isEdited = true;
                }
            }
        }

        // 🔹 Updates section as soon as grade level changes
        private void UpdateSectionInstantly(object sender, EventArgs e)
        {
            if (int.TryParse(cbYearLevel_AdminStudentRegistration.Text, out int selectedGrade))
            {
                lbAdminStudReg_SectionEdit.Text = GetSectionByGradeLevel(selectedGrade);
                isEdited = true;
            }
        }

        // 🔹 Section logic
        private string GetSectionByGradeLevel(int gradeLevel)
        {
            return gradeLevel switch
            {
                7 => "Sirius",
                8 => "Polaris",
                9 => "Phoenix",
                10 => "Pegasus",
                _ => "Unassigned"
            };
        }

        private void btnAdminEditBack_Click(object sender, EventArgs e)
        {
            if (isEdited && !isSaved)
            {
                DialogResult result = MessageBox.Show(
                    "You have unsaved changes. Do you want to save before going back?",
                    "Unsaved Changes",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    btnRegister_AdminStudentRegistration.PerformClick(); // Save first
                    AdminStudentRegistration adminStudReg = new AdminStudentRegistration();
                    adminStudReg.Show();
                    this.Close();
                }
                else if (result == DialogResult.No)
                {
                    AdminStudentRegistration adminStudReg = new AdminStudentRegistration();
                    adminStudReg.Show();
                    this.Close();
                }
                // Cancel does nothing
            }
            else
            {
                AdminStudentRegistration adminStudReg = new AdminStudentRegistration();
                adminStudReg.Show();
                this.Close();
            }
        }

        private void btnView_StudentRegistration_Admin_Click(object sender, EventArgs e)
        {
            AdminStudentRegistration_View adminStudReg_edit = new AdminStudentRegistration_View();
            adminStudReg_edit.Show();
            this.Hide();
        }

        private void btnAdminStudentInformation4_Click(object sender, EventArgs e)
        {
            AdminStudentInformation adminStudInfo = new AdminStudentInformation();
            adminStudInfo.Show();
            this.Close();
        }

        private void btnAdminOut4_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void btnRegister_AdminStudentRegistration_Click(object sender, EventArgs e)
        {
            string newLastName = txtLname_AdminStudentRegistration.Text.Trim();
            string newFirstName = txtFirstName_AdminStudentRegistration.Text.Trim();
            string newMiddleName = txtMiddleName_AdminStudentRegistration.Text.Trim();
            string newGender = cbGender_AdminStudentRegistration.Text.Trim();
            string newBarangay = txtBarangay_AdminStudentRegistration.Text.Trim();
            string newMunicipality = txtMunicipality_AdminStudentRegistration.Text.Trim();
            string newProvince = txtProvince_AdminStudentRegistration.Text.Trim();
            string newContactNumber = txtContactNumber_AdminStudentRegistration.Text.Trim();
            string newGuardian = txtGuardianName_AdminStudentRegistration.Text.Trim();
            string newGuardianContact = txtGuardianContactNumber_AdminStudentRegistrationEdit.Text.Trim();
            string newYearLevel = cbYearLevel_AdminStudentRegistration.Text.Trim();
            string newStudentType = cbStudentType_AdminStudentRegistration.Text.Trim();
            string newAge = txtAge_AdminStudentRegistration.Text.Trim();
            DateTime newBirthdate = dtAdminEditBirthdate.Value;
            string newSection = lbAdminStudReg_SectionEdit.Text.Trim();

            //  Correct way to get ALL checked items
            string newRequirements = string.Join(", ",
                clbRequirements_AdminStudentRegistration.CheckedItems.Cast<string>());

            string newModeOfPayment = string.Join(", ",
                clbModeOfPayment_AdminStudentRegistration.CheckedItems.Cast<string>());

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
                         StudentType = @StudentType,
                         Requirements = @Requirements,
                         ModeOfPayment = @ModeOfPayment,
                         Section = @Section
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
                    cmd.Parameters.AddWithValue("@Id", studentId);
                    cmd.Parameters.AddWithValue("@Age", newAge);
                    cmd.Parameters.AddWithValue("@Birthdate", newBirthdate);
                    cmd.Parameters.AddWithValue("@Requirements", newRequirements);
                    cmd.Parameters.AddWithValue("@ModeOfPayment", newModeOfPayment);
                    cmd.Parameters.AddWithValue("@Section", newSection);

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (rows > 0)
                    {
                        MessageBox.Show("✅ Record updated successfully!");
                        isSaved = true;
                        isEdited = false;
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
            

        private void btnDelete_AdminStudentRegistration_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this student record?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM StudentRecord WHERE Id = @Id";

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Id", studentId);
                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();
                        conn.Close();

                        if (rows > 0)
                        {
                            MessageBox.Show("✅ Student record deleted successfully!");

                            // After deletion, go back to main Student Registration form
                            this.Hide();
                            var adminStudReg = new AdminStudentRegistration();
                            adminStudReg.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("⚠️ No record found to delete.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error deleting record: " + ex.Message);
                }
            }
        }
    }
}
