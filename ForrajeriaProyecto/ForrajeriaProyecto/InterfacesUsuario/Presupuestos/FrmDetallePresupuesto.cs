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
using System.Drawing.Printing;

namespace ForrajeriaProyecto.InterfacesUsuario.Presupuestos
{
    public partial class FrmDetallePresupuesto : Form
    {
        private PresupuestosServicio presupuestosServicio;
        private Presupuesto presupuesto;
        public List<DetallePresupuesto> detallesPresupuesto = new List<DetallePresupuesto>();
        public FrmDetallePresupuesto(long id)
        {
            InitializeComponent();
            presupuestosServicio = new PresupuestosServicio();
            presupuesto = presupuestosServicio.GetPresupuesto(id);
            detallesPresupuesto = presupuestosServicio.GetDetalles(id);
        }

        private void CargarCliente()
        {
            TxtNombreCliente.Text = presupuesto.Cliente.Nombre + " " + presupuesto.Cliente.Apellido;
            TxtMontoTotal.Text = Convert.ToString(presupuesto.Monto, System.Globalization.CultureInfo.InvariantCulture);
            TxtFechaVenta.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }

        private void CargarDetalles(List<DetallePresupuesto> detallesPresupuesto)
        {
            DgvDetVenta.Rows.Clear();
            foreach (var detallePresupuesto in detallesPresupuesto)
            {
                var fila = new string[]
                {
                    detallePresupuesto.Id.ToString(),
                    detallePresupuesto.Producto.Nombre.ToString(),
                    detallePresupuesto.PrecioUnitario.ToString(System.Globalization.CultureInfo.InvariantCulture),
                    detallePresupuesto.Cantidad.ToString(),
                    (detallePresupuesto.PrecioUnitario * detallePresupuesto.Cantidad).ToString(System.Globalization.CultureInfo.InvariantCulture)
                };
                DgvDetVenta.Rows.Add(fila);
            }
        }

        private void FrmDetallePresupuesto_Load(object sender, EventArgs e)
        {
            CargarCliente();
            CargarDetalles(detallesPresupuesto);
        }

        private void BtnVolverAtras_Click(object sender, EventArgs e)
        {
            cerrarFormulario();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnSalirBarra_Click(object sender, EventArgs e)
        {
            cerrarFormulario();
        }

        private void cerrarFormulario()
        {
            this.Dispose();
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

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += Imprimir;
            printDocument1.Print();
        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Arial", 14);
            int ancho = 500;
            int y = 20;
            var suma = 0;

            e.Graphics.DrawString("FORRAJERÍA MARTÍN FIERRO", font, Brushes.Black, new RectangleF(40, y += 20, ancho, 25));
            e.Graphics.DrawString("Orden #" + presupuesto.IdPresupuesto.ToString(), font, Brushes.Black, new RectangleF(0, y += 40, ancho, 25));
            e.Graphics.DrawString("Cliente: " + TxtNombreCliente.Text, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 25));
            e.Graphics.DrawString("Fecha: " + TxtFechaVenta.Text, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 25));
            e.Graphics.DrawString("------------------------------------------------------", font, Brushes.Black, new RectangleF(0, y += 30, ancho, 25));
            e.Graphics.DrawString("Cantidad", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 25));
            e.Graphics.DrawString("Producto", font, Brushes.Black, new RectangleF(93, y, ancho, 25));
            e.Graphics.DrawString("PU", font, Brushes.Black, new RectangleF(310, y, ancho, 25));
            e.Graphics.DrawString("------------------------------------------------------", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 25));

            foreach (DataGridViewRow fila in DgvDetVenta.Rows)
            {
                e.Graphics.DrawString(fila.Cells["Cantidad"].Value.ToString(), font, Brushes.Black, new RectangleF(30, y += 20, ancho, 25));
                e.Graphics.DrawString(fila.Cells["Producto"].Value.ToString(), font, Brushes.Black, new RectangleF(95, y, ancho, 25));
                e.Graphics.DrawString(fila.Cells["PrecioUnitario"].Value.ToString(), font, Brushes.Black, new RectangleF(290, y, ancho, 25));
                suma += 1;
            }
            e.Graphics.DrawString("------------------------------------------------------", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 25));
            e.Graphics.DrawString("Cantidad de productos: " + suma.ToString(), font, Brushes.Black, new RectangleF(0, y += 30, ancho, 25));
            e.Graphics.DrawString("Monto total: $" + TxtMontoTotal.Text, font, Brushes.Black, new RectangleF(0, y += 30, ancho, 25));
        }
    }
}
