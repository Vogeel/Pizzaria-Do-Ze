using System;
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
    /// <summary>
    /// tela de CRUD de sabores
    /// </summary>
    public partial class TelaSabores : Form
    {
        readonly TelaEditSabores editSabores = new TelaEditSabores();
        /// <summary>
        /// 
        /// </summary>
        public TelaSabores()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
        }

        private void VoltarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            editSabores.ShowDialog();
        }
    }
}
