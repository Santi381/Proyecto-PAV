using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForrajeriaProyecto.Entidades
{
    public class Compra
    {
        public int NroOrden { get; set; }
        public DateTime Fecha { get; set; }
        public float Monto { get; set; }
        public string TipoPago { get; set; }
        public Proveedor Proveedor { get; set; }
    }
}
