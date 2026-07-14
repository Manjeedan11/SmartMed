using SmartMed.Business;
using SmartMed.Data;
using SmartMed.Models;
using SmartMed.Presentation.Dashboard;
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
        private CustomerRepository customerRepository = new CustomerRepository();

        public LoginForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = ColorTranslator.FromHtml("#102E30");
            loginCard.BackColor = ColorTranslator.FromHtml("#27453F");
            btn_login.HoverBackground = ColorTranslator.FromHtml("#DDF084");
            btn_login.HoverForeColor = ColorTranslator.FromHtml("#102E30");
            lb_signUp.ForeColor = ColorTranslator.FromHtml("#DDF084");
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

                
                if (user.role == "Admin")
                {
                    AdminDashboardForm adminDashboard = new AdminDashboardForm(user);
                    adminDashboard.Show();
                    this.Hide();
                }
                else if (user.role == "Customer")
                {
                  
                    Customer customer = customerRepository.GetCustomerByUserId(user.userId);
                    if (customer == null)
                    {
                        MessageBox.Show("Customer profile not found.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    CustomerDashboardForm customerDashboard = new CustomerDashboardForm(user, customer);
                    customerDashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Unknown user role.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }
    }
}
