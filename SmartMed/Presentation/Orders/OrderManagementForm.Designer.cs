namespace SmartMed.Presentation.Orders
{
    partial class OrderManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lb_manageOrder = new Label();
            dgv_orders = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_orders).BeginInit();
            SuspendLayout();
            // 
            // lb_manageOrder
            // 
            lb_manageOrder.AutoSize = true;
            lb_manageOrder.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_manageOrder.Location = new Point(67, 160);
            lb_manageOrder.Name = "lb_manageOrder";
            lb_manageOrder.Size = new Size(222, 41);
            lb_manageOrder.TabIndex = 3;
            lb_manageOrder.Text = "Manage Order";
            // 
            // dgv_orders
            // 
            dgv_orders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_orders.Location = new Point(67, 251);
            dgv_orders.Name = "dgv_orders";
            dgv_orders.RowHeadersWidth = 51;
            dgv_orders.Size = new Size(1252, 275);
            dgv_orders.TabIndex = 4;
            // 
            // OrderManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(dgv_orders);
            Controls.Add(lb_manageOrder);
            Name = "OrderManagementForm";
            Text = "OrderManagementForm";
            ((System.ComponentModel.ISupportInitialize)dgv_orders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_manageOrder;
        private DataGridView dgv_orders;
    }
}