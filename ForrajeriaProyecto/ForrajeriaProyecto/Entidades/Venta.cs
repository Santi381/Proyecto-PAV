using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForrajeriaProyecto.Entidades;

namespace ForrajeriaProyecto.Entidades
{
    public class Venta
    {
        public int NroOrden { get; set; }
        public DateTime Fecha { get; set; }
        public float Monto { get; set; }
        public string TipoCobro { get; set; }
        public Cliente Cliente { get; set; }
        
    }
}
