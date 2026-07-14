namespace SmartMed.Presentation.Dashboard
{
    partial class AdminDashboardForm
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
            medicineStatCard = new Panel();
            txt_medicineNo = new Label();
            lb_medicines = new Label();
            orderStatCard = new Panel();
            txt_ordersNo = new Label();
            lb_orders = new Label();
            salesStatCard = new Panel();
            txt_salesNo = new Label();
            lb_sales = new Label();
            sales_chartLine = new CuoreUI.Controls.Charts.cuiChartLine();
            panel1 = new Panel();
            txt_lowStockAlert = new Label();
            label5 = new Label();
            customerStatCard = new Panel();
            txt_customersNo = new Label();
            lb_customers = new Label();
            btn_dashboard = new Button();
            btn_medicines = new Button();
            btn_customers = new Button();
            btn_orders = new Button();
            btn_reports = new Button();
            btn_logOut = new Button();
            sidebarPanel.SuspendLayout();
            contentPanel.SuspendLayout();
            medicineStatCard.SuspendLayout();
            orderStatCard.SuspendLayout();
            salesStatCard.SuspendLayout();
            panel1.SuspendLayout();
            customerStatCard.SuspendLayout();
            SuspendLayout();
            // 
            // sidebarPanel
            // 
            sidebarPanel.Controls.Add(btn_logOut);
            sidebarPanel.Controls.Add(btn_reports);
            sidebarPanel.Controls.Add(btn_orders);
            sidebarPanel.Controls.Add(btn_customers);
            sidebarPanel.Controls.Add(btn_medicines);
            sidebarPanel.Controls.Add(btn_dashboard);
            sidebarPanel.Margin = new Padding(3, 5, 3, 5);
            sidebarPanel.Size = new Size(287, 1033);
            sidebarPanel.Controls.SetChildIndex(logoutButton, 0);
            sidebarPanel.Controls.SetChildIndex(logoLabel, 0);
            sidebarPanel.Controls.SetChildIndex(btn_dashboard, 0);
            sidebarPanel.Controls.SetChildIndex(btn_medicines, 0);
            sidebarPanel.Controls.SetChildIndex(btn_customers, 0);
            sidebarPanel.Controls.SetChildIndex(btn_orders, 0);
            sidebarPanel.Controls.SetChildIndex(btn_reports, 0);
            sidebarPanel.Controls.SetChildIndex(btn_logOut, 0);
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.White;
            contentPanel.Controls.Add(customerStatCard);
            contentPanel.Controls.Add(panel1);
            contentPanel.Controls.Add(sales_chartLine);
            contentPanel.Controls.Add(salesStatCard);
            contentPanel.Controls.Add(orderStatCard);
            contentPanel.Controls.Add(medicineStatCard);
            contentPanel.Location = new Point(287, 0);
            contentPanel.Margin = new Padding(3, 5, 3, 5);
            contentPanel.Size = new Size(1615, 1033);
            contentPanel.Paint += contentPanel_Paint;
            // 
            // logoLabel
            // 
            logoLabel.Location = new Point(52, 170);
            logoLabel.Click += logoLabel_Click;
            // 
            // logoutButton
            // 
            logoutButton.Location = new Point(13, 1067);
            logoutButton.Margin = new Padding(3, 5, 3, 5);
            logoutButton.Size = new Size(262, 71);
            // 
            // medicineStatCard
            // 
            medicineStatCard.Controls.Add(txt_medicineNo);
            medicineStatCard.Controls.Add(lb_medicines);
            medicineStatCard.Location = new Point(84, 73);
            medicineStatCard.Name = "medicineStatCard";
            medicineStatCard.Size = new Size(250, 157);
            medicineStatCard.TabIndex = 0;
            // 
            // txt_medicineNo
            // 
            txt_medicineNo.AutoSize = true;
            txt_medicineNo.Font = new Font("Poppins", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_medicineNo.Location = new Point(12, 76);
            txt_medicineNo.Name = "txt_medicineNo";
            txt_medicineNo.Size = new Size(106, 50);
            txt_medicineNo.TabIndex = 1;
            txt_medicineNo.Text = "label1";
            // 
            // lb_medicines
            // 
            lb_medicines.AutoSize = true;
            lb_medicines.Font = new Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_medicines.Location = new Point(12, 15);
            lb_medicines.Name = "lb_medicines";
            lb_medicines.Size = new Size(143, 40);
            lb_medicines.TabIndex = 0;
            lb_medicines.Text = "Medicines";
            // 
            // orderStatCard
            // 
            orderStatCard.Controls.Add(txt_ordersNo);
            orderStatCard.Controls.Add(lb_orders);
            orderStatCard.Location = new Point(868, 73);
            orderStatCard.Name = "orderStatCard";
            orderStatCard.Size = new Size(250, 157);
            orderStatCard.TabIndex = 1;
            // 
            // txt_ordersNo
            // 
            txt_ordersNo.AutoSize = true;
            txt_ordersNo.Font = new Font("Poppins", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_ordersNo.Location = new Point(12, 76);
            txt_ordersNo.Name = "txt_ordersNo";
            txt_ordersNo.Size = new Size(113, 50);
            txt_ordersNo.TabIndex = 3;
            txt_ordersNo.Text = "label2";
            // 
            // lb_orders
            // 
            lb_orders.AutoSize = true;
            lb_orders.Font = new Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_orders.Location = new Point(12, 15);
            lb_orders.Name = "lb_orders";
            lb_orders.Size = new Size(101, 40);
            lb_orders.TabIndex = 0;
            lb_orders.Text = "Orders";
            // 
            // salesStatCard
            // 
            salesStatCard.Controls.Add(txt_salesNo);
            salesStatCard.Controls.Add(lb_sales);
            salesStatCard.Location = new Point(1266, 73);
            salesStatCard.Name = "salesStatCard";
            salesStatCard.Size = new Size(250, 157);
            salesStatCard.TabIndex = 2;
            // 
            // txt_salesNo
            // 
            txt_salesNo.AutoSize = true;
            txt_salesNo.Font = new Font("Poppins", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_salesNo.Location = new Point(12, 76);
            txt_salesNo.Name = "txt_salesNo";
            txt_salesNo.Size = new Size(113, 50);
            txt_salesNo.TabIndex = 5;
            txt_salesNo.Text = "label3";
            // 
            // lb_sales
            // 
            lb_sales.AutoSize = true;
            lb_sales.Font = new Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_sales.Location = new Point(12, 15);
            lb_sales.Name = "lb_sales";
            lb_sales.Size = new Size(83, 40);
            lb_sales.TabIndex = 0;
            lb_sales.Text = "Sales";
            // 
            // sales_chartLine
            // 
            sales_chartLine.AutoMaxValue = false;
            sales_chartLine.AxisColor = Color.Gray;
            sales_chartLine.ChartLineColor = Color.FromArgb(255, 106, 0);
            sales_chartLine.ChartPadding = 40;
            sales_chartLine.DataPoints = new float[]
    {
    100F,
    90F,
    80F,
    75F,
    70F,
    65F,
    60F
    };
            sales_chartLine.DayColor = Color.DarkGray;
            sales_chartLine.Font = new Font("Microsoft YaHei UI", 8.25F);
            sales_chartLine.GradientBackground = true;
            sales_chartLine.Location = new Point(84, 303);
            sales_chartLine.Margin = new Padding(4, 5, 4, 5);
            sales_chartLine.MaxValue = 100F;
            sales_chartLine.Name = "sales_chartLine";
            sales_chartLine.PointColor = Color.FromArgb(255, 106, 0);
            sales_chartLine.ShortDates = true;
            sales_chartLine.ShowLines = true;
            sales_chartLine.Size = new Size(1436, 466);
            sales_chartLine.TabIndex = 3;
            sales_chartLine.UseBezier = false;
            sales_chartLine.UsePercent = true;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txt_lowStockAlert);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(96, 809);
            panel1.Name = "panel1";
            panel1.Size = new Size(1424, 168);
            panel1.TabIndex = 4;
            // 
            // txt_lowStockAlert
            // 
            txt_lowStockAlert.AutoSize = true;
            txt_lowStockAlert.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_lowStockAlert.Location = new Point(25, 79);
            txt_lowStockAlert.Name = "txt_lowStockAlert";
            txt_lowStockAlert.Size = new Size(59, 25);
            txt_lowStockAlert.TabIndex = 1;
            txt_lowStockAlert.Text = "label6";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(25, 22);
            label5.Name = "label5";
            label5.Size = new Size(202, 40);
            label5.TabIndex = 0;
            label5.Text = "Low Stock Alert";
            // 
            // customerStatCard
            // 
            customerStatCard.Controls.Add(txt_customersNo);
            customerStatCard.Controls.Add(lb_customers);
            customerStatCard.Location = new Point(471, 73);
            customerStatCard.Name = "customerStatCard";
            customerStatCard.Size = new Size(250, 157);
            customerStatCard.TabIndex = 1;
            // 
            // txt_customersNo
            // 
            txt_customersNo.AutoSize = true;
            txt_customersNo.Font = new Font("Poppins", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_customersNo.Location = new Point(12, 76);
            txt_customersNo.Name = "txt_customersNo";
            txt_customersNo.Size = new Size(106, 50);
            txt_customersNo.TabIndex = 2;
            txt_customersNo.Text = "label1";
            // 
            // lb_customers
            // 
            lb_customers.AutoSize = true;
            lb_customers.Font = new Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_customers.Location = new Point(12, 15);
            lb_customers.Name = "lb_customers";
            lb_customers.Size = new Size(153, 40);
            lb_customers.TabIndex = 0;
            lb_customers.Text = "Customers";
            // 
            // btn_dashboard
            // 
            btn_dashboard.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_dashboard.Location = new Point(36, 350);
            btn_dashboard.Name = "btn_dashboard";
            btn_dashboard.Size = new Size(202, 47);
            btn_dashboard.TabIndex = 16;
            btn_dashboard.Text = "Dashboard";
            btn_dashboard.UseVisualStyleBackColor = true;
            btn_dashboard.Click += btn_dashboard_Click_1;
            // 
            // btn_medicines
            // 
            btn_medicines.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_medicines.Location = new Point(36, 445);
            btn_medicines.Name = "btn_medicines";
            btn_medicines.Size = new Size(202, 47);
            btn_medicines.TabIndex = 17;
            btn_medicines.Text = "Medicines";
            btn_medicines.UseVisualStyleBackColor = true;
            btn_medicines.Click += btn_medicines_Click_1;
            // 
            // btn_customers
            // 
            btn_customers.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_customers.Location = new Point(36, 548);
            btn_customers.Name = "btn_customers";
            btn_customers.Size = new Size(202, 47);
            btn_customers.TabIndex = 18;
            btn_customers.Text = "Customers";
            btn_customers.UseVisualStyleBackColor = true;
            btn_customers.Click += btn_customers_Click_1;
            // 
            // btn_orders
            // 
            btn_orders.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_orders.Location = new Point(36, 646);
            btn_orders.Name = "btn_orders";
            btn_orders.Size = new Size(202, 47);
            btn_orders.TabIndex = 19;
            btn_orders.Text = "Orders";
            btn_orders.UseVisualStyleBackColor = true;
            btn_orders.Click += btn_orders_Click_1;
            // 
            // btn_reports
            // 
            btn_reports.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_reports.Location = new Point(36, 745);
            btn_reports.Name = "btn_reports";
            btn_reports.Size = new Size(202, 47);
            btn_reports.TabIndex = 20;
            btn_reports.Text = "Reports";
            btn_reports.UseVisualStyleBackColor = true;
            btn_reports.Click += btn_reports_Click_1;
            // 
            // btn_logOut
            // 
            btn_logOut.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_logOut.Location = new Point(36, 930);
            btn_logOut.Name = "btn_logOut";
            btn_logOut.Size = new Size(202, 47);
            btn_logOut.TabIndex = 27;
            btn_logOut.Text = "Log Out";
            btn_logOut.UseVisualStyleBackColor = true;
            btn_logOut.Click += btn_logOut_Click;
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Margin = new Padding(3, 5, 3, 5);
            Name = "AdminDashboardForm";
            Text = "SmartMed - Admin Dashboard";
            sidebarPanel.ResumeLayout(false);
            sidebarPanel.PerformLayout();
            contentPanel.ResumeLayout(false);
            medicineStatCard.ResumeLayout(false);
            medicineStatCard.PerformLayout();
            orderStatCard.ResumeLayout(false);
            orderStatCard.PerformLayout();
            salesStatCard.ResumeLayout(false);
            salesStatCard.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            customerStatCard.ResumeLayout(false);
            customerStatCard.PerformLayout();
            ResumeLayout(false);
        }
        private Panel medicineStatCard;
        private Label lb_medicines;
        private Panel salesStatCard;
        private Label lb_sales;
        private Panel orderStatCard;
        private Label lb_orders;
        private Panel panel1;
        private Label label5;
        private CuoreUI.Controls.Charts.cuiChartLine sales_chartLine;
        private Label txt_lowStockAlert;
        private Panel customerStatCard;
        private Label lb_customers;
        private Label txt_medicineNo;
        private Label txt_customersNo;
        private Label txt_salesNo;
        private Label txt_ordersNo;
        private Button btn_dashboard;
        private Button btn_medicines;
        private Button btn_reports;
        private Button btn_orders;
        private Button btn_customers;
        private Button btn_logOut;
    }
}