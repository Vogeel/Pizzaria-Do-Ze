﻿using System;
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
    public partial class TelaEditarPrecos : Form
    {
        /// <summary>
        /// Tela para editar os preços das pizzas
        /// </summary>
        public TelaEditarPrecos()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Atualizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
