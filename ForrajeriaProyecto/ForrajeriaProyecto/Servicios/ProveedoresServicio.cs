using ForrajeriaProyecto.Entidades;
using ForrajeriaProyecto.RepositoriosDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForrajeriaProyecto.Servicios
{
    class ProveedoresServicio
    {
        private ProveedoresRepositorio proveedoresRepositorio;
        public ProveedoresServicio(ProveedoresRepositorio proveedoresRepo)
        {
            proveedoresRepositorio = proveedoresRepo;
        }

        public ProveedoresServicio()
        {
            proveedoresRepositorio = new ProveedoresRepositorio();
        }

        public List<Proveedor> GetProveedores()
        {
            return proveedoresRepositorio.GetProveedores();
        }
        public List<Proveedor> GetProveedoresActivos()
        {
            return proveedoresRepositorio.GetProveedoresActivos();
        }
        public List<Proveedor> GetProveedores(Proveedor p, bool mostrarTodos)
        {
            return proveedoresRepositorio.GetProveedores(p, mostrarTodos);
        }
        public void ValidarProveedor(Proveedor proveedor)
        {
            proveedor.ValidarRazonSocial();
        }
        public bool RegistrarProveedor(Proveedor proveedor)
        {
            if (proveedor == null)
                throw new ApplicationException("Cliente requerido");
            var filasAfectadas = proveedoresRepositorio.RegistrarProveedor(proveedor);
            if (filasAfectadas == 1)
                return true;
            return false;
        }

        public Proveedor GetProveedor(long id)
        {
            var proveedor = proveedoresRepositorio.GetProveedor(id);
            return proveedor;
        }
        public void ModificarProveedor(Proveedor p)
        {
            var filasAfectadas = proveedoresRepositorio.ModificarProveedor(p);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al actualizar");
        }
        public void DarBajaProveedor(Proveedor p)
        {
            var filasAfectadas = proveedoresRepositorio.DarBajaProveedor(p);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al dar de baja al proveedor");
        }
    }

}
