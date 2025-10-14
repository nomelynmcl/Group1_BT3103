using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using EventDriven.Project.Model;

namespace EventDriven.Project.BusinessLogic.Repository
{
    public class StudentRecordRepository
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EnrollmentDB;Integrated Security=True";

        public int Insert(StudentRecordModel studentRecordModel)
        {
            var query = "INSERT INTO StudentRecord (LastName,FirstName, MiddleName, ContactNumber,Gender,Address,Birthdate, GradeLevel)" +
                            "VALUES (@Lastname,@Firstname, @Middlename, @ContactNumber,@Gender,@Address,@Birthdate, @GradeLevel)";
            var rowsAffected = -1;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Lastname", studentRecordModel.Lastname);
                        command.Parameters.AddWithValue("@Firstname", studentRecordModel.Firstname);
                        command.Parameters.AddWithValue("@Middlename", studentRecordModel.Middlename);
                        command.Parameters.AddWithValue("@ContactNumber", studentRecordModel.ContactNumber);
                        command.Parameters.AddWithValue("@Gender", studentRecordModel.Gender);
                        command.Parameters.AddWithValue("@Barangay", studentRecordModel.Barangay);
                        command.Parameters.AddWithValue("@Municipality", studentRecordModel.Municipality);
                        command.Parameters.AddWithValue("@Province", studentRecordModel.Province);
                        command.Parameters.AddWithValue("@Birthdate", studentRecordModel.Birthdate);
                        command.Parameters.AddWithValue("@GradeLevel", studentRecordModel.GradeLevel);


                        return command.ExecuteNonQuery();

                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("An error occurred: " + ex.Message);
                }
            }
        }



        public StudentRecordModel GetById(int id)
        {
            var query = "SELECT Id, LastName, FirstName, MiddleName,ContactNumber,Gender,Address,Birthdate, GradeLevel FROM StudentRecord WHERE id=@id";
            var result = new StudentRecordModel();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                result = new StudentRecordModel
                                {
                                    Lastname = reader.GetString(0),
                                    Firstname = reader.GetString(1),
                                    Middlename = reader.GetString(2),
                                    ContactNumber = reader.GetString(3),
                                    Gender = reader.GetString(4),
                                    Barangay = reader.GetString(5),
                                    Municipality = reader.GetString(5),
                                    Province = reader.GetString(5),
                                    Birthdate = reader.GetDateTime(6),
                                    GradeLevel = Convert.ToInt32(reader.GetString(7))
                                    
                                };
                            }
                            else
                            {
                                throw new Exception("No student found.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("An error occurred: " + ex.Message);
                }
            }
            return result;
        }

        public int GetCount()
        {
            var count = 0;
            var query = "SELECT COUNT(*) FROM StudentRecord";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    ; using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        var result = command.ExecuteScalar();
                        count = result != null ? Convert.ToInt32(result) : 0;

                        Console.WriteLine($"Total number of Client: {count}");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("An error occurred: " + ex.Message);
                }
            }
            return count;
        }
    }
}
