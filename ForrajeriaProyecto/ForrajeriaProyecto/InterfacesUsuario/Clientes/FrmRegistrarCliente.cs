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
using ForrajeriaProyecto.Entidades;
using ForrajeriaProyecto.Servicios;


namespace ForrajeriaProyecto.InterfacesUsuario.Clientes
{
    public partial class FrmRegistrarCliente : Form
    {
        private Cliente cliente;
        private ClientesServicio clienteServicio;
        private TiposDocumentoServicio tiposDocumentoServicio;

        public FrmRegistrarCliente()
        {
            tiposDocumentoServicio = new TiposDocumentoServicio();
            clienteServicio = new ClientesServicio();
            InitializeComponent();
        }

        private void BtnAgregarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (!EsClienteValido())
                    return;
                if (!EsOperacionConfirmada())
                    return;
                RegistrarCliente();
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

        private bool EsClienteValido()
        {
            var clienteIngresado = new Cliente();
            clienteIngresado.NroDocumento = TxtNroDocumentoCliente.Text;
            clienteIngresado.TipoDocumento = (TipoDocumento)CbTipoDocumentoCliente.SelectedItem;
            clienteIngresado.Nombre = TxtNombreCliente.Text;
            clienteIngresado.Apellido = TxtApellidoCliente.Text;
            clienteIngresado.Telefono = TxtTelefonoCliente.Text;
            clienteIngresado.Direccion = TxtDireccionCliente.Text;
            clienteServicio.ValidarCliente(clienteIngresado);
            cliente = clienteIngresado;
            return true;
        }

        private void RegistrarCliente()
        {
            if (!clienteServicio.RegistrarCliente(cliente))
            {
                MessageBox.Show("Ocurrió un problema al registrar el cliente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("El cliente se registró con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }

        private void CargarTiposDocumento()
        {
            var tiposDocumento = tiposDocumentoServicio.GetTiposDocumento();
            var tipoDocumentoSelecciona = tiposDocumento.First();
            var conector = new BindingSource();
            conector.DataSource = tiposDocumento;
            CbTipoDocumentoCliente.DataSource = conector;
            CbTipoDocumentoCliente.DisplayMember = "Descripcion";
            CbTipoDocumentoCliente.ValueMember = "Id";
            CbTipoDocumentoCliente.SelectedItem = tipoDocumentoSelecciona;
        }

        private void FrmRegistrarCliente_Load(object sender, EventArgs e)
        {
            CargarTiposDocumento();
        }

        private void BtnSalirBarra_Click(object sender, EventArgs e)
        {
            cerrarFormulario();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void cerrarFormulario()
        {
            this.Dispose();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
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

        private void TxtNroDocumentoCliente_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtTelefonoCliente_KeyPress(object sender, KeyPressEventArgs e)
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
