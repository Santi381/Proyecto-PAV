using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForrajeriaProyecto.Entidades
{
    public class Presupuesto
    {
        public int IdPresupuesto { get; set; }
        public DateTime Fecha { get; set; }
        public float Monto { get; set; }
        public Cliente Cliente { get; set; }
    }
}
