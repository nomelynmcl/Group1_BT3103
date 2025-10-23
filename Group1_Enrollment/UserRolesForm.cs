using EventDriven.Project.UI;

namespace Group1_Enrollment
{
    public partial class UserRolesForm : Form
    {
        public UserRolesForm()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserRolesForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            SelectedRole = "Admin";
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            SelectedRole = "Cashier";
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            SelectedRole = "Registrar";
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }
    }
}
