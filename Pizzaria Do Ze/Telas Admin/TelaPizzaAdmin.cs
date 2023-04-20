using Pizzaria_Do_Ze.Telas_Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria_Do_Ze.Telas_Cadastrais
{
    /// <summary>
    /// Tela que o admin tem acesso para editar coisas como borda, pizza, valores, etc
    /// </summary>
    public partial class TelaPizzaAdmin : Form
    {
        readonly TelaSabores sabores = new TelaSabores();
        readonly TelaEditarPrecos precos = new TelaEditarPrecos();
        readonly TelaCadastrarIngrediente ingrediente = new TelaCadastrarIngrediente();
        readonly TelaCadastroBorda borda = new TelaCadastroBorda();
        /// <summary>
        /// 
        /// </summary>
        public TelaPizzaAdmin()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
            bordaBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            bordaBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            cancelBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            cancelBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            ingredientesBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            ingredientesBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            saboresBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            saboresBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            valoresBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            valoresBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);
        }

        private void SaboresBtn_Click(object sender, EventArgs e)
        {
            sabores.ShowDialog();
        }

        private void ValoresBtn_Click(object sender, EventArgs e)
        {
            precos.ShowDialog();
        }

        private void BordaBtn_Click(object sender, EventArgs e)
        {
            borda.ShowDialog();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IngredientesBtn_Click(object sender, EventArgs e)
        {
            ingrediente.ShowDialog();
        }
    }
}
