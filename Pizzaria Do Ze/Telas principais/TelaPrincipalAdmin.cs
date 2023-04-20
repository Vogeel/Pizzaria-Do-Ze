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
        /// <summary>
        /// Tela quando um admin logar
        /// </summary>
    public partial class TelaPrincipalAdmin : Form
    {
        readonly TelaPrincipalEntregador entregas = new TelaPrincipalEntregador();
        readonly TelaCadastrarFuncionarios funcionarios = new TelaCadastrarFuncionarios();
        readonly TelaCadastroCliente pedido = new TelaCadastroCliente();
        readonly TelaPizzaAdmin pizza = new TelaPizzaAdmin();
        readonly TelaCadastroFornecedor fornecedor = new TelaCadastroFornecedor();
        readonly TelaAcessarStatusPedidoAtendente editStatus = new TelaAcessarStatusPedidoAtendente();
        readonly TelaCadastrarBebidas bebidas = new TelaCadastrarBebidas();
        readonly ContextMenuStrip menuContext = new ContextMenuStrip();

        /// <summary>
        /// Tela quando um admin logar
        /// </summary>
        public TelaPrincipalAdmin()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
            bebidasBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            bebidasBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            cadastroFuncionarioBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            cadastroFuncionarioBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            editarStatusPedidoBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            editarStatusPedidoBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            fornecedorBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            fornecedorBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            pedidoBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            pedidoBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            pizzaBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            pizzaBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            visPedidoBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            visPedidoBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            voltarBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            voltarBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);
            pizzaToolStripMenuItem.Click += new EventHandler(PizzaBtn_Click);
            bebidaToolStripMenuItem.Click += new EventHandler(BebidasBtn_Click);
            editarStatusToolStripMenuItem.Click += new EventHandler(EditarStatusPedido_Click);
            fornecedorToolStripMenuItem.Click += new EventHandler(FornecedorBtn_Click);
            funcionarioToolStripMenuItem.Click += new EventHandler(CadastroFuncionarioBtn_Click);
            realizarToolStripMenuItem.Click += new EventHandler(PedidoBtn_Click);
            sairToolStripMenuItem.Click += new EventHandler(VoltarBtn_Click);
            visualizarToolStripMenuItem.Click += new EventHandler(visPedidoBtn_Click);




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
