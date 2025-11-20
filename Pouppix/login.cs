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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void linkcadastro_Click(object sender, EventArgs e)
        {
            Form cadastroForm = new Cadastro();
            cadastroForm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DaoUsuario DaoUsuario = new DaoUsuario();
            bool autenticado;
            autenticado = DaoUsuario.buscarUsuario(txtlogin.Text, txtloginsenha.Text);

            if (autenticado == true)
            {
                Form MenuForm = new Menu();
                MenuForm.Show();
                this.Hide();
            }
            else if (autenticado == false)
            {
                MessageBox.Show("Email ou senha incorretos!");
            }
            else
            {

            }
        }
    }
}
