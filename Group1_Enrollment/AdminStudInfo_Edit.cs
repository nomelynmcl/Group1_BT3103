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

namespace EventDriven.Project.UI
{
    public partial class AdminStudInfo_Edit : Form
    {
        public AdminStudInfo_Edit(
            string firstname,
            string lastname,
            string middlename,
            string contactNumber,
            string gender,
            DateTime birthdate,
            string barangay,
            string municipality,
            string province,
            int gradeLevel
            )
        {
            InitializeComponent();
        }

        private void pcAdminLogo4_Click(object sender, EventArgs e)
        {
            AdminDashboard adDashboard = new AdminDashboard();
            adDashboard.Show();
        }

        private void btnAdminBack_Edit_Click(object sender, EventArgs e)
        {
            AdminStudentInformation adminStudInfo = new AdminStudentInformation();
            adminStudInfo.Show();
        }

        private void btnAdminStudInfoSave_Edit_Click(object sender, EventArgs e)
        {

        }
    }
}
