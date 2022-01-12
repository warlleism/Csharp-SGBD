using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpInteSGBD
{
    public class Cadastro
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        

        public Cadastro(string Descricao,double ValorPedido)
        {
            cmd.CommandText = "insert into Pedidos (Descricao,ValorPedido) values (@Descricao,@ValorPedido)";

            cmd.Parameters.AddWithValue("@Descricao", Descricao);
            cmd.Parameters.AddWithValue("@ValorPedido", ValorPedido);

            try
            {
                cmd.Connection = conexao.Conectar();

                cmd.ExecuteNonQuery();

                conexao.Desconectar();

            }
            catch(SqlException)
            {
                throw;
            }
        }

    }
}
