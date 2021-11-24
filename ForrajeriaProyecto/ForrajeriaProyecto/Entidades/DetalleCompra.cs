using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForrajeriaProyecto.Entidades
{
    public class DetalleCompra
    {
        public int Id { get; set; }
        public Compra NroOrden { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public float PrecioUnitario { get; set; }
    }
}
