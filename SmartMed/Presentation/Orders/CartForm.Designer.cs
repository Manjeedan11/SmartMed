namespace SmartMed.Presentation.Orders
{
    partial class CartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartForm));
            cart_container = new Panel();
            cart_ScrollBar = new VScrollBar();
            cart_card = new Panel();
            cart_qtyCard = new Panel();
            btn_qtyDecrease = new CuoreUI.Controls.cuiButton();
            btn_qtyIncrease = new CuoreUI.Controls.cuiButton();
            txt_qty = new Label();
            imgPrescription_dropper = new CuoreUI.Controls.cuiFileDropper();
            btn_cartDelete = new CuoreUI.Controls.cuiButton();
            txt_medicinePrice = new Label();
            txt_medicineName = new Label();
            img_box = new PictureBox();
            orderSummary_container = new Panel();
            btn_placeOrder = new CuoreUI.Controls.cuiButton();
            fg_total = new Label();
            txt_total = new Label();
            cuiSeparator1 = new CuoreUI.Controls.cuiSeparator();
            fg_discount = new Label();
            fg_subTotal = new Label();
            txt_discount = new Label();
            txt_subTotal = new Label();
            txt_orderSummary = new Label();
            label1 = new Label();
            cart_container.SuspendLayout();
            cart_card.SuspendLayout();
            cart_qtyCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)img_box).BeginInit();
            orderSummary_container.SuspendLayout();
            SuspendLayout();
            // 
            // cart_container
            // 
            cart_container.BorderStyle = BorderStyle.FixedSingle;
            cart_container.Controls.Add(cart_ScrollBar);
            cart_container.Controls.Add(cart_card);
            cart_container.Location = new Point(118, 202);
            cart_container.Name = "cart_container";
            cart_container.Size = new Size(900, 500);
            cart_container.TabIndex = 0;
            // 
            // cart_ScrollBar
            // 
            cart_ScrollBar.Location = new Point(872, 0);
            cart_ScrollBar.Name = "cart_ScrollBar";
            cart_ScrollBar.Size = new Size(26, 498);
            cart_ScrollBar.TabIndex = 1;
            // 
            // cart_card
            // 
            cart_card.BorderStyle = BorderStyle.FixedSingle;
            cart_card.Controls.Add(cart_qtyCard);
            cart_card.Controls.Add(imgPrescription_dropper);
            cart_card.Controls.Add(btn_cartDelete);
            cart_card.Controls.Add(txt_medicinePrice);
            cart_card.Controls.Add(txt_medicineName);
            cart_card.Controls.Add(img_box);
            cart_card.Location = new Point(20, 20);
            cart_card.Name = "cart_card";
            cart_card.Size = new Size(830, 180);
            cart_card.TabIndex = 0;
            // 
            // cart_qtyCard
            // 
            cart_qtyCard.BorderStyle = BorderStyle.FixedSingle;
            cart_qtyCard.Controls.Add(btn_qtyDecrease);
            cart_qtyCard.Controls.Add(btn_qtyIncrease);
            cart_qtyCard.Controls.Add(txt_qty);
            cart_qtyCard.Location = new Point(700, 130);
            cart_qtyCard.Name = "cart_qtyCard";
            cart_qtyCard.Size = new Size(111, 35);
            cart_qtyCard.TabIndex = 15;
            // 
            // btn_qtyDecrease
            // 
            btn_qtyDecrease.CheckButton = false;
            btn_qtyDecrease.Checked = false;
            btn_qtyDecrease.CheckedBackground = Color.FromArgb(255, 106, 0);
            btn_qtyDecrease.CheckedForeColor = Color.White;
            btn_qtyDecrease.CheckedImageTint = Color.White;
            btn_qtyDecrease.CheckedOutline = Color.FromArgb(255, 106, 0);
            btn_qtyDecrease.Content = "-";
            btn_qtyDecrease.DialogResult = DialogResult.None;
            btn_qtyDecrease.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            btn_qtyDecrease.ForeColor = Color.Black;
            btn_qtyDecrease.HoverBackground = Color.White;
            btn_qtyDecrease.HoverForeColor = Color.DimGray;
            btn_qtyDecrease.HoverImageTint = Color.DimGray;
            btn_qtyDecrease.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btn_qtyDecrease.Image = null;
            btn_qtyDecrease.ImageExpand = new Point(0, 0);
            btn_qtyDecrease.Location = new Point(3, 3);
            btn_qtyDecrease.Name = "btn_qtyDecrease";
            btn_qtyDecrease.NormalBackground = Color.White;
            btn_qtyDecrease.NormalForeColor = Color.Black;
            btn_qtyDecrease.NormalImageTint = Color.Black;
            btn_qtyDecrease.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btn_qtyDecrease.OutlineThickness = 1F;
            btn_qtyDecrease.Padding = new Padding(12);
            btn_qtyDecrease.PressedBackground = Color.WhiteSmoke;
            btn_qtyDecrease.PressedForeColor = Color.FromArgb(32, 32, 32);
            btn_qtyDecrease.PressedImageTint = Color.FromArgb(32, 32, 32);
            btn_qtyDecrease.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btn_qtyDecrease.Rounding = new Padding(20);
            btn_qtyDecrease.Size = new Size(27, 26);
            btn_qtyDecrease.TabIndex = 18;
            btn_qtyDecrease.TextAlignment = StringAlignment.Center;
            btn_qtyDecrease.TextPadding = 12;
            btn_qtyDecrease.TextSpacing = 2;
            // 
            // btn_qtyIncrease
            // 
            btn_qtyIncrease.CheckButton = false;
            btn_qtyIncrease.Checked = false;
            btn_qtyIncrease.CheckedBackground = Color.FromArgb(255, 106, 0);
            btn_qtyIncrease.CheckedForeColor = Color.White;
            btn_qtyIncrease.CheckedImageTint = Color.White;
            btn_qtyIncrease.CheckedOutline = Color.FromArgb(255, 106, 0);
            btn_qtyIncrease.Content = "+";
            btn_qtyIncrease.DialogResult = DialogResult.None;
            btn_qtyIncrease.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btn_qtyIncrease.ForeColor = Color.Black;
            btn_qtyIncrease.HoverBackground = Color.White;
            btn_qtyIncrease.HoverForeColor = Color.DimGray;
            btn_qtyIncrease.HoverImageTint = Color.DimGray;
            btn_qtyIncrease.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btn_qtyIncrease.Image = null;
            btn_qtyIncrease.ImageExpand = new Point(0, 0);
            btn_qtyIncrease.Location = new Point(79, 4);
            btn_qtyIncrease.Name = "btn_qtyIncrease";
            btn_qtyIncrease.NormalBackground = Color.White;
            btn_qtyIncrease.NormalForeColor = Color.Black;
            btn_qtyIncrease.NormalImageTint = Color.Black;
            btn_qtyIncrease.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btn_qtyIncrease.OutlineThickness = 1F;
            btn_qtyIncrease.Padding = new Padding(12);
            btn_qtyIncrease.PressedBackground = Color.WhiteSmoke;
            btn_qtyIncrease.PressedForeColor = Color.FromArgb(32, 32, 32);
            btn_qtyIncrease.PressedImageTint = Color.FromArgb(32, 32, 32);
            btn_qtyIncrease.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btn_qtyIncrease.Rounding = new Padding(20);
            btn_qtyIncrease.Size = new Size(27, 26);
            btn_qtyIncrease.TabIndex = 17;
            btn_qtyIncrease.TextAlignment = StringAlignment.Center;
            btn_qtyIncrease.TextPadding = 12;
            btn_qtyIncrease.TextSpacing = 2;
            // 
            // txt_qty
            // 
            txt_qty.AutoSize = true;
            txt_qty.Location = new Point(46, 5);
            txt_qty.Name = "txt_qty";
            txt_qty.Size = new Size(17, 20);
            txt_qty.TabIndex = 16;
            txt_qty.Text = "0";
            // 
            // imgPrescription_dropper
            // 
            imgPrescription_dropper.AllowDrop = true;
            imgPrescription_dropper.DashedOutline = true;
            imgPrescription_dropper.DashedOutlineColor = Color.FromArgb(128, 128, 128, 128);
            imgPrescription_dropper.DashLength = 8;
            imgPrescription_dropper.Filter = "";
            imgPrescription_dropper.ForeColor = Color.Gray;
            imgPrescription_dropper.HoverContent = "Release to drop";
            imgPrescription_dropper.HoverForeColor = Color.FromArgb(128, 128, 128, 128);
            imgPrescription_dropper.HoverUploadForeColor = Color.FromArgb(255, 106, 0);
            imgPrescription_dropper.Image = (Image)resources.GetObject("imgPrescription_dropper.Image");
            imgPrescription_dropper.ImagePadding = 2;
            imgPrescription_dropper.ImageSize = new Size(24, 24);
            imgPrescription_dropper.ImageTint = Color.Gray;
            imgPrescription_dropper.Location = new Point(630, 50);
            imgPrescription_dropper.Multiselect = false;
            imgPrescription_dropper.Name = "imgPrescription_dropper";
            imgPrescription_dropper.NormalContent = "Drop file here";
            imgPrescription_dropper.NormalForeColor = Color.Gray;
            imgPrescription_dropper.NormalUploadForeColor = Color.FromArgb(255, 106, 0);
            imgPrescription_dropper.OutlineThickness = 1F;
            imgPrescription_dropper.PanelColor = Color.FromArgb(16, 255, 255, 255);
            imgPrescription_dropper.Rounding = new Padding(8);
            imgPrescription_dropper.Size = new Size(181, 75);
            imgPrescription_dropper.TabIndex = 14;
            imgPrescription_dropper.Text = "cuiFileDropper1";
            imgPrescription_dropper.UploadContent = "Click to upload";
            imgPrescription_dropper.UploadWithClick = true;
            // 
            // btn_cartDelete
            // 
            btn_cartDelete.BackgroundImageLayout = ImageLayout.None;
            btn_cartDelete.CheckButton = false;
            btn_cartDelete.Checked = false;
            btn_cartDelete.CheckedBackground = Color.FromArgb(255, 106, 0);
            btn_cartDelete.CheckedForeColor = Color.White;
            btn_cartDelete.CheckedImageTint = Color.White;
            btn_cartDelete.CheckedOutline = Color.FromArgb(255, 106, 0);
            btn_cartDelete.Content = "Delete";
            btn_cartDelete.DialogResult = DialogResult.None;
            btn_cartDelete.Font = new Font("Microsoft Sans Serif", 9F);
            btn_cartDelete.ForeColor = Color.Black;
            btn_cartDelete.HoverBackground = Color.White;
            btn_cartDelete.HoverForeColor = Color.DimGray;
            btn_cartDelete.HoverImageTint = Color.DimGray;
            btn_cartDelete.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btn_cartDelete.Image = null;
            btn_cartDelete.ImageExpand = new Point(0, 0);
            btn_cartDelete.Location = new Point(750, 15);
            btn_cartDelete.Name = "btn_cartDelete";
            btn_cartDelete.NormalBackground = Color.White;
            btn_cartDelete.NormalForeColor = Color.Black;
            btn_cartDelete.NormalImageTint = Color.Black;
            btn_cartDelete.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btn_cartDelete.OutlineThickness = 1F;
            btn_cartDelete.Padding = new Padding(12);
            btn_cartDelete.PressedBackground = Color.WhiteSmoke;
            btn_cartDelete.PressedForeColor = Color.FromArgb(32, 32, 32);
            btn_cartDelete.PressedImageTint = Color.FromArgb(32, 32, 32);
            btn_cartDelete.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btn_cartDelete.Rounding = new Padding(20);
            btn_cartDelete.Size = new Size(66, 31);
            btn_cartDelete.TabIndex = 13;
            btn_cartDelete.TextAlignment = StringAlignment.Center;
            btn_cartDelete.TextPadding = 12;
            btn_cartDelete.TextSpacing = 2;
            // 
            // txt_medicinePrice
            // 
            txt_medicinePrice.AutoSize = true;
            txt_medicinePrice.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            txt_medicinePrice.Location = new Point(200, 130);
            txt_medicinePrice.Name = "txt_medicinePrice";
            txt_medicinePrice.Size = new Size(62, 25);
            txt_medicinePrice.TabIndex = 2;
            txt_medicinePrice.Text = "label2";
            // 
            // txt_medicineName
            // 
            txt_medicineName.AutoSize = true;
            txt_medicineName.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            txt_medicineName.Location = new Point(200, 15);
            txt_medicineName.Name = "txt_medicineName";
            txt_medicineName.Size = new Size(104, 41);
            txt_medicineName.TabIndex = 1;
            txt_medicineName.Text = "label1";
            // 
            // img_box
            // 
            img_box.Location = new Point(15, 15);
            img_box.Name = "img_box";
            img_box.Size = new Size(170, 140);
            img_box.TabIndex = 0;
            img_box.TabStop = false;
            // 
            // orderSummary_container
            // 
            orderSummary_container.BorderStyle = BorderStyle.FixedSingle;
            orderSummary_container.Controls.Add(btn_placeOrder);
            orderSummary_container.Controls.Add(fg_total);
            orderSummary_container.Controls.Add(txt_total);
            orderSummary_container.Controls.Add(cuiSeparator1);
            orderSummary_container.Controls.Add(fg_discount);
            orderSummary_container.Controls.Add(fg_subTotal);
            orderSummary_container.Controls.Add(txt_discount);
            orderSummary_container.Controls.Add(txt_subTotal);
            orderSummary_container.Controls.Add(txt_orderSummary);
            orderSummary_container.Location = new Point(1133, 203);
            orderSummary_container.Name = "orderSummary_container";
            orderSummary_container.Size = new Size(420, 350);
            orderSummary_container.TabIndex = 1;
            // 
            // btn_placeOrder
            // 
            btn_placeOrder.BackgroundImageLayout = ImageLayout.None;
            btn_placeOrder.CheckButton = false;
            btn_placeOrder.Checked = false;
            btn_placeOrder.CheckedBackground = Color.FromArgb(255, 106, 0);
            btn_placeOrder.CheckedForeColor = Color.White;
            btn_placeOrder.CheckedImageTint = Color.White;
            btn_placeOrder.CheckedOutline = Color.FromArgb(255, 106, 0);
            btn_placeOrder.Content = "Place Order";
            btn_placeOrder.DialogResult = DialogResult.None;
            btn_placeOrder.Font = new Font("Microsoft Sans Serif", 9F);
            btn_placeOrder.ForeColor = Color.Black;
            btn_placeOrder.HoverBackground = Color.White;
            btn_placeOrder.HoverForeColor = Color.DimGray;
            btn_placeOrder.HoverImageTint = Color.DimGray;
            btn_placeOrder.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btn_placeOrder.Image = null;
            btn_placeOrder.ImageExpand = new Point(0, 0);
            btn_placeOrder.Location = new Point(130, 280);
            btn_placeOrder.Name = "btn_placeOrder";
            btn_placeOrder.NormalBackground = Color.White;
            btn_placeOrder.NormalForeColor = Color.Black;
            btn_placeOrder.NormalImageTint = Color.Black;
            btn_placeOrder.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btn_placeOrder.OutlineThickness = 1F;
            btn_placeOrder.Padding = new Padding(12);
            btn_placeOrder.PressedBackground = Color.WhiteSmoke;
            btn_placeOrder.PressedForeColor = Color.FromArgb(32, 32, 32);
            btn_placeOrder.PressedImageTint = Color.FromArgb(32, 32, 32);
            btn_placeOrder.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btn_placeOrder.Rounding = new Padding(20);
            btn_placeOrder.Size = new Size(135, 52);
            btn_placeOrder.TabIndex = 16;
            btn_placeOrder.TextAlignment = StringAlignment.Center;
            btn_placeOrder.TextPadding = 12;
            btn_placeOrder.TextSpacing = 2;
            btn_placeOrder.Click += btn_placeOrder_Click;
            // 
            // fg_total
            // 
            fg_total.AutoSize = true;
            fg_total.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            fg_total.Location = new Point(330, 230);
            fg_total.Name = "fg_total";
            fg_total.Size = new Size(24, 28);
            fg_total.TabIndex = 7;
            fg_total.Text = "0";
            // 
            // txt_total
            // 
            txt_total.AutoSize = true;
            txt_total.Font = new Font("Segoe UI", 12F);
            txt_total.Location = new Point(20, 230);
            txt_total.Name = "txt_total";
            txt_total.Size = new Size(54, 28);
            txt_total.TabIndex = 6;
            txt_total.Text = "Total";
            // 
            // cuiSeparator1
            // 
            cuiSeparator1.ForeColor = Color.FromArgb(128, 128, 128, 128);
            cuiSeparator1.Location = new Point(15, 180);
            cuiSeparator1.Margin = new Padding(4, 5, 4, 5);
            cuiSeparator1.Name = "cuiSeparator1";
            cuiSeparator1.SeparatorMargin = 8;
            cuiSeparator1.Size = new Size(380, 30);
            cuiSeparator1.TabIndex = 5;
            cuiSeparator1.Thickness = 0.5F;
            cuiSeparator1.Vertical = false;
            // 
            // fg_discount
            // 
            fg_discount.AutoSize = true;
            fg_discount.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            fg_discount.Location = new Point(330, 130);
            fg_discount.Name = "fg_discount";
            fg_discount.Size = new Size(24, 28);
            fg_discount.TabIndex = 4;
            fg_discount.Text = "0";
            // 
            // fg_subTotal
            // 
            fg_subTotal.AutoSize = true;
            fg_subTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            fg_subTotal.Location = new Point(330, 80);
            fg_subTotal.Name = "fg_subTotal";
            fg_subTotal.Size = new Size(24, 28);
            fg_subTotal.TabIndex = 3;
            fg_subTotal.Text = "0";
            // 
            // txt_discount
            // 
            txt_discount.AutoSize = true;
            txt_discount.Font = new Font("Segoe UI", 12F);
            txt_discount.Location = new Point(20, 130);
            txt_discount.Name = "txt_discount";
            txt_discount.Size = new Size(89, 28);
            txt_discount.TabIndex = 2;
            txt_discount.Text = "Discount";
            // 
            // txt_subTotal
            // 
            txt_subTotal.AutoSize = true;
            txt_subTotal.Font = new Font("Segoe UI", 12F);
            txt_subTotal.Location = new Point(20, 80);
            txt_subTotal.Name = "txt_subTotal";
            txt_subTotal.Size = new Size(87, 28);
            txt_subTotal.TabIndex = 1;
            txt_subTotal.Text = "Subtotal";
            // 
            // txt_orderSummary
            // 
            txt_orderSummary.AutoSize = true;
            txt_orderSummary.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            txt_orderSummary.Location = new Point(20, 20);
            txt_orderSummary.Name = "txt_orderSummary";
            txt_orderSummary.Size = new Size(227, 38);
            txt_orderSummary.TabIndex = 0;
            txt_orderSummary.Text = "Order Summary";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(118, 85);
            label1.Name = "label1";
            label1.Size = new Size(137, 50);
            label1.TabIndex = 11;
            label1.Text = "My Cart";
            // 
            // CartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(label1);
            Controls.Add(orderSummary_container);
            Controls.Add(cart_container);
            Name = "CartForm";
            Text = "SmartMed - My Cart";
            cart_container.ResumeLayout(false);
            cart_card.ResumeLayout(false);
            cart_card.PerformLayout();
            cart_qtyCard.ResumeLayout(false);
            cart_qtyCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)img_box).EndInit();
            orderSummary_container.ResumeLayout(false);
            orderSummary_container.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        // ----- DECLARATIONS -----
        private System.Windows.Forms.Panel cart_container;
        private System.Windows.Forms.VScrollBar cart_ScrollBar;
        private System.Windows.Forms.Panel cart_card;
        private System.Windows.Forms.Panel cart_qtyCard;
        private CuoreUI.Controls.cuiButton btn_qtyDecrease;
        private CuoreUI.Controls.cuiButton btn_qtyIncrease;
        private System.Windows.Forms.Label txt_qty;
        private CuoreUI.Controls.cuiFileDropper imgPrescription_dropper;
        private CuoreUI.Controls.cuiButton btn_cartDelete;
        private System.Windows.Forms.Label txt_medicinePrice;
        private System.Windows.Forms.Label txt_medicineName;
        private System.Windows.Forms.PictureBox img_box;
        private System.Windows.Forms.Panel orderSummary_container;
        private CuoreUI.Controls.cuiButton btn_placeOrder;
        private System.Windows.Forms.Label fg_total;
        private System.Windows.Forms.Label txt_total;
        private CuoreUI.Controls.cuiSeparator cuiSeparator1;
        private System.Windows.Forms.Label fg_discount;
        private System.Windows.Forms.Label fg_subTotal;
        private System.Windows.Forms.Label txt_discount;
        private System.Windows.Forms.Label txt_subTotal;
        private System.Windows.Forms.Label txt_orderSummary;
        private Label label1;
    }
}