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
    /// Tela para o usuario escolher qual tamanho de pizza ele deseja
    /// </summary>
    public partial class TelaTamanhoPizza : Form
    {
        readonly TelaPedidoCliente pedido = new TelaPedidoCliente();
        /// <summary>
        /// 
        /// </summary>
        public TelaTamanhoPizza()
        {
            InitializeComponent();
            Funcoes.FecharEsc(this);
            Funcoes.AjustaResourcesControl(this);
            cancelBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            cancelBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            comprarBrotoBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            comprarBrotoBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            comprarExtraGiganteBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            comprarExtraGiganteBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            comprarGiganteBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            comprarGiganteBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            comprarMediaBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            comprarMediaBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);

        }

        private void ComprarExtraGiganteBtn_Click(object sender, EventArgs e)
        {
            pedido.ShowDialog();
        }

        private void ComprarGiganteBtn_Click(object sender, EventArgs e)
        {
            pedido.ShowDialog();
        }

        
        private void ComprarBrotoBtn_Click(object sender, EventArgs e)
        {
            pedido.ShowDialog();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComprarMediaBtn_Click(object sender, EventArgs e)
        {
            pedido.ShowDialog();
        }

       
    }
}
