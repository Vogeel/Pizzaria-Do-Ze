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
    /// Tela para ver a descrição do pedido e do cliente que pediu
    /// </summary>
    public partial class TelaPedidoSelecionado : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public TelaPedidoSelecionado()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
