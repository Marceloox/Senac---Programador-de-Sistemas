using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCliente
{
    internal class Cliente
    {
        public int id { get; set;}
        public string nome { get; set;}
        public string DataNascimento { get; set;}
        public string telefone { get; set;}
        public string email {  get; set;}
        public EnderecoCliente endereco { get; set;}
        public GeneroCliente genero {  get; set;}
        public string NomeSocial { get; set;}
        public EtniaCliente Etnia { get; set;}
        public bool estrangeiro { get; set;}
        public TipoCliente tipo { get; set;}
    }
}
