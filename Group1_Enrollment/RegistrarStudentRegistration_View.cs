using System.Drawing.Printing;

namespace EventDriven.Project.UI
{
    public partial class RegistrarStudentRegistration_View : Form
    {
        private string id, fullName, age, birthdate, gender, address,
                       contactNumber, guardianName, guardianContact,
                       gradeLevel, studentType, requirements, modeOfPayment, section;

        public RegistrarStudentRegistration_View(
            int id,
            string firstName,
            string middleName,
            string lastName,
            string suffix,
            int age,
            DateTime birthdate,
            string gender,
            string barangay,
            string municipality,
            string province,
            string contactNumber,
            string guardianName,
            string guardianContact,
            int gradeLevel,
            string studentType,
            string section,
            string requirements,
            string modeOfPayment,
            string schoolYear)
        {
            InitializeComponent();

            this.fullName = $"{lastName} {firstName} {middleName}".Replace("  ", " ").Trim();
            this.address = $"{barangay} {municipality} {province}".Replace("  ", " ").Trim();

            lblStudentID_RegistrarStudentRegistration_View.Text = id.ToString();
            lblFullName_RegistrarStudentRegistration_View.Text = fullName;
            lblAge_RegistrarStudentRegistration_View.Text = age.ToString();
            lblBirthDate_RegistrarStudentRegistration_View.Text = birthdate.ToString();
            lblGender_RegistrarStudentRegistration_View.Text = gender;
            lblAddress_RegistrarStudentRegistration_View.Text = $"{barangay} {municipality} {province}".Replace("  ", " ").Trim(); ;
            lblContactNumber_RegistrarStudentRegistration_View.Text = contactNumber;
            lblGuardiansName_RegistrarStudentRegistration_View.Text = guardianName;
            lblGuardiansContactNum_RegistrarStudentRegistration_View.Text = guardianContact;
            lblYearLevel_RegistrarStudentRegistration_View.Text = gradeLevel.ToString();
            lblStudentType_RegistrarStudentRegistration_View.Text = studentType;
            lblRequirements_RegistrarStudentRegistration_View.Text = requirements;
            lblModeOfPayment_RegistrarStudentRegistration_View.Text = modeOfPayment;
            lblRegistrarSection_ViewStudReg.Text = section;
            lbSyear.Text = schoolYear;
        }

