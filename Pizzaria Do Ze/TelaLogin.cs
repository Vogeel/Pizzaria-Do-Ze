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
        public TelaLogin()
        {
            InitializeComponent();
            UserTextBox.Focus();
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
    }
}
