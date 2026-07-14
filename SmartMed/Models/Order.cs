using SmartMed.Models;
using System;
using System.Collections.Generic;

namespace SmartMed.Models
{
    public class Order
    {
        public int OrderID { get; private set; }
        public int CustomerID { get; private set; }
        public DateTime OrderDate { get; private set; }
        public string Status { get; private set; }
        public decimal Total { get; private set; }
        public decimal? DiscountApplied { get; private set; }

    
        public string CustomerName { get; set; }

        public Customer Customer { get; set; }
        public List<OrderItem> Items { get; set; }

        public Order() { }

       
        public Order(int customerId, decimal total, decimal? discountApplied = null)
        {
            if (customerId <= 0)
                throw new ArgumentException("Invalid customer ID.", nameof(customerId));
            if (total < 0)
                throw new ArgumentException("Total cannot be negative.", nameof(total));
            if (discountApplied.HasValue && (discountApplied.Value < 0 || discountApplied.Value > 100))
                throw new ArgumentException("Discount must be between 0 and 100.", nameof(discountApplied));

            CustomerID = customerId;
            OrderDate = DateTime.Now;
            Status = "Pending";
            Total = total;
            DiscountApplied = discountApplied;
        }

        public Order(int orderId, int customerId, DateTime orderDate, string status,
                     decimal total, decimal? discountApplied)
            : this(customerId, total, discountApplied)
        {
            if (orderId <= 0)
                throw new ArgumentException("Invalid order ID.", nameof(orderId));
            OrderID = orderId;
            OrderDate = orderDate;
            Status = status;
        }

        public void Validate()
        {
            if (CustomerID <= 0)
                throw new InvalidOperationException("Invalid customer.");
            if (Total < 0)
                throw new InvalidOperationException("Total cannot be negative.");
            if (string.IsNullOrWhiteSpace(Status))
                throw new InvalidOperationException("Status is required.");
        }

        public void SetId(int id)
        {
            if (OrderID != 0)
                throw new InvalidOperationException("Order ID already set.");
            OrderID = id;
        }
    }
}