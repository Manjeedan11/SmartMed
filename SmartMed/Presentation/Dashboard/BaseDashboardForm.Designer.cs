namespace SmartMed.Presentation.Dashboard
{
    partial class BaseDashboardForm
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
            sidebarPanel = new Panel();
            logoLabel = new Label();
            logoutButton = new Button();
            contentPanel = new Panel();
            img_logo = new PictureBox();
            sidebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)img_logo).BeginInit();
            SuspendLayout();
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.FromArgb(22, 33, 62);
            sidebarPanel.Controls.Add(img_logo);
            sidebarPanel.Controls.Add(logoLabel);
            sidebarPanel.Controls.Add(logoutButton);
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.Location = new Point(0, 0);
            sidebarPanel.Margin = new Padding(3, 4, 3, 4);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(251, 933);
            sidebarPanel.TabIndex = 0;
            // 
            // logoLabel
            // 
            logoLabel.AutoSize = true;
            logoLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            logoLabel.ForeColor = Color.White;
            logoLabel.Location = new Point(36, 167);
            logoLabel.Name = "logoLabel";
            logoLabel.Size = new Size(167, 41);
            logoLabel.TabIndex = 0;
            logoLabel.Text = "SmartMed";
            // 
            // logoutButton
            // 
            logoutButton.BackColor = Color.FromArgb(22, 33, 62);
            logoutButton.FlatStyle = FlatStyle.Flat;
            logoutButton.Font = new Font("Segoe UI", 10F);
            logoutButton.ForeColor = Color.White;
            logoutButton.Location = new Point(11, 800);
            logoutButton.Margin = new Padding(3, 4, 3, 4);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(229, 53);
            logoutButton.TabIndex = 10;
            logoutButton.Text = "🚪 Logout";
            logoutButton.TextAlign = ContentAlignment.MiddleLeft;
            logoutButton.UseVisualStyleBackColor = false;
            logoutButton.Click += logoutButton_Click;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.FromArgb(26, 26, 46);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(251, 0);
            contentPanel.Margin = new Padding(3, 4, 3, 4);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(892, 933);
            contentPanel.TabIndex = 1;
            // 
            // img_logo
            // 
            img_logo.Location = new Point(36, 12);
            img_logo.Name = "img_logo";
            img_logo.Size = new Size(183, 140);
            img_logo.TabIndex = 11;
            img_logo.TabStop = false;
            // 
            // BaseDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 933);
            Controls.Add(contentPanel);
            Controls.Add(sidebarPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BaseDashboardForm";
            Text = "SmartMed Dashboard";
            FormClosing += BaseDashboardForm_FormClosing;
            sidebarPanel.ResumeLayout(false);
            sidebarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)img_logo).EndInit();
            ResumeLayout(false);
        }

        protected System.Windows.Forms.Panel sidebarPanel;
        protected System.Windows.Forms.Panel contentPanel;
        protected System.Windows.Forms.Label logoLabel;
        protected System.Windows.Forms.Button logoutButton;
        private PictureBox img_logo;
    }
}