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
    public partial class CamposCadsatroUserControl : UserControl
    {
        /// <summary>
        /// User control para padrao de cadastro
        /// </summary>
        public CamposCadsatroUserControl()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
            CEPMaskedTB.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            CEPMaskedTB.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            CPFMaskedTB.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            CPFMaskedTB.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            telefoneMaskTB.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            telefoneMaskTB.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            complementoTextBox.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            complementoTextBox.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            emailTextBox.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            emailTextBox.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            enderecoTextBox.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            enderecoTextBox.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            nomeTextBot.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            nomeTextBot.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);

        }


    }
}
