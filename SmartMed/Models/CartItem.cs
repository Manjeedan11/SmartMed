using System;

namespace SmartMed.Models
{
    public class CartItem
    {
        public int MedicineID { get; set; }
        public string Name { get; set; }
        public string Dosage { get; set; }
        public decimal Price { get; set; }
        public decimal? Discount { get; set; }
        public int Quantity { get; set; }
        public string ImageURL { get; set; }
        public bool RequiresPrescription { get; set; }
        public string PrescriptionFilePath { get; set; } 

        public decimal UnitPrice => Price * (1 - (Discount ?? 0) / 100m);
        public decimal Total => UnitPrice * Quantity;
    }
}