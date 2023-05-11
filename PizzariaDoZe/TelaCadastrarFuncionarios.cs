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
    /// 
    /// </summary>
    public partial class TelaCadastrarFuncionarios : Form
    {
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
            cpfMaskedTB.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            cpfMaskedTB.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            matriculaTB.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            matriculaTB.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            nomeTB.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            nomeTB.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            senhaMaskedTB.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            senhaMaskedTB.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            telefonemaskedTB.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            telefonemaskedTB.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            validadeCNHdateTimePicker.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            validadeCNHdateTimePicker.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);
            nomeTB.Focus();
        }

        private void CadastrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close ();
        }

       
    }
}
