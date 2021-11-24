using ForrajeriaProyecto.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForrajeriaProyecto.RepositoriosDB
{
    class ProveedoresRepositorio
    {
        private Proveedor MapearProveedores(DataRow fila)
        {
            var proveedor = new Proveedor();
            proveedor.Id = Convert.ToInt32(fila["id_proveedor"]);
            proveedor.RazonSocial = fila["razon_social"].ToString();
            var estado = fila["estado"].ToString();
            proveedor.Estado = estado == "S";
            return proveedor;
        }
        public List<Proveedor> GetProveedores()
        {
            var proveedores = new List<Proveedor>();
            var sentenciaSql = $"SELECT * from Proveedores";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                var proveedor = MapearProveedores(fila);
                proveedores.Add(proveedor);
            }
            return proveedores;
        }
        public List<Proveedor> GetProveedoresActivos()
        {
            var proveedores = new List<Proveedor>();
            var sentenciaSql = $"SELECT * from Proveedores WHERE estado = 'S'";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                var proveedor = MapearProveedores(fila);
                proveedores.Add(proveedor);
            }
            return proveedores;
        }

        public List<Proveedor> GetProveedores(Proveedor p, bool mostrarTodos)
        {
            var proveedores = new List<Proveedor>();
            var sentenciaSql = $"SELECT p.* FROM Proveedores p WHERE p.razon_social like '%{p.RazonSocial}%'";
            if (!mostrarTodos)
            {
                sentenciaSql += $" and p.estado='S'";
            }
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                var proveedor = MapearProveedores(fila);
                proveedores.Add(proveedor);
            }
            return proveedores;
        }
        public int RegistrarProveedor(Proveedor p)
        {
            var sentenciaSQL = $"INSERT INTO Proveedores (razon_social, estado) VALUES( '{p.RazonSocial}','S')";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSQL);
            return filasAfectadas;
        }

        public Proveedor GetProveedor(long id)
        {
            var proveedor = new Proveedor();
            var sentenciaSql = $"SELECT p.* FROM Proveedores p WHERE p.id_proveedor={id}";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                proveedor = MapearProveedores(fila);
            }
            return proveedor;
        }
        public int ModificarProveedor(Proveedor p)
        {
            var sentenciaSql = $"UPDATE Proveedores SET razon_social='{p.RazonSocial}' WHERE id_proveedor={p.Id}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }
        public int DarBajaProveedor(Proveedor p)
        {
            var estado = p.Estado ? "S" : "N";
            var sentenciaSql = $"UPDATE Proveedores SET estado='{estado}' WHERE id_proveedor={p.Id}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }
    }
}
