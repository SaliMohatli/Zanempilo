using System;
using System.Windows.Forms;
using WinFormsApp2; // Add this at the top if Login is in the same namespace

namespace WinFormsApp2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Login()); // Change 'Login' to your new form's class name
        }
    }
}