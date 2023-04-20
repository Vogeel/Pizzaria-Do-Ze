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
    /// Tela para o Entregador ver seus pedidos pendentes (que estao em produção)
    /// </summary>
    public partial class TelaPedidosPendentes : Form
    {
        readonly TelaPedidoSelecionado pedidoSelecionado = new TelaPedidoSelecionado();
        /// <summary>
        /// 
        /// </summary>
        public TelaPedidosPendentes()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
            abrirPedidoBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            abrirPedidoBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            cancelBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            cancelBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);
        }

        private void AbrirPedidoBtn_Click(object sender, EventArgs e)
        {
            pedidoSelecionado.ShowDialog();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
