using CadastroCliente.repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCliente.dominio
{
    internal class Cliente
    {
        private readonly ClienteRepositorio ClienteRepositorio = new();

        public int id { get; set;}
        public string nome { get; set;}
        public DateTime DataNascimento { get; set;}
        public string telefone { get; set;}
        public string email {  get; set;}
        public EnderecoCliente endereco { get; set;}
        public GeneroCliente genero {  get; set;}
        public string NomeSocial { get; set;}
        public EtniaCliente Etnia { get; set;}
        public bool estrangeiro { get; set;}
        public TipoCliente tipo { get; set;}

        public List<Cliente> ListarClientes()
        {
            return ClienteRepositorio.ListarClientes();
        }

        public void InserirCliente(Cliente novoCliente)
        {
            ClienteRepositorio.InserirCliente(novoCliente);
        }
    }
}
