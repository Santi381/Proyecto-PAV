using ForrajeriaProyecto.Entidades;
using ForrajeriaProyecto.RepositoriosDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForrajeriaProyecto.Servicios
{
    class VentasServicio
    {
        private VentasRepositorio ventasRepositorio;
        public VentasServicio(VentasRepositorio ventasRepo)
        {
            ventasRepositorio = ventasRepo;
        }
        public VentasServicio()
        {
            ventasRepositorio = new VentasRepositorio();
        }
        public List<Venta> GetNroOrden()
        {
            return ventasRepositorio.GetNroOrden();
        }

        public List<Venta> GetVentas(Venta v)
        {
            return ventasRepositorio.GetVentas(v);
        }
        public Venta GetVenta(long id)
        {
            var venta = ventasRepositorio.GetVenta(id);
            return venta;
        }
        public bool RegistrarVenta (Venta venta, List<DetalleVenta> listaDetalles)
        {
            if (venta == null)
                throw new ApplicationException("Venta requerida");
            if (!listaDetalles.Any())
            {
                throw new ApplicationException("Se deben agregar productos");
            }
            if (venta.Cliente.Id == 0)
            {
                throw new ApplicationException("Se debe seleccionar un cliente");
            }
            if (string.IsNullOrEmpty(venta.TipoCobro))
            {
                throw new ApplicationException("Se debe seleccionar un tipo de cobro");
            }
            var valor = ventasRepositorio.RegistrarVenta(venta, listaDetalles);
            if (valor == true)
                return true;
            return false;
        }

        public List<DetalleVenta> ObtenerDetalles(long id)
        {
            return ventasRepositorio.ObtenerDetalles(id);
        }
    }
}
