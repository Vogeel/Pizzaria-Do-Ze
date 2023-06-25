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
    /// Tela para o atendete/admin adcionar sabores, bebidas do cliente
    /// </summary>
    public partial class TelaPedidoCliente : Form
    {
        SaborDAO SaborDAO;
        ProdutoDAO BebidaDAO;
        ClienteDAO ClienteDAO;
        readonly TelaPedidoFinal pedidoFinal = new TelaPedidoFinal();
        readonly TelaRetirarIngrediente retirarIngrediente = new TelaRetirarIngrediente();
        /// <summary>
        /// 
        /// </summary>
        public TelaPedidoCliente()
        {
            InitializeComponent();
            Funcoes.FecharEsc(this);
            Funcoes.AjustaResourcesControl(this);
            addBebidaBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            addBebidaBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            addPizzaBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            addPizzaBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            cancelBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            cancelBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            excluirBebidaBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            excluirBebidaBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            excluirPizzaBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            excluirPizzaBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            retirarIngredienteBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            retirarIngredienteBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            seguinteBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            seguinteBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            ComboBoxBebida.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            ComboBoxBebida.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            ComboBoxBorda.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            ComboBoxBorda.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            ComboBoxSabor.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            ComboBoxSabor.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);
            ComboBoxSabor.Focus();
            
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;           
            SaborDAO = new SaborDAO(provider, strConnection);
            BebidaDAO = new ProdutoDAO(provider, strConnection);
            ClienteDAO = new ClienteDAO(provider, strConnection);
            CarregaSabores();
            CarregaBebida();
            CarregaCliente();
            CarregaEnumTamanho();
        }

        private void SeguinteBtn_Click(object sender, EventArgs e)
        {
            pedidoFinal.ShowDialog();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RetirarIngredienteBtn_Click(object sender, EventArgs e)
        {
            retirarIngrediente.ShowDialog();
        }
        private void CarregaSabores()
        {
            //Instância e Preenche o objeto com os dados da view
            var sabor = new Sabor();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = SaborDAO.Buscar(sabor);
                // carrega os dados, como objeto, no checkedListBox
                ComboBoxSabor.Items.Clear();
                foreach (DataRow row in linhas.Rows)
                {
                    ComboBoxSabor.Items.Add(new Sabor(int.Parse(row["ID"].ToString()), row["Descricao"].ToString())).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CarregaCliente()
        {
            //Instância e Preenche o objeto com os dados da view
            var cliente = new Cliente();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = ClienteDAO.Buscar(cliente);
                // carrega os dados, como objeto, no checkedListBox
                comboBoxCLiente.Items.Clear();
                foreach (DataRow row in linhas.Rows)
                {
                    comboBoxCLiente.Items.Add(new Sabor(int.Parse(row["ID"].ToString()), row["Nome"].ToString())).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void CarregaBebida()
        {
            //Instância e Preenche o objeto com os dados da view
            var bebida = new Produto();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = BebidaDAO.Buscar(bebida);
                // carrega os dados, como objeto, no checkedListBox
                ComboBoxBebida.Items.Clear();
                foreach (DataRow row in linhas.Rows)
                {
                    ComboBoxBebida.Items.Add(new Sabor(int.Parse(row["ID"].ToString()), row["Descricao"].ToString())).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CarregaEnumTamanho()
        {
            //popular comboBOxTamanho
            comboBoxTamanhoPiza.Items.Clear();
            comboBoxTamanhoPiza.DataSource = Enum.GetValues(typeof(EnumValorTamanho));
         
        }
    }
}
