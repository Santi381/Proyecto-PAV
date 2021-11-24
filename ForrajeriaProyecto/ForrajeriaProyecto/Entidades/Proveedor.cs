using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForrajeriaProyecto.Entidades
{
    public class Proveedor
    {
        public int Id { get; set; }
        public string RazonSocial { get; set; }
        public bool Estado { get; set; }

        public void ValidarRazonSocial()
        {
            if (string.IsNullOrEmpty(RazonSocial))
                throw new ApplicationException("La razón social del proveedor es requerida.");
            if (RazonSocial.Length > 50)
                throw new ApplicationException("La razón social no debe superar los 50 caracteres.");
        }
    }
}
