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
            Funcoes.AjustaResourcesControl(this);
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
