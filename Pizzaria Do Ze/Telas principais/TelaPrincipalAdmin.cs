using Pizzaria_Do_Ze.Telas_Admin;
using Pizzaria_Do_Ze.Telas_Cadastrais;
using Pizzaria_Do_Ze.Telas_cadastros;
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

namespace Pizzaria_Do_Ze
{
    public partial class TelaPrincipalAdmin : Form
    {
        TelaPrincipalEntregador entregas = new TelaPrincipalEntregador();
        TelaCadastrarFuncionarios funcionarios = new TelaCadastrarFuncionarios();
        TelaCadastroCliente pedido = new TelaCadastroCliente();
        TelaPizzaAdmin pizza = new TelaPizzaAdmin();
        TelaCadastroFornecedor fornecedor = new TelaCadastroFornecedor();
        TelaAcessarStatusPedidoAtendente editStatus = new TelaAcessarStatusPedidoAtendente();
        TelaCadastrarBebidas bebidas = new TelaCadastrarBebidas();
        public TelaPrincipalAdmin()
        {
            InitializeComponent();
        }

        

        private void pizzaBtn_Click(object sender, EventArgs e)
        {
            pizza.ShowDialog();
        }

        private void pedidoBtn_Click(object sender, EventArgs e)
        {
            pedido.ShowDialog();
        }
        private void visualizarPedidosBtn_Click(object sender, EventArgs e)
        {
            entregas.ShowDialog();
        }

        private void cadastroFuncionarioBtn_Click(object sender, EventArgs e)
        {
            funcionarios.ShowDialog();
        }

        private void voltarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editarStatusBtn_Click(object sender, EventArgs e)
        {
            editStatus.ShowDialog();
        }

        private void fornecedorBtn_Click(object sender, EventArgs e)
        {
            fornecedor.ShowDialog();
        }

        private void bebidasBtn_Click(object sender, EventArgs e)
        {
            bebidas.ShowDialog();
        }

        
    }
}
