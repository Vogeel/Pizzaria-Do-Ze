using Pizzaria_Do_Ze.Telas_cadastros;
using Pizzaria_Do_Ze.Telas_Pedido;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria_Do_Ze
{
    public partial class TelaPrincipalAtendente : Form
    {
        readonly TelaCadastroCliente cadCliente = new TelaCadastroCliente();
        readonly TelaAcessarStatusPedidoAtendente status = new TelaAcessarStatusPedidoAtendente();
        readonly TelaPrincipalEntregador telaPedido = new TelaPrincipalEntregador();
        public TelaPrincipalAtendente()
        {
            InitializeComponent();
        }

        

          

        private void VisPedidoBtn_Click(object sender, EventArgs e)
        {
            telaPedido.ShowDialog();
        }

        private void EditarStatusPedidoBtn_Click(object sender, EventArgs e)
        {
            status.ShowDialog();
        }

        private void VoltarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pedidoBtn_Click(object sender, EventArgs e)
        {
            cadCliente.ShowDialog();
        }
    }
}
