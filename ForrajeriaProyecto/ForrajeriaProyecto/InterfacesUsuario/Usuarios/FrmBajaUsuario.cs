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


namespace ForrajeriaProyecto.InterfacesUsuario.Usuarios
{
    public partial class FrmBajaUsuario : Form
    {
        private Usuario usuario;
        private UsuariosServicio usuarioServicio;
        public FrmBajaUsuario(int id)
        {
            usuarioServicio = new UsuariosServicio();
            usuario = usuarioServicio.GetUsuario(id);
            InitializeComponent();
        }

        private void LblRazonSocial_Click(object sender, EventArgs e)
        {

        }

        private void BtnBajaProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Confirmar operación", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.Cancel)
                    return;
                SetBajaUsuario();
                DarBajaUsuario();
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
        private void SetBajaUsuario()
        {
            if (RbActivo.Checked)
            {
                usuario.Estado = true;
            }
            if (RbInactivo.Checked)
            {
                usuario.Estado = false;
            }
        }
        private void DarBajaUsuario()
        {
            usuarioServicio.DarBajaUsuario(usuario);
            MessageBox.Show("La operación se realizó con éxito", "Información");
        }

        private void GbEstado_Enter(object sender, EventArgs e)
        {

        }

        private void TxtRazonSocialProveedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BajaUsuario_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void CerrarFormulario()
        {
            this.Dispose();
        }
        private void CargarDatos()
        {
            
            TxtNombre.Text = usuario.NombreUsuario;
            
            if (usuario.Estado)
            {
                RbActivo.Checked = true;
            }
            else
            {
                RbInactivo.Checked = true;
            }
        }

        private void BtnSalirBarra_Click(object sender, EventArgs e)
        {
            CerrarFormulario();
        }

        private void BtnMinimizar_Click_1(object sender, EventArgs e)
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
