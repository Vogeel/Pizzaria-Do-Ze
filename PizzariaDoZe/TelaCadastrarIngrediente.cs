using PizzariaDoZe.DAO;
using System.Configuration;
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
    public partial class TelaCadastrarIngrediente : Form
    {
        private readonly IngredienteDAO dao;
        /// <summary>
        /// Tela para CRUD de ingredientes
        /// </summary>
        public TelaCadastrarIngrediente()
        {
            InitializeComponent();
            Funcoes.FecharEsc(this);
            Funcoes.AjustaResourcesControl(this);
            addBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            addBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            cancelBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            cancelBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            excluirSelecionadoBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            excluirSelecionadoBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            nomeTextBox.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            nomeTextBox.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);
            nomeTextBox.Focus();
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model
            dao = new IngredienteDAO(provider, strConnection);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            //Instância e Preenche o objeto com os dados da view
            var ingrediente = new Ingrediente
            {
                Id = 0,
                Nome = nomeTextBox.Text,
            };
            try
            {
                // chama o método para inserir da camada model
                dao.Inserir(ingrediente);
                MessageBox.Show("Dados inseridos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
