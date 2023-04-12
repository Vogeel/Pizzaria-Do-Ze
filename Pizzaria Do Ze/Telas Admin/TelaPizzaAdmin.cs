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
