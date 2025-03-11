namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSoma_Click(object sender, EventArgs e)
        {
            string numero1 = Numero1.Text;
            string numero2 = Numero2.Text;

            if (!numero1.All(char.IsNumber))
            {
                labelResultado.Text = "O valor 1 deve ser um numero";
                return;
            }

            double doubleNumero1 = Convert.ToDouble(numero1);
            double doubleNumero2 = Convert.ToDouble(numero2);

            double resultado = doubleNumero1 + doubleNumero2;

            labelResultado.Text = resultado.ToString();

        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            string numero1 = Numero1.Text;
            string numero2 = Numero2.Text;

            if (!numero1.All(char.IsNumber))
            {
                labelResultado.Text = "O valor 1 deve ser um numero";
                return;
            }

            double doubleNumero1 = Convert.ToDouble(numero1);
            double doubleNumero2 = Convert.ToDouble(numero2);

            double resultado = doubleNumero1 * doubleNumero2;

            labelResultado.Text = resultado.ToString();
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            string numero1 = Numero1.Text;
            string numero2 = Numero2.Text;

            if (!numero1.All(char.IsNumber))
            {
                labelResultado.Text = "O valor 1 deve ser um numero";
                return;
            }

            double doubleNumero1 = Convert.ToDouble(numero1);
            double doubleNumero2 = Convert.ToDouble(numero2);

            double resultado = doubleNumero1 / doubleNumero2;

            labelResultado.Text = resultado.ToString();
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            string numero1 = Numero1.Text;
            string numero2 = Numero2.Text;

            if (!numero1.All(char.IsNumber))
            {
                labelResultado.Text = "O valor 1 deve ser um numero";
                return;
            }

            double doubleNumero1 = Convert.ToDouble(numero1);
            double doubleNumero2 = Convert.ToDouble(numero2);

            double resultado = doubleNumero1 - doubleNumero2;

            labelResultado.Text = resultado.ToString();
        }
    }
}
