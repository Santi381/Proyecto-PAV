using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForrajeriaProyecto.Entidades;
using System.Data;

namespace ForrajeriaProyecto.RepositoriosDB
{
    public class ClientesRepositorio
    {
        public List<Cliente> GetClientes()
        {
            var clientes = new List<Cliente>();
            var sentenciaSql = $"SELECT c.*, td.descripcion from Clientes c LEFT JOIN TipoDocumento td ON td.id = c.tipoDocumento where estado='S'";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                var cliente = MapearCliente(fila);
                clientes.Add(cliente);
            }
            return clientes;
        }
        public List<Cliente> GetClientesActivos()
        {
            var clientes = new List<Cliente>();
            var sentenciaSql = $"SELECT * from Clientes WHERE estado = 'S'";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                var cliente = MapearCliente(fila);
                clientes.Add(cliente);
            }
            return clientes;
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

        public List<Cliente> GetClientes(Cliente c, bool mostrarTodos)
        {
            var clientes = new List<Cliente>();
            var sentenciaSql = $"SELECT c.*, td.descripcion FROM Clientes c LEFT JOIN TipoDocumento td ON td.id = c.tipoDocumento WHERE c.nroDocumento like '%{c.NroDocumento}%'";
            if (c.TipoDocumento != null && c.TipoDocumento.Id != 0)
            {
                sentenciaSql += $" and c.tipoDocumento={c.TipoDocumento.Id}";
            }
            if (!mostrarTodos)
            {
                sentenciaSql += $" and c.estado='S'";
            }
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                var cliente = MapearCliente(fila);
                clientes.Add(cliente);
            }
            return clientes;
        }

        public int RegistrarCliente(Cliente c)
        {
            var sentenciaSQL = $"INSERT INTO Clientes (tipoDocumento, nroDocumento, nombre, apellido, telefono, direccion, estado) VALUES( '{c.TipoDocumento.Id}', {c.NroDocumento}, '{c.Nombre}', '{c.Apellido}', '{c.Telefono}','{c.Direccion}','S')";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSQL);
            return filasAfectadas;
        }

        public Cliente GetCliente(long id)
        {
            var cliente = new Cliente();
            var sentenciaSql = $"SELECT c.*, td.descripcion FROM Clientes c LEFT JOIN TipoDocumento td ON c.tipoDocumento = td.id WHERE c.id={id}";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                cliente = MapearCliente(fila);
            }
            return cliente;
        }

        public int ModificarCliente(Cliente c)
        {
            var sentenciaSql = $"UPDATE Clientes SET tipoDocumento='{c.TipoDocumento.Id}', nroDocumento={c.NroDocumento}, nombre='{c.Nombre}', apellido='{c.Apellido}', telefono='{c.Telefono}', direccion='{c.Direccion}' WHERE id={c.Id}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }

        public int DarBajaCliente(Cliente c)
        {
            var estado = c.Estado ? "S" : "N";
            var sentenciaSql = $"UPDATE Clientes SET estado='{estado}' WHERE id={c.Id}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }
    }
}
