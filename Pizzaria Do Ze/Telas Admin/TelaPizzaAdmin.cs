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
    public partial class TelaPizzaAdmin : Form
    {
        TelaSabores sabores = new TelaSabores();
        TelaEditarPrecos precos = new TelaEditarPrecos();
        TelaCadastrarIngrediente ingrediente = new TelaCadastrarIngrediente();
        TelaCadastroBorda borda = new TelaCadastroBorda();
        public TelaPizzaAdmin()
        {
            InitializeComponent();
        }

        private void saboresBtn_Click(object sender, EventArgs e)
        {
            sabores.ShowDialog();
        }

        private void valoresBtn_Click(object sender, EventArgs e)
        {
            precos.ShowDialog();
        }

        private void bordaBtn_Click(object sender, EventArgs e)
        {
            borda.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ingredientesBtn_Click(object sender, EventArgs e)
        {
            ingrediente.ShowDialog();
        }
    }
}
