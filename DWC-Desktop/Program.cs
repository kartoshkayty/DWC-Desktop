using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DWC_Desktop.Classes;
using DWC_Desktop.Database;
using DWC_Desktop.Forms.Auth;
using DWC_Desktop.Utils;

namespace DWC_Desktop
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Config.Init();
            DB.Init();

            List<LocalUser> users = Users.GetUsers();

            if (users.Count == 0)
            {
                Application.Run(new LoginForm());

                return;
            }

            Application.Run(new AccountsForm());
        }
    }
}
