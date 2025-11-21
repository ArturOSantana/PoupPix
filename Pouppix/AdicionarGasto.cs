using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pouppix
{
    public partial class AdicionarGasto : Form
    {
        private Usuario usuarioLogado;
        private string con = "server=localhost;user=root;password=root;database=pouppix";
        public AdicionarGasto(Usuario u)
        {
            InitializeComponent();
            usuarioLogado = u;
            carregarTipos();
        }

        public void carregarTipos()
        {
            using (MySqlConnection conexao = new MySqlConnection(con))
            {
                conexao.Open();
                string sql = "SELECT * FROM tipo_gasto;";
                using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                using (MySqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        comboBox.Items.Add(new TipoGasto()
                        {
                            id = Convert.ToInt32(rdr["id_tipo"]),
                            nome = rdr.GetString("nome_tipo")
                        });
                    }
                }
            }
        }
        public int obterTipoSelecionado()
        {

            TipoGasto tipo = (TipoGasto)comboBox.SelectedItem;
            return tipo.id;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int tipoId = obterTipoSelecionado();

            double txtvaloraux = Convert.ToDouble(txtValorGasto.Text);
            string txtNomeGasto = txtGasto.Text;
            try
            {
                if (dataGasto.Value > DateTime.Now)
                {
                    MessageBox.Show("A data do gasto não pode ser futura.");

                }
                else
                {
                    DaoGastos dao = new DaoGastos();
                    Gastos g = new Gastos(usuarioLogado.id, txtvaloraux, tipoId, dataGasto.Value, txtNomeGasto);
                    dao.adicionarGasto(g);
                    MessageBox.Show("Gasto adicionado com sucesso");
                }
            }
            catch (Exception erroaddgastonoform)
            {
                MessageBox.Show("Erro ao adicionar gasto: " + erroaddgastonoform.Message);

            }


        }
    }
}
