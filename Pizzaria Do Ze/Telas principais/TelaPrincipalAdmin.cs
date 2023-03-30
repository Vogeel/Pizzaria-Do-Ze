﻿using Pizzaria_Do_Ze.Telas_Admin;
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
        readonly TelaPrincipalEntregador entregas = new TelaPrincipalEntregador();
        readonly TelaCadastrarFuncionarios funcionarios = new TelaCadastrarFuncionarios();
        readonly TelaCadastroCliente pedido = new TelaCadastroCliente();
        readonly TelaPizzaAdmin pizza = new TelaPizzaAdmin();
        readonly TelaCadastroFornecedor fornecedor = new TelaCadastroFornecedor();
        readonly TelaAcessarStatusPedidoAtendente editStatus = new TelaAcessarStatusPedidoAtendente();
        readonly TelaCadastrarBebidas bebidas = new TelaCadastrarBebidas();
        public TelaPrincipalAdmin()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);

        }

        private void PizzaBtn_Click(object sender, EventArgs e)
        {
            pizza.ShowDialog();
        }

        private void PedidoBtn_Click(object sender, EventArgs e)
        {
            pedido.ShowDialog();
        }
      
        private void CadastroFuncionarioBtn_Click(object sender, EventArgs e)
        {
            funcionarios.ShowDialog();
        }

        private void VoltarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void FornecedorBtn_Click(object sender, EventArgs e)
        {
            fornecedor.ShowDialog();
        }

        private void BebidasBtn_Click(object sender, EventArgs e)
        {
            bebidas.ShowDialog();
        }

        private void EditarStatusPedido_Click(object sender, EventArgs e)
        {
            editStatus.ShowDialog();

        }

        private void visPedidoBtn_Click(object sender, EventArgs e)
        {
            entregas.ShowDialog();

        }
    }
}
