namespace Terceiro_Projeto_CSharp_AutonomiaVeicular
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Declara��o de Vari�veis
            double kmRodado;
            double litros;
            double autonomia;

            //Recebendo Valores do Formul�rio
            kmRodado = double.Parse(textBox1.Text);
            litros = double.Parse(textBox2.Text);

            //Calculando autonomia
            autonomia = kmRodado / litros;

            //Mostrar Valores
            label5.Text = autonomia.ToString();
        }
    }
}
