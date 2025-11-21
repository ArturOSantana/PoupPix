using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pouppix
{
    internal class Receita
    {
        public int usuarioId { get; set; }
        public string nome { get; set; } 
        public double valor { get; set; }
        public DateTime dataReceita { get; set; }

        DaoReceita dao = new DaoReceita();

        public Receita(Usuario u,string n,double v, DateTime data) { 
            this.usuarioId = u.id;
            this.nome = n;
            this.valor = v;
            this.dataReceita = data;

            dao.inserirReceita(this, u);
        }




    }
}
