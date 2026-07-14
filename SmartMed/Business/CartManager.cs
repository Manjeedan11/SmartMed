using SmartMed.Models;
using System.Collections.Generic;
using System.Linq;

namespace SmartMed.Business
{
    public static class CartManager
    {
        private static List<CartItem> _items = new List<CartItem>();

        public static IReadOnlyList<CartItem> Items => _items.AsReadOnly();
        public static void AddItem(int medicineId, string name, string dosage, decimal price, decimal? discount, string imageURL, bool requiresPrescription, int quantity = 1)
        {
            var existing = _items.FirstOrDefault(i => i.MedicineID == medicineId);
            if (existing != null)
            {
                existing.Quantity += quantity;
            }
            else
            {
                _items.Add(new CartItem
                {
                    MedicineID = medicineId,
                    Name = name,
                    Dosage = dosage,
                    Price = price,
                    Discount = discount,
                    Quantity = quantity,
                    ImageURL = imageURL,
                    RequiresPrescription = requiresPrescription,
                    PrescriptionFilePath = null
                });
            }
        }

        public static void UpdateQuantity(int medicineId, int newQuantity)
        {
            var item = _items.FirstOrDefault(i => i.MedicineID == medicineId);
            if (item != null)
            {
                if (newQuantity <= 0)
                    RemoveItem(medicineId);
                else
                    item.Quantity = newQuantity;
            }
        }

        public static void RemoveItem(int medicineId)
        {
            var item = _items.FirstOrDefault(i => i.MedicineID == medicineId);
            if (item != null)
                _items.Remove(item);
        }

        public static void Clear()
        {
            _items.Clear();
        }

        public static decimal GetSubTotal()
        {
            return _items.Sum(i => i.Total);
        }

        public static decimal GetTotalDiscount()
        {
            return _items.Sum(i => (i.Price - i.UnitPrice) * i.Quantity);
        }

        public static decimal GetTotal()
        {
            return GetSubTotal();
        }
    }
}