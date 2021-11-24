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

namespace ForrajeriaProyecto.InterfacesUsuario.Proveedores
{
    public partial class FrmRegistrarProveedor : Form
    {
        private Proveedor proveedor;
        private ProveedoresServicio proveedoresServicio;
        public FrmRegistrarProveedor()
        {
            proveedoresServicio = new ProveedoresServicio();
            InitializeComponent();
        }

        private void BtnAgregarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsProveedorValido())
                    return;
                if (!EsOperacionConfirmada())
                    return;
                RegistrarProveedor();
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
        private bool EsProveedorValido()
        {
            var razonSocial = TxtRazonSocialProveedor.Text;

            var proveedorIngresado = new Proveedor();
            proveedorIngresado.RazonSocial = razonSocial;
            proveedoresServicio.ValidarProveedor(proveedorIngresado);
            proveedor = proveedorIngresado;
            return true;
        }
        private void RegistrarProveedor()
        {
            if (!proveedoresServicio.RegistrarProveedor(proveedor))
            {
                MessageBox.Show("Ocurrió un problema al registrar el proveedor", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("El proveedor se registró con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }

        private void FrmRegistrarProveedor_Load(object sender, EventArgs e)
        {

        }
        private void cerrarFormulario()
        {
            this.Dispose();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            cerrarFormulario();
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
