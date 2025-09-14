using EventDriven.Project.Businesslogic.Controller;
using EventDriven.Project.Model;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            userController = new UserController();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        private UserController userController;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                UserModel matchingUser = userController.ValidateUser(txtUsername.Text, txtPassword.Text);

                if (matchingUser != null)
                {
                 
                }
                else throw new Exception("Invalid Credentials");
            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message + " error");
            }
        }
    }
    }

