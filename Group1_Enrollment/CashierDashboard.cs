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
    public partial class CashierDashboard : Form
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EnrollmentDB;Integrated Security=True";
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

        private void btnAdminPay2_Click(object sender, EventArgs e)
        {
            CashierPayment cashierPayment = new CashierPayment();
            cashierPayment.Show();
            this.Close();
        }

        private void btnAdminHistory2_Click(object sender, EventArgs e)
        {
            Cashier_PaymentHistory cashier_PaymentHistory = new Cashier_PaymentHistory();
            cashier_PaymentHistory.Show();
            this.Close();
        }

        private void btnAdminReport2_Click(object sender, EventArgs e)
        {
            CashierReport cashierReport1 = new CashierReport();
            cashierReport1.Show();
            this.Close();
        }

        private void btnAdminOut2_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
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

                dtgCashier.DataSource = dt;


                dtgCashier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSyear.SelectedItem != null)
            {
                string selectedYear = cbSyear.SelectedItem.ToString();
                LoadEnrolledStudents(selectedYear);
            }
        }

        private void CashierDashboard_Load(object sender, EventArgs e)
        {
            if (cbSyear.Items.Count > 0)
            {
                cbSyear.SelectedIndex = 0;
            }
        }
    }
}
