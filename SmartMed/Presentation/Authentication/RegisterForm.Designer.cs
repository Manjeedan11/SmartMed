namespace SmartMed.Presentation.Authentication
{
    partial class RegisterForm
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
            registerCard = new Panel();
            register_header = new Label();
            label3 = new Label();
            btn_signUp = new CuoreUI.Controls.cuiButton();
            txt_phoneNumber = new CuoreUI.Controls.cuiTextBox();
            txt_password = new CuoreUI.Controls.cuiTextBox();
            label1 = new Label();
            label2 = new Label();
            txt_address = new CuoreUI.Controls.cuiTextBox();
            txt_fullName = new CuoreUI.Controls.cuiTextBox();
            password_label = new Label();
            email_label = new Label();
            txt_email = new CuoreUI.Controls.cuiTextBox();
            registerCard.SuspendLayout();
            SuspendLayout();
            // 
            // registerCard
            // 
            registerCard.Controls.Add(register_header);
            registerCard.Controls.Add(label3);
            registerCard.Controls.Add(btn_signUp);
            registerCard.Controls.Add(txt_phoneNumber);
            registerCard.Controls.Add(txt_password);
            registerCard.Controls.Add(label1);
            registerCard.Controls.Add(label2);
            registerCard.Controls.Add(txt_address);
            registerCard.Controls.Add(txt_fullName);
            registerCard.Controls.Add(password_label);
            registerCard.Controls.Add(email_label);
            registerCard.Controls.Add(txt_email);
            registerCard.Location = new Point(679, 148);
            registerCard.Name = "registerCard";
            registerCard.Size = new Size(536, 720);
            registerCard.TabIndex = 2;
            // 
            // register_header
            // 
            register_header.AutoSize = true;
            register_header.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            register_header.ForeColor = SystemColors.ButtonHighlight;
            register_header.Location = new Point(163, 40);
            register_header.Name = "register_header";
            register_header.Size = new Size(207, 62);
            register_header.TabIndex = 14;
            register_header.Text = "Register";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(58, 517);
            label3.Name = "label3";
            label3.Size = new Size(127, 23);
            label3.TabIndex = 13;
            label3.Text = "Phone Number";
            // 
            // btn_signUp
            // 
            btn_signUp.CheckButton = false;
            btn_signUp.Checked = false;
            btn_signUp.CheckedBackground = Color.FromArgb(255, 106, 0);
            btn_signUp.CheckedForeColor = Color.White;
            btn_signUp.CheckedImageTint = Color.White;
            btn_signUp.CheckedOutline = Color.FromArgb(255, 106, 0);
            btn_signUp.Content = "Sign Up";
            btn_signUp.DialogResult = DialogResult.None;
            btn_signUp.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_signUp.ForeColor = Color.Black;
            btn_signUp.HoverBackground = Color.White;
            btn_signUp.HoverForeColor = Color.DimGray;
            btn_signUp.HoverImageTint = Color.DimGray;
            btn_signUp.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btn_signUp.Image = null;
            btn_signUp.ImageExpand = new Point(0, 0);
            btn_signUp.Location = new Point(208, 646);
            btn_signUp.Name = "btn_signUp";
            btn_signUp.NormalBackground = Color.White;
            btn_signUp.NormalForeColor = Color.Black;
            btn_signUp.NormalImageTint = Color.Black;
            btn_signUp.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btn_signUp.OutlineThickness = 1F;
            btn_signUp.Padding = new Padding(12);
            btn_signUp.PressedBackground = Color.WhiteSmoke;
            btn_signUp.PressedForeColor = Color.FromArgb(32, 32, 32);
            btn_signUp.PressedImageTint = Color.FromArgb(32, 32, 32);
            btn_signUp.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btn_signUp.Rounding = new Padding(20);
            btn_signUp.Size = new Size(119, 50);
            btn_signUp.TabIndex = 5;
            btn_signUp.TextAlignment = StringAlignment.Center;
            btn_signUp.TextPadding = 12;
            btn_signUp.TextSpacing = 2;
            btn_signUp.Click += btn_signUp_Click;
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
            txt_phoneNumber.Location = new Point(58, 544);
            txt_phoneNumber.Margin = new Padding(4);
            txt_phoneNumber.Multiline = false;
            txt_phoneNumber.Name = "txt_phoneNumber";
            txt_phoneNumber.NormalImageTint = Color.White;
            txt_phoneNumber.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txt_phoneNumber.Padding = new Padding(20, 13, 20, 0);
            txt_phoneNumber.PasswordChar = false;
            txt_phoneNumber.PlaceholderColor = Color.LightGray;
            txt_phoneNumber.PlaceholderText = "Enter Your Phone Number";
            txt_phoneNumber.Rounding = new Padding(8);
            txt_phoneNumber.Size = new Size(430, 46);
            txt_phoneNumber.TabIndex = 12;
            txt_phoneNumber.TextOffset = new Size(0, 0);
            txt_phoneNumber.UnderlinedStyle = true;
            // 
            // txt_password
            // 
            txt_password.BackgroundColor = Color.White;
            txt_password.Content = "";
            txt_password.FocusBackgroundColor = Color.White;
            txt_password.FocusImageTint = Color.White;
            txt_password.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            txt_password.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_password.ForeColor = Color.Gray;
            txt_password.Image = null;
            txt_password.ImageExpand = new Point(0, 0);
            txt_password.ImageOffset = new Point(0, 0);
            txt_password.Location = new Point(58, 356);
            txt_password.Margin = new Padding(4);
            txt_password.Multiline = false;
            txt_password.Name = "txt_password";
            txt_password.NormalImageTint = Color.White;
            txt_password.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txt_password.Padding = new Padding(20, 13, 20, 0);
            txt_password.PasswordChar = false;
            txt_password.PlaceholderColor = Color.LightGray;
            txt_password.PlaceholderText = "Enter Your Password";
            txt_password.Rounding = new Padding(8);
            txt_password.Size = new Size(430, 46);
            txt_password.TabIndex = 11;
            txt_password.TextOffset = new Size(0, 0);
            txt_password.UnderlinedStyle = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(58, 422);
            label1.Name = "label1";
            label1.Size = new Size(70, 23);
            label1.TabIndex = 10;
            label1.Text = "Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(58, 329);
            label2.Name = "label2";
            label2.Size = new Size(80, 23);
            label2.TabIndex = 8;
            label2.Text = "Password";
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
            txt_address.Location = new Point(58, 449);
            txt_address.Margin = new Padding(4);
            txt_address.Multiline = false;
            txt_address.Name = "txt_address";
            txt_address.NormalImageTint = Color.White;
            txt_address.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txt_address.Padding = new Padding(20, 13, 20, 0);
            txt_address.PasswordChar = false;
            txt_address.PlaceholderColor = Color.LightGray;
            txt_address.PlaceholderText = "Enter Your Shipping Address";
            txt_address.Rounding = new Padding(8);
            txt_address.Size = new Size(430, 46);
            txt_address.TabIndex = 9;
            txt_address.TextOffset = new Size(0, 0);
            txt_address.UnderlinedStyle = true;
            // 
            // txt_fullName
            // 
            txt_fullName.BackgroundColor = Color.White;
            txt_fullName.Content = "";
            txt_fullName.FocusBackgroundColor = Color.White;
            txt_fullName.FocusImageTint = Color.White;
            txt_fullName.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            txt_fullName.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_fullName.ForeColor = Color.Gray;
            txt_fullName.Image = null;
            txt_fullName.ImageExpand = new Point(0, 0);
            txt_fullName.ImageOffset = new Point(0, 0);
            txt_fullName.Location = new Point(58, 173);
            txt_fullName.Margin = new Padding(4);
            txt_fullName.Multiline = false;
            txt_fullName.Name = "txt_fullName";
            txt_fullName.NormalImageTint = Color.White;
            txt_fullName.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txt_fullName.Padding = new Padding(20, 13, 20, 0);
            txt_fullName.PasswordChar = false;
            txt_fullName.PlaceholderColor = Color.LightGray;
            txt_fullName.PlaceholderText = "Enter Your Full Name";
            txt_fullName.Rounding = new Padding(8);
            txt_fullName.Size = new Size(430, 46);
            txt_fullName.TabIndex = 7;
            txt_fullName.TextOffset = new Size(0, 0);
            txt_fullName.UnderlinedStyle = true;
            // 
            // password_label
            // 
            password_label.AutoSize = true;
            password_label.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password_label.ForeColor = SystemColors.ButtonHighlight;
            password_label.Location = new Point(58, 239);
            password_label.Name = "password_label";
            password_label.Size = new Size(51, 23);
            password_label.TabIndex = 6;
            password_label.Text = "Email";
            // 
            // email_label
            // 
            email_label.AutoSize = true;
            email_label.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            email_label.ForeColor = SystemColors.ButtonHighlight;
            email_label.Location = new Point(58, 146);
            email_label.Name = "email_label";
            email_label.Size = new Size(87, 23);
            email_label.TabIndex = 2;
            email_label.Text = "Full Name";
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
            txt_email.Location = new Point(58, 266);
            txt_email.Margin = new Padding(4);
            txt_email.Multiline = false;
            txt_email.Name = "txt_email";
            txt_email.NormalImageTint = Color.White;
            txt_email.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txt_email.Padding = new Padding(20, 13, 20, 0);
            txt_email.PasswordChar = false;
            txt_email.PlaceholderColor = Color.LightGray;
            txt_email.PlaceholderText = "Enter Your Email Address";
            txt_email.Rounding = new Padding(8);
            txt_email.Size = new Size(430, 46);
            txt_email.TabIndex = 3;
            txt_email.TextOffset = new Size(0, 0);
            txt_email.UnderlinedStyle = true;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(registerCard);
            Name = "RegisterForm";
            Text = "RegisterForm";
            registerCard.ResumeLayout(false);
            registerCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel registerCard;
        private CuoreUI.Controls.cuiTextBox txt_fullName;
        private Label password_label;
        private CuoreUI.Controls.cuiButton btn_signUp;
        private Label email_label;
        private CuoreUI.Controls.cuiTextBox txt_email;
        private Label label3;
        private CuoreUI.Controls.cuiTextBox txt_phoneNumber;
        private CuoreUI.Controls.cuiTextBox txt_password;
        private Label label1;
        private Label label2;
        private CuoreUI.Controls.cuiTextBox txt_address;
        private Label register_header;
    }
}