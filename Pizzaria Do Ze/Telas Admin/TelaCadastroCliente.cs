using Pizzaria_Do_Ze.Telas_Admin;
using Pizzaria_Do_Ze.Telas_Pedido;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria_Do_Ze.Telas_cadastros
{
    /// <summary>
    /// 
    /// </summary>
    public partial class TelaCadastroCliente : Form
    {
        
        readonly TelaTamanhoPizza pedido = new TelaTamanhoPizza();
        /// <summary>
        /// Tela para cadastrar um novo cliente ou puxar um cadastro antigo
        /// </summary>
        public TelaCadastroCliente()
        {
            InitializeComponent();
            Funcoes.FecharEsc(this);
            CamposCadsatroUserControl campos = new CamposCadsatroUserControl();
            campos.nomeTextBot.Focus();
            Funcoes.AjustaResourcesControl(this);
            cadastrarBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            cadastrarBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            cancelBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            cancelBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            clienteCadastradoBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            clienteCadastradoBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);
        }



        private void CadastrarBtn_Click(object sender, EventArgs e)
        {
            
            pedido.ShowDialog();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
