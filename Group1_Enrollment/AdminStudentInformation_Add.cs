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
    public partial class AdminStudentInformation_Add : Form
    {
        public AdminStudentInformation_Add()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void btnAdminBack_Click(object sender, EventArgs e)
        {
            AdminStudentInformation adminStudInfo = new AdminStudentInformation();
            adminStudInfo.Show();
        }

        private void btnAdminAddView_Click(object sender, EventArgs e)
        {
            AdminStudentInformation_View adminStudInfo_View = new AdminStudentInformation_View();
            adminStudInfo_View.Show();
        }

        private void btnAdminOut3_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(); 
            loginForm.Show();
        }
    }
}
