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

        }
    }
}
