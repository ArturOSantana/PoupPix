using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Pouppix
{
    internal class DaoUsuario
    {
        private string connectionString = "server=localhost;user=root;password=root;database=pouppix";

       
        public void testeConexao()
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    Console.WriteLine("Conexão bem-sucedida!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao conectar ao banco de dados: " + ex.Message);
            }
        }


        public bool buscarUsuario(string email, string senha)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string sql = "SELECT * FROM usuario WHERE email = @email AND senha = @senha;";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@senha", senha);
                        using (MySqlDataReader rdr = cmd.ExecuteReader())
                        {
                            if (rdr.Read())
                            {
                                if(email == rdr.GetString("email") && senha == rdr.GetString("senha"))
                                {
                                    return true;
                                }
                                else
                                {
                                    return false;
                                }
                            } else
                            {
                                return false;
                            }
                            
                           
                        }
                    }
                }
            }
            catch (Exception erroBuscaUsuario)
            {       
                Console.WriteLine("Erro ao buscar usuário: " + erroBuscaUsuario.Message);
                return false;
            }
        }





        public void cadastrarUsuario(Usuario u)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(connectionString))
                {
                    conexao.Open();
                    string sql = "INSERT INTO usuario (nome,senha,email) VALUES (@nome,@senha,@email);";
                    using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                    {
                        cmd.Parameters.AddWithValue("@nome",u.nome);
                        cmd.Parameters.AddWithValue("@senha",u.senha);
                        cmd.Parameters.AddWithValue("@email", u.email);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception erroCadastroUsuario)
            {
                Console.WriteLine("Erro ao cadastrar usuário: " + erroCadastroUsuario.Message);
            }
        }
    }
}
