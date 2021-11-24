using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForrajeriaProyecto.RepositoriosDB;
using ForrajeriaProyecto.Entidades;

namespace ForrajeriaProyecto.Servicios
{
    public class PresupuestosServicio
    {
        private PresupuestosRepositorio presupuestosRepositorio;
        public PresupuestosServicio(PresupuestosRepositorio presupuestosRepo)
        {
            presupuestosRepositorio = presupuestosRepo;
        }

        public PresupuestosServicio()
        {
            presupuestosRepositorio = new PresupuestosRepositorio();
        }

        public List<Presupuesto> GetPresupuestos(Presupuesto p)
        {
            return presupuestosRepositorio.GetPresupuestos(p);
        }

        public Presupuesto GetPresupuesto(long id)
        {
            return presupuestosRepositorio.GetPresupuesto(id);
        }

        public List<Presupuesto> GetPresupuestos()
        {
            return presupuestosRepositorio.GetPresupuestos();
        }

        public List<DetallePresupuesto> GetDetalles(long id)
        {
            return presupuestosRepositorio.GetDetalles(id);
        }

        public List<Presupuesto> GetNroPresupuesto()
        {
            return presupuestosRepositorio.GetNroPresupuesto();
        }

        public bool RegistrarPresupuesto(Presupuesto presupuesto, List<DetallePresupuesto> listaDetalles)
        {
            if (presupuesto == null)
                throw new ApplicationException("Presupuesto requerido");
            /*if (presupuesto.Cliente.Id == 0)
            {
                throw new ApplicationException("Se debe seleccionar un cliente");
            }*/
            if (!listaDetalles.Any())
            {
                throw new ApplicationException("Se deben agregar productos");
            }
            var valor = presupuestosRepositorio.RegistrarPresupuesto(presupuesto, listaDetalles);
            if (valor == true)
                return true;
            return false;
        }
    }
}
