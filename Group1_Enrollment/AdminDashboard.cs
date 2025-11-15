using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventDriven.Project.UI
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void lblAdmin_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void lblStudentInformation_Click(object sender, EventArgs e)
        {
            AdminStudentInformation adminStudInfo = new AdminStudentInformation();
            adminStudInfo.Show();
            this.Hide();
        }

        private void btnLogoutAdmin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void lblStudentRegistration_Click(object sender, EventArgs e)
        {
            AdminStudentRegistration adminStudReg = new AdminStudentRegistration();
            adminStudReg.Show();
            this.Hide();
        }

        private void lblPayment_Click(object sender, EventArgs e)
        {
            AdminPayment adminPayment = new AdminPayment();
            adminPayment.Show();
            this.Close();
        }

        private void lblAssessment_Click(object sender, EventArgs e)
        {
            AdminAssesment assessment = new AdminAssesment();
            assessment.Show();
            this.Hide();
        }

        private void lblPaymentHistory_Click(object sender, EventArgs e)
        {
            AdminPaymentHistory adminPaymentHistory = new AdminPaymentHistory();
            adminPaymentHistory.Show();
            this.Close();
        }

        private void lblReport_Click(object sender, EventArgs e)
        {
            AdminReport report = new AdminReport();
            report.Show();
            this.Close();
        }

        private void btnAdminOverview_Click(object sender, EventArgs e)
        {
            AdminReport adminReport = new AdminReport();    
            adminReport.Show();
            this.Close();
        }
    }
}
