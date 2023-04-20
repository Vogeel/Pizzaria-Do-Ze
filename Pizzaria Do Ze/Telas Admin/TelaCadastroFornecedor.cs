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
        /// <summary>
        /// Tela para cadastrar um novo fornecedor
        /// </summary>
        public TelaCadastroFornecedor()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
            cadastrarBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            cadastrarBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            cancelBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            cancelBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);

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
