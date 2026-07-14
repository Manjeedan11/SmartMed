using System;

namespace SmartMed.Models
{
    public class OrderItem
    {
        public int OrderItemID { get; private set; }
        public int OrderID { get; private set; }
        public int MedicineID { get; private set; }
        public int Quantity { get; private set; }
        public decimal UnitPrice { get; private set; }

        public Order Order { get; set; }
        public Medicine Medicine { get; set; }


        public OrderItem() { }

     
        public OrderItem(int orderId, int medicineId, int quantity, decimal unitPrice)
        {
            if (orderId < 0)
                throw new ArgumentException("Invalid order ID.", nameof(orderId));
            if (medicineId <= 0)
                throw new ArgumentException("Invalid medicine ID.", nameof(medicineId));
            if (quantity <= 0)
                throw new ArgumentException("Quantity must be positive.", nameof(quantity));
            if (unitPrice < 0)
                throw new ArgumentException("Unit price cannot be negative.", nameof(unitPrice));

            OrderID = orderId;
            MedicineID = medicineId;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }

        public OrderItem(int orderItemId, int orderId, int medicineId, int quantity, decimal unitPrice)
            : this(orderId, medicineId, quantity, unitPrice)
        {
            if (orderItemId <= 0)
                throw new ArgumentException("Invalid OrderItem ID.", nameof(orderItemId));
            OrderItemID = orderItemId;
        }

        public void Validate()
        {
            if (OrderID < 0)
                throw new InvalidOperationException("Invalid order.");
            if (MedicineID <= 0)
                throw new InvalidOperationException("Invalid medicine.");
            if (Quantity <= 0)
                throw new InvalidOperationException("Quantity must be positive.");
            if (UnitPrice < 0)
                throw new InvalidOperationException("Unit price cannot be negative.");
        }

        public void SetId(int id)
        {
            if (OrderItemID != 0)
                throw new InvalidOperationException("OrderItem ID already set.");
            if (id <= 0)
                throw new ArgumentException("Invalid ID.", nameof(id));
            OrderItemID = id;
        }

       
        public void SetOrderId(int orderId)
        {
            if (OrderID != 0)
                throw new InvalidOperationException("OrderID already set.");
            if (orderId <= 0)
                throw new ArgumentException("Invalid order ID.", nameof(orderId));
            OrderID = orderId;
        }
    }
}