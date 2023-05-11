using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzariaDoZe
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
            Funcoes.FecharEsc(this);
            Funcoes.AjustaResourcesControl(this);
            voltarBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            voltarBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);
        }

        private void excluirBtn_Click(object sender, EventArgs e)
        {

        }

        private void editBtn_Click(object sender, EventArgs e)
        {

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
