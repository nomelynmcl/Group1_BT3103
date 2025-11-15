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
    public partial class CashierDashboard : Form
    {
        public CashierDashboard()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblCashierPayment_Click(object sender, EventArgs e)
        {
            CashierPayment payment = new CashierPayment();
            payment.Show();
            this.Close();
        }

        private void lblCashierPayHistory_Click(object sender, EventArgs e)
        {
            Cashier_PaymentHistory history = new Cashier_PaymentHistory();
            history.Show();
            this.Close();
        }

        private void btnCashierSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnLogoutCashier_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void lblCashierReport_Click(object sender, EventArgs e)
        {
            CashierReport report = new CashierReport();
            report.Show();
            this.Close();
        }

        private void btnCashierOverview_Click(object sender, EventArgs e)
        {
            CashierReport cashierReport = new CashierReport();
            cashierReport.Show();
            this.Close();
        }
    }
}
