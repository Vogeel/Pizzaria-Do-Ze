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
    /// Tela para o adtendete/admin alterar o status do pedido
    /// </summary>
    public partial class TelaStatusPedidoAtendente : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public TelaStatusPedidoAtendente()
        {
            InitializeComponent();
            Funcoes.FecharEsc(this);
            Funcoes.AjustaResourcesControl(this);
            cancelarBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            cancelarBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            pagoRadioBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            pagoRadioBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            pendenteRadioBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            pendenteRadioBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            preparoRadioBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            preparoRadioBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            retiradaRadioBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            retiradaRadioBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            saiuEntregaRadioBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            saiuEntregaRadioBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            entregadorComboBox.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            entregadorComboBox.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);
            pagoRadioBtn.Focus();
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
