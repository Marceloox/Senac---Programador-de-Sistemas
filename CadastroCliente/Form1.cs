namespace CadastroCliente
{
    public partial class Form1 : Form
    {
        List<Cliente> clientes = new List<Cliente>();
        public Form1()
        {
            InitializeComponent();
            EnderecoCliente enderecoId1 = new EnderecoCliente() { logradouro = "Rua Jos� Francisco de Freitas", numero = "133", complemento = "N�o tem", bairro = "Jardim Maria Rita", municipio = "S�o Paulo", estado = "S�o Paulo", cep = "04814-180" };
            EnderecoCliente enderecoId2 = new EnderecoCliente() { logradouro = "Rua Manoel Caldeira", numero = "583", complemento = "N�o tem", bairro = "Jardim Ana L�cia", municipio = "S�o Paulo", estado = "S�o Paulo", cep = "04812-000" };
            EnderecoCliente enderecoId3 = new EnderecoCliente() { logradouro = "Avenida Gon�alo de Paiva de Gomes", numero = "166", complemento = "N�o tem", bairro = "Jardim Rep�blica", municipio = "S�o Paulo", estado = "S�o Paulo", cep = "04915-160" };
            clientes.Add(new Cliente() { id = 1, nome = "Marcelo Ferreira", DataNascimento = "06/07/2006", telefone = "(11)96029-5985", email = "marcelo06ferr@email.com", endereco = enderecoId1, genero = GeneroCliente.Masculino, NomeSocial = "N�o se aplica", Etnia = EtniaCliente.Branco, estrangeiro = false, tipo = TipoCliente.PF });
            clientes.Add(new Cliente() { id = 2, nome = "Eduardo Henrique", DataNascimento = "10/11/1996", telefone = "(11)98020-2499", email = "edu1910@email.com", endereco = enderecoId2, genero = GeneroCliente.Masculino, NomeSocial = "N�o se aplica", Etnia = EtniaCliente.Branco, estrangeiro = false, tipo = TipoCliente.PF });
            clientes.Add(new Cliente() { id = 3, nome = "Leonice Ramos", DataNascimento = "11/12/1956", telefone = "(11)98020-2502", email = "nice.mwa@email.com", endereco = enderecoId3, genero = GeneroCliente.Feminino, NomeSocial = "N�o se aplica", Etnia = EtniaCliente.Branco, estrangeiro = false, tipo = TipoCliente.PF });

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
                labelErro.Text = "O Nome � obrigatorio!!!";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            if (!nomeCliente.All(char.IsLetter))
            {
                labelErro.Text = "O Nome s� pode conter letras!!!";
                labelErro.ForeColor = Color.Red;
                return false;
            }


            //Data de Nascimento
            if (DataNascCliente == "  /  /" || DataNascCliente.Length < 10)
            {
                labelErro.Text = "A Data de Nascimento � obrigatoria!!!";
                labelErro.ForeColor = Color.Red;
                return false;
            }


            //Telefone
            if (telefoneCliente == "(  )      -" || telefoneCliente.Length < 15)
            {
                labelErro.Text = "O Telefone � obrigatorio!!!";
                labelErro.ForeColor = Color.Red;
                return false;
            }


            //Email
            if (string.IsNullOrWhiteSpace(emailCliente))
            {
                labelErro.Text = "O Email � obrigatorio!!!";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            if (!emailCliente.EndsWith("@email.com"))
            {
                labelErro.Text = "O Email deve conter @email.com!!!";
                labelErro.ForeColor = Color.Red;
                return false;
            }


            //G�nero
            if (comboBoxGenero.SelectedItem == null)
            {
                labelErro.Text = "Selecione algum g�nero!!!";
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
                labelErro.Text = "O Logradouro � obrigatorio!!!";
                labelErro.ForeColor = Color.Red;
                return false;
            }


            //Numero
            if (string.IsNullOrWhiteSpace(numeroEnderecoCliente))
            {
                labelErro.Text = "O Numero � obrigatorio!!!";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            if (numeroEnderecoCliente.All(char.IsLetter))
            {
                labelErro.Text = "O Numero n�o pode s� conter letras!!!";
                labelErro.ForeColor = Color.Red;
                return false;
            }


            //Bairro
            if (string.IsNullOrWhiteSpace(bairroCliente))
            {
                labelErro.Text = "O Bairro � obrigatorio!!!";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            if (bairroCliente.Any(char.IsNumber))
            {
                labelErro.Text = "O Bairro n�o pode conter numeros!!!";
                labelErro.ForeColor = Color.Red;
                return false;
            }

            //Municipio
            if (string.IsNullOrWhiteSpace(municipioCliente))
            {
                labelErro.Text = "O Munic�pio � obrigatorio!!!";
                labelErro.ForeColor = Color.Red;
                return false;
            }
            if (municipioCliente.Any(char.IsNumber))
            {
                labelErro.Text = "O Munic�pio n�o pode conter numeros!!!";
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
                labelErro.Text = "O CEP � obrigatorio!!!";
                labelErro.ForeColor = Color.Red;
                return false;
            }

            return true;
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            if (!LimparErro())
            {
                return;
            }

            if (!Validacoes())
            {
                return;
            }
            
            /*
            string emailCliente = textBoxEmail.Text;
            string telefoneCliente = maskedTextBoxTelefone.Text;
            int ClienteCadastrado = -1;

            for (int i = 0; i < clientes.Count; i++) 
            {
                if (emailCliente == clientes[i].email && telefoneCliente == clientes[i].telefone)
                {
                    ClienteCadastrado = i;
                }
            }
            
            if (ClienteCadastrado > -1)
            {
                labelAviso.Text = "Cliente j� cadastrado!";
            }
            else
            {
                labelAviso.Text = "Cliente Cadastrado!";
            }*/
        }
    }
}
