using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;
using MySql.Data.MySqlClient;

namespace Pouppix
{
    internal class DaoReceita
    {
        private string connectionString = "server=localhost;user=root;password=root;database=pouppix";
        DateTime hj = DateTime.Now;


        public void inserirReceita(Receita r, Usuario u) //INSERIR RECEITA NO BANCO, OBS: RECENE O ID DO USUARIO LOGADO
        {

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string sql = "INSERT INTO receita (usuario_id,descricao,valor,data_receita) VALUES (@usuario_id,@descricao,@valor,@data);";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@usuario_id", u.id);
                        cmd.Parameters.AddWithValue("@descricao", r.nome);
                        cmd.Parameters.AddWithValue("@valor", r.valor);
                        cmd.Parameters.AddWithValue("@data", hj);
                        cmd.ExecuteNonQuery();
                    }


                }
            }
            catch (Exception erroCriacaodeReceita)
            {
                Console.WriteLine("Erro ao inserir receita: " + erroCriacaodeReceita.Message);
            }

        }


        public void mostrarReceitas(Usuario u )
        {
            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                conexao.Open();
                string sql = "SELECT * FROM receita WHERE usuario_id = @usuario_id;";
                using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@usuario_id", u.id);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine("ID: " + reader["id"] + " | Descrição: " + reader["descricao"] + " | Valor: " + reader["valor"] + " | Data: " + reader["data_receita"]);
                        }
                    }
                }
            }
        }




        public void confirmarDelecao(int receitaId)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string sqlSelect = "SELECT FROM receita WHERE id = @receitaId;";
                    using (MySqlCommand cmd = new MySqlCommand(sqlSelect, conexao))
                    {
                        cmd.Parameters.AddWithValue("@receita", receitaId);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine("ID: " + reader["id"] + " | Descrição: " + reader["descricao"] + " | Valor: " + reader["valor"] + " | Data: " + reader["data_receita"]);
                                Console.WriteLine("Deseja realmente deletar esta receita? (s/n)");
                                string opt = Console.ReadLine();
                                switch (opt)
                                {
                                    case "s":
                                        deletarReceita(receitaId);
                                        Console.WriteLine("Receita deletada com sucesso.");
                                        break;
                                    case "n":
                                        Console.WriteLine("Deleção cancelada.");
                                        break;
                                    default:
                                        Console.WriteLine("Opção inválida. Deleção cancelada.");
                                        break;
                                }

                            }

                        }
                    }

                }
            }
            catch (Exception erroConfirmacaoDelecao)
            {
                Console.WriteLine("Erro ao confirmar deleção da receita: " + erroConfirmacaoDelecao.Message);
            } 
        }


        private void deletarReceita(int receitaId)
        {
            try
            {

                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {

                    string sql = "DELETE FROM receita WHERE id = @receitaId;";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@receitaId", receitaId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception erroDelecaoReceita)
            {
                Console.WriteLine("Erro ao deletar receita: " + erroDelecaoReceita.Message);
            }
        }












    }

}
