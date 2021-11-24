using ForrajeriaProyecto.Entidades;
using ForrajeriaProyecto.InterfacesUsuario.Clientes;
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
using ForrajeriaProyecto.InterfacesUsuario.Productos;
using System.Runtime.InteropServices;


namespace ForrajeriaProyecto.InterfacesUsuario.Ventas
{
    public partial class FrmAgregarVenta : Form
    {
        private ClientesServicio clientesServicio;
        private ProductosServicio productoServicio;
        private VentasServicio ventasServicio;
        public List<DetalleVenta> listaDetalles = new List<DetalleVenta>();


        public FrmAgregarVenta()
        {
            InitializeComponent();
            clientesServicio = new ClientesServicio();
            productoServicio = new ProductosServicio();
            ventasServicio = new VentasServicio();
        }

        private void FrmAgregarVenta_Load(object sender, EventArgs e)
        {
            CargarClientes();
            DgvDetalleVenta.Rows.Clear();
            TxtFechaVenta.Text = DateTime.Now.ToString("dd-MM-yyyy");
            var ventas = ventasServicio.GetNroOrden();

            foreach (var venta in ventas)
            {
                var fila = new string[]
                {
                        venta.NroOrden.ToString(),
                };
                TxtOrden.Text = fila[0];
            }

        }

        private void BtnAgregarCliente_Click(object sender, EventArgs e)
        {
            var frmRegistrarCliente = new FrmRegistrarCliente();
            frmRegistrarCliente.ShowDialog();
        }
        private void CerrarFormulario()
        {
            this.Dispose();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            ReponerStock();
            CerrarFormulario();
            
        }
        private void ReponerStock()
        {
            var idProd = 0;
            var cantidad = 0;
            foreach (DataGridViewRow row in DgvDetalleVenta.Rows)
            {
                idProd = Convert.ToInt32(row.Cells["ID"].Value);
                cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                productoServicio.ReponerStock(idProd, cantidad);
            }
        }

