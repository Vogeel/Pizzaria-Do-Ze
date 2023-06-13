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
    public partial class TelaOpcoesSabores : Form
    {
        TelaEditSabores editSabores = new TelaEditSabores();
        TelaSabores sabores = new TelaSabores();
        public TelaOpcoesSabores()
        {
            InitializeComponent();
        }

        private void visualizarBtn_Click(object sender, EventArgs e)
        {
            sabores.AtualizarTela();
            sabores.ShowDialog();
        }


        private void cadastroBtn_Click(object sender, EventArgs e)
        {
            editSabores.ShowDialog();
        }

        private void voltarBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
