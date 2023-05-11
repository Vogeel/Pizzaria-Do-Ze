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
    public partial class MessageBoxIdiomaMudado : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public MessageBoxIdiomaMudado()
        {
            InitializeComponent();
            Funcoes.FecharEsc(this);
            Funcoes.AjustaResourcesControl(this);
            okBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            okBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);
            okBtn.Focus();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
