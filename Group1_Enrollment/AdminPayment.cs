using System.Data.SqlClient;

namespace EventDriven.Project.UI
{
    public partial class AdminPayment : Form
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EnrollmentDB;Integrated Security=True";
        private ListBox lstSuggestions;

        public AdminPayment()
        {
            InitializeComponent();
            InitializeSuggestionList();
        }

        private void InitializeSuggestionList()
        {
            lstSuggestions = new ListBox();
            lstSuggestions.Visible = false;
            lstSuggestions.Font = new Font("Segoe UI", 9);
            lstSuggestions.Height = 120;
            lstSuggestions.Width = AdminPayment_TXTBOX.Width;
            lstSuggestions.Location = new Point(AdminPayment_TXTBOX.Left, AdminPayment_TXTBOX.Bottom);
            lstSuggestions.Click += lstSuggestions_Click;
            this.Controls.Add(lstSuggestions);
        }

        private void lstSuggestions_Click(object sender, EventArgs e)
        {
            if (lstSuggestions.SelectedItem != null)
            {
                string selectedText = lstSuggestions.SelectedItem.ToString();
                string[] parts = selectedText.Split('|');
                if (parts.Length >= 3)
                {
                    string id = parts[0].Trim();
                    string fullName = parts[1].Trim();
                    string gradeSection = parts[2].Trim();

                    // Fill labels on form
                    AdminStuID_LBL.Text = id;
                    AdminStuName_LBL.Text = fullName;
                    AdminYLSection_LBL.Text = gradeSection;

                    AdminPayment_TXTBOX.Text = id;

                    // Load the payment mode for this student
                    LoadStudentPaymentInfo(id); // now studentId exists
                }

                lstSuggestions.Visible = false;
            }
        }


        private void AdminPayment_Load(object sender, EventArgs e)
        {
            dtCurrDate.Text = DateTime.Now.ToString("MM/dd/yyyy");

            // Initialize CheckedListBox with payment modes
            clbModeOfPayment_AdminPay.Items.Clear();
            clbModeOfPayment_AdminPay.Items.Add("Cash");
            clbModeOfPayment_AdminPay.Items.Add("Low Down Payment");
            clbModeOfPayment_AdminPay.Items.Add("Low Quarterly Payment");

            // Ensure only one mode can be checked at a time
            clbModeOfPayment_AdminPay.ItemCheck += clbModeOfPayment_AdminPay_ItemCheck;

            // Initialize DataGridView
            AdminPayment_GridView.Columns.Clear();
            AdminPayment_GridView.Columns.Add("Item", "Item");
            AdminPayment_GridView.Columns.Add("BaseAmount", "Base Amount (₱)");
            AdminPayment_GridView.Columns.Add("AdjustedAmount", "Adjusted Amount (₱)");


        }

