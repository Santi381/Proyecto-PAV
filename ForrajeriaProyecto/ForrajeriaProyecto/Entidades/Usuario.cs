using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForrajeriaProyecto.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Contrasenia { get; set; }
        public string NombreUsuario { get; set; }
        public bool Estado { get; set; }

        internal void ValidarNombre()
        {
            if (string.IsNullOrEmpty(NombreUsuario))
                throw new ApplicationException("El nombre del usuario es requerido.");
            if (NombreUsuario.Length > 21)
                throw new ApplicationException("El nombre no debe superar los 20 caracteres.");
        }

        internal void ValidarContrasenia()
        {
            if (string.IsNullOrEmpty(Contrasenia))
                throw new ApplicationException("La contraseña del usuario es requerida.");
            if (Contrasenia.Length > 21)
                throw new ApplicationException("El nombre no debe superar los 20 caracteres.");
        }
    }
}

