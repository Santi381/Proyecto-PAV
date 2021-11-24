using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForrajeriaProyecto.Entidades
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public long Stock { get; set; }
        public float Precio { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public Proveedor Proveedor { get; set; }
       
    
        public void ValidarNombre()
        {
            if (string.IsNullOrEmpty(Nombre))
                throw new ApplicationException("El nombre del producto es requerido.");
            if (Nombre.Length > 26)
                throw new ApplicationException("El nombre no debe superar los 25 caracteres.");
        }

        public void ValidarMarca()
        {
            if (string.IsNullOrEmpty(Marca))
                throw new ApplicationException("La marca del producto es requerida.");
            if (Marca.Length > 26)
                throw new ApplicationException("La marca no debe superar los 25 caracteres.");
        }
        //public void ValidarStock()
        //{
        //    if (string.IsNullOrEmpty(Stock.ToString()))
        //        throw new ApplicationException("El stock del producto es requerido.");
        //}
        public void ValidarDescripcion()
        {
            if (string.IsNullOrEmpty(Descripcion))
                throw new ApplicationException("La descripcion del producto es requerida.");
            if (Descripcion.Length > 101)
                throw new ApplicationException("La marca no debe superar los 25 caracteres.");
        }

        //public void ValidarPrecio()
        //{
        //    if (string.IsNullOrEmpty(Precio.ToString()))
        //        throw new ApplicationException("El precio del producto es requerido.");
        //}

    }
}