        private void AdminPayment_SearchBTN_Click(object sender, EventArgs e)
        {
            string searchText = AdminPayment_TXTBOX.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter an ID or name to search.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                lstSuggestions.Items.Clear();

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = @"
                        SELECT Id, FirstName, MiddleName, LastName, GradeLevel, Section
                        FROM StudentRecord
                        WHERE Id LIKE @search
                           OR FirstName LIKE @search
                           OR MiddleName LIKE @search
                           OR LastName LIKE @search
                           OR CONCAT(FirstName, ' ', MiddleName, ' ', LastName) LIKE @search";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string fullName = $"{reader["FirstName"]} {reader["MiddleName"]} {reader["LastName"]}".Replace("  ", " ").Trim();
                                string gradeSection = $"{reader["GradeLevel"]} - {reader["Section"]}";
                                string item = $"{reader["Id"]} | {fullName} | {gradeSection}";
                                lstSuggestions.Items.Add(item);
                            }
                        }
                    }
                }

                if (lstSuggestions.Items.Count > 0)
                {
                    lstSuggestions.Visible = true;
                    lstSuggestions.BringToFront();
                }
                else
                {
                    lstSuggestions.Visible = false;
                    MessageBox.Show("No matching student found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during search: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadStudentPaymentInfo(string id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT ModeOfPayment FROM StudentRecord WHERE Id=@id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                        SetPaymentMode(result.ToString());
                }
            }
        }

        private void SetPaymentMode(string mode)
        {
            string normalizedMode = mode.Trim().ToLower();

            // Uncheck all first
            for (int i = 0; i < clbModeOfPayment_AdminPay.Items.Count; i++)
                clbModeOfPayment_AdminPay.SetItemChecked(i, false);

            // Determine which mode to check
            if (normalizedMode.Contains("cash"))
            {
                clbModeOfPayment_AdminPay.SetItemChecked(0, true);
                FillPaymentBreakdown("Cash");
            }
            else if (normalizedMode.Contains("low down"))
            {
                clbModeOfPayment_AdminPay.SetItemChecked(1, true);
                FillPaymentBreakdown("Low Down Payment");
            }
            else if (normalizedMode.Contains("low quarterly") || normalizedMode.Contains("installment"))
            {
                clbModeOfPayment_AdminPay.SetItemChecked(2, true);
                FillPaymentBreakdown("Low Quarterly Payment");
            }
            else
            {
                MessageBox.Show($"Unrecognized payment mode: {mode}", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void clbModeOfPayment_AdminPay_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Allow only one mode checked at a time
            if (e.NewValue == CheckState.Checked)
            {
                for (int i = 0; i < clbModeOfPayment_AdminPay.Items.Count; i++)
                {
                    if (i != e.Index)
                        clbModeOfPayment_AdminPay.SetItemChecked(i, false);
                }

                string selectedMode = clbModeOfPayment_AdminPay.Items[e.Index].ToString();
                FillPaymentBreakdown(selectedMode);
            }
        }

        private void FillPaymentBreakdown(string method)
        {
            AdminPayment_GridView.Rows.Clear();

            if (method == "Cash")
            {
                AdminPayment_GridView.Rows.Add("Tuition Fee", "2,000", "2,000");
                AdminPayment_GridView.Rows.Add("Miscellaneous Fee", "1,500", "1,500");
                AdminPayment_GridView.Rows.Add("Others", "1,700", "1,700");
                AdminPayment_GridView.Rows.Add("Total", "5,200", "5,200");
            }
            else if (method == "Low Down Payment")
            {
                AdminPayment_GridView.Rows.Add("Tuition Fee", "2,000", "2,500");
                AdminPayment_GridView.Rows.Add("Miscellaneous Fee", "1,500", "1,875");
                AdminPayment_GridView.Rows.Add("Others", "1,700", "2,125");
                AdminPayment_GridView.Rows.Add("Total", "5,200", "6,500");
                AdminPayment_GridView.Rows.Add("Down Payment", "-", "500");
                AdminPayment_GridView.Rows.Add("Remaining Balance", "-", "6,000");
                AdminPayment_GridView.Rows.Add("Quarterly Payment (4x)", "-", "1,500");
            }
            else if (method == "Low Quarterly Payment")
            {
                AdminPayment_GridView.Rows.Add("Tuition Fee", "2,000", "2,700");
                AdminPayment_GridView.Rows.Add("Miscellaneous Fee", "1,500", "2,025");
                AdminPayment_GridView.Rows.Add("Others", "1,700", "2,295");
                AdminPayment_GridView.Rows.Add("Total", "5,200", "7,020");
                AdminPayment_GridView.Rows.Add("Down Payment", "-", "500");
                AdminPayment_GridView.Rows.Add("Remaining Balance", "-", "6,520");
                AdminPayment_GridView.Rows.Add("Quarterly Payment (4x)", "-", "1,630");
            }
        }

        private void clbModeOfPayment_AdminPay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clbModeOfPayment_AdminPay.SelectedIndex == -1) return;

            // Allow only one checked at a time
            for (int i = 0; i < clbModeOfPayment_AdminPay.Items.Count; i++)
            {
                if (i != clbModeOfPayment_AdminPay.SelectedIndex)
                    clbModeOfPayment_AdminPay.SetItemChecked(i, false);
            }

            string selected = clbModeOfPayment_AdminPay.SelectedItem.ToString();
            FillPaymentBreakdown(selected);
        }
    }
}
