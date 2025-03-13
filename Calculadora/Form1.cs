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

        private void button1_Click(object sender, EventArgs e)
        {
            string valor1 = textBoxValor1.Text;
            string valor2 = textBoxValor2.Text;

            if (!valor1.All(char.IsNumber))
            {
                labelErro.Text = "O valor 1 deve ser um numero";
                return;
            }
            if (!valor2.All(char.IsNumber))
            {
                labelErro.Text = "O valor 2 deve ser um numero";
                return;
            }

            double doublevalor1 = Convert.ToDouble(valor1);
            double doublevalor2 = Convert.ToDouble(valor2);
            double resultado;


            switch (comboBoxOpera.SelectedItem?.ToString())
            {
                case "Soma":
                    resultado = doublevalor1 + doublevalor2;
                    textBoxResultado.Text = resultado.ToString();
                    break;
                case "Subtração":
                    resultado = doublevalor1 - doublevalor2;
                    textBoxResultado.Text = resultado.ToString();
                    break;
                case "Multiplicação":
                    resultado = doublevalor1 * doublevalor2;
                    textBoxResultado.Text = resultado.ToString();
                    break;
                case "Divisão":
                    if (doublevalor1 != 0 || doublevalor2 != 0)
                    {
                        resultado = doublevalor1 / doublevalor2;
                        textBoxResultado.Text = resultado.ToString();
                    }
                    else
                    {
                        labelErro.Text = "O valor inserido deve ser diferente de 0";
                    }
                    break;
                default:
                    labelErro.Text = "Selecione uma operação";
                    break;
            }

        }

        private void comboBoxOpera_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxOpera.SelectedItem?.ToString())
            {
                case "Soma":
                    labelOperacao.Text = "+";
                    break;
                case "Subtração":
                    labelOperacao.Text = "-";
                    break;
                case "Multiplicação":
                    labelOperacao.Text = "*";
                    break;
                case "Divisão":
                    labelOperacao.Text = "/";
                    break;
            }
        }

        private void buttonNovoForm_Click(object sender, EventArgs e)
        {
            NovoForm novoForm = new NovoForm();
            novoForm.Show();

            this.Hide();
        }
    }
}
