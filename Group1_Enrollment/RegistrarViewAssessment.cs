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
    public partial class RegistrarViewAssessment : Form
    {
        public RegistrarViewAssessment(
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
    }
}
