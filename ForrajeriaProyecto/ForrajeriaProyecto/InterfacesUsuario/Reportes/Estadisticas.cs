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
using ForrajeriaProyecto.RepositoriosDB;
using Microsoft.Reporting.WinForms;
using ForrajeriaProyecto.Entidades;

namespace ForrajeriaProyecto.InterfacesUsuario.Reportes
{
    public partial class Estadísticas : Form
    {
        private ReportesRepositorio reportesRepositorio;
        public Estadísticas()
        {
            reportesRepositorio = new ReportesRepositorio();
            InitializeComponent();
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

        private void cerrarFormulario()
        {
            this.Dispose();
        }

        private void Estadísticas_Load(object sender, EventArgs e)
        {

            this.RwEstadisticas.RefreshReport();
        }
        private void CargarReporte(VentaFiltros filtros)
        {
            var datos = reportesRepositorio.ObtenerMetodoPago(filtros);
            var datos2 = reportesRepositorio.ObtenerProductosMasVendidos(filtros);
            var datos3 = reportesRepositorio.ObtenerProveedoresMasComprados(filtros);
            var datos4 = reportesRepositorio.ObtenerIngresos(filtros);
            var datos5 = reportesRepositorio.ObtenerEgresos(filtros);

            this.RwEstadisticas.LocalReport.DataSources.Clear();

            var ds = new ReportDataSource("DTMetodoPago", datos);
            var ds2 = new ReportDataSource("DTProductos", datos2);
            var ds3 = new ReportDataSource("DTCompraxProveedor", datos3);
            var ds4 = new ReportDataSource("DTIngresos", datos4);
            var ds5 = new ReportDataSource("DTEgresos", datos5);

            this.RwEstadisticas.LocalReport.DataSources.Add(ds);
            this.RwEstadisticas.LocalReport.DataSources.Add(ds2);
            this.RwEstadisticas.LocalReport.DataSources.Add(ds3);
            this.RwEstadisticas.LocalReport.DataSources.Add(ds4);
            this.RwEstadisticas.LocalReport.DataSources.Add(ds5);

            var parametros = new List<ReportParameter>();
            var fechaHoy = DateTime.Now.ToString("dd/MM/yyyy hh:mm");
            var paramFechaHoy = new ReportParameter("ParamFechaHoy", fechaHoy);
            parametros.Add(paramFechaHoy);
            this.RwEstadisticas.LocalReport.SetParameters(parametros);

            this.RwEstadisticas.RefreshReport();
        }

        private void BtnRealizanReporte_Click(object sender, EventArgs e)
        {
            var filtros = new VentaFiltros();
            filtros.FechaDesde = DtpFechaDesde.Value;
            filtros.FechaHasta = DtpFechaHasta.Value;
            CargarReporte(filtros);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            cerrarFormulario();
        }
    }
}
