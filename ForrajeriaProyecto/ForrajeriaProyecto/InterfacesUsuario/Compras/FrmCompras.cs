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


namespace ForrajeriaProyecto.InterfacesUsuario.Compras
{
    public partial class FrmCompras : Form
    {
        private Principal principal;
        private ComprasServicio comprasServicio;
        private ProveedoresServicio Proveedores;
        public FrmCompras(Principal _principal)
        {
            Proveedores = new ProveedoresServicio();
            comprasServicio = new ComprasServicio();
            principal = _principal;
            InitializeComponent();
        }
        private void ConsultarCompras()
        {
            var compraFiltros = new Compra();
            var valor = TxtNroOrden.Text.Trim();
            if (valor == "" || valor == null)
            {
                compraFiltros.NroOrden = 0;
                var compras = comprasServicio.GetCompra(compraFiltros);
                DgvCompras.Rows.Clear();

                foreach (var compra in compras)
                {
                    var fila = new string[]
                    {
                        compra.NroOrden.ToString(),
                        compra.Fecha.ToString("dd/MM/yyyy"),
                        Math.Round(compra.Monto, 2).ToString(System.Globalization.CultureInfo.InvariantCulture),
                        compra.TipoPago,
                        compra.Proveedor.RazonSocial,
                    };
                    DgvCompras.Rows.Add(fila);
                }
            }
            else
            {
                compraFiltros.NroOrden = Convert.ToInt32(TxtNroOrden.Text.Trim());
                var compras = comprasServicio.GetCompra(compraFiltros);
                DgvCompras.Rows.Clear();

                foreach (var compra in compras)
                {
                    var fila = new string[]
                    {
                        compra.NroOrden.ToString(),
                        compra.Fecha.ToString("dd/MM/yyyy"),
                        Math.Round(compra.Monto, 2).ToString(System.Globalization.CultureInfo.InvariantCulture),
                        compra.TipoPago,
                        compra.Proveedor.RazonSocial,
                    };
                    DgvCompras.Rows.Add(fila);
                }
            }
        }

        private void FrmCompras_Load(object sender, EventArgs e)
        {
            ConsultarCompras();
        }

        private void BtnConsultarCompra_Click(object sender, EventArgs e)
        {
            ConsultarCompras();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            cerrarFormulario();
        }
        private void cerrarFormulario()
        {
            this.Close();
            principal.Show();
        }

        private void BtnAgregarCompra_Click(object sender, EventArgs e)
        {
            var frmAgregarCompra = new FrmSeleccionarProveedor();
            frmAgregarCompra.ShowDialog();
        }

        private void BtnDetalleCompra_Click(object sender, EventArgs e)
        {
            if (DgvCompras.SelectedRows.Count == 1)
            {
                var id = Convert.ToInt32(DgvCompras.SelectedRows[0].Cells["NroOrden"].Value);
                new FrmDetalleCompra(id).ShowDialog();
                ConsultarCompras();
                return;
            }
        }

        private void TxtNroOrden_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
