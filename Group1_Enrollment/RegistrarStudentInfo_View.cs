using System.Drawing.Printing;

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
            Font titleFont = new Font("Arial", 22, FontStyle.Bold);
            Font headerFont = new Font("Arial", 14, FontStyle.Underline);
            Font labelBoldFont = new Font("Arial", 12, FontStyle.Bold);
            Font valueFont = new Font("Arial", 12, FontStyle.Regular);

            float y = 100;
            float leftMargin = 80;

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

            // Student Information

            DrawLine("Full Name:", lbRegistrarViewFullname.Text);
            DrawLine("Age:", lbRegistrarViewAge.Text);
            DrawLine("Birthdate:", lbRegistrarViewBirthdate.Text);
            DrawLine("Gender:", lbRegistrarViewGender.Text);
            DrawLine("Address:", lbRegistrarViewAddress.Text);
            DrawLine("Contact No.:", lbRegistrarViewContactNo.Text);
            DrawLine("Guardian:", lbRegistrarViewGuardian.Text);
            DrawLine("Contact No.:", lbRegistrarViewGuardianContact.Text);
            DrawLine("Year Level:", lbRegistrarViewFullname.Text);
            DrawLine("Student Type:", lbRegistrarViewType.Text);

            y += 40;
            e.Graphics.DrawString($"Printed on: {DateTime.Now}", valueFont, Brushes.Gray, leftMargin, y);
        }

        private void btnRegistrarViewPrint_Click(object sender, EventArgs e)
        {
            printDocument1.PrintPage -= printDocument1_PrintPage;
            printDocument1.PrintPage += printDocument1_PrintPage;

            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("Letter", 850, 1100);
            printDocument1.DefaultPageSettings.Margins = new Margins(50, 50, 50, 50);

            // Show the Print Preview Dialog instead of the Print Dialog
            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            previewDialog.Document = printDocument1;
            previewDialog.WindowState = FormWindowState.Maximized;
            previewDialog.ShowDialog();
        }

        private void btnRegistrarViewCancel_Click(object sender, EventArgs e)
        {
            Registrar___Student_Information regStudInfo = new Registrar___Student_Information();
            regStudInfo.Show();
            this.Close();
            
        }
    }
}
