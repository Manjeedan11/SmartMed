using SmartMed.Business;
using SmartMed.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SmartMed.Presentation.Customers
{
    public partial class ProfileForm : Form
    {
        private CustomerService customerService = new CustomerService();
        private Customer currentCustomer;

        public ProfileForm(Customer customer)
        {
            InitializeComponent();
            currentCustomer = customer;

            LoadProfileData();
            LoadProfileImage();

            btn_update.Click += btn_update_Click;
        }

        private void LoadProfileData()
        {
            if (currentCustomer == null)
                return;

            lb_fullName.Text = currentCustomer.fullName ?? "N/A";
            lb_phoneNumber.Text = currentCustomer.phoneNumber ?? "N/A";
            lb_email.Text = currentCustomer.User?.email ?? "N/A";

            txt_name.Content = currentCustomer.fullName ?? "";
            txt_phoneNumber.Content = currentCustomer.phoneNumber ?? "";
            txt_email.Content = currentCustomer.User?.email ?? "";
            txt_address.Content = currentCustomer.address ?? "";
        }

        private void LoadProfileImage()
        {
            
            string imageUrl = "https://ik.imagekit.io/f10phwyh5/UNI/profilePlaceholder.png";

            try
            {
                img_profile.ImageLocation = imageUrl;
                img_profile.LoadAsync();
                img_profile.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch
            {
                img_profile.Image = null;
                img_profile.BackColor = Color.LightGray;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                string fullName = txt_name.Content.Trim();
                string phone = txt_phoneNumber.Content.Trim();
                string address = txt_address.Content.Trim();
                string email = txt_email.Content.Trim();

                if (string.IsNullOrWhiteSpace(fullName))
                {
                    MessageBox.Show("Full name is required.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_name.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(phone))
                {
                    MessageBox.Show("Phone number is required.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_phoneNumber.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(email))
                {
                    MessageBox.Show("Email is required.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txt_email.Focus();
                    return;
                }

                
                currentCustomer.UpdateProfile(fullName, phone, address);

                bool success = customerService.UpdateCustomer(currentCustomer, email);

                if (success)
                {
                    MessageBox.Show("Profile updated successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProfileData();
                }
                else
                {
                    MessageBox.Show("Failed to update profile. Please try again.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}