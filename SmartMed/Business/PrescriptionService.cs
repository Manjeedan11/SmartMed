using SmartMed.Data;
using SmartMed.Models;
using System;
using System.IO;

namespace SmartMed.Business
{
    public class PrescriptionService
    {
        private PrescriptionRepository repo = new PrescriptionRepository();

        public bool SavePrescription(int orderId, int customerId, int medicineId, string sourceFilePath)
        {
            if (string.IsNullOrEmpty(sourceFilePath) || !File.Exists(sourceFilePath))
                throw new Exception("Invalid prescription file.");

           
            string destFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Prescriptions");
            Directory.CreateDirectory(destFolder);

        
            string fileName = $"{orderId}_{medicineId}_{Path.GetFileName(sourceFilePath)}";
            string destPath = Path.Combine(destFolder, fileName);

            
            File.Copy(sourceFilePath, destPath, true);

            
            var prescription = new Prescription
            {
                OrderID = orderId,
                CustomerID = customerId,
                MedicineID = medicineId,
                FilePath = destPath,
                UploadDate = DateTime.Now,
                IsVerified = false
            };

            return repo.CreatePrescription(prescription);
        }

        public bool SavePrescriptions(int orderId, int customerId, System.Collections.Generic.List<CartItem> cartItems)
        {
            bool allSaved = true;
            foreach (var item in cartItems)
            {
                if (item.RequiresPrescription && !string.IsNullOrEmpty(item.PrescriptionFilePath))
                {
                    try
                    {
                        bool saved = SavePrescription(orderId, customerId, item.MedicineID, item.PrescriptionFilePath);
                        if (!saved) allSaved = false;
                    }
                    catch
                    {
                        allSaved = false;
                    }
                }
            }
            return allSaved;
        }
    }
}