using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForrajeriaProyecto.Entidades
{
    public class Cliente
    {
        public int Id { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public string NroDocumento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public bool Estado { get; set; }


        public void ValidarNroDocumento()
        {
            if (string.IsNullOrEmpty(NroDocumento))
                throw new ApplicationException("El DNI del cliente es requerido.");
        }
        public void ValidarNombre()
        {
            if (string.IsNullOrEmpty(Nombre))
                throw new ApplicationException("El nombre del cliente es requerido.");
            if (Nombre.Length > 21)
                throw new ApplicationException("El nombre no debe superar los 50 caracteres.");
        }

        public void ValidarApellido()
        {
            if (string.IsNullOrEmpty(Apellido))
                throw new ApplicationException("El apellido del cliente es requerido.");
            if (Apellido.Length > 21)
                throw new ApplicationException("El apellido no debe superar los 50 caracteres.");
        }

        public void ValidarTelefono()
        {
            if (string.IsNullOrEmpty(Telefono))
                throw new ApplicationException("El teléfono del cliente es requerido.");
            if (Telefono.Length > 21)
                throw new ApplicationException("El teléfono no debe superar los 15 caracteres.");
        }

        public void ValidarDireccion()
        {
            if (string.IsNullOrEmpty(Direccion))
                throw new ApplicationException("El dirección de cliente es requerido.");
            if (Direccion.Length > 101)
                throw new ApplicationException("El dirección no debe superar los 50 caracteres.");
        }
        public string FullName => $"{Nombre} {Apellido}";
    }
}
