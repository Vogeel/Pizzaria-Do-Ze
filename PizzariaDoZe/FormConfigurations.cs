
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaDoZe
{
    public partial class FormConfigurations : Form
    {
        MessageBoxIdiomaMudado menssagem = new MessageBoxIdiomaMudado();

        /// <summary>
        /// Tela para mudar ocnfiguraçoes antes de logar
        /// </summary>
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        /// 
        public FormConfigurations()
        {
            InitializeComponent();
            Funcoes.FecharEsc(this);
            Funcoes.AjustaResourcesControl(this);
            //seleciona no comboBox o idioma/cultura atual
            idiomaComboBox.SelectedItem = ConfigurationManager.AppSettings.Get("IdiomaRegiao");
            cancelBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            cancelBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            okBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            okBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            idiomaComboBox.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            idiomaComboBox.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);
            idiomaComboBox.Focus();
            ConnectionStringSettings connection = ConfigurationManager.ConnectionStrings["BD"];
            comboBoxProvider.Text = connection.ProviderName;
            textBoxConexao.Text = connection.ConnectionString;

        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            //abre o arquivo local como leitura/escrita e salva as alterações
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove("IdiomaRegiao");//tira o idioma anterior
            config.AppSettings.Settings.Add("IdiomaRegiao", idiomaComboBox.Text);//coloca o idioma escolhido
            config.Save(ConfigurationSaveMode.Modified);//salva modificações
            ConfigurationManager.RefreshSection("appSettings");//atualiza appSettings
            config.ConnectionStrings.ConnectionStrings["BD"].ProviderName = comboBoxProvider.Text;
            config.ConnectionStrings.ConnectionStrings["BD"].ConnectionString = textBoxConexao.Text;
            config.Save(ConfigurationSaveMode.Modified, true);
            ConfigurationManager.RefreshSection("connectionStrings");
            Close();
            _ = MessageBox.Show("Dados alterados com sucesso");

            if (reiniciarCheckBox.Checked)
            {
                Application.Restart();
                Environment.Exit(0);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
