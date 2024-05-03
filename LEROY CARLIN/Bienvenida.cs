namespace LEROY_CARLIN
{
    public partial class Bienvenida : Form
    {
        Clientes ventanaClientes;
        Bienvenida ventanaBienvenida;
        public Bienvenida()
        {
            InitializeComponent();
            ventanaClientes = new Clientes();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            ventanaClientes.ShowDialog();
            ventanaBienvenida.Close();
        }
    }
}