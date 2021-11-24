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
    
    public partial class FrmBajaProveedor : Form
    {
        private Proveedor proveedor;
        private ProveedoresServicio proveedoresServicio;
        public FrmBajaProveedor(long id)
        {
            proveedoresServicio = new ProveedoresServicio();
            proveedor = proveedoresServicio.GetProveedor(id);
            InitializeComponent();
        }

        private void BtnBajaProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Confirmar operación", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.Cancel)
                    return;
                SetBajaProveedor();
                DarBajaProveedor();
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
        private void DarBajaProveedor()
        {
            proveedoresServicio.DarBajaProveedor(proveedor);
            MessageBox.Show("La operación se realizó con éxito", "Información");
        }
        private void CargarDatos()
        {
            TxtRazonSocialProveedor.Text = proveedor.RazonSocial;
            if (proveedor.Estado)
            {
                RbActivo.Checked = true;
            }
            else
            {
                RbInactivo.Checked = true;
            }
        }

        private void FrmBajaProveedor_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void SetBajaProveedor()
        {
            if (RbActivo.Checked)
            {
                proveedor.Estado = true;
            }
            if (RbInactivo.Checked)
            {
                proveedor.Estado = false;
            }
        }
        private void CerrarFormulario()
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
