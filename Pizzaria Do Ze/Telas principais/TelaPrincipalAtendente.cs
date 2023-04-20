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
    /// <summary>
    /// Tela se um atendente logar
    /// </summary>
    public partial class TelaPrincipalAtendente : Form
    {
        readonly TelaCadastroCliente cadCliente = new TelaCadastroCliente();
        readonly TelaAcessarStatusPedidoAtendente status = new TelaAcessarStatusPedidoAtendente();
        readonly TelaPrincipalEntregador telaPedido = new TelaPrincipalEntregador();
        /// <summary>
        /// construtor da tela do atendente
        /// </summary>
        public TelaPrincipalAtendente()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
            voltarBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            voltarBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            editarStatusPedidoBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            editarStatusPedidoBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            pedidoBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            pedidoBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            visPedidoBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            visPedidoBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);
            editarStatusPedidoToolStripMenuItem.Click += new EventHandler(EditarStatusPedidoBtn_Click);
            realizarPedidoToolStripMenuItem.Click += new EventHandler(pedidoBtn_Click);
            visualizarPedidoToolStripMenuItem.Click += new EventHandler(VisPedidoBtn_Click);


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
