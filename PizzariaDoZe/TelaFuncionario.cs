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
    
    public partial class TelaFuncionario : Form
    {
        TelaVisualizarFuncionario visualizar = new TelaVisualizarFuncionario();
        TelaCadastrarFuncionarios cadastro = new TelaCadastrarFuncionarios();
        public TelaFuncionario()
        {
            InitializeComponent();
        }

        private void visualizarClienteBtn_Click(object sender, EventArgs e)
        {
            visualizar.ShowDialog();
        }

        private void cadastroBtn_Click(object sender, EventArgs e)
        {
            cadastro.ShowDialog();
        }

        private void voltarBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
