using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace EventDriven.Project.UI
{
    public partial class AdminStudentInformation_Edit : Form
    {
        public AdminStudentInformation_Edit(
            string firstname,
            string lastname,
            string middlename,
            string contactNumber,
            string gender,
            string address,
            int gradeLevel)
        {
            InitializeComponent();
        }

        private void btnAdminStudInfoSave_Click(object sender, EventArgs e)
        {

        }

        private void btnAdminEditBack_Click(object sender, EventArgs e)
        {
            AdminStudentInformation adminStudInfo = new AdminStudentInformation();
            adminStudInfo.Show();
        }

        private void btnAdminOut4_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(); 
            loginForm.Show(); 
        }
    }
}
