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

namespace Pizzaria_Do_Ze.Telas_cadastros
{
    public partial class TelaCadastroCliente : Form
    {
        readonly TelaTamanhoPizza pedido = new TelaTamanhoPizza();
        public TelaCadastroCliente()
        {
            InitializeComponent();
        }

        private void VoltarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CadastrarBtn_Click(object sender, EventArgs e)
        {
            
            pedido.ShowDialog();
        }
    }
}
