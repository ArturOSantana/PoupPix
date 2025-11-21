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
           
    public partial class AdicionarReceita : Form
    {
        private Usuario usuarioLogado;
        public AdicionarReceita(Usuario usuarioLogado)
        {
            InitializeComponent();
            this.usuarioLogado = usuarioLogado;
        }

        private void btnaddReceita_Click(object sender, EventArgs e)
        {
            int idU = usuarioLogado.id;
            string nomeReceita = txtNomeReceita.Text;
           
                double valorReceita = Convert.ToDouble(txtvalorReceita.Text);
            

            DateTime dataHoje = DateTime.Now;
            if (dataEntradaReceita.Value > dataHoje)
            {
                MessageBox.Show("A data da receita não pode ser futura.");
            }
            else
            {
                if(txtvalorReceita.Text == "")
                {
                    MessageBox.Show("O valor da receita não pode ser vazio.");

                }
                else {
                    Receita receita = new Receita(usuarioLogado, nomeReceita, valorReceita, dataEntradaReceita.Value);
                    MessageBox.Show("Receita adicionada com sucesso");
                    this.Close();
                }
                
               
            }

               
        }
    }
}
