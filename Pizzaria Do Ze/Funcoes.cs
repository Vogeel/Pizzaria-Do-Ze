using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria_Do_Ze
{
    /// <summary>
    /// classe que ajuda as outras (compartilhado/commom/tools) da vida
    /// </summary>
    public class Funcoes
    {
        /// <summary>
        /// De forma recursiva, varre todos os componentes do Control informado,
        /// executando o método ApplyResources em cada um dos componentes localizados.
        /// O ApplyResources realiza a leitura do satellite assembly, ou seja, do arquivo de resource que foi ativo
        /// conforme o idioma escolhido pelo usuário,
        /// e com base no nome do campo ajusta todos os parâmetros contidos no resource para aquele campo,
        /// por exemplo Text, Font, Size, PasswordChar, Location etc.
        /// O objetivo principal aqui é ajustar o Control, por exemplo o Form, para o Idioma e Cultura escolhido pelo usuário.
        /// Deve possuir, em Properties, um arquivo de resources para cada idioma desejado, devendo ser alimentado na
        /// coluna nome o nome do campo e a propriedade que deseja ajustar.
        /// Por exemplo, em cadeias de caracteres labelLogin.Text, em outros textBoxSenha.PasswordChar, ou seja,
        /// todas as propriedades podem ser ajustadas conforme o idioma e região em uso.
        /// </summary>
        /// <param name="container">Informar o container inicial, geralmente this para pegar todos os campos da tela,
        /// ou então, por exemplo, o nome de um panel ou usercontrol.
        /// </param>
        public static void AjustaResourcesControl(Control container)
        {
            foreach (Control c in container.Controls)
            {
                AjustaResourcesControl(c);
                ComponentResourceManager resources = new ComponentResourceManager(typeof(Properties.Resources));
                resources.ApplyResources(c, c.Name);
            }
        }
        /// <summary>
        /// Altera a cor do back gorund quando esta o elemnto esta selecionado
        /// </summary>
        /// <param name="sender"> Obejto que gerou evento</param>
        /// <param name="e"> Evento que foi capturado</param>
        /// <example> textBoxUser.Enter += new System.EventHandler(ClassFuncoes.CampoEventoEnter)</example>
        public static void CampoEventoEnter(object sender, EventArgs e)
        {
            if (sender is TextBoxBase txt)
            {
                txt.BackColor = Color.LightGray;
            }
            else if (sender is ComboBox cb)
            {
                cb.BackColor = Color.LightGray;
            }
            else if (sender is RadioButton rb)
            {
                rb.BackColor = Color.LightGray;
            }
            else if (sender is ButtonBase btn)
            {
                btn.BackColor = Color.LightGray;
            }
        }

        /// <summary>
        /// Altera a cor do back gorund quando esta o elemnto parou de estar selecionado
        /// </summary>
        /// <param name="sender"> Obejto que gerou evento</param>
        /// <param name="e"> Evento que foi capturado</param>
        /// <example> textBoxUser.Enter += new System.EventHandler(ClassFuncoes.CampoEventoLeave)</example>
        public static void CampoEventoLeave(object sender, EventArgs e)
        {
            if (sender is TextBoxBase txt)
            {
                txt.BackColor = Color.White;
            }
            else if (sender is ComboBox cb)
            {
                cb.BackColor = Color.White;
            }
            else if (sender is RadioButton rb)
            {
                rb.BackColor = Color.White;
            }
            else if (sender is ButtonBase btn)
            {
                btn.BackColor = Color.BurlyWood;
            }
        }
        /// <summary>
        /// Tratar eventos de teclado, no caso tecla ENTER funcionando com TAB e tecla ESC para fechar
        /// </summary>
        /// <remarks>KeyPreview do formulário para true.</remarks>
        /// <param name="sender">Objeto que gerou o evento</param>
        /// <param name="e">Evento que foi capturado</param>
        /// <example>No construtor do formulário:
        /// this.KeyDown += new System.Windows.Forms.KeyEventHandler(ClassFuncoes.FormEventoKeyDown);
        ///</example>
        public static void FormEventoKeyDown(object sender, KeyEventArgs e)
        {
            //obtém o form onde o componente gerou o evento
            Control x = (Control)sender;
            Form form = x.FindForm();
            //verifica se foi pressionado ENTER
            if (e.KeyCode == Keys.Enter)
            {
                //Obtém ou define um valor que indica se o evento de chave deve ser passado para o controle subjacente.
                //true caso o evento chave não deva ser enviado ao controle; caso contrário, false
                //com isso evitamos o som de erro toda vez que pressionamos enter em algum campo
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
                //form.SelectNextControl(form.ActiveControl, !e.Shift, true, true, true);
            }
            //verifica se foi pressionado ESC
            else if (e.KeyCode == Keys.Escape)
            {
                form.Close();
            }
        }

       



        /// <summary>
        /// Serve para fechar o formulario ao apertar Esc
        /// </summary>
        /// <param name="form">formulario que vai ser usado</param>
        public static void FecharEsc(Form form)
        {
            form.KeyPreview = true;
            form.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == Keys.Escape)
                {
                    form.Close();
                }
            };
        }
        /// <summary>
        /// Configuração para apertar enter e ir para o proximo campo
        /// </summary>
        /// <param name="e"> tecla pressionada</param>
        /// <param name="form">formulario atual</param>
        

    }
}
