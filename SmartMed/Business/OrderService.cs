using SmartMed.Data;
using SmartMed.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SmartMed.Business
{
    public class OrderService
    {
        private OrderRepository orderRepo = new OrderRepository();
        private OrderItemRepository orderItemRepo = new OrderItemRepository();
        private MedicineRepository medicineRepo = new MedicineRepository();

        public List<Order> GetAllOrders()
        {
            return orderRepo.GetAllOrders();
        }

        public int CreateOrder(Order order, List<OrderItem> items)
        {
            
            order.Validate();
            foreach (var item in items)
                item.Validate();

           
            int orderId = orderRepo.CreateOrder(order);
            order.SetId(orderId);

            
            foreach (var item in items)
            {
               
                item.SetOrderId(orderId);
                orderItemRepo.CreateOrderItem(item);
                medicineRepo.UpdateStock(item.MedicineID, item.Quantity, isDecrease: true);
            }

            return orderId;
        }

        public List<Order> GetOrdersByCustomer(int customerId)
        {
            return orderRepo.GetOrdersByCustomer(customerId);
        }

        public Order GetOrderById(int orderId)
        {
            return orderRepo.GetOrderById(orderId);
        }

        public List<decimal> GetLast7DaysSales()
        {
            return orderRepo.GetLast7DaysSales();
        }

        public List<Order> GetAllOrdersWithCustomerDetails()
        {
            return orderRepo.GetAllOrdersWithCustomerDetails();
        }

        public int GetOrderCount()
        {
            return orderRepo.GetOrderCount();
        }

        public decimal GetTotalSales()
        {
            return orderRepo.GetTotalSales();
        }

        public int GetTotalOrdersByCustomer(int customerId)
        {
            return orderRepo.GetTotalOrdersByCustomer(customerId);
        }

        public int GetPendingOrdersByCustomer(int customerId)
        {
            return orderRepo.GetPendingOrdersByCustomer(customerId);
        }

        public int GetDeliveredOrdersByCustomer(int customerId)
        {
            return orderRepo.GetDeliveredOrdersByCustomer(customerId);
        }

        public int GetRecentOrdersByCustomer(int customerId)
        {
            return orderRepo.GetRecentOrdersByCustomer(customerId);
        }
    }
}