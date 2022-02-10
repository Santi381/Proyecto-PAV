using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForrajeriaProyecto.RepositoriosDB;
using ForrajeriaProyecto.Entidades;

namespace ForrajeriaProyecto.Servicios
{
    class ProductosServicio
    {
        private ProductosRepositorio productosRepositorio;
        public ProductosServicio(ProductosRepositorio productosRepo)
        {
            productosRepositorio = productosRepo;
        }

        public ProductosServicio()
        {
            productosRepositorio = new ProductosRepositorio();
        }

        public List<Producto> GetProductos()
        {
            return productosRepositorio.GetProductos();
        }
        public List<Producto> GetProductosXProveedor(Producto p)
        {
            return productosRepositorio.GetProductosXProveedor(p);
        }
        public List<Producto> GetProductos(Producto p, bool mostrarTodos)
        {
            return productosRepositorio.GetProductos(p, mostrarTodos);
        }

        public bool RegistrarProducto(Producto producto)
        {
            if (producto == null)
                throw new ApplicationException("Producto requerido");
            var filasAfectadas = productosRepositorio.RegistrarProducto(producto);
            if (filasAfectadas == 1)
                return true;
            return false;
        }
        public void ValidarProducto(Producto p)
        {
            p.ValidarNombre();
            p.ValidarMarca();
            //p.ValidarStock();
            //p.ValidarPrecio();
            p.ValidarDescripcion();
        }
        public Producto GetProducto(long id)
        {
            var producto = productosRepositorio.GetProducto(id);
            return producto;
        }
        public void ModificarProducto(Producto p)
        {
            var filasAfectadas = productosRepositorio.ModificarProducto(p);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al actualizar");
        }
        public void DarBajaProducto(Producto p)
        {
            var filasAfectadas = productosRepositorio.DarBajaProducto(p);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al dar de baja el producto");
        }

        public void RestarStock(int id, int cantidad)
        {
            var producto = productosRepositorio.GetProducto(id);
            int stockActual = Convert.ToInt32(producto.Stock);
            var filasAfectadas = productosRepositorio.DescontarStock(id, cantidad, stockActual);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al descontar el stock");
        }
        public void ReponerStock(int idProd, int cantidad)
        {
            var filasAfectadas = productosRepositorio.ReponerStock(idProd, cantidad);
            if (filasAfectadas != 1)
            {
                throw new ApplicationException("Hubo un problema al reponer el stock");
            }
        }
        public void SumarStock(int id, int cantidad)
        {
            var producto = productosRepositorio.GetProducto(id);
            var filasAfectadas = productosRepositorio.SumarStock(id, cantidad);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al sumar el stock");
        }
    }
}
