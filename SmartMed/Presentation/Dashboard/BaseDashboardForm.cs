using SmartMed.Presentation.Authentication;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SmartMed.Presentation.Dashboard
{
    public partial class BaseDashboardForm : Form
    {
        public BaseDashboardForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = ColorTranslator.FromHtml("#1A1A2E");

            sidebarPanel.BackColor = ColorTranslator.FromHtml("#102E30");
            contentPanel.BackColor = ColorTranslator.FromHtml("#FFFFFF");

            LoadLogo();
        }

        private void LoadLogo()
        {
            string logoUrl = "https://ik.imagekit.io/f10phwyh5/UNI/smartMedLogo.png";

            try
            {
                img_logo.ImageLocation = logoUrl;
                img_logo.LoadAsync();
                img_logo.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch
            {
                img_logo.Image = null;
                img_logo.BackColor = Color.LightGray;
            }
        }

        // =========================================================
        //  LOGOUT – NOW PROTECTED SO DERIVED FORMS CAN USE IT
        // =========================================================
        protected void Logout()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?",
                "Logout Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Find existing LoginForm
                LoginForm loginForm = null;
                foreach (Form form in Application.OpenForms)
                {
                    if (form is Authentication.LoginForm)
                    {
                        loginForm = (Authentication.LoginForm)form;
                        break;
                    }
                }

                if (loginForm != null)
                {
                    loginForm.Show();
                }
                else
                {
                    loginForm = new Authentication.LoginForm();
                    loginForm.Show();
                }

                this.Close();
            }
        }

        // Event handler for the logout button in the designer – now protected
        protected virtual void logoutButton_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void BaseDashboardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // App stays alive – LoginForm is hidden, not closed.
        }

        protected void ShowContentPanel(UserControl control)
        {
            contentPanel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(control);
        }

        protected void HighlightButton(Control activeControl)
        {
            Color defaultBg = ColorTranslator.FromHtml("#102E30");
            Color defaultFg = ColorTranslator.FromHtml("#DDF084");
            Color activeBg = ColorTranslator.FromHtml("#DDF084");
            Color activeFg = ColorTranslator.FromHtml("#102E30");

            foreach (Control control in sidebarPanel.Controls)
            {
                if (control is Button || control.GetType().Name == "cuiButton")
                {
                    control.BackColor = defaultBg;
                    control.ForeColor = defaultFg;
                }
            }

            if (activeControl != null)
            {
                activeControl.BackColor = activeBg;
                activeControl.ForeColor = activeFg;
            }
        }

        protected void AddMenuButton(string text, int yPosition, EventHandler clickEvent)
        {
            Button btn = new Button
            {
                Text = text,
                Location = new Point(10, yPosition),
                Size = new Size(200, 40),
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 },
                BackColor = ColorTranslator.FromHtml("#16213E"),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10F),
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(10, 0, 0, 0)
            };
            btn.Click += clickEvent;
            sidebarPanel.Controls.Add(btn);
        }
    }
}