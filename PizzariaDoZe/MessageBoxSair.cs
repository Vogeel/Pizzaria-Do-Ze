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
    public partial class MessageBoxSair : Form
    {
        /// <summary>
        /// Forms feito para ser usado como mngBox
        /// </summary>
        public MessageBoxSair()
        {
            InitializeComponent();
            Funcoes.FecharEsc(this);
            Funcoes.AjustaResourcesControl(this);
            cancelBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            cancelBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            okBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            okBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);
            cancelBtn.Focus();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
        }

        private void BandejaBtn_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
