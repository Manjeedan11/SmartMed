using System;

namespace SmartMed.Models
{
    public class Medicine
    {
    
        public int MedicineID { get; set; }
        public string Name { get; private set; }
        public int CategoryID { get; private set; }
        public int SupplierID { get; private set; }
        public string Dosage { get; private set; }
        public decimal Price { get; private set; }
        public int Stock { get; private set; }
        public DateTime ExpiryDate { get; private set; }
        public bool RequiresPrescription { get; private set; }
        public decimal? Discount { get; private set; }
        public string ImageURL { get; private set; }

        public Category Category { get; set; }
        public Supplier Supplier { get; set; }
        

        public Medicine(string name, int categoryId, int supplierId, string dosage,
                        decimal price, int stock, DateTime expiryDate,
                        bool requiresPrescription, decimal? discount, string imageURL)
        {
            
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Medicine name is required.", nameof(name));
            if (categoryId <= 0)
                throw new ArgumentException("Category is required.", nameof(categoryId));
            if (supplierId <= 0)
                throw new ArgumentException("Supplier is required.", nameof(supplierId));
            if (price <= 0)
                throw new ArgumentException("Price must be greater than 0.", nameof(price));
            if (stock < 0)
                throw new ArgumentException("Stock cannot be negative.", nameof(stock));
            if (expiryDate <= DateTime.Today)
                throw new ArgumentException("Expiry date must be in the future.", nameof(expiryDate));
            if (discount.HasValue && (discount.Value < 0 || discount.Value > 100))
                throw new ArgumentException("Discount must be between 0 and 100.", nameof(discount));

        
            Name = name;
            CategoryID = categoryId;
            SupplierID = supplierId;
            Dosage = dosage;
            Price = price;
            Stock = stock;
            ExpiryDate = expiryDate;
            RequiresPrescription = requiresPrescription;
            Discount = discount;
            ImageURL = imageURL;
        }

     
        public Medicine(int medicineId, string name, int categoryId, int supplierId, string dosage,
                        decimal price, int stock, DateTime expiryDate,
                        bool requiresPrescription, decimal? discount, string imageURL)
            : this(name, categoryId, supplierId, dosage, price, stock, expiryDate,
                   requiresPrescription, discount, imageURL)
        {
            MedicineID = medicineId;
        }

    
        public void SetId(int id)
        {
            if (MedicineID != 0)
                throw new InvalidOperationException("ID is already set and cannot be changed.");
            if (id <= 0)
                throw new ArgumentException("Invalid ID.", nameof(id));
            MedicineID = id;
        }

        public void Validate()
        {
            if (string.IsNullOrWhiteSpace(Name))
                throw new InvalidOperationException("Medicine name is required.");
            if (CategoryID <= 0)
                throw new InvalidOperationException("Category is required.");
            if (SupplierID <= 0)
                throw new InvalidOperationException("Supplier is required.");
            if (Price <= 0)
                throw new InvalidOperationException("Price must be greater than 0.");
            if (Stock < 0)
                throw new InvalidOperationException("Stock cannot be negative.");
            if (ExpiryDate <= DateTime.Today)
                throw new InvalidOperationException("Expiry date must be in the future.");
            if (Discount.HasValue && (Discount.Value < 0 || Discount.Value > 100))
                throw new InvalidOperationException("Discount must be between 0 and 100.");
        }
    }
}