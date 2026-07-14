using SmartMed.Business;
using SmartMed.Models;
using SmartMed.Presentation.Customers;
using SmartMed.Presentation.Medicines;
using SmartMed.Presentation.Orders;
using SmartMed.Presentation.Reports;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SmartMed.Presentation.Dashboard
{
    public partial class AdminDashboardForm : BaseDashboardForm
    {
        private User currentUser;
        private Form currentForm;

        public AdminDashboardForm(User user)
        {
            InitializeComponent();
            currentUser = user;

            HighlightButton(btn_dashboard);
            medicineStatCard.BackColor = ColorTranslator.FromHtml("#27453F");
            customerStatCard.BackColor = ColorTranslator.FromHtml("#27453F");
            orderStatCard.BackColor = ColorTranslator.FromHtml("#27453F");
            salesStatCard.BackColor = ColorTranslator.FromHtml("#27453F");
            lb_medicines.ForeColor = ColorTranslator.FromHtml("#DDF084");
            lb_customers.ForeColor = ColorTranslator.FromHtml("#DDF084");
            lb_orders.ForeColor = ColorTranslator.FromHtml("#DDF084");
            lb_sales.ForeColor = ColorTranslator.FromHtml("#DDF084");
            txt_customersNo.ForeColor = ColorTranslator.FromHtml("#DDF084");
            txt_medicineNo.ForeColor = ColorTranslator.FromHtml("#DDF084");
            txt_ordersNo.ForeColor = ColorTranslator.FromHtml("#DDF084");
            txt_salesNo.ForeColor = ColorTranslator.FromHtml("#DDF084");

            btn_logOut.Click += logoutButton_Click;

            ShowDashboardContent();
            LoadLowStockAlert();
            LoadSalesChart();
            LoadStatistics();


        }


        private void ShowDashboardContent()
        {
            if (currentForm != null)
            {
                contentPanel.Controls.Remove(currentForm);
                currentForm.Dispose();
                currentForm = null;
            }

            medicineStatCard.Visible = true;
            customerStatCard.Visible = true;
            orderStatCard.Visible = true;
            salesStatCard.Visible = true;
            sales_chartLine.Visible = true;
            panel1.Visible = true;

            LoadLowStockAlert();
            LoadSalesChart();
            LoadStatistics();
        }

        private void LoadSalesChart()
        {
            try
            {
                var orderService = new OrderService();
                var salesData = orderService.GetLast7DaysSales();

                float[] dataPoints = salesData.Select(d => (float)d).ToArray();


                if (dataPoints.All(d => d == 0))
                {
                    sales_chartLine.DataPoints = new float[] { 0, 0, 0, 0, 0, 0, 0 };
                    sales_chartLine.MaxValue = 100;
                }
                else
                {
                    sales_chartLine.DataPoints = dataPoints;
                    sales_chartLine.MaxValue = dataPoints.Max() * 1.2f;
                }


                sales_chartLine.UsePercent = false;
            }
            catch (Exception ex)
            {

                sales_chartLine.DataPoints = new float[] { 0, 0, 0, 0, 0, 0, 0 };
                sales_chartLine.MaxValue = 100;
            }
        }



        private void HideDashboardContent()
        {
            medicineStatCard.Visible = false;
            customerStatCard.Visible = false;
            orderStatCard.Visible = false;
            salesStatCard.Visible = false;
            sales_chartLine.Visible = false;
            panel1.Visible = false;
        }

        private void ShowEmbeddedForm(Form form)
        {
            if (currentForm != null)
            {
                contentPanel.Controls.Remove(currentForm);
                currentForm.Dispose();
                currentForm = null;
            }

            HideDashboardContent();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Visible = true;

            contentPanel.Controls.Add(form);
            currentForm = form;
        }


        private void LoadLowStockAlert()
        {
            try
            {
                var medicineService = new MedicineService();
                var medicines = medicineService.GetAllMedicines();
                var lowStock = medicines.Where(m => m.Stock <= 0).ToList();

                if (lowStock.Count > 0)
                {
                    string names = string.Join(", ", lowStock.Select(m => m.Name));
                    txt_lowStockAlert.Text = $"⚠️ The following medicines are out of stock: {names}. Please refill soon!";
                    txt_lowStockAlert.ForeColor = System.Drawing.Color.Red;
                    txt_lowStockAlert.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
                }
                else
                {
                    txt_lowStockAlert.Text = "✅ All medicines are in stock.";
                    txt_lowStockAlert.ForeColor = System.Drawing.Color.Green;
                    txt_lowStockAlert.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular);
                }
            }
            catch (Exception ex)
            {
                txt_lowStockAlert.Text = "⚠️ Error loading stock alerts. Please try again.";
                txt_lowStockAlert.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void LoadStatistics()
        {
            try
            {
                var medicineService = new MedicineService();
                var customerService = new CustomerService();
                var orderService = new OrderService();


                int medicineCount = medicineService.GetMedicineCount();
                txt_medicineNo.Text = medicineCount.ToString();


                int customerCount = customerService.GetCustomerCount();
                txt_customersNo.Text = customerCount.ToString();

                int orderCount = orderService.GetOrderCount();
                txt_ordersNo.Text = orderCount.ToString();


                decimal totalSales = orderService.GetTotalSales();
                txt_salesNo.Text = $"LKR {totalSales:N2}";
            }
            catch (Exception ex)
            {

                txt_medicineNo.Text = "-";
                txt_customersNo.Text = "-";
                txt_ordersNo.Text = "-";
                txt_salesNo.Text = "-";
            }
        }

        private void contentPanel_Paint(object sender, PaintEventArgs e) { }

        private void btn_dashboard_Click_1(object sender, EventArgs e)
        {
            HighlightButton((Control)sender);
            ShowDashboardContent();
        }

        private void btn_medicines_Click_1(object sender, EventArgs e)
        {
            HighlightButton((Control)sender);
            MedicineForm medicineForm = new MedicineForm();
            ShowEmbeddedForm(medicineForm);
        }

        private void btn_customers_Click_1(object sender, EventArgs e)
        {
            HighlightButton((Control)sender);
            CustomerForm customerForm = new CustomerForm();
            ShowEmbeddedForm(customerForm);
        }

        private void btn_orders_Click_1(object sender, EventArgs e)
        {
            HighlightButton((Control)sender);
            OrderManagementForm orderForm = new OrderManagementForm();
            ShowEmbeddedForm(orderForm);

        }

        private void btn_reports_Click_1(object sender, EventArgs e)
        {
            HighlightButton((Control)sender);
            ReportForm reportForm = new ReportForm();
            ShowEmbeddedForm(reportForm);
        }

        private void logoLabel_Click(object sender, EventArgs e)
        {

        }

        private void btn_logOut_Click(object sender, EventArgs e)
        {
            Logout();
        }
    }
}