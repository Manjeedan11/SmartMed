using SmartMed.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SmartMed.Data
{
    public class OrderItemRepository
    {
        private Database db = new Database();

        public bool CreateOrderItem(OrderItem item)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = @"
                    INSERT INTO OrderItem (OrderID, MedicineID, Quantity, UnitPrice)
                    VALUES (@OrderID, @MedicineID, @Quantity, @UnitPrice)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@OrderID", item.OrderID);
                cmd.Parameters.AddWithValue("@MedicineID", item.MedicineID);
                cmd.Parameters.AddWithValue("@Quantity", item.Quantity);
                cmd.Parameters.AddWithValue("@UnitPrice", item.UnitPrice);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public List<OrderItem> GetOrderItemsByOrderId(int orderId)
        {
            List<OrderItem> items = new List<OrderItem>();
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "SELECT * FROM OrderItem WHERE OrderID = @OrderID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@OrderID", orderId);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Use the constructor that includes OrderItemID
                        OrderItem item = new OrderItem(
                            (int)reader["OrderItemID"],
                            (int)reader["OrderID"],
                            (int)reader["MedicineID"],
                            (int)reader["Quantity"],
                            (decimal)reader["UnitPrice"]
                        );
                        items.Add(item);
                    }
                }
            }
            return items;
        }
    }
}