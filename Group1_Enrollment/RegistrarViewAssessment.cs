using System.Drawing.Printing;

namespace EventDriven.Project.UI
{
    public partial class RegistrarViewAssessment : Form
    {
        private string fullName;
        private string yearSec;

        public RegistrarViewAssessment(
            int id,
                string firstName,
                string middleName,
                string lastName,
                int age,
                DateTime birthdate,
                string gender,
                int gradeLevel,
                string section,
                string studentType,
                string modeOfPayment,
                string enrollmentStatus)
        {
            InitializeComponent();

            this.fullName = $"{lastName} {firstName} {middleName}".Replace("  ", " ").Trim();
            this.yearSec = $"{gradeLevel} {section}".Replace(" ", " ").Trim();
            STU_ID_LBL_RGTR.Text = id.ToString();
            STU_NAME_LBL_RGTR.Text = fullName;
            SECT_TION_LBL_RGTR.Text = yearSec;
            TYPE_LBL_RGTR.Text = studentType;
            STATUS_BOTTOM_LBL_RGTR.Text = enrollmentStatus;
            MODE_LBL_RGTR.Text = modeOfPayment;

            LoadFeeBreakdown(modeOfPayment);
        }

        private void LoadFeeBreakdown(string modeOfPayment)
        {
            dataGridView_RGTR.Columns.Clear();
            dataGridView_RGTR.Columns.Add("Description", "Description");
            dataGridView_RGTR.Columns.Add("Amount", "Amount");
            dataGridView_RGTR.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (modeOfPayment == "Cash")
            {
                dataGridView_RGTR.Rows.Add("Tuition Fee", "2,000");
                dataGridView_RGTR.Rows.Add("Miscellaneous Fee", "1,500");
                dataGridView_RGTR.Rows.Add("Others", "1,700");
                dataGridView_RGTR.Rows.Add("Total", "5,200");
            }
            else if (modeOfPayment == "Low Down Payment")
            {
                dataGridView_RGTR.Rows.Add("Tuition Fee", "2,500");
                dataGridView_RGTR.Rows.Add("Miscellaneous Fee", "1,875");
                dataGridView_RGTR.Rows.Add("Others", "2,125");
                dataGridView_RGTR.Rows.Add("Total", "6,500");
                dataGridView_RGTR.Rows.Add("");
                dataGridView_RGTR.Rows.Add("Down Payment", "500");
                dataGridView_RGTR.Rows.Add("Remaining Balance", "6,000");
                dataGridView_RGTR.Rows.Add("Quarterly Payment (4x)", "1,500");
            }
            else if (modeOfPayment == "Low Quarterly Payment")
            {
                dataGridView_RGTR.Rows.Add("Tuition Fee", "2,700");
                dataGridView_RGTR.Rows.Add("Miscellaneous Fee", "2,025");
                dataGridView_RGTR.Rows.Add("Total", "7,020");
                dataGridView_RGTR.Rows.Add("Down Payment", "500");
                dataGridView_RGTR.Rows.Add("");
                dataGridView_RGTR.Rows.Add("Remaining Balance", "6,520");
                dataGridView_RGTR.Rows.Add("Quarterly Payment (4x)", "1,630");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            RegistrarAssesment registrarAssesment = new RegistrarAssesment();
            registrarAssesment.Show();
            this.Close();
        }

        private void PRIN_BUTTON_Click(object sender, EventArgs e)
        {
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += new PrintPageEventHandler(PrintDoc_PrintPage);

            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = printDoc;
            preview.ShowDialog();
        }

        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font headerFont = new Font("Cambria", 16, FontStyle.Bold);
            Font smallHeader = new Font("Cambria", 15, FontStyle.Bold);
            Font labelFont = new Font("Cambria", 12, FontStyle.Bold);
            Font gridFont = new Font("Cambria", 12, FontStyle.Bold);

            int leftMargin = 50;
            int topMargin = 50;
            int y = topMargin;

            int pageWidth = e.PageBounds.Width;
            int rightMargin = e.MarginBounds.Right;

            void DrawCenteredString(string text, Font font, int yPos)
            {
                float textWidth = e.Graphics.MeasureString(text, font).Width;
                float x = (pageWidth - textWidth) / 2;  
                e.Graphics.DrawString(text, font, Brushes.Black, x, yPos);
            }

            if (pictureBox1.Image != null)
            {
                g.DrawImage(pictureBox1.Image, leftMargin + 150, y, 100, 100);
                y += 40;
            }

            DrawCenteredString("ORION TECH-HIGH SCHOOL", headerFont, y);
            y += 25;
            DrawCenteredString("ASSESSMENT FORM", headerFont, y);
            y += 50;

            g.DrawString($"Student ID: {STU_ID_LBL_RGTR.Text}", labelFont, Brushes.Black, leftMargin, y);
            y += 25;
            g.DrawString($"Yr/Section: {SECT_TION_LBL_RGTR.Text}", labelFont, Brushes.Black, leftMargin, y);
            y += 25;
            g.DrawString($"Student Name: {STU_NAME_LBL_RGTR.Text}", labelFont, Brushes.Black, leftMargin, y);
            y += 25;
            g.DrawString($"Student Type: {TYPE_LBL_RGTR.Text}", labelFont, Brushes.Black, leftMargin, y);
            y += 40;
            g.DrawString("Fees Breakdown", smallHeader, Brushes.Black, leftMargin, y);
            y += 30;

            int tableStartY = y;
            int rowHeight = 25;
            int col1Width = 200;
            int col2Width = 100;

            g.DrawRectangle(Pens.Black, leftMargin, y, col1Width, rowHeight);
            g.DrawRectangle(Pens.Black, leftMargin + col1Width, y, col2Width, rowHeight);
            g.DrawString("Description", labelFont, Brushes.Black, leftMargin + 5, y + 5);
            g.DrawString("Amount", labelFont, Brushes.Black, leftMargin + col1Width + 5, y + 5);

            y += rowHeight;

            foreach (DataGridViewRow row in dataGridView_RGTR.Rows)
            {
                if (!row.IsNewRow)
                {
                    g.DrawRectangle(Pens.Black, leftMargin, y, col1Width, rowHeight);
                    g.DrawRectangle(Pens.Black, leftMargin + col1Width, y, col2Width, rowHeight);
                    g.DrawString(row.Cells[0].Value?.ToString(), gridFont, Brushes.Black, leftMargin + 5, y + 5);
                    g.DrawString(row.Cells[1].Value?.ToString(), gridFont, Brushes.Black, leftMargin + col1Width + 5, y + 5);
                    y += rowHeight;
                }
            }

            y += 20;
            g.DrawString($"Mode of Payment: {MODE_LBL_RGTR.Text}", labelFont, Brushes.Black, leftMargin, y);
            y += 25;
            g.DrawString($"Status: {STATUS_BOTTOM_LBL_RGTR.Text}", labelFont, Brushes.Black, leftMargin, y);
            y += 40;


            g.DrawString($"Printed on: {DateTime.Now}", labelFont, Brushes.Gray, leftMargin, y);
        }
    }
}
