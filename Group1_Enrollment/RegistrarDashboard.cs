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
    public partial class RegistrarDashboard : Form
    {
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
    }
}
