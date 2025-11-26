using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventDriven.Project.UI
{
    public partial class RegistrarDashboard : Form
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EnrollmentDB;Integrated Security=True";
        public RegistrarDashboard()
        {
            InitializeComponent();
        }

        private void lblRegistrarStudentRegistration_Click(object sender, EventArgs e)
        {
            RegistrarStudentRegistration regStudReg = new RegistrarStudentRegistration();
            regStudReg.Show();
            this.Hide();
        }

        private void btnLogoutRegistrar_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void lblRegistrarStudentInfo_Click(object sender, EventArgs e)
        {
            Registrar___Student_Information regStudInfo = new Registrar___Student_Information();
            regStudInfo.Show();
            this.Hide();
        }

        private void lblRegistrarAssessment_Click(object sender, EventArgs e)
        {
            RegistrarAssesment assesment = new RegistrarAssesment();
            assesment.Show();
            this.Hide();
        }

        private void lblRegistrarReport_Click(object sender, EventArgs e)
        {
            RegistrarReport report = new RegistrarReport();
            report.Show();
            this.Hide();
        }

        private void btnRegistrarOverview_Click(object sender, EventArgs e)
        {
            RegistrarReport registrarReport = new RegistrarReport();
            registrarReport.Show();
            this.Hide();
        }

        private void btnAdminStudentInformation3_Click(object sender, EventArgs e)
        {
            Registrar___Student_Information registrar___Student_Information = new Registrar___Student_Information();
            registrar___Student_Information.Show();
            this.Close();
        }

        private void btnAdminStudreg3_Click(object sender, EventArgs e)
        {
            RegistrarStudentRegistration registration = new RegistrarStudentRegistration();
            registration.Show();
            this.Close();
        }

        private void btnAdminAssessment3_Click(object sender, EventArgs e)
        {
            RegistrarAssesment registrarAssesment = new RegistrarAssesment();
            registrarAssesment.Show();
            this.Close();
        }

        private void btnAdminReport3_Click(object sender, EventArgs e)
        {
            RegistrarReport registration = new RegistrarReport();
            registration.Show();
            this.Close();
        }
        private void LoadEnrolledStudents(string schoolYear)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT s.Id, s.FirstName, s.MiddleName, s.LastName, 
                                s.GradeLevel, s.Section, s.StudentType, s.SchoolYear
                         FROM StudentRecord s
                         INNER JOIN PaymentRecord p ON s.Id = p.Id
                         WHERE p.AmountPaid >= 500 AND s.SchoolYear = @SchoolYear
                         ORDER BY s.LastName ASC";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SchoolYear", schoolYear);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dtgRegistrar.DataSource = dt;


                dtgRegistrar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void cbSyear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSyear.SelectedItem != null)
            {
                string selectedYear = cbSyear.SelectedItem.ToString();
                LoadEnrolledStudents(selectedYear);
            }
        }

        private void RegistrarDashboard_Load(object sender, EventArgs e)
        {
            if (cbSyear.Items.Count > 0)
            {
                cbSyear.SelectedIndex = 0;
            }
        }
    }
}
