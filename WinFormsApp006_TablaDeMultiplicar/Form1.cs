namespace WinFormsApp006_TablaDeMultiplicar
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
            listBox1.Items.Clear();
            for (int i = 1; i <= 10; i++)
            {
                listBox1.Items.Add($"{numero} X {i} = {numero*i}");
            }
        }
    }
}
