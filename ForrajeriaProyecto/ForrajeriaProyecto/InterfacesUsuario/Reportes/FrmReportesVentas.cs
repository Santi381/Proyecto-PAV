using ForrajeriaProyecto.Entidades;
using ForrajeriaProyecto.RepositoriosDB;
using ForrajeriaProyecto.Servicios;
using Microsoft.Reporting.WinForms;
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
    public partial class FrmReportesVentas : Form
    {
        private readonly ClientesServicio clientesServicio = new ClientesServicio();
        private readonly ReportesRepositorio reportesRepositorio;
        public FrmReportesVentas()
        {
            clientesServicio = new ClientesServicio();

            reportesRepositorio = new ReportesRepositorio();
            InitializeComponent();
        }

        private void RwBugs_Load(object sender, EventArgs e)
        {

        }

        private void ReportesVentas_Load(object sender, EventArgs e)
        {
            CargarClientes();
            this.RwVentas.RefreshReport();
        }
        private void CargarClientes()
        {
            var cliente = clientesServicio.GetClientes();
            var clienteCargado = cliente.First();
            var conector = new BindingSource();
            conector.DataSource = cliente;
            CbCliente.DataSource = conector;
            CbCliente.DisplayMember = "FullName";
            CbCliente.ValueMember = "Id";
            CbCliente.SelectedItem = clienteCargado;
        }

        private void CargarReporte(VentaFiltros filtros)
        {
            var datos = reportesRepositorio.ObtenerVentasFiltros(filtros);
            var datos1 = reportesRepositorio.ObtenerCliente(filtros);

            this.RwVentas.LocalReport.DataSources.Clear();

            var ds = new ReportDataSource("VentasDS", datos);
            var ds1 = new ReportDataSource("DTCliente", datos1);

            this.RwVentas.LocalReport.DataSources.Add(ds);
            this.RwVentas.LocalReport.DataSources.Add(ds1);

            var fechaHoy = DateTime.Now.ToString("dd/MM/yyyy hh:mm");
            var paramFechaHoy = new ReportParameter("ParamFechaGeneracion", fechaHoy);

            var parametros = new List<ReportParameter>();

            parametros.Add(paramFechaHoy);
            this.RwVentas.LocalReport.SetParameters(parametros);

            this.RwVentas.RefreshReport();
        }

        private void BtnRealizanReporte_Click(object sender, EventArgs e)
        {
            var filtros = new VentaFiltros();
            filtros.FechaDesde = DtpFechaDesde.Value;
            filtros.FechaHasta = DtpFechaHasta.Value;
            filtros.IdCliente = ((Cliente)CbCliente.SelectedItem).Id;
            CargarReporte(filtros);
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

        private void BtnConsultarCliente_Click(object sender, EventArgs e)
        {
            var frmReporteCliente = new FrmReportesVentas();
            frmReporteCliente.ShowDialog();
        }
        private void cerrarFormulario()
        {
            this.Dispose();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            cerrarFormulario();
        }
    }
}
