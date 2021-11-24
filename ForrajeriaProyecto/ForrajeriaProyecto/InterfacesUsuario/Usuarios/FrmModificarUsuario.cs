using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ForrajeriaProyecto.Entidades;
using ForrajeriaProyecto.Servicios;
using System.Runtime.InteropServices;



namespace ForrajeriaProyecto.InterfacesUsuario.Usuarios
{
    public partial class FrmModificarUsuario : Form
    {
        private Usuario usuario;
        private UsuariosServicio usuarioServicio;
        public FrmModificarUsuario(int id)
        {
            usuarioServicio = new UsuariosServicio();
            usuario = usuarioServicio.GetUsuario(id);
            InitializeComponent();
        }


        private void FrmModificarUsuario_Load(object sender, EventArgs e)
        {
            ActualizarDatos();
        }

        private void BtnModificarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Confirmar operación", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.Cancel)
                    return;
                ValidarUsuario();
                ActualizarUsuario();
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

        private void ActualizarUsuario()
        {
            usuarioServicio.ModificarUsuario(usuario);
            MessageBox.Show("Se actualizó el usuario con éxito", "Información");
        }

        private void CerrarFormulario()
        {
            this.Dispose();
        }

        private void ValidarUsuario()
        {
            usuario.NombreUsuario = TxtNombreUsuario.Text;
            usuario.Contrasenia = TxtContraseñaUsuario.Text;
            usuarioServicio.ValidarUsuario(usuario);
        }

        private void ActualizarDatos()
        {
            TxtNombreUsuario.Text = usuario.NombreUsuario;
            TxtContraseñaUsuario.Text = usuario.Contrasenia;
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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            CerrarFormulario();
        }
    }
}
