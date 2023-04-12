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
    /// Tela para o Entregador ver quais pedidos ele ja entregou
    /// </summary>
    public partial class TelaPedidosEntregues : Form
    {
        /// <summary>
        /// 
        /// </summary>
        readonly TelaPedidoSelecionado pedidoSelecionado = new TelaPedidoSelecionado();
        public TelaPedidosEntregues()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
        }

        private void AbrirPedidoBtn_Click(object sender, EventArgs e)
        {
            pedidoSelecionado.ShowDialog();
        }

        

        private void CancelBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
