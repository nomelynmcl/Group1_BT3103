using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
    public partial class RegistrarStudentInfo_View : Form
    {
        private string fullName, age, birthdate, gender, address,
                       contactNumber, guardianName, guardianContact,
                       gradeLevel, studentType;

        public RegistrarStudentInfo_View(
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
            string studentType)
        {
            InitializeComponent();

            this.fullName = $"{firstName} {middleName} {lastName}".Replace("  ", " ").Trim();
            this.lbRegistrarViewAge.Text = age.ToString();
            this.lbRegistrarViewBirthdate.Text = birthdate.ToString();
            this.lbRegistrarViewGender.Text = gender;
            this.lbRegistrarViewAddress.Text = $"{barangay} {municipality} {province}".Replace("  ", " ").Trim(); ;
            this.lbRegistrarViewContactNo.Text = contactNumber;
            this.lbRegistrarViewGuardian.Text = guardianName;
            this.lbRegistrarViewGuardianContact.Text = guardianContact;
            this.lbRegistrarViewLevel.Text = gradeLevel.ToString();
            this.lbRegistrarViewType.Text = studentType;


            lbRegistrarViewFullname.Text = fullName;
            lbRegistrarViewAge.Text = age.ToString();
            lbRegistrarViewBirthdate.Text = birthdate.ToString();
            lbRegistrarViewGender.Text = gender;
            lbRegistrarViewAddress.Text = $"{barangay} {municipality} {province}".Replace("  ", " ").Trim(); ;
            lbRegistrarViewContactNo.Text = contactNumber;
            lbRegistrarViewGuardian.Text = guardianName;
            lbRegistrarViewGuardianContact.Text = guardianContact;
            lbRegistrarViewLevel.Text = gradeLevel.ToString();
            lbRegistrarViewType.Text = studentType;
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

        private void btnRegistrarViewPrint_Click(object sender, EventArgs e)
        {
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

            // Show print dialog
            printDialog1.Document = printDocument1;

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
    }
}
