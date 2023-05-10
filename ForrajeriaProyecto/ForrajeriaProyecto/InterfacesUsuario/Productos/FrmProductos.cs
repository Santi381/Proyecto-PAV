using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ForrajeriaProyecto.Servicios;
using ForrajeriaProyecto.Entidades;
using System.Runtime.InteropServices;
using System.Globalization;

namespace ForrajeriaProyecto.InterfacesUsuario.Productos
{
    public partial class FrmProductos : Form
    {
        private Principal principal;
        private ProductosServicio productosServicio;
        private ProveedoresServicio proveedoresServicio;

        public FrmProductos(Principal _principal)
        {
            productosServicio = new ProductosServicio();
            proveedoresServicio = new ProveedoresServicio();
            principal = _principal;
            InitializeComponent();
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

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            ConsultarProductos();
        }

        private void BtnConsultarProducto_Click(object sender, EventArgs e)
        {
            ConsultarProductos();
        }

        private void BtnSalirBarra_Click(object sender, EventArgs e)
        {
            cerrarFormulario();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            cerrarFormulario();
        }

        private void cerrarFormulario()
        {
            this.Close();
            principal.Show();
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

        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            var frmAgregarProducto = new FrmAgregarProducto();
            frmAgregarProducto.ShowDialog();
            ConsultarProductos();
        }

        private void BtnModificarProducto_Click(object sender, EventArgs e)
        {
            if (DgvProductos.SelectedRows.Count == 1)
            {
                var id = Convert.ToInt32(DgvProductos.SelectedRows[0].Cells["IDProducto"].Value);
                new FrmModificarProducto(id).ShowDialog();
                ConsultarProductos();
                return;
            }
        }

        private void BtnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (DgvProductos.SelectedRows.Count == 1)
            {
                var id = Convert.ToInt32(DgvProductos.SelectedRows[0].Cells["IDProducto"].Value);
                new FrmBajaProducto(id).ShowDialog();
                ConsultarProductos();
                return;
            }

        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }
}
