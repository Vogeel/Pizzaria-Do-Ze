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
    /// Tela para retirar algum ingredietne do sabor da pizza escolhida pelo cliente
    /// </summary>
    public partial class TelaRetirarIngrediente : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public TelaRetirarIngrediente()
        {
            InitializeComponent();
            Funcoes.FecharEsc(this);
            Funcoes.AjustaResourcesControl(this);
            ConcluirBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            ConcluirBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            retirarBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            retirarBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            cancelbtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            cancelbtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            saborComboBox.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            saborComboBox.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);
            saborComboBox.Focus();
        }
        private void ConcluirBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
