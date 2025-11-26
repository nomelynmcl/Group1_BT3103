using System.Drawing.Printing;

namespace EventDriven.Project.UI
{
    public partial class RegistrarStudentInfo_View : Form
    {
        private string fullName, age, birthdate, gender, address,
                       contactNumber, guardianName, guardianContact,
                       gradeLevel, studentType, suffix, schoolYear;


        public RegistrarStudentInfo_View(
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
            string schoolYear)
        {
            InitializeComponent();


            this.fullName = $"{firstName} {middleName} {lastName} {suffix} ".Replace("  ", " ").Trim();
            this.lbRegistrarViewAge.Text = age.ToString();
            this.lbRegistrarViewBirthdate.Text = birthdate.ToString();
            this.lbRegistrarViewGender.Text = gender;
            this.lbRegistrarViewAddress.Text = $"{barangay} {municipality} {province}".Replace("  ", " ").Trim(); ;
            this.lbRegistrarViewContactNo.Text = contactNumber;
            this.lbRegistrarViewGuardian.Text = guardianName;
            this.lbRegistrarViewGuardianContact.Text = guardianContact;
            this.lbRegistrarViewLevel.Text = gradeLevel.ToString();
            this.lbRegistrarViewType.Text = studentType;
            this.lbSyear.Text = schoolYear;


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
            lbSyear.Text = schoolYear;
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

            DrawField("Full Name:", lbRegistrarViewFullname.Text);
            DrawField("Age:", lbRegistrarViewAge.Text);
            DrawField("Birthdate:", lbRegistrarViewBirthdate.Text);
            DrawField("Gender:", lbRegistrarViewGender.Text);

            y += 5;

            // ADDRESS (wrap)
            e.Graphics.DrawString("Address:", labelFont, Brushes.Black, left, y);

            RectangleF rect = new RectangleF(left + 170, y, width - 200, 50);
            e.Graphics.DrawString(lbRegistrarViewAddress.Text, valueFont, Brushes.Black, rect);

            y += 55;

            // **************************************
            //     PARENT / GUARDIAN INFORMATION
            // **************************************
            e.Graphics.DrawString("PARENT / GUARDIAN INFORMATION", sectionFont, Brushes.Black, left, y);
            y += 28;

            DrawField("Guardian Name:", lbRegistrarViewGuardian.Text);
            DrawField("Contact No.:", lbRegistrarViewGuardianContact.Text);

            y += 20;

            // **************************************
            //        ENROLLMENT DETAILS
            // **************************************
            e.Graphics.DrawString("ENROLLMENT DETAILS", sectionFont, Brushes.Black, left, y);
            y += 28;

            DrawField("Grade Level:", lbRegistrarViewLevel.Text);
            DrawField("Student Type:", lbRegistrarViewType.Text);
            DrawField("School Year:", lbSyear.Text);

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

        private void btnRegistrarViewPrint_Click(object sender, EventArgs e)
        {
            printDocument1.PrintPage -= printDocument1_PrintPage;
            printDocument1.PrintPage += printDocument1_PrintPage;

            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("Letter", 850, 1100);
            printDocument1.DefaultPageSettings.Margins = new Margins(50, 50, 50, 50);

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

        private void RegistrarStudentInfo_View_Load(object sender, EventArgs e)
        {

        }
    }
}
