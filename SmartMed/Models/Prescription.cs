using System;

namespace SmartMed.Models
{
    public class Prescription
    {
        public int PrescriptionID { get; set; }
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int MedicineID { get; set; }
        public string FilePath { get; set; }  
        public DateTime UploadDate { get; set; }
        public bool IsVerified { get; set; }  

        
        public Order Order { get; set; }
        public Customer Customer { get; set; }
        public Medicine Medicine { get; set; }
    }
}