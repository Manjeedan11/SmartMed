namespace SmartMed.Presentation.Orders
{
    partial class MyOrdersForm
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
            lb_myOrder = new Label();
            dgv_myOrder = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_myOrder).BeginInit();
            SuspendLayout();
            // 
            // lb_myOrder
            // 
            lb_myOrder.AutoSize = true;
            lb_myOrder.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_myOrder.Location = new Point(48, 153);
            lb_myOrder.Name = "lb_myOrder";
            lb_myOrder.Size = new Size(153, 41);
            lb_myOrder.TabIndex = 2;
            lb_myOrder.Text = "My Order";
            // 
            // dgv_myOrder
            // 
            dgv_myOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_myOrder.Location = new Point(61, 234);
            dgv_myOrder.Name = "dgv_myOrder";
            dgv_myOrder.RowHeadersWidth = 51;
            dgv_myOrder.Size = new Size(1312, 288);
            dgv_myOrder.TabIndex = 3;
            dgv_myOrder.CellContentClick += dgv_myOrder_CellContentClick;
            // 
            // MyOrdersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(dgv_myOrder);
            Controls.Add(lb_myOrder);
            Name = "MyOrdersForm";
            Text = "MyOrdersForm";
            ((System.ComponentModel.ISupportInitialize)dgv_myOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_myOrder;
        private DataGridView dgv_myOrder;
    }
}