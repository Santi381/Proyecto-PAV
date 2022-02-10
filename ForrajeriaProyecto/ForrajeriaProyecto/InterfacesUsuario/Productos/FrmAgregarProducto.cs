using ForrajeriaProyecto.Entidades;
using ForrajeriaProyecto.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace ForrajeriaProyecto.InterfacesUsuario.Productos
{
    public partial class FrmAgregarProducto : Form
    {
        private Producto producto;
        private ProductosServicio productoServicio;
        private ProveedoresServicio proveedoresServicio;
        public FrmAgregarProducto()
        {
            proveedoresServicio = new ProveedoresServicio();
            productoServicio = new ProductosServicio();
            InitializeComponent();
        }

        private void BtnRegistrarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsProductoValido())
                    return;
                if (!EsOperacionConfirmada())
                    return;
                RegistrarProducto();
            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                var mensaje = ex.Message;
                MessageBox.Show("Ha ocurrido un problema, intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool EsOperacionConfirmada()
        {
            var respuesta = MessageBox.Show("¿Desea confirmar la operación?", "Confirmación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
                return true;
            return false;
        }

        private bool EsProductoValido()
        {
            var nombre = TxtNombreProducto.Text;
            var marca = TxtMarcaProducto.Text;
            var stock = TxtStockProducto.Text;
            var precio = TxtPrecioProducto.Text;
            var descripcion = TxtDescripcionProducto.Text;
            var idProveedor = (Proveedor)CbProveedor.SelectedItem;

            CultureInfo culture = new CultureInfo("en-US");
            var productoIngreasdo = new Producto();
            productoIngreasdo.Nombre = nombre;
            productoIngreasdo.Marca = marca;
            productoIngreasdo.Stock = Convert.ToInt32(stock);
            productoIngreasdo.Precio = Convert.ToSingle(precio, culture);
            productoIngreasdo.Descripcion = descripcion;
            productoIngreasdo.Proveedor = idProveedor;
            productoServicio.ValidarProducto(productoIngreasdo);
            producto = productoIngreasdo;
            return true;
        }

        private void RegistrarProducto()
        {
            if (!productoServicio.RegistrarProducto(producto))
            {
                MessageBox.Show("Ocurrió un problema al registrar el producto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("El producto se registró con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            cerrarFormulario();
        }
        private void cerrarFormulario()
        {
            this.Dispose();
        }

        private void FrmAgregarProducto_Load(object sender, EventArgs e)
        {
            CargarProveedores();
        }
        private void CargarProveedores()
        {
            var proveedores = proveedoresServicio.GetProveedoresActivos();
            var proveedoresSelecciona = proveedores.First();
            var conector = new BindingSource();
            conector.DataSource = proveedores;
            CbProveedor.DataSource = conector;
            CbProveedor.DisplayMember = "RazonSocial";
            CbProveedor.ValueMember = "Id";
            CbProveedor.SelectedItem = proveedoresSelecciona;
        }

        private void TxtStockProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void BtnSalirBarra_Click(object sender, EventArgs e)
        {
            cerrarFormulario();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
    }
}
