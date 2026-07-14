using SmartMed.Presentation.Authentication;
using SmartMed.Presentation.Medicines;
using System;
using System.Windows.Forms;

namespace SmartMed
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());   
        }
    }
}