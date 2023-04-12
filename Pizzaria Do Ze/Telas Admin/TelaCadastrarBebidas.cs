using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria_Do_Ze.Telas_Admin
{
    /// <summary>
    /// 
    /// </summary>
    public partial class TelaCadastrarBebidas : Form
    {
        /// <summary>
        /// Tela CRUD de bebidas
        /// </summary>
        public TelaCadastrarBebidas()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
        }

        private void CadastrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
