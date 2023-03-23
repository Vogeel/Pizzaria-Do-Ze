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
    public partial class TelaCadastrarFuncionarios : Form
    {
        public TelaCadastrarFuncionarios()
        {
            InitializeComponent();
        }

        private void cadastrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close ();
        }
    }
}
