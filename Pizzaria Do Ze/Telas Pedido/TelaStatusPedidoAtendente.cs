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
    /// Tela para o adtendete/admin alterar o status do pedido
    /// </summary>
    public partial class TelaStatusPedidoAtendente : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public TelaStatusPedidoAtendente()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);

        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
