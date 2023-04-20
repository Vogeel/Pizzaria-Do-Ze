﻿using Pizzaria_Do_Ze.Telas_principais;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria_Do_Ze
{
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
            UserTextBox.Focus();
            UserTextBox.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            UserTextBox.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            senhaTextBox.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            senhaTextBox.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            cancelBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            cancelBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            loginBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            loginBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            configurations.ShowDialog();
        }

        
    }
}
