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
    /// ultima tela do pedido do cliente, onde ele seleciona forma de pagamento e se vai retirar ou vai ser pro Delivery a entrega
    /// </summary>
    public partial class TelaPedidoFinal : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public TelaPedidoFinal()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
        }

        private void FinalizarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
