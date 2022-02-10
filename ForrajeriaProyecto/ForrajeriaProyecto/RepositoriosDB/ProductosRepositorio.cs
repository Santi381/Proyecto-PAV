using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ForrajeriaProyecto.Entidades;


namespace ForrajeriaProyecto.RepositoriosDB
{
    class ProductosRepositorio
    {
        private Producto MapearProductos(DataRow fila)
        {
            var producto = new Producto();
            producto.Id = Convert.ToInt32(fila["id_producto"]);
            producto.Nombre = fila["nombre"].ToString();
            producto.Marca = fila["marca"].ToString();
            producto.Stock = Convert.ToInt32(fila["stock"]);
            producto.Precio = Convert.ToSingle(fila["precio"]);
            producto.Descripcion = fila["descripcion"].ToString();
            var estado = fila["estado"].ToString();
            producto.Estado = estado == "S";
            var idProveedor = new Proveedor();
            idProveedor.Id = Convert.ToInt32(fila["id_Proveedor"]);
            if (fila.Table.Columns.Contains("razon_social"))
                if (!fila.IsNull("razon_social"))
                    idProveedor.RazonSocial = fila["razon_social"].ToString();
            producto.Proveedor = idProveedor;
            return producto;
        }

        public List<Producto> GetProductos()
        {
            var productos = new List<Producto>();
            var sentenciaSql = $"SELECT * from Productos";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                var producto = MapearProductos(fila);
                productos.Add(producto);
            }
            return productos;
        }
        public List<Producto> GetProductosXProveedor(Producto p)
        {
            var productos = new List<Producto>();
            var sentenciaSql = $"SELECT p.*, pr.razon_social FROM Productos p JOIN Proveedores pr on ('{p.Proveedor.Id}' = pr.id_proveedor) WHERE p.id_Proveedor = '{p.Proveedor.Id}' and p.estado='S'";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                var producto = MapearProductos(fila);
                productos.Add(producto);
            }
            return productos;
        }

        public List<Producto> GetProductos(Producto p, bool mostrarTodos)
        {
            var productos = new List<Producto>();
            var sentenciaSql = $"SELECT p.*, pr.razon_social FROM Productos p JOIN Proveedores pr on (p.id_Proveedor = pr.id_proveedor) WHERE p.nombre like '%{p.Nombre}%'";
            if (!mostrarTodos)
            {
                sentenciaSql += $" and p.estado='S' and p.stock > 0";
            }
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                var producto = MapearProductos(fila);
                productos.Add(producto);
            }
            return productos;
        }

        public int RegistrarProducto(Producto p)
        {
            var sentenciaSQL = $"INSERT INTO Productos (nombre, marca, stock, precio, descripcion, estado, id_Proveedor) VALUES('{p.Nombre}', '{p.Marca}', {p.Stock}, {Math.Round(p.Precio, 2).ToString(System.Globalization.CultureInfo.InvariantCulture)},'{p.Descripcion}','S','{p.Proveedor.Id}')";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSQL);
            return filasAfectadas;
        }
        public Producto GetProducto(long id)
        {
            var producto = new Producto();
            var sentenciaSql = $"SELECT p.* FROM Productos p WHERE p.id_producto={id}";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                producto = MapearProductos(fila);
            }
            return producto;
        }
        public int ModificarProducto(Producto p)
        {
            var sentenciaSql = $"UPDATE Productos SET nombre='{p.Nombre}', marca='{p.Marca}', stock='{p.Stock}', precio={Math.Round(p.Precio, 2).ToString("0.00", System.Globalization.CultureInfo.InvariantCulture)}, descripcion='{p.Descripcion}', id_Proveedor='{p.Proveedor.Id}' WHERE id_producto={p.Id}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }
        public int DarBajaProducto(Producto p)
        {
            var estado = p.Estado ? "S" : "N";
            var sentenciaSql = $"UPDATE Productos SET estado='{estado}' WHERE id_producto={p.Id}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }

        public int DescontarStock(int id, int cantidad, int stockActual)
        {
            int stockNuevo = stockActual - cantidad;
            var sentenciaSql = $"UPDATE Productos SET stock='{stockNuevo}' WHERE id_producto={id}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }
        public int ReponerStock(int id, int cantidad)
        {
            var sentenciaSql = $"UPDATE Productos SET stock +='{cantidad}' WHERE id_producto='{id}'";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }
        public int SumarStock(int id, int cantidad)
        {
            var sentenciaSql = $"UPDATE Productos SET stock +='{cantidad}' WHERE id_producto={id}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }
    }
}
