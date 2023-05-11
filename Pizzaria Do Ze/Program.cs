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
using System.Data.Common;

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
            //DbProviderFactories.RegisterFactory("System.Data.SqlClient", System.Data.SqlClient.SqlClientFactory.Instance);
            //DbProviderFactories.RegisterFactory("MySql.Data.MySqlClient", MySql.Data.MySqlClient.MySqlClientFactory.Instance);

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
