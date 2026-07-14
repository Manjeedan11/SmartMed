namespace SmartMed.Presentation.Dashboard
{
    partial class CustomerDashboardForm
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
            pendingOrdersStatCard = new Panel();
            txt_noPendingOrders = new Label();
            lb_pendingOrders = new Label();
            recentOrdersStatCard = new Panel();
            txt_noRecentOrders = new Label();
            lb_recentOrders = new Label();
            deliveredOrdersStatCard = new Panel();
            txt_noDeliveredOrders = new Label();
            lb_deliveredOrders = new Label();
            totalOrdersStatCard = new Panel();
            txt_noTotalOrders = new Label();
            lb_totalOrders = new Label();
            img_ad = new PictureBox();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            btn_dashboard = new Button();
            btn_browseMedicines = new Button();
            btn_Mycart = new Button();
            btn_Myorders = new Button();
            btn_profile = new Button();
            btn_logOut = new Button();
            sidebarPanel.SuspendLayout();
            contentPanel.SuspendLayout();
            pendingOrdersStatCard.SuspendLayout();
            recentOrdersStatCard.SuspendLayout();
            deliveredOrdersStatCard.SuspendLayout();
            totalOrdersStatCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)img_ad).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // sidebarPanel
            // 
            sidebarPanel.Controls.Add(btn_logOut);
            sidebarPanel.Controls.Add(btn_profile);
            sidebarPanel.Controls.Add(btn_Myorders);
            sidebarPanel.Controls.Add(btn_Mycart);
            sidebarPanel.Controls.Add(btn_browseMedicines);
            sidebarPanel.Controls.Add(btn_dashboard);
            sidebarPanel.Margin = new Padding(3, 5, 3, 5);
            sidebarPanel.Size = new Size(287, 1033);
            sidebarPanel.Controls.SetChildIndex(btn_dashboard, 0);
            sidebarPanel.Controls.SetChildIndex(btn_browseMedicines, 0);
            sidebarPanel.Controls.SetChildIndex(btn_Mycart, 0);
            sidebarPanel.Controls.SetChildIndex(btn_Myorders, 0);
            sidebarPanel.Controls.SetChildIndex(btn_profile, 0);
            sidebarPanel.Controls.SetChildIndex(btn_logOut, 0);
            sidebarPanel.Controls.SetChildIndex(logoutButton, 0);
            sidebarPanel.Controls.SetChildIndex(logoLabel, 0);
            // 
            // contentPanel
            // 
            contentPanel.Controls.Add(panel1);
            contentPanel.Controls.Add(img_ad);
            contentPanel.Controls.Add(pendingOrdersStatCard);
            contentPanel.Controls.Add(recentOrdersStatCard);
            contentPanel.Controls.Add(deliveredOrdersStatCard);
            contentPanel.Controls.Add(totalOrdersStatCard);
            contentPanel.Location = new Point(287, 0);
            contentPanel.Margin = new Padding(3, 5, 3, 5);
            contentPanel.Size = new Size(1615, 1033);
            // 
            // logoLabel
            // 
            logoLabel.Location = new Point(52, 172);
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(13, 1067);
            logoutButton.Margin = new Padding(3, 5, 3, 5);
            logoutButton.Size = new Size(262, 71);
            // 
            // pendingOrdersStatCard
            // 
            pendingOrdersStatCard.Controls.Add(txt_noPendingOrders);
            pendingOrdersStatCard.Controls.Add(lb_pendingOrders);
            pendingOrdersStatCard.Location = new Point(481, 43);
            pendingOrdersStatCard.Name = "pendingOrdersStatCard";
            pendingOrdersStatCard.Size = new Size(250, 157);
            pendingOrdersStatCard.TabIndex = 4;
            // 
            // txt_noPendingOrders
            // 
            txt_noPendingOrders.AutoSize = true;
            txt_noPendingOrders.Font = new Font("Poppins", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_noPendingOrders.Location = new Point(12, 77);
            txt_noPendingOrders.Name = "txt_noPendingOrders";
            txt_noPendingOrders.Size = new Size(112, 50);
            txt_noPendingOrders.TabIndex = 2;
            txt_noPendingOrders.Text = "label7";
            // 
            // lb_pendingOrders
            // 
            lb_pendingOrders.AutoSize = true;
            lb_pendingOrders.Font = new Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_pendingOrders.Location = new Point(12, 15);
            lb_pendingOrders.Name = "lb_pendingOrders";
            lb_pendingOrders.Size = new Size(210, 40);
            lb_pendingOrders.TabIndex = 0;
            lb_pendingOrders.Text = "Pending Orders";
            // 
            // recentOrdersStatCard
            // 
            recentOrdersStatCard.Controls.Add(txt_noRecentOrders);
            recentOrdersStatCard.Controls.Add(lb_recentOrders);
            recentOrdersStatCard.Location = new Point(1272, 43);
            recentOrdersStatCard.Name = "recentOrdersStatCard";
            recentOrdersStatCard.Size = new Size(250, 157);
            recentOrdersStatCard.TabIndex = 6;
            // 
            // txt_noRecentOrders
            // 
            txt_noRecentOrders.AutoSize = true;
            txt_noRecentOrders.Font = new Font("Poppins", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_noRecentOrders.Location = new Point(12, 77);
            txt_noRecentOrders.Name = "txt_noRecentOrders";
            txt_noRecentOrders.Size = new Size(115, 50);
            txt_noRecentOrders.TabIndex = 2;
            txt_noRecentOrders.Text = "label9";
            // 
            // lb_recentOrders
            // 
            lb_recentOrders.AutoSize = true;
            lb_recentOrders.Font = new Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_recentOrders.Location = new Point(12, 15);
            lb_recentOrders.Name = "lb_recentOrders";
            lb_recentOrders.Size = new Size(193, 40);
            lb_recentOrders.TabIndex = 0;
            lb_recentOrders.Text = "Recent Orders";
            // 
            // deliveredOrdersStatCard
            // 
            deliveredOrdersStatCard.Controls.Add(txt_noDeliveredOrders);
            deliveredOrdersStatCard.Controls.Add(lb_deliveredOrders);
            deliveredOrdersStatCard.Location = new Point(874, 43);
            deliveredOrdersStatCard.Name = "deliveredOrdersStatCard";
            deliveredOrdersStatCard.Size = new Size(250, 157);
            deliveredOrdersStatCard.TabIndex = 5;
            // 
            // txt_noDeliveredOrders
            // 
            txt_noDeliveredOrders.AutoSize = true;
            txt_noDeliveredOrders.Font = new Font("Poppins", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_noDeliveredOrders.Location = new Point(12, 77);
            txt_noDeliveredOrders.Name = "txt_noDeliveredOrders";
            txt_noDeliveredOrders.Size = new Size(115, 50);
            txt_noDeliveredOrders.TabIndex = 9;
            txt_noDeliveredOrders.Text = "label8";
            // 
            // lb_deliveredOrders
            // 
            lb_deliveredOrders.AutoSize = true;
            lb_deliveredOrders.Font = new Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_deliveredOrders.Location = new Point(12, 15);
            lb_deliveredOrders.Name = "lb_deliveredOrders";
            lb_deliveredOrders.Size = new Size(225, 40);
            lb_deliveredOrders.TabIndex = 0;
            lb_deliveredOrders.Text = "Delivered Orders";
            // 
            // totalOrdersStatCard
            // 
            totalOrdersStatCard.Controls.Add(txt_noTotalOrders);
            totalOrdersStatCard.Controls.Add(lb_totalOrders);
            totalOrdersStatCard.Location = new Point(90, 43);
            totalOrdersStatCard.Name = "totalOrdersStatCard";
            totalOrdersStatCard.Size = new Size(250, 157);
            totalOrdersStatCard.TabIndex = 3;
            // 
            // txt_noTotalOrders
            // 
            txt_noTotalOrders.AutoSize = true;
            txt_noTotalOrders.Font = new Font("Poppins", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_noTotalOrders.Location = new Point(12, 77);
            txt_noTotalOrders.Name = "txt_noTotalOrders";
            txt_noTotalOrders.Size = new Size(115, 50);
            txt_noTotalOrders.TabIndex = 1;
            txt_noTotalOrders.Text = "label6";
            // 
            // lb_totalOrders
            // 
            lb_totalOrders.AutoSize = true;
            lb_totalOrders.Font = new Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_totalOrders.Location = new Point(12, 15);
            lb_totalOrders.Name = "lb_totalOrders";
            lb_totalOrders.Size = new Size(170, 40);
            lb_totalOrders.TabIndex = 0;
            lb_totalOrders.Text = "Total Orders";
            // 
            // img_ad
            // 
            img_ad.Location = new Point(92, 265);
            img_ad.Name = "img_ad";
            img_ad.Size = new Size(1430, 508);
            img_ad.TabIndex = 7;
            img_ad.TabStop = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(90, 819);
            panel1.Name = "panel1";
            panel1.Size = new Size(1432, 168);
            panel1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(211, 92);
            label2.Name = "label2";
            label2.Size = new Size(248, 36);
            label2.TabIndex = 2;
            label2.Text = "on diabetics medicines";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 81);
            label1.Name = "label1";
            label1.Size = new Size(201, 53);
            label1.TabIndex = 1;
            label1.Text = "Get 20% off";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(25, 22);
            label5.Name = "label5";
            label5.Size = new Size(238, 40);
            label5.TabIndex = 0;
            label5.Text = "Special Discounts";
            // 
            // btn_dashboard
            // 
            btn_dashboard.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_dashboard.Location = new Point(36, 317);
            btn_dashboard.Name = "btn_dashboard";
            btn_dashboard.Size = new Size(202, 47);
            btn_dashboard.TabIndex = 21;
            btn_dashboard.Text = "Dashboard";
            btn_dashboard.UseVisualStyleBackColor = true;
            // 
            // btn_browseMedicines
            // 
            btn_browseMedicines.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_browseMedicines.Location = new Point(36, 404);
            btn_browseMedicines.Name = "btn_browseMedicines";
            btn_browseMedicines.Size = new Size(202, 47);
            btn_browseMedicines.TabIndex = 22;
            btn_browseMedicines.Text = "Browse Medicines";
            btn_browseMedicines.UseVisualStyleBackColor = true;
            // 
            // btn_Mycart
            // 
            btn_Mycart.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Mycart.Location = new Point(36, 489);
            btn_Mycart.Name = "btn_Mycart";
            btn_Mycart.Size = new Size(202, 47);
            btn_Mycart.TabIndex = 23;
            btn_Mycart.Text = "My Cart";
            btn_Mycart.UseVisualStyleBackColor = true;
            // 
            // btn_Myorders
            // 
            btn_Myorders.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Myorders.Location = new Point(36, 579);
            btn_Myorders.Name = "btn_Myorders";
            btn_Myorders.Size = new Size(202, 47);
            btn_Myorders.TabIndex = 24;
            btn_Myorders.Text = "My Orders";
            btn_Myorders.UseVisualStyleBackColor = true;
            // 
            // btn_profile
            // 
            btn_profile.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_profile.Location = new Point(36, 674);
            btn_profile.Name = "btn_profile";
            btn_profile.Size = new Size(202, 47);
            btn_profile.TabIndex = 25;
            btn_profile.Text = "My Profile";
            btn_profile.UseVisualStyleBackColor = true;
            // 
            // btn_logOut
            // 
            btn_logOut.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_logOut.Location = new Point(36, 940);
            btn_logOut.Name = "btn_logOut";
            btn_logOut.Size = new Size(202, 47);
            btn_logOut.TabIndex = 26;
            btn_logOut.Text = "Log Out";
            btn_logOut.UseVisualStyleBackColor = true;
            btn_logOut.Click += btn_logOut_Click;
            // 
            // CustomerDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Margin = new Padding(3, 5, 3, 5);
            Name = "CustomerDashboardForm";
            Text = "SmartMed - Customer Dashboard";
            sidebarPanel.ResumeLayout(false);
            sidebarPanel.PerformLayout();
            contentPanel.ResumeLayout(false);
            pendingOrdersStatCard.ResumeLayout(false);
            pendingOrdersStatCard.PerformLayout();
            recentOrdersStatCard.ResumeLayout(false);
            recentOrdersStatCard.PerformLayout();
            deliveredOrdersStatCard.ResumeLayout(false);
            deliveredOrdersStatCard.PerformLayout();
            totalOrdersStatCard.ResumeLayout(false);
            totalOrdersStatCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)img_ad).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }


        private Panel pendingOrdersStatCard;
        private Label lb_pendingOrders;
        private Panel recentOrdersStatCard;
        private Label lb_recentOrders;
        private Panel deliveredOrdersStatCard;
        private Label lb_deliveredOrders;
        private Panel totalOrdersStatCard;
        private Label lb_totalOrders;
        private PictureBox img_ad;
        private Panel panel1;
        private Label label5;
        private Button btn_dashboard;
        private Button btn_browseMedicines;
        private Button btn_profile;
        private Button btn_Myorders;
        private Button btn_Mycart;
        private Label txt_noPendingOrders;
        private Label txt_noRecentOrders;
        private Label txt_noDeliveredOrders;
        private Label txt_noTotalOrders;
        private Label label2;
        private Label label1;
        private Button btn_logOut;
    }
}