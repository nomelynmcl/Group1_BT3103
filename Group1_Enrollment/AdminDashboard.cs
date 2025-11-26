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


        private void btnAdminStudentInformation3_Click(object sender, EventArgs e)
        {
            AdminStudentInformation adminStudentInformation = new AdminStudentInformation();
            adminStudentInformation.Show();
            this.Close();
        }

        private void btnAdminStudreg3_Click(object sender, EventArgs e)
        {
            AdminStudentRegistration adminStudentRegistration = new AdminStudentRegistration();
            adminStudentRegistration.Show();
            this.Close();
        }

        private void btnAdminPay3_Click(object sender, EventArgs e)
        {
            AdminPayment payment = new AdminPayment();
            payment.Show();
            this.Close();
        }

        private void btnAdminAssessment3_Click(object sender, EventArgs e)
        {
            AdminAssesment assesment = new AdminAssesment();
            assesment.Show();
            this.Close();
        }

        private void btnAdminHistory3_Click(object sender, EventArgs e)
        {
            AdminPaymentHistory paymentHistory = new AdminPaymentHistory();
            paymentHistory.Show();
            this.Close();
        }

        private void btnAdminReport3_Click(object sender, EventArgs e)
        {
            AdminReport report = new AdminReport();
            report.Show();
            this.Close();
        }

        private void btnAdminOut3_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}
