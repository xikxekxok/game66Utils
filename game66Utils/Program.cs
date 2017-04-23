using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using game66Utils.Factory;
using Ninject;

namespace game66Utils
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
            DiContainer.Register();
            var form = DiContainer.Kernel.Get<PriceCompareForm>();
            Application.Run(form);
        }
    }
}
