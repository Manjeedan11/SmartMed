namespace SmartMed.Presentation.Authentication
{
    partial class LoginForm
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
            loginCard = new Panel();
            txt_email = new CuoreUI.Controls.cuiTextBox();
            password_label = new Label();
            btn_login = new CuoreUI.Controls.cuiButton();
            email_label = new Label();
            txt_password = new CuoreUI.Controls.cuiTextBox();
            loginHeader = new Label();
            loginCard.SuspendLayout();
            SuspendLayout();
            // 
            // loginCard
            // 
            loginCard.Controls.Add(txt_email);
            loginCard.Controls.Add(password_label);
            loginCard.Controls.Add(btn_login);
            loginCard.Controls.Add(email_label);
            loginCard.Controls.Add(txt_password);
            loginCard.Controls.Add(loginHeader);
            loginCard.Location = new Point(671, 281);
            loginCard.Name = "loginCard";
            loginCard.Size = new Size(536, 481);
            loginCard.TabIndex = 1;
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
            txt_email.Location = new Point(58, 173);
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
            txt_email.TabIndex = 7;
            txt_email.TextOffset = new Size(0, 0);
            txt_email.UnderlinedStyle = true;
            // 
            // password_label
            // 
            password_label.AutoSize = true;
            password_label.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password_label.ForeColor = SystemColors.ButtonHighlight;
            password_label.Location = new Point(58, 239);
            password_label.Name = "password_label";
            password_label.Size = new Size(80, 23);
            password_label.TabIndex = 6;
            password_label.Text = "Password";
            // 
            // btn_login
            // 
            btn_login.CheckButton = false;
            btn_login.Checked = false;
            btn_login.CheckedBackground = Color.FromArgb(255, 106, 0);
            btn_login.CheckedForeColor = Color.White;
            btn_login.CheckedImageTint = Color.White;
            btn_login.CheckedOutline = Color.FromArgb(255, 106, 0);
            btn_login.Content = "Login";
            btn_login.DialogResult = DialogResult.None;
            btn_login.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_login.ForeColor = Color.Black;
            btn_login.HoverBackground = Color.White;
            btn_login.HoverForeColor = Color.DimGray;
            btn_login.HoverImageTint = Color.DimGray;
            btn_login.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btn_login.Image = null;
            btn_login.ImageExpand = new Point(0, 0);
            btn_login.Location = new Point(213, 363);
            btn_login.Name = "btn_login";
            btn_login.NormalBackground = Color.White;
            btn_login.NormalForeColor = Color.Black;
            btn_login.NormalImageTint = Color.Black;
            btn_login.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btn_login.OutlineThickness = 1F;
            btn_login.Padding = new Padding(12);
            btn_login.PressedBackground = Color.WhiteSmoke;
            btn_login.PressedForeColor = Color.FromArgb(32, 32, 32);
            btn_login.PressedImageTint = Color.FromArgb(32, 32, 32);
            btn_login.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btn_login.Rounding = new Padding(20);
            btn_login.Size = new Size(119, 50);
            btn_login.TabIndex = 5;
            btn_login.TextAlignment = StringAlignment.Center;
            btn_login.TextPadding = 12;
            btn_login.TextSpacing = 2;
            btn_login.Click += btn_login_Click;
            // 
            // email_label
            // 
            email_label.AutoSize = true;
            email_label.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            email_label.ForeColor = SystemColors.ButtonHighlight;
            email_label.Location = new Point(58, 146);
            email_label.Name = "email_label";
            email_label.Size = new Size(51, 23);
            email_label.TabIndex = 2;
            email_label.Text = "Email";
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
            txt_password.Location = new Point(58, 266);
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
            txt_password.TabIndex = 3;
            txt_password.TextOffset = new Size(0, 0);
            txt_password.UnderlinedStyle = true;
            // 
            // loginHeader
            // 
            loginHeader.AutoSize = true;
            loginHeader.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginHeader.ForeColor = SystemColors.ButtonHighlight;
            loginHeader.Location = new Point(202, 36);
            loginHeader.Name = "loginHeader";
            loginHeader.Size = new Size(150, 62);
            loginHeader.TabIndex = 0;
            loginHeader.Text = "Login";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1902, 1033);
            Controls.Add(loginCard);
            Name = "LoginForm";
            Text = "LoginForm";
            loginCard.ResumeLayout(false);
            loginCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel loginCard;
        private CuoreUI.Controls.cuiButton btn_login;
        private Label loginHeader;
        private CuoreUI.Controls.cuiTextBox txt_password;
        private Label email_label;
        private Label password_label;
        private CuoreUI.Controls.cuiTextBox txt_email;
    }
}