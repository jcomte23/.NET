using System.Diagnostics;

namespace WinFormsApp008_BuscadorDeProductos
{
    public partial class Form1 : Form
    {
        string[,] productos = new string[4, 3];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtOutCodigo.Enabled = false;
            txtNombre.Enabled = false;
            txtPrecio.Enabled = false;

            productos[0, 0] = "Codigo";
            productos[0, 1] = "Nombre";
            productos[0, 2] = "Precio";

            productos[1, 0] = "P001";
            productos[1, 1] = "ARROZ";
            productos[1, 2] = "3000";

            productos[2, 0] = "P002";
            productos[2, 1] = "ACEITE";
            productos[2, 2] = "5000";

            productos[3, 0] = "P003";
            productos[3, 1] = "LENTEJAS";
            productos[3, 2] = "2500";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = txtCaja.Text.ToUpper().Trim();
            int indice = 0;
            bool encontrado = false;

            if (String.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Debes ingresar un codigo");
                return;
            }

            for (int i = 0; i < 4 && encontrado == false; i++)
            {
                if (input.Equals(productos[i,0]))
                {
                    indice = i;
                    encontrado = true;
                }
            }

            if (indice != 0)
            {
                txtOutCodigo.Text = productos[indice,0];
                txtNombre.Text = productos[indice,1];
                txtPrecio.Text = productos[indice,2];
            }
        }
    }
}
