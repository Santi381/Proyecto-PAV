using ForrajeriaProyecto.Entidades;
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
using System.Runtime.InteropServices;


namespace ForrajeriaProyecto.InterfacesUsuario.Compras
{
    public partial class FrmSeleccionarProveedor : Form
    {
        private ProveedoresServicio proveedoresServicio;
        public FrmSeleccionarProveedor()
        {
            proveedoresServicio = new ProveedoresServicio();
            InitializeComponent();
        }
        private void CargarProveedores()
        {
            var proveedor = proveedoresServicio.GetProveedoresActivos();
            var proveedorCargado = new Proveedor();
            proveedorCargado.RazonSocial = "Seleccionar";
            proveedor.Add(proveedorCargado);

            var conector = new BindingSource();
            conector.DataSource = proveedor;
            CBProveedores.DataSource = conector;
            CBProveedores.DisplayMember = "RazonSocial";
            CBProveedores.ValueMember = "Id";
            CBProveedores.SelectedItem = proveedorCargado;
        }

        private void FrmSeleccionarProveedor_Load(object sender, EventArgs e)
        {
            CargarProveedores();
        }
        private void CerrarFormulario()
        {
            this.Dispose();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            CerrarFormulario();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            var proveedor = Convert.ToInt32(CBProveedores.SelectedValue);
            if (proveedor == 0)
            {
                MessageBox.Show("Debe seleccionar un proveedor", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                var nombreProv = Convert.ToString(CBProveedores.Text);
                var frmAgregarCompra = new FrmAgregarCompra(proveedor, nombreProv);
                frmAgregarCompra.ShowDialog();
                this.Close();
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
