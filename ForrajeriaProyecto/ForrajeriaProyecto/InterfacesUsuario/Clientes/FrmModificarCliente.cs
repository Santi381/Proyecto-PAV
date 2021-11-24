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
using ForrajeriaProyecto.Utils;


namespace ForrajeriaProyecto.InterfacesUsuario.Clientes
{
    public partial class FrmModificarCliente : Form
    {
        private Cliente cliente;
        private ClientesServicio clienteServicio;
        private TiposDocumentoServicio tiposDocumentoServicio;
        public FrmModificarCliente(int id)
        {
            tiposDocumentoServicio = new TiposDocumentoServicio();
            clienteServicio = new ClientesServicio();
            cliente = clienteServicio.GetCliente(id);
            InitializeComponent();
        }

        private void BtnModificarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Confirmar operación", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.Cancel)
                    return;
                ValidarCliente();
                ActualizarCliente();
                CerrarFormulario();
            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidarCliente()
        {
            cliente.TipoDocumento = (TipoDocumento)CbTipoDocumentoCliente.SelectedItem; ;
            cliente.NroDocumento = TxtNroDocumentoCliente.Text;
            cliente.Nombre = TxtNombreCliente.Text;
            cliente.Apellido = TxtApellidoCliente.Text;
            cliente.Telefono = TxtTelefonoCliente.Text; ;
            cliente.Direccion = TxtDireccionCliente.Text;
            clienteServicio.ValidarCliente(cliente);
        }

        private void ActualizarDatos()
        {
            TxtNroDocumentoCliente.Text = cliente.NroDocumento.ToString();
            TxtNombreCliente.Text = cliente.Nombre;
            TxtApellidoCliente.Text = cliente.Apellido;
            TxtTelefonoCliente.Text = cliente.Telefono;
            TxtDireccionCliente.Text = cliente.Direccion;
        }
        private void CargarTiposDocumento()
        {
            var tiposDocumento = tiposDocumentoServicio.GetTiposDocumento();
            var conector = new BindingSource();
            conector.DataSource = tiposDocumento;
            FormUtils.CargarCombo(ref CbTipoDocumentoCliente, conector, "Descripcion", "Id");
            var tipoDocumentoSeleccionado = tiposDocumento.First(td => td.Id == cliente.TipoDocumento.Id);
            CbTipoDocumentoCliente.SelectedItem = tipoDocumentoSeleccionado;
        }
        private void ActualizarCliente()
        {
            clienteServicio.ModificarCliente(cliente);
            MessageBox.Show("Se actualizó el cliente con éxito", "Información");
        }

        private void FrmModificarCliente_Load(object sender, EventArgs e)
        {
            CargarTiposDocumento();
            ActualizarDatos();
        }

        private void BtnSalirBarra_Click(object sender, EventArgs e)
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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            CerrarFormulario();
        }

        public void CerrarFormulario()
        {
            this.Dispose();
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
