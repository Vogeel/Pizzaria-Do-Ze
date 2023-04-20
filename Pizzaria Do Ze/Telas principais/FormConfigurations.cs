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

namespace Pizzaria_Do_Ze.Telas_principais
{
    public partial class FormConfigurations : Form
    {
        /// <summary>
        /// Tela para mudar ocnfiguraçoes antes de logar
        /// </summary>
        public FormConfigurations()
        {
            InitializeComponent();
            //seleciona no comboBox o idioma/cultura atual
            idiomaComboBox.SelectedItem = ConfigurationManager.AppSettings.Get("IdiomaRegiao");
            cancelBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            cancelBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            okBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            okBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            idiomaComboBox.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            idiomaComboBox.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);

        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            //abre o arquivo local como leitura/escrita e salva as alterações
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove("IdiomaRegiao");//tira o idioma anterior
            config.AppSettings.Settings.Add("IdiomaRegiao", idiomaComboBox.Text);//coloca o idioma escolhido
            config.Save(ConfigurationSaveMode.Modified);//salva modificações
            ConfigurationManager.RefreshSection("appSettings");//atualiza appSettings
            Close();
            _ = MessageBox.Show("Idioma/região alterada com sucesso! Reinicie a aplicação para aplicar o novo Idioma/região!");

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
