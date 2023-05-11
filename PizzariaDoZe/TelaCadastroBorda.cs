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
    public partial class TelaCadastroBorda : Form
    {
        readonly TelaAdicionarBorda addborda = new TelaAdicionarBorda();
        /// <summary>
        /// Tela de CRUD das bordas
        /// </summary>
        public TelaCadastroBorda()
        {
            InitializeComponent();
            Funcoes.FecharEsc(this);
            Funcoes.AjustaResourcesControl(this);
            addBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            addBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            cancelBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            cancelBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            excluirSelecionadoBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            excluirSelecionadoBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);
            addBtn.Focus();
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
