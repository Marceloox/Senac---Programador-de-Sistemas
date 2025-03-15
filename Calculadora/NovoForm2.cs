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
    public partial class NovoForm2 : Form
    {
        public NovoForm2()
        {
            InitializeComponent();
        }

        private bool ValidarForm()
        {
            labelErro.Text = "";

            if(comboBoxForma.SelectedItem == null)
            {
                labelErro.Text = "Selecione uma opção";
                return false;
            }

            switch (comboBoxForma.SelectedItem)
            {
                case "Círculo":
                    return false;
                    

            }

            return false;
        }

        private void comboBoxForma_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxForma.SelectedItem)
            {
                case "Círculo":
                    groupBoxCalculo.Visible = true;
                    break;

            }
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            if (!radioButtonDiametro.Checked && !radioButtonPeri.Checked && !radioButtonArea.Checked && !radioButtonVolume.Checked)
            {
                labelErro.Text = "Selecione uma opção";
                return;
            }

            string raio = textBoxRaio.Text;           

            if (string.IsNullOrWhiteSpace(raio) || !raio.All(char.IsNumber))
            {
                labelErro.Text = "Inserir um raio de um numero valido";
                return;
            }

            double raioDoNumero = Convert.ToDouble(raio);
            double resultado;

            if (radioButtonDiametro.Checked)
            {
                resultado = 2 * raioDoNumero;
                textBoxResultado.Text = Math.Round(resultado).ToString();
                return;
            }

            if (radioButtonPeri.Checked)
            {
                resultado = 2 * Math.PI * raioDoNumero;
                textBoxResultado.Text = Math.Round(resultado).ToString();
                return;
            }

            if (radioButtonArea.Checked)
            {
                resultado = Math.PI * Math.Pow(raioDoNumero, 2);
                textBoxResultado.Text = Math.Round(resultado).ToString();
                return;
            }

            if (radioButtonVolume.Checked)
            {
                resultado = (4/3) * Math.PI * Math.Pow(raioDoNumero, 3);
                textBoxResultado.Text = Math.Round(resultado).ToString();
                return;
            }
        }
    }
}
