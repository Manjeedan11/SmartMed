using SmartMed.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SmartMed.Data
{
    public class CustomerRepository
    {
        private Database db = new Database();

        public List<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>();
            using (SqlConnection conn = db.GetConnection())
            {
                string query = @"
                    SELECT c.CustomerID, c.UserID, c.FullName, c.Phone, c.Address,
                           u.Email, u.Role, u.CreatedAt
                    FROM Customer c
                    INNER JOIN [User] u ON c.UserID = u.UserID
                    ORDER BY c.FullName";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Customer customer = new Customer(
                            (int)reader["CustomerID"],
                            (int)reader["UserID"],
                            reader["FullName"].ToString(),
                            reader["Phone"].ToString(),
                            reader["Address"].ToString()
                        );
                        
                        customer.User = new User(
                            (int)reader["UserID"],
                            reader["Email"].ToString(),
                            null, 
                            reader["Role"].ToString(),
                            (DateTime)reader["CreatedAt"]
                        );
                        customers.Add(customer);
                    }
                }
            }
            return customers;
        }

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
                        Customer customer = new Customer(
                            (int)reader["CustomerID"],
                            (int)reader["UserID"],
                            reader["FullName"].ToString(),
                            reader["Phone"].ToString(),
                            reader["Address"].ToString()
                        );
                        customer.User = new User(
                            (int)reader["UserID"],
                            reader["Email"].ToString(),
                            reader["PasswordHash"].ToString(),
                            reader["Role"].ToString(),
                            (DateTime)reader["CreatedAt"]
                        );
                        return customer;
                    }
                }
                return null;
            }
        }

        public Customer GetCustomerById(int customerId)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = @"
                    SELECT u.UserID, u.Email, u.PasswordHash, u.Role, u.CreatedAt,
                           c.CustomerID, c.FullName, c.Phone, c.Address
                    FROM Customer c
                    INNER JOIN [User] u ON c.UserID = u.UserID
                    WHERE c.CustomerID = @CustomerID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerID", customerId);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Customer customer = new Customer(
                            (int)reader["CustomerID"],
                            (int)reader["UserID"],
                            reader["FullName"].ToString(),
                            reader["Phone"].ToString(),
                            reader["Address"].ToString()
                        );
                        customer.User = new User(
                            (int)reader["UserID"],
                            reader["Email"].ToString(),
                            reader["PasswordHash"].ToString(),
                            reader["Role"].ToString(),
                            (DateTime)reader["CreatedAt"]
                        );
                        return customer;
                    }
                }
                return null;
            }
        }

        public bool UpdateCustomer(Customer customer, string newEmail)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                conn.Open();
                using (SqlTransaction tran = conn.BeginTransaction())
                {
                    try
                    {
                        string query1 = @"
                            UPDATE Customer 
                            SET FullName = @FullName, Phone = @Phone, Address = @Address
                            WHERE CustomerID = @CustomerID";
                        SqlCommand cmd1 = new SqlCommand(query1, conn, tran);
                        cmd1.Parameters.AddWithValue("@FullName", customer.fullName);
                        cmd1.Parameters.AddWithValue("@Phone", customer.phoneNumber);
                        cmd1.Parameters.AddWithValue("@Address", customer.address);
                        cmd1.Parameters.AddWithValue("@CustomerID", customer.customerId);
                        int rows1 = cmd1.ExecuteNonQuery();

                        string query2 = @"
                            UPDATE [User] 
                            SET Email = @Email
                            WHERE UserID = @UserID";
                        SqlCommand cmd2 = new SqlCommand(query2, conn, tran);
                        cmd2.Parameters.AddWithValue("@Email", newEmail);
                        cmd2.Parameters.AddWithValue("@UserID", customer.userId);
                        int rows2 = cmd2.ExecuteNonQuery();

                        tran.Commit();
                        return rows1 > 0 && rows2 > 0;
                    }
                    catch
                    {
                        tran.Rollback();
                        throw;
                    }
                }
            }
        }

        public int GetCustomerCount()
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM Customer";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }
    }
}