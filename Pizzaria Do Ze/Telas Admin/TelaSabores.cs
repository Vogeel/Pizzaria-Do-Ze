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
    public partial class TelaSabores : Form
    {
        TelaEditSabores editSabores = new TelaEditSabores();
        public TelaSabores()
        {
            InitializeComponent();
        }

        private void voltarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            editSabores.ShowDialog();
        }
    }
}
