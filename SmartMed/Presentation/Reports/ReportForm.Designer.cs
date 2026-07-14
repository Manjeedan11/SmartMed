namespace SmartMed.Presentation.Reports
{
    partial class ReportForm
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
            report_Card = new Panel();
            btn_exportCSV = new CuoreUI.Controls.cuiButton();
            btn_exportPDF = new CuoreUI.Controls.cuiButton();
            cmb_report = new CuoreUI.Controls.cuiComboBox();
            dgv_reports = new DataGridView();
            report_Card.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_reports).BeginInit();
            SuspendLayout();
            // 
            // lb_myOrder
            // 
            lb_myOrder.AutoSize = true;
            lb_myOrder.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_myOrder.Location = new Point(46, 129);
            lb_myOrder.Name = "lb_myOrder";
            lb_myOrder.Size = new Size(250, 41);
            lb_myOrder.TabIndex = 3;
            lb_myOrder.Text = "Manage Reports";
            // 
            // report_Card
            // 
            report_Card.BorderStyle = BorderStyle.FixedSingle;
            report_Card.Controls.Add(btn_exportCSV);
            report_Card.Controls.Add(btn_exportPDF);
            report_Card.Controls.Add(cmb_report);
            report_Card.Location = new Point(55, 200);
            report_Card.Name = "report_Card";
            report_Card.Size = new Size(620, 72);
            report_Card.TabIndex = 4;
            // 
            // btn_exportCSV
            // 
            btn_exportCSV.CheckButton = false;
            btn_exportCSV.Checked = false;
            btn_exportCSV.CheckedBackground = Color.FromArgb(255, 106, 0);
            btn_exportCSV.CheckedForeColor = Color.White;
            btn_exportCSV.CheckedImageTint = Color.White;
            btn_exportCSV.CheckedOutline = Color.FromArgb(255, 106, 0);
            btn_exportCSV.Content = "Export CSV";
            btn_exportCSV.DialogResult = DialogResult.None;
            btn_exportCSV.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_exportCSV.ForeColor = Color.Black;
            btn_exportCSV.HoverBackground = Color.White;
            btn_exportCSV.HoverForeColor = Color.DimGray;
            btn_exportCSV.HoverImageTint = Color.DimGray;
            btn_exportCSV.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btn_exportCSV.Image = null;
            btn_exportCSV.ImageExpand = new Point(0, 0);
            btn_exportCSV.Location = new Point(501, 19);
            btn_exportCSV.Name = "btn_exportCSV";
            btn_exportCSV.NormalBackground = Color.White;
            btn_exportCSV.NormalForeColor = Color.Black;
            btn_exportCSV.NormalImageTint = Color.Black;
            btn_exportCSV.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btn_exportCSV.OutlineThickness = 1F;
            btn_exportCSV.Padding = new Padding(12);
            btn_exportCSV.PressedBackground = Color.WhiteSmoke;
            btn_exportCSV.PressedForeColor = Color.FromArgb(32, 32, 32);
            btn_exportCSV.PressedImageTint = Color.FromArgb(32, 32, 32);
            btn_exportCSV.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btn_exportCSV.Rounding = new Padding(20);
            btn_exportCSV.Size = new Size(97, 32);
            btn_exportCSV.TabIndex = 12;
            btn_exportCSV.TextAlignment = StringAlignment.Center;
            btn_exportCSV.TextPadding = 12;
            btn_exportCSV.TextSpacing = 2;
            // 
            // btn_exportPDF
            // 
            btn_exportPDF.CheckButton = false;
            btn_exportPDF.Checked = false;
            btn_exportPDF.CheckedBackground = Color.FromArgb(255, 106, 0);
            btn_exportPDF.CheckedForeColor = Color.White;
            btn_exportPDF.CheckedImageTint = Color.White;
            btn_exportPDF.CheckedOutline = Color.FromArgb(255, 106, 0);
            btn_exportPDF.Content = "Export PDF";
            btn_exportPDF.DialogResult = DialogResult.None;
            btn_exportPDF.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_exportPDF.ForeColor = Color.Black;
            btn_exportPDF.HoverBackground = Color.White;
            btn_exportPDF.HoverForeColor = Color.DimGray;
            btn_exportPDF.HoverImageTint = Color.DimGray;
            btn_exportPDF.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btn_exportPDF.Image = null;
            btn_exportPDF.ImageExpand = new Point(0, 0);
            btn_exportPDF.Location = new Point(380, 19);
            btn_exportPDF.Name = "btn_exportPDF";
            btn_exportPDF.NormalBackground = Color.White;
            btn_exportPDF.NormalForeColor = Color.Black;
            btn_exportPDF.NormalImageTint = Color.Black;
            btn_exportPDF.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btn_exportPDF.OutlineThickness = 1F;
            btn_exportPDF.Padding = new Padding(12);
            btn_exportPDF.PressedBackground = Color.WhiteSmoke;
            btn_exportPDF.PressedForeColor = Color.FromArgb(32, 32, 32);
            btn_exportPDF.PressedImageTint = Color.FromArgb(32, 32, 32);
            btn_exportPDF.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btn_exportPDF.Rounding = new Padding(20);
            btn_exportPDF.Size = new Size(97, 32);
            btn_exportPDF.TabIndex = 11;
            btn_exportPDF.TextAlignment = StringAlignment.Center;
            btn_exportPDF.TextPadding = 12;
            btn_exportPDF.TextSpacing = 2;
            // 
            // cmb_report
            // 
            cmb_report.BackgroundColor = Color.FromArgb(255, 255, 255);
            cmb_report.DropDownBackgroundColor = Color.White;
            cmb_report.DropDownForeColor = Color.FromArgb(27, 27, 27);
            cmb_report.ExpandArrowColor = Color.Gray;
            cmb_report.ForeColor = Color.Gray;
            cmb_report.Items = new string[]
    {
    "Item 1",
    "Item 2",
    "Item 3"
    };
            cmb_report.Location = new Point(16, 19);
            cmb_report.Margin = new Padding(4, 5, 4, 5);
            cmb_report.MaxDropDownHeight = 240;
            cmb_report.Name = "cmb_report";
            cmb_report.NoSelectionText = "None";
            cmb_report.OutlineColor = Color.FromArgb(64, 128, 128, 128);
            cmb_report.OutlineThickness = 1F;
            cmb_report.Rounding = 8;
            cmb_report.SelectedIndex = -1;
            cmb_report.SelectedItem = "";
            cmb_report.Size = new Size(335, 32);
            cmb_report.SortAlphabetically = true;
            cmb_report.TabIndex = 0;
            // 
            // dgv_reports
            // 
            dgv_reports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_reports.Location = new Point(55, 309);
            dgv_reports.Name = "dgv_reports";
            dgv_reports.RowHeadersWidth = 51;
            dgv_reports.Size = new Size(1080, 246);
            dgv_reports.TabIndex = 5;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(dgv_reports);
            Controls.Add(report_Card);
            Controls.Add(lb_myOrder);
            Name = "ReportForm";
            Text = "ReportForm";
            report_Card.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_reports).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_myOrder;
        private Panel report_Card;
        private CuoreUI.Controls.cuiComboBox cmb_report;
        private CuoreUI.Controls.cuiButton btn_exportCSV;
        private CuoreUI.Controls.cuiButton btn_exportPDF;
        private DataGridView dgv_reports;
    }
}