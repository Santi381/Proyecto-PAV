using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ForrajeriaProyecto.Servicios;
using ForrajeriaProyecto.Entidades;
using System.Runtime.InteropServices;



namespace ForrajeriaProyecto.InterfacesUsuario.Clientes
{
    public partial class FrmClientes : Form
    {
        private ClientesServicio clientesServicio;
        private Principal principal;
        private TiposDocumentoServicio tiposDocumentoServicio;
        public List<Cliente> clientes = new List<Cliente>();

        public FrmClientes(Principal _principal)
        {
            principal = _principal;
            clientesServicio = new ClientesServicio();
            tiposDocumentoServicio = new TiposDocumentoServicio();
            InitializeComponent();
        }

        
        private void ConsultarClientes()
        {

            var clienteFiltros = new Cliente();
            clienteFiltros.NroDocumento = TxtDniCliente.Text;
            clienteFiltros.TipoDocumento = (TipoDocumento)CbTipoDocumentoCliente.SelectedItem;
            var mostrarTodos = CkMostrarTodos.Checked;
            var clientes = clientesServicio.GetClientes(clienteFiltros, mostrarTodos);
            DgvClientes.Rows.Clear();

            foreach (var cliente in clientes)
            {
                var descripcionEstado = cliente.Estado ? "Activo" : "Inactivo";
                var fila = new string[]
                {
                    cliente.Id.ToString(),
                    cliente.TipoDocumento.Descripcion,
                    cliente.NroDocumento.ToString(),
                    cliente.Nombre,
                    cliente.Apellido,
                    cliente.Telefono,
                    cliente.Direccion,
                    descripcionEstado
                };
                DgvClientes.Rows.Add(fila);
            }
        }

        private void BtnAgregarCliente_Click(object sender, EventArgs e)
        {
            var frmRegistrarCliente = new FrmRegistrarCliente();
            frmRegistrarCliente.ShowDialog();
            ConsultarClientes();

        }

        private void BtnModificarCliente_Click(object sender, EventArgs e)
        {
            if (DgvClientes.SelectedRows.Count == 1)
            {
                var id = Convert.ToInt32(DgvClientes.SelectedRows[0].Cells["IDCliente"].Value);
                new FrmModificarCliente(id).ShowDialog();
                ConsultarClientes();
                return;
            }
        }

        private void BtnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (DgvClientes.SelectedRows.Count == 1)
            {
                var id = Convert.ToInt32(DgvClientes.SelectedRows[0].Cells["IDCliente"].Value);
                new FrmBajaCliente(id).ShowDialog();
                ConsultarClientes();
                return;
            }

        }
        private void CargarTiposDocumento()
        {
            var tiposDocumento = tiposDocumentoServicio.GetTiposDocumento();
            var tipoDocumentoDefault = new TipoDocumento();
            tipoDocumentoDefault.Descripcion = "Seleccionar";
            tiposDocumento.Add(tipoDocumentoDefault);

            var conector = new BindingSource();
            conector.DataSource = tiposDocumento;
            CbTipoDocumentoCliente.DataSource = conector;
            CbTipoDocumentoCliente.DisplayMember = "Descripcion";
            CbTipoDocumentoCliente.ValueMember = "Id";
            CbTipoDocumentoCliente.SelectedItem = tipoDocumentoDefault;
        }


        private void BtnConsultarCliente_Click(object sender, EventArgs e)
        {
            ConsultarClientes();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            CargarTiposDocumento();
            ConsultarClientes();
        }

        private void BtnSalirBarra_Click(object sender, EventArgs e)
        {
            cerrarFormulario();

        }

        private void BtnSalir_Click(object sender, EventArgs e)
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
        private void cerrarFormulario()
        {
            this.Dispose();
            principal.Show();
        }

        private void TxtDniCliente_KeyPress(object sender, KeyPressEventArgs e)
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
