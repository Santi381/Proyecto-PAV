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
    public partial class RegistrarUsuario : Form
    {
        private Usuario usuario;
        private UsuariosServicio usuarioServicio;
        public RegistrarUsuario()
        {
            usuarioServicio = new UsuariosServicio();
            InitializeComponent();
        }

        private void RegistrarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void BtnAgregarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsUsuarioValido())
                    return;
                if (!EsOperacionConfirmada())
                    return;
                RegistrarUsuarioIngresado();
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

        private void RegistrarUsuarioIngresado()
        {
            if (!usuarioServicio.RegistrarUsuario(usuario))
            {
                MessageBox.Show("Ocurrió un problema al registrar el usuario", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("El usuario se registró con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }

        private bool EsUsuarioValido()
        {
            var nombre = TxtNombreUsuario.Text;
            var contra1 = TxtContrasenia1.Text;
            var contra2 = TxtContrasenia2.Text;
            if (contra1 != contra2)
                
                return false;

            var usuarioIngresado = new Usuario();
            usuarioIngresado.NombreUsuario = nombre;
            usuarioIngresado.Contrasenia = contra1;
            usuarioServicio.ValidarUsuario(usuarioIngresado);
            usuario = usuarioIngresado;
            return true;

        }
    

        private bool EsOperacionConfirmada()
        {
            var respuesta = MessageBox.Show("¿Desea confirmar la operación?", "Confirmación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
                return true;
            return false;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            cerrarFormulario();
        }

        private void cerrarFormulario()
        {
            this.Dispose();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnSalirBarra_Click(object sender, EventArgs e)
        {
            cerrarFormulario();
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
