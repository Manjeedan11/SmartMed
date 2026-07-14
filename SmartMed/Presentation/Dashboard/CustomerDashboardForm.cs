using SmartMed.Business;
using SmartMed.Models;
using SmartMed.Presentation.Authentication;
using SmartMed.Presentation.Customers;
using SmartMed.Presentation.Medicines;
using SmartMed.Presentation.Orders;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SmartMed.Presentation.Dashboard
{
    public partial class CustomerDashboardForm : BaseDashboardForm
    {
        private User currentUser;
        private Customer currentCustomer;
        private Panel dashboardContainer;
        private Form currentEmbeddedForm;

        public CustomerDashboardForm(User user, Customer customer)
        {
            InitializeComponent();
            currentUser = user;
            currentCustomer = customer;

            SetupDashboardContainer();

            btn_dashboard.Click += btn_dashboard_Click;
            btn_browseMedicines.Click += btn_browseMedicines_Click;
            btn_Mycart.Click += btn_Mycart_Click;
            btn_Myorders.Click += btn_Myorders_Click;
            btn_profile.Click += btn_profile_Click;
            btn_logOut.Click += logoutButton_Click;

            ShowDashboardContent();
            HighlightButton(btn_dashboard);

            totalOrdersStatCard.BackColor = ColorTranslator.FromHtml("#27453F");
            pendingOrdersStatCard.BackColor = ColorTranslator.FromHtml("#27453F");
            deliveredOrdersStatCard.BackColor = ColorTranslator.FromHtml("#27453F");
            recentOrdersStatCard.BackColor = ColorTranslator.FromHtml("#27453F");

            lb_totalOrders.ForeColor = ColorTranslator.FromHtml("#DDF084");
            lb_pendingOrders.ForeColor = ColorTranslator.FromHtml("#DDF084");
            lb_recentOrders.ForeColor = ColorTranslator.FromHtml("#DDF084");
            lb_deliveredOrders.ForeColor = ColorTranslator.FromHtml("#DDF084");

            txt_noTotalOrders.ForeColor = ColorTranslator.FromHtml("#DDF084");
            txt_noRecentOrders.ForeColor = ColorTranslator.FromHtml("#DDF084");
            txt_noPendingOrders.ForeColor = ColorTranslator.FromHtml("#DDF084");
            txt_noDeliveredOrders.ForeColor = ColorTranslator.FromHtml("#DDF084");

            LoadAdImage();
            LoadStatistics();
        }

        public CustomerDashboardForm()
        {
            InitializeComponent();
        }

        private void SetupDashboardContainer()
        {
            dashboardContainer = new Panel
            {
                Dock = DockStyle.Fill
            };

            var controlsToMove = new Control[contentPanel.Controls.Count];
            contentPanel.Controls.CopyTo(controlsToMove, 0);

            foreach (Control ctrl in controlsToMove)
            {
                contentPanel.Controls.Remove(ctrl);
                dashboardContainer.Controls.Add(ctrl);
            }

            contentPanel.Controls.Add(dashboardContainer);
        }

        private void ShowDashboardContent()
        {
            if (currentEmbeddedForm != null)
            {
                contentPanel.Controls.Remove(currentEmbeddedForm);
                currentEmbeddedForm.Dispose();
                currentEmbeddedForm = null;
            }

            if (dashboardContainer != null)
                dashboardContainer.Visible = true;

            LoadStatistics();
        }

        private void HideDashboardContent()
        {
            if (dashboardContainer != null)
                dashboardContainer.Visible = false;
        }

        private void ShowEmbeddedForm(Form form)
        {
            if (currentEmbeddedForm != null)
            {
                contentPanel.Controls.Remove(currentEmbeddedForm);
                currentEmbeddedForm.Dispose();
                currentEmbeddedForm = null;
            }

            HideDashboardContent();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Visible = true;

            contentPanel.Controls.Add(form);
            currentEmbeddedForm = form;
        }

        private void LoadAdImage()
        {
            string imageUrl = "https://ik.imagekit.io/f10phwyh5/UNI/adBanner.jpg";

            try
            {
                img_ad.ImageLocation = imageUrl;
                img_ad.LoadAsync();
                img_ad.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch
            {
                img_ad.Image = null;
                img_ad.BackColor = Color.LightGray;
            }
        }

        private void LoadStatistics()
        {
            try
            {
                var orderService = new OrderService();
                int customerId = currentCustomer.customerId;


                int totalOrders = orderService.GetTotalOrdersByCustomer(customerId);
                txt_noTotalOrders.Text = totalOrders.ToString();


                int pendingOrders = orderService.GetPendingOrdersByCustomer(customerId);
                txt_noPendingOrders.Text = pendingOrders.ToString();


                int deliveredOrders = orderService.GetDeliveredOrdersByCustomer(customerId);
                txt_noDeliveredOrders.Text = deliveredOrders.ToString();


                int recentOrders = orderService.GetRecentOrdersByCustomer(customerId);
                txt_noRecentOrders.Text = recentOrders.ToString();
            }
            catch (Exception ex)
            {

                txt_noTotalOrders.Text = "-";
                txt_noPendingOrders.Text = "-";
                txt_noDeliveredOrders.Text = "-";
                txt_noRecentOrders.Text = "-";
            }
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            HighlightButton((Control)sender);
            ShowDashboardContent();
        }

        private void btn_browseMedicines_Click(object sender, EventArgs e)
        {
            HighlightButton((Control)sender);
            BrowseMedicineForm browseForm = new BrowseMedicineForm();
            ShowEmbeddedForm(browseForm);
        }

        private void btn_Mycart_Click(object sender, EventArgs e)
        {
            HighlightButton((Control)sender);
            CartForm cartForm = new CartForm(currentCustomer);
            ShowEmbeddedForm(cartForm);
        }

        private void btn_Myorders_Click(object sender, EventArgs e)
        {
            HighlightButton((Control)sender);
            MyOrdersForm ordersForm = new MyOrdersForm(currentCustomer);
            ShowEmbeddedForm(ordersForm);
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            HighlightButton((Control)sender);
            ProfileForm profileForm = new ProfileForm(currentCustomer);
            ShowEmbeddedForm(profileForm);
        }

        private void btn_logOut_Click(object sender, EventArgs e)
        {
            Logout();
        }

    }
}