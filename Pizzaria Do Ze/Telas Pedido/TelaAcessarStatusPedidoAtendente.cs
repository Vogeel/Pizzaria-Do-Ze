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
    public partial class TelaAcessarStatusPedidoAtendente : Form
    {
        readonly TelaStatusPedidoAtendente statusPedido = new TelaStatusPedidoAtendente();
        public TelaAcessarStatusPedidoAtendente()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AcessarBtn_Click(object sender, EventArgs e)
        {
            statusPedido.ShowDialog();
        }
    }
}
