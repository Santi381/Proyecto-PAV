using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForrajeriaProyecto.Entidades;
using ForrajeriaProyecto.RepositoriosDB;

namespace ForrajeriaProyecto.Servicios
{
    public class TiposDocumentoServicio
    {
        private TiposDocumentoRepositorio tiposDocumentoRepositorio;

        public TiposDocumentoServicio()
        {
            tiposDocumentoRepositorio = new TiposDocumentoRepositorio();
        }

        public List<TipoDocumento> GetTiposDocumento()
        {
            return tiposDocumentoRepositorio.GetTiposDocumento();
        }
    }
}
