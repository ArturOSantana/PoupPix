using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pouppix
{
   public class Usuario
    {
        DaoUsuario DaoUsuario = new DaoUsuario();

        public int id { set; get; }
        public string nome { set; get; }
        public string senha { set; get; }
        public string email { set; get; }
        public bool autenticado { set; get; }




        public Usuario() { }
        public Usuario( string n,string s,string e)
        {
            
            this.nome = n;
            this.email = e;
            this.senha = s;
            

            DaoUsuario.cadastrarUsuario(this);

        }


      
        }

       




        }

