using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pouppix
{
    internal class TipoGasto
    {
        public int id { get; set; }
        public string nome { get; set; }
        public override string ToString()
        {
            return nome;
        }
    }
}
