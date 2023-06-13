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
using PizzariaDoZe.DAO;

namespace PizzariaDoZe
{
    /// <summary>
    /// Tela para editar o sabor(excluindo/adicionadno ingrediente)
    /// </summary>
    public partial class TelaEditSabores : Form
    {
        /// <summary>
        /// 
        /// </summary>
        private IngredienteDAO ingredienteDAO;
        private SaborDAO saborDAO;
        public TelaEditSabores()
        {
            InitializeComponent();
            Funcoes.FecharEsc(this);
            Funcoes.AjustaResourcesControl(this);
            cadastrarBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            cadastrarBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            cancelBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            cancelBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            nomePizzaTextBox.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            nomePizzaTextBox.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);
            nomePizzaTextBox.Focus();
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection =
            ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            ingredienteDAO = new IngredienteDAO(provider, strConnection);
            saborDAO = new SaborDAO(provider, strConnection);
            CarregaIngredientesCheckedListBox();
            CarregaEnumListBox();
        }
        private void CarregaIngredientesCheckedListBox()
        {
            //Instância e Preenche o objeto com os dados da view
            var ingrediente = new Ingrediente();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = ingredienteDAO.Buscar(ingrediente);
                // carrega os dados, como objeto, no checkedListBox
                checkedListBoxIngredientes.Items.Clear();
                foreach (DataRow row in linhas.Rows)
                {
                    checkedListBoxIngredientes.Items.Add(new Ingrediente(int.Parse(row["ID"].ToString()), row["Nome"].ToString())).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CarregaEnumListBox()
        {
            //popular listBoxCategoria
            listBoxCategoria.Items.Clear();
            listBoxCategoria.DataSource = Enum.GetValues(typeof(EnumSaborCategoria));
            //popular listBoxTipo
            listBoxTipo.Items.Clear();
            listBoxTipo.DataSource = Enum.GetValues(typeof(EnumSaborTipo));
        }
        private void CadastrarBtn_Click(object sender, EventArgs e)
        {
            //Instância e Preenche o objeto com os dados da view
            var sabor = new Sabor
            {
                Id = 0,
                Descricao = nomePizzaTextBox.Text,
                Foto = Funcoes.ConverteImagemParaByteArray(pictureBoxImagem.Image),
                Categoria = (char)(EnumSaborCategoria)Enum.Parse(typeof(EnumSaborCategoria), listBoxCategoria.Text),
                Tipo = (char)(EnumSaborTipo)Enum.Parse(typeof(EnumSaborTipo), listBoxTipo.Text),
                SaborIngredientes = checkedListBoxIngredientes.CheckedItems.OfType<Ingrediente>().ToList(),
            };
            try
            {
                // chama o método para inserir da camada model
                saborDAO.Inserir(sabor);
                MessageBox.Show("Dados inseridos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogImagem = new()
            {
                Title = "Imagem do produto",
                Filter = "Images (*.JPEG;*.BMP;*.JPG;*.GIF;*.PNG;*.)|*.JPEG;*.BMP;*.JPG;*.GIF;*.PNG;*.icon;*.JFIF"
            };
            if (openFileDialogImagem.ShowDialog() == DialogResult.OK)
            {
                //pega a imagem escolhida e adiciona na tela
                pictureBoxImagem.Image = Image.FromFile(openFileDialogImagem.FileName);
                //redimensiona a imagem
                pictureBoxImagem.Image = (Image)(new Bitmap(pictureBoxImagem.Image, new Size(130, 98)));
                //ajusta a visualização no tamanho do pictureBoxImagem na tela
                pictureBoxImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
