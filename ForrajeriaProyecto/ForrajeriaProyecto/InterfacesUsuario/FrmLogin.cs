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
using ForrajeriaProyecto.Entidades;
using ForrajeriaProyecto.Servicios;

namespace ForrajeriaProyecto.InterfacesUsuario
{
    public partial class FrmLogin : Form
    {
        private UsuariosServicio usuariosServicio;

        public FrmLogin()
        {
            InitializeComponent();
            usuariosServicio = new UsuariosServicio();
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            var usuarioIngresado = TxtUsuario.Text;

            Usuario usuario = new Usuario();
            usuario.NombreUsuario = usuarioIngresado;
            usuario.Contrasenia = TxtContrasenia.Text;

            var usuarioLogueado = usuariosServicio.Login(usuario);
            if (usuarioLogueado == null)
            {
                MessageBox.Show("Usuario/contraseña inválida", "Información", MessageBoxButtons.OK);
            }
            else
            {
                this.Dispose();
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

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            cerrarFormulario();
        }

        private void BtnSalirBarra_Click(object sender, EventArgs e)
        {
            cerrarFormulario();
        }

        private void cerrarFormulario()
        {
            Application.Exit();
        }
    }
}
