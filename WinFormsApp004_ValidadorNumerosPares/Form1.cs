namespace WinFormsApp004_ValidadorNumerosPares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double numero=double.Parse(textBox1.Text);
            if (numero%2==0)
            {
                MessageBox.Show("El numero es PAR");
            }
            else
            {
                MessageBox.Show("El numero es IMPAR");
            }
        }
    }
}
