namespace SmartMed.Presentation.Customers
{
    partial class ProfileForm
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
            img_profile = new PictureBox();
            profileCard = new Panel();
            lb_fullName = new Label();
            lb_email = new Label();
            lb_phoneNumber = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btn_update = new CuoreUI.Controls.cuiButton();
            txt_address = new HartUI.Controls.cuiTextBox();
            txt_email = new HartUI.Controls.cuiTextBox();
            txt_phoneNumber = new HartUI.Controls.cuiTextBox();
            txt_name = new HartUI.Controls.cuiTextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)img_profile).BeginInit();
            profileCard.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // img_profile
            // 
            img_profile.Location = new Point(156, 19);
            img_profile.Name = "img_profile";
            img_profile.Size = new Size(208, 177);
            img_profile.TabIndex = 0;
            img_profile.TabStop = false;
            // 
            // profileCard
            // 
            profileCard.BackColor = SystemColors.ButtonHighlight;
            profileCard.BorderStyle = BorderStyle.FixedSingle;
            profileCard.Controls.Add(lb_fullName);
            profileCard.Controls.Add(lb_email);
            profileCard.Controls.Add(lb_phoneNumber);
            profileCard.Controls.Add(label2);
            profileCard.Controls.Add(label1);
            profileCard.Controls.Add(img_profile);
            profileCard.Location = new Point(517, 121);
            profileCard.Name = "profileCard";
            profileCard.Size = new Size(515, 362);
            profileCard.TabIndex = 2;
            // 
            // lb_fullName
            // 
            lb_fullName.AutoSize = true;
            lb_fullName.Font = new Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_fullName.Location = new Point(177, 208);
            lb_fullName.Name = "lb_fullName";
            lb_fullName.Size = new Size(95, 40);
            lb_fullName.TabIndex = 5;
            lb_fullName.Text = "label5";
            // 
            // lb_email
            // 
            lb_email.AutoSize = true;
            lb_email.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_email.Location = new Point(277, 301);
            lb_email.Name = "lb_email";
            lb_email.Size = new Size(57, 31);
            lb_email.TabIndex = 4;
            lb_email.Text = "label";
            // 
            // lb_phoneNumber
            // 
            lb_phoneNumber.AutoSize = true;
            lb_phoneNumber.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_phoneNumber.Location = new Point(381, 259);
            lb_phoneNumber.Name = "lb_phoneNumber";
            lb_phoneNumber.Size = new Size(57, 31);
            lb_phoneNumber.TabIndex = 3;
            lb_phoneNumber.Text = "label";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(57, 301);
            label2.Name = "label2";
            label2.Size = new Size(50, 31);
            label2.TabIndex = 2;
            label2.Text = "Mail";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 259);
            label1.Name = "label1";
            label1.Size = new Size(71, 31);
            label1.TabIndex = 1;
            label1.Text = "Phone";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btn_update);
            panel2.Controls.Add(txt_address);
            panel2.Controls.Add(txt_email);
            panel2.Controls.Add(txt_phoneNumber);
            panel2.Controls.Add(txt_name);
            panel2.Location = new Point(376, 586);
            panel2.Name = "panel2";
            panel2.Size = new Size(812, 291);
            panel2.TabIndex = 3;
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
            btn_update.Location = new Point(352, 221);
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
            btn_update.TabIndex = 12;
            btn_update.TextAlignment = StringAlignment.Center;
            btn_update.TextPadding = 12;
            btn_update.TextSpacing = 2;
            // 
            // txt_address
            // 
            txt_address.BackgroundColor = Color.White;
            txt_address.Content = "";
            txt_address.FocusBackgroundColor = Color.White;
            txt_address.FocusImageTint = Color.White;
            txt_address.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            txt_address.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_address.ForeColor = Color.Gray;
            txt_address.Image = null;
            txt_address.ImageExpand = new Point(0, 0);
            txt_address.ImageOffset = new Point(0, 0);
            txt_address.Location = new Point(439, 140);
            txt_address.Margin = new Padding(4);
            txt_address.Multiline = false;
            txt_address.Name = "txt_address";
            txt_address.NormalImageTint = Color.White;
            txt_address.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txt_address.Padding = new Padding(20, 9, 20, 0);
            txt_address.PasswordChar = false;
            txt_address.PlaceholderColor = Color.LightGray;
            txt_address.PlaceholderText = "Placeholder text..";
            txt_address.Rounding = new Padding(8);
            txt_address.Size = new Size(342, 39);
            txt_address.TabIndex = 3;
            txt_address.TextOffset = new Size(0, 0);
            txt_address.UnderlinedStyle = true;
            // 
            // txt_email
            // 
            txt_email.BackgroundColor = Color.White;
            txt_email.Content = "";
            txt_email.FocusBackgroundColor = Color.White;
            txt_email.FocusImageTint = Color.White;
            txt_email.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            txt_email.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_email.ForeColor = Color.Gray;
            txt_email.Image = null;
            txt_email.ImageExpand = new Point(0, 0);
            txt_email.ImageOffset = new Point(0, 0);
            txt_email.Location = new Point(24, 140);
            txt_email.Margin = new Padding(4);
            txt_email.Multiline = false;
            txt_email.Name = "txt_email";
            txt_email.NormalImageTint = Color.White;
            txt_email.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txt_email.Padding = new Padding(20, 9, 20, 0);
            txt_email.PasswordChar = false;
            txt_email.PlaceholderColor = Color.LightGray;
            txt_email.PlaceholderText = "Placeholder text..";
            txt_email.Rounding = new Padding(8);
            txt_email.Size = new Size(342, 39);
            txt_email.TabIndex = 2;
            txt_email.TextOffset = new Size(0, 0);
            txt_email.UnderlinedStyle = true;
            // 
            // txt_phoneNumber
            // 
            txt_phoneNumber.BackgroundColor = Color.White;
            txt_phoneNumber.Content = "";
            txt_phoneNumber.FocusBackgroundColor = Color.White;
            txt_phoneNumber.FocusImageTint = Color.White;
            txt_phoneNumber.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            txt_phoneNumber.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_phoneNumber.ForeColor = Color.Gray;
            txt_phoneNumber.Image = null;
            txt_phoneNumber.ImageExpand = new Point(0, 0);
            txt_phoneNumber.ImageOffset = new Point(0, 0);
            txt_phoneNumber.Location = new Point(439, 37);
            txt_phoneNumber.Margin = new Padding(4);
            txt_phoneNumber.Multiline = false;
            txt_phoneNumber.Name = "txt_phoneNumber";
            txt_phoneNumber.NormalImageTint = Color.White;
            txt_phoneNumber.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txt_phoneNumber.Padding = new Padding(20, 9, 20, 0);
            txt_phoneNumber.PasswordChar = false;
            txt_phoneNumber.PlaceholderColor = Color.LightGray;
            txt_phoneNumber.PlaceholderText = "Placeholder text..";
            txt_phoneNumber.Rounding = new Padding(8);
            txt_phoneNumber.Size = new Size(342, 39);
            txt_phoneNumber.TabIndex = 1;
            txt_phoneNumber.TextOffset = new Size(0, 0);
            txt_phoneNumber.UnderlinedStyle = true;
            // 
            // txt_name
            // 
            txt_name.BackColor = SystemColors.ButtonHighlight;
            txt_name.BackgroundColor = Color.White;
            txt_name.Content = "";
            txt_name.FocusBackgroundColor = Color.White;
            txt_name.FocusImageTint = Color.White;
            txt_name.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            txt_name.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_name.ForeColor = Color.Gray;
            txt_name.Image = null;
            txt_name.ImageExpand = new Point(0, 0);
            txt_name.ImageOffset = new Point(0, 0);
            txt_name.Location = new Point(24, 37);
            txt_name.Margin = new Padding(4);
            txt_name.Multiline = false;
            txt_name.Name = "txt_name";
            txt_name.NormalImageTint = Color.White;
            txt_name.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txt_name.Padding = new Padding(20, 9, 20, 0);
            txt_name.PasswordChar = false;
            txt_name.PlaceholderColor = Color.LightGray;
            txt_name.PlaceholderText = "Placeholder text..";
            txt_name.Rounding = new Padding(8);
            txt_name.Size = new Size(342, 39);
            txt_name.TabIndex = 0;
            txt_name.TextOffset = new Size(0, 0);
            txt_name.UnderlinedStyle = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(47, 44);
            label3.Name = "label3";
            label3.Size = new Size(165, 41);
            label3.TabIndex = 6;
            label3.Text = "My Profile";
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(profileCard);
            Name = "ProfileForm";
            Text = "ProfileForm";
            ((System.ComponentModel.ISupportInitialize)img_profile).EndInit();
            profileCard.ResumeLayout(false);
            profileCard.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox img_profile;
        private Panel profileCard;
        private Label lb_fullName;
        private Label lb_email;
        private Label lb_phoneNumber;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Label label6;
        private HartUI.Controls.cuiTextBox txt_name;
        private HartUI.Controls.cuiTextBox txt_address;
        private HartUI.Controls.cuiTextBox txt_email;
        private HartUI.Controls.cuiTextBox cuiTextBox2;
        private CuoreUI.Controls.cuiButton btn_update;
        private HartUI.Controls.cuiTextBox txt_phoneNumber;
        private Label label3;
    }
}