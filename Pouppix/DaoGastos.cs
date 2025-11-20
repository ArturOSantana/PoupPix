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




















    }
}
