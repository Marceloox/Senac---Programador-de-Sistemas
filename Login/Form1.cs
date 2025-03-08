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
        List<string> listaSenhas = new List<string>() { "Brun@123", "12345Abc!", "Sete7Sete!" };

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
            /*bool usuarioEncontrado = false;

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
            }*/

            if (string.IsNullOrWhiteSpace(novoUsuario))
            {
                labelCadastro.Text = "Usuario eh obrigatorio!!!";
                return;
            }

            if (string.IsNullOrWhiteSpace(novaSenha))
            {
                labelCadastro.Text = "Senha eh obrigatoria!!!";
                return;
            }

            if (novaSenha.Length < 8)
            {
                labelCadastro.Text = "A senha deve ter pelo menos 8 caracteres";
                return;
            }

            if (!novaSenha.Any(char.IsUpper))
            {
                labelCadastro.Text = "A senha deve ter pelo menos uma letra maiuscula";
                return;
            }

            if (!novaSenha.Any(char.IsLower))
            {
                labelCadastro.Text = "A senha deve ter pelo menos uma letra minuscula";
                return;
            }

            if (!novaSenha.Any(char.IsDigit))
            {
                labelCadastro.Text = "A senha deve ter pelo menos um numero";
                return;
            }

            if (!novaSenha.Any(char.IsPunctuation) && !novaSenha.Any(char.IsSymbol) && !novaSenha.Contains('@'))
            {
                labelCadastro.Text = "A senha deve ter pelo menos um caracter especial";
                return;
            }

            if (novaSenha.Contains(' '))
            {
                labelCadastro.Text = "A senha nao deve ter espacos em branco";
                return;
            }

            if (listaUsuarios.Contains(novoUsuario))
            {
                labelCadastro.Text = "Já existe um usuário cadastrado";
                return;
            }

            listaUsuarios.Add(novoUsuario);
            listaSenhas.Add(novaSenha);
            labelCadastro.Text = "Usuário cadastrado com sucesso!";
            textBoxnovoUsuario.Clear();
            textBoxnovaSenha.Clear();
        }
    }
}
