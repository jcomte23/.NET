namespace WinFormsApp005_CalculadorMesAño
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int opcion = int.Parse(comboBox1.SelectedItem.ToString());

            switch (opcion)
            {
                case 1:
                    lblRespuesta.Text = "Ese numero corresponde a 'ENERO'";
                    break;
                case 2:
                    lblRespuesta.Text = "Ese numero corresponde a 'FEBRERO'";
                    break;
                case 3:
                    lblRespuesta.Text = "Ese numero corresponde a 'MARZO'";
                    break;
                case 4:
                    lblRespuesta.Text = "Ese numero corresponde a 'ABRIL'";
                    break;
                case 5:
                    lblRespuesta.Text = "Ese numero corresponde a 'MAYO'";
                    break;
                case 6:
                    lblRespuesta.Text = "Ese numero corresponde a 'JUNIO'";
                    break;
                case 7:
                    lblRespuesta.Text = "Ese numero corresponde a 'JULIO'";
                    break;
                case 8:
                    lblRespuesta.Text = "Ese numero corresponde a 'AGOSTO'";
                    break;
                case 9:
                    lblRespuesta.Text = "Ese numero corresponde a 'SEPTIEMBRE'";
                    break;
                case 10:
                    lblRespuesta.Text = "Ese numero corresponde a 'OCTUBRE'";
                    break;
                case 11:
                    lblRespuesta.Text = "Ese numero corresponde a 'NOVIEMBRE'";
                    break;
                case 12:
                    lblRespuesta.Text = "Ese numero corresponde a 'DICIEMBRE'";
                    break;
            }
        }
    }
}
