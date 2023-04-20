using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria_Do_Ze.Telas_Pedido
{
    /// <summary>
    /// ultima tela do pedido do cliente, onde ele seleciona forma de pagamento e se vai retirar ou vai ser pro Delivery a entrega
    /// </summary>
    public partial class TelaPedidoFinal : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public TelaPedidoFinal()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
            cancelBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            cancelBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            cartaoRadioBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            cartaoRadioBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            dinheiroRadioBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            dinheiroRadioBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            entregaRadioBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            entregaRadioBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            finalizarBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            finalizarBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            pixRadioBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            pixRadioBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            retiradaRadioBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            retiradaRadioBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            trocoTextBox.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            trocoTextBox.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);
        }

        private void FinalizarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
