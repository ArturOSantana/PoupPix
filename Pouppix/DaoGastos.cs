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

     
        public void mostrarGastos(Usuario u)
        {
            try 
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string sql = "SELECT * FROM GASTOS WHERE usuario_id = @id;";
                    MySqlCommand cmd = new MySqlCommand(sql, conexao);
                    cmd.Parameters.AddWithValue("@id", u.id);
                   using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            int idusuario = Convert.ToInt32(rdr["usuario_id"]);
                            int idgasto = Convert.ToInt32(rdr["id_gasto"]);
                            string nomeG = rdr.GetString("nome_gasto");
                            double valor = rdr.GetDouble("valor_gasto");
                            DateTime data = rdr.GetDateTime("data_gasto");

                        }
                    }

                    
                }
            }
            catch (Exception ErroAoExibir)
            {

            }
        }




















       
    }
}