        private void btnViewPrint_RegistrarStudentRegistration_Click(object sender, EventArgs e)
        {
            printDocument1.PrintPage -= printDocument1_PrintPage;
            printDocument1.PrintPage += printDocument1_PrintPage;

            // Show the Print Preview Dialog instead of the Print Dialog
            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            previewDialog.Document = printDocument1;
            previewDialog.WindowState = FormWindowState.Maximized;
            previewDialog.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font govHeaderFont = new Font("Arial", 12, FontStyle.Bold);
            Font schoolNameFont = new Font("Arial", 18, FontStyle.Bold);
            Font titleFont = new Font("Arial", 16, FontStyle.Bold);
            Font sectionTitleFont = new Font("Arial", 13, FontStyle.Bold | FontStyle.Underline);
            Font labelBoldFont = new Font("Arial", 12, FontStyle.Bold);
            Font valueFont = new Font("Arial", 12, FontStyle.Regular);

            float y = 80;
            float left = 70;
            float pageWidth = e.PageBounds.Width;

            // --- Logo (optional) ---
            try
            {
                Image logo = Image.FromFile("C:\\Enrollment\\Orion_Logo.png");
                e.Graphics.DrawImage(logo, left, y - 40, 120, 120);
            }
            catch { }

            // --- Government Header ---
            string[] govHeader =
            {
        "Republic of the Philippines",
        "Department of Education",
        "Region IV-A CALABARZON",
        "DIVISION OF BATANGAS",
        "DISTRICT LEARNING CENTER II"
    };

            foreach (string line in govHeader)
            {
                SizeF size = e.Graphics.MeasureString(line, govHeaderFont);
                e.Graphics.DrawString(line, govHeaderFont, Brushes.Black,
                    (pageWidth - size.Width) / 2, y);
                y += 20;
            }

            // --- School Name ---
            SizeF schoolSize = e.Graphics.MeasureString("ORION TECH-HIGH SCHOOL", schoolNameFont);
            e.Graphics.DrawString("ORION TECH-HIGH SCHOOL", schoolNameFont, Brushes.Black,
                (pageWidth - schoolSize.Width) / 2, y + 10);

            y += 50;

            // --- Divider ---
            e.Graphics.DrawLine(Pens.Black, left, y, pageWidth - left, y);
            y += 25;

            // --- Main Title ---
            SizeF titleSize = e.Graphics.MeasureString("STUDENT REGISTRATION FORM", titleFont);
            e.Graphics.DrawString("STUDENT REGISTRATION FORM", titleFont, Brushes.Black,
                (pageWidth - titleSize.Width) / 2, y);
            y += 40;

            // --- Helper Function ---
            void DrawField(string label, string value)
            {
                e.Graphics.DrawString(label, labelBoldFont, Brushes.Black, left, y);
                e.Graphics.DrawString(value, valueFont, Brushes.Black, left + 200, y);
                y += 22;
            }

            // --- Student Info Section ---
            e.Graphics.DrawString("STUDENT INFORMATION", sectionTitleFont, Brushes.Black, left, y);
            y += 30;

            DrawField("School Year:", lbSyear.Text);
            DrawField("Student ID:", lblStudentID_RegistrarStudentRegistration_View.Text);
            DrawField("Full Name:", lblFullName_RegistrarStudentRegistration_View.Text);
            DrawField("Age:", lblAge_RegistrarStudentRegistration_View.Text);
            DrawField("Birthdate:", lblBirthDate_RegistrarStudentRegistration_View.Text);
            DrawField("Gender:", lblGender_RegistrarStudentRegistration_View.Text);

            y += 10;
            e.Graphics.DrawLine(Pens.Gray, left, y, pageWidth - left, y);
            y += 25;

            // --- Contact & Address Section ---
            e.Graphics.DrawString("CONTACT & ADDRESS", sectionTitleFont, Brushes.Black, left, y);
            y += 30;

            DrawField("Address:", lblAddress_RegistrarStudentRegistration_View.Text);
            DrawField("Contact Number:", lblContactNumber_RegistrarStudentRegistration_View.Text);
            DrawField("Guardian Name:", lblGuardiansName_RegistrarStudentRegistration_View.Text);
            DrawField("Guardian Contact:", lblGuardiansContactNum_RegistrarStudentRegistration_View.Text);

            y += 10;
            e.Graphics.DrawLine(Pens.Gray, left, y, pageWidth - left, y);
            y += 25;

            // --- Enrollment Details ---
            e.Graphics.DrawString("ENROLLMENT DETAILS", sectionTitleFont, Brushes.Black, left, y);
            y += 30;

            DrawField("Year Level:", lblYearLevel_RegistrarStudentRegistration_View.Text);
            DrawField("Section:", lblRegistrarSection_ViewStudReg.Text);
            DrawField("Student Type:", lblStudentType_RegistrarStudentRegistration_View.Text);
            DrawField("Requirements:", lblRequirements_RegistrarStudentRegistration_View.Text);
            DrawField("Mode of Payment:", lblModeOfPayment_RegistrarStudentRegistration_View.Text);

            y += 40;

            // Footer
            e.Graphics.DrawLine(Pens.Black, left, y, pageWidth - left, y);
            y += 25;
            e.Graphics.DrawString("Printed on: " + DateTime.Now.ToString("MMMM dd, yyyy - hh:mm tt"),
                valueFont, Brushes.Gray, left, y);
        }

        private void btnViewCancel_RegistrarStudentRegistration_Click(object sender, EventArgs e)
        {
            RegistrarStudentRegistration registrarStudReg = new RegistrarStudentRegistration();
            registrarStudReg.Show();
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
