using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo_Produto.Dominio
{
    internal class Estoque
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public Produto IdProduto { get; set; }

       public string Validacoes()
        {
            if (Id < 0)
            {
                return "Id não pode ser negativo";
            }

            if (Quantidade < 0)
            {
                return "A quantidade não pode ser negativa";
            }

            return string.Empty;
        }
    }
}
