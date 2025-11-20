using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pouppix
{
    internal class Gastos
    {
        DaoGastos dao = new DaoGastos();

        public int usuarioId { get; set; }
        public double valor { get; set; }
        public int tipo { get; set; }
        public DateTime data { get; set; }
        public string descricao { get; set; }

        public Gastos(Usuario u,double valor,int tipo,DateTime data,string descricao) {
            this.usuarioId = u.id;
            this.valor = valor;
            this.tipo = tipo;
            this.data = data;
            this.descricao = descricao;

            dao.adicionarGasto(this);

        }
    }
}
