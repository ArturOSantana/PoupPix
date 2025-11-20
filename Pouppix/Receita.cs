using System;
using System.Collections.Generic;
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

        DaoReceita receita = new DaoReceita();

       


    }
}
