using SmartMed.Business;
using SmartMed.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SmartMed.Presentation.Medicines
{
    public partial class MedicineForm : Form
    {
        private MedicineService medicineService = new MedicineService();
        private List<Category> categories;
        private List<Supplier> suppliers;
        private Medicine currentMedicine = null;

        public MedicineForm()
        {
            InitializeComponent();

     
            btn_create.Click += btn_create_Click;
            btn_update.Click += btn_update_Click;
            btn_delete.Click += btn_delete_Click;

            LoadComboBoxes();
            ClearForm();
            LoadMedicines();
        }

        private void LoadComboBoxes()
        {
            try
            {
                categories = medicineService.GetAllCategories();
                var categoryItems = new List<string> { "Select Category" };
                foreach (var cat in categories)
                    categoryItems.Add(cat.CategoryName);
                cmb_category.Items = categoryItems.ToArray();
                cmb_category.SelectedIndex = 0;

                suppliers = medicineService.GetAllSuppliers();
                var supplierItems = new List<string> { "Select Supplier" };
                foreach (var sup in suppliers)
                    supplierItems.Add(sup.SupplierName);
                cmb_supplier.Items = supplierItems.ToArray();
                cmb_supplier.SelectedIndex = 0;

                string[] statusItems = { "Select Prescription Status", "Required", "Not Required" };
                cmb_prescriptionStatus.Items = statusItems;
                cmb_prescriptionStatus.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadMedicines()
        {
            try
            {
                var medicines = medicineService.GetAllMedicines();

                if (dgvMedicines == null)
                {
                    MessageBox.Show("DataGridView not initialized.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                dgvMedicines.DataSource = null;
                dgvMedicines.Rows.Clear();
                dgvMedicines.Columns.Clear();

                if (medicines == null || medicines.Count == 0)
                {
                    dgvMedicines.Rows.Add("No medicines found.");
                    return;
                }

                dgvMedicines.Columns.Add("MedicineID", "ID");
                dgvMedicines.Columns.Add("Name", "Medicine Name");
                dgvMedicines.Columns.Add("Category", "Category");
                dgvMedicines.Columns.Add("Supplier", "Supplier");
                dgvMedicines.Columns.Add("Dosage", "Dosage");
                dgvMedicines.Columns.Add("Price", "Price (LKR)");
                dgvMedicines.Columns.Add("Stock", "Stock");
                dgvMedicines.Columns.Add("Discount", "Discount %");
                dgvMedicines.Columns.Add("Expiry", "Expiry Date");
                dgvMedicines.Columns.Add("Prescription", "Prescription");

                dgvMedicines.Columns["MedicineID"].Width = 50;
                dgvMedicines.Columns["Name"].Width = 180;
                dgvMedicines.Columns["Category"].Width = 120;
                dgvMedicines.Columns["Supplier"].Width = 120;
                dgvMedicines.Columns["Dosage"].Width = 100;
                dgvMedicines.Columns["Price"].Width = 100;
                dgvMedicines.Columns["Stock"].Width = 80;
                dgvMedicines.Columns["Discount"].Width = 80;
                dgvMedicines.Columns["Expiry"].Width = 100;
                dgvMedicines.Columns["Prescription"].Width = 80;

                dgvMedicines.Columns["Price"].DefaultCellStyle.Format = "N2";
                dgvMedicines.Columns["Discount"].DefaultCellStyle.Format = "N0";
                dgvMedicines.Columns["Expiry"].DefaultCellStyle.Format = "yyyy-MM-dd";

                foreach (var med in medicines)
                {
                    dgvMedicines.Rows.Add(
                        med.MedicineID,
                        med.Name,
                        med.Category?.CategoryName ?? "N/A",
                        med.Supplier?.SupplierName ?? "N/A",
                        med.Dosage ?? "",
                        med.Price,
                        med.Stock,
                        med.Discount.HasValue ? med.Discount.Value.ToString("N0") : "",
                        med.ExpiryDate.ToString("yyyy-MM-dd"),
                        med.RequiresPrescription ? "Required" : "Not Required"
                    );
                }

                dgvMedicines.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dgvMedicines.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                if (dgvMedicines.Rows.Count > 0)
                    dgvMedicines.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading medicines: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     
        // FORM HELPERS

        private void ClearForm()
        {
            txt_medicineName.Content = "";
            cmb_category.SelectedIndex = 0;
            cmb_supplier.SelectedIndex = 0;
            txt_dosage.Content = "";
            txt_price.Content = "";
            txt_stock.Content = "";
            txt_discount.Content = "";
            dtp_expiryDate.Content = DateTime.Now.AddMonths(6);
            cmb_prescriptionStatus.SelectedIndex = 0;
            txt_imgURL.Content = "";
            currentMedicine = null;
            btn_create.Enabled = true;
            btn_update.Enabled = false;
            btn_delete.Enabled = false;

            if (dgvMedicines != null && dgvMedicines.Rows.Count > 0)
                dgvMedicines.ClearSelection();
        }

        private void LoadMedicineToForm(Medicine medicine)
        {
            if (medicine == null) return;

            txt_medicineName.Content = medicine.Name;

            int catIndex = cmb_category.Items.IndexOf(medicine.Category?.CategoryName);
            cmb_category.SelectedIndex = catIndex >= 0 ? catIndex : 0;

            int supIndex = cmb_supplier.Items.IndexOf(medicine.Supplier?.SupplierName);
            cmb_supplier.SelectedIndex = supIndex >= 0 ? supIndex : 0;

            txt_dosage.Content = medicine.Dosage;
            txt_price.Content = medicine.Price.ToString();
            txt_stock.Content = medicine.Stock.ToString();
            txt_discount.Content = medicine.Discount.HasValue ? medicine.Discount.Value.ToString() : "";
            dtp_expiryDate.Content = medicine.ExpiryDate;
            cmb_prescriptionStatus.SelectedIndex = medicine.RequiresPrescription ? 1 : 2;
            txt_imgURL.Content = medicine.ImageURL;

            currentMedicine = medicine;
            btn_create.Enabled = false;
            btn_update.Enabled = true;
            btn_delete.Enabled = true;
        }


        private int GetCategoryId()
        {
            return cmb_category.SelectedIndex > 0
                ? categories[cmb_category.SelectedIndex - 1].CategoryID
                : 0;
        }

        private int GetSupplierId()
        {
            return cmb_supplier.SelectedIndex > 0
                ? suppliers[cmb_supplier.SelectedIndex - 1].SupplierID
                : 0;
        }

        private decimal ParseDecimal(string value) => decimal.TryParse(value, out decimal result) ? result : 0;
        private int ParseInt(string value) => int.TryParse(value, out int result) ? result : 0;
        private decimal? ParseNullableDecimal(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return null;
            return decimal.TryParse(value, out decimal result) ? result : (decimal?)null;
        }

        private void SetFocusOnField(string paramName)
        {
            if (string.IsNullOrEmpty(paramName)) return;
            switch (paramName)
            {
                case nameof(Medicine.Name): txt_medicineName.Focus(); break;
                case nameof(Medicine.CategoryID): cmb_category.Focus(); break;
                case nameof(Medicine.SupplierID): cmb_supplier.Focus(); break;
                case nameof(Medicine.Price): txt_price.Focus(); break;
                case nameof(Medicine.Stock): txt_stock.Focus(); break;
                case nameof(Medicine.ExpiryDate): dtp_expiryDate.Focus(); break;
                case nameof(Medicine.Discount): txt_discount.Focus(); break;
                default: break;
            }
        }

        
        //OOP section 
        

        private void btn_create_Click(object sender, EventArgs e)
        {
            try
            {
          
                string name = txt_medicineName.Content.Trim();
                int categoryId = GetCategoryId();
                int supplierId = GetSupplierId();
                string dosage = txt_dosage.Content.Trim();
                decimal price = ParseDecimal(txt_price.Content);
                int stock = ParseInt(txt_stock.Content);
                DateTime expiryDate = dtp_expiryDate.Content;
                bool requiresPrescription = (cmb_prescriptionStatus.SelectedIndex == 1);
                decimal? discount = ParseNullableDecimal(txt_discount.Content);
                string imageURL = txt_imgURL.Content.Trim();

                Medicine medicine = new Medicine(
                    name, categoryId, supplierId, dosage,
                    price, stock, expiryDate,
                    requiresPrescription, discount, imageURL
                );

               
                medicine.Validate();

            
                int id = medicineService.CreateMedicine(medicine);

                if (id > 0)
                {
                    MessageBox.Show($"✅ Medicine '{medicine.Name}' created successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadMedicines();
                }
            }
            catch (ArgumentException ex)
            {
               
                MessageBox.Show($"⚠️ {ex.Message}", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SetFocusOnField(ex.ParamName);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentMedicine == null)
                {
                    MessageBox.Show("Please select a medicine to update.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string name = txt_medicineName.Content.Trim();
                int categoryId = GetCategoryId();
                int supplierId = GetSupplierId();
                string dosage = txt_dosage.Content.Trim();
                decimal price = ParseDecimal(txt_price.Content);
                int stock = ParseInt(txt_stock.Content);
                DateTime expiryDate = dtp_expiryDate.Content;
                bool requiresPrescription = (cmb_prescriptionStatus.SelectedIndex == 1);
                decimal? discount = ParseNullableDecimal(txt_discount.Content);
                string imageURL = txt_imgURL.Content.Trim();

            
                Medicine medicine = new Medicine(
                    name, categoryId, supplierId, dosage,
                    price, stock, expiryDate,
                    requiresPrescription, discount, imageURL
                );
                medicine.MedicineID = currentMedicine.MedicineID; 

                medicine.Validate();

                bool result = medicineService.UpdateMedicine(medicine);
                if (result)
                {
                    MessageBox.Show("✅ Medicine updated successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadMedicines();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"⚠️ {ex.Message}", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                SetFocusOnField(ex.ParamName);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentMedicine == null)
                {
                    MessageBox.Show("Please select a medicine to delete.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to delete '{currentMedicine.Name}'?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    bool deleted = medicineService.DeleteMedicine(currentMedicine.MedicineID);
                    if (deleted)
                    {
                        MessageBox.Show("✅ Medicine deleted successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                        LoadMedicines();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"❌ Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void dgvMedicines_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                int medicineId = Convert.ToInt32(dgvMedicines.Rows[e.RowIndex].Cells["MedicineID"].Value);
                Medicine medicine = medicineService.GetMedicineById(medicineId);

                if (medicine != null)
                    LoadMedicineToForm(medicine);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading medicine: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}