using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using System.Reflection;
using System.Resources;
using System.Configuration;

namespace Pizzaria_Do_Ze
{
    internal static class Program
    {
        /// <summary>
        /// aplicação de incio
        /// </summary>
        [STAThread]
        static void Main()
        {

            /// <summary>
            /// Parte que se faz para alterar o idioma do projeto todo
            /// </summary>
            /// <param name="auxIdiomaRegiao"> string que leva o novo idioma </param>
            string auxIdiomaRegiao = ConfigurationManager.AppSettings.Get("IdiomaRegiao");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(auxIdiomaRegiao);
            Thread.CurrentThread.CurrentCulture = new CultureInfo(auxIdiomaRegiao);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TelaLogin());
        }
    }
}
