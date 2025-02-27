using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUsuario.Text;
            string senha = textBoxSenha.Text;

            if(usuario == null || usuario == "")
            {
                labelResultado.Text = "Usuario é obrigatorio!!!";
                labelResultado.ForeColor = Color.Red;
                return;
            }
            else if (senha == null || senha == "")
            {
                labelResultado.Text = "Senha é obrigatorio!!!";
                labelResultado.ForeColor = Color.Red;
                return;
            }

          /*else
            {
                labelResultado.Text = "Usuario e Senha são obrigatorios!!!";
                labelResultado.ForeColor = Color.Red;
            }*/

            

            if (usuario == "marcelo" && senha == "12345")
            {
                labelResultado.Text = "Autenticado com sucesso!";
                labelResultado.ForeColor = Color.Green;
            }
            else
            {
                labelResultado.Text = "Usuario ou Senha incorretos...";
                labelResultado.ForeColor = Color.Red;
            }
        }
    }
}
