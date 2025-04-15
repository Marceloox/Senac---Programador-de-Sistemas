using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using MySql.Data.MySqlClient;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividades.Banco_de_dados
{
    internal class Database
    {
        private static readonly string ConnectionString = "datasource=localhost;username=root;password=;database=senacmarcelo;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
    }
}
