using System;
using System.Configuration;
using System.Windows.Forms;
using PL;

namespace Project
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string DB_path = ConfigurationManager.AppSettings.Get("DB_Path");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(DB_path));
        }
    }
}
