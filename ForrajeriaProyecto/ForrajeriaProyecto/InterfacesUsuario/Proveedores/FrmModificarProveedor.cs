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
    public partial class FrmModificarProveedor : Form
    {
        private Proveedor proveedor;
        private ProveedoresServicio proveedoresServicio;
        public FrmModificarProveedor(int id)
        {
            proveedoresServicio = new ProveedoresServicio();
            proveedor = proveedoresServicio.GetProveedor(id);
            InitializeComponent();
        }

        private void BtnModificarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Confirmar operación", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.Cancel)
                    return;
                ValidarProveedor();
                ActualizarProveedor();
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
        private void ValidarProveedor()
        {
            proveedor.RazonSocial = TxtRazonSocialProveedor.Text;
            proveedoresServicio.ValidarProveedor(proveedor);
        }

        private void ActualizarDatos()
        {
            TxtRazonSocialProveedor.Text = proveedor.RazonSocial;
        }
        private void ActualizarProveedor()
        {
            proveedoresServicio.ModificarProveedor(proveedor);
            MessageBox.Show("Se actualizó el proveedor con éxito", "Información");
        }

        private void FrmModificarProveedor_Load(object sender, EventArgs e)
        {
            ActualizarDatos();
        }
        public void CerrarFormulario()
        {
            this.Dispose();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            CerrarFormulario();
        }

        private void BtnSalirBarra_Click(object sender, EventArgs e)
        {
            CerrarFormulario();
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
