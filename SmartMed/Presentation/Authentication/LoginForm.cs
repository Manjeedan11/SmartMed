using SmartMed.Business;
using SmartMed.Data;
using SmartMed.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace SmartMed.Presentation.Authentication
{
    public partial class LoginForm : Form
    {

        private AuthenticationService auth = new AuthenticationService();
        
        public LoginForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = ColorTranslator.FromHtml("#102E30");
            loginCard.BackColor = ColorTranslator.FromHtml("#27453F");
            btn_login.HoverBackground = ColorTranslator.FromHtml("#DDF084");
            btn_login.HoverForeColor = ColorTranslator.FromHtml("#102E30");
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
          
            string email = txt_email.Text.Trim();
            string password = txt_password.Text;

            
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please enter your email.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_email.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter your password.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_password.Focus();
                return;
            }

            try
            {
                User user = auth.Login(email, password);

                MessageBox.Show($"Welcome, {user.email}!\nRole: {user.role}",
                    "Login Successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

              
                if (user.role == "Admin")
                {
                   
                    MessageBox.Show("Admin Dashboard would open here.", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                 
                }
                else if (user.role == "Customer")
                {

                    MessageBox.Show("Customer Dashboard would open here.", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Unknown user role.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                this.Hide();
            }
            catch (Exception ex)
            {
             
                MessageBox.Show(ex.Message, "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
