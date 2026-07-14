namespace SmartMed.Presentation.Medicines
{
    partial class BrowseMedicineForm
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
            cuiTextBox1 = new CuoreUI.Controls.cuiTextBox();
            btn_search = new CuoreUI.Controls.cuiButton();
            medicine_card = new Panel();
            txt_medicinePrice = new Label();
            btn_cart = new CuoreUI.Controls.cuiButton();
            txt_MedicineName = new Label();
            img_box = new PictureBox();
            label1 = new Label();
            medicine_card.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)img_box).BeginInit();
            SuspendLayout();
            // 
            // cuiTextBox1
            // 
            cuiTextBox1.BackgroundColor = Color.White;
            cuiTextBox1.Content = "";
            cuiTextBox1.FocusBackgroundColor = Color.White;
            cuiTextBox1.FocusImageTint = Color.White;
            cuiTextBox1.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            cuiTextBox1.Font = new Font("Microsoft YaHei UI", 9F);
            cuiTextBox1.ForeColor = Color.Gray;
            cuiTextBox1.Image = null;
            cuiTextBox1.ImageExpand = new Point(0, 0);
            cuiTextBox1.ImageOffset = new Point(0, 0);
            cuiTextBox1.Location = new Point(46, 170);
            cuiTextBox1.Margin = new Padding(4);
            cuiTextBox1.Multiline = false;
            cuiTextBox1.Name = "cuiTextBox1";
            cuiTextBox1.NormalImageTint = Color.White;
            cuiTextBox1.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            cuiTextBox1.Padding = new Padding(20, 10, 20, 0);
            cuiTextBox1.PasswordChar = false;
            cuiTextBox1.PlaceholderColor = Color.LightGray;
            cuiTextBox1.PlaceholderText = "Search medicines...";
            cuiTextBox1.Rounding = new Padding(8);
            cuiTextBox1.Size = new Size(758, 41);
            cuiTextBox1.TabIndex = 0;
            cuiTextBox1.TextOffset = new Size(0, 0);
            cuiTextBox1.UnderlinedStyle = true;
            // 
            // btn_search
            // 
            btn_search.CheckButton = false;
            btn_search.Checked = false;
            btn_search.CheckedBackground = Color.FromArgb(255, 106, 0);
            btn_search.CheckedForeColor = Color.White;
            btn_search.CheckedImageTint = Color.White;
            btn_search.CheckedOutline = Color.FromArgb(255, 106, 0);
            btn_search.Content = "Search";
            btn_search.DialogResult = DialogResult.None;
            btn_search.Font = new Font("Microsoft Sans Serif", 10.8F);
            btn_search.ForeColor = Color.Black;
            btn_search.HoverBackground = Color.White;
            btn_search.HoverForeColor = Color.DimGray;
            btn_search.HoverImageTint = Color.DimGray;
            btn_search.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btn_search.Image = null;
            btn_search.ImageExpand = new Point(0, 0);
            btn_search.Location = new Point(816, 170);
            btn_search.Name = "btn_search";
            btn_search.NormalBackground = Color.White;
            btn_search.NormalForeColor = Color.Black;
            btn_search.NormalImageTint = Color.Black;
            btn_search.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btn_search.OutlineThickness = 1F;
            btn_search.Padding = new Padding(12);
            btn_search.PressedBackground = Color.WhiteSmoke;
            btn_search.PressedForeColor = Color.FromArgb(32, 32, 32);
            btn_search.PressedImageTint = Color.FromArgb(32, 32, 32);
            btn_search.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btn_search.Rounding = new Padding(20);
            btn_search.Size = new Size(100, 41);
            btn_search.TabIndex = 1;
            btn_search.TextAlignment = StringAlignment.Center;
            btn_search.TextPadding = 12;
            btn_search.TextSpacing = 2;
            // 
            // medicine_card
            // 
            medicine_card.BorderStyle = BorderStyle.FixedSingle;
            medicine_card.Controls.Add(txt_medicinePrice);
            medicine_card.Controls.Add(btn_cart);
            medicine_card.Controls.Add(txt_MedicineName);
            medicine_card.Controls.Add(img_box);
            medicine_card.Location = new Point(46, 251);
            medicine_card.Name = "medicine_card";
            medicine_card.Size = new Size(286, 304);
            medicine_card.TabIndex = 2;
            // 
            // txt_medicinePrice
            // 
            txt_medicinePrice.AutoSize = true;
            txt_medicinePrice.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            txt_medicinePrice.Location = new Point(10, 231);
            txt_medicinePrice.Name = "txt_medicinePrice";
            txt_medicinePrice.Size = new Size(42, 20);
            txt_medicinePrice.TabIndex = 9;
            txt_medicinePrice.Text = "label";
            // 
            // btn_cart
            // 
            btn_cart.CheckButton = false;
            btn_cart.Checked = false;
            btn_cart.CheckedBackground = Color.FromArgb(255, 106, 0);
            btn_cart.CheckedForeColor = Color.White;
            btn_cart.CheckedImageTint = Color.White;
            btn_cart.CheckedOutline = Color.FromArgb(255, 106, 0);
            btn_cart.Content = "Add to Cart";
            btn_cart.DialogResult = DialogResult.None;
            btn_cart.Font = new Font("Microsoft Sans Serif", 9F);
            btn_cart.ForeColor = Color.Black;
            btn_cart.HoverBackground = Color.White;
            btn_cart.HoverForeColor = Color.DimGray;
            btn_cart.HoverImageTint = Color.DimGray;
            btn_cart.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btn_cart.Image = null;
            btn_cart.ImageExpand = new Point(0, 0);
            btn_cart.Location = new Point(10, 254);
            btn_cart.Name = "btn_cart";
            btn_cart.NormalBackground = Color.White;
            btn_cart.NormalForeColor = Color.Black;
            btn_cart.NormalImageTint = Color.Black;
            btn_cart.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btn_cart.OutlineThickness = 1F;
            btn_cart.Padding = new Padding(12);
            btn_cart.PressedBackground = Color.WhiteSmoke;
            btn_cart.PressedForeColor = Color.FromArgb(32, 32, 32);
            btn_cart.PressedImageTint = Color.FromArgb(32, 32, 32);
            btn_cart.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btn_cart.Rounding = new Padding(20);
            btn_cart.Size = new Size(97, 35);
            btn_cart.TabIndex = 8;
            btn_cart.TextAlignment = StringAlignment.Center;
            btn_cart.TextPadding = 12;
            btn_cart.TextSpacing = 2;
            // 
            // txt_MedicineName
            // 
            txt_MedicineName.AutoSize = true;
            txt_MedicineName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            txt_MedicineName.Location = new Point(10, 203);
            txt_MedicineName.Name = "txt_MedicineName";
            txt_MedicineName.Size = new Size(70, 28);
            txt_MedicineName.TabIndex = 1;
            txt_MedicineName.Text = "label1";
            // 
            // img_box
            // 
            img_box.Location = new Point(10, 14);
            img_box.Name = "img_box";
            img_box.Size = new Size(266, 177);
            img_box.TabIndex = 0;
            img_box.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 52);
            label1.Name = "label1";
            label1.Size = new Size(286, 50);
            label1.TabIndex = 10;
            label1.Text = "Browse Medicines";
            // 
            // BrowseMedicineForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 700);
            Controls.Add(label1);
            Controls.Add(medicine_card);
            Controls.Add(btn_search);
            Controls.Add(cuiTextBox1);
            Name = "BrowseMedicineForm";
            Text = "Browse Medicines";
            medicine_card.ResumeLayout(false);
            medicine_card.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)img_box).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        // ----- DECLARATIONS -----
        private CuoreUI.Controls.cuiTextBox cuiTextBox1;
        private CuoreUI.Controls.cuiButton btn_search;
        private System.Windows.Forms.Panel medicine_card;
        private System.Windows.Forms.Label txt_MedicineName;
        private System.Windows.Forms.PictureBox img_box;
        private CuoreUI.Controls.cuiButton btn_cart;
        private System.Windows.Forms.Label txt_medicinePrice;
        private Label label1;
    }
}