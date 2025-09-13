using EventDriven.Project.Model;
using System.Data;
using System.Data.SqlClient;

namespace EventDriven.Project.Businesslogic.Repository
{
    internal class UserRepository
    {
        private string CONNECTIONSTRING = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=EventDrivenProject;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public UserModel ValidateUser(string Username, string Password)
        {
            try
            {
                using (SqlConnection Enrollment = new SqlConnection(CONNECTIONSTRING))
                {
                    Enrollment.Open();
                    string query = "SELECT * FROM dbo.[UsersDB] WHERE Username = @username AND User_password = @password";
                    SqlCommand command = new SqlCommand(query, Enrollment);
                    command.Parameters.AddWithValue("@username", Username);
                    command.Parameters.AddWithValue("@password", Password);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if (table.Rows.Count >= 1)
                    {
                        DataRow row = table.Rows[0];
                        return new UserModel
                        {
                            Id = Convert.ToInt32(row["Id"]),
                            Username = row["Username"].ToString(),
                            Password = row["User_password"].ToString(),
                            Roles = row["Roles"].ToString()
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public UserModel getUserByUserId(string UserIdParam)
        {
            try
            {
                UserModel matchingUser = new UserModel();
                using (SqlConnection myConnection = new SqlConnection(CONNECTIONSTRING))
                {
                    string oString = "SELECT * FROM dbo.[UsersDB] WHERE Id = @userId";
                    using (SqlCommand oCmd = new SqlCommand(oString, myConnection))
                    {
                        oCmd.Parameters.AddWithValue("@UserId", UserIdParam);
                        myConnection.Open();
                        using (SqlDataReader oReader = oCmd.ExecuteReader())
                        {
                            if (oReader.Read())
                            {
                                matchingUser.Id = (int)oReader["Id"];
                                matchingUser.Username = oReader["Username"].ToString();
                                matchingUser.Password = oReader["User_password"].ToString();
                                matchingUser.Roles = oReader["Roles"].ToString();
                            }
                        }
                        myConnection.Close();
                    }
                }

                if (matchingUser.Id == 0)
                {
                    throw new Exception("User does not exist");
                }

                return matchingUser;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred: " + ex.Message);
            }
        }
    }
}

        
    