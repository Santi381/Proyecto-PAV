using ForrajeriaProyecto.Entidades;
using ForrajeriaProyecto.InterfacesUsuario.Productos;
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
    public partial class FrmAgregarCompra : Form
    {
        private ProveedoresServicio proveedoresServicio;
        private ProductosServicio productoServicio;
        private ComprasServicio comprasServicio;
        public List<DetalleCompra> listaDetalles = new List<DetalleCompra>();
        public int idProv;
        public string nombreProv;
        public FrmAgregarCompra(int prov, String nomProv)
        {
            proveedoresServicio = new ProveedoresServicio();
            productoServicio = new ProductosServicio();
            comprasServicio = new ComprasServicio();
            idProv = prov;
            nombreProv = nomProv;
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void FrmAgregarCompra_Load(object sender, EventArgs e)
        {
            //CargarProveedores();
            TxtProveedor.Text = nombreProv;
            DgvDetalleCompra.Rows.Clear();
            TxtFechaVenta.Text = DateTime.Now.ToString("dd-MM-yyyy");
            var compras = comprasServicio.GetNroOrden();

            foreach (var compra in compras)
            {
                var fila = new string[]
                {
                        compra.NroOrden.ToString(),
                };
                TxtOrden.Text = fila[0];
            }
        }



        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (!(TxtIDProducto.Text != "" && TxtCantidad.Text != ""))
            {
                MessageBox.Show("Ocurrió un problema, debe seleccionar un producto e ingresar la cantidad!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var productoId = Convert.ToInt32(TxtIDProducto.Text);
            Producto productoCargado = new Producto();
            productoCargado = productoServicio.GetProducto(productoId);
            var prodPrecio = Math.Round((Convert.ToSingle(productoCargado.Precio) - (Convert.ToSingle(productoCargado.Precio) * 0.21)), 2);

            if (TxtCantidad.Text == "" && TxtIDProducto.Text != "")
            {
                MessageBox.Show("Ocurrió un problema, debe ingresar una cantidad!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtIDProducto.Text = "";
                TxtCantidad.Text = "";
                return;
            }

            if ((Convert.ToInt32(TxtCantidad.Text) <= 0))
            {
                MessageBox.Show("Ocurrió un problema, la cantidad debe ser mayor a 0", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtIDProducto.Text = "";
                TxtCantidad.Text = "";
                return;
            }
            var fila = new string[]
                {
                    productoCargado.Id.ToString(),
                    productoCargado.Descripcion,
                    prodPrecio.ToString(System.Globalization.CultureInfo.InvariantCulture),
                    TxtCantidad.Text.ToString(),
                    (Convert.ToInt32(TxtCantidad.Text) * Convert.ToSingle(prodPrecio)).ToString(System.Globalization.CultureInfo.InvariantCulture)
                };
            DgvDetalleCompra.Rows.Add(fila);

            float suma = 0;
            foreach (DataGridViewRow row in DgvDetalleCompra.Rows)
            {
                suma += Convert.ToSingle(row.Cells["Subtotal"].Value, System.Globalization.CultureInfo.InvariantCulture);
            }
            TxtMontoTotal.Text = Math.Round(suma, 2).ToString(System.Globalization.CultureInfo.InvariantCulture);
            AgregarStock(productoId, Convert.ToInt32(TxtCantidad.Text));
            TxtIDProducto.Text = "";
            TxtCantidad.Text = "";
        }
        private void AgregarStock(int id, int cantidad)
        {
            productoServicio.SumarStock(id, cantidad);
        }


        private void BtnRegistrarCompra_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsOperacionConfirmada())
                    return;
                RegistrarCompra();
            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                var mensaje = ex.Message;
                MessageBox.Show("Ha ocurrido un problema, intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool EsOperacionConfirmada()
        {
            var respuesta = MessageBox.Show("¿Desea confirmar la operación?", "Confirmación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
                return true;
            return false;
        }
        private void RegistrarCompra()
        {
            var compra = new Compra();
            compra.Fecha = Convert.ToDateTime(TxtFechaVenta.Text);
            float suma = 0;
            foreach (DataGridViewRow row in DgvDetalleCompra.Rows)
            {
                suma += Convert.ToSingle(row.Cells["Subtotal"].Value, System.Globalization.CultureInfo.InvariantCulture);
            }
            compra.Monto = suma;
            var prov = new Proveedor();
            prov.Id = idProv;
            compra.Proveedor = prov;
            if (RbEfectivo.Checked)
            {
                compra.TipoPago = "Efectivo";
            }
            if (RbTarjeta.Checked)
            {
                compra.TipoPago = "Tarjeta";
            }
            RegistrarDetalleCompra(compra);
            if (!comprasServicio.RegistrarCompra(compra, listaDetalles))
            {
                ReponerStock();
                MessageBox.Show("Ocurrió un problema al registrar la compra", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("La compra se registró con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void RegistrarDetalleCompra(Compra compra)
        {
            foreach (DataGridViewRow row in DgvDetalleCompra.Rows)
            {
                DetalleCompra det = new DetalleCompra();
                compra.NroOrden = Convert.ToInt32(ObtenerNroOrden());
                det.NroOrden = compra;
                var prod = new Producto();
                prod.Id = Convert.ToInt32(row.Cells["ID"].Value);
                det.Producto = prod;
                det.Cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                det.PrecioUnitario = Convert.ToSingle(row.Cells["PrecioUnitario"].Value, System.Globalization.CultureInfo.InvariantCulture);
                listaDetalles.Add(det);
            }

            this.Close();

        }
        private string ObtenerNroOrden()
        {
            var compras = comprasServicio.GetNroOrden();
            var res = "";
            foreach (var compra in compras)
            {
                var fila = new string[]
                {
                        compra.NroOrden.ToString(),
                };
                var s = Convert.ToInt32(fila[0]) - 1;
                res = s.ToString();
 
            }
            return res;
        }

        private void BuscarProducto_Click_1(object sender, EventArgs e)
        {
            var idProveedor = idProv;
            var frmConsultarProducto = new FrmProductoXProveedor(idProveedor);
            AddOwnedForm(frmConsultarProducto);
            frmConsultarProducto.ShowDialog();

        }
        private void ReponerStock()
        {
            var idProd = 0;
            var cantidad = 0;
            foreach (DataGridViewRow row in DgvDetalleCompra.Rows)
            {
                idProd = Convert.ToInt32(row.Cells["ID"].Value);
                cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                productoServicio.RestarStock(idProd, cantidad);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            ReponerStock();
            CerrarFormulario();
        }
        private void CerrarFormulario()
        {
            this.Dispose();
        }

        private void BtnEliminarFila_Click(object sender, EventArgs e)
        {
            var idProd = 0;
            var cantidad = 0;
            var total = Convert.ToSingle(TxtMontoTotal.Text, System.Globalization.CultureInfo.InvariantCulture);
            foreach (DataGridViewRow row in DgvDetalleCompra.SelectedRows)
            {
                idProd = Convert.ToInt32(row.Cells["ID"].Value);
                cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                productoServicio.RestarStock(idProd, cantidad);
                total -= Convert.ToSingle(row.Cells["Subtotal"].Value, System.Globalization.CultureInfo.InvariantCulture);
            }
            if (DgvDetalleCompra.CurrentRow == null)
            {
                MessageBox.Show("No hay productos cargados", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DgvDetalleCompra.Rows.RemoveAt(DgvDetalleCompra.CurrentRow.Index);
            TxtMontoTotal.Text = total.ToString();
        }

        private void TxtCantidad_KeyPress(object sender, KeyPressEventArgs e)
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

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnSalirBarra_Click(object sender, EventArgs e)
        {
            CerrarFormulario();
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
