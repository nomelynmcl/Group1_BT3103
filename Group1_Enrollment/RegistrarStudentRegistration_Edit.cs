using System.Data;
using System.Data.SqlClient;

namespace EventDriven.Project.UI
{
    public partial class RegistrarStudentRegistration_Edit : Form
    {
        private bool isEdited;
        private int studentId;
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EnrollmentDB;Integrated Security=True";
        private bool isSaved;

        public RegistrarStudentRegistration_Edit(
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
            lblStudentID_RegistrarStudentRegis.Text = id.ToString();
            txtFirstName_RegistrarStudentRegistration.Text = firstname;
            txtLastname_RegistrarStudentRegistration.Text = lastname;
            txtMiddleName_RegistrarStudentRegistration.Text = middlename;
            txtContactNumber_RegistrarStudentRegistration.Text = contactNumber;
            cbGender_RegistrarStudentRegistration.Text = gender;
            txtAge_RegistrarStudentRegistration.Text = age.ToString();
            dtEdit_RegistrarBirthdate.Value = birthdate;
            txtBarangay_RegistrarStudentRegistration.Text = barangay;
            txtMunicipality_RegistrarStudentRegistration.Text = municipality;
            txtProvince_RegistrarStudentRegistration.Text = province;
            cbYearLevel_RegistrarStudentRegistration.Text = gradeLevel.ToString();
            txtGuardianName_RegistrarStudentRegistration.Text = guardian.ToString();
            txtGuardianContact_StudRegEditRegistrar.Text = guardianContact;
            cbStudentType_RegistrarStudentRegistration.Text = studentType;

            //  Auto-set section based on grade
            lbSection_StudRegEditRegistrar.Text = string.IsNullOrWhiteSpace(section)
                ? GetSectionByGradeLevel(gradeLevel)
                : section;

            //  Auto-check Requirements
            if (!string.IsNullOrWhiteSpace(requirements))
            {
                var reqItems = requirements.Split(',').Select(r => r.Trim().ToLower()).ToList();
                for (int i = 0; i < clbRequirements_RegistrarStudentRegistration.Items.Count; i++)
                {
                    string itemText = clbRequirements_RegistrarStudentRegistration.Items[i].ToString().ToLower();
                    if (reqItems.Contains(itemText))
                        clbRequirements_RegistrarStudentRegistration.SetItemChecked(i, true);
                }
            }

            //  Auto-check Mode of Payment
            if (!string.IsNullOrWhiteSpace(modeOfPayment))
            {
                var payItems = modeOfPayment.Split(',').Select(p => p.Trim().ToLower()).ToList();
                for (int i = 0; i < clbModeOfPayment_RegistrarStudentRegistration.Items.Count; i++)
                {
                    string itemText = clbModeOfPayment_RegistrarStudentRegistration.Items[i].ToString().ToLower();
                    if (payItems.Contains(itemText))
                        clbModeOfPayment_RegistrarStudentRegistration.SetItemChecked(i, true);
                }
            }

            // Track unsaved changes for Requirements
            clbRequirements_RegistrarStudentRegistration.ItemCheck += (s, e) =>
            {
                this.BeginInvoke(new Action(() => isEdited = true));
            };

            // Allow only one mode of payment and track unsaved changes
            clbModeOfPayment_RegistrarStudentRegistration.ItemCheck += (s, e) =>
            {
                if (e.NewValue == CheckState.Checked)
                {
                    for (int i = 0; i < clbModeOfPayment_RegistrarStudentRegistration.Items.Count; i++)
                    {
                        if (i != e.Index)
                        {
                            clbModeOfPayment_RegistrarStudentRegistration.SetItemChecked(i, false);
                        }
                    }
                }

                this.BeginInvoke(new Action(() => isEdited = true));
            };

            //  Update section instantly when grade changes
            cbYearLevel_RegistrarStudentRegistration.SelectedIndexChanged += UpdateSectionInstantly;
            cbYearLevel_RegistrarStudentRegistration.TextChanged += UpdateSectionInstantly;

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
            if (int.TryParse(cbYearLevel_RegistrarStudentRegistration.Text, out int selectedGrade))
            {
                lbSection_StudRegEditRegistrar.Text = GetSectionByGradeLevel(selectedGrade);
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


        private void btnRegistar_EditBack_Click(object sender, EventArgs e)
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
                    btnSave_RegistrarStudentRegistration.PerformClick(); // Save first
                    RegistrarStudentRegistration registrarStudReg = new RegistrarStudentRegistration();
                    registrarStudReg.Show();
                    this.Close();
                }
                else if (result == DialogResult.No)
                {
                    RegistrarStudentRegistration registrarStudReg = new RegistrarStudentRegistration();
                    registrarStudReg.Show();
                    this.Close();
                }
                // Cancel does nothing
            }
            else
            {
                RegistrarStudentRegistration registrarStudReg = new RegistrarStudentRegistration();
                registrarStudReg.Show();
                this.Close();
            }
        }

        private void btnSave_RegistrarStudentRegistration_Click(object sender, EventArgs e)
        {
            string newLastName = txtLastname_RegistrarStudentRegistration.Text.Trim();
            string newFirstName = txtFirstName_RegistrarStudentRegistration.Text.Trim();
            string newMiddleName = txtMiddleName_RegistrarStudentRegistration.Text.Trim();
            string newGender = cbGender_RegistrarStudentRegistration.Text.Trim();
            string newBarangay = txtBarangay_RegistrarStudentRegistration.Text.Trim();
            string newMunicipality = txtMunicipality_RegistrarStudentRegistration.Text.Trim();
            string newProvince = txtProvince_RegistrarStudentRegistration.Text.Trim();
            string newContactNumber = txtContactNumber_RegistrarStudentRegistration.Text.Trim();
            string newGuardian = txtGuardianName_RegistrarStudentRegistration.Text.Trim();
            string newGuardianContact = txtGuardianContact_StudRegEditRegistrar.Text.Trim();
            string newYearLevel = cbYearLevel_RegistrarStudentRegistration.Text.Trim();
            string newStudentType = cbStudentType_RegistrarStudentRegistration.Text.Trim();
            string newAge = txtAge_RegistrarStudentRegistration.Text.Trim();
            DateTime newBirthdate = dtEdit_RegistrarBirthdate.Value;
            string newSection = lbSection_StudRegEditRegistrar.Text.Trim();

            //  Correct way to get ALL checked items
            string newRequirements = string.Join(", ",
                clbRequirements_RegistrarStudentRegistration.CheckedItems.Cast<string>());

            string newModeOfPayment = string.Join(", ",
                clbModeOfPayment_RegistrarStudentRegistration.CheckedItems.Cast<string>());

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

        private void btnDelete_RegistrarStudentRegistration_Click(object sender, EventArgs e)
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
                            var registrarStudReg = new RegistrarStudentRegistration();
                            registrarStudReg.ShowDialog();
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

        private void btnAdminStudentInformation4_Click(object sender, EventArgs e)
        {
            Registrar___Student_Information regStudInfo = new Registrar___Student_Information();
            regStudInfo.Show();
            this.Hide();
        }

        private void btnAdminOut4_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void btnView_RegistrarRegistration_Admin_Click(object sender, EventArgs e)
        {
            RegistrarStudentRegistration_View regStudReg_view = new RegistrarStudentRegistration_View();
            regStudReg_view.Show();
            this.Hide();
        }
    }
}
