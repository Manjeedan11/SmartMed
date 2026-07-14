using SmartMed.Data;
using SmartMed.Models;
using System.Collections.Generic;

namespace SmartMed.Business
{
    public class OrderItemService
    {
        private OrderItemRepository repo = new OrderItemRepository();

        public List<OrderItem> GetOrderItemsByOrderId(int orderId)
        {
            return repo.GetOrderItemsByOrderId(orderId);
        }
    }
}