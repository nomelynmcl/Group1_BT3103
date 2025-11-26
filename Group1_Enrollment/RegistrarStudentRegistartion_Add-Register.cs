using System.Data;
using System.Data.SqlClient;

namespace EventDriven.Project.UI
{
    public partial class RegistrarStudentRegistration_Add : Form
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EnrollmentDB;Integrated Security=True";
        private bool isEdited;
        private bool isSaved;
        private int id;
        private bool isInitializing = true;

        public RegistrarStudentRegistration_Add(
            int studentId,
            string lastname,
            string firstname,
            string middlename,
            string suffix,
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
            string modeOfPayment,
            string schoolYear)
        {
            InitializeComponent();

            id = studentId;
            lblStudentID_RegistrarStudentRegistrationEdit.Text = id.ToString();
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
            txtSuffix.Text = suffix;
            cbSyear.Text = schoolYear;

            LoadSectionsByGradeLevel();
            if (!string.IsNullOrEmpty(section) && cbSection.Items.Contains(section))
            {
                cbSection.SelectedItem = section;
            }

            txtGuardiansName_RegistrarStudentInformationEdit.Text = guardianName;
            txtGuardiansContactNumber_RegistrarStudentInformationEdit.Text = guardianContact;
            cbStudentType_RegistrarStudentInformationEdit.Text = studentType;


            if (!string.IsNullOrEmpty(requirements))
            {
                var reqItems = requirements.Split(',').Select(r => r.Trim()).ToList();
                for (int i = 0; i < clbRequirements_RegistrarStudentInformationEdit.Items.Count; i++)
                {
                    if (reqItems.Contains(clbRequirements_RegistrarStudentInformationEdit.Items[i].ToString()))
                        clbRequirements_RegistrarStudentInformationEdit.SetItemChecked(i, true);
                }
            }

            if (!string.IsNullOrEmpty(modeOfPayment))
            {
                var payItems = modeOfPayment.Split(',').Select(p => p.Trim()).ToList();
                for (int i = 0; i < clbModeOfPayment_RegistrarStudentInformationEdit.Items.Count; i++)
                {
                    if (payItems.Contains(clbModeOfPayment_RegistrarStudentInformationEdit.Items[i].ToString()))
                        clbModeOfPayment_RegistrarStudentInformationEdit.SetItemChecked(i, true);
                }
            }

            clbModeOfPayment_RegistrarStudentInformationEdit.ItemCheck += (s, e) =>
            {
                if (e.NewValue == CheckState.Checked)
                {
                    for (int i = 0; i < clbModeOfPayment_RegistrarStudentInformationEdit.Items.Count; i++)
                    {
                        if (i != e.Index)
                            clbModeOfPayment_RegistrarStudentInformationEdit.SetItemChecked(i, false);
                    }
                }
            };

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

            cbYearLevel_RegistrarStudentInformationEdit.SelectedIndexChanged += (s, e) =>
            {
                if (!isInitializing)
                {
                    LoadSectionsByGradeLevel();
                    isEdited = true;
                }
            };

            isInitializing = false;
            txtContactNumber_RegistrarStudentInformationEdit.MaxLength = 11;
            txtGuardiansContactNumber_RegistrarStudentInformationEdit.MaxLength = 11;

            UpdateStudentStatus(studentId);
        }

        private void LoadSectionsByGradeLevel()
        {
            cbSection.Items.Clear();

            if (!int.TryParse(cbYearLevel_RegistrarStudentInformationEdit.Text, out int grade))
                return;

            switch (grade)
            {
                case 7:
                    cbSection.Items.Add("Sirius");
                    cbSection.Items.Add("Rigel");
                    break;
                case 8:
                    cbSection.Items.Add("Polaris");
                    cbSection.Items.Add("Vega");
                    break;
                case 9:
                    cbSection.Items.Add("Phoenix");
                    cbSection.Items.Add("Altair");
                    break;
                case 10:
                    cbSection.Items.Add("Pegasus");
                    cbSection.Items.Add("Deneb");
                    break;
                default:
                    cbSection.Items.Add("Unassigned");
                    break;
            }

            // Automatically select first section
            if (cbSection.Items.Count > 0)
                cbSection.SelectedIndex = 0;
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
                    btnRegister_RegistrarStudentInformationEdit.PerformClick();
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
            }
            else
            {
                AdminStudentRegistration adminStudReg = new AdminStudentRegistration();
                adminStudReg.Show();
                this.Close();
            }
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
            string newSuffix = txtSuffix.Text.Trim();
            string newSchoolYear = cbSyear.Text.Trim();

            string section = cbSection.Text.Trim();


            string requirements = string.Join(", ",
                clbRequirements_RegistrarStudentInformationEdit.CheckedItems.Cast<string>());

            string modeOfPayment = string.Join(", ",
                clbModeOfPayment_RegistrarStudentInformationEdit.CheckedItems.Cast<string>());

            if (string.IsNullOrEmpty(newFirstName) || string.IsNullOrEmpty(newLastName))
            {
                MessageBox.Show("First and Last name are required.");
                return;
            }

