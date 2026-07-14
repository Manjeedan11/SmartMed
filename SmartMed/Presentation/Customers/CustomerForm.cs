using SmartMed.Business;
using SmartMed.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace SmartMed.Presentation.Customers
{
    public partial class CustomerForm : Form
    {
        private CustomerService customerService = new CustomerService();

        public CustomerForm()
        {
            InitializeComponent();
            LoadCustomers();

            dgv_customers.CellContentClick += dgv_customers_CellContentClick;
        }

        private void LoadCustomers()
        {
            try
            {
                var customers = customerService.GetAllCustomers();

                dgv_customers.DataSource = null;
                dgv_customers.Rows.Clear();
                dgv_customers.Columns.Clear();

                if (customers == null || customers.Count == 0)
                {
                    dgv_customers.Rows.Add("No customers found.");
                    return;
                }

              
                dgv_customers.Columns.Add("CustomerID", "Customer ID");
                dgv_customers.Columns.Add("FullName", "Full Name");
                dgv_customers.Columns.Add("Phone", "Phone Number");
                dgv_customers.Columns.Add("Email", "Email");
                dgv_customers.Columns.Add("Address", "Address");

                dgv_customers.Columns["CustomerID"].Width = 100;
                dgv_customers.Columns["FullName"].Width = 180;
                dgv_customers.Columns["Phone"].Width = 150;
                dgv_customers.Columns["Email"].Width = 200;
                dgv_customers.Columns["Address"].Width = 250;

                foreach (var customer in customers)
                {
                    string email = customer.User?.email ?? "N/A";
                    dgv_customers.Rows.Add(
                        customer.customerId,
                        customer.fullName,
                        customer.phoneNumber,
                        email,
                        customer.address
                    );
                }

               
                dgv_customers.AllowUserToAddRows = false;

                dgv_customers.BackgroundColor = Color.White;

                dgv_customers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dgv_customers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customers: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
        private void dgv_customers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                try
                {
                   
                    int customerId = Convert.ToInt32(dgv_customers.Rows[e.RowIndex].Cells["CustomerID"].Value);
                    MessageBox.Show($"Selected Customer ID: {customerId}", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

       
        public void RefreshCustomers()
        {
            LoadCustomers();
        }
    }
}