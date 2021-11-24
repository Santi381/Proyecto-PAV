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
using ForrajeriaProyecto.InterfacesUsuario.Usuarios;
using ForrajeriaProyecto.Servicios;
using System.Runtime.InteropServices;



namespace ForrajeriaProyecto.InterfacesUsuario.Usuarios
{

    public partial class FrmUsuarios : Form
    {
        private Principal principal;
        private UsuariosServicio usuariosServicio;
        public FrmUsuarios(Principal _principal)
        {
            principal = _principal;
            usuariosServicio = new UsuariosServicio();
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            cerrarFormulario();
        }

        private void cerrarFormulario()
        {
            this.Dispose();
            principal.Show();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            ConsultarUsuarios();
        }

        private void BtnConsultarUsuario_Click(object sender, EventArgs e)
        {

            ConsultarUsuarios();
        }

        private void ConsultarUsuarios()
        {
            var usuarioFiltros = new Usuario();
            var valor = TxtIdUsuario.Text.Trim();
            if (valor == "" || valor == null)
            {
                usuarioFiltros.Id = 0;

            }
            else
            {
                usuarioFiltros.Id = Convert.ToInt32(TxtIdUsuario.Text.Trim());
            }
            var mostrarTodos = CkMostrarTodosUsuarios.Checked;
            var usuarios = usuariosServicio.GetUsuarios(usuarioFiltros, mostrarTodos);
            DgvUsuarios.Rows.Clear();

            foreach (var usuario in usuarios)
            {
                var descripcionEstado = usuario.Estado ? "Activo" : "Inactivo";
                var fila = new string[]
                {
                    usuario.Id.ToString(),
                    usuario.NombreUsuario,
                    descripcionEstado,
                };
                DgvUsuarios.Rows.Add(fila);
            }

        }

        private void BtnAgregarUsuario_Click(object sender, EventArgs e)
        {
            var frmRegistrarUsuario = new RegistrarUsuario();
            frmRegistrarUsuario.ShowDialog();
            ConsultarUsuarios();
        }

        private void BtnModificarUsuario_Click(object sender, EventArgs e)
        {
            if(DgvUsuarios.SelectedRows.Count == 1)
            {
                var id = Convert.ToInt32(DgvUsuarios.SelectedRows[0].Cells["IDUsuario"].Value);
                new FrmModificarUsuario(id).ShowDialog();
                ConsultarUsuarios();
                return;
            }
        }

        private void BtnEliminarUsuario_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(DgvUsuarios.SelectedRows[0].Cells["IDUsuario"].Value);
            new FrmBajaUsuario(id).ShowDialog();
            ConsultarUsuarios();
            return;
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

        private void TxtIdUsuario_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}