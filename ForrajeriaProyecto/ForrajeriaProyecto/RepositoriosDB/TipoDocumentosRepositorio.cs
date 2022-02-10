using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForrajeriaProyecto.Entidades;


namespace ForrajeriaProyecto.RepositoriosDB
{
    public class TiposDocumentoRepositorio
    {
        public List<TipoDocumento> GetTiposDocumento()
        {
            var tiposDocumento = new List<TipoDocumento>();
            var sentenciaSql = $"SELECT * from TipoDocumento";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            foreach (DataRow fila in tablaResultado.Rows)
            {
                var tipoDocumento = new TipoDocumento();
                tipoDocumento.Id = Convert.ToInt32(fila["id"]);
                tipoDocumento.Descripcion = fila["descripcion"].ToString();
                tiposDocumento.Add(tipoDocumento);
            }
            return tiposDocumento;
        }
    }
}
