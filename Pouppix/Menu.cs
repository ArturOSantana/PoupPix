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
    }
}
