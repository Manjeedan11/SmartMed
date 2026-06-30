using SmartMed.Models;
using System.Data.SqlClient;

namespace SmartMed.Data
{
    public class CustomerRepository
    {
        private Database db = new Database();

        
        public bool CreateCustomer(Customer customer)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = @"INSERT INTO Customer (UserID, FullName, Phone, Address) 
                                 VALUES (@UserID, @FullName, @Phone, @Address)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", customer.userId);
                cmd.Parameters.AddWithValue("@FullName", customer.fullName);
                cmd.Parameters.AddWithValue("@Phone", customer.phoneNumber);
                cmd.Parameters.AddWithValue("@Address", customer.address);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

      
        public Customer GetCustomerByUserId(int userId)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = @"
                    SELECT u.UserID, u.Email, u.PasswordHash, u.Role, u.CreatedAt,
                           c.CustomerID, c.FullName, c.Phone, c.Address
                    FROM [User] u
                    JOIN Customer c ON u.UserID = c.UserID
                    WHERE u.UserID = @UserID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserID", userId);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Customer
                        {
                            // From User table
                            userId = (int)reader["UserID"],
                            email = reader["Email"].ToString(),
                            passwordHash = reader["PasswordHash"].ToString(),
                            role = reader["Role"].ToString(),
                            createdAt = (DateTime)reader["CreatedAt"],
                            // From Customer table
                            customerId = (int)reader["CustomerID"],
                            fullName = reader["FullName"].ToString(),
                            phoneNumber = reader["Phone"].ToString(),
                            address = reader["Address"].ToString()
                        };
                    }
                }
                return null;
            }
        }

   
        public bool UpdateCustomer(Customer customer)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = @"UPDATE Customer 
                                 SET FullName = @FullName, Phone = @Phone, Address = @Address
                                 WHERE UserID = @UserID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FullName", customer.fullName);
                cmd.Parameters.AddWithValue("@Phone", customer.phoneNumber);
                cmd.Parameters.AddWithValue("@Address", customer.address);
                cmd.Parameters.AddWithValue("@UserID", customer.userId);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}