        private void CargarClientes()
        {
            var cliente = clientesServicio.GetClientesActivos();
            var clienteCargado = new Cliente();
            clienteCargado.Nombre = "Seleccionar";
            cliente.Add(clienteCargado);

            var conector = new BindingSource();
            conector.DataSource = cliente;
            CBClientes.DataSource = conector;
            CBClientes.DisplayMember = "FullName";
            CBClientes.ValueMember = "Id";
            CBClientes.SelectedItem = clienteCargado;
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

            if (TxtCantidad.Text == "" && Convert.ToString(TxtIDProducto.Text) != "")
            {
                MessageBox.Show("Ocurrió un problema, debe ingresar una cantidad!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtIDProducto.Text = "";
                TxtCantidad.Text = "";
                return;
            }

            int productoStock = Convert.ToInt32(productoCargado.Stock);

            if ((Convert.ToInt32(TxtCantidad.Text) > productoStock || Convert.ToInt32(TxtCantidad.Text) <= 0))
            {
                MessageBox.Show("Ocurrió un problema, la cantidad debe ser mayor a 0 y no puede ser mayor a " + productoCargado.Stock, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtIDProducto.Text = "";
                TxtCantidad.Text = "";
                return;
            }
            var fila = new string[]
                {
                    productoCargado.Id.ToString(),
                    productoCargado.Descripcion,
                    Math.Round(productoCargado.Precio, 2).ToString(System.Globalization.CultureInfo.InvariantCulture),
                    TxtCantidad.Text.ToString(),
                    (Convert.ToInt32(TxtCantidad.Text) * Convert.ToSingle(productoCargado.Precio)).ToString(System.Globalization.CultureInfo.InvariantCulture)
                };
            DgvDetalleVenta.Rows.Add(fila);

            float suma = 0;
            foreach (DataGridViewRow row in DgvDetalleVenta.Rows)
            {
                suma += Convert.ToSingle(row.Cells["Subtotal"].Value, System.Globalization.CultureInfo.InvariantCulture);
            }
            TxtMontoTotal.Text = Math.Round(suma, 2).ToString(System.Globalization.CultureInfo.InvariantCulture);
            DescontarStock(productoId, Convert.ToInt32(TxtCantidad.Text));
            TxtIDProducto.Text = "";
            TxtCantidad.Text = "";
        }
        private string ObtenerNroOrden()
        {
            var ventas = ventasServicio.GetNroOrden();
            var res = "";
            foreach (var venta in ventas)
            {
                var fila = new string[]
                {
                        venta.NroOrden.ToString(),
                };
                var s = Convert.ToInt32(fila[0]) - 1;
                res = s.ToString();            
            }
            return res;
        }
        private void RegistrarDetalleVenta(Venta venta)
        {
            foreach (DataGridViewRow row in DgvDetalleVenta.Rows)
            {
                DetalleVenta det = new DetalleVenta();
                venta.NroOrden = Convert.ToInt32(ObtenerNroOrden());
                det.NroOrden = venta;
                var prod = new Producto();
                prod.Id = Convert.ToInt32(row.Cells["ID"].Value);
                det.Producto = prod;
                det.Cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                det.PrecioUnitario = Convert.ToSingle(row.Cells["PrecioUnitario"].Value, System.Globalization.CultureInfo.InvariantCulture);
                listaDetalles.Add(det);
            }

            this.Close();

        }
        private void BuscarProducto_Click(object sender, EventArgs e)
        {
            var frmConsultarProducto = new FrmConsultarProducto();
            AddOwnedForm(frmConsultarProducto);
            frmConsultarProducto.ShowDialog();
        }

        private void BtnRegistrarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsOperacionConfirmada())
                    return;
                RegistrarVenta();
            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ReponerStock();
            }
            catch (Exception ex)
            {
                var mensaje = ex.Message;
                MessageBox.Show("Ha ocurrido un problema, intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ReponerStock();
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

        private void RegistrarVenta()
        {
            var venta = new Venta();
            venta.Fecha = Convert.ToDateTime(TxtFechaVenta.Text);
            float suma = 0;
            foreach (DataGridViewRow row in DgvDetalleVenta.Rows)
            {
                suma += Convert.ToSingle(row.Cells["Subtotal"].Value, System.Globalization.CultureInfo.InvariantCulture);
            }
            venta.Monto = suma;
            venta.Cliente = (Cliente)CBClientes.SelectedItem;
            if (RbEfectivo.Checked)
            {
                venta.TipoCobro = "Efectivo";
            }
            if (RbTarjeta.Checked)
            {
                venta.TipoCobro = "Tarjeta";
            }
            RegistrarDetalleVenta(venta);
            if (!ventasServicio.RegistrarVenta(venta, listaDetalles))
            {
                ReponerStock();
                MessageBox.Show("Ocurrió un problema al registrar la venta", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("La venta se registró con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void DescontarStock(int id, int cantidad)
        {
            productoServicio.RestarStock(id, cantidad);
        }

        private void BtnSalirBarra_Click(object sender, EventArgs e)
        {
            ReponerStock();
            CerrarFormulario();
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

        private void BtnEliminarFila_Click(object sender, EventArgs e)
        {
            var idProd = 0;
            var cantidad = 0;
            var total = Convert.ToSingle(TxtMontoTotal.Text, System.Globalization.CultureInfo.InvariantCulture);
            foreach (DataGridViewRow row in DgvDetalleVenta.SelectedRows)
            {
                idProd = Convert.ToInt32(row.Cells["ID"].Value);
                cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                productoServicio.ReponerStock(idProd, cantidad);
                total -= Convert.ToSingle(row.Cells["Subtotal"].Value, System.Globalization.CultureInfo.InvariantCulture);
            }
            if (DgvDetalleVenta.CurrentRow == null)
            {
                MessageBox.Show("No hay productos cargados", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DgvDetalleVenta.Rows.RemoveAt(DgvDetalleVenta.CurrentRow.Index);
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
    }
}
