using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaDoZe
{
    /// <summary>
    /// Tela para acessar o status do pedido pelo seu ID
    /// </summary>
    public partial class TelaAcessarStatusPedidoAtendente : Form
    {
        
        readonly TelaStatusPedidoAtendente statusPedido = new TelaStatusPedidoAtendente();
        /// <summary>
        /// 
        /// </summary>
        public TelaAcessarStatusPedidoAtendente()
        {
            InitializeComponent();
            Funcoes.FecharEsc(this);
            Funcoes.AjustaResourcesControl(this);
            cancelBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            cancelBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            acessarBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            acessarBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            idPedidosAbertoscomboBox.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            idPedidosAbertoscomboBox.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);
            idPedidosAbertoscomboBox.Focus();
        }



        private void AcessarBtn_Click(object sender, EventArgs e)
        {
            statusPedido.ShowDialog();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
