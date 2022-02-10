using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ForrajeriaProyecto.InterfacesUsuario.Presupuestos;
using ForrajeriaProyecto.Servicios;
using ForrajeriaProyecto.Entidades;
using System.Runtime.InteropServices;

namespace ForrajeriaProyecto.InterfacesUsuario.Productos
{
    public partial class FrmConsultarProductoPresupuesto : Form
    {
        private ProductosServicio productosServicio;
        private ProveedoresServicio proveedoresServicio;
        public FrmConsultarProductoPresupuesto()
        {
            InitializeComponent();
            productosServicio = new ProductosServicio();
            proveedoresServicio = new ProveedoresServicio();
        }

        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = DgvProductos.CurrentRow;
            string idProducto = Convert.ToString(row.Cells["IDProducto"].Value);
            FrmAgregarPresupuesto frmAgregarPresupuesto = Owner as FrmAgregarPresupuesto;
            frmAgregarPresupuesto.TxtIDProducto.Text = idProducto;
            this.Close();
        }

        private void BtnConsultarProducto_Click(object sender, EventArgs e)
        {
            ConsultarProductos();
        }

        private void ConsultarProductos()
        {

            var productoFiltros = new Producto();
            productoFiltros.Nombre = TxtNombreProducto.Text.Trim();
            var mostrarTodos = CkMostrarTodos.Checked;
            var productos = productosServicio.GetProductos(productoFiltros, mostrarTodos);
            DgvProductos.Rows.Clear();

            foreach (var producto in productos)
            {
                var descripcionEstado = producto.Estado ? "Activo" : "Inactivo";
                var fila = new string[]
                {
                    producto.Id.ToString(),
                    producto.Nombre,
                    producto.Marca,
                    producto.Stock.ToString(),
                    producto.Precio.ToString(System.Globalization.CultureInfo.InvariantCulture),
                    producto.Descripcion,
                    descripcionEstado,
                    producto.Proveedor.RazonSocial
                };
                DgvProductos.Rows.Add(fila);
            }
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnSalirBarra_Click(object sender, EventArgs e)
        {
            CerrarFormulario();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            CerrarFormulario();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void PanelHorizontal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CerrarFormulario()
        {
            this.Dispose();
        }

        private void FrmConsultarProductoPresupuesto_Load(object sender, EventArgs e)
        {
            ConsultarProductos();
        }
    }
}
