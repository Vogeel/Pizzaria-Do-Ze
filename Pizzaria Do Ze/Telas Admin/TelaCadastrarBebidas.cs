using System;
using System.Windows.Forms;

namespace Pizzaria_Do_Ze.Telas_Admin
{
    /// <summary>
    /// 
    /// </summary>
    public partial class TelaCadastrarBebidas : Form
    {
        /// <summary>
        /// Tela CRUD de bebidas
        /// </summary>
        public TelaCadastrarBebidas()
        {
            InitializeComponent();
            Funcoes.FecharEsc(this);
            Funcoes.AjustaResourcesControl(this);
            cadastrarBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            cadastrarBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            cancelBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            cancelBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            excluirSelecionadoBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            excluirSelecionadoBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            nomeTB.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            nomeTB.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            valorTB.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            valorTB.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            tamanhoComboBox.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            tamanhoComboBox.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            tipoComboBox.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            tipoComboBox.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);
            tipoComboBox.Focus();
        }

        private void CadastrarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
