
namespace ForrajeriaProyecto.InterfacesUsuario.Presupuestos
{
    partial class FrmAgregarPresupuesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarPresupuesto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelHorizontal = new System.Windows.Forms.Panel();
            this.LblTituloVentana = new System.Windows.Forms.Label();
            this.PicIconoVentana = new System.Windows.Forms.PictureBox();
            this.BtnRestaurar = new System.Windows.Forms.PictureBox();
            this.BtnMaximizar = new System.Windows.Forms.PictureBox();
            this.BtnMinimizar = new System.Windows.Forms.PictureBox();
            this.BtnSalirBarra = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnEliminarFila = new System.Windows.Forms.Button();
            this.BtnRegistrarPresupuesto = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAgregarProducto = new System.Windows.Forms.Button();
            this.BuscarProducto = new System.Windows.Forms.Button();
            this.LblMonto = new System.Windows.Forms.Label();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.TxtMontoTotal = new System.Windows.Forms.TextBox();
            this.TxtIDProducto = new System.Windows.Forms.TextBox();
            this.LblProductos = new System.Windows.Forms.Label();
            this.DgvDetallePresupuesto = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtOrden = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtFechaVenta = new System.Windows.Forms.TextBox();
            this.LblFecha = new System.Windows.Forms.Label();
            this.CBClientes = new System.Windows.Forms.ComboBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.BtnAgregarCliente = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TxtNroPresupuesto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtFechaDía = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CBCliente = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PanelHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicIconoVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalirBarra)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetallePresupuesto)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
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
            this.PanelHorizontal.Size = new System.Drawing.Size(773, 25);
            this.PanelHorizontal.TabIndex = 94;
            this.PanelHorizontal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelHorizontal_MouseDown);
            // 
            // LblTituloVentana
            // 
            this.LblTituloVentana.AutoSize = true;
            this.LblTituloVentana.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloVentana.Location = new System.Drawing.Point(39, 4);
            this.LblTituloVentana.Name = "LblTituloVentana";
            this.LblTituloVentana.Size = new System.Drawing.Size(143, 16);
            this.LblTituloVentana.TabIndex = 7;
            this.LblTituloVentana.Text = "Agregar presupuesto";
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
            this.BtnRestaurar.Location = new System.Drawing.Point(695, 3);
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
            this.BtnMaximizar.Location = new System.Drawing.Point(695, 3);
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
            this.BtnMinimizar.Location = new System.Drawing.Point(662, 1);
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
            this.BtnSalirBarra.Location = new System.Drawing.Point(737, 3);
            this.BtnSalirBarra.Name = "BtnSalirBarra";
            this.BtnSalirBarra.Size = new System.Drawing.Size(36, 18);
            this.BtnSalirBarra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnSalirBarra.TabIndex = 0;
            this.BtnSalirBarra.TabStop = false;
            this.BtnSalirBarra.Click += new System.EventHandler(this.BtnSalirBarra_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnEliminarFila);
            this.groupBox3.Controls.Add(this.BtnRegistrarPresupuesto);
            this.groupBox3.Controls.Add(this.BtnCancelar);
            this.groupBox3.Controls.Add(this.BtnAgregarProducto);
            this.groupBox3.Controls.Add(this.BuscarProducto);
            this.groupBox3.Controls.Add(this.LblMonto);
            this.groupBox3.Controls.Add(this.LblCantidad);
            this.groupBox3.Controls.Add(this.TxtMontoTotal);
            this.groupBox3.Controls.Add(this.TxtIDProducto);
            this.groupBox3.Controls.Add(this.LblProductos);
            this.groupBox3.Controls.Add(this.DgvDetallePresupuesto);
            this.groupBox3.Controls.Add(this.TxtCantidad);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(18, 101);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(745, 494);
            this.groupBox3.TabIndex = 93;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalle presupuesto:";
            // 
            // BtnEliminarFila
            // 
            this.BtnEliminarFila.BackColor = System.Drawing.Color.White;
            this.BtnEliminarFila.FlatAppearance.BorderSize = 2;
            this.BtnEliminarFila.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarFila.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.BtnEliminarFila.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminarFila.Image")));
            this.BtnEliminarFila.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminarFila.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnEliminarFila.Location = new System.Drawing.Point(558, 15);
            this.BtnEliminarFila.Name = "BtnEliminarFila";
            this.BtnEliminarFila.Size = new System.Drawing.Size(181, 37);
            this.BtnEliminarFila.TabIndex = 96;
            this.BtnEliminarFila.Text = "Quitar producto";
            this.BtnEliminarFila.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEliminarFila.UseVisualStyleBackColor = false;
            this.BtnEliminarFila.Click += new System.EventHandler(this.BtnEliminarFila_Click);
            // 
            // BtnRegistrarPresupuesto
            // 
            this.BtnRegistrarPresupuesto.BackColor = System.Drawing.Color.White;
            this.BtnRegistrarPresupuesto.FlatAppearance.BorderSize = 2;
            this.BtnRegistrarPresupuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrarPresupuesto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.BtnRegistrarPresupuesto.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegistrarPresupuesto.Image")));
            this.BtnRegistrarPresupuesto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegistrarPresupuesto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnRegistrarPresupuesto.Location = new System.Drawing.Point(629, 429);
            this.BtnRegistrarPresupuesto.Name = "BtnRegistrarPresupuesto";
            this.BtnRegistrarPresupuesto.Size = new System.Drawing.Size(110, 47);
            this.BtnRegistrarPresupuesto.TabIndex = 89;
            this.BtnRegistrarPresupuesto.Text = "Registrar";
            this.BtnRegistrarPresupuesto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRegistrarPresupuesto.UseVisualStyleBackColor = false;
            this.BtnRegistrarPresupuesto.Click += new System.EventHandler(this.BtnRegistrarPresupuesto_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.White;
            this.BtnCancelar.FlatAppearance.BorderSize = 2;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.BtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.Image")));
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnCancelar.Location = new System.Drawing.Point(484, 429);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(110, 47);
            this.BtnCancelar.TabIndex = 86;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAgregarProducto
            // 
            this.BtnAgregarProducto.BackColor = System.Drawing.Color.White;
            this.BtnAgregarProducto.FlatAppearance.BorderSize = 2;
            this.BtnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarProducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.BtnAgregarProducto.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgregarProducto.Image")));
            this.BtnAgregarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregarProducto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnAgregarProducto.Location = new System.Drawing.Point(372, 13);
            this.BtnAgregarProducto.Name = "BtnAgregarProducto";
            this.BtnAgregarProducto.Size = new System.Drawing.Size(180, 40);
            this.BtnAgregarProducto.TabIndex = 79;
            this.BtnAgregarProducto.Text = "Agregar Producto";
            this.BtnAgregarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAgregarProducto.UseVisualStyleBackColor = false;
            this.BtnAgregarProducto.Click += new System.EventHandler(this.BtnAgregarProducto_Click_1);
            // 
            // BuscarProducto
            // 
            this.BuscarProducto.BackColor = System.Drawing.Color.White;
            this.BuscarProducto.FlatAppearance.BorderSize = 2;
            this.BuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuscarProducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.BuscarProducto.Image = ((System.Drawing.Image)(resources.GetObject("BuscarProducto.Image")));
            this.BuscarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarProducto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BuscarProducto.Location = new System.Drawing.Point(177, 15);
            this.BuscarProducto.Name = "BuscarProducto";
            this.BuscarProducto.Size = new System.Drawing.Size(33, 38);
            this.BuscarProducto.TabIndex = 87;
            this.BuscarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarProducto.UseVisualStyleBackColor = false;
            this.BuscarProducto.Click += new System.EventHandler(this.BuscarProducto_Click);
            // 
            // LblMonto
            // 
            this.LblMonto.AutoSize = true;
            this.LblMonto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMonto.Location = new System.Drawing.Point(474, 388);
            this.LblMonto.Name = "LblMonto";
            this.LblMonto.Size = new System.Drawing.Size(152, 23);
            this.LblMonto.TabIndex = 41;
            this.LblMonto.Text = "Monto Total ($):";
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.LblCantidad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblCantidad.Location = new System.Drawing.Point(216, 23);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(104, 23);
            this.LblCantidad.TabIndex = 55;
            this.LblCantidad.Text = "Cantidad:";
            // 
            // TxtMontoTotal
            // 
            this.TxtMontoTotal.Enabled = false;
            this.TxtMontoTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMontoTotal.Location = new System.Drawing.Point(630, 387);
            this.TxtMontoTotal.Name = "TxtMontoTotal";
            this.TxtMontoTotal.ReadOnly = true;
            this.TxtMontoTotal.Size = new System.Drawing.Size(109, 27);
            this.TxtMontoTotal.TabIndex = 42;
            this.TxtMontoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtIDProducto
            // 
            this.TxtIDProducto.Enabled = false;
            this.TxtIDProducto.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.TxtIDProducto.Location = new System.Drawing.Point(131, 19);
            this.TxtIDProducto.Name = "TxtIDProducto";
            this.TxtIDProducto.Size = new System.Drawing.Size(40, 30);
            this.TxtIDProducto.TabIndex = 84;
            this.TxtIDProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblProductos
            // 
            this.LblProductos.AutoSize = true;
            this.LblProductos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.LblProductos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblProductos.Location = new System.Drawing.Point(6, 23);
            this.LblProductos.Name = "LblProductos";
            this.LblProductos.Size = new System.Drawing.Size(123, 23);
            this.LblProductos.TabIndex = 53;
            this.LblProductos.Text = "Id producto:";
            // 
            // DgvDetallePresupuesto
            // 
            this.DgvDetallePresupuesto.AllowUserToAddRows = false;
            this.DgvDetallePresupuesto.AllowUserToDeleteRows = false;
            this.DgvDetallePresupuesto.BackgroundColor = System.Drawing.Color.White;
            this.DgvDetallePresupuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDetallePresupuesto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Producto,
            this.PrecioUnitario,
            this.Cantidad,
            this.Subtotal});
            this.DgvDetallePresupuesto.Location = new System.Drawing.Point(6, 59);
            this.DgvDetallePresupuesto.Name = "DgvDetallePresupuesto";
            this.DgvDetallePresupuesto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDetallePresupuesto.Size = new System.Drawing.Size(733, 311);
            this.DgvDetallePresupuesto.TabIndex = 43;
            // 
            // ID
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.ID.DefaultCellStyle = dataGridViewCellStyle1;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 51;
            // 
            // Producto
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.Producto.DefaultCellStyle = dataGridViewCellStyle2;
            this.Producto.FillWeight = 200F;
            this.Producto.HeaderText = "Nombre de producto";
            this.Producto.MinimumWidth = 50;
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 297;
            // 
            // PrecioUnitario
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.PrecioUnitario.DefaultCellStyle = dataGridViewCellStyle3;
            this.PrecioUnitario.HeaderText = "Precio Unitario";
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.ReadOnly = true;
            this.PrecioUnitario.Width = 142;
            // 
            // Cantidad
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle4;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Subtotal
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.Subtotal.DefaultCellStyle = dataGridViewCellStyle5;
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.TxtCantidad.Location = new System.Drawing.Point(320, 19);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(40, 30);
            this.TxtCantidad.TabIndex = 88;
            this.TxtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCantidad_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtOrden);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TxtFechaVenta);
            this.groupBox2.Controls.Add(this.LblFecha);
            this.groupBox2.Controls.Add(this.CBClientes);
            this.groupBox2.Controls.Add(this.LblNombre);
            this.groupBox2.Controls.Add(this.BtnAgregarCliente);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(18, -37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(710, 62);
            this.groupBox2.TabIndex = 92;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos venta:";
            // 
            // TxtOrden
            // 
            this.TxtOrden.Enabled = false;
            this.TxtOrden.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOrden.Location = new System.Drawing.Point(245, 23);
            this.TxtOrden.Name = "TxtOrden";
            this.TxtOrden.ReadOnly = true;
            this.TxtOrden.Size = new System.Drawing.Size(25, 27);
            this.TxtOrden.TabIndex = 53;
            this.TxtOrden.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(149, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 54;
            this.label1.Text = "Nro Orden:";
            // 
            // TxtFechaVenta
            // 
            this.TxtFechaVenta.Enabled = false;
            this.TxtFechaVenta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFechaVenta.Location = new System.Drawing.Point(66, 24);
            this.TxtFechaVenta.Name = "TxtFechaVenta";
            this.TxtFechaVenta.ReadOnly = true;
            this.TxtFechaVenta.Size = new System.Drawing.Size(84, 27);
            this.TxtFechaVenta.TabIndex = 39;
            this.TxtFechaVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Century Gothic", 13.25F, System.Drawing.FontStyle.Bold);
            this.LblFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblFecha.Location = new System.Drawing.Point(1, 25);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(71, 22);
            this.LblFecha.TabIndex = 38;
            this.LblFecha.Text = "Fecha:";
            // 
            // CBClientes
            // 
            this.CBClientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBClientes.FormattingEnabled = true;
            this.CBClientes.Location = new System.Drawing.Point(339, 22);
            this.CBClientes.Name = "CBClientes";
            this.CBClientes.Size = new System.Drawing.Size(203, 29);
            this.CBClientes.TabIndex = 37;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Century Gothic", 13.25F, System.Drawing.FontStyle.Bold);
            this.LblNombre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblNombre.Location = new System.Drawing.Point(268, 25);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(77, 22);
            this.LblNombre.TabIndex = 36;
            this.LblNombre.Text = "Cliente:";
            // 
            // BtnAgregarCliente
            // 
            this.BtnAgregarCliente.BackColor = System.Drawing.Color.White;
            this.BtnAgregarCliente.FlatAppearance.BorderSize = 2;
            this.BtnAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.BtnAgregarCliente.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgregarCliente.Image")));
            this.BtnAgregarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregarCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnAgregarCliente.Location = new System.Drawing.Point(544, 15);
            this.BtnAgregarCliente.Name = "BtnAgregarCliente";
            this.BtnAgregarCliente.Size = new System.Drawing.Size(159, 40);
            this.BtnAgregarCliente.TabIndex = 52;
            this.BtnAgregarCliente.Text = "Agregar Cliente";
            this.BtnAgregarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAgregarCliente.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TxtNroPresupuesto);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.TxtFechaDía);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.CBCliente);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(18, 33);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(745, 62);
            this.groupBox4.TabIndex = 95;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos presupuesto:";
            // 
            // TxtNroPresupuesto
            // 
            this.TxtNroPresupuesto.Enabled = false;
            this.TxtNroPresupuesto.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.TxtNroPresupuesto.Location = new System.Drawing.Point(81, 22);
            this.TxtNroPresupuesto.Name = "TxtNroPresupuesto";
            this.TxtNroPresupuesto.Size = new System.Drawing.Size(40, 30);
            this.TxtNroPresupuesto.TabIndex = 90;
            this.TxtNroPresupuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(28, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 23);
            this.label2.TabIndex = 53;
            this.label2.Text = "Nro:";
            // 
            // TxtFechaDía
            // 
            this.TxtFechaDía.Enabled = false;
            this.TxtFechaDía.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.TxtFechaDía.Location = new System.Drawing.Point(239, 22);
            this.TxtFechaDía.Name = "TxtFechaDía";
            this.TxtFechaDía.ReadOnly = true;
            this.TxtFechaDía.Size = new System.Drawing.Size(106, 30);
            this.TxtFechaDía.TabIndex = 39;
            this.TxtFechaDía.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(161, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 38;
            this.label3.Text = "Fecha:";
            // 
            // CBCliente
            // 
            this.CBCliente.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.CBCliente.FormattingEnabled = true;
            this.CBCliente.Location = new System.Drawing.Point(439, 22);
            this.CBCliente.Name = "CBCliente";
            this.CBCliente.Size = new System.Drawing.Size(300, 30);
            this.CBCliente.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(352, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 23);
            this.label4.TabIndex = 36;
            this.label4.Text = "Cliente:";
            // 
            // FrmAgregarPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(773, 607);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.PanelHorizontal);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(773, 607);
            this.MinimumSize = new System.Drawing.Size(773, 607);
            this.Name = "FrmAgregarPresupuesto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgregarPresupuesto";
            this.Load += new System.EventHandler(this.FrmAgregarPresupuesto_Load);
            this.PanelHorizontal.ResumeLayout(false);
            this.PanelHorizontal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicIconoVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalirBarra)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetallePresupuesto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelHorizontal;
        private System.Windows.Forms.Label LblTituloVentana;
        private System.Windows.Forms.PictureBox PicIconoVentana;
        private System.Windows.Forms.PictureBox BtnRestaurar;
        private System.Windows.Forms.PictureBox BtnMaximizar;
        private System.Windows.Forms.PictureBox BtnMinimizar;
        private System.Windows.Forms.PictureBox BtnSalirBarra;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnRegistrarPresupuesto;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAgregarProducto;
        private System.Windows.Forms.Button BuscarProducto;
        private System.Windows.Forms.Label LblMonto;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.TextBox TxtMontoTotal;
        public System.Windows.Forms.TextBox TxtIDProducto;
        private System.Windows.Forms.Label LblProductos;
        private System.Windows.Forms.DataGridView DgvDetallePresupuesto;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtOrden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtFechaVenta;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.ComboBox CBClientes;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Button BtnAgregarCliente;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox TxtFechaDía;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBCliente;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox TxtNroPresupuesto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnEliminarFila;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
    }
}