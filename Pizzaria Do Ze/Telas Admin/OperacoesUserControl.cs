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
    public partial class OperacoesUserControl : UserControl
    {
        /// <summary>
        /// User control das operações de Adicionar, Editar e Excluir
        /// </summary>
        public OperacoesUserControl()
        {
            InitializeComponent();
            Funcoes.AjustaResourcesControl(this);
            addBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            addBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            editBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            editBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            excluirBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            excluirBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
        }
    }
}
