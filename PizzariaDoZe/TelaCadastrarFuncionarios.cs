using PizzariaDoZe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaDoZe
{
    /// <summary>
    /// 
    /// </summary>
    public partial class TelaCadastrarFuncionarios : Form
    {
        TelaVisualizarFuncionario vis = new TelaVisualizarFuncionario();
        private readonly EnderecoDAO enderecoDAO;
        private readonly FuncionarioDAO funcionarioDAO;

        Funcoes funcoes = new Funcoes();

        /// <summary>
        /// Tela para cadastrar um novo funcionario e sua atuação(entregador, atendente ou admin)
        /// </summary>
        public TelaCadastrarFuncionarios()
        {
            InitializeComponent();
            Funcoes.FecharEsc(this);
            Funcoes.AjustaResourcesControl(this);
            adminRadioBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            adminRadioBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            atendenteRadioBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            atendenteRadioBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            cadastrarBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            cadastrarBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            cancelBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            cancelBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            entregadorRadioBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            entregadorRadioBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            cnhMaskedTB.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            cnhMaskedTB.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            CPFmaskedTextBox.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            CPFmaskedTextBox.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            matriculaTB.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            matriculaTB.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            nomeTB.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            nomeTB.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            senhaMaskedTB.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            senhaMaskedTB.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            telefoneMaskedTextBox.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            telefoneMaskedTextBox.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            validadeCNHdateTimePicker.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            validadeCNHdateTimePicker.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);
            nomeTB.Focus();
            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            enderecoDAO = new EnderecoDAO(provider, strConnection);
            funcionarioDAO = new FuncionarioDAO(provider, strConnection);

        }

        public void CadastrarBtn_Click(object sender, EventArgs e)
        {
            if (idEnderecotextBox.Text.Length <= 0)
            {
                MessageBox.Show("Selecione um endereço valido!");
                return;
            }
            //Instância e Preenche o objeto com os dados da view
            var funcionario = new Funcionario
            {
                Id = 0,
                Nome = nomeTB.Text,
                Cpf = CPFmaskedTextBox.Text,
                Matricula = matriculaTB.Text,
                Senha = funcoes.Sha256Hash(senhaMaskedTB.Text),
                Grupo = (adminRadioBtn.Checked) ? '1' : (atendenteRadioBtn.Checked) ? '2' : '3',
                Motorista = cnhMaskedTB.Text,
                Validade = validadeCNHdateTimePicker.Value,
                Observacao = observacaotextBox.Text,
                Telefone = telefoneMaskedTextBox.Text,
                Email = emailtextBox.Text,
                EnderecoId = int.Parse(idEnderecotextBox.Text),
                Numero = numerotextBox.Text,
                Complemento = complementotextBox.Text,
            };
            try
            {
                // chama o método da model para inserir e capturar o ID do cliente
                int IdFuncionarioGerado = funcionarioDAO.Inserir(funcionario);
                MessageBox.Show("Dados inseridos com sucesso! ID Funcionario: " + IdFuncionarioGerado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close ();
        }

        private void CEPmaskedTextBox_Leave(object sender, EventArgs e)
        {
            if (CEPmaskedTextBox.Text.Trim().Length <= 0)
            {
                return;
            }
            var endereco = new Endereco
            {
                Cep = CEPmaskedTextBox.Text.Trim(),
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = enderecoDAO.Buscar(endereco);
                // seta os dados na tela
                idEnderecotextBox.Text = "";
                //userControlEndereco.maskedTextBoxCep.Text = "";
                longradourotextBox.Text = "";
                bairrotextBox.Text = "";
                cidadetextBox.Text = "";
                uftextBox.Text = "";
                paistextBox.Text = "";
                foreach (DataRow row in linhas.Rows)
                {
                    idEnderecotextBox.Text = row["id"].ToString(); ;
                    CEPmaskedTextBox.Text = row["cep"].ToString(); ;
                    longradourotextBox.Text = row["logradouro"].ToString(); ;
                    bairrotextBox.Text = row["bairro"].ToString(); ;
                    cidadetextBox.Text = row["cidade"].ToString(); ;
                    uftextBox.Text = row["uf"].ToString(); ;
                    paistextBox.Text = row["pais"].ToString(); ;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Pizzaria do Zé", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
