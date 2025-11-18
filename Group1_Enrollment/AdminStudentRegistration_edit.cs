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

            lbAdminStudReg_SectionEdit.Text = string.IsNullOrWhiteSpace(section)
                ? GetSectionByGradeLevel(gradeLevel)
                : section;

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

            clbRequirements_AdminStudentRegistration.ItemCheck += (s, e) =>
            {
                this.BeginInvoke(new Action(() => isEdited = true));
            };

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

            cbYearLevel_AdminStudentRegistration.SelectedIndexChanged += UpdateSectionInstantly;
            cbYearLevel_AdminStudentRegistration.TextChanged += UpdateSectionInstantly;

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox || ctrl is ComboBox || ctrl is CheckedListBox || ctrl is DateTimePicker)
                {
                    ctrl.TextChanged += (s, e) => isEdited = true;
                }
            }

            txtContactNumber_AdminStudentRegistration.MaxLength = 11;
            txtGuardianContactNumber_AdminStudentRegistrationEdit.MaxLength = 11;

            UpdateStudentStatus(studentId);
        }

        private void UpdateSectionInstantly(object sender, EventArgs e)
        {
            if (int.TryParse(cbYearLevel_AdminStudentRegistration.Text, out int selectedGrade))
            {
                lbAdminStudReg_SectionEdit.Text = GetSectionByGradeLevel(selectedGrade);
                isEdited = true;
            }
        }

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
                    btnRegister_AdminStudentRegistration.PerformClick();
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

        private void btnView_StudentRegistration_Admin_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lblStudentID_AdminStudentRegis.Text.Trim());
            string firstname = txtFirstName_AdminStudentRegistration.Text.Trim();
            string middlename = txtMiddleName_AdminStudentRegistration.Text.Trim();
            string lastname = txtLname_AdminStudentRegistration.Text.Trim();
            int age = int.Parse(txtAge_AdminStudentRegistration.Text.Trim());
            DateTime birthdate = dtAdminEditBirthdate.Value;
            string gender = cbGender_AdminStudentRegistration.Text.Trim();
            string barangay = txtBarangay_AdminStudentRegistration.Text.Trim();
            string municipality = txtMunicipality_AdminStudentRegistration.Text.Trim();
            string province = txtProvince_AdminStudentRegistration.Text.Trim();
            string contactNumber = txtContactNumber_AdminStudentRegistration.Text.Trim();
            string guardianName = txtGuardianName_AdminStudentRegistration.Text.Trim();
            string guardianContact = txtGuardianContactNumber_AdminStudentRegistrationEdit.Text.Trim();
            int gradeLevel = Convert.ToInt32(cbYearLevel_AdminStudentRegistration.Text.Trim());
            string studentType = cbStudentType_AdminStudentRegistration.Text.Trim();
            string section = lbAdminStudReg_SectionEdit.Text.Trim();

            string requirements = string.Join(", ",
                clbRequirements_AdminStudentRegistration.CheckedItems.Cast<string>());

            string modeOfPayment = string.Join(", ",
                clbModeOfPayment_AdminStudentRegistration.CheckedItems.Cast<string>());

            AdminStudentRegistration_View viewForm = new AdminStudentRegistration_View(
                id,
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
                studentType,
                section,
                requirements,
                modeOfPayment
            );

            viewForm.Show();
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

        private void pcAdminLogo4_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
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
            this.Close();
        }

        private void btnAdminHistory4_Click(object sender, EventArgs e)
        {
            AdminPaymentHistory adminHistory = new AdminPaymentHistory();
            adminHistory.Show();
            this.Close();
        }

        private void btnAdminReport4_Click(object sender, EventArgs e)
        {
            AdminReport adminReport = new AdminReport();
            adminReport.Show();
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
    }
}
