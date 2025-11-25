using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventDriven.Project.UI
{
    public partial class AdminStudentRegistration_View : Form
    {
        private string id, fullName, age, birthdate, gender, address,
                       contactNumber, guardianName, guardianContact,
                       gradeLevel, studentType, requirements, modeOfPayment, section;

        public AdminStudentRegistration_View(
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

            lblStudentIDAdminStudentRegistration_View.Text = id.ToString();
            lblFullName_AdminStudentRegistration_View.Text = fullName;
            lblAge_AdminStudentRegistration_View.Text = age.ToString();
            lblBirthDate_AdminStudentRegistration_View.Text = birthdate.ToString();
            lblGender_AdminStudentRegistration_View.Text = gender;
            lblAddress_AdminStudentRegistration_View.Text = $"{barangay} {municipality} {province}".Replace("  ", " ").Trim(); ;
            lblContactNumber_AdminStudentRegistration_View.Text = contactNumber;
            lblGuardiansName_AdminStudentRegistration_View.Text = guardianName;
            lblGuardiansContactNum_AdminStudentRegistration_View.Text = guardianContact;
            lblYearLevel_AdminStudentRegistration_View.Text = gradeLevel.ToString();
            lblStudentType_AdminStudentRegistration_View.Text = studentType;
            lblRequirements_AdminStudentRegistration_View.Text = requirements;
            lblModeOfPayment_AdminStudentRegistration_View.Text = modeOfPayment;
            lbAdminViewSection_StudReg.Text = section;
        }

        private void btnViewPrint_AdminStudentRegistration_Click(object sender, EventArgs e)
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

            // 🏫 Optional: Draw your logo at the top-left
            try
            {
                Image logo = Image.FromFile("C:\\Enrollment\\Orion_Logo.png"); // <- update path
                float logox = 100;
                e.Graphics.DrawImage(logo, leftMargin, y - 50, 250, 150);


            }
            catch
            {
                // ignore if logo not found
            }

            // --- Centered Header ---
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


            // Function to draw label + value
            void DrawLine(string label, string value)
            {
                e.Graphics.DrawString(label, labelBoldFont, Brushes.Black, leftMargin, y);
                e.Graphics.DrawString(value, valueFont, Brushes.Black, leftMargin + 180, y);
                y += 25;
            }

            // --- Student Information ---
            DrawLine("Student ID:", lblStudentIDAdminStudentRegistration_View.Text);
            DrawLine("Full Name:", lblFullName_AdminStudentRegistration_View.Text);
            DrawLine("Age:", lblAge_AdminStudentRegistration_View.Text);
            DrawLine("Birthdate:", lblBirthDate_AdminStudentRegistration_View.Text);
            DrawLine("Gender:", lblGender_AdminStudentRegistration_View.Text);
            DrawLine("Address:", lblAddress_AdminStudentRegistration_View.Text);
            DrawLine("Contact No.:", lblContactNumber_AdminStudentRegistration_View.Text);
            DrawLine("Guardian:", lblGuardiansName_AdminStudentRegistration_View.Text);
            DrawLine("Guardian Contact:", lblGuardiansContactNum_AdminStudentRegistration_View.Text);
            DrawLine("Year Level:", lblYearLevel_AdminStudentRegistration_View.Text);
            DrawLine("Section:", lbAdminViewSection_StudReg.Text);
            DrawLine("Student Type:", lblStudentType_AdminStudentRegistration_View.Text);
            DrawLine("Requirements:", lblRequirements_AdminStudentRegistration_View.Text);
            DrawLine("Mode of Payment:", lblModeOfPayment_AdminStudentRegistration_View.Text);

            y += 40;
            e.Graphics.DrawString($"Printed on: {DateTime.Now}", valueFont, Brushes.Gray, leftMargin, y);

        }

        private void btnViewCancel_AdminStudentRegistration_Click(object sender, EventArgs e)
        {
            AdminStudentRegistration adminStudReg = new AdminStudentRegistration();
            adminStudReg.Show();
            this.Close();
        }

        private void lblStudentType_AdminStudentRegistration_View_Click(object sender, EventArgs e)
        {

        }
    }
}
