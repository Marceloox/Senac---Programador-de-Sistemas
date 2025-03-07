using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        List<string> listaUsuarios = new List<string>() { "neymar.jr", "pablo.vitar", "sukuna.silva" };
        List<string> listaSenhas = new List<string>() { "bruna", "12345", "777" };

        public Form1()
        {
            InitializeComponent();
        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            string usuarioBuscado = textBoxUsuario.Text;
            string senha = textBoxSenha.Text;

            if (string.IsNullOrWhiteSpace(usuarioBuscado))
            {
                labelResultado.Text = "Usuário é obrigatorio!!!";
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

            int posicaoUsuarioEncontrado = -1;

            for (int i = 0; i < listaUsuarios.Count; i++)
            {
                if (usuarioBuscado == listaUsuarios[i])
                {
                    posicaoUsuarioEncontrado = i;
                }
            }



            if (posicaoUsuarioEncontrado > -1 && senha == listaSenhas[posicaoUsuarioEncontrado])
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

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            string novoUsuario = textBoxnovoUsuario.Text;
            string novaSenha = textBoxnovaSenha.Text;
            bool usuarioEncontrado = false;

            for (int i = 0; i < listaUsuarios.Count; i++)
            {
                if (novoUsuario == listaUsuarios[i])
                {
                    usuarioEncontrado = true;
                }
            }

            if (usuarioEncontrado == false)
            {
                listaUsuarios.Add(novoUsuario);
                listaSenhas.Add(novaSenha);
                labelCadastro.Text = "Usuário com sucesso!";
                labelCadastro.ForeColor = Color.Green;
            }
            else
            {
                labelCadastro.Text = "Já existe um usuário cadastrado";
                labelCadastro.ForeColor = Color.Red;
            }

            if (!Regex.IsMatch(novaSenha, @"[0-9]"))
                labelCadastro.Text = "A senha deve conter pelo menos 1 número.";

            if (!Regex.IsMatch(novaSenha, @"[!@#$%^&*(),.?""{}|<>]"))
                labelCadastro.Text = "A senha deve conter pelo menos 1 caractere especial.";

            if (!Regex.IsMatch(novaSenha, @"[A-Z]"))
                labelCadastro.Text = "A senha deve conter pelo menos 1 letra maiúscula.";

            if (!Regex.IsMatch(novaSenha, @"[a-z]"))
                labelCadastro.Text = "A senha deve conter pelo menos 1 letra minúscula.";

            if (novaSenha.Contains(" "))
               labelCadastro.Text =  "A senha não pode conter espaços.";

        }
    }
}
