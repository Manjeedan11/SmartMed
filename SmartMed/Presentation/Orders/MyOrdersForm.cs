using SmartMed.Business;
using SmartMed.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SmartMed.Presentation.Orders
{
    public partial class MyOrdersForm : Form
    {
        private Customer currentCustomer;
        private OrderService orderService = new OrderService();
        private OrderItemService orderItemService = new OrderItemService();
        private MedicineService medicineService = new MedicineService();

        public MyOrdersForm(Customer customer)
        {
            InitializeComponent();
            currentCustomer = customer;
            LoadOrders();
        }

        private void LoadOrders()
        {
            try
            {
                var orders = orderService.GetOrdersByCustomer(currentCustomer.customerId);

               
                dgv_myOrder.DataSource = null;
                dgv_myOrder.Rows.Clear();
                dgv_myOrder.Columns.Clear();

                if (orders == null || orders.Count == 0)
                {
               
                    dgv_myOrder.Rows.Add("No orders found.");
                    return;
                }

               
                dgv_myOrder.Columns.Add("OrderID", "Order ID");
                dgv_myOrder.Columns.Add("OrderDate", "Order Date");
                dgv_myOrder.Columns.Add("TotalAmount", "Total Amount");
                dgv_myOrder.Columns.Add("Status", "Status");
                dgv_myOrder.Columns.Add("Action", "Action");

                
                dgv_myOrder.Columns["OrderID"].Width = 100;
                dgv_myOrder.Columns["OrderDate"].Width = 180;
                dgv_myOrder.Columns["TotalAmount"].Width = 150;
                dgv_myOrder.Columns["Status"].Width = 150;
                dgv_myOrder.Columns["Action"].Width = 120;

                
                dgv_myOrder.Columns["TotalAmount"].DefaultCellStyle.Format = "N2";
                dgv_myOrder.Columns["TotalAmount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                
                foreach (var order in orders)
                {
                    
                    int rowIndex = dgv_myOrder.Rows.Add(
                        order.OrderID,
                        order.OrderDate.ToString("yyyy-MM-dd HH:mm"),
                        order.Total,
                        order.Status
                    );

                  
                    DataGridViewButtonCell btnView = new DataGridViewButtonCell();
                    btnView.Value = "View Details";
                    btnView.FlatStyle = FlatStyle.Flat;
                    btnView.Style.BackColor = Color.FromArgb(52, 152, 219);
                    btnView.Style.ForeColor = Color.White;
                    btnView.Style.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

                    dgv_myOrder.Rows[rowIndex].Cells["Action"] = btnView;
                }

               
                dgv_myOrder.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dgv_myOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading orders: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_myOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == dgv_myOrder.Columns["Action"].Index && e.RowIndex >= 0)
            {
                try
                {
                    int orderId = Convert.ToInt32(dgv_myOrder.Rows[e.RowIndex].Cells["OrderID"].Value);
                    ViewOrderDetails(orderId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ViewOrderDetails(int orderId)
        {
            try
            {
               
                var order = orderService.GetOrderById(orderId);
                if (order == null)
                {
                    MessageBox.Show("Order not found.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

              
                var items = orderItemService.GetOrderItemsByOrderId(orderId);

                if (items == null || items.Count == 0)
                {
                    MessageBox.Show("No items found for this order.", "Order Details",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                
                string details = $"Order ID: {order.OrderID}\n";
                details += $"Order Date: {order.OrderDate:yyyy-MM-dd HH:mm}\n";
                details += $"Status: {order.Status}\n";
                details += $"Total: LKR {order.Total:N2}\n\n";
                details += "═══════════════════════════════════════\n";
                details += "Items:\n";
                details += "─────────────────────────────────────\n";

                foreach (var item in items)
                {
                  
                    string medicineName = "Unknown";
                    try
                    {
                        var medicine = medicineService.GetMedicineById(item.MedicineID);
                        if (medicine != null)
                            medicineName = medicine.Name;
                    }
                    catch { }

                    details += $"{medicineName}\n";
                    details += $"  Quantity: {item.Quantity}\n";
                    details += $"  Unit Price: LKR {item.UnitPrice:N2}\n";
                    details += $"  Total: LKR {(item.Quantity * item.UnitPrice):N2}\n";
                    details += "─────────────────────────────────────\n";
                }

                details += "\n═══════════════════════════════════════\n";
                details += $"Grand Total: LKR {order.Total:N2}";

                
                MessageBox.Show(details, $"Order #{orderId} Details",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading order details: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}