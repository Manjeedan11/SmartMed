using SmartMed.Models;
using System;
using System.Data.SqlClient;

namespace SmartMed.Data
{
    public class OrderRepository
    {
        private Database db = new Database();

        public List<Order> GetAllOrders()
        {
            List<Order> orders = new List<Order>();
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "SELECT * FROM [Order] ORDER BY OrderDate DESC";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        orders.Add(MapToOrder(reader));
                }
            }
            return orders;
        }

        public int CreateOrder(Order order)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = @"
                    INSERT INTO [Order] (CustomerID, OrderDate, Status, Total, DiscountApplied)
                    VALUES (@CustomerID, @OrderDate, @Status, @Total, @DiscountApplied);
                    SELECT SCOPE_IDENTITY();";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerID", order.CustomerID);
                cmd.Parameters.AddWithValue("@OrderDate", order.OrderDate);
                cmd.Parameters.AddWithValue("@Status", order.Status);
                cmd.Parameters.AddWithValue("@Total", order.Total);
                cmd.Parameters.AddWithValue("@DiscountApplied", (object)order.DiscountApplied ?? DBNull.Value);
                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public List<Order> GetOrdersByCustomer(int customerId)
        {
            List<Order> orders = new List<Order>();
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "SELECT * FROM [Order] WHERE CustomerID = @CustomerID ORDER BY OrderDate DESC";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerID", customerId);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        orders.Add(MapToOrder(reader));
                    }
                }
            }
            return orders;
        }

        public Order GetOrderById(int orderId)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "SELECT * FROM [Order] WHERE OrderID = @OrderID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@OrderID", orderId);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return MapToOrder(reader);
                    }
                }
            }
            return null;
        }

        private Order MapToOrder(SqlDataReader reader)
        {
            return new Order(
                (int)reader["OrderID"],
                (int)reader["CustomerID"],
                (DateTime)reader["OrderDate"],
                reader["Status"].ToString(),
                (decimal)reader["Total"],
                reader["DiscountApplied"] as decimal?
            );
        }

        public List<decimal> GetLast7DaysSales()
        {
            List<decimal> sales = new List<decimal>();
            using (SqlConnection conn = db.GetConnection())
            {
                string query = @"
            SELECT 
                DATEADD(day, DATEDIFF(day, 0, OrderDate), 0) as OrderDay,
                SUM(Total) as DailyTotal
            FROM [Order]
            WHERE OrderDate >= DATEADD(day, -6, GETDATE())
            GROUP BY DATEADD(day, DATEDIFF(day, 0, OrderDate), 0)
            ORDER BY OrderDay";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    var today = DateTime.Now.Date;
                    var startDate = today.AddDays(-6);
                    var dict = new Dictionary<DateTime, decimal>();

                    for (int i = 0; i < 7; i++)
                        dict.Add(startDate.AddDays(i), 0);

                    while (reader.Read())
                    {
                        DateTime day = (DateTime)reader["OrderDay"];
                        decimal total = (decimal)reader["DailyTotal"];
                        if (dict.ContainsKey(day))
                            dict[day] = total;
                    }

                    sales = dict.OrderBy(kvp => kvp.Key).Select(kvp => kvp.Value).ToList();
                }
            }
            return sales;
        }

        
        public List<Order> GetAllOrdersWithCustomerDetails()
        {
            List<Order> orders = new List<Order>();
            using (SqlConnection conn = db.GetConnection())
            {
                string query = @"
            SELECT o.*, c.FullName as CustomerName
            FROM [Order] o
            INNER JOIN Customer c ON o.CustomerID = c.CustomerID
            ORDER BY o.OrderDate DESC";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Order order = MapToOrder(reader);
                        order.CustomerName = reader["CustomerName"].ToString(); 
                        orders.Add(order);
                    }
                }
            }
            return orders;
        }
        public int GetOrderCount()
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM [Order]";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        public decimal GetTotalSales()
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "SELECT ISNULL(SUM(Total), 0) FROM [Order]";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                return (decimal)cmd.ExecuteScalar();
            }
        }

     
        public int GetTotalOrdersByCustomer(int customerId)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM [Order] WHERE CustomerID = @CustomerID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerID", customerId);
                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        public int GetPendingOrdersByCustomer(int customerId)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM [Order] WHERE CustomerID = @CustomerID AND Status = 'Pending'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerID", customerId);
                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

        public int GetDeliveredOrdersByCustomer(int customerId)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM [Order] WHERE CustomerID = @CustomerID AND Status = 'Delivered'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerID", customerId);
                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }

       
        public int GetRecentOrdersByCustomer(int customerId)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM [Order] WHERE CustomerID = @CustomerID AND OrderDate >= DATEADD(day, -7, GETDATE())";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerID", customerId);
                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }
    }
}