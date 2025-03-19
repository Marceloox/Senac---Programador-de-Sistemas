namespace CadastroCliente
{
    public partial class Form1 : Form
    {
        List<Cliente> clientes = new List<Cliente>();
        public Form1()
        {
            InitializeComponent();
            EnderecoCliente enderecoId1 = new EnderecoCliente() { logradouro = "Rua José Francisco de Freitas", numero = "133", complemento = "Não tem", bairro = "Jardim Maria Rita", municipio = "São Paulo", estado = "São Paulo", cep = "04814-180" };
            EnderecoCliente enderecoId2 = new EnderecoCliente() { logradouro = "Rua Manoel Caldeira", numero = "583", complemento = "Não tem", bairro = "Jardim Ana Lúcia", municipio = "São Paulo", estado = "São Paulo", cep = "04812-000" };
            EnderecoCliente enderecoId3 = new EnderecoCliente() { logradouro = "Avenida Gonçalo de Paiva de Gomes", numero = "166", complemento = "Não tem", bairro = "Jardim República", municipio = "São Paulo", estado = "São Paulo", cep = "04915-160" };
            clientes.Add(new Cliente() { id = 1, nome = "Marcelo Ferreira", DataNascimento = "06/07/2006", telefone = "(11)96029-5985", email = "marcelo06ferr@gmail.com", endereco = enderecoId1, genero = GeneroCliente.Masculino, NomeSocial = "Não se aplica", Etnia = EtniaCliente.Branco, estrangeiro = false, tipo = TipoCliente.PF });
            clientes.Add(new Cliente() { id = 2, nome = "Eduardo Henrique", DataNascimento = "10/11/1996", telefone = "(11)98020-2499", email = "edu1910@gmail.com", endereco = enderecoId2, genero = GeneroCliente.Masculino, NomeSocial = "Não se aplica", Etnia = EtniaCliente.Branco, estrangeiro = false, tipo = TipoCliente.PF });
            clientes.Add(new Cliente() { id = 3, nome = "Leonice Ramos", DataNascimento = "11/12/1956", telefone = "(11)98020-2502", email = "nice.mwa@gmail.com", endereco = enderecoId3, genero = GeneroCliente.Feminino, NomeSocial = "Não se aplica", Etnia = EtniaCliente.Branco, estrangeiro = false, tipo = TipoCliente.PF });

        }

        
    }
}
