using System.Drawing.Printing;

namespace EventDriven.Project.UI
{
    public partial class AdminStudentInformation_View : Form
    {
        private string fullName, age, birthdate, gender, address,
               contactNumber, guardianName, guardianContact,
               gradeLevel, studentType, schoolYear;
        public AdminStudentInformation_View(string firstName, string middleName, string lastName,
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
        string schoolYear)

        {
            InitializeComponent();

            this.fullName = $"{firstName} {middleName} {lastName} {suffix}".Replace("  ", " ").Trim();
            this.age = age.ToString();
            this.birthdate = birthdate.ToShortDateString();
            this.gender = gender;
            this.address = $"{barangay} {municipality} {province}".Replace("  ", " ").Trim();
            this.contactNumber = contactNumber;
            this.guardianName = guardianName;
            this.guardianContact = guardianContact;
            this.gradeLevel = gradeLevel.ToString();
            this.studentType = studentType;
            this.schoolYear = schoolYear;

            lbAdminViewFullname.Text = this.fullName;
            lbAdminViewAge.Text = this.age;
            lbAdminViewBirthdate.Text = this.birthdate;
            lbAdminViewGender.Text = this.gender;
            lbAdminViewAddress.Text = this.address;
            lbAdminViewContactNo.Text = this.contactNumber;
            lbAdminViewGuardian.Text = this.guardianName;
            lbAdminViewGuardianContact.Text = this.guardianContact;
            lbAdminViewLevel.Text = this.gradeLevel;
            lbAdminViewType.Text = this.studentType;
            lbSchoolYear.Text = this.schoolYear;
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
            int left = 60;
            int right = e.PageBounds.Width - 60;
            int width = right - left;

            Font titleFont = new Font("Arial", 24, FontStyle.Bold);
            Font schoolFont = new Font("Arial", 14, FontStyle.Bold);
            Font sectionFont = new Font("Arial", 13, FontStyle.Bold);
            Font labelFont = new Font("Arial", 11, FontStyle.Bold);
            Font valueFont = new Font("Arial", 11);
            Font footerFont = new Font("Arial", 9, FontStyle.Italic);

            Pen thickPen = new Pen(Color.Black, 2);
            Pen thinPen = new Pen(Color.Black, 1);

            float y = 80;

            // ---- SCHOOL LOGO ----
            try
            {
                Image logo = Image.FromFile("C:\\Enrollment\\Orion_Logo.png");
                e.Graphics.DrawImage(logo, left, 40, 90, 90);
            }
            catch { }

            // ---- SCHOOL HEADER ----
            StringFormat center = new StringFormat();
            center.Alignment = StringAlignment.Center;

            e.Graphics.DrawString("ORION TECH-HIGH SCHOOL", titleFont, Brushes.Black,
                e.PageBounds.Width / 2, 40, center);

            e.Graphics.DrawString("Official Enrollment Record", schoolFont, Brushes.Black,
                e.PageBounds.Width / 2, 85, center);

            y = 150;

            // ---- OUTER BORDER ----
            e.Graphics.DrawRectangle(thickPen, left - 20, y, width + 40, 620);

            y += 30;

            // **************************************
            //        STUDENT INFORMATION
            // **************************************
            e.Graphics.DrawString("STUDENT INFORMATION", sectionFont, Brushes.Black, left, y);
            y += 28;

            void DrawField(string label, string value)
            {
                e.Graphics.DrawString(label, labelFont, Brushes.Black, left, y);
                e.Graphics.DrawString(value, valueFont, Brushes.Black, left + 170, y);
                y += 25;
            }

            DrawField("Full Name:", lbAdminViewFullname.Text);
            DrawField("Age:", lbAdminViewAge.Text);
            DrawField("Birthdate:", lbAdminViewBirthdate.Text);
            DrawField("Gender:", lbAdminViewGender.Text);

            y += 5;

            // ADDRESS (wrap)
            e.Graphics.DrawString("Address:", labelFont, Brushes.Black, left, y);

            RectangleF rect = new RectangleF(left + 170, y, width - 200, 50);
            e.Graphics.DrawString(lbAdminViewAddress.Text, valueFont, Brushes.Black, rect);

            y += 55;

            // **************************************
            //     PARENT / GUARDIAN INFORMATION
            // **************************************
            e.Graphics.DrawString("PARENT / GUARDIAN INFORMATION", sectionFont, Brushes.Black, left, y);
            y += 28;

            DrawField("Guardian Name:", lbAdminViewGuardian.Text);
            DrawField("Contact No.:", lbAdminViewGuardianContact.Text);

            y += 20;

            // **************************************
            //        ENROLLMENT DETAILS
            // **************************************
            e.Graphics.DrawString("ENROLLMENT DETAILS", sectionFont, Brushes.Black, left, y);
            y += 28;

            DrawField("Grade Level:", lbAdminViewLevel.Text);
            DrawField("Student Type:", lbAdminViewType.Text);
            DrawField("School Year:", lbSchoolYear.Text);

            y += 40;

            // ---------------------------------------------------
            // SIGNATURE BLOCKS
            // ---------------------------------------------------

            e.Graphics.DrawLine(thinPen, left, y, left + 200, y);
            e.Graphics.DrawString("Student Signature", valueFont, Brushes.Black, left, y + 5);

            e.Graphics.DrawLine(thinPen, right - 200, y, right, y);
            e.Graphics.DrawString("Parent/Guardian Signature", valueFont, Brushes.Black, right - 200, y + 5);

            y += 60;

            e.Graphics.DrawLine(thinPen, left, y, left + 200, y);
            e.Graphics.DrawString("Registrar", valueFont, Brushes.Black, left, y + 5);

            e.Graphics.DrawLine(thinPen, right - 200, y, right, y);
            e.Graphics.DrawString("School Principal", valueFont, Brushes.Black, right - 200, y + 5);

            y += 60;

            // FOOTER
            e.Graphics.DrawLine(thinPen, left, y, right, y);
            y += 10;

            e.Graphics.DrawString(
                $"Printed on: {DateTime.Now:MMMM dd, yyyy   hh:mm tt}",
                footerFont,
                Brushes.Gray,
                left,
                y
            );
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


