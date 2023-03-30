using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pizzaria_Do_Ze.Telas_Admin;

namespace Pizzaria_Do_Ze.Telas_Admin
{
    public partial class TelaCadastroFornecedor : Form
    {
        public TelaCadastroFornecedor()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cadastrarbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
