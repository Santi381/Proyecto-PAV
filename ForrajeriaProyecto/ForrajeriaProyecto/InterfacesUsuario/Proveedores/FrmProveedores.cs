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
    public partial class FrmProveedores : Form
    {
        private Principal principal;
        private ProveedoresServicio proveedoresServicio;
        public FrmProveedores(Principal _principal)
        {
            proveedoresServicio = new ProveedoresServicio();
            principal = _principal;
            InitializeComponent();
        }
        private void ConsultarProveedores()
        {

            var proveedorFiltros = new Proveedor();
            proveedorFiltros.RazonSocial = TxtRazonSocial.Text.Trim();
            var mostrarTodos = CkMostrarTodos.Checked;
            var proveedores = proveedoresServicio.GetProveedores(proveedorFiltros, mostrarTodos);
            DgvProveedores.Rows.Clear();

            foreach (var proveedor in proveedores)
            {
                var descripcionEstado = proveedor.Estado ? "Activo" : "Inactivo";
                var fila = new string[]
                {
                    proveedor.Id.ToString(),
                    proveedor.RazonSocial,
                    descripcionEstado
                };
                DgvProveedores.Rows.Add(fila);
            }
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            ConsultarProveedores();
        }

        private void BtnConsultarProveedor_Click(object sender, EventArgs e)
        {
            ConsultarProveedores();
        }

        private void cerrarFormulario()
        {
            this.Close();
            principal.Show();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            cerrarFormulario();
        }

        private void BtnAgregarProveedor_Click(object sender, EventArgs e)
        {
            var frmRegistrarProveedor = new FrmRegistrarProveedor();
            frmRegistrarProveedor.ShowDialog();
        }

        private void BtnModificarProveedor_Click(object sender, EventArgs e)
        {
            if (DgvProveedores.SelectedRows.Count == 1)
            {
                var id = Convert.ToInt32(DgvProveedores.SelectedRows[0].Cells["IDProveedor"].Value);
                new FrmModificarProveedor(id).ShowDialog();
                ConsultarProveedores();
                return;
            }
        }

        private void BtnEliminarProveedor_Click(object sender, EventArgs e)
        {
            if (DgvProveedores.SelectedRows.Count == 1)
            {
                var id = Convert.ToInt32(DgvProveedores.SelectedRows[0].Cells["IDProveedor"].Value);
                new FrmBajaProveedor(id).ShowDialog();
                ConsultarProveedores();
                return;
            }
        }

        private void DgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
