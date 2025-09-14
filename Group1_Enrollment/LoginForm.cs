using EventDriven.Project.Businesslogic.Controller;
using EventDriven.Project.Model;
using Group1_Enrollment;
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
    public partial class LoginForm : Form
    {
        private UserController userController;
        private int loginAttempts = 3;
        private string connectionString = @"Data Source=DESKTOP-1B1BE1O\SQLEXPRESS;Initial Catalog=EnrollmentDB;Integrated Security=True";
        public LoginForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            userController = new UserController();
        }
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            // walang laman
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string selectedRole = UserRolesForm.SelectedRole;
            try
            {
                UserModel matchingUser = userController.ValidateUser(txtUsername.Text, txtPassword.Text);
                if (matchingUser != null)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close(); ;
                }
                else throw new Exception("Invalid Credentials");

                matchingUser = new UserModel();
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "SELECT COUNT(*) FROM Users WHERE username=@username AND user_password=@password AND role=@role";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@User_password", txtPassword.Text);
                        cmd.Parameters.AddWithValue("@Role", selectedRole);

                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Open dashboard based on role
                            if (selectedRole == "Admin")
                            {
                                AdminDashboard adminForm = new AdminDashboard();
                                adminForm.Show();
                            }
                            else if (selectedRole == "Cashier")
                            {
                                CashierDashboard cashierForm = new CashierDashboard();
                                cashierForm.Show();
                            }
                            else if (selectedRole == "Registrar")
                            {
                                RegistarDashboard registrarForm = new RegistarDashboard();
                                registrarForm.Show();
                            }

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid credentials or role mismatch!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}