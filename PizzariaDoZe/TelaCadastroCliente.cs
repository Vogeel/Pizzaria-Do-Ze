using PizzariaDoZe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaDoZe
{
    /// <summary>
    /// 
    /// </summary>
    public partial class TelaCadastroCliente : Form
    {
        TelaVisualizarCliente vis = new TelaVisualizarCliente();
        
        readonly TelaTamanhoPizza pedido = new TelaTamanhoPizza();
        /// <summary>
        /// Tela para cadastrar um novo cliente ou puxar um cadastro antigo
        /// </summary>
        /// 
        private readonly EnderecoDAO enderecoDAO;
        private readonly ClienteDAO clienteDAO;

        public TelaCadastroCliente()
        {
            InitializeComponent();
            Funcoes.FecharEsc(this);
            CamposCadsatroUserControl campos = new CamposCadsatroUserControl();
            campos.nomeTextBot.Focus();
            Funcoes.AjustaResourcesControl(this);
            cadastrarBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            cadastrarBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            cancelBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            cancelBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            clienteCadastradoBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            clienteCadastradoBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);
            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            enderecoDAO = new EnderecoDAO(provider, strConnection);
            clienteDAO = new ClienteDAO(provider, strConnection);
            camposCadsatroUserControl1.CEPMaskedTB.Leave += MaskedTextBoxCep_Leave;
        }



        private void CadastrarBtn_Click(object sender, EventArgs e)
        {
            if (camposCadsatroUserControl1.idTextBox.Text.Length <= 0)
            {
                MessageBox.Show("Selecione um endereço valido!");
                return;
            }
            //Instância e Preenche o objeto com os dados da view
            var cliente = new Cliente
            {
                Id = 0,
                Nome = camposCadsatroUserControl1.nomeTextBot.Text,
                Cpf = camposCadsatroUserControl1.CPFMaskedTB.Text,
                Telefone = camposCadsatroUserControl1.telefoneMaskTB.Text,
                Email = camposCadsatroUserControl1.emailTextBox.Text,
                EnderecoId = int.Parse(camposCadsatroUserControl1.idTextBox.Text),
                Numero = camposCadsatroUserControl1.numeroTextBox.Text,
                Complemento = camposCadsatroUserControl1.complementoTextBox.Text,
            };
            try
            {
                // chama o método da model para inserir e capturar o ID do cliente
                int IdClienteGerado = clienteDAO.Inserir(cliente);
                MessageBox.Show("Dados inseridos com sucesso! ClienteID: " + IdClienteGerado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            pedido.ShowDialog();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MaskedTextBoxCep_Leave(object? sender, EventArgs e)
        {
            if (camposCadsatroUserControl1.CEPMaskedTB.Text.Trim().Length <= 0)
            {
                return;
            }
            var endereco = new Endereco
            {
                Cep = camposCadsatroUserControl1.CEPMaskedTB.Text.Trim(),
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = enderecoDAO.Buscar(endereco);
                // seta os dados na tela
                camposCadsatroUserControl1.idTextBox.Text = "";
                //userControlEndereco.maskedTextBoxCep.Text = "";
                camposCadsatroUserControl1.longradouroTextBox.Text = "";
                camposCadsatroUserControl1.bairroTextBox.Text = "";
                camposCadsatroUserControl1.cidadeTextBox.Text = "";
                camposCadsatroUserControl1.ufTextBox.Text = "";
                camposCadsatroUserControl1.paisTextBox.Text = "";
                foreach (DataRow row in linhas.Rows)
                {
                    camposCadsatroUserControl1.idTextBox.Text = row["id"].ToString(); ;
                    camposCadsatroUserControl1.CEPMaskedTB.Text = row["cep"].ToString(); ;
                    camposCadsatroUserControl1.longradouroTextBox.Text = row["logradouro"].ToString(); ;
                    camposCadsatroUserControl1.bairroTextBox.Text = row["bairro"].ToString(); ;
                    camposCadsatroUserControl1.cidadeTextBox.Text = row["cidade"].ToString(); ;
                    camposCadsatroUserControl1.ufTextBox.Text = row["uf"].ToString(); ;
                    camposCadsatroUserControl1.paisTextBox.Text = row["pais"].ToString(); ;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Pizzaria do Zé", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TelaCadastroCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            vis.AtualizarTela();
            vis.ShowDialog();
        }
    }
}
