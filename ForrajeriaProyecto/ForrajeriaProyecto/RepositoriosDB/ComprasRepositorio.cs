using ForrajeriaProyecto.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForrajeriaProyecto.RepositoriosDB
{
    public class ComprasRepositorio
    {
        public List<Compra> GetCompra(Compra c)
        {
            var compras = new List<Compra>();
            var sentenciaSql = $"SELECT c.*, p.razon_social FROM Compras c JOIN Proveedores p on c.idProveedor = p.id_proveedor";
            if (c.NroOrden != 0)
            {
                sentenciaSql += $" WHERE c.nroOrden = {c.NroOrden}";
            }
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                var compra = MapearCompras(fila);
                compras.Add(compra);
            }
            return compras;
        }
        public Proveedor GetProveedor(long id)
        {
            var proveedor = new Proveedor();
            var sentenciaSql = $"SELECT p.* from Proveedores p WHERE p.id_proveedor = {id}";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow filaAfectada in tablaResultado.Rows)
            {
                proveedor = MapearProveedor(filaAfectada);
            }
            return proveedor;
        }
        private Compra MapearCompras(DataRow fila)
        {
            var compra = new Compra();
            compra.NroOrden = Convert.ToInt32(fila["nroOrden"]);
            compra.Fecha = Convert.ToDateTime(fila["fecha"].ToString());
            compra.Monto = Convert.ToSingle(fila["monto"]);
            compra.TipoPago = fila["tipoPago"].ToString();
            var idBusqueda = Convert.ToInt32(fila["idProveedor"]);
            var proveedor = GetProveedor(idBusqueda);
            compra.Proveedor = proveedor;

            return compra;
        }
        private Proveedor MapearProveedor(DataRow fila)
        {
            var proveedor = new Proveedor();
            proveedor.Id = Convert.ToInt32(fila["id_proveedor"]);
            proveedor.RazonSocial = fila["razon_social"].ToString();

            var estado = fila["estado"].ToString();
            proveedor.Estado = estado == "S";
            return proveedor;
        }
        public List<Compra> GetNroOrden()
        {
            var compras = new List<Compra>();
            var sentenciaSQL = $"SELECT (MAX(c.nroOrden) + 1) AS NroOrden FROM Compras c";
            var resultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSQL);
            foreach (DataRow fila in resultado.Rows)
            {
                var compra = MapearNroOrden(fila);
                compras.Add(compra);
            }
            return compras;
        }
        public Compra GetCompra(long id)
        {
            var compra = new Compra();
            var sentenciaSql = $"SELECT c.*, p.razon_social FROM Compras c JOIN Proveedores p on c.idProveedor = p.id_proveedor WHERE c.nroOrden={id}";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                compra = MapearCompras(fila);
            }
            return compra;
        }
        public List<DetalleCompra> ObtenerDetalles(long id)
        {
            List<DetalleCompra> detalleCompras = new List<DetalleCompra>();
            var SentenciaSql = $"SELECT dc.*, p.descripcion FROM DetalleCompras dc LEFT JOIN Productos p ON p.id_producto = dc.idProducto where dc.nroOrden = {id}";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(SentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                var detalleCompra = MapearDetalleCompras(fila);
                detalleCompras.Add(detalleCompra);
            }
            return detalleCompras;
        }
        private DetalleCompra MapearDetalleCompras(DataRow fila)
        {
            var detalleCompra = new DetalleCompra();
            detalleCompra.Id = Convert.ToInt32(fila["id"]);
            var prod = new Producto();
            prod.Id = Convert.ToInt32(fila["idProducto"]);
            if (fila.Table.Columns.Contains("descripcion"))
                if (!fila.IsNull("descripcion"))
                    prod.Descripcion = fila["descripcion"].ToString();
            detalleCompra.Producto = prod;
            detalleCompra.Cantidad = Convert.ToInt32(fila["cantidad"]);
            detalleCompra.PrecioUnitario = Convert.ToSingle(fila["precioUnitario"]);

            return detalleCompra;
        }
        private Compra MapearNroOrden(DataRow fila)
        {
            var compra = new Compra();
            if (!DBNull.Value.Equals(fila["NroOrden"]))
            {
                compra.NroOrden = Convert.ToInt32(fila["NroOrden"]);
                return compra;
            }
            compra.NroOrden = 1;
            return compra;
        }
        public bool RegistrarCompra(Compra c, List<DetalleCompra> listaDetalles)
        {
            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    var CompraSql = $"INSERT INTO Compras (fecha, monto, tipoPago, idProveedor) VALUES('{c.Fecha}', '{Math.Round(c.Monto, 2).ToString(System.Globalization.CultureInfo.InvariantCulture)}', '{c.TipoPago}', '{c.Proveedor.Id}');";
                    c.NroOrden = DBHelper.GetDBHelper().EjecutarTransaccionSQL(CompraSql);

                    for (int i = 0; i < listaDetalles.Count; i++)
                    {
                        var DetalleSql = $"INSERT INTO DetalleCompras (nroOrden, idProducto, cantidad, precioUnitario) VALUES( '{listaDetalles[i].NroOrden.NroOrden}','{listaDetalles[i].Producto.Id}', '{listaDetalles[i].Cantidad}', '{listaDetalles[i].PrecioUnitario.ToString(System.Globalization.CultureInfo.InvariantCulture)}')";
                        listaDetalles[i].Id = DBHelper.GetDBHelper().EjecutarTransaccionSQL(DetalleSql);
                    }
                    tx.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    throw new ApplicationException("No se pudo registrar la compra");
                }
                finally
                {
                    DBHelper.GetDBHelper().CloseConnection();
                }
            }
        }
    }
}
