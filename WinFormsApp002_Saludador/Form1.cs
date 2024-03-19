namespace WinFormsApp002_Saludador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrarMensaje_Click(object sender, EventArgs e)
        {
            string mensaje = txtMensaje.Text;
            MessageBox.Show(mensaje);
        }
    }
}
