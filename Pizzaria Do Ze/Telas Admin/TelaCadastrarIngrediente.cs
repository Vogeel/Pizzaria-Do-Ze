using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria_Do_Ze.Telas_Admin
{
    public partial class TelaCadastrarIngrediente : Form
    {
        /// <summary>
        /// Tela para CRUD de ingredientes
        /// </summary>
        public TelaCadastrarIngrediente()
        {
            InitializeComponent();
            Funcoes.FecharEsc(this);
            Funcoes.AjustaResourcesControl(this);
            addBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            addBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            cancelBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            cancelBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            excluirSelecionadoBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            excluirSelecionadoBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            nomeTextBox.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            nomeTextBox.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);
            nomeTextBox.Focus();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
