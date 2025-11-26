using System.Data;
using System.Data.SqlClient;

namespace EventDriven.Project.UI
{
    public partial class AdminStudentRegistration_Add : Form
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EnrollmentDB;Integrated Security=True";
        private bool isEdited;
        private bool isSaved;
        private int studentId;
        private bool isInitializing = true;


        public AdminStudentRegistration_Add(
            int id,
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

            studentId = id;
            lblStudentID_AdminStudentRegisAdd.Text = id.ToString();
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
            txtSuffix.Text = suffix;
            cbSyear.Text = schoolYear;
            cbYearLevel_AdminStudentRegistrationAdd.Text = gradeLevel.ToString();

            LoadSectionsByGradeLevel();
            if (!string.IsNullOrEmpty(section) && cbSection.Items.Contains(section))
            {
                cbSection.SelectedItem = section;
            }

            txtGuardianName_AdminStudentRegistrationAdd.Text = guardianName;
            txtGuardianContactNumber_AdminStudentRegistrationAdd.Text = guardianContact;
            cbStudentType_AdminStudentRegistrationAdd.Text = studentType;
            txtSuffix.Text = suffix;
            cbSyear.Text = schoolYear;
            cbSection.Text = section;

            if (!string.IsNullOrEmpty(requirements))
            {
                var reqItems = requirements.Split(',').Select(r => r.Trim()).ToList();
                for (int i = 0; i < clbRequirements_AdminStudentRegistrationAdd.Items.Count; i++)
                {
                    if (reqItems.Contains(clbRequirements_AdminStudentRegistrationAdd.Items[i].ToString()))
                        clbRequirements_AdminStudentRegistrationAdd.SetItemChecked(i, true);
                }
            }

            if (!string.IsNullOrEmpty(modeOfPayment))
            {
                var payItems = modeOfPayment.Split(',').Select(p => p.Trim()).ToList();
                for (int i = 0; i < clbModeOfPayment_AdminStudentRegistrationAdd.Items.Count; i++)
                {
                    if (payItems.Contains(clbModeOfPayment_AdminStudentRegistrationAdd.Items[i].ToString()))
                        clbModeOfPayment_AdminStudentRegistrationAdd.SetItemChecked(i, true);
                }
            }

            clbModeOfPayment_AdminStudentRegistrationAdd.ItemCheck += (s, e) =>
            {
                if (e.NewValue == CheckState.Checked)
                {
                    for (int i = 0; i < clbModeOfPayment_AdminStudentRegistrationAdd.Items.Count; i++)
                    {
                        if (i != e.Index)
                            clbModeOfPayment_AdminStudentRegistrationAdd.SetItemChecked(i, false);
                    }
                }
            };

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is System.Windows.Forms.TextBox)
                    (ctrl as System.Windows.Forms.TextBox).TextChanged += (s, e) => isEdited = true;
                else if (ctrl is System.Windows.Forms.ComboBox)
                    (ctrl as System.Windows.Forms.ComboBox).SelectedIndexChanged += (s, e) => isEdited = true;
                else if (ctrl is CheckedListBox)
                    (ctrl as CheckedListBox).ItemCheck += (s, e) => isEdited = true;
                else if (ctrl is DateTimePicker)
                    (ctrl as DateTimePicker).ValueChanged += (s, e) => isEdited = true;
            }

            cbYearLevel_AdminStudentRegistrationAdd.SelectedIndexChanged += (s, e) =>
            {
                if (!isInitializing)
                {
                    LoadSectionsByGradeLevel();
                    isEdited = true;
                }
            };

            isInitializing = false;


            txtContactNumber_AdminStudentRegistrationAdd.MaxLength = 11;
            txtGuardianContactNumber_AdminStudentRegistrationAdd.MaxLength = 11;

            studentId = Convert.ToInt32(lblStudentID_AdminStudentRegisAdd.Text);
            UpdateStudentStatus(studentId);
        }
        private void LoadSectionsByGradeLevel()
        {
            cbSection.Items.Clear();

            if (!int.TryParse(cbYearLevel_AdminStudentRegistrationAdd.Text, out int grade))
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
            string newSuffix = txtSuffix.Text.Trim();
            string newSchoolYear = cbSyear.Text.Trim();

            string section = cbSection.Text;

            int id = Convert.ToInt32(lblStudentID_AdminStudentRegisAdd.Text.Trim());


            string requirements = string.Join(", ",
                clbRequirements_AdminStudentRegistrationAdd.CheckedItems.Cast<string>());

            string modeOfPayment = string.Join(", ",
                clbModeOfPayment_AdminStudentRegistrationAdd.CheckedItems.Cast<string>());

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
                    cmd.Parameters.AddWithValue("@Id", id);
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

        private void btnAdminOut4_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_AdminStudentRegisAdd_Click(object sender, EventArgs e)
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
                    btnAdd_AdminStudentRegistrationAdd.PerformClick();
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

        private void btnView_AdminStudentRegisAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAge_AdminStudentRegistrationAdd.Text) || !int.TryParse(txtAge_AdminStudentRegistrationAdd.Text, out int age))
            {
                MessageBox.Show("⚠ Please enter a valid age.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbYearLevel_AdminStudentRegistrationAdd.SelectedItem == null || !int.TryParse(cbYearLevel_AdminStudentRegistrationAdd.SelectedItem.ToString(), out int gradeLevel))
            {
                MessageBox.Show("⚠ Please select a valid grade level.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(lblStudentID_AdminStudentRegisAdd.Text.Trim());
            string firstName = txtFirstName_AdminStudentRegistrationAdd.Text.Trim();
            string middleName = txtMiddleName_AdminStudentRegistrationAdd.Text.Trim();
            string lastName = txtLastname_AdminStudentRegistrationAdd.Text.Trim();
            DateTime birthdate = dtAdminAddBirthdate.Value;
            string gender = cbGender_AdminStudentRegistrationAdd.SelectedItem.ToString();
            string barangay = txtBarangay_AdminStudentRegistrationAdd.Text.Trim();
            string municipality = txtMunicipality_AdminStudentRegistrationAdd.Text.Trim();
            string province = txtProvince_AdminStudentRegistrationAdd.Text.Trim();
            string contactNumber = txtContactNumber_AdminStudentRegistrationAdd.Text.Trim();
            string guardianName = txtGuardianName_AdminStudentRegistrationAdd.Text.Trim();
            string guardianContact = txtGuardianContactNumber_AdminStudentRegistrationAdd.Text.Trim();
            string studentType = cbStudentType_AdminStudentRegistrationAdd.SelectedItem.ToString();
            string suffix = txtSuffix.Text.Trim();
            string schoolYear = cbSyear.SelectedItem.ToString();
            string section = cbSection.Text.Trim();

            string requirements = string.Join(", ",
                clbRequirements_AdminStudentRegistrationAdd.CheckedItems.Cast<string>());

            string modeOfPayment = string.Join(", ",
                clbModeOfPayment_AdminStudentRegistrationAdd.CheckedItems.Cast<string>());


            AdminStudentRegistration_View adminStudReg_view = new AdminStudentRegistration_View(
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
            adminStudReg_view.Show();
            this.Hide();
        }

        private void pcAdminLogo4_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Close();
        }

        private void btnAdminStudentInformation4_Click(object sender, EventArgs e)
        {
            AdminStudentInformation adminStudentInformation = new AdminStudentInformation();
            adminStudentInformation.Show();
            this.Close();
        }

        private void btnAdminAssessment4_Click(object sender, EventArgs e)
        {
            AdminAssesment adminAssesment = new AdminAssesment();
            adminAssesment.Show();
            this.Close();
        }

        private void btnAdminPay4_Click(object sender, EventArgs e)
        {
            AdminPayment adminPayment = new AdminPayment();
            adminPayment.Show();
        }

        private void btnAdminHistory4_Click(object sender, EventArgs e)
        {
            AdminPaymentHistory adminPaymentHistory = new AdminPaymentHistory();
            adminPaymentHistory.Show();
            this.Close();
        }

        private void btnAdminReport4_Click(object sender, EventArgs e)
        {
            AdminReport adminReport = new AdminReport();
            adminReport.Show();
            this.Close();
        }

        private void btnAdminOut4_Click_1(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
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

        private void AdminStudentRegistration_Add_Load(object sender, EventArgs e)
        {

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

        private void dtAdminAddBirthdate_ValueChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            DateTime birth = dtAdminAddBirthdate.Value;

            int age = today.Year - birth.Year;

            if (birth > today.AddYears(-age))
                age--;

            txtAge_AdminStudentRegistrationAdd.Text = age.ToString();
        }
    }
}
