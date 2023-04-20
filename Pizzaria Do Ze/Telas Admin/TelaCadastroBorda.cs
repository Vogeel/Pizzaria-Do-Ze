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
    public partial class TelaCadastroBorda : Form
    {
        readonly TelaAdicionarBorda addborda = new TelaAdicionarBorda();
        /// <summary>
        /// Tela de CRUD das bordas
        /// </summary>
        public TelaCadastroBorda()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
            addBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            addBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            cancelBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            cancelBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            excluirSelecionadoBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            excluirSelecionadoBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);
        }

        private void AddBordaBtn_Click(object sender, EventArgs e)
        {
            addborda.ShowDialog();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
