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
    public partial class TelaPedidoCliente : Form
    {
        readonly TelaPedidoFinal pedidoFinal = new TelaPedidoFinal();
        readonly TelaRetirarIngrediente retirarIngrediente = new TelaRetirarIngrediente();
        public TelaPedidoCliente()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
        }

        private void SeguinteBtn_Click(object sender, EventArgs e)
        {
            pedidoFinal.ShowDialog();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RetirarIngredienteBtn_Click(object sender, EventArgs e)
        {
            retirarIngrediente.ShowDialog();
        }
    }
}
