
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaDoZe
{
    /// <summary>
    /// 
    /// </summary>
    public partial class TelaLogin : Form
    {
        readonly TelaPrincipalAdmin admin = new TelaPrincipalAdmin();
        readonly TelaPrincipalAtendente atendente = new TelaPrincipalAtendente();
        readonly TelaPrincipalEntregador entregador = new TelaPrincipalEntregador();
        readonly FormConfigurations configurations = new FormConfigurations();
        /// <summary>
        /// Tela incial de Login para ver permiçoes dadas ao usuario logado
        /// </summary>
        public TelaLogin()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
            Funcoes.FecharEsc(this);
            UserTextBox.Focus();
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);
            UserTextBox.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            UserTextBox.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            senhaTextBox.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            senhaTextBox.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            cancelBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            cancelBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            loginBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            loginBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            encerrarToolStripMenuItem.Click += new EventHandler(CancelBtn_Click);
            sobreToolStripMenuItem.Click += new EventHandler(SobreMenuItem_Click);
            abrirToolStripMenuItem.Click += new EventHandler(AbrirTela_Click);
        }

        private void AbrirTela_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void SobreMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Direitos reservados a Vitor Vogel e ChatGPT", "Sobre", MessageBoxButtons.OK);
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UserTextBox.Text == "admin")
            {
                admin.ShowDialog();
            }

            if (UserTextBox.Text == "atendente")
            {
                atendente.ShowDialog();
            }

            if (UserTextBox.Text == "entregador")
            {
                entregador.ShowDialog();
            }
        }
       
           
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void ConfigBtn_Click(object sender, EventArgs e)
        {
            configurations.ShowDialog();

        }

        private void TelaLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBoxSair sairTela = new MessageBoxSair();
            DialogResult result = sairTela.ShowDialog();

            if(result == DialogResult.Abort)
            {
                e.Cancel = true;
                this.WindowState = FormWindowState.Minimized;
                notifyIcon1.ShowBalloonTip(1000);
            }
            else if (result == DialogResult.OK)
            {
                

            }
            else if(result == DialogResult.Cancel)
            {
                e.Cancel = true;
                
            }
        }
        public static void ValidaConexaoDB()
        {
            DbProviderFactory factory;
            try
            {
                factory = DbProviderFactories.GetFactory(ConfigurationManager.ConnectionStrings["BD"].ProviderName);
                using var conexao = factory.CreateConnection();
                conexao!.ConnectionString = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
                using var comando = factory.CreateCommand();
                comando!.Connection = conexao;
                conexao.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                new FormConfigurations().ShowDialog();
                ValidaConexaoDB();
            }
        }
        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void TelaLogin_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000);

            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }
    }
}
