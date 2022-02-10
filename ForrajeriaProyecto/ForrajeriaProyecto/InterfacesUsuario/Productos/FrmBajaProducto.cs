using ForrajeriaProyecto.Entidades;
using ForrajeriaProyecto.Servicios;
using ForrajeriaProyecto.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForrajeriaProyecto.InterfacesUsuario.Productos
{
    public partial class FrmBajaProducto : Form
    {
        private Producto producto;
        private ProductosServicio productoServicio;
        private ProveedoresServicio proveedoresServicio;
        public FrmBajaProducto(long id)
        {
            proveedoresServicio = new ProveedoresServicio();
            productoServicio = new ProductosServicio();
            producto = productoServicio.GetProducto(id);
            InitializeComponent();
        }

        private void BtnBajaProducto_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Confirmar operación", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.Cancel)
                    return;
                SetBajaProducto();
                DarBajaProducto();
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
        private void DarBajaProducto()
        {
            productoServicio.DarBajaProducto(producto);
            MessageBox.Show("La operación se realizó con éxito", "Información");
        }
        private void CargarDatos()
        {
            TxtNombreProducto.Text = producto.Nombre;
            TxtMarca.Text = producto.Marca;
            TxtDescripcion.Text = producto.Descripcion;
            if (producto.Estado)
            {
                RbActivo.Checked = true;
            }
            else
            {
                RbInactivo.Checked = true;
            }
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

        private void FrmBajaProducto_Load(object sender, EventArgs e)
        {
            CargarDatos();
            CargarProveedores();
        }
        private void CerrarFormulario()
        {
            this.Dispose();
        }
        private void SetBajaProducto()
        {
            if (RbActivo.Checked)
            {
                producto.Estado = true;
            }
            if (RbInactivo.Checked)
            {
                producto.Estado = false;
            }
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

        private void cerrarFormulario()
        {
            this.Dispose();
        }

        private void BtnSalirBarra_Click(object sender, EventArgs e)
        {
            cerrarFormulario();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            cerrarFormulario();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
