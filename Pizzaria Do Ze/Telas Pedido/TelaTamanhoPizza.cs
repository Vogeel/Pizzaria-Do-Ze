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
    public partial class TelaTamanhoPizza : Form
    {
        TelaPedidoCliente pedido = new TelaPedidoCliente();
        public TelaTamanhoPizza()
        {
            InitializeComponent();
        }

        private void comprarExtraGiganteBtn_Click(object sender, EventArgs e)
        {
            pedido.Show();
        }

        private void comprarGiganteBtn_Click(object sender, EventArgs e)
        {
            pedido.Show();
        }

        
        private void comprarBrotoBtn_Click(object sender, EventArgs e)
        {
            pedido.Show();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comprarMediaBtn_Click(object sender, EventArgs e)
        {
            pedido.Show();
        }

       
    }
}
