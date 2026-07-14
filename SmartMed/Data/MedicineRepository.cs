using SmartMed.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SmartMed.Data
{
    public class MedicineRepository
    {
        private Database db = new Database();

        public List<Medicine> GetAllMedicines()
        {
            List<Medicine> medicines = new List<Medicine>();
            using (SqlConnection conn = db.GetConnection())
            {
                string query = @"
                    SELECT m.*, c.CategoryName, s.SupplierName 
                    FROM Medicine m
                    LEFT JOIN Category c ON m.CategoryID = c.CategoryID
                    LEFT JOIN Supplier s ON m.SupplierID = s.SupplierID
                    ORDER BY m.MedicineID DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        medicines.Add(MapToMedicine(reader));
                    }
                }
            }
            return medicines;
        }

       
        public Medicine GetMedicineById(int id)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = @"
                    SELECT m.*, c.CategoryName, s.SupplierName 
                    FROM Medicine m
                    LEFT JOIN Category c ON m.CategoryID = c.CategoryID
                    LEFT JOIN Supplier s ON m.SupplierID = s.SupplierID
                    WHERE m.MedicineID = @MedicineID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MedicineID", id);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return MapToMedicine(reader);
                    }
                }
            }
            return null;
        }

        
        public int CreateMedicine(Medicine medicine)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = @"
                    INSERT INTO Medicine (Name, CategoryID, SupplierID, Dosage, Price, Stock, ExpiryDate, RequiresPrescription, Discount, ImageURL)
                    VALUES (@Name, @CategoryID, @SupplierID, @Dosage, @Price, @Stock, @ExpiryDate, @RequiresPrescription, @Discount, @ImageURL);
                    SELECT SCOPE_IDENTITY();";

                SqlCommand cmd = new SqlCommand(query, conn);
                AddParameters(cmd, medicine);
                conn.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public bool UpdateMedicine(Medicine medicine)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = @"
                    UPDATE Medicine 
                    SET Name = @Name, 
                        CategoryID = @CategoryID, 
                        SupplierID = @SupplierID, 
                        Dosage = @Dosage, 
                        Price = @Price, 
                        Stock = @Stock, 
                        ExpiryDate = @ExpiryDate, 
                        RequiresPrescription = @RequiresPrescription, 
                        Discount = @Discount,
                        ImageURL = @ImageURL
                    WHERE MedicineID = @MedicineID";

                SqlCommand cmd = new SqlCommand(query, conn);
                AddParameters(cmd, medicine);
                cmd.Parameters.AddWithValue("@MedicineID", medicine.MedicineID);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

      
        public bool DeleteMedicine(int id)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "DELETE FROM Medicine WHERE MedicineID = @MedicineID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MedicineID", id);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateStock(int medicineId, int quantity, bool isDecrease = true)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string operation = isDecrease ? "Stock - @Quantity" : "Stock + @Quantity";
                string query = $"UPDATE Medicine SET Stock = {operation} WHERE MedicineID = @MedicineID AND Stock >= @Quantity";
                // The condition prevents negative stock
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@MedicineID", medicineId);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public List<Category> GetAllCategories()
        {
            List<Category> categories = new List<Category>();
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "SELECT CategoryID, CategoryName FROM Category ORDER BY CategoryName";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        categories.Add(new Category
                        {
                            CategoryID = (int)reader["CategoryID"],
                            CategoryName = reader["CategoryName"].ToString()
                        });
                    }
                }
            }
            return categories;
        }

       
        public List<Supplier> GetAllSuppliers()
        {
            List<Supplier> suppliers = new List<Supplier>();
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "SELECT SupplierID, SupplierName, Contact, Phone FROM Supplier ORDER BY SupplierName";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        suppliers.Add(new Supplier
                        {
                            SupplierID = (int)reader["SupplierID"],
                            SupplierName = reader["SupplierName"].ToString(),
                            Contact = reader["Contact"].ToString(),
                            Phone = reader["Phone"].ToString()
                        });
                    }
                }
            }
            return suppliers;
        }

  
        private Medicine MapToMedicine(SqlDataReader reader)
        {
           
            Medicine medicine = new Medicine(
                (int)reader["MedicineID"],
                reader["Name"].ToString(),
                (int)reader["CategoryID"],
                (int)reader["SupplierID"],
                reader["Dosage"]?.ToString(),
                (decimal)reader["Price"],
                (int)reader["Stock"],
                (DateTime)reader["ExpiryDate"],
                (bool)reader["RequiresPrescription"],
                reader["Discount"] as decimal?,
                reader["ImageURL"]?.ToString()
            );

            medicine.Category = new Category
            {
                CategoryID = (int)reader["CategoryID"],
                CategoryName = reader["CategoryName"]?.ToString()
            };
            medicine.Supplier = new Supplier
            {
                SupplierID = (int)reader["SupplierID"],
                SupplierName = reader["SupplierName"]?.ToString()
            };

            return medicine;
        }

        public int GetMedicineCount()
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM Medicine";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                return (int)cmd.ExecuteScalar();
            }
        }




        private void AddParameters(SqlCommand cmd, Medicine medicine)
        {
            cmd.Parameters.AddWithValue("@Name", medicine.Name);
            cmd.Parameters.AddWithValue("@CategoryID", medicine.CategoryID);
            cmd.Parameters.AddWithValue("@SupplierID", medicine.SupplierID);
            cmd.Parameters.AddWithValue("@Dosage", (object)medicine.Dosage ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Price", medicine.Price);
            cmd.Parameters.AddWithValue("@Stock", medicine.Stock);
            cmd.Parameters.AddWithValue("@ExpiryDate", medicine.ExpiryDate);
            cmd.Parameters.AddWithValue("@RequiresPrescription", medicine.RequiresPrescription);
            cmd.Parameters.AddWithValue("@Discount", (object)medicine.Discount ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@ImageURL", (object)medicine.ImageURL ?? DBNull.Value);
        }
    }
}