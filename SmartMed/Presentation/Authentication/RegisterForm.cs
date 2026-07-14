using SmartMed.Business;
using SmartMed.Models;
using SmartMed.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SmartMed.Presentation.Authentication
{
    public partial class RegisterForm : Form
    {
        private AuthenticationService auth = new AuthenticationService(); 
        public RegisterForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = ColorTranslator.FromHtml("#102E30");
            registerCard.BackColor = ColorTranslator.FromHtml("#27453F");
            btn_signUp.HoverBackground = ColorTranslator.FromHtml("#DDF084");
            btn_signUp.HoverForeColor = ColorTranslator.FromHtml("#102E30");
        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {
            try
            {
                string fullName = txt_fullName.Text.Trim();
                string email = txt_email.Text.Trim();
                string password = txt_password.Text;
                string address = txt_address.Text.Trim();
                string phone = txt_phoneNumber.Text.Trim();

                
                string hashedPassword = PasswordHelper.HashPassword(password);

                
                User user = new User(email, hashedPassword, "Customer");
                Customer customer = new Customer(fullName, phone, address);

                
                user.Validate();
                customer.Validate();

                bool success = auth.Register(user, customer);
                if (success)
                {
                    MessageBox.Show("Registration successful!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Registration Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetFocusOnField(string paramName)
        {
            if (string.IsNullOrEmpty(paramName)) return;
            switch (paramName)
            {
                case nameof(User.email): txt_email.Focus(); break;
                case nameof(User.passwordHash): txt_password.Focus(); break;
                case nameof(Customer.fullName): txt_fullName.Focus(); break;
                case nameof(Customer.phoneNumber): txt_phoneNumber.Focus(); break;
                case nameof(Customer.address): txt_address.Focus(); break;
                default: break;
            }
        }
    }
}
