using MySql.Data.MySqlClient;


namespace PI.Repositorio
{
    internal class RepositorioPi
    {
       public void InserirCliente(string NovoCliente)
        {
            using (var con = Database.GetConnection())
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

        public void InserirPedido(string NovoPedido)
        {
            using (var con = Database.GetConnection())
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

        public List<Pedido> ListarPedidoPendentes()
        {
            List<Pedido> pedidos = [];

            using (var con = Database.GetConnection())
            {
                con.Open();

                string query = $"SELECT * FROM pedido WHERE estado = {(bool)Estado.Pendente};";

                using (var cmd = new MySqlCommand(query, con))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            pedidos.Add(new Pedido()
                            {
                                Id = reader.GetInt32("id"),
                                DataDoPedido = reader.GetString("estado"),
                                Estado = (Estado)reader.GetBoolean("estado"),
                                Id_cliente = reader.GetInt32("id_cliente")
                            });
                        }
                    }
                }
            }

            return pedidos;
        }

        public void AtualizarPedido(int id, bool novaSituacao)
        {
            using (var con = Database.GetConnection())
            {
                con.Open();

                string query = "UPDATE pedido ped SET ped.estado = @ped.estado WHERE ped.id = @ped.id;";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ped.estado", novaSituacao);
                    cmd.Parameters.AddWithValue("@ped.id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
