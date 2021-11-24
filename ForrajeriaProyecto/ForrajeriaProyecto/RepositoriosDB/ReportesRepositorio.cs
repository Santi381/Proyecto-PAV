using ForrajeriaProyecto.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForrajeriaProyecto.RepositoriosDB
{
    public class ReportesRepositorio
    {
        public DataTable ObtenerVentasFiltros(VentaFiltros filtros)
        {
            var sentenciaSQL = "SELECT v.* FROM Ventas v JOIN Clientes c ON v.id_cliente = c.id WHERE v.NroOrden like '%%'";
            if (filtros.FechaDesde.HasValue)
                sentenciaSQL += $" AND v.fecha >= '{filtros.FechaDesde.Value.ToString("yyyy-MM-dd")}'";
            if (filtros.FechaHasta.HasValue)
                sentenciaSQL += $" AND v.fecha <= '{filtros.FechaHasta.Value.ToString("yyyy-MM-dd")}'";
            if (filtros.IdCliente != 0)
                sentenciaSQL += $" AND v.id_cliente = {filtros.IdCliente}";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSQL);
            return tabla;
        }
        public DataTable ObtenerCliente(VentaFiltros filtros)
        {
            var sentenciaSQL = "SELECT c.id, (c.nombre + ' ' + c.apellido) AS nombre FROM Clientes c WHERE ";
            if (filtros.IdCliente != 0)
                sentenciaSQL += $" c.id = {filtros.IdCliente}";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSQL);
            return tabla;
        }

        public DataTable ObtenerProductos()
        {
            var sentenciaSql = "SELECT dv.id_Producto, SUM(dv.cantidad) AS cantidad FROM DetalleVentas dv GROUP BY dv.id_Producto";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            return tabla;
        }
        public DataTable ObtenerProductosMasVendidos(VentaFiltros filtros)
        {
            var sentenciaSql = "SELECT TOP 3 dv.id_Producto, SUM(dv.cantidad) AS cantidad FROM DetalleVentas dv JOIN Ventas v ON dv.nroOrden = v.NroOrden WHERE v.TipoCobro like '%%'";
            if (filtros.FechaDesde.HasValue)
                sentenciaSql += $" AND v.fecha >= '{filtros.FechaDesde.Value.ToString("yyyy-MM-dd")}'";
            if (filtros.FechaHasta.HasValue)
                sentenciaSql += $" AND v.fecha <= '{filtros.FechaHasta.Value.ToString("yyyy-MM-dd")}' GROUP BY dv.id_Producto";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            return tabla;
        }
        public DataTable ObtenerIngresos(VentaFiltros filtros)
        {
            var sentenciaSql = "SELECT SUM(v.Monto) AS montoIngreso FROM Ventas v WHERE v.TipoCobro like '%%'";
            if (filtros.FechaDesde.HasValue)
                sentenciaSql += $" AND v.fecha >= '{filtros.FechaDesde.Value.ToString("yyyy-MM-dd")}'";
            if (filtros.FechaHasta.HasValue)
                sentenciaSql += $" AND v.fecha <= '{filtros.FechaHasta.Value.ToString("yyyy-MM-dd")}'";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            return tabla;
        }

        public DataTable ObtenerMetodoPago(VentaFiltros filtros)
        {
            var sentenciaSql = "SELECT c.tipoPago AS tipoPago FROM Compras c WHERE c.tipoPago like '%%'";
            if (filtros.FechaDesde.HasValue)
                sentenciaSql += $" AND c.fecha >= '{filtros.FechaDesde.Value.ToString("yyyy-MM-dd")}'";
            if (filtros.FechaHasta.HasValue)
                sentenciaSql += $" AND c.fecha <= '{filtros.FechaHasta.Value.ToString("yyyy-MM-dd")}' GROUP BY c.tipoPago HAVING COUNT(c.tipoPago) >= ALL (SELECT COUNT(cc.tipoPago) FROM Compras cc GROUP BY cc.tipoPago)";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            return tabla;
        }

        public DataTable ObtenerMontoPorCliente()
        {
            var sentenciaSql = "SELECT v.id_cliente, SUM(v.Monto) AS total FROM Ventas v GROUP BY v.id_cliente";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            return tabla;
        }

        public DataTable ObtenerMontoPorCompra()
        {
            var sentenciaSql = "SELECT c.nroOrden, SUM(c.Monto) AS monto FROM Compras c GROUP BY c.nroOrden";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            return tabla;
        }

        public DataTable ObtenerComprasPorProveedores()
        {
            var sentenciaSql = "SELECT c.idProveedor, COUNT(c.Monto) AS cantidad FROM Compras c GROUP BY c.idProveedor";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            return tabla;
        }
        public DataTable ObtenerProveedoresMasComprados(VentaFiltros filtros)
        {
            var sentenciaSql = "SELECT TOP 3 c.idProveedor, COUNT(c.Monto) AS cantidad FROM Compras c WHERE c.tipoPago like '%%' ";
            if (filtros.FechaDesde.HasValue)
                sentenciaSql += $" AND c.fecha >= '{filtros.FechaDesde.Value.ToString("yyyy-MM-dd")}'";
            if (filtros.FechaHasta.HasValue)
                sentenciaSql += $" AND c.fecha <= '{filtros.FechaHasta.Value.ToString("yyyy-MM-dd")}' GROUP BY c.idProveedor";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            return tabla;
        }
        public DataTable ObtenerEgresos(VentaFiltros filtros)
        {
            var sentenciaSql = "SELECT SUM(c.monto) AS montoEgresos FROM Compras c WHERE c.tipoPago like '%%' ";
            if (filtros.FechaDesde.HasValue)
                sentenciaSql += $" AND c.fecha >= '{filtros.FechaDesde.Value.ToString("yyyy-MM-dd")}'";
            if (filtros.FechaHasta.HasValue)
                sentenciaSql += $" AND c.fecha <= '{filtros.FechaHasta.Value.ToString("yyyy-MM-dd")}'";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            return tabla;
        }

        public DataTable ObtenerStockPorProducto()
        {
            var sentenciaSql = "SELECT p.id_producto, p.stock FROM Productos p WHERE p.estado = 'S' GROUP BY p.id_producto, p.stock";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            return tabla;
        }

    }
}
