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
    /// tela de CRUD de sabores
    /// </summary>
    public partial class TelaSabores : Form
    {
        readonly TelaEditSabores editSabores = new TelaEditSabores();
        /// <summary>
        /// 
        /// </summary>
        public SaborDAO saborDAO;
        public TelaSabores()
        {
            InitializeComponent();
            Funcoes.FecharEsc(this);
            Funcoes.AjustaResourcesControl(this);
            voltarBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            voltarBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            saborDAO = new SaborDAO(provider, strConnection);
        }
        public void AtualizarTela()
        {
            //Instância e Preenche o objeto com os dados da view
            var sabor = new Sabor();
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = saborDAO.Buscar(sabor);
                // seta o datasouce do dataGridView com os dados retornados
                dataGridViewDados.Columns.Clear();
                dataGridViewDados.AutoGenerateColumns = true;
                dataGridViewDados.DataSource = linhas;
                dataGridViewDados.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void VoltarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void dataGridViewDados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
           
                if (e.RowIndex == this.dataGridViewDados.NewRowIndex || e.Value.ToString().Trim().Length == 0)
                {
                    return;
                }
                if (this.dataGridViewDados.Columns[e.ColumnIndex].Name.Equals("Grupo"))
                {
                    e.Value = classEnum.GetDescription((EnumFuncionarioGrupo)int.Parse(e.Value.ToString()));
                }
                else if (this.dataGridViewDados.Columns[e.ColumnIndex].Name.Equals("Categoria"))
                {
                    e.Value = classEnum.GetDescription((EnumSaborCategoria)char.Parse(e.Value.ToString()));
                }
                else if (this.dataGridViewDados.Columns[e.ColumnIndex].Name.Equals("Tipo"))
                {
                    e.Value = classEnum.GetDescription((EnumSaborTipo)char.Parse(e.Value.ToString()));
                }
                else if (this.dataGridViewDados.Columns[e.ColumnIndex].Name.Equals("CPF"))
                {
                    long value = long.Parse(e.Value.ToString().Replace(" ", ""));
                    e.Value = string.Format(@"{0:000\.000\.000\-00}", value);
                }
                else if (this.dataGridViewDados.Columns[e.ColumnIndex].Name.Equals("CEP"))
                {
                    long value = long.Parse(e.Value.ToString().Replace(" ", ""));
                    e.Value = string.Format(@"{0:00\.000\-000}", value);
                }
                else if (this.dataGridViewDados.Columns[e.ColumnIndex].Name.Equals("Telefone"))
                {
                    long value = long.Parse(e.Value.ToString().Replace(" ", ""));
                    e.Value = string.Format(@"{0:(00) 00000\-0000}", value);
                }
                else if (this.dataGridViewDados.Columns[e.ColumnIndex].Name.Equals("Valor"))
                {
                    // formata valor numérico com duas casa decimais
                    double d = double.Parse(e.Value.ToString());
                    e.Value = d.ToString("N2");
                }
            
        }
    }
}
