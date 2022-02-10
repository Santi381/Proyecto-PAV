using ForrajeriaProyecto.Entidades;
using ForrajeriaProyecto.Servicios;
using ForrajeriaProyecto.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForrajeriaProyecto.InterfacesUsuario.Productos
{
    public partial class FrmModificarProducto : Form
    {
        private Producto producto;
        private ProductosServicio productoServicio;
        private ProveedoresServicio proveedoresServicio;
        public FrmModificarProducto(int id)
        {
            proveedoresServicio = new ProveedoresServicio();
            productoServicio = new ProductosServicio();
            producto = productoServicio.GetProducto(id);
            InitializeComponent();
        }

        private void BtnModificarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Confirmar operación", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.Cancel)
                    return;
                ValidarProducto();
                ActualizarProducto();
                CerrarFormulario();
            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ValidarProducto()
        {
            var nombre = TxtNombreProducto.Text;
            var marca = TxtMarca.Text;
            var stock = TxtStock.Text;
            var precio = TxtPrecio.Text;
            var descripcion = TxtDescripcion.Text;
            var proveedor = (Proveedor)CbProveedor.SelectedItem;

            CultureInfo culture = new CultureInfo("en-US");
            producto.Nombre = nombre;
            producto.Marca = marca;
            producto.Stock = Convert.ToInt32(stock);
            producto.Precio = Convert.ToSingle(precio, culture);
            producto.Descripcion = descripcion;
            producto.Proveedor = proveedor;
            productoServicio.ValidarProducto(producto);
        }

        private void ActualizarDatos()
        {
            TxtNombreProducto.Text = producto.Nombre;
            TxtMarca.Text = producto.Marca;
            TxtStock.Text = producto.Stock.ToString();
            TxtPrecio.Text = producto.Precio.ToString(System.Globalization.CultureInfo.InvariantCulture);
            TxtDescripcion.Text = producto.Descripcion;
        }
        private void ActualizarProducto()
        {
            productoServicio.ModificarProducto(producto);
            MessageBox.Show("Se actualizó el producto con éxito", "Información");
        }
        private void CargarProveedores()
        {
            var proveedor = proveedoresServicio.GetProveedores();
            var conector = new BindingSource();
            conector.DataSource = proveedor;
            FormUtils.CargarCombo(ref CbProveedor, conector, "RazonSocial", "Id");
            var proveedorSeleccionado = proveedor.First(td => td.Id == producto.Proveedor.Id);
            CbProveedor.SelectedItem = proveedorSeleccionado;
        }
        private void FrmModificarProducto_Load(object sender, EventArgs e)
        {
            CargarProveedores();
            ActualizarDatos();
        }

        public void CerrarFormulario()
        {
            this.Dispose();
        }

        private void BtnSalirBarra_Click(object sender, EventArgs e)
        {
            CerrarFormulario();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
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

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }

}
