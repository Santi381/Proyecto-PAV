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
using System.Drawing.Printing;

namespace ForrajeriaProyecto.InterfacesUsuario.Compras
{
    public partial class FrmDetalleCompra : Form
    {
        private ComprasServicio comprasServicio;
        private Compra compra;
        public List<DetalleCompra> detallesCompra = new List<DetalleCompra>();
        public FrmDetalleCompra(long id)
        {
            comprasServicio = new ComprasServicio();
            compra = comprasServicio.GetCompra(id);
            detallesCompra = comprasServicio.ObtenerDetalles(id);
            InitializeComponent();
        }
        private void CargarProveedor()
        {
            TxtNombreProveedor.Text = compra.Proveedor.RazonSocial;
            TxtMontoTotal.Text = Convert.ToString(compra.Monto, System.Globalization.CultureInfo.InvariantCulture);
            TxtFechaVenta.Text = DateTime.Now.ToString("dd-MM-yyyy");
            if (compra.TipoPago != null && compra.TipoPago == "Efectivo")
            {
                RbEfectivo.Checked = true;
            }
            else if (compra.TipoPago != null && compra.TipoPago == "Tarjeta")
            {
                RbTarjeta.Checked = true;
            }
        }
        private void CargarDetalles(List<DetalleCompra> detallesCompra)
        {
            DgvDetCompra.Rows.Clear();
            foreach (var detalleCompra in detallesCompra)
            {
                var fila = new string[]
                {
                    detalleCompra.Id.ToString(),
                    detalleCompra.Producto.Descripcion.ToString(),
                    detalleCompra.PrecioUnitario.ToString(System.Globalization.CultureInfo.InvariantCulture),
                    detalleCompra.Cantidad.ToString(),
                    (detalleCompra.PrecioUnitario * detalleCompra.Cantidad).ToString(System.Globalization.CultureInfo.InvariantCulture)
                };
                DgvDetCompra.Rows.Add(fila);
            }
        }

        private void FrmDetalleCompra_Load(object sender, EventArgs e)
        {
            CargarProveedor();
            CargarDetalles(detallesCompra);
        }

        private void BtnVolverAtras_Click(object sender, EventArgs e)
        {
            cerrarFormulario();
        }
        private void cerrarFormulario()
        {
            this.Close();
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
            e.Graphics.DrawString("Orden #" + compra.NroOrden.ToString(), font, Brushes.Black, new RectangleF(0, y += 40, ancho, 25));
            e.Graphics.DrawString("Proveedor: " + TxtNombreProveedor.Text, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 25));
            e.Graphics.DrawString("Fecha: " + TxtFechaVenta.Text, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 25));
            e.Graphics.DrawString("------------------------------------------------------", font, Brushes.Black, new RectangleF(0, y += 30, ancho, 25));
            e.Graphics.DrawString("Cantidad", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 25));
            e.Graphics.DrawString("Producto", font, Brushes.Black, new RectangleF(93, y, ancho, 25));
            e.Graphics.DrawString("PU", font, Brushes.Black, new RectangleF(310, y, ancho, 25));
            e.Graphics.DrawString("------------------------------------------------------", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 25));

            foreach (DataGridViewRow fila in DgvDetCompra.Rows)
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
