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
           
            Usuario usuarioLogado = DaoUsuario.buscarUsuario(txtlogin.Text, txtloginsenha.Text);

            if(usuarioLogado != null)
            {
                Menu menuForm = new Menu(usuarioLogado);
                menuForm.Show();
                this.Hide();
            }
            else
            {
            MessageBox.Show("Login ou senha incorretos. Tente novamente.");
            }
        }
    }
}
 