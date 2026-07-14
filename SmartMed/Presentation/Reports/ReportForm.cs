using SmartMed.Business;
using SmartMed.Models;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace SmartMed.Presentation.Reports
{
    public partial class ReportForm : Form
    {
        private DataTable currentDataTable;

        public ReportForm()
        {
            InitializeComponent();

           
            cmb_report.Items = new string[]
            {
                "Sales Report",
                "Stock Report",
                "Customer Order History"
            };
            cmb_report.NoSelectionText = "Select Report Type";
            cmb_report.SelectedIndex = -1;

           
            cmb_report.SelectedIndexChanged += cmb_report_SelectedIndexChanged;
            btn_exportPDF.Click += btn_exportPDF_Click;
            btn_exportCSV.Click += btn_exportCSV_Click;

            
            dgv_reports.DataSource = null;
        }

       

        private void cmb_report_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cmb_report.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selected))
                return;

            try
            {
                switch (selected)
                {
                    case "Sales Report":
                        currentDataTable = GenerateSalesReport();
                        break;
                    case "Stock Report":
                        currentDataTable = GenerateStockReport();
                        break;
                    case "Customer Order History":
                        currentDataTable = GenerateCustomerOrderHistory();
                        break;
                    default:
                        currentDataTable = null;
                        break;
                }

                dgv_reports.DataSource = null;
                if (currentDataTable != null && currentDataTable.Rows.Count > 0)
                {
                    dgv_reports.DataSource = currentDataTable;
                    dgv_reports.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
                else
                {
                    
                    DataTable empty = new DataTable();
                    empty.Columns.Add("No data available");
                    empty.Rows.Add("Please check your database.");
                    dgv_reports.DataSource = empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating report: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable GenerateSalesReport()
        {
            var orderService = new OrderService();
            var orders = orderService.GetAllOrders();

            DataTable dt = new DataTable();
            dt.Columns.Add("Order ID", typeof(int));
            dt.Columns.Add("Order Date", typeof(DateTime));
            dt.Columns.Add("Customer", typeof(string));
            dt.Columns.Add("Total Amount", typeof(decimal));
            dt.Columns.Add("Status", typeof(string));

            foreach (var order in orders)
            {
                string customerName = "Unknown";
                if (order.Customer != null)
                {
                    customerName = order.Customer.fullName;
                }
                else
                {
                   
                    var customerService = new CustomerService();
                    var cust = customerService.GetCustomerById(order.CustomerID);
                    if (cust != null)
                        customerName = cust.fullName;
                }

                dt.Rows.Add(
                    order.OrderID,
                    order.OrderDate,
                    customerName,
                    order.Total,
                    order.Status
                );
            }
            return dt;
        }

        private DataTable GenerateStockReport()
        {
            var medicineService = new MedicineService();
            var medicines = medicineService.GetAllMedicines();

            DataTable dt = new DataTable();
            dt.Columns.Add("Medicine ID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Category", typeof(string));
            dt.Columns.Add("Supplier", typeof(string));
            dt.Columns.Add("Price", typeof(decimal));
            dt.Columns.Add("Stock", typeof(int));
            dt.Columns.Add("Status", typeof(string));

            foreach (var med in medicines)
            {
                string status = med.Stock > 10 ? "In Stock" :
                                med.Stock > 0 ? "Low Stock" : "Out of Stock";

                dt.Rows.Add(
                    med.MedicineID,
                    med.Name,
                    med.Category?.CategoryName ?? "N/A",
                    med.Supplier?.SupplierName ?? "N/A",
                    med.Price,
                    med.Stock,
                    status
                );
            }
            return dt;
        }

        private DataTable GenerateCustomerOrderHistory()
        {
            var customerService = new CustomerService();
            var orderService = new OrderService();
            var customers = customerService.GetAllCustomers();

            DataTable dt = new DataTable();
            dt.Columns.Add("Customer ID", typeof(int));
            dt.Columns.Add("Customer Name", typeof(string));
            dt.Columns.Add("Total Orders", typeof(int));
            dt.Columns.Add("Total Spent", typeof(decimal));

            foreach (var cust in customers)
            {
                var orders = orderService.GetOrdersByCustomer(cust.customerId);
                int totalOrders = orders.Count;
                decimal totalSpent = orders.Sum(o => o.Total);

                dt.Rows.Add(
                    cust.customerId,
                    cust.fullName,
                    totalOrders,
                    totalSpent
                );
            }
            return dt;
        }

     

        private void btn_exportPDF_Click(object sender, EventArgs e)
        {
            if (currentDataTable == null || currentDataTable.Rows.Count == 0)
            {
                MessageBox.Show("No data to export. Please generate a report first.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF files (*.pdf)|*.pdf";
                sfd.DefaultExt = "pdf";
                sfd.FileName = $"Report_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ExportToPDF(currentDataTable, sfd.FileName);
                        MessageBox.Show("PDF exported successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error exporting PDF: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btn_exportCSV_Click(object sender, EventArgs e)
        {
            if (currentDataTable == null || currentDataTable.Rows.Count == 0)
            {
                MessageBox.Show("No data to export. Please generate a report first.", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "CSV files (*.csv)|*.csv";
                sfd.DefaultExt = "csv";
                sfd.FileName = $"Report_{DateTime.Now:yyyyMMdd_HHmmss}.csv";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ExportToCSV(currentDataTable, sfd.FileName);
                        MessageBox.Show("CSV exported successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error exporting CSV: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        

        private void ExportToPDF(DataTable dt, string filePath)
        {
            Document doc = new Document(PageSize.A4.Rotate());
            PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
            doc.Open();

            
            doc.Add(new Paragraph($"Report - {cmb_report.SelectedItem}", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18)));
            doc.Add(new Paragraph($"Generated on: {DateTime.Now}", FontFactory.GetFont(FontFactory.HELVETICA, 12)));
            doc.Add(new Paragraph(" "));

           
            PdfPTable table = new PdfPTable(dt.Columns.Count);
            table.WidthPercentage = 100;

            
            foreach (DataColumn col in dt.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(col.ColumnName, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10)));
                cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
            }

           
            foreach (DataRow row in dt.Rows)
            {
                foreach (object item in row.ItemArray)
                {
                    table.AddCell(new Phrase(item?.ToString() ?? "", FontFactory.GetFont(FontFactory.HELVETICA, 9)));
                }
            }

            doc.Add(table);
            doc.Close();
        }

        private void ExportToCSV(DataTable dt, string filePath)
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    sw.Write(dt.Columns[i].ColumnName);
                    if (i < dt.Columns.Count - 1)
                        sw.Write(",");
                }
                sw.WriteLine();

               
                foreach (DataRow row in dt.Rows)
                {
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        string value = row[i]?.ToString() ?? "";
                        if (value.Contains(",") || value.Contains("\""))
                            value = $"\"{value.Replace("\"", "\"\"")}\"";
                        sw.Write(value);
                        if (i < dt.Columns.Count - 1)
                            sw.Write(",");
                    }
                    sw.WriteLine();
                }
            }
        }
    }
}