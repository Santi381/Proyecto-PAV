using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ForrajeriaProyecto.InterfacesUsuario;
using ForrajeriaProyecto.Entidades;
using ForrajeriaProyecto.Servicios;
using ForrajeriaProyecto.InterfacesUsuario.Clientes;
using ForrajeriaProyecto.InterfacesUsuario.Productos;
using ForrajeriaProyecto.InterfacesUsuario.Proveedores;
using ForrajeriaProyecto.InterfacesUsuario.Reportes;
using ForrajeriaProyecto.InterfacesUsuario.Compras;
using ForrajeriaProyecto.InterfacesUsuario.Usuarios;
using ForrajeriaProyecto.InterfacesUsuario.Presupuestos;

namespace ForrajeriaProyecto
{
    public partial class Principal : Form
    {
        private Usuario usuarioLogueado;
        public Principal()
        {
            InitializeComponent();
        }
        private void Principal_Load(object sender, EventArgs e)
        {
            var frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
            usuarioLogueado = UsuariosServicio.UsuarioLogueado;
            if (usuarioLogueado is null)
            {
                this.Close();
            }
            else
            {
                LblNombreUsuario.Text = $"{usuarioLogueado.NombreUsuario}";
            }
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            var frmClientes = new FrmClientes(this);
            frmClientes.Show();
            this.Hide();
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            var frmProductos = new FrmProductos(this);
            frmProductos.Show();
            this.Hide();
        }
        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PanelHorizontal_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void fechaHora_Tick(object sender, EventArgs e)
        {
            LblHora.Text = DateTime.Now.ToLongTimeString();
            LblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void cerrarFormulario()
        {
            Application.Exit();
        }

        private void BtnSalirBarra_Click(object sender, EventArgs e)
        {
            cerrarFormulario();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            cerrarFormulario();
        }

        private void BtnProveedores_Click(object sender, EventArgs e)
        {
            var frmProveedores = new FrmProveedores(this);
            frmProveedores.Show();
            this.Hide();
        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            var frmVentas = new FrmVentas(this);
            frmVentas.Show();
            this.Hide();
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            var frmReportesPrincipal = new ReportesPrincipal(this);
            frmReportesPrincipal.Show();
            this.Hide();
        }

        private void BtnPresupuesto_Click(object sender, EventArgs e)
        {
            var frmPresupuestos = new FrmPresupuestos(this);
            frmPresupuestos.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frmCompras = new FrmCompras(this);
            frmCompras.Show();
            this.Hide();
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            var frmUsuarios = new FrmUsuarios(this);
            frmUsuarios.Show();
            this.Hide();
        }
    }
}
