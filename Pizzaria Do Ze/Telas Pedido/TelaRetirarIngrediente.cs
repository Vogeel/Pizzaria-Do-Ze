using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria_Do_Ze.Telas_Pedido
{
    /// <summary>
    /// Tela para retirar algum ingredietne do sabor da pizza escolhida pelo cliente
    /// </summary>
    public partial class TelaRetirarIngrediente : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public TelaRetirarIngrediente()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);

        }
        private void ConcluirBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
