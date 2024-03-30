namespace WinFormsApp007_RepetidorDeMensajes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            string mensaje = txtMensaje.Text;
            double numeroRepeticiones = double.Parse(txtRepeticiones.Text);

            lstRepeticiones.Items.Clear();
            int i = 1;
            while (i <= numeroRepeticiones)
            {
                lstRepeticiones.Items.Add(mensaje);
                i++;
            }
        }
    }
}
