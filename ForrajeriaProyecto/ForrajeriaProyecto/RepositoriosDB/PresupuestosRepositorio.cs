using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForrajeriaProyecto.Entidades;
using System.Data;


namespace ForrajeriaProyecto.RepositoriosDB
{
    public class PresupuestosRepositorio
    {
        public List<Presupuesto> GetPresupuestos(Presupuesto p)
        {
            var presupuestos = new List<Presupuesto>();
            var sentenciaSql = $"SELECT p.* from Presupuestos p JOIN Clientes c on p.idCliente = c.id WHERE c.Nombre = '{p.Cliente.Nombre}' and c.Apellido = '{p.Cliente.Apellido}'";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                var presupuesto = MapearPresupuesto(fila);
                presupuestos.Add(presupuesto);
            }
            return presupuestos;
        }

        public List<Presupuesto> GetPresupuestos()
        {
            var presupuestos = new List<Presupuesto>();
            var sentenciaSql = $"SELECT p.*, c.Nombre from Presupuestos p JOIN Clientes c on p.idCliente = c.id";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                var presupuesto = MapearPresupuesto(fila);
                presupuestos.Add(presupuesto);
            }
            return presupuestos;
        }

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

        private Presupuesto MapearPresupuesto(DataRow fila)
        {
            var presupuesto = new Presupuesto();
            presupuesto.IdPresupuesto = Convert.ToInt32(fila["id"]);
            presupuesto.Fecha = Convert.ToDateTime(fila["fecha"].ToString());
            presupuesto.Monto = Convert.ToSingle(fila["monto"]);
            var idBusqueda = Convert.ToInt32(fila["idCliente"]);
            var cliente = GetCliente(idBusqueda);
            presupuesto.Cliente = cliente;
            return presupuesto;
        }

        public Presupuesto GetPresupuesto(long id)
        {
            Presupuesto presupuesto = new Presupuesto();
            var sentenciaSql = $"SELECT p.*, c.nombre, c.apellido FROM Presupuestos p JOIN Clientes c on p.idCliente = c.id WHERE p.id={id}";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                presupuesto = MapearPresupuesto(fila);
            }
            return presupuesto;

        }

        public List<DetallePresupuesto> GetDetalles(long id)
        {
            List<DetallePresupuesto> detallePresupuestos = new List<DetallePresupuesto>();
            var SentenciaSql = $"SELECT dp.*, p.nombre FROM DetallePresupuestos dp LEFT JOIN Productos p ON p.id_producto = dp.idProducto where dp.idPresupuesto = {id}";
            var tabla = DBHelper.GetDBHelper().ConsultaSQL(SentenciaSql);
            foreach (DataRow fila in tabla.Rows)
            {
                var detallePresupuesto = MapearDetallePresupuesto(fila);
                detallePresupuestos.Add(detallePresupuesto);
            }
            return detallePresupuestos;
        }

        private DetallePresupuesto MapearDetallePresupuesto(DataRow fila)
        {
            var detallePresupuesto = new DetallePresupuesto();
            detallePresupuesto.Id = Convert.ToInt32(fila["id"]);
            var prod = new Producto();
            prod.Id = Convert.ToInt32(fila["idProducto"]);
            if (fila.Table.Columns.Contains("nombre"))
                if (!fila.IsNull("nombre"))
                    prod.Nombre = fila["nombre"].ToString();
            detallePresupuesto.Producto = prod;
            detallePresupuesto.Cantidad = Convert.ToInt32(fila["Cantidad"]);
            detallePresupuesto.PrecioUnitario = Convert.ToSingle(fila["PrecioUnitario"]);

            return detallePresupuesto;
        }

        public List<Presupuesto> GetNroPresupuesto()
        {
            var presupuestos = new List<Presupuesto>();
            var sentenciaSQL = $"SELECT (MAX(P.id) + 1) AS 'id' FROM Presupuestos p";
            var resultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSQL);
            foreach (DataRow fila in resultado.Rows)
            {
                var presupuesto = MapearNroPresupuesto(fila);
                presupuestos.Add(presupuesto);
            }
            return presupuestos;
        }

        public bool RegistrarPresupuesto(Presupuesto presupuesto, List<DetallePresupuesto> listaDetalles)
        {
            using (var tx = DBHelper.GetDBHelper().IniciarTransaccion())
            {
                try
                {
                    var PresupuestoSql = $"INSERT INTO Presupuestos (fecha, Monto, idCliente) VALUES('{presupuesto.Fecha}', '{presupuesto.Monto.ToString(System.Globalization.CultureInfo.InvariantCulture)}', '{presupuesto.Cliente.Id}');";
                    presupuesto.IdPresupuesto = DBHelper.GetDBHelper().EjecutarTransaccionSQL(PresupuestoSql);

                    for (int i = 0; i < listaDetalles.Count; i++)
                    {
                        var DetalleSql = $"INSERT INTO DetallePresupuestos (idPresupuesto, idProducto, cantidad, precioUnitario) VALUES( '{listaDetalles[i].IdPresupuesto.IdPresupuesto}','{listaDetalles[i].Producto.Id}', '{listaDetalles[i].Cantidad}', '{listaDetalles[i].PrecioUnitario.ToString(System.Globalization.CultureInfo.InvariantCulture)}')";
                        listaDetalles[i].Id = DBHelper.GetDBHelper().EjecutarTransaccionSQL(DetalleSql);
                    }
                    tx.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    throw new ApplicationException("No se pudo registrar el presupuesto");
                }
                finally
                {
                    DBHelper.GetDBHelper().CloseConnection();
                }
            }
        }

        public Presupuesto MapearNroPresupuesto(DataRow fila)
        {
            var presupuesto = new Presupuesto();
            if (!DBNull.Value.Equals(fila["id"]))
            {
                presupuesto.IdPresupuesto = Convert.ToInt32(fila["id"]);
                return presupuesto;
            }
            presupuesto.IdPresupuesto = 1;
            return presupuesto;
        }
    }
}
