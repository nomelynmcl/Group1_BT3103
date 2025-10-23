using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EventDriven.Project.UI
{
    public partial class AdminStudentInformation_View : Form
    {
        private string fullName, age, birthdate, gender, address,
                       contactNumber, guardianName, guardianContact,
                       gradeLevel, studentType;
        public AdminStudentInformation_View(string firstName, string middleName, string lastName,
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
        string studentType)

        {
            InitializeComponent();

            this.fullName = $"{firstName} {middleName} {lastName}".Replace("  ", " ").Trim();
            this.lbAdminViewAge.Text = age.ToString();
            this.lbAdminViewBirthdate.Text = birthdate.ToString();
            this.lbAdminViewGender.Text = gender;
            this.lbAdminViewAddress.Text = $"{barangay} {municipality} {province}".Replace("  ", " ").Trim(); ;
            this.lbAdminViewContactNo.Text = contactNumber;
            this.lbAdminViewGuardian.Text = guardianName;
            this.lbAdminViewGuardianContact.Text = guardianContact;
            this.lbAdminViewLevel.Text = gradeLevel.ToString();
            this.lbAdminViewType.Text = studentType;


            lbAdminViewFullname.Text = fullName;
            lbAdminViewAge.Text = age.ToString();
            lbAdminViewBirthdate.Text = birthdate.ToString();
            lbAdminViewGender.Text = gender;
            lbAdminViewAddress.Text = $"{barangay} {municipality} {province}".Replace("  ", " ").Trim(); ;
            lbAdminViewContactNo.Text = contactNumber;
            lbAdminViewGuardian.Text = guardianName;
            lbAdminViewGuardianContact.Text = guardianContact;
            lbAdminViewLevel.Text = gradeLevel.ToString();
            lbAdminViewType.Text = studentType;
        }

        private void AdminStudentInformation_View_Load(object sender, EventArgs e)
        {

        }

        private void lbAdminViewFullname_Click(object sender, EventArgs e)
        {

        }

        private void btnAdminViewPrint_Click(object sender, EventArgs e)
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
            Font titleFont = new Font("Arial", 22, FontStyle.Bold);
            Font headerFont = new Font("Arial", 14, FontStyle.Underline);
            Font labelBoldFont = new Font("Arial", 12, FontStyle.Bold);
            Font valueFont = new Font("Arial", 12, FontStyle.Regular);

            float y = 100;
            float leftMargin = 80;

            // 🏫 Optional: Draw your logo at the top-left
            try
            {
                Image logo = Image.FromFile("C:\\Enrollment\\Orion_Logo.png"); // <- change path
                e.Graphics.DrawImage(logo, leftMargin, y - 100, 150, 150);
            }
            catch
            {
                // Ignore if logo not found
            }

            // Title and header
            e.Graphics.DrawString("Orion Tech-High School", titleFont, Brushes.Black, leftMargin + 150, y - 40);
            e.Graphics.DrawString("Student Information", headerFont, Brushes.Black, leftMargin, y += 40);
            y += 30;


            // Function to draw label + value
            void DrawLine(string label, string value)
            {
                e.Graphics.DrawString(label, labelBoldFont, Brushes.Black, leftMargin, y);
                e.Graphics.DrawString(value, valueFont, Brushes.Black, leftMargin + 150, y);
                y += 25;
            }

            // 🧾 Student Information
            
            DrawLine("Full Name:", lbAdminViewFullname.Text);
            DrawLine("Age:", lbAdminViewAge.Text);
            DrawLine("Birthdate:", lbAdminViewBirthdate.Text);
            DrawLine("Gender:", lbAdminViewGender.Text);
            DrawLine("Address:", lbAdminViewAddress.Text);
            DrawLine("Contact No.:", lbAdminViewContactNo.Text);
            DrawLine("Guardian:", lbAdminViewGuardian.Text);
            DrawLine("Contact No.:", lbAdminViewGuardianContact.Text);
            DrawLine("Year Level:", lbAdminViewLevel.Text);
            DrawLine("Student Type:", lbAdminViewType.Text);

            y += 40;
            e.Graphics.DrawString($"Printed on: {DateTime.Now}", valueFont, Brushes.Gray, leftMargin, y);
        }

        private void lbAdminViewAddress_Click(object sender, EventArgs e)
        {

        }

        private void btnAdminViewCancel_Click(object sender, EventArgs e)
        {
            AdminStudentInformation adminStudentInformation = new AdminStudentInformation();
            adminStudentInformation.Show();
            this.Close();
        }
    }
}


