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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pouppix
{
    public partial class MostrarGastos : Form
    {
        private string con = "server=localhost;user=root;password=root;database=pouppix";
        int idGasto = 0;

        private Usuario usuarioLogado;
        DaoGastos DaoG = new DaoGastos();
        
        public MostrarGastos(Usuario u)
        {
            InitializeComponent();
            usuarioLogado = u;

        }

        private void MostrarGastos_Load(object sender, EventArgs e)
        {
            carregarGrid();
        }

        private void carregarGrid()
        {
            /* GERAR DE FORMA AUTOMATICA AS COLUNAS
              dgv.AutoGenerateColumns = true;
             List<Gastos> listaGastos = DaoG.mostrarGastos(usuarioLogado);

             dgv.DataSource= DaoG.mostrarGastos(usuarioLogado);
      */

            dgv.Rows.Clear();
            List<Gastos> listaGastos = DaoG.mostrarGastos(usuarioLogado);
            foreach (Gastos g in listaGastos)
            {
                dgv.Rows.Add(
                    g.idgasto,
                g.descricao,
                    g.valor,
                    g.tipo,
                    g.data.ToString("dd/MM/yyyy")

                );

            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0)
            {
                MessageBox.Show("Aperte em um local valido");
            }


            if (dgv.Columns[e.ColumnIndex].Name == "btnExcluir")
            {
                int gastoId = Convert.ToInt32(dgv.Rows[e.RowIndex].Cells["idgasto"].Value);

                object resposta = MessageBox.Show("Tem certeza que deseja excluir este gasto?", "Confirmação de deleção",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resposta.Equals(DialogResult.Yes))
                {
                    DaoG.deletarGasto(gastoId);
                    carregarGrid();
                }



            }

            if (dgv.Columns[e.ColumnIndex].Name == "btnEditar")
            {
            }
         }
      











            }
        }
