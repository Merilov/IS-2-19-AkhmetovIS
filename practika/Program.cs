using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practika
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
            Application.Run(new Menu());
        }
    }
    public class Connect
    {
        public string Connstring = "server=caseum.ru;port=33333;user=test_user;database=db_test;password=test_pass;";
        public string GetConne()
        {
            return Connstring;
        }
    }
}
