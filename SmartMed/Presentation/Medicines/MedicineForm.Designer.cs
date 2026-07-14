namespace SmartMed.Presentation.Medicines
{
    partial class MedicineForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicineForm));
            panel1 = new Panel();
            txt_discount = new CuoreUI.Controls.cuiTextBox();
            txt_medicineName = new CuoreUI.Controls.cuiTextBox();
            btn_delete = new CuoreUI.Controls.cuiButton();
            cmb_prescriptionStatus = new CuoreUI.Controls.cuiComboBox();
            txt_dosage = new CuoreUI.Controls.cuiTextBox();
            txt_stock = new CuoreUI.Controls.cuiTextBox();
            cmb_category = new CuoreUI.Controls.cuiComboBox();
            btn_update = new CuoreUI.Controls.cuiButton();
            btn_create = new CuoreUI.Controls.cuiButton();
            txt_imgURL = new CuoreUI.Controls.cuiTextBox();
            dtp_expiryDate = new CuoreUI.Controls.cuiCalendarDatePicker();
            txt_price = new CuoreUI.Controls.cuiTextBox();
            cmb_supplier = new CuoreUI.Controls.cuiComboBox();
            label2 = new Label();
            dgvMedicines = new DataGridView();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMedicines).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txt_discount);
            panel1.Controls.Add(txt_medicineName);
            panel1.Controls.Add(btn_delete);
            panel1.Controls.Add(cmb_prescriptionStatus);
            panel1.Controls.Add(txt_dosage);
            panel1.Controls.Add(txt_stock);
            panel1.Controls.Add(cmb_category);
            panel1.Controls.Add(btn_update);
            panel1.Controls.Add(btn_create);
            panel1.Controls.Add(txt_imgURL);
            panel1.Controls.Add(dtp_expiryDate);
            panel1.Controls.Add(txt_price);
            panel1.Controls.Add(cmb_supplier);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(68, 124);
            panel1.Name = "panel1";
            panel1.Size = new Size(791, 574);
            panel1.TabIndex = 0;
            // 
            // txt_discount
            // 
            txt_discount.BackgroundColor = Color.White;
            txt_discount.Content = "";
            txt_discount.FocusBackgroundColor = Color.White;
            txt_discount.FocusImageTint = Color.White;
            txt_discount.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            txt_discount.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_discount.ForeColor = Color.Gray;
            txt_discount.Image = null;
            txt_discount.ImageExpand = new Point(0, 0);
            txt_discount.ImageOffset = new Point(0, 0);
            txt_discount.Location = new Point(28, 411);
            txt_discount.Margin = new Padding(4);
            txt_discount.Multiline = false;
            txt_discount.Name = "txt_discount";
            txt_discount.NormalImageTint = Color.White;
            txt_discount.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txt_discount.Padding = new Padding(20, 8, 20, 0);
            txt_discount.PasswordChar = false;
            txt_discount.PlaceholderColor = Color.LightGray;
            txt_discount.PlaceholderText = "Enter Discount Rate";
            txt_discount.Rounding = new Padding(8);
            txt_discount.Size = new Size(345, 36);
            txt_discount.TabIndex = 14;
            txt_discount.TextOffset = new Size(0, 0);
            txt_discount.UnderlinedStyle = true;
            // 
            // txt_medicineName
            // 
            txt_medicineName.BackgroundColor = Color.White;
            txt_medicineName.Content = "";
            txt_medicineName.FocusBackgroundColor = Color.White;
            txt_medicineName.FocusImageTint = Color.White;
            txt_medicineName.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            txt_medicineName.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_medicineName.ForeColor = Color.Gray;
            txt_medicineName.Image = null;
            txt_medicineName.ImageExpand = new Point(0, 0);
            txt_medicineName.ImageOffset = new Point(0, 0);
            txt_medicineName.Location = new Point(23, 79);
            txt_medicineName.Margin = new Padding(4);
            txt_medicineName.Multiline = false;
            txt_medicineName.Name = "txt_medicineName";
            txt_medicineName.NormalImageTint = Color.White;
            txt_medicineName.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txt_medicineName.Padding = new Padding(20, 8, 20, 0);
            txt_medicineName.PasswordChar = false;
            txt_medicineName.PlaceholderColor = Color.LightGray;
            txt_medicineName.PlaceholderText = "Enter Medicine Name";
            txt_medicineName.Rounding = new Padding(8);
            txt_medicineName.Size = new Size(345, 36);
            txt_medicineName.TabIndex = 13;
            txt_medicineName.TextOffset = new Size(0, 0);
            txt_medicineName.UnderlinedStyle = true;
            // 
            // btn_delete
            // 
            btn_delete.CheckButton = false;
            btn_delete.Checked = false;
            btn_delete.CheckedBackground = Color.FromArgb(255, 106, 0);
            btn_delete.CheckedForeColor = Color.White;
            btn_delete.CheckedImageTint = Color.White;
            btn_delete.CheckedOutline = Color.FromArgb(255, 106, 0);
            btn_delete.Content = "Delete";
            btn_delete.DialogResult = DialogResult.None;
            btn_delete.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_delete.ForeColor = Color.Black;
            btn_delete.HoverBackground = Color.White;
            btn_delete.HoverForeColor = Color.DimGray;
            btn_delete.HoverImageTint = Color.DimGray;
            btn_delete.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btn_delete.Image = null;
            btn_delete.ImageExpand = new Point(0, 0);
            btn_delete.Location = new Point(495, 504);
            btn_delete.Name = "btn_delete";
            btn_delete.NormalBackground = Color.White;
            btn_delete.NormalForeColor = Color.Black;
            btn_delete.NormalImageTint = Color.Black;
            btn_delete.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btn_delete.OutlineThickness = 1F;
            btn_delete.Padding = new Padding(12);
            btn_delete.PressedBackground = Color.WhiteSmoke;
            btn_delete.PressedForeColor = Color.FromArgb(32, 32, 32);
            btn_delete.PressedImageTint = Color.FromArgb(32, 32, 32);
            btn_delete.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btn_delete.Rounding = new Padding(20);
            btn_delete.Size = new Size(101, 47);
            btn_delete.TabIndex = 12;
            btn_delete.TextAlignment = StringAlignment.Center;
            btn_delete.TextPadding = 12;
            btn_delete.TextSpacing = 2;
            btn_delete.Click += btn_delete_Click;
            // 
            // cmb_prescriptionStatus
            // 
            cmb_prescriptionStatus.BackgroundColor = Color.FromArgb(255, 255, 255);
            cmb_prescriptionStatus.DropDownBackgroundColor = Color.White;
            cmb_prescriptionStatus.DropDownForeColor = Color.FromArgb(27, 27, 27);
            cmb_prescriptionStatus.ExpandArrowColor = Color.Gray;
            cmb_prescriptionStatus.ForeColor = Color.Gray;
            cmb_prescriptionStatus.Items = new string[]
            {
                "Item 1",
                "Item 2",
                "Item 3"
            };
            cmb_prescriptionStatus.Location = new Point(420, 331);
            cmb_prescriptionStatus.Margin = new Padding(4, 5, 4, 5);
            cmb_prescriptionStatus.MaxDropDownHeight = 240;
            cmb_prescriptionStatus.Name = "cmb_prescriptionStatus";
            cmb_prescriptionStatus.NoSelectionText = "Select Prescription Status";
            cmb_prescriptionStatus.OutlineColor = Color.FromArgb(64, 128, 128, 128);
            cmb_prescriptionStatus.OutlineThickness = 1F;
            cmb_prescriptionStatus.Rounding = 8;
            cmb_prescriptionStatus.SelectedIndex = -1;
            cmb_prescriptionStatus.SelectedItem = "";
            cmb_prescriptionStatus.Size = new Size(345, 36);
            cmb_prescriptionStatus.SortAlphabetically = true;
            cmb_prescriptionStatus.TabIndex = 8;
            // 
            // txt_dosage
            // 
            txt_dosage.BackgroundColor = Color.White;
            txt_dosage.Content = "";
            txt_dosage.FocusBackgroundColor = Color.White;
            txt_dosage.FocusImageTint = Color.White;
            txt_dosage.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            txt_dosage.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_dosage.ForeColor = Color.Gray;
            txt_dosage.Image = null;
            txt_dosage.ImageExpand = new Point(0, 0);
            txt_dosage.ImageOffset = new Point(0, 0);
            txt_dosage.Location = new Point(420, 158);
            txt_dosage.Margin = new Padding(4);
            txt_dosage.Multiline = false;
            txt_dosage.Name = "txt_dosage";
            txt_dosage.NormalImageTint = Color.White;
            txt_dosage.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txt_dosage.Padding = new Padding(20, 8, 20, 0);
            txt_dosage.PasswordChar = false;
            txt_dosage.PlaceholderColor = Color.LightGray;
            txt_dosage.PlaceholderText = "Enter Dosage";
            txt_dosage.Rounding = new Padding(8);
            txt_dosage.Size = new Size(345, 36);
            txt_dosage.TabIndex = 2;
            txt_dosage.TextOffset = new Size(0, 0);
            txt_dosage.UnderlinedStyle = true;
            // 
            // txt_stock
            // 
            txt_stock.BackgroundColor = Color.White;
            txt_stock.Content = "";
            txt_stock.FocusBackgroundColor = Color.White;
            txt_stock.FocusImageTint = Color.White;
            txt_stock.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            txt_stock.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_stock.ForeColor = Color.Gray;
            txt_stock.Image = null;
            txt_stock.ImageExpand = new Point(0, 0);
            txt_stock.ImageOffset = new Point(0, 0);
            txt_stock.Location = new Point(420, 246);
            txt_stock.Margin = new Padding(4);
            txt_stock.Multiline = false;
            txt_stock.Name = "txt_stock";
            txt_stock.NormalImageTint = Color.White;
            txt_stock.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txt_stock.Padding = new Padding(20, 8, 20, 0);
            txt_stock.PasswordChar = false;
            txt_stock.PlaceholderColor = Color.LightGray;
            txt_stock.PlaceholderText = "Enter Available Stock";
            txt_stock.Rounding = new Padding(8);
            txt_stock.Size = new Size(345, 36);
            txt_stock.TabIndex = 6;
            txt_stock.TextOffset = new Size(0, 0);
            txt_stock.UnderlinedStyle = true;
            // 
            // cmb_category
            // 
            cmb_category.BackgroundColor = Color.FromArgb(255, 255, 255);
            cmb_category.BackgroundImageLayout = ImageLayout.None;
            cmb_category.DropDownBackgroundColor = Color.White;
            cmb_category.DropDownForeColor = Color.FromArgb(27, 27, 27);
            cmb_category.ExpandArrowColor = Color.Gray;
            cmb_category.ForeColor = Color.Gray;
            cmb_category.Items = new string[]
            {
                "Item 1",
                "Item 2",
                "Item 3"
            };
            cmb_category.Location = new Point(420, 79);
            cmb_category.Margin = new Padding(4, 5, 4, 5);
            cmb_category.MaxDropDownHeight = 240;
            cmb_category.Name = "cmb_category";
            cmb_category.NoSelectionText = "Select Category";
            cmb_category.OutlineColor = Color.FromArgb(64, 128, 128, 128);
            cmb_category.OutlineThickness = 1F;
            cmb_category.Rounding = 8;
            cmb_category.SelectedIndex = -1;
            cmb_category.SelectedItem = "";
            cmb_category.Size = new Size(345, 36);
            cmb_category.SortAlphabetically = true;
            cmb_category.TabIndex = 4;
            // 
            // btn_update
            // 
            btn_update.CheckButton = false;
            btn_update.Checked = false;
            btn_update.CheckedBackground = Color.FromArgb(255, 106, 0);
            btn_update.CheckedForeColor = Color.White;
            btn_update.CheckedImageTint = Color.White;
            btn_update.CheckedOutline = Color.FromArgb(255, 106, 0);
            btn_update.Content = "Update";
            btn_update.DialogResult = DialogResult.None;
            btn_update.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_update.ForeColor = Color.Black;
            btn_update.HoverBackground = Color.White;
            btn_update.HoverForeColor = Color.DimGray;
            btn_update.HoverImageTint = Color.DimGray;
            btn_update.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btn_update.Image = null;
            btn_update.ImageExpand = new Point(0, 0);
            btn_update.Location = new Point(346, 504);
            btn_update.Name = "btn_update";
            btn_update.NormalBackground = Color.White;
            btn_update.NormalForeColor = Color.Black;
            btn_update.NormalImageTint = Color.Black;
            btn_update.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btn_update.OutlineThickness = 1F;
            btn_update.Padding = new Padding(12);
            btn_update.PressedBackground = Color.WhiteSmoke;
            btn_update.PressedForeColor = Color.FromArgb(32, 32, 32);
            btn_update.PressedImageTint = Color.FromArgb(32, 32, 32);
            btn_update.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btn_update.Rounding = new Padding(20);
            btn_update.Size = new Size(101, 47);
            btn_update.TabIndex = 11;
            btn_update.TextAlignment = StringAlignment.Center;
            btn_update.TextPadding = 12;
            btn_update.TextSpacing = 2;
            btn_update.Click += btn_update_Click;
            // 
            // btn_create
            // 
            btn_create.CheckButton = false;
            btn_create.Checked = false;
            btn_create.CheckedBackground = Color.FromArgb(255, 106, 0);
            btn_create.CheckedForeColor = Color.White;
            btn_create.CheckedImageTint = Color.White;
            btn_create.CheckedOutline = Color.FromArgb(255, 106, 0);
            btn_create.Content = "Create";
            btn_create.DialogResult = DialogResult.None;
            btn_create.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_create.ForeColor = Color.Black;
            btn_create.HoverBackground = Color.White;
            btn_create.HoverForeColor = Color.DimGray;
            btn_create.HoverImageTint = Color.DimGray;
            btn_create.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btn_create.Image = null;
            btn_create.ImageExpand = new Point(0, 0);
            btn_create.Location = new Point(201, 504);
            btn_create.Name = "btn_create";
            btn_create.NormalBackground = Color.White;
            btn_create.NormalForeColor = Color.Black;
            btn_create.NormalImageTint = Color.Black;
            btn_create.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btn_create.OutlineThickness = 1F;
            btn_create.Padding = new Padding(12);
            btn_create.PressedBackground = Color.WhiteSmoke;
            btn_create.PressedForeColor = Color.FromArgb(32, 32, 32);
            btn_create.PressedImageTint = Color.FromArgb(32, 32, 32);
            btn_create.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btn_create.Rounding = new Padding(20);
            btn_create.Size = new Size(101, 47);
            btn_create.TabIndex = 10;
            btn_create.TextAlignment = StringAlignment.Center;
            btn_create.TextPadding = 12;
            btn_create.TextSpacing = 2;
            btn_create.Click += btn_create_Click;
            // 
            // txt_imgURL
            // 
            txt_imgURL.BackgroundColor = Color.White;
            txt_imgURL.Content = "";
            txt_imgURL.FocusBackgroundColor = Color.White;
            txt_imgURL.FocusImageTint = Color.White;
            txt_imgURL.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            txt_imgURL.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_imgURL.ForeColor = Color.Gray;
            txt_imgURL.Image = null;
            txt_imgURL.ImageExpand = new Point(0, 0);
            txt_imgURL.ImageOffset = new Point(0, 0);
            txt_imgURL.Location = new Point(425, 411);
            txt_imgURL.Margin = new Padding(4);
            txt_imgURL.Multiline = false;
            txt_imgURL.Name = "txt_imgURL";
            txt_imgURL.NormalImageTint = Color.White;
            txt_imgURL.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txt_imgURL.Padding = new Padding(20, 8, 20, 0);
            txt_imgURL.PasswordChar = false;
            txt_imgURL.PlaceholderColor = Color.LightGray;
            txt_imgURL.PlaceholderText = "Enter Image URL";
            txt_imgURL.Rounding = new Padding(8);
            txt_imgURL.Size = new Size(345, 36);
            txt_imgURL.TabIndex = 9;
            txt_imgURL.TextOffset = new Size(0, 0);
            txt_imgURL.UnderlinedStyle = true;
            // 
            // dtp_expiryDate
            // 
            dtp_expiryDate.Content = new DateTime(2026, 7, 2, 0, 0, 0, 0);
            dtp_expiryDate.EnableThemeChangeButton = true;
            dtp_expiryDate.Font = new Font("Segoe UI", 9.75F);
            dtp_expiryDate.ForeColor = Color.Gray;
            dtp_expiryDate.HoverBackground = Color.FromArgb(50, 128, 128, 128);
            dtp_expiryDate.HoverOutline = Color.FromArgb(180, 128, 128, 128);
            dtp_expiryDate.Icon = (Image)resources.GetObject("dtp_expiryDate.Icon");
            dtp_expiryDate.IconTint = Color.Gray;
            dtp_expiryDate.Location = new Point(28, 331);
            dtp_expiryDate.Margin = new Padding(4, 5, 4, 5);
            dtp_expiryDate.Name = "dtp_expiryDate";
            dtp_expiryDate.NormalBackground = Color.FromArgb(32, 128, 128, 128);
            dtp_expiryDate.NormalOutline = Color.FromArgb(150, 128, 128, 128);
            dtp_expiryDate.OutlineThickness = 1.5F;
            dtp_expiryDate.PickerPosition = CuoreUI.Controls.cuiCalendarDatePicker.Position.Bottom;
            dtp_expiryDate.PressedBackground = Color.FromArgb(80, 128, 128, 128);
            dtp_expiryDate.PressedOutline = Color.FromArgb(210, 128, 128, 128);
            dtp_expiryDate.Rounding = 8;
            dtp_expiryDate.ShowIcon = true;
            dtp_expiryDate.Size = new Size(345, 36);
            dtp_expiryDate.TabIndex = 7;
            dtp_expiryDate.Theme = CuoreUI.Controls.Forms.DatePicker.Themes.Light;
            // 
            // txt_price
            // 
            txt_price.BackgroundColor = Color.White;
            txt_price.Content = "";
            txt_price.FocusBackgroundColor = Color.White;
            txt_price.FocusImageTint = Color.White;
            txt_price.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            txt_price.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_price.ForeColor = Color.Gray;
            txt_price.Image = null;
            txt_price.ImageExpand = new Point(0, 0);
            txt_price.ImageOffset = new Point(0, 0);
            txt_price.Location = new Point(28, 246);
            txt_price.Margin = new Padding(4);
            txt_price.Multiline = false;
            txt_price.Name = "txt_price";
            txt_price.NormalImageTint = Color.White;
            txt_price.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txt_price.Padding = new Padding(20, 8, 20, 0);
            txt_price.PasswordChar = false;
            txt_price.PlaceholderColor = Color.LightGray;
            txt_price.PlaceholderText = "Enter Price";
            txt_price.Rounding = new Padding(8);
            txt_price.Size = new Size(345, 36);
            txt_price.TabIndex = 5;
            txt_price.TextOffset = new Size(0, 0);
            txt_price.UnderlinedStyle = true;
            // 
            // cmb_supplier
            // 
            cmb_supplier.BackgroundColor = Color.FromArgb(255, 255, 255);
            cmb_supplier.DropDownBackgroundColor = Color.White;
            cmb_supplier.DropDownForeColor = Color.FromArgb(27, 27, 27);
            cmb_supplier.ExpandArrowColor = Color.Gray;
            cmb_supplier.ForeColor = Color.Gray;
            cmb_supplier.Items = new string[]
            {
                "Item 1",
                "Item 2",
                "Item 3"
            };
            cmb_supplier.Location = new Point(28, 158);
            cmb_supplier.Margin = new Padding(4, 5, 4, 5);
            cmb_supplier.MaxDropDownHeight = 240;
            cmb_supplier.Name = "cmb_supplier";
            cmb_supplier.NoSelectionText = "Select Supplier";
            cmb_supplier.OutlineColor = Color.FromArgb(64, 128, 128, 128);
            cmb_supplier.OutlineThickness = 1F;
            cmb_supplier.Rounding = 8;
            cmb_supplier.SelectedIndex = -1;
            cmb_supplier.SelectedItem = "";
            cmb_supplier.Size = new Size(345, 36);
            cmb_supplier.SortAlphabetically = true;
            cmb_supplier.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 21);
            label2.Name = "label2";
            label2.Size = new Size(182, 31);
            label2.TabIndex = 0;
            label2.Text = "Create Medicine";
            // 
            // dgvMedicines
            // 
            dgvMedicines.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMedicines.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedicines.Location = new Point(68, 731);
            dgvMedicines.Name = "dgvMedicines";
            dgvMedicines.RowHeadersWidth = 51;
            dgvMedicines.Size = new Size(1492, 265);
            dgvMedicines.TabIndex = 2;
            dgvMedicines.CellContentClick += dgvMedicines_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(68, 44);
            label1.Name = "label1";
            label1.Size = new Size(270, 41);
            label1.TabIndex = 1;
            label1.Text = "Manage Medicine";
            // 
            // MedicineForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(dgvMedicines);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "MedicineForm";
            Text = "SmartMed - Manage Medicines";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMedicines).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        // ----- DECLARATIONS -----
        private Label label1;
        private Panel panel1;
        private Label label2;
        private CuoreUI.Controls.cuiComboBox cmb_prescriptionStatus;
        private CuoreUI.Controls.cuiCalendarDatePicker dtp_expiryDate;
        private CuoreUI.Controls.cuiTextBox txt_stock;
        private CuoreUI.Controls.cuiTextBox txt_price;
        private CuoreUI.Controls.cuiComboBox cmb_category;
        private CuoreUI.Controls.cuiComboBox cmb_supplier;
        private CuoreUI.Controls.cuiTextBox txt_dosage;
        private CuoreUI.Controls.cuiTextBox txt_imgURL;
        private CuoreUI.Controls.cuiButton btn_delete;
        private CuoreUI.Controls.cuiButton btn_update;
        private CuoreUI.Controls.cuiButton btn_create;
        private CuoreUI.Controls.cuiTextBox txt_medicineName;
        private CuoreUI.Controls.cuiTextBox txt_discount;
        private DataGridView dgvMedicines;
    }
}