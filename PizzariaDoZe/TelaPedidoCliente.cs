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
    /// <summary>
    /// Tela para o atendete/admin adcionar sabores, bebidas do cliente
    /// </summary>
    public partial class TelaPedidoCliente : Form
    {
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
            bebeidasComboBox.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            bebeidasComboBox.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            bordaComboBox.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            bordaComboBox.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            saborComboBox.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            saborComboBox.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);
            saborComboBox.Focus();
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

        
    }
}
