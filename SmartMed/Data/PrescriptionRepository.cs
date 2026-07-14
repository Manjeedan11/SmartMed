using SmartMed.Models;
using System;
using System.Data.SqlClient;

namespace SmartMed.Data
{
    public class PrescriptionRepository
    {
        private Database db = new Database();

        public bool CreatePrescription(Prescription prescription)
        {
            using (SqlConnection conn = db.GetConnection())
            {
                string query = @"
                    INSERT INTO Prescription (OrderID, CustomerID, MedicineID, FilePath, UploadDate, IsVerified)
                    VALUES (@OrderID, @CustomerID, @MedicineID, @FilePath, @UploadDate, @IsVerified)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@OrderID", prescription.OrderID);
                cmd.Parameters.AddWithValue("@CustomerID", prescription.CustomerID);
                cmd.Parameters.AddWithValue("@MedicineID", prescription.MedicineID);
                cmd.Parameters.AddWithValue("@FilePath", prescription.FilePath);
                cmd.Parameters.AddWithValue("@UploadDate", prescription.UploadDate);
                cmd.Parameters.AddWithValue("@IsVerified", prescription.IsVerified);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public Prescription GetPrescriptionById(int id)
        {
            throw new NotImplementedException();
        }

        public bool VerifyPrescription(int prescriptionId)
        {
            throw new NotImplementedException();
        }
    }
}