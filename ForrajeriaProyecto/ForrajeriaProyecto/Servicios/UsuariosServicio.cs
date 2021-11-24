using ForrajeriaProyecto.Entidades;
using ForrajeriaProyecto.RepositoriosDB;
using System;
using System.Collections.Generic;

namespace ForrajeriaProyecto.Servicios
{
    public class UsuariosServicio
    {
        private UsuariosRepositorio usuariosRepositorio;
        public static Usuario UsuarioLogueado;

        public UsuariosServicio(UsuariosRepositorio usuariosRepo)
        {
            usuariosRepositorio = usuariosRepo;
        }
        public UsuariosServicio()
        {
            usuariosRepositorio = new UsuariosRepositorio();
        }

        public Usuario Login(Usuario usuarioIngresado)
        {
            var usuario = usuariosRepositorio.LoginBD(usuarioIngresado);
            UsuarioLogueado = usuario;
            return UsuarioLogueado;
        }

        public Usuario GetUsuario(object id)
        {
            var usuario = usuariosRepositorio.GetUsuario(id);
            return usuario;
        }

        public List<Usuario> GetUsuarios(Usuario u,bool mostrartodos)
        {
            return usuariosRepositorio.GetUsuarios(u, mostrartodos);
        }

        public void ValidarUsuario(Usuario usuario)
        {
            usuario.ValidarNombre();
            usuario.ValidarContrasenia();
        }

        public bool RegistrarUsuario(Usuario usuario)
        {
            if (usuario == null)
                throw new ApplicationException("Usuario requerido");
            var filasAfectadas = usuariosRepositorio.RegistrarUsuario(usuario);
            if (filasAfectadas == 1)
                return true;
            return false;
        }

        public void ModificarUsuario(Usuario usuario)
        {
            var filasAfectadas = usuariosRepositorio.ModificarUsuario(usuario);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al actualizar");
        }
        public void DarBajaUsuario(Usuario u)
        {
            var filasAfectadas = usuariosRepositorio.DarBajaUsuario(u);
            if (filasAfectadas != 1)
                throw new ApplicationException("Hubo un problema al dar de baja al usuario");
        }
    }
}
