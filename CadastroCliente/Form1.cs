namespace CadastroCliente
{
    public partial class Form1 : Form
    {
        List<Cliente> clientes = new List<Cliente>();
        private readonly BindingSource BindingSource = [];
        public Form1()
        {
            InitializeComponent();
            EnderecoCliente enderecoIdMarcelo = new EnderecoCliente() { logradouro = "Rua José Francisco de Freitas", numero = "133", complemento = "Não tem", bairro = "Jardim Maria Rita", municipio = "São Paulo", estado = "São Paulo", cep = "04814-180" };
            EnderecoCliente enderecoIdEduardo = new EnderecoCliente() { logradouro = "Rua Manoel Caldeira", numero = "583", complemento = "Não tem", bairro = "Jardim Ana Lúcia", municipio = "São Paulo", estado = "São Paulo", cep = "04812-000" };
            EnderecoCliente enderecoIdLeonice = new EnderecoCliente() { logradouro = "Avenida Gonçalo de Paiva de Gomes", numero = "166", complemento = "Não tem", bairro = "Jardim República", municipio = "São Paulo", estado = "São Paulo", cep = "04915-160" };
            clientes.Add(new Cliente() { id = 1, nome = "Marcelo Ferreira", DataNascimento = "06/07/2006", telefone = "(11) 96029-5985", email = "marcelo06ferr@email.com", endereco = enderecoIdMarcelo, genero = GeneroCliente.Masculino, NomeSocial = "", Etnia = EtniaCliente.Branco, estrangeiro = false, tipo = TipoCliente.PF });
            clientes.Add(new Cliente() { id = 2, nome = "Eduardo Henrique", DataNascimento = "10/11/1996", telefone = "(11) 98020-2499", email = "edu1910@email.com", endereco = enderecoIdEduardo, genero = GeneroCliente.Masculino, NomeSocial = "", Etnia = EtniaCliente.Branco, estrangeiro = false, tipo = TipoCliente.PF });
            clientes.Add(new Cliente() { id = 3, nome = "Leonice Ramos", DataNascimento = "11/12/1956", telefone = "(11) 98020-2502", email = "nice.mwa@email.com", endereco = enderecoIdLeonice, genero = GeneroCliente.Feminino, NomeSocial = "", Etnia = EtniaCliente.Branco, estrangeiro = false, tipo = TipoCliente.PF });


            BindingSource.DataSource = clientes;
            dataGridViewClientes.DataSource = BindingSource;
        }

        public bool LimparErro()
        {
            labelErro.Text = "";
            return true;
        }

        public bool Validacoes()
        {
            string nomeCliente = textBoxNome.Text;
            string DataNascCliente = maskedTextBoxDataNasc.Text;
            string telefoneCliente = maskedTextBoxTelefone.Text;
            string emailCliente = textBoxEmail.Text;
            string logradouroCliente = textBoxLogradouro.Text;
            string numeroEnderecoCliente = textBoxNumeroCs.Text;
            string bairroCliente = textBoxBairro.Text;
            string municipioCliente = textBoxMunicipio.Text;
            string cepCliente = maskedTextBoxCep.Text;


            //Nome
            if (string.IsNullOrWhiteSpace(nomeCliente))
            {
                labelErro.Text = "O Nome é obrigatorio!!!";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            if (nomeCliente.Any(char.IsNumber))
            {
                labelErro.Text = "O Nome só pode conter letras!!!";
                labelErro.ForeColor = Color.Red;
                return false;
            }


            //Data de Nascimento
            if (DataNascCliente == "  /  /" || DataNascCliente.Length < 10)
            {
                labelErro.Text = "A Data de Nascimento é obrigatoria!!!";
                labelErro.ForeColor = Color.Red;
                return false;
            }


            //Telefone
            if (telefoneCliente == "(  )      -" || telefoneCliente.Length < 15)
            {
                labelErro.Text = "O Telefone é obrigatorio!!!";
                labelErro.ForeColor = Color.Red;
                return false;
            }


            //Email
            if (string.IsNullOrWhiteSpace(emailCliente))
            {
                labelErro.Text = "O Email é obrigatorio!!!";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            if (!emailCliente.EndsWith("@email.com"))
            {
                labelErro.Text = "O Email deve conter @email.com!!!";
                labelErro.ForeColor = Color.Red;
                return false;
            }


            //Gênero
            if (comboBoxGenero.SelectedItem == null)
            {
                labelErro.Text = "Selecione algum gênero!!!";
                labelErro.ForeColor = Color.Red;
                return false;
            }


            //Etnia
            if (comboBoxEtnia.SelectedItem == null)
            {
                labelErro.Text = "Selecione alguma etnia!!!";
                labelErro.ForeColor = Color.Red;
                return false;
            }


            //Tipo de Cliente
            if (!radioButtonPF.Checked && !radioButtonPJ.Checked)
            {
                labelErro.Text = "Selecione algum Tipo!!!";
                labelErro.ForeColor = Color.Red;
                return false;
            }

            //Logradouro
            if (string.IsNullOrWhiteSpace(logradouroCliente))
            {
                labelErro.Text = "O Logradouro é obrigatorio!!!";
                labelErro.ForeColor = Color.Red;
                return false;
            }


            //Numero
            if (string.IsNullOrWhiteSpace(numeroEnderecoCliente))
            {
                labelErro.Text = "O Numero é obrigatorio!!!";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            if (numeroEnderecoCliente.All(char.IsLetter))
            {
                labelErro.Text = "O Numero não pode só conter letras!!!";
                labelErro.ForeColor = Color.Red;
                return false;
            }


            //Bairro
            if (string.IsNullOrWhiteSpace(bairroCliente))
            {
                labelErro.Text = "O Bairro é obrigatorio!!!";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            if (bairroCliente.Any(char.IsNumber))
            {
                labelErro.Text = "O Bairro não pode conter numeros!!!";
                labelErro.ForeColor = Color.Red;
                return false;
            }

            //Municipio
            if (string.IsNullOrWhiteSpace(municipioCliente))
            {
                labelErro.Text = "O Município é obrigatorio!!!";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            if (municipioCliente.Any(char.IsNumber))
            {
                labelErro.Text = "O Município não pode conter numeros!!!";
                labelErro.ForeColor = Color.Red;
                return false;
            }


            //Estados
            if (comboBoxEstado.SelectedItem == null)
            {
                labelErro.Text = "Selecione algum Estado!!!";
                labelErro.ForeColor = Color.Red;
                return false;
            }


            //CEP
            if (cepCliente == "     -" || cepCliente.Length < 9)
            {
                labelErro.Text = "O CEP é obrigatorio!!!";
                labelErro.ForeColor = Color.Red;
                return false;
            }

            return true;
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            //Validações
            if (!LimparErro())
            {
                return;
            }

            if (!Validacoes())
            {
                return;
            }

            TipoCliente tipo;

            if (radioButtonPF.Checked)
            {
                tipo = TipoCliente.PF;
            }
            else
            {
                tipo = TipoCliente.PJ;
            }

            GeneroCliente Genero;

            switch (comboBoxGenero.SelectedIndex)
            {
                case 0:
                    Genero = GeneroCliente.Masculino;
                    break;

                case 1:
                    Genero = GeneroCliente.Feminino;
                    break;

                case 2:
                    Genero = GeneroCliente.NãoBinário;
                    break;

                case 3:
                    Genero = GeneroCliente.Outro;
                    break;

                default:
                    Genero = GeneroCliente.Outro;
                    break;
            }

            EtniaCliente etnia;

            switch (comboBoxEtnia.SelectedIndex)
            {
                case 0:
                    etnia = EtniaCliente.Branco;
                    break;

                case 1:
                    etnia = EtniaCliente.Negro;
                    break;

                case 2:
                    etnia = EtniaCliente.Pardo;
                    break;

                case 3:
                    etnia = EtniaCliente.Indígena;
                    break;

                case 4:
                    etnia = EtniaCliente.Amarelo;
                    break;

                default:
                    etnia = EtniaCliente.Outro;
                    break;
            }


            string emailCliente = textBoxEmail.Text;
            string telefoneCliente = maskedTextBoxTelefone.Text;
            int ClienteCadastrado = -1;

            for (int i = 0; i < clientes.Count; i++)
            {
                if (emailCliente == clientes[i].email || telefoneCliente == clientes[i].telefone)
                {
                    ClienteCadastrado = i;
                }
            }

            if (ClienteCadastrado > -1)
            {
                labelAviso.Text = "Cliente já cadastrado!";
                labelAviso.ForeColor = Color.Red;
            }
            else
            {
                EnderecoCliente enderecoNovoCliente = new EnderecoCliente() { logradouro = textBoxLogradouro.Text, numero = textBoxNumeroCs.Text, complemento = textBoxComple.Text, bairro = textBoxBairro.Text, municipio = textBoxMunicipio.Text, estado = comboBoxEstado.Text, cep = maskedTextBoxCep.Text };
                clientes.Add(new Cliente() { id = clientes.ElementAt(clientes.Count - 1).id + 1, nome = textBoxNome.Text, DataNascimento = maskedTextBoxDataNasc.Text, telefone = maskedTextBoxTelefone.Text, email = textBoxEmail.Text, genero = Genero, NomeSocial = textBoxNomeSocial.Text, Etnia = etnia, estrangeiro = checkBoxEstrangeiro.Checked, tipo = tipo, endereco = enderecoNovoCliente });
                labelAviso.Text = "Cliente Cadastrado!";
                labelAviso.ForeColor = Color.Green;
                BindingSource.ResetBindings(false);
            }

        }
    }
}
