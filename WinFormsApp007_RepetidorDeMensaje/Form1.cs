namespace WinFormsApp007_RepetidorDeMensaje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            lstMensajes.Items.Clear();
            int cantidadRepeticiones=int.Parse(txtNumeroRepeticiones.Text);
            string mensaje=txtMensaje.Text;
            int contador = 0;

            while (contador<cantidadRepeticiones)
            {
                lstMensajes.Items.Add(mensaje);
                contador++;
            }
        }
    }
}
