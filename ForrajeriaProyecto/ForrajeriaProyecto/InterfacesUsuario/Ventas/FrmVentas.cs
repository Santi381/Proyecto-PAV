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
using ForrajeriaProyecto.Servicios;
using ForrajeriaProyecto.Entidades;
using ForrajeriaProyecto.InterfacesUsuario.Ventas;

namespace ForrajeriaProyecto
{
    public partial class FrmVentas : Form
    {
        private Principal principal;
        private VentasServicio ventasServicio;
        private ClientesServicio Clientes;
        public FrmVentas(Principal _principal)
        {
            Clientes = new ClientesServicio();
            ventasServicio = new VentasServicio();
            principal = _principal;
            InitializeComponent();
        }
        private void ConsultarVentas()
        {
            var ventaFiltros = new Venta();
            var valor = TxtNroOrden.Text.Trim();
            if (valor == "" || valor == null)
            {
                ventaFiltros.NroOrden = 0; 
            }
            else
            {
                ventaFiltros.NroOrden = Convert.ToInt32(TxtNroOrden.Text.Trim());
            }
            var ventas = ventasServicio.GetVentas(ventaFiltros);
            DgvVentas.Rows.Clear();

            foreach (var venta in ventas)
            {
                var fila = new string[]
                {
                venta.NroOrden.ToString(),
                venta.Fecha.ToString("dd/MM/yyyy"),
                venta.Monto.ToString(System.Globalization.CultureInfo.InvariantCulture),
                venta.TipoCobro,
                venta.Cliente.Nombre + " "+ venta.Cliente.Apellido,
                };
                DgvVentas.Rows.Add(fila);
            }

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
            this.Close();
            principal.Show();
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            ConsultarVentas();
        }

        private void BtnConsultarProducto_Click(object sender, EventArgs e)
        {
            ConsultarVentas();
        }

        private void BtnAgregarVenta_Click(object sender, EventArgs e)
        {
            var frmAgregarVenta = new FrmAgregarVenta();
            frmAgregarVenta.ShowDialog();
            ConsultarVentas();
        }

        private void BtnDetalleVenta_Click(object sender, EventArgs e)
        {
            if (DgvVentas.SelectedRows.Count == 1)
            {
                var id = Convert.ToInt32(DgvVentas.SelectedRows[0].Cells["NroOrden"].Value);
                new FrmDetalleVenta(id).ShowDialog();
                ConsultarVentas();
                return;
            }
        }

        private void DgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
