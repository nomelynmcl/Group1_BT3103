using System.Data.SqlClient;
using EventDriven.Project.Businesslogic.Controller;
using EventDriven.Project.Model;
using Group1_Enrollment;

namespace EventDriven.Project.UI
{
    public partial class LoginForm : Form
    {
        private UserController userController;
        private int loginAttempts = 3;
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EnrollmentDB;Integrated Security=True";
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string selectedRole = UserRolesForm.SelectedRole;

            try
            {
                // Validate user credentials using the controller
                UserModel matchingUser = userController.ValidateUser(txtUsername.Text.Trim(), txtPassword.Text.Trim());

                if (matchingUser != null)
                {
                    if (matchingUser.Roles == selectedRole)
                    {
                        MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();

                        // Open dashboard based on role
                        if (selectedRole == "Admin")
                        {
                            AdminDashboard adminDashboard = new AdminDashboard();
                            adminDashboard.Show();


                        }
                        else if (selectedRole == "Cashier")
                        {
                            CashierDashboard cashierDashboard = new CashierDashboard();
                            cashierDashboard.Show();

                        }
                        else if (selectedRole == "Registrar")
                        {
                            RegistrarDashboard registrarDashboard = new RegistrarDashboard();
                            registrarDashboard.Show();

                        }

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Role mismatch! Please select the correct role.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    // Decrease attempts
                    loginAttempts--;

                    if (loginAttempts > 0)
                    {
                        MessageBox.Show($"Invalid credentials! Attempts remaining: {loginAttempts}",
                                        "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Too many failed attempts. The application will now close.",
                                        "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        this.Close(); // Close the login form completely
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            UserRolesForm userRoles = new UserRolesForm();
            userRoles.Show();
            this.Close();
        }
    }
}