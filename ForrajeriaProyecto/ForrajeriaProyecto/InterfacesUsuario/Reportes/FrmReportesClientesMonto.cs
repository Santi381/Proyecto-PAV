using ForrajeriaProyecto.RepositoriosDB;
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
    public partial class FrmReportesClientesMonto : Form
    {
        private ReportesRepositorio reportesRepositorio;
        public FrmReportesClientesMonto()
        {
            reportesRepositorio = new ReportesRepositorio();
            InitializeComponent();
        }

        private void FrmReportesClientesMonto_Load(object sender, EventArgs e)
        {

            this.CargarReporte();
        }
        private void CargarReporte()
        {
            var datos = reportesRepositorio.ObtenerMontoPorCliente();

            this.RwMonto.LocalReport.DataSources.Clear();

            var ds = new ReportDataSource("DTMontoxCliente", datos);

            this.RwMonto.LocalReport.DataSources.Add(ds);

            var parametros = new List<ReportParameter>();
            var fechaHoy = DateTime.Now.ToString("dd/MM/yyyy hh:mm");
            var paramFechaHoy = new ReportParameter("ParamFechaHoy", fechaHoy);
            parametros.Add(paramFechaHoy);
            this.RwMonto.LocalReport.SetParameters(parametros);

            this.RwMonto.RefreshReport();
        }
        private void cerrarFormulario()
        {
            this.Dispose();
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

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            cerrarFormulario();
        }

        private void BtnSalirBarra_Click(object sender, EventArgs e)
        {
            cerrarFormulario();
        }
    }
}