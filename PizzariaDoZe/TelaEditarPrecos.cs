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
    public partial class TelaEditarPrecos : Form
    {
        /// <summary>
        /// Tela para editar os preços das pizzas
        /// </summary>
        private ValorDAO valorDAO;
        TelaVisualizarPrecos visualizarPrecos = new TelaVisualizarPrecos();
        public TelaEditarPrecos()
        {
            InitializeComponent();
            Funcoes.FecharEsc(this);
            Funcoes.AjustaResourcesControl(this);
            atualizarBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            atualizarBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            cancelBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            cancelBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);
            MaskedTextBoxValor.Focus();
            CarregaEnumListBox();
            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection =
            ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            valorDAO = new ValorDAO(provider, strConnection);
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       


        private void CarregaEnumListBox()
        {
            //popular listBoxTipo
            listBoxTamanho.Items.Clear();
            listBoxTamanho.DataSource = Enum.GetValues(typeof(EnumValorTamanho));
            //popular listBoxCategoria
            listBoxCategoria.Items.Clear();
            listBoxCategoria.DataSource = Enum.GetValues(typeof(EnumSaborCategoria));
        }

        private void atualizarBtn_Click(object sender, EventArgs e)
        {
            //Instância e Preenche o objeto com os dados da view
            var valor = new Valor
            {
                Id = 0,
                Tamanho = (char)(EnumValorTamanho)Enum.Parse(typeof(EnumValorTamanho), listBoxTamanho.Text),
                Categoria = (char)(EnumSaborCategoria)Enum.Parse(typeof(EnumSaborCategoria), listBoxCategoria.Text),
                ValorPizza = decimal.Parse(MaskedTextBoxValor.Text),
                ValorBorda = decimal.Parse(MaskedTextBoxBorda.Text),
            };
            try
            {
                // chama o método para inserir da camada model
                valorDAO.Inserir(valor);
                MessageBox.Show("Dados inseridos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonVisualizar_Click(object sender, EventArgs e)
        {
            visualizarPrecos.AtualizarTela();
            visualizarPrecos.ShowDialog();
        }
    }
}
