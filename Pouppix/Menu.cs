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
     partial class Menu : Form
    {
        private Usuario usuarioLogado;
        DaoGastos DaoG = new DaoGastos();
        DaoReceita DaoR = new DaoReceita();

        public Menu(Usuario u)
        {


            InitializeComponent();
            usuarioLogado = u;

        }

        private void adicionarGastoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form adicionarGastoForm = new AdicionarGasto(usuarioLogado);
            adicionarGastoForm.Show();

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            lblnome.Text = usuarioLogado.nome;
            double consumo = DaoG.somaGastos(usuarioLogado);

            if ( consumo > 0)
            {
                totalGastos.Text = "R$" + DaoG.somaGastos(usuarioLogado) + ",00";

            }
            else
            {
                totalGastos.Text = "R$0,00";
                MessageBox.Show("Gastos ainda não cadastrados");
            }

            double saldo = DaoR.somaReceitas(usuarioLogado);
            if (saldo > 0)
            {
                totalReceita.Text = "R$" + DaoR.somaReceitas(usuarioLogado) + ",00";

            }
            else
            {
                totalReceita.Text = "R$ 0,00";
                MessageBox.Show("Receita ainda não cadastrada ");
            }


                this.Refresh();
          
        }

        private void adicionarReceitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form adicionarReceitaform = new AdicionarReceita(usuarioLogado);
            adicionarReceitaform.Show();
        }

        public void atualizarDashboard()
        {
            totalGastos.Text = "R$" + DaoG.somaGastos(usuarioLogado) + ",00";


            totalReceita.Text = "R$" + DaoR.somaReceitas(usuarioLogado) + ",00";
        }

        private void mostrarGastosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form mostrarGastosforms = new MostrarGastos(usuarioLogado);
            mostrarGastosforms.Show();
        }
    }
}
