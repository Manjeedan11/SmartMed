using SmartMed.Models;
using System;
using System.Data.SqlClient;

namespace SmartMed.Data
{
    public class UserRepository
    {
        private Database db = new Database();

        public User GetUserByEmail(string email)
        {
            User user = null;
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "SELECT UserID, Email, PasswordHash, Role, CreatedAt FROM [User] WHERE Email = @Email";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        user = new User
                        {
                            userId = (int)reader["UserID"],
                            email = reader["Email"].ToString(),
                            passwordHash = reader["PasswordHash"].ToString(),
                            role = reader["Role"].ToString(),
                            createdAt = (DateTime)reader["CreatedAt"]
                        };
                    }
                }
            }
            return user;
        }

        
        public bool EmailExists(string email)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "SELECT COUNT(1) FROM [User] WHERE Email = @Email";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);
                conn.Open();
                return (int)cmd.ExecuteScalar() > 0;
            }
        }

        
        public int CreateUser(User user)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = @"INSERT INTO [User] (Email, PasswordHash, Role, CreatedAt) 
                                 VALUES (@Email, @PasswordHash, @Role, @CreatedAt);
                                 SELECT SCOPE_IDENTITY();";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", user.email);
                cmd.Parameters.AddWithValue("@PasswordHash", user.passwordHash);
                cmd.Parameters.AddWithValue("@Role", user.role);
                cmd.Parameters.AddWithValue("@CreatedAt", DateTime.Now);
                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
    }
}