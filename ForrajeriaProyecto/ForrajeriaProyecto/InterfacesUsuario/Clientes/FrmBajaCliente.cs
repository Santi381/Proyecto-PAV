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
    public partial class FrmBajaCliente : Form
    {
        private Cliente cliente;
        private ClientesServicio clienteServicio;
        private TiposDocumentoServicio tiposDocumentoServicio;
        public FrmBajaCliente(long id)
        {
            clienteServicio = new ClientesServicio();
            cliente = clienteServicio.GetCliente(id);
            tiposDocumentoServicio = new TiposDocumentoServicio();
            InitializeComponent();
        }
        

        private void BtnBajaCliente_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Confirmar operación", "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.Cancel)
                    return;
                SetBajaCliente();
                DarBajaCliente();
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

        private void DarBajaCliente()
        {
            clienteServicio.DarBajaCliente(cliente);
            MessageBox.Show("La operación se realizó con éxito", "Información");
        }
        private void CargarDatos()
        {
            TxtNroDocumentoCliente.Text = cliente.NroDocumento.ToString();
            TxtNombreCliente.Text = cliente.Nombre;
            TxtApellidoCliente.Text = cliente.Apellido;
            if (cliente.Estado)
            {
                RbActivo.Checked = true;
            }
            else
            {
                RbInactivo.Checked = true;
            }
        }

        private void FrmBajaCliente_Load(object sender, EventArgs e)
        {
            CargarDatos();
            CargarTiposDocumento();    
        }


        private void CerrarFormulario()
        {
            this.Dispose();
        }

        private void SetBajaCliente()
        {
            if (RbActivo.Checked)
            {
                cliente.Estado = true;
            }
            if (RbInactivo.Checked)
            {
                cliente.Estado = false;
            }
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

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSalirBarra_Click(object sender, EventArgs e)
        {
            this.Close();
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
