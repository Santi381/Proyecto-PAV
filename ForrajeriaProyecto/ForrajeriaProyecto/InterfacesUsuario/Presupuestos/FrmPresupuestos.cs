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

namespace ForrajeriaProyecto.InterfacesUsuario.Presupuestos
{
    public partial class FrmPresupuestos : Form
    {
        public PresupuestosServicio presupuestoServicio;
        public Presupuesto presupuesto;
        private Principal principal;
        private ClientesServicio clientesServicio;

        public FrmPresupuestos(Principal _principal)
        {
            InitializeComponent();
            presupuestoServicio = new PresupuestosServicio();
            presupuesto = new Presupuesto();
            principal = _principal;
            clientesServicio = new ClientesServicio();
        }

        private void FrmPresupuestos_Load(object sender, EventArgs e)
        {
            CargarClientes();
            ConsultarPresupuestos();
        }

        private void ConsultarPresupuestos()
        {
            var presupuestos = presupuestoServicio.GetPresupuestos();
            DgvVentas.Rows.Clear();

            foreach (var presupuesto in presupuestos)
            {
                var fila = new string[]
                    {
                presupuesto.IdPresupuesto.ToString(),
                presupuesto.Fecha.ToString("dd/MM/yyyy"),
                presupuesto.Monto.ToString(System.Globalization.CultureInfo.InvariantCulture),
                presupuesto.Cliente.Nombre + " " + presupuesto.Cliente.Apellido,
                    };
                DgvVentas.Rows.Add(fila);
            }
        }

        private void ConsultarPresupuestosCliente()
        {
            var presupuestoFiltro = new Presupuesto();
            presupuestoFiltro.Cliente = (Cliente)CBClientes.SelectedItem;
            var presupuestos = presupuestoServicio.GetPresupuestos(presupuestoFiltro);
            DgvVentas.Rows.Clear();

            foreach (var presupuesto in presupuestos)
            {
            var fila = new string[]
                {
                presupuesto.IdPresupuesto.ToString(),
                presupuesto.Fecha.ToString("dd/MM/yyyy"),
                presupuesto.Monto.ToString(System.Globalization.CultureInfo.InvariantCulture),
                presupuesto.Cliente.Nombre + " " + presupuesto.Cliente.Apellido,
                };
            DgvVentas.Rows.Add(fila);
            }
        }
        private void CargarClientes()
        {
            var cliente = clientesServicio.GetClientes();
            var clienteCargado = new Cliente();
            clienteCargado.Nombre = "Seleccionar";
            cliente.Add(clienteCargado);

            var conector = new BindingSource();
            conector.DataSource = cliente;
            CBClientes.DataSource = conector;
            CBClientes.DisplayMember = "FullName";
            CBClientes.ValueMember = "Id";
            CBClientes.SelectedItem = clienteCargado;
        }

        private void BtnConsultarPresupuestos_Click(object sender, EventArgs e)
        {
            ConsultarPresupuestosCliente();
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

        private void BtnAgregarPresupuesto_Click(object sender, EventArgs e)
        {
            var frmAgregarPresupuesto = new FrmAgregarPresupuesto();
            frmAgregarPresupuesto.ShowDialog();
            ConsultarPresupuestos();
        }

        private void BtnDetallePresupuesto_Click(object sender, EventArgs e)
        {
            if (DgvVentas.SelectedRows.Count == 1)
            {
                var id = Convert.ToInt32(DgvVentas.SelectedRows[0].Cells["NroOrden"].Value);
                new FrmDetallePresupuesto(id).ShowDialog();
                ConsultarPresupuestos();
                return;
            }
        }
    }
}
