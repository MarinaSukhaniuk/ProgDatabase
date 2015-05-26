using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rgr_34
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new admin_log());
            
            Application.Run(new EnterForm());//ЗАПУСК ВСЕГО

            //Application.Run(new clients_form("Суханюк", "Марина"));

            //Application.Run(new ManagerForm());

        }
    }
}
