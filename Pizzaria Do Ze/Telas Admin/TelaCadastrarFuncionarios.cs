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
    /// 
    /// </summary>
    public partial class TelaCadastrarFuncionarios : Form
    {
        /// <summary>
        /// Tela para cadastrar um novo funcionario e sua atuação(entregador, atendente ou admin)
        /// </summary>
        public TelaCadastrarFuncionarios()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
        }

        private void CadastrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close ();
        }
    }
}
