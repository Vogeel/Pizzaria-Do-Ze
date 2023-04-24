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
    /// 
    /// </summary>
    public partial class TelaPrincipalEntregador : Form
    {
        readonly TelaPedidosEntregues entregues = new TelaPedidosEntregues();
        readonly TelaPedidosPendentes pendentes = new TelaPedidosPendentes();
        /// <summary>
        /// Tela se um entregador logar
        /// </summary>
        public TelaPrincipalEntregador()
        {
            InitializeComponent();
            Funcoes.FecharEsc(this);
            Funcoes.AjustaResourcesControl(this);
            pedEntreguesBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            pedEntreguesBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            pedPendentesBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            pedPendentesBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            voltarBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            voltarBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);
            pedidosEntreguesToolStripMenuItem.Click += new EventHandler(PedEntreguesBtn_Click);
            pedidosPendentesToolStripMenuItem.Click += new EventHandler(PedPendentesBtn_Click);
        }

        private void PedPendentesBtn_Click(object sender, EventArgs e)
        {
            pendentes.ShowDialog();
            
        }

        private void PedEntreguesBtn_Click(object sender, EventArgs e)
        {
            entregues.ShowDialog();
        }

        private void VoltarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
