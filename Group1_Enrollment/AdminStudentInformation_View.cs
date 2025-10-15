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
            this.lbAdminViewAddress.Text = address;
            this.lbAdminViewContactNo.Text = contactNumber;
            this.lbAdminViewGuardian.Text = guardianName;
            this.lbAdminViewGuardianContact.Text = guardianContact;
            this.lbAdminViewLevel.Text = gradeLevel.ToString();
            this.lbAdminViewType.Text = studentType;


            lbAdminViewFullname.Text = fullName;
            lbAdminViewAge.Text = age.ToString();
            lbAdminViewBirthdate.Text = birthdate.ToString();
            lbAdminViewGender.Text = gender;
            lbAdminViewAddress.Text = address;
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
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

            // Show print dialog
            printDialog1.Document = printDocument1;

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Set font styles
            Font titleFont = new Font("Arial", 16, FontStyle.Bold);
            Font labelFont = new Font("Arial", 12, FontStyle.Regular);

            float y = 100; // starting Y position
            float leftMargin = 80;

            e.Graphics.DrawString("Orion Tech-High School", titleFont, Brushes.Black, leftMargin, y - 50);

            e.Graphics.DrawString("Full Name: " + fullName, labelFont, Brushes.Black, leftMargin, y += 40);
            e.Graphics.DrawString("Age: " + age, labelFont, Brushes.Black, leftMargin, y += 25);
            e.Graphics.DrawString("Birthdate: " + birthdate, labelFont, Brushes.Black, leftMargin, y += 25);
            e.Graphics.DrawString("Gender: " + gender, labelFont, Brushes.Black, leftMargin, y += 25);
            e.Graphics.DrawString("Address: " + address, labelFont, Brushes.Black, leftMargin, y += 25);
            e.Graphics.DrawString("Contact Number: " + contactNumber, labelFont, Brushes.Black, leftMargin, y += 25);
            e.Graphics.DrawString("Guardian's Name: " + guardianName, labelFont, Brushes.Black, leftMargin, y += 25);
            e.Graphics.DrawString("Guardian Contact: " + guardianContact, labelFont, Brushes.Black, leftMargin, y += 25);
            e.Graphics.DrawString("Year Level: " + gradeLevel, labelFont, Brushes.Black, leftMargin, y += 25);
            e.Graphics.DrawString("Student Type: " + studentType, labelFont, Brushes.Black, leftMargin, y += 25);
        }
    }
}


