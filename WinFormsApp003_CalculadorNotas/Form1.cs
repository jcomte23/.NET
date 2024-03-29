namespace WinFormsApp003_CalculadorNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double nota1 = double.Parse(textBox1.Text);
            double nota2 = double.Parse(textBox2.Text);
            double nota3 = double.Parse(textBox3.Text);
            double calificacion=(nota1+nota2 +nota3)/3;
            MessageBox.Show($"la calificacion es de {Math.Round(calificacion)}");
        }
    }
}
