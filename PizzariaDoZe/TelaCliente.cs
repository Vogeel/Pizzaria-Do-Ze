namespace PizzariaDoZe
{
    public partial class TelaCliente : Form
    {
        TelaCadastroCliente cadastro = new TelaCadastroCliente();
        TelaVisualizarCliente visualizarCliente = new TelaVisualizarCliente(); 
        public TelaCliente()
        {
            InitializeComponent();

        }

        private void visualizarClienteBtn_Click(object sender, EventArgs e)
        {
            visualizarCliente.ShowDialog();
        }

        private void cadastroBtn_Click(object sender, EventArgs e)
        {
            cadastro.ShowDialog();
        }

        private void voltarBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}