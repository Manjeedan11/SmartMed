using SmartMed.Business;
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
            // Get user input
            string fullName = txt_fullName.Text.Trim();
            string email = txt_email.Text.Trim();
            string password = txt_password.Text;
            string address = txt_address.Text.Trim();
            string phone = txt_phoneNumber.Text.Trim();

            // ----- UI VALIDATION -----
            if (string.IsNullOrWhiteSpace(fullName))
            {
                MessageBox.Show("Please enter your full name.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_fullName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please enter your email address.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_email.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter a password.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_password.Focus();
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_password.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("Please enter your address.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_address.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Please enter your phone number.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_phoneNumber.Focus();
                return;
            }

            try
            {
                // ----- CALL BUSINESS LAYER -----
                // AuthenticationService.Register(email, password, fullName, phone, address)
                bool success = auth.Register(email, password, fullName, phone, address);

                if (success)
                {
                    MessageBox.Show("Registration successful! You can now login.",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Close registration form
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Registration Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
