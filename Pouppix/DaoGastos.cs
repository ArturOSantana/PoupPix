using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Pouppix
{
    internal class DaoGastos
    {

        private string connectionString = "server=localhost;user=root;password=root;database=pouppix";

        public void adicionarGasto(Gastos g)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string sql = "INSERT INTO gasto (usuario_id, valor_gasto, tipo_id, data_gasto, nome_gasto) VALUES (@usuarioId, @valor, @tipo, @data, @descricao);";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@usuarioId", g.usuarioId);
                        cmd.Parameters.AddWithValue("@valor", g.valor);
                        cmd.Parameters.AddWithValue("@tipo", g.tipo);
                        cmd.Parameters.AddWithValue("@data", g.data);
                        cmd.Parameters.AddWithValue("@descricao", g.descricao);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception erroAddGasto)
            {
                Console.WriteLine("Erro ao adicionar gasto: " + erroAddGasto.Message);
                MessageBox.Show("Erro ao adicionar gasto: " + erroAddGasto.Message);
            }
        }

        public double somaGastos(Usuario u)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string sql = "SELECT SUM(valor_gasto) FROM gasto WHERE usuario_id = @id;";
                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("@id", u.id);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        double total = Convert.ToDouble(result);
                        return total;
                    }
                    else
                    {
                        return 0;
                    }

                }

            }
            catch (Exception erroSomaGastos)
            {
                Console.WriteLine("Erro ao somar gastos: " + erroSomaGastos.Message);
                MessageBox.Show("Erro ao somar gastos: " + erroSomaGastos.Message);
                return 0;
            }
        }

     
        public List<Gastos> mostrarGastos(Usuario u)
        {
            List<Gastos> listaGastos = new List<Gastos>();
            try 
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string sql = "SELECT * FROM gasto WHERE usuario_id = @id;";
                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("@id", u.id);
                   using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            Gastos  g = new Gastos(
                                u.id,
                                rdr.GetDouble("valor_gasto"),
                                rdr.GetInt32("tipo_id"),
                                rdr.GetDateTime("data_gasto"),
                                rdr.GetString("nome_gasto")
                               
                                );
                            g.idgasto = rdr.GetInt32("id_gasto");
                           
                            listaGastos.Add(g);

                        }
                    }

                    
                }
            }
            catch (Exception ErroAoExibir)
            {
                MessageBox.Show("Erro ao exibir gastos: " + ErroAoExibir.Message);
            }
            return listaGastos;
        }

        public void deletarGasto(int g)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string sql = "DELETE FROM gasto WHERE id_gasto = @id;";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@id", g);
                        cmd.ExecuteNonQuery();
                    }
                }

            }
            catch (Exception erroDeletarGasto)
            {
                MessageBox.Show("Erro ao deletar gasto: " + erroDeletarGasto.Message);
            }
        }



        public Gastos mostrarGastosporId(int id)
        {
            try
            {

                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string sql = "SELECT * FROM gasto WHERE id_gasto = @id;";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (MySqlDataReader rdr = cmd.ExecuteReader())
                        {
                            if (rdr.Read())
                            {
                                return new Gastos(
                                      rdr.GetInt32("usuario_id"),
                                      rdr.GetDouble("valor_gasto"),
                                      rdr.GetInt32("tipo_id"),
                                      rdr.GetDateTime("data_gasto"),
                                      rdr.GetString("nome_gasto")
                                      )
                                {
                                    idgasto = rdr.GetInt32("id_gasto")
                                };
                            }
                            else
                            {
                                return null;
                            }
                        }
                    }

                }
            }
            catch (Exception erroMostrarGastoPorId)
            {
              
                return null;
            }
        }















       
    }
}
