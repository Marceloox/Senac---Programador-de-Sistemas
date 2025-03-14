using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class NovoForm : Form
    {
        public NovoForm()
        {
            InitializeComponent();
        }

        private void comboBoxFormas_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxFormas.SelectedItem)
            {
                case "Quadrado":
                    break;
                case "Retângulo":
                    break;
            }
        }

        private void comboBoxCalculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxCalculos.SelectedItem)
            {
                case "Área":
                    labelBase.Visible = true;
                    textBoxBase.Visible = true;
                    labelAltura.Visible = true;
                    textBoxAltura.Visible = true;
                    labelComprimento.Visible = false;
                    textBoxComprimento.Visible = false;
                    break;

                case "Perímetro":
                    labelBase.Visible = true;
                    textBoxBase.Visible = true;
                    labelAltura.Visible = true;
                    textBoxAltura.Visible = true;
                    labelComprimento.Visible = false;
                    textBoxComprimento.Visible = false;
                    break;

                case "Volume":
                    labelBase.Visible = true;
                    textBoxBase.Visible = true;
                    labelAltura.Visible = true;
                    textBoxAltura.Visible = true;
                    labelComprimento.Visible = true;
                    textBoxComprimento.Visible = true;
                    break;
            }




        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            string Base = textBoxBase.Text;
            string altura = textBoxAltura.Text;
            string comprimento = textBoxComprimento.Text;

            double doubleBase = Convert.ToDouble(Base);
            double doubleAltura = Convert.ToDouble(altura);
            double doubleComprimento = Convert.ToDouble(comprimento);
            doubleComprimento = 1;
            double resultado;

            switch (comboBoxCalculos.SelectedItem)
            {
                case "Área":
                    if (doubleBase > 0 && doubleAltura > 0)
                    {
                        resultado = doubleBase * doubleAltura;
                        labelResultado.Text = resultado.ToString();
                    }
                    else
                    {
                        labelErro.Text = "O valor não pode ser 0";
                    }
                    break;

                case "Perímetro":
                    if (doubleBase > 0 && doubleAltura > 0)
                    {
                        resultado = doubleBase * doubleBase + doubleAltura * doubleAltura;
                        labelResultado.Text = resultado.ToString();
                    }
                    else
                    {
                        labelErro.Text = "O valor não pode ser 0";
                    }
                    break;

                case "Volume":
                    if (doubleBase > 0 && doubleAltura > 0)
                    {
                        resultado = doubleBase * doubleAltura * doubleComprimento;
                        labelResultado.Text = resultado.ToString();
                    }
                    else
                    {
                        labelErro.Text = "O valor não pode ser 0";
                    }
                    break;


            }
        }

        private void buttonOutraCalculadora_Click(object sender, EventArgs e)
        {
            NovoForm2 novoForm2 = new NovoForm2();
            novoForm2.Show();

            this.Hide();
        }
    }
}
