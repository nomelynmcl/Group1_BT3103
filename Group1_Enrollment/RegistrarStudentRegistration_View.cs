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
            string modeOfPayment)
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
            Font schoolNameFont = new Font("Arial", 16, FontStyle.Bold);
            Font titleFont = new Font("Arial", 20, FontStyle.Bold);
            Font headerFont = new Font("Arial", 14, FontStyle.Bold);
            Font labelBoldFont = new Font("Arial", 12, FontStyle.Bold);
            Font valueFont = new Font("Arial", 12, FontStyle.Regular);

            float x = 50;
            float y = 100;
            float leftMargin = 80;

            float pageWidth = e.PageBounds.Width;

            try
            {
                Image logo = Image.FromFile("C:\\Enrollment\\Orion_Logo.png");
                float logox = 100;
                e.Graphics.DrawImage(logo, leftMargin, y - 50, 250, 150);


            }
            catch
            {
            }

            string[] headerLines =
            {
        "Republic of the Philippines",
        "Department of Education",
        "Region IV-A CALABARZON ",
        "DIVISION OF BATANGAS",
        "DISTRICT LEARNING CENTER II",
        "Orion Tech-High School",
        "Balayan, Batangas",
        " ",
        "STUDENT REGISTRATION"
    };

            foreach (string line in headerLines)
            {
                SizeF textSize = e.Graphics.MeasureString(line, govHeaderFont);
                float xCenter = (pageWidth - textSize.Width) / 2;
                e.Graphics.DrawString(line, govHeaderFont, Brushes.Black, xCenter, y);
                y += 20;
            }

            y += 10;
            e.Graphics.DrawLine(Pens.Black, leftMargin, y, pageWidth - leftMargin, y);
            y += 30;


            void DrawLine(string label, string value)
            {
                e.Graphics.DrawString(label, labelBoldFont, Brushes.Black, leftMargin, y);
                e.Graphics.DrawString(value, valueFont, Brushes.Black, leftMargin + 180, y);
                y += 25;
            }

            // --- Student Information ---
            DrawLine("Student ID:", lblStudentID_RegistrarStudentRegistration_View.Text);
            DrawLine("Full Name:", lblFullName_RegistrarStudentRegistration_View.Text);
            DrawLine("Age:", lblAge_RegistrarStudentRegistration_View.Text);
            DrawLine("Birthdate:", lblBirthDate_RegistrarStudentRegistration_View.Text);
            DrawLine("Gender:", lblGender_RegistrarStudentRegistration_View.Text);
            DrawLine("Address:", lblAddress_RegistrarStudentRegistration_View.Text);
            DrawLine("Contact No.:", lblContactNumber_RegistrarStudentRegistration_View.Text);
            DrawLine("Guardian:", lblGuardiansName_RegistrarStudentRegistration_View.Text);
            DrawLine("Guardian Contact:", lblGuardiansContactNum_RegistrarStudentRegistration_View.Text);
            DrawLine("Year Level:", lblYearLevel_RegistrarStudentRegistration_View.Text);
            DrawLine("Section:", lblRegistrarSection_ViewStudReg.Text);
            DrawLine("Student Type:", lblStudentType_RegistrarStudentRegistration_View.Text);
            DrawLine("Requirements:", lblRequirements_RegistrarStudentRegistration_View.Text);
            DrawLine("Mode of Payment:", lblModeOfPayment_RegistrarStudentRegistration_View.Text);

            y += 40;
            e.Graphics.DrawString($"Printed on: {DateTime.Now}", valueFont, Brushes.Gray, leftMargin, y);

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
