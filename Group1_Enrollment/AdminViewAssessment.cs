using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EventDriven.Project.UI
{
    public partial class AdminViewAssessment : Form
    {
        public AdminViewAssessment(
                int id,
                string firstName,
                string middleName,
                string lastName,
                int age,
                DateTime birthdate,
                string gender,
                int gradeLevel,
                string section,
                string studentType)
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
