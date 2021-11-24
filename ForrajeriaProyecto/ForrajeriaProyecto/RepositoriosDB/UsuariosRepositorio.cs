using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForrajeriaProyecto.Entidades;
using System.Data;

namespace ForrajeriaProyecto.RepositoriosDB
{
    public class UsuariosRepositorio
    {
        public Usuario LoginBD(Usuario usuarioIngresado)
        {
            Usuario usuarioResultado = null;
            var sentenciaSql = $"SELECT * FROM Usuarios where usuario='{usuarioIngresado.NombreUsuario}'and password='{usuarioIngresado.Contrasenia}'";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            if (tablaResultado.Rows.Count == 1)
            {
                var row = tablaResultado.Rows[0];
                usuarioResultado = new Usuario();
                usuarioResultado.NombreUsuario = row["usuario"].ToString();
                usuarioResultado.Id = Convert.ToInt32(row["id_usuario"]);
            }
            return usuarioResultado;
        }

        public Usuario GetUsuario(object id)
        {
            var usuario = new Usuario();
            var sentenciaSql = $"SELECT u.* FROM Usuarios u WHERE u.id_usuario={id}";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                usuario = MapearUsuario(fila);
            }
            return usuario;
        }

        public List<Usuario> GetUsuarios(Usuario u, bool mostrartodos)
        {   
            var usuarios = new List<Usuario>();
            var sentenciaSql = $"SELECT u.* FROM Usuarios u WHERE u.usuario like '%%' ";
            if (u.Id != 0 )
            {
                sentenciaSql += $" and u.id_usuario = {u.Id}";
            }
            if (!mostrartodos)
            {
                sentenciaSql += $" and u.estado ='S'";
            }
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                var usuario = MapearUsuario(fila);
                usuarios.Add(usuario);
            }
            
            return usuarios;

        }

        public int ModificarUsuario(Usuario u)
        {
            var sentenciaSql = $"UPDATE Usuarios SET usuario='{u.NombreUsuario}', password='{u.Contrasenia}' WHERE id_usuario={u.Id}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }

        public int RegistrarUsuario(Usuario u)
        {
            var sentenciaSQL = $"INSERT INTO Usuarios (id_usuario,usuario, password, estado) VALUES((select max (u.id_usuario) from Usuarios u)+1,'{u.NombreUsuario}', '{u.Contrasenia}', 'S')";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSQL);
            return filasAfectadas;
        }

        private Usuario MapearUsuario(DataRow fila)
        {
            var usuario = new Usuario();
            usuario.Id = Convert.ToInt32(fila["id_usuario"]);
            usuario.NombreUsuario = fila["usuario"].ToString();
            var estado = fila["estado"].ToString();
            usuario.Estado = estado == "S";
            usuario.Contrasenia = fila["password"].ToString();
            return usuario;
        }
        public int DarBajaUsuario(Usuario u)
        {
            var estado = u.Estado ? "S" : "N";
            var sentenciaSql = $"UPDATE Usuarios SET estado='{estado}' WHERE id_usuario={u.Id}";
            var filasAfectadas = DBHelper.GetDBHelper().EjecutarSQL(sentenciaSql);
            return filasAfectadas;
        }
    }
}
