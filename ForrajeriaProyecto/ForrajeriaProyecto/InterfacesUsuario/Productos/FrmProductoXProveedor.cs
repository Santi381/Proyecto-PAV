using ForrajeriaProyecto.Entidades;
using ForrajeriaProyecto.InterfacesUsuario.Compras;
using ForrajeriaProyecto.InterfacesUsuario.Ventas;
using ForrajeriaProyecto.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForrajeriaProyecto.InterfacesUsuario.Productos
{
    public partial class FrmProductoXProveedor : Form
    {
        private ProductosServicio productosServicio;
        private ProveedoresServicio proveedoresServicio;
        private int idProv;
        public FrmProductoXProveedor(int idProveedor)
        {
            productosServicio = new ProductosServicio();
            proveedoresServicio = new ProveedoresServicio();
            this.idProv = idProveedor;
            InitializeComponent();
        }
        private void ConsultarProductos()
        {
            var prov = new Proveedor();
            prov.Id = idProv;
            var productoFiltros = new Producto();
            productoFiltros.Proveedor = prov;
            var productos = productosServicio.GetProductosXProveedor(productoFiltros);
            DgvProductos.Rows.Clear();

            foreach (var producto in productos)
            {
                var prodPrecio = Math.Round((Convert.ToSingle(producto.Precio) - (Convert.ToSingle(producto.Precio) * 0.21)),2);
                var descripcionEstado = producto.Estado ? "Activo" : "Inactivo";
                var fila = new string[]
                {
                    producto.Id.ToString(),
                    producto.Nombre,
                    producto.Marca,
                    producto.Stock.ToString(),
                    prodPrecio.ToString(System.Globalization.CultureInfo.InvariantCulture),
                    producto.Descripcion,
                    descripcionEstado,
                    producto.Proveedor.RazonSocial
                };
                DgvProductos.Rows.Add(fila);
            }
        }

        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = DgvProductos.CurrentRow;
            string idProducto = Convert.ToString(row.Cells["IDProducto"].Value);
            FrmAgregarCompra frmAgregarCompra = Owner as FrmAgregarCompra;
            frmAgregarCompra.TxtIDProducto.Text = idProducto;
            this.Close();
        }

        private void FrmProductoXProveedor_Load(object sender, EventArgs e)
        {
            ConsultarProductos();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            CerrarFormulario();
        }
        private void CerrarFormulario()
        {
            this.Dispose();
        }

        private void BtnConsultarProducto_Click(object sender, EventArgs e)
        {
            ConsultarProductos();
        }
    }
}
