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
    public partial class TelaEditarPrecos : Form
    {
        /// <summary>
        /// Tela para editar os preços das pizzas
        /// </summary>
        public TelaEditarPrecos()
        {
            InitializeComponent();
            Funcoes.FecharEsc(this);
            Funcoes.AjustaResourcesControl(this);
            atualizarBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            atualizarBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            cancelBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            cancelBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);
            valorBrotoMaskedTextBox.Focus();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Atualizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        
    }
}
