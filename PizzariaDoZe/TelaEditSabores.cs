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
    /// Tela para editar o sabor(excluindo/adicionadno ingrediente)
    /// </summary>
    public partial class TelaEditSabores : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public TelaEditSabores()
        {
            InitializeComponent();
            Funcoes.FecharEsc(this);
            Funcoes.AjustaResourcesControl(this);
            addBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            addBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            cadastrarBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            cadastrarBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            cancelBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            cancelBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            excluirSaborBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            excluirSaborBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            nomePizzaTextBox.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            nomePizzaTextBox.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            ingredientesComboBox.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            ingredientesComboBox.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);
            nomePizzaTextBox.Focus();
        }

        private void CadastrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
