using CadastroCliente.banco_de_dados;
using CadastroCliente.dominio;
using MySql.Data.MySqlClient;
using System.Data;

namespace CadastroCliente.repositorio
{
    internal class ClienteRepositorio
    {
        public List<Cliente> ListarClientes()
        {
            var clientes = new List<Cliente>();

            using (var conn = Database.GetConnection())
            {
                conn.Open();

                string query = "SELECT c.*, e.logradouro, e.numero, e.complemento, e.bairro, e.municipio, e.estado, e.cep FROM cliente c JOIN endereco e ON c.id_endereco = e.id;";

                using var cmd = new MySqlCommand(query, conn);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var nomeSocial = !reader.IsDBNull("nome_social") ? reader.GetString("nome_social") : "";
                    var complemento = !reader.IsDBNull("complemento") ? reader.GetString("complemento") : "";

                    clientes.Add(new Cliente
                    {
                        id = reader.GetInt32("id"),
                        nome = reader.GetString("nome"),
                        NomeSocial = nomeSocial,
                        DataNascimento = reader.GetDateTime("data_nascimento"),
                        email = reader.GetString("email"),
                        telefone = reader.GetString("telefone"),
                        tipo = (TipoCliente)reader.GetInt32("tipo"),
                        Etnia = (EtniaCliente)reader.GetInt32("etnia"),
                        genero = (GeneroCliente)reader.GetInt32("genero"),
                        estrangeiro = reader.GetBoolean("estrangeiro"),
                        endereco = new EnderecoCliente
                        {
                            id = reader.GetInt32("id_endereco"),
                            logradouro = reader.GetString("logradouro"),
                            numero = reader.GetString("numero"),
                            complemento = complemento,
                            bairro = reader.GetString("bairro"),
                            municipio = reader.GetString("municipio"),
                            estado = reader.GetString("estado"),
                            cep = reader.GetString("cep")
                        }
                    });
                }
            }

            return clientes;
        }

        public void InserirCliente(Cliente novoCliente)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();

                string queryEndereco = "INSERT INTO endereco (logradouro, numero, bairro, municipio, estado, cep, complemento) " +
                                        "VALUES (@logradouro, @numero, @bairro, @municipio, @estado, @cep, @complemento);";
                using (var cmd = new MySqlCommand(queryEndereco, conn))
                {
                    cmd.Parameters.AddWithValue("@logradouro", novoCliente.endereco.logradouro);
                    cmd.Parameters.AddWithValue("@numero", novoCliente.endereco.numero);
                    cmd.Parameters.AddWithValue("@bairro", novoCliente.endereco.bairro);
                    cmd.Parameters.AddWithValue("@municipio", novoCliente.endereco.municipio);
                    cmd.Parameters.AddWithValue("@estado", novoCliente.endereco.estado);
                    cmd.Parameters.AddWithValue("@cep", novoCliente.endereco.cep);
                    cmd.Parameters.AddWithValue("@complemento", novoCliente.endereco.complemento);
                    cmd.ExecuteNonQuery();
                }

                int idEndereco = -1;
                string queryIdEndereco = "SELECT id FROM endereco " +
                                            "WHERE logradouro = @logradouro " +
                                            "AND numero = @numero " +
                                            "AND bairro = @bairro " +
                                            "AND municipio = @municipio " +
                                            "AND estado = @estado " +
                                            "AND cep = @cep " +
                                            "AND complemento = @complemento;";
                using (var cmd = new MySqlCommand(queryIdEndereco, conn))
                {
                    cmd.Parameters.AddWithValue("@logradouro", novoCliente.endereco.logradouro);
                    cmd.Parameters.AddWithValue("@numero", novoCliente.endereco.numero);
                    cmd.Parameters.AddWithValue("@bairro", novoCliente.endereco.bairro);
                    cmd.Parameters.AddWithValue("@municipio", novoCliente.endereco.municipio);
                    cmd.Parameters.AddWithValue("@estado", novoCliente.endereco.estado);
                    cmd.Parameters.AddWithValue("@cep", novoCliente.endereco.cep);
                    cmd.Parameters.AddWithValue("@complemento", novoCliente.endereco.complemento);
                    using (var reader = cmd.ExecuteReader())
                    {
                        idEndereco = reader.Read() ? reader.GetInt32("id") : -1;
                    }
                }

                string query = "INSERT INTO cliente (nome, nome_social, data_nascimento, email, telefone, tipo, etnia, genero, estrangeiro, id_endereco) " +
                                    "VALUES (@nome, @nome_social, @data_nascimento, @email, @telefone, @tipo, @etnia, @genero, @estrangeiro, @id_endereco);";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nome", novoCliente.nome);
                    cmd.Parameters.AddWithValue("@nome_social", novoCliente.NomeSocial);
                    cmd.Parameters.AddWithValue("@data_nascimento", novoCliente.DataNascimento);
                    cmd.Parameters.AddWithValue("@email", novoCliente.email);
                    cmd.Parameters.AddWithValue("@telefone", novoCliente.telefone);
                    cmd.Parameters.AddWithValue("@tipo", novoCliente.tipo);
                    cmd.Parameters.AddWithValue("@etnia", novoCliente.Etnia);
                    cmd.Parameters.AddWithValue("@genero", novoCliente.genero);
                    cmd.Parameters.AddWithValue("@estrangeiro", novoCliente.estrangeiro);
                    cmd.Parameters.AddWithValue("@id_endereco", idEndereco);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //public void UpdateCliente(Client client)
        //{
        //    using (var conn = Database.GetConnection())
        //    {
        //        conn.Open();
        //        string query = "UPDATE clients SET name=@name, email=@email, phone=@phone WHERE id=@id";
        //        using (var cmd = new MySqlCommand(query, conn))
        //        {
        //            cmd.Parameters.AddWithValue("@id", client.Id);
        //            cmd.Parameters.AddWithValue("@name", client.Name);
        //            cmd.Parameters.AddWithValue("@email", client.Email);
        //            cmd.Parameters.AddWithValue("@phone", client.Phone);
        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //}

        //public void DeleteCliente(int id)
        //{
        //    using (var conn = Database.GetConnection())
        //    {
        //        conn.Open();
        //        string query = "DELETE FROM clients WHERE id=@id";
        //        using (var cmd = new MySqlCommand(query, conn))
        //        {
        //            cmd.Parameters.AddWithValue("@id", id);
        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //}
    }
}

