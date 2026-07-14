using SmartMed.Business;
using SmartMed.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SmartMed.Presentation.Orders
{
    public partial class OrderManagementForm : Form
    {
        private OrderService orderService = new OrderService();
        private OrderItemService orderItemService = new OrderItemService();
        private MedicineService medicineService = new MedicineService();

        public OrderManagementForm()
        {
            InitializeComponent();
            LoadOrders();

            
            dgv_orders.CellContentClick += dgv_orders_CellContentClick;
        }

    
        private void LoadOrders()
        {
            try
            {
                var orders = orderService.GetAllOrdersWithCustomerDetails();

             
                dgv_orders.DataSource = null;
                dgv_orders.Rows.Clear();
                dgv_orders.Columns.Clear();

                if (orders == null || orders.Count == 0)
                {
                    dgv_orders.Rows.Add("No orders found.");
                    return;
                }

               
                dgv_orders.Columns.Add("OrderID", "Order ID");
                dgv_orders.Columns.Add("OrderDate", "Order Date");
                dgv_orders.Columns.Add("Customer", "Customer");
                dgv_orders.Columns.Add("TotalAmount", "Total Amount");
                dgv_orders.Columns.Add("Status", "Status");
                dgv_orders.Columns.Add("Action", "Action");

              
                dgv_orders.Columns["OrderID"].Width = 100;
                dgv_orders.Columns["OrderDate"].Width = 160;
                dgv_orders.Columns["Customer"].Width = 200;
                dgv_orders.Columns["TotalAmount"].Width = 130;
                dgv_orders.Columns["Status"].Width = 120;
                dgv_orders.Columns["Action"].Width = 100;

           
                dgv_orders.Columns["TotalAmount"].DefaultCellStyle.Format = "N2";
                dgv_orders.Columns["TotalAmount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                
                foreach (var order in orders)
                {
                    int rowIndex = dgv_orders.Rows.Add(
                        order.OrderID,
                        order.OrderDate.ToString("yyyy-MM-dd HH:mm"),
                        order.CustomerName ?? "Unknown",
                        order.Total,
                        order.Status
                    );

                    DataGridViewButtonCell btnView = new DataGridViewButtonCell();
                    btnView.Value = "View";
                    btnView.FlatStyle = FlatStyle.Flat;
                    btnView.Style.BackColor = Color.FromArgb(52, 152, 219);
                    btnView.Style.ForeColor = Color.White;
                    btnView.Style.Font = new Font("Segoe UI", 9F, FontStyle.Bold);

                    dgv_orders.Rows[rowIndex].Cells["Action"] = btnView;
                }

             
                dgv_orders.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dgv_orders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

              
                dgv_orders.AllowUserToAddRows = false;
                dgv_orders.BackgroundColor = Color.White;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading orders: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     
        private void dgv_orders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.ColumnIndex == dgv_orders.Columns["Action"].Index && e.RowIndex >= 0)
            {
                try
                {
                    int orderId = Convert.ToInt32(dgv_orders.Rows[e.RowIndex].Cells["OrderID"].Value);
                    ShowOrderDetails(orderId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void ShowOrderDetails(int orderId)
        {
            try
            {
                var items = orderItemService.GetOrderItemsByOrderId(orderId);

                if (items == null || items.Count == 0)
                {
                    MessageBox.Show("No items found for this order.", "Order Details",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                
                string details = $"Order ID: {orderId}\n";
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

                MessageBox.Show(details, $"Order #{orderId} Details",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading order details: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        public void RefreshOrders()
        {
            LoadOrders();
        }
    }
}