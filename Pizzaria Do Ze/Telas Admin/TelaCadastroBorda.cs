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
    public partial class TelaCadastroBorda : Form
    {
        readonly TelaAdicionarBorda addborda = new TelaAdicionarBorda();
        public TelaCadastroBorda()
        {
            InitializeComponent();
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
