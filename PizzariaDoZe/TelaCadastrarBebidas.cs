using PizzariaDoZe.DAO;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace PizzariaDoZe
{
    /// <summary>
    /// 
    /// </summary>
    public partial class TelaCadastrarBebidas : Form
    {
        private ProdutoDAO produtoDAO;
        TelaVisualizarBebidas visualizarBebidas = new TelaVisualizarBebidas();
        /// <summary>
        /// Tela CRUD de bebidas
        /// </summary>
        public TelaCadastrarBebidas()
        {
            InitializeComponent();
            Funcoes.FecharEsc(this);
            Funcoes.AjustaResourcesControl(this);
            cadastrarBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            cadastrarBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            cancelBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            cancelBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            textBoxNome.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            textBoxNome.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            maskedTextBoxValor.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            maskedTextBoxValor.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);
            CarregaEnumListBox();
            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            produtoDAO = new ProdutoDAO(provider, strConnection);
        }

        private void CarregaEnumListBox()
        {
            //popular listBoxTipo
            listBoxTipo.Items.Clear();
            listBoxTipo.DataSource = Enum.GetValues(typeof(EnumProdutoTipo));
        }

        private void CadastrarBtn_Click(object sender, EventArgs e)
        {
            //Instância e Preenche o objeto com os dados da view
            var produto = new Produto
            {
                Id = 0,
                Descricao = textBoxNome.Text,
                Valor = decimal.Parse(maskedTextBoxValor.Text),
                Tipo = (char)(EnumProdutoTipo)Enum.Parse(typeof(EnumProdutoTipo), listBoxTipo.Text),
                ML = listBoxTamanho.Text,
            };
            try
            {
                // chama o método para inserir da camada model
                produtoDAO.Inserir(produto);
                MessageBox.Show("Dados inseridos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonVisualizar_Click(object sender, EventArgs e)
        {
            visualizarBebidas.AtualizarTela();
            visualizarBebidas.ShowDialog();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
