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

namespace ForrajeriaProyecto.InterfacesUsuario.Reportes
{
    public partial class ReportesPrincipal : Form
    {

        private Principal principal;
        public ReportesPrincipal(Principal _principal)
        {
            InitializeComponent();
            principal = _principal;
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

        private void BtnComprasPorProveedor_Click(object sender, EventArgs e)
        {
            var frmComprasPorProveedor = new FrmReporteCompraPorProveedor();
            frmComprasPorProveedor.ShowDialog();
        }

        private void BtnStockPorProducto_Click(object sender, EventArgs e)
        {
            var frmStockPorProducto = new FrmReporteStockPorProducto();
            frmStockPorProducto.ShowDialog();
        }

        private void BtnCompras_Click(object sender, EventArgs e)
        {
            var frmCompras = new FrmReportesCompras();
            frmCompras.ShowDialog();
        }

        private void BrnProductosMasVendidos_Click(object sender, EventArgs e)
        {
            var frmReporteProducto = new FrmReportesProductos();
            frmReporteProducto.ShowDialog();
        }

        private void BtnMontoPorCliente_Click(object sender, EventArgs e)
        {
            var frmReporteMonto = new FrmReportesClientesMonto();
            frmReporteMonto.ShowDialog();
        }

        private void BtnVentasPorCliente_Click(object sender, EventArgs e)
        {
            var frmReporteCliente = new FrmReportesVentas();
            frmReporteCliente.ShowDialog();
        }

        private void BtnEstadisticas_Click(object sender, EventArgs e)
        {
            var frmEstadísticas = new Estadísticas();
            frmEstadísticas.ShowDialog();

        }
    }
}
