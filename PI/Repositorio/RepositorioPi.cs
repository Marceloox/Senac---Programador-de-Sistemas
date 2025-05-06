using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System.Data;


namespace PI.Repositorio
{
    internal class RepositorioPi
    {
       public void InserirCliente(string NovoCliente)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string query = $"INSERT INTO cliente(nome, email, cpf) VALUES(@nome, @email, @cpf);";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nome", NovoCliente.nome);
                    cmd.Parameters.AddWithValue("@email", NovoCliente.email);
                    cmd.Parameters.AddWithValue("@cpf", NovoCliente.cpf);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Cliente> ListarClientes()
        {
            var clientes = new List<Cliente>();

            using (var conn = DataBase.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM cliente";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("id", Cliente.Id);
                    cmd.Parameters.AddWithValue("nome", Cliente.Nome);
                    cmd.Parameters.AddWithValue("email", Cliente.Email);
                    cmd.Parameters.AddWithValue("Telefone", Cliente.Telefone);
                    cmd.Parameters.AddWithValue("CPF", Cliente.CPF);
                    cmd.ExecuteNonQuery();
                }
            }
            return clientes;
        }

        public void InserirPedido(string NovoPedido)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string query = $"INSERT INTO pedido p(c.nome, p.dataDoPedido, p.estado) VALUES(@c.nome, @p.dataDoPedido, {(bool)Estado.Pendente}) INNER JOIN cliente c ON p.id_cliente c.id;";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@c.nome", NovoPedido.nome);
                    cmd.Parameters.AddWithValue("@p.dataDoPedido", NovoPedido.dataDoPedido);
                    cmd.Parameters.AddWithValue("@estado", NovoPedido.Estado);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Pedido BuscarPedidoPendente()
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string query = $"SELECT * FROM atividade WHERE situacao = {(bool)Estado.Realizando};";

                using (var cmd = new MySqlCommand(query, con))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Pedido()
                            {
                                Id = reader.GetInt32("id"),
                                dataDoPedido = reader.GetString("dataDoPedido"),
                                Estado = (Estado)reader.GetBoolean("estado"),
                                Id_cliente = reader.GetInt32("id_cliente")
                            };
                        }
                    }
                }
            }

            return new Pedido();
        }

        public void AtualizarPedido(int id, bool novoEstado)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string query = "UPDATE pedido ped SET ped.estado = @ped.estado WHERE ped.id = @ped.id;";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ped.estado", novoEstado);
                    cmd.Parameters.AddWithValue("@ped.id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void CancelarPedido(string NovoPedido)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string query = $"DELETE FROM pedido WHERE estado = Vencido";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("id", NovoPedido.id);
                    cmd.Parameters.AddWithValue("estado", NovoPedido.estado);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