            string query = @"UPDATE StudentRecord
                             SET Requirements = @Requirements,
                                 ModeOfPayment = @ModeOfPayment,
                                 LastName = @LastName,
                                 FirstName = @FirstName,
                                 MiddleName = @MiddleName,
                                 Suffix = @Suffix,
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
                                 Section = @Section,
                                 SchoolYear = @SchoolYear
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
                    cmd.Parameters.AddWithValue("@Suffix", newSuffix);
                    cmd.Parameters.AddWithValue("@SchoolYear", newSchoolYear);

                    try
                    {
                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("✅ Student registration completed successfully!");
                            isSaved = true;
                            isEdited = false;
                        }
                        else
                        {
                            MessageBox.Show("❌ Student ID not found in records.");
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("❌ Error: " + ex.Message);
                    }


                }
            }
        }

        private void btnView_RegistrarStudentInformationEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAge_RegistrarStudentInformationEdit.Text) || !int.TryParse(txtAge_RegistrarStudentInformationEdit.Text, out int age))
            {
                MessageBox.Show("⚠ Please enter a valid age.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbYearLevel_RegistrarStudentInformationEdit.SelectedItem == null || !int.TryParse(cbYearLevel_RegistrarStudentInformationEdit.SelectedItem.ToString(), out int gradeLevel))
            {
                MessageBox.Show("⚠ Please select a valid grade level.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(lblStudentID_RegistrarStudentRegistrationEdit.Text.Trim());
            string firstName = txtFirstName_RegistrarStudentInformationEdit.Text.Trim();
            string middleName = txtMiddleName_RegistrarStudentInformationEdit.Text.Trim();
            string lastName = txtLname_RegistrarStudentInformationEdit.Text.Trim();
            string suffix = txtSuffix.Text.Trim();
            DateTime birthdate = dtAdminEditBirthdate.Value;
            string gender = cbGender_RegistrarStudentInformationEdit.SelectedItem.ToString();
            string barangay = txtBarangay_RegistrarStudentInformationEdit.Text.Trim();
            string municipality = txtMunicipality_RegistrarStudentInformationEdit.Text.Trim();
            string province = txtProvince_RegistrarStudentInformationEdit.Text.Trim();
            string contactNumber = txtContactNumber_RegistrarStudentInformationEdit.Text.Trim();
            string guardianName = txtGuardiansName_RegistrarStudentInformationEdit.Text.Trim();
            string guardianContact = txtGuardiansContactNumber_RegistrarStudentInformationEdit.Text.Trim();
            string section = cbSection.Text.Trim();
            string studentType = cbStudentType_RegistrarStudentInformationEdit.SelectedItem.ToString();
            string schoolYear = cbSyear.SelectedItem.ToString();

            string requirements = string.Join(", ",
                clbRequirements_RegistrarStudentInformationEdit.CheckedItems.Cast<string>());

            string modeOfPayment = string.Join(", ",
                clbModeOfPayment_RegistrarStudentInformationEdit.CheckedItems.Cast<string>());


            RegistrarStudentRegistration_View registrarStudReg_view = new RegistrarStudentRegistration_View(
                id,
                firstName,
                middleName,
                lastName,
                suffix,
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
                studentType,
                section,
                requirements,
                modeOfPayment,
                schoolYear);
            registrarStudReg_view.Show();
            this.Hide();
        }

        private void pcAdminLogo4_Click(object sender, EventArgs e)
        {
            RegistrarDashboard registrarDashboard = new RegistrarDashboard();
            registrarDashboard.Show();
            this.Close();
        }

        private void btnAdminStudentInformation4_Click(object sender, EventArgs e)
        {
            Registrar___Student_Information registrar___Student_Information = new Registrar___Student_Information();
            registrar___Student_Information.Show();
            this.Close();
        }

        private void btnAdminAssessment4_Click(object sender, EventArgs e)
        {
            RegistrarAssesment registrarAssesment = new RegistrarAssesment();
            registrarAssesment.Show();
            this.Close();
        }

        private void btnAdminReport4_Click(object sender, EventArgs e)
        {
            RegistrarReport registrarReport = new RegistrarReport();
            registrarReport.Show();
            this.Close();
        }

        private void UpdateStudentStatus(int studentId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT TOP 1 AmountPaid FROM PaymentRecord WHERE Id=@StudentId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@StudentId", studentId);
                        object result = cmd.ExecuteScalar();

                        if (result != null && Convert.ToDecimal(result) > 0)
                            lbStatus.Text = "Enrolled";
                        else
                            lbStatus.Text = "Pending Enrollment";
                    }
                }
            }
            catch
            {
                lbStatus.Text = "Pending Enrollment";
            }
        }

        private void dtAdminEditBirthdate_ValueChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            DateTime birth = dtAdminEditBirthdate.Value;

            int age = today.Year - birth.Year;

            if (birth > today.AddYears(-age))
                age--;

            txtAge_RegistrarStudentInformationEdit.Text = age.ToString();
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
                        cmd.Parameters.AddWithValue("@Id", id);
                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();
                        conn.Close();

                        if (rows > 0)
                        {
                            MessageBox.Show("✅ Student record deleted successfully!");

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

