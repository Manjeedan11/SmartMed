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
        public RegisterForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = ColorTranslator.FromHtml("#102E30");
            registerCard.BackColor = ColorTranslator.FromHtml("#27453F");
            btn_signUp.HoverBackground = ColorTranslator.FromHtml("#DDF084");
            btn_signUp.HoverForeColor = ColorTranslator.FromHtml("#102E30");
        }
    }
}
