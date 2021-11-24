
namespace ForrajeriaProyecto.InterfacesUsuario.Clientes
{
    partial class FrmClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            this.DgvClientes = new System.Windows.Forms.DataGridView();
            this.IDCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeléfonoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DirecciónCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelHorizontal = new System.Windows.Forms.Panel();
            this.LblTituloVentana = new System.Windows.Forms.Label();
            this.PicIconoVentana = new System.Windows.Forms.PictureBox();
            this.BtnRestaurar = new System.Windows.Forms.PictureBox();
            this.BtnMaximizar = new System.Windows.Forms.PictureBox();
            this.BtnMinimizar = new System.Windows.Forms.PictureBox();
            this.BtnSalirBarra = new System.Windows.Forms.PictureBox();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnAgregarCliente = new System.Windows.Forms.Button();
            this.BtnEliminarCliente = new System.Windows.Forms.Button();
            this.BtnModificarCliente = new System.Windows.Forms.Button();
            this.BtnConsultarCliente = new System.Windows.Forms.Button();
            this.TxtDniCliente = new System.Windows.Forms.TextBox();
            this.CkMostrarTodos = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CbTipoDocumentoCliente = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).BeginInit();
            this.PanelHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicIconoVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalirBarra)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvClientes
            // 
            this.DgvClientes.AllowUserToAddRows = false;
            this.DgvClientes.AllowUserToDeleteRows = false;
            this.DgvClientes.AllowUserToResizeRows = false;
            this.DgvClientes.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCliente,
            this.tipoDocumento,
            this.nroDocumento,
            this.NombreCliente,
            this.ApellidoCliente,
            this.TeléfonoCliente,
            this.DirecciónCliente,
            this.EstadoCliente});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 11F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvClientes.DefaultCellStyle = dataGridViewCellStyle10;
            this.DgvClientes.Location = new System.Drawing.Point(12, 108);
            this.DgvClientes.MultiSelect = false;
            this.DgvClientes.Name = "DgvClientes";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 11F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.DgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvClientes.Size = new System.Drawing.Size(742, 211);
            this.DgvClientes.TabIndex = 0;
            // 
            // IDCliente
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.IDCliente.DefaultCellStyle = dataGridViewCellStyle2;
            this.IDCliente.HeaderText = "ID";
            this.IDCliente.Name = "IDCliente";
            this.IDCliente.ReadOnly = true;
            this.IDCliente.Width = 30;
            // 
            // tipoDocumento
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.tipoDocumento.DefaultCellStyle = dataGridViewCellStyle3;
            this.tipoDocumento.HeaderText = "Tipo ";
            this.tipoDocumento.Name = "tipoDocumento";
            this.tipoDocumento.Width = 70;
            // 
            // nroDocumento
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.nroDocumento.DefaultCellStyle = dataGridViewCellStyle4;
            this.nroDocumento.HeaderText = "Numero ";
            this.nroDocumento.Name = "nroDocumento";
            this.nroDocumento.ReadOnly = true;
            this.nroDocumento.Width = 75;
            // 
            // NombreCliente
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.NombreCliente.DefaultCellStyle = dataGridViewCellStyle5;
            this.NombreCliente.HeaderText = "Nombre";
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.ReadOnly = true;
            this.NombreCliente.Width = 120;
            // 
            // ApellidoCliente
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.ApellidoCliente.DefaultCellStyle = dataGridViewCellStyle6;
            this.ApellidoCliente.HeaderText = "Apellido";
            this.ApellidoCliente.Name = "ApellidoCliente";
            this.ApellidoCliente.ReadOnly = true;
            this.ApellidoCliente.Width = 90;
            // 
            // TeléfonoCliente
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.TeléfonoCliente.DefaultCellStyle = dataGridViewCellStyle7;
            this.TeléfonoCliente.FillWeight = 300F;
            this.TeléfonoCliente.HeaderText = "Teléfono";
            this.TeléfonoCliente.Name = "TeléfonoCliente";
            this.TeléfonoCliente.ReadOnly = true;
            this.TeléfonoCliente.Width = 85;
            // 
            // DirecciónCliente
            // 
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.DirecciónCliente.DefaultCellStyle = dataGridViewCellStyle8;
            this.DirecciónCliente.HeaderText = "Dirección";
            this.DirecciónCliente.Name = "DirecciónCliente";
            this.DirecciónCliente.ReadOnly = true;
            this.DirecciónCliente.Width = 164;
            // 
            // EstadoCliente
            // 
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.EstadoCliente.DefaultCellStyle = dataGridViewCellStyle9;
            this.EstadoCliente.HeaderText = "Estado";
            this.EstadoCliente.Name = "EstadoCliente";
            this.EstadoCliente.ReadOnly = true;
            this.EstadoCliente.Width = 65;
            // 
            // PanelHorizontal
            // 
            this.PanelHorizontal.BackColor = System.Drawing.Color.MediumTurquoise;
            this.PanelHorizontal.Controls.Add(this.LblTituloVentana);
            this.PanelHorizontal.Controls.Add(this.PicIconoVentana);
            this.PanelHorizontal.Controls.Add(this.BtnRestaurar);
            this.PanelHorizontal.Controls.Add(this.BtnMaximizar);
            this.PanelHorizontal.Controls.Add(this.BtnMinimizar);
            this.PanelHorizontal.Controls.Add(this.BtnSalirBarra);
            this.PanelHorizontal.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHorizontal.Location = new System.Drawing.Point(0, 0);
            this.PanelHorizontal.Name = "PanelHorizontal";
            this.PanelHorizontal.Size = new System.Drawing.Size(766, 25);
            this.PanelHorizontal.TabIndex = 3;
            this.PanelHorizontal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelHorizontal_MouseDown);
            // 
            // LblTituloVentana
            // 
            this.LblTituloVentana.AutoSize = true;
            this.LblTituloVentana.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloVentana.Location = new System.Drawing.Point(39, 4);
            this.LblTituloVentana.Name = "LblTituloVentana";
            this.LblTituloVentana.Size = new System.Drawing.Size(59, 16);
            this.LblTituloVentana.TabIndex = 7;
            this.LblTituloVentana.Text = "Clientes";
            // 
            // PicIconoVentana
            // 
            this.PicIconoVentana.Image = ((System.Drawing.Image)(resources.GetObject("PicIconoVentana.Image")));
            this.PicIconoVentana.Location = new System.Drawing.Point(5, 4);
            this.PicIconoVentana.Name = "PicIconoVentana";
            this.PicIconoVentana.Size = new System.Drawing.Size(31, 20);
            this.PicIconoVentana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicIconoVentana.TabIndex = 6;
            this.PicIconoVentana.TabStop = false;
            // 
            // BtnRestaurar
            // 
            this.BtnRestaurar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("BtnRestaurar.Image")));
            this.BtnRestaurar.Location = new System.Drawing.Point(688, 3);
            this.BtnRestaurar.Name = "BtnRestaurar";
            this.BtnRestaurar.Size = new System.Drawing.Size(36, 18);
            this.BtnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnRestaurar.TabIndex = 3;
            this.BtnRestaurar.TabStop = false;
            // 
            // BtnMaximizar
            // 
            this.BtnMaximizar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnMaximizar.Image")));
            this.BtnMaximizar.Location = new System.Drawing.Point(688, 3);
            this.BtnMaximizar.Name = "BtnMaximizar";
            this.BtnMaximizar.Size = new System.Drawing.Size(36, 18);
            this.BtnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMaximizar.TabIndex = 2;
            this.BtnMaximizar.TabStop = false;
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnMinimizar.Image")));
            this.BtnMinimizar.Location = new System.Drawing.Point(655, 1);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(27, 21);
            this.BtnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnMinimizar.TabIndex = 1;
            this.BtnMinimizar.TabStop = false;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // BtnSalirBarra
            // 
            this.BtnSalirBarra.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnSalirBarra.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalirBarra.Image")));
            this.BtnSalirBarra.Location = new System.Drawing.Point(730, 3);
            this.BtnSalirBarra.Name = "BtnSalirBarra";
            this.BtnSalirBarra.Size = new System.Drawing.Size(36, 18);
            this.BtnSalirBarra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnSalirBarra.TabIndex = 0;
            this.BtnSalirBarra.TabStop = false;
            this.BtnSalirBarra.Click += new System.EventHandler(this.BtnSalirBarra_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.White;
            this.BtnSalir.FlatAppearance.BorderSize = 2;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Image")));
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalir.Location = new System.Drawing.Point(644, 335);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(110, 40);
            this.BtnSalir.TabIndex = 6;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnAgregarCliente
            // 
            this.BtnAgregarCliente.BackColor = System.Drawing.Color.White;
            this.BtnAgregarCliente.FlatAppearance.BorderSize = 2;
            this.BtnAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarCliente.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgregarCliente.Image")));
            this.BtnAgregarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregarCliente.Location = new System.Drawing.Point(12, 335);
            this.BtnAgregarCliente.Name = "BtnAgregarCliente";
            this.BtnAgregarCliente.Size = new System.Drawing.Size(110, 40);
            this.BtnAgregarCliente.TabIndex = 7;
            this.BtnAgregarCliente.Text = "Agregar";
            this.BtnAgregarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAgregarCliente.UseVisualStyleBackColor = false;
            this.BtnAgregarCliente.Click += new System.EventHandler(this.BtnAgregarCliente_Click);
            // 
            // BtnEliminarCliente
            // 
            this.BtnEliminarCliente.BackColor = System.Drawing.Color.White;
            this.BtnEliminarCliente.FlatAppearance.BorderSize = 2;
            this.BtnEliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarCliente.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminarCliente.Image")));
            this.BtnEliminarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminarCliente.Location = new System.Drawing.Point(270, 335);
            this.BtnEliminarCliente.Name = "BtnEliminarCliente";
            this.BtnEliminarCliente.Size = new System.Drawing.Size(110, 40);
            this.BtnEliminarCliente.TabIndex = 8;
            this.BtnEliminarCliente.Text = "Eliminar";
            this.BtnEliminarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEliminarCliente.UseVisualStyleBackColor = false;
            this.BtnEliminarCliente.Click += new System.EventHandler(this.BtnEliminarCliente_Click);
            // 
            // BtnModificarCliente
            // 
            this.BtnModificarCliente.BackColor = System.Drawing.Color.White;
            this.BtnModificarCliente.FlatAppearance.BorderSize = 2;
            this.BtnModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificarCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarCliente.Image = ((System.Drawing.Image)(resources.GetObject("BtnModificarCliente.Image")));
            this.BtnModificarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModificarCliente.Location = new System.Drawing.Point(139, 335);
            this.BtnModificarCliente.Name = "BtnModificarCliente";
            this.BtnModificarCliente.Size = new System.Drawing.Size(110, 40);
            this.BtnModificarCliente.TabIndex = 9;
            this.BtnModificarCliente.Text = "Modificar";
            this.BtnModificarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnModificarCliente.UseVisualStyleBackColor = false;
            this.BtnModificarCliente.Click += new System.EventHandler(this.BtnModificarCliente_Click);
            // 
            // BtnConsultarCliente
            // 
            this.BtnConsultarCliente.BackColor = System.Drawing.Color.White;
            this.BtnConsultarCliente.FlatAppearance.BorderSize = 2;
            this.BtnConsultarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultarCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultarCliente.Image = ((System.Drawing.Image)(resources.GetObject("BtnConsultarCliente.Image")));
            this.BtnConsultarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsultarCliente.Location = new System.Drawing.Point(644, 43);
            this.BtnConsultarCliente.Name = "BtnConsultarCliente";
            this.BtnConsultarCliente.Size = new System.Drawing.Size(110, 40);
            this.BtnConsultarCliente.TabIndex = 10;
            this.BtnConsultarCliente.Text = "Consultar";
            this.BtnConsultarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConsultarCliente.UseVisualStyleBackColor = false;
            this.BtnConsultarCliente.Click += new System.EventHandler(this.BtnConsultarCliente_Click);
            // 
            // TxtDniCliente
            // 
            this.TxtDniCliente.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.TxtDniCliente.Location = new System.Drawing.Point(477, 49);
            this.TxtDniCliente.Name = "TxtDniCliente";
            this.TxtDniCliente.Size = new System.Drawing.Size(161, 30);
            this.TxtDniCliente.TabIndex = 12;
            this.TxtDniCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDniCliente_KeyPress);
            // 
            // CkMostrarTodos
            // 
            this.CkMostrarTodos.AutoSize = true;
            this.CkMostrarTodos.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CkMostrarTodos.Location = new System.Drawing.Point(488, 84);
            this.CkMostrarTodos.Name = "CkMostrarTodos";
            this.CkMostrarTodos.Size = new System.Drawing.Size(137, 23);
            this.CkMostrarTodos.TabIndex = 13;
            this.CkMostrarTodos.Text = "Mostrar todos";
            this.CkMostrarTodos.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tipo y número documento:";
            // 
            // CbTipoDocumentoCliente
            // 
            this.CbTipoDocumentoCliente.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.CbTipoDocumentoCliente.FormattingEnabled = true;
            this.CbTipoDocumentoCliente.Location = new System.Drawing.Point(332, 49);
            this.CbTipoDocumentoCliente.Name = "CbTipoDocumentoCliente";
            this.CbTipoDocumentoCliente.Size = new System.Drawing.Size(139, 30);
            this.CbTipoDocumentoCliente.TabIndex = 64;
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(766, 389);
            this.Controls.Add(this.CbTipoDocumentoCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CkMostrarTodos);
            this.Controls.Add(this.TxtDniCliente);
            this.Controls.Add(this.BtnConsultarCliente);
            this.Controls.Add(this.BtnModificarCliente);
            this.Controls.Add(this.BtnEliminarCliente);
            this.Controls.Add(this.BtnAgregarCliente);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.PanelHorizontal);
            this.Controls.Add(this.DgvClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).EndInit();
            this.PanelHorizontal.ResumeLayout(false);
            this.PanelHorizontal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicIconoVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalirBarra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvClientes;
        private System.Windows.Forms.Panel PanelHorizontal;
        private System.Windows.Forms.Label LblTituloVentana;
        private System.Windows.Forms.PictureBox PicIconoVentana;
        private System.Windows.Forms.PictureBox BtnRestaurar;
        private System.Windows.Forms.PictureBox BtnMaximizar;
        private System.Windows.Forms.PictureBox BtnMinimizar;
        private System.Windows.Forms.PictureBox BtnSalirBarra;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnAgregarCliente;
        private System.Windows.Forms.Button BtnEliminarCliente;
        private System.Windows.Forms.Button BtnModificarCliente;
        private System.Windows.Forms.Button BtnConsultarCliente;
        private System.Windows.Forms.TextBox TxtDniCliente;
        private System.Windows.Forms.CheckBox CkMostrarTodos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbTipoDocumentoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeléfonoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DirecciónCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoCliente;
    }
}