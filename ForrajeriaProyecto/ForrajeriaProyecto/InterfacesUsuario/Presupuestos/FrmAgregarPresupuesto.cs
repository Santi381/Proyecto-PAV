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
using ForrajeriaProyecto.InterfacesUsuario.Clientes;
using ForrajeriaProyecto.InterfacesUsuario.Productos;
using System.Runtime.InteropServices;


namespace ForrajeriaProyecto.InterfacesUsuario.Presupuestos
{
    public partial class FrmAgregarPresupuesto : Form
    {
        private ClientesServicio clientesServicio;
        private ProductosServicio productoServicio;
        private PresupuestosServicio presupuestosServicio;
        public List<DetallePresupuesto> listaDetalles = new List<DetallePresupuesto>();


        public FrmAgregarPresupuesto()
        {
            InitializeComponent();
            clientesServicio = new ClientesServicio();
            productoServicio = new ProductosServicio();
            presupuestosServicio = new PresupuestosServicio();
        }

        private void FrmAgregarPresupuesto_Load(object sender, EventArgs e)
        {
            CargarClientes();
            DgvDetallePresupuesto.Rows.Clear();
            TxtFechaDía.Text = DateTime.Now.ToString("dd-MM-yyyy");
            var presupuestos = presupuestosServicio.GetNroPresupuesto();

            foreach (var presupuesto in presupuestos)
            {
                var fila = new string[]
                {
                        presupuesto.IdPresupuesto.ToString(),
                };
                TxtNroPresupuesto.Text = fila[0];
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
            CBCliente.DataSource = conector;
            CBCliente.DisplayMember = "FullName";
            CBCliente.ValueMember = "Id";
            CBCliente.SelectedItem = clienteCargado;
        }

        private void BtnAddCliente_Click(object sender, EventArgs e)
        {
            var frmAgregarCliente = new FrmRegistrarCliente();
            frmAgregarCliente.ShowDialog();
        }

        private void BtnSalirBarra_Click(object sender, EventArgs e)
        {
            CerrarFormulario();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
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

        private void CerrarFormulario()
        {
            this.Dispose();
        }

        private void BuscarProducto_Click(object sender, EventArgs e)
        {
            var frmConsultarProducto = new FrmConsultarProductoPresupuesto();
            AddOwnedForm(frmConsultarProducto);
            frmConsultarProducto.ShowDialog();
        }

        private void BtnAgregarProducto_Click_1(object sender, EventArgs e)
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
                    productoCargado.Precio.ToString(System.Globalization.CultureInfo.InvariantCulture),
                    TxtCantidad.Text.ToString(),
                    (Convert.ToInt32(TxtCantidad.Text) * Convert.ToSingle(productoCargado.Precio)).ToString(System.Globalization.CultureInfo.InvariantCulture)
                };
            DgvDetallePresupuesto.Rows.Add(fila);

            float suma = 0;
            foreach (DataGridViewRow row in DgvDetallePresupuesto.Rows)
            {
                suma += Convert.ToSingle(row.Cells["Subtotal"].Value, System.Globalization.CultureInfo.InvariantCulture);
            }
            TxtMontoTotal.Text = suma.ToString(System.Globalization.CultureInfo.InvariantCulture);
            TxtIDProducto.Text = "";
            TxtCantidad.Text = "";
        }

        private void RegistrarDetallePresupuesto(Presupuesto presupuesto)
        {
            foreach (DataGridViewRow row in DgvDetallePresupuesto.Rows)
            {
                DetallePresupuesto det = new DetallePresupuesto();
                presupuesto.IdPresupuesto = Convert.ToInt32(ObtenerNroPresupuesto());
                det.IdPresupuesto = presupuesto;
                var prod = new Producto();
                prod.Id = Convert.ToInt32(row.Cells["ID"].Value);
                det.Producto = prod;
                det.Cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                det.PrecioUnitario = Convert.ToSingle(row.Cells["PrecioUnitario"].Value, System.Globalization.CultureInfo.InvariantCulture);
                listaDetalles.Add(det);
            }

            this.Close();

        }

        private string ObtenerNroPresupuesto()
        {
            var presupuestos = presupuestosServicio.GetNroPresupuesto();
            var res = "";
            foreach (var presupuesto in presupuestos)
            {
                var fila = new string[]
                {
                        presupuesto.IdPresupuesto.ToString(),
                };
                var s = Convert.ToInt32(fila[0]) - 1;
                res = s.ToString();
            }
            return res;
        }

        private void BtnRegistrarPresupuesto_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsOperacionConfirmada())
                    return;
                RegistrarPresupuesto();
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

        private void RegistrarPresupuesto()
        {
            var presupuesto = new Presupuesto();
            presupuesto.Fecha = Convert.ToDateTime(TxtFechaDía.Text);
            float suma = 0;
            foreach (DataGridViewRow row in DgvDetallePresupuesto.Rows)
            {
                suma += Convert.ToSingle(row.Cells["Subtotal"].Value, System.Globalization.CultureInfo.InvariantCulture);
            }
            presupuesto.Monto = suma;
            presupuesto.Cliente = (Cliente)CBCliente.SelectedItem;
            if (presupuesto.Cliente.Id == 0)
            {
                MessageBox.Show("Se debe seleccionar un cliente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            RegistrarDetallePresupuesto(presupuesto);
            if (!presupuestosServicio.RegistrarPresupuesto(presupuesto, listaDetalles))
            {
                MessageBox.Show("Ocurrió un problema al registrar el presupuesto", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("El presupuesto se registró con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void BtnEliminarFila_Click(object sender, EventArgs e)
        {
            var total = Convert.ToSingle(TxtMontoTotal.Text, System.Globalization.CultureInfo.InvariantCulture);
            foreach (DataGridViewRow row in DgvDetallePresupuesto.SelectedRows)
            {
                total -= Convert.ToSingle(row.Cells["Subtotal"].Value, System.Globalization.CultureInfo.InvariantCulture);
            }
            if (DgvDetallePresupuesto.CurrentRow == null)
            {
                MessageBox.Show("No hay productos cargados", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DgvDetallePresupuesto.Rows.RemoveAt(DgvDetallePresupuesto.CurrentRow.Index);
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
