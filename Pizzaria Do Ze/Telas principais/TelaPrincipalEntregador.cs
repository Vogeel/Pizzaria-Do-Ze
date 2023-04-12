﻿using Pizzaria_Do_Ze.Telas_Pedido;
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
    public partial class TelaPrincipalEntregador : Form
    {
        TelaPedidosEntregues entregues = new TelaPedidosEntregues();
        TelaPedidosPendentes pendentes = new TelaPedidosPendentes();
        /// <summary>
        /// Tela se um entregador logar
        /// </summary>
        public TelaPrincipalEntregador()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);

        }

        private void pedPendentesBtn_Click(object sender, EventArgs e)
        {
            pendentes.ShowDialog();
        }

        private void pedEntreguesBtn_Click(object sender, EventArgs e)
        {
            entregues.ShowDialog();
        }

        private void voltarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
