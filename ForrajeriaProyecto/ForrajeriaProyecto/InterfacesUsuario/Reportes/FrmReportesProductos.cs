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
    public partial class FrmReportesProductos : Form
    {
        private ReportesRepositorio reportesRepositorio;
        public FrmReportesProductos()
        {
            reportesRepositorio = new ReportesRepositorio();
            InitializeComponent();
        }

        private void FrmReportesProductos_Load(object sender, EventArgs e)
        {

            this.CargarReporte();
        }
        private void CargarReporte()
        {
            var datos = reportesRepositorio.ObtenerProductos();

            this.RwProductos.LocalReport.DataSources.Clear();

            var ds = new ReportDataSource("DTProductos", datos);

            this.RwProductos.LocalReport.DataSources.Add(ds);

            var parametros = new List<ReportParameter>();
            var fechaHoy = DateTime.Now.ToString("dd/MM/yyyy hh:mm");
            var paramFechaHoy = new ReportParameter("ParamFechaHoy", fechaHoy);
            parametros.Add(paramFechaHoy);
            this.RwProductos.LocalReport.SetParameters(parametros);

            this.RwProductos.RefreshReport();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            cerrarFormulario();
        }
        private void cerrarFormulario()
        {
            this.Dispose();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnSalirBarra_Click(object sender, EventArgs e)
        {
            cerrarFormulario();
        }

        private void BtnMinimizar_Click_1(object sender, EventArgs e)
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
    }
}
