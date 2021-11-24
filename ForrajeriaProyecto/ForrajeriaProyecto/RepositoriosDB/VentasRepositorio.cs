using ForrajeriaProyecto.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForrajeriaProyecto.RepositoriosDB
{
    class VentasRepositorio
    {
        private Cliente MapearCliente(DataRow fila)
        {
            var cliente = new Cliente();
            cliente.Id = Convert.ToInt32(fila["id"]);
            var tipoDocumento = new TipoDocumento();
            tipoDocumento.Id = Convert.ToInt32(fila["tipoDocumento"]);
            if (fila.Table.Columns.Contains("descripcion"))
                if (!fila.IsNull("descripcion"))
                    tipoDocumento.Descripcion = fila["descripcion"].ToString();
            cliente.TipoDocumento = tipoDocumento;
            cliente.NroDocumento = fila["nroDocumento"].ToString();
            cliente.Nombre = fila["nombre"].ToString();
            cliente.Apellido = fila["apellido"].ToString();
            cliente.Telefono = fila["telefono"].ToString();
            cliente.Direccion = fila["direccion"].ToString();

            var estado = fila["estado"].ToString();
            cliente.Estado = estado == "S";
            return cliente;
        }

        public Cliente GetCliente(long id)
        {
            var cliente = new Cliente();
            var sentenciaSql = $"SELECT c.* from Clientes c WHERE c.id = {id}";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow filaAfectada in tablaResultado.Rows)
            {
                cliente = MapearCliente(filaAfectada);
            }
            return cliente;
        }
        private Venta MapearVentas(DataRow fila)
        {
            var venta = new Venta();
            venta.NroOrden = Convert.ToInt32(fila["NroOrden"]);
            venta.Fecha = Convert.ToDateTime(fila["fecha"].ToString());
            venta.Monto = Convert.ToSingle(fila["Monto"]);
            venta.TipoCobro = fila["TipoCobro"].ToString();
            var idBusqueda = Convert.ToInt32(fila["id_cliente"]);
            var cliente = GetCliente(idBusqueda);
            venta.Cliente = cliente;

            return venta;
        }
        
        public List<Venta> GetVentas(Venta v)
        {
            var productos = new List<Venta>();
            var sentenciaSql = $"SELECT v.*, c.Nombre FROM Ventas v JOIN Clientes c on v.id_cliente = c.id";
            if (v.NroOrden != 0)
            {
                sentenciaSql += $" WHERE v.NroOrden = {v.NroOrden}";
            }
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                var producto = MapearVentas(fila);
                productos.Add(producto);
            }
            return productos;
        }
        public List<Venta> GetNroOrden()
        {
            var ventas = new List<Venta>();
            var sentenciaSQL = $"SELECT (MAX(v.NroOrden) + 1) AS NroOrden FROM Ventas v";
            var resultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSQL);
            foreach (DataRow fila in resultado.Rows)
            {
                var venta = MapearNroOrden(fila);
                ventas.Add(venta);
            }
            return ventas;
        }
        private Venta MapearNroOrden(DataRow fila)
        {
            var venta = new Venta();
            if (! DBNull.Value.Equals(fila["NroOrden"]))
            {
                venta.NroOrden = Convert.ToInt32(fila["NroOrden"]);
                return venta;
            }
            venta.NroOrden = 1;
            return venta;
        }


        public Venta GetVenta(long id)
        {
            var venta = new Venta();
            var sentenciaSql = $"SELECT v.*, c.nombre, c.apellido FROM Ventas v JOIN Clientes c on v.id_cliente = c.id WHERE v.NroOrden={id}";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                venta = MapearVentas(fila);
            }
            return venta;
        }

        public bool RegistrarVenta(Venta v, List<DetalleVenta> listaDetalles)
        {
            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    var VentaSql = $"INSERT INTO Ventas (fecha, Monto, TipoCobro, id_cliente) VALUES('{v.Fecha}', '{v.Monto.ToString(System.Globalization.CultureInfo.InvariantCulture)}', '{v.TipoCobro}', '{v.Cliente.Id}');";
                    v.NroOrden = DBHelper.GetDBHelper().EjecutarTransaccionSQL(VentaSql);

                    for (int i = 0; i < listaDetalles.Count; i++)
                    {
                        var DetalleSql = $"INSERT INTO DetalleVentas (nroOrden, id_Producto, cantidad, precioUnitario) VALUES( '{listaDetalles[i].NroOrden.NroOrden}','{listaDetalles[i].Producto.Id}', '{listaDetalles[i].Cantidad}', '{listaDetalles[i].PrecioUnitario.ToString(System.Globalization.CultureInfo.InvariantCulture)}')";
                        listaDetalles[i].Id = DBHelper.GetDBHelper().EjecutarTransaccionSQL(DetalleSql);
                    }
                    tx.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    throw new ApplicationException("No se pudo registrar la venta");
                }
                finally
                {
                    DBHelper.GetDBHelper().CloseConnection();
                }
            }
        }

        public List<DetalleVenta> ObtenerDetalles(long id)
        {
            List<DetalleVenta> detalleVentas = new List<DetalleVenta>();
            var SentenciaSql = $"SELECT dv.*, p.nombre FROM DetalleVentas dv LEFT JOIN Productos p ON p.id_producto = dv.Id_Producto where dv.nroOrden = {id}";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(SentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                var detalleVenta = MapearDetalleVenta(fila);
                detalleVentas.Add(detalleVenta);
            }
            return detalleVentas;
        }

        private DetalleVenta MapearDetalleVenta(DataRow fila)
        {
            var detalleVenta = new DetalleVenta();
            detalleVenta.Id = Convert.ToInt32(fila["Id"]);
            var prod = new Producto();
            prod.Id = Convert.ToInt32(fila["Id_Producto"]);
            if (fila.Table.Columns.Contains("nombre"))
                if (!fila.IsNull("nombre"))
                    prod.Nombre = fila["nombre"].ToString();
            detalleVenta.Producto = prod;
            detalleVenta.Cantidad = Convert.ToInt32(fila["Cantidad"]);
            detalleVenta.PrecioUnitario = Convert.ToSingle(fila["PrecioUnitario"]);

            return detalleVenta;
        }
    }
}