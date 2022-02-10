using ForrajeriaProyecto.Entidades;
using ForrajeriaProyecto.RepositoriosDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForrajeriaProyecto.Servicios
{
    public class ComprasServicio
    {
        private ComprasRepositorio comprasRepositorio;
        public ComprasServicio(ComprasRepositorio comprasRepo)
        {
            comprasRepositorio = comprasRepo;
        }

        public ComprasServicio()
        {
            comprasRepositorio = new ComprasRepositorio();
        }
        public List<Compra> GetCompra(Compra v)
        {
            return comprasRepositorio.GetCompra(v);
        }
        public Compra GetCompra(long id)
        {
            var compra = comprasRepositorio.GetCompra(id);
            return compra;
        }
        public List<Compra> GetNroOrden()
        {
            return comprasRepositorio.GetNroOrden();
        }
        public bool RegistrarCompra(Compra compra, List<DetalleCompra> listaDetalles)
        {
            if (compra == null)
                throw new ApplicationException("Compra requerida");
            if (!listaDetalles.Any())
            {
                throw new ApplicationException("Se deben agregar productos");
            }
            if (string.IsNullOrEmpty(compra.TipoPago))
            {
                throw new ApplicationException("Se debe seleccionar un tipo de pago");
            }
            var valor = comprasRepositorio.RegistrarCompra(compra, listaDetalles);
            if (valor == true)
                return true;
            return false;
        }
        public List<DetalleCompra> ObtenerDetalles(long id)
        {
            return comprasRepositorio.ObtenerDetalles(id);
        }
    }
}
