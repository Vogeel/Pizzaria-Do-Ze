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
            Funcoes.AjustaResourcesControl(this);

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
