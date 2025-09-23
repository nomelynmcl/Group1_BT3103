using System;
using System.Data.SqlClient;
using EventDriven.Project.Model;

namespace EventDriven.Project.Businesslogic.Repository
{
    public class UserRepository
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EnrollmentDB;Integrated Security=True";

        public UserModel ValidateUser(string username, string password)
        {
            UserModel user = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT TOP 1 [Username], [User_password], [Roles] " +
                               "FROM [UsersDB] " +
                               "WHERE [Username] = @username AND [User_password] = @password";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        user = new UserModel
                        {
                            Username = reader["Username"].ToString(),
                            Password = reader["User_password"].ToString(),
                            Roles = reader["Roles"].ToString()
                        };
                    }
                }
            }

            return user;
        }
    }
}