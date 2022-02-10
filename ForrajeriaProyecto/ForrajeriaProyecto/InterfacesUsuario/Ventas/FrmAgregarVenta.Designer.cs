
namespace ForrajeriaProyecto.InterfacesUsuario.Ventas
{
    partial class FrmAgregarVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarVenta));
            this.LblNombre = new System.Windows.Forms.Label();
            this.CBClientes = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RbTarjeta = new System.Windows.Forms.RadioButton();
            this.RbEfectivo = new System.Windows.Forms.RadioButton();
            this.TxtMontoTotal = new System.Windows.Forms.TextBox();
            this.LblMonto = new System.Windows.Forms.Label();
            this.DgvDetalleVenta = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblProductos = new System.Windows.Forms.Label();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.BtnAgregarProducto = new System.Windows.Forms.Button();
            this.TxtIDProducto = new System.Windows.Forms.TextBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BuscarProducto = new System.Windows.Forms.Button();
            this.LblFecha = new System.Windows.Forms.Label();
            this.TxtFechaVenta = new System.Windows.Forms.TextBox();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtOrden = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnEliminarFila = new System.Windows.Forms.Button();
            this.BtnRegistrarVenta = new System.Windows.Forms.Button();
            this.PanelHorizontal = new System.Windows.Forms.Panel();
            this.LblTituloVentana = new System.Windows.Forms.Label();
            this.PicIconoVentana = new System.Windows.Forms.PictureBox();
            this.BtnRestaurar = new System.Windows.Forms.PictureBox();
            this.BtnMaximizar = new System.Windows.Forms.PictureBox();
            this.BtnMinimizar = new System.Windows.Forms.PictureBox();
            this.BtnSalirBarra = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalleVenta)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.PanelHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicIconoVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalirBarra)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.LblNombre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblNombre.Location = new System.Drawing.Point(392, 23);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(81, 23);
            this.LblNombre.TabIndex = 36;
            this.LblNombre.Text = "Cliente:";
            // 
            // CBClientes
            // 
            this.CBClientes.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.CBClientes.FormattingEnabled = true;
            this.CBClientes.Location = new System.Drawing.Point(479, 21);
            this.CBClientes.Name = "CBClientes";
            this.CBClientes.Size = new System.Drawing.Size(269, 30);
            this.CBClientes.TabIndex = 37;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RbTarjeta);
            this.groupBox1.Controls.Add(this.RbEfectivo);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 384);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 64);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de cobro:";
            // 
            // RbTarjeta
            // 
            this.RbTarjeta.AutoSize = true;
            this.RbTarjeta.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbTarjeta.Location = new System.Drawing.Point(159, 26);
            this.RbTarjeta.Name = "RbTarjeta";
            this.RbTarjeta.Size = new System.Drawing.Size(91, 27);
            this.RbTarjeta.TabIndex = 1;
            this.RbTarjeta.TabStop = true;
            this.RbTarjeta.Text = "Tarjeta";
            this.RbTarjeta.UseVisualStyleBackColor = true;
            // 
            // RbEfectivo
            // 
            this.RbEfectivo.AllowDrop = true;
            this.RbEfectivo.AutoSize = true;
            this.RbEfectivo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbEfectivo.Location = new System.Drawing.Point(20, 26);
            this.RbEfectivo.Name = "RbEfectivo";
            this.RbEfectivo.Size = new System.Drawing.Size(110, 27);
            this.RbEfectivo.TabIndex = 0;
            this.RbEfectivo.TabStop = true;
            this.RbEfectivo.Text = "Contado";
            this.RbEfectivo.UseVisualStyleBackColor = true;
            // 
            // TxtMontoTotal
            // 
            this.TxtMontoTotal.Enabled = false;
            this.TxtMontoTotal.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.TxtMontoTotal.Location = new System.Drawing.Point(638, 384);
            this.TxtMontoTotal.Name = "TxtMontoTotal";
            this.TxtMontoTotal.ReadOnly = true;
            this.TxtMontoTotal.Size = new System.Drawing.Size(109, 30);
            this.TxtMontoTotal.TabIndex = 42;
            this.TxtMontoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblMonto
            // 
            this.LblMonto.AutoSize = true;
            this.LblMonto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMonto.Location = new System.Drawing.Point(483, 390);
            this.LblMonto.Name = "LblMonto";
            this.LblMonto.Size = new System.Drawing.Size(152, 23);
            this.LblMonto.TabIndex = 41;
            this.LblMonto.Text = "Monto Total ($):";
            // 
            // DgvDetalleVenta
            // 
            this.DgvDetalleVenta.AllowUserToAddRows = false;
            this.DgvDetalleVenta.BackgroundColor = System.Drawing.Color.White;
            this.DgvDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDetalleVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Producto,
            this.PrecioUnitario,
            this.Cantidad,
            this.Subtotal});
            this.DgvDetalleVenta.Location = new System.Drawing.Point(6, 59);
            this.DgvDetalleVenta.Name = "DgvDetalleVenta";
            this.DgvDetalleVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDetalleVenta.Size = new System.Drawing.Size(742, 311);
            this.DgvDetalleVenta.TabIndex = 43;
            // 
            // ID
            // 
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.ID.DefaultCellStyle = dataGridViewCellStyle11;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 53;
            // 
            // Producto
            // 
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.Producto.DefaultCellStyle = dataGridViewCellStyle12;
            this.Producto.FillWeight = 200F;
            this.Producto.HeaderText = "Nombre de producto";
            this.Producto.MinimumWidth = 50;
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 303;
            // 
            // PrecioUnitario
            // 
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.PrecioUnitario.DefaultCellStyle = dataGridViewCellStyle13;
            this.PrecioUnitario.HeaderText = "Precio Unitario";
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.ReadOnly = true;
            this.PrecioUnitario.Width = 142;
            // 
            // Cantidad
            // 
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle14;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Subtotal
            // 
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.Subtotal.DefaultCellStyle = dataGridViewCellStyle15;
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // LblProductos
            // 
            this.LblProductos.AutoSize = true;
            this.LblProductos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.LblProductos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblProductos.Location = new System.Drawing.Point(8, 23);
            this.LblProductos.Name = "LblProductos";
            this.LblProductos.Size = new System.Drawing.Size(123, 23);
            this.LblProductos.TabIndex = 53;
            this.LblProductos.Text = "Id producto:";
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.LblCantidad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblCantidad.Location = new System.Drawing.Point(224, 23);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(104, 23);
            this.LblCantidad.TabIndex = 55;
            this.LblCantidad.Text = "Cantidad:";
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
            this.BtnAgregarProducto.Location = new System.Drawing.Point(382, 15);
            this.BtnAgregarProducto.Name = "BtnAgregarProducto";
            this.BtnAgregarProducto.Size = new System.Drawing.Size(180, 40);
            this.BtnAgregarProducto.TabIndex = 79;
            this.BtnAgregarProducto.Text = "Agregar producto";
            this.BtnAgregarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAgregarProducto.UseVisualStyleBackColor = false;
            this.BtnAgregarProducto.Click += new System.EventHandler(this.BtnAgregarProducto_Click);
            // 
            // TxtIDProducto
            // 
            this.TxtIDProducto.Enabled = false;
            this.TxtIDProducto.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.TxtIDProducto.Location = new System.Drawing.Point(133, 19);
            this.TxtIDProducto.Name = "TxtIDProducto";
            this.TxtIDProducto.Size = new System.Drawing.Size(40, 30);
            this.TxtIDProducto.TabIndex = 84;
            this.TxtIDProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.BtnCancelar.Location = new System.Drawing.Point(493, 431);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(110, 47);
            this.BtnCancelar.TabIndex = 86;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
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
            this.BuscarProducto.Location = new System.Drawing.Point(185, 15);
            this.BuscarProducto.Name = "BuscarProducto";
            this.BuscarProducto.Size = new System.Drawing.Size(33, 38);
            this.BuscarProducto.TabIndex = 87;
            this.BuscarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarProducto.UseVisualStyleBackColor = false;
            this.BuscarProducto.Click += new System.EventHandler(this.BuscarProducto_Click);
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.LblFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblFecha.Location = new System.Drawing.Point(40, 24);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(72, 23);
            this.LblFecha.TabIndex = 38;
            this.LblFecha.Text = "Fecha:";
            // 
            // TxtFechaVenta
            // 
            this.TxtFechaVenta.Enabled = false;
            this.TxtFechaVenta.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.TxtFechaVenta.Location = new System.Drawing.Point(109, 20);
            this.TxtFechaVenta.Name = "TxtFechaVenta";
            this.TxtFechaVenta.ReadOnly = true;
            this.TxtFechaVenta.Size = new System.Drawing.Size(109, 30);
            this.TxtFechaVenta.TabIndex = 39;
            this.TxtFechaVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.TxtCantidad.Location = new System.Drawing.Point(330, 19);
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
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(18, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(757, 62);
            this.groupBox2.TabIndex = 89;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos venta:";
            // 
            // TxtOrden
            // 
            this.TxtOrden.Enabled = false;
            this.TxtOrden.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.TxtOrden.Location = new System.Drawing.Point(334, 20);
            this.TxtOrden.Name = "TxtOrden";
            this.TxtOrden.ReadOnly = true;
            this.TxtOrden.Size = new System.Drawing.Size(40, 30);
            this.TxtOrden.TabIndex = 53;
            this.TxtOrden.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(224, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 23);
            this.label1.TabIndex = 54;
            this.label1.Text = "Nro Orden:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnEliminarFila);
            this.groupBox3.Controls.Add(this.BtnRegistrarVenta);
            this.groupBox3.Controls.Add(this.BtnCancelar);
            this.groupBox3.Controls.Add(this.BtnAgregarProducto);
            this.groupBox3.Controls.Add(this.BuscarProducto);
            this.groupBox3.Controls.Add(this.LblMonto);
            this.groupBox3.Controls.Add(this.LblCantidad);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.TxtMontoTotal);
            this.groupBox3.Controls.Add(this.TxtIDProducto);
            this.groupBox3.Controls.Add(this.LblProductos);
            this.groupBox3.Controls.Add(this.DgvDetalleVenta);
            this.groupBox3.Controls.Add(this.TxtCantidad);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(18, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(757, 487);
            this.groupBox3.TabIndex = 90;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalle venta";
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
            this.BtnEliminarFila.Location = new System.Drawing.Point(568, 15);
            this.BtnEliminarFila.Name = "BtnEliminarFila";
            this.BtnEliminarFila.Size = new System.Drawing.Size(180, 40);
            this.BtnEliminarFila.TabIndex = 93;
            this.BtnEliminarFila.Text = "Quitar producto";
            this.BtnEliminarFila.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnEliminarFila.UseVisualStyleBackColor = false;
            this.BtnEliminarFila.Click += new System.EventHandler(this.BtnEliminarFila_Click);
            // 
            // BtnRegistrarVenta
            // 
            this.BtnRegistrarVenta.BackColor = System.Drawing.Color.White;
            this.BtnRegistrarVenta.FlatAppearance.BorderSize = 2;
            this.BtnRegistrarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrarVenta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.BtnRegistrarVenta.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegistrarVenta.Image")));
            this.BtnRegistrarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegistrarVenta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnRegistrarVenta.Location = new System.Drawing.Point(638, 431);
            this.BtnRegistrarVenta.Name = "BtnRegistrarVenta";
            this.BtnRegistrarVenta.Size = new System.Drawing.Size(110, 47);
            this.BtnRegistrarVenta.TabIndex = 89;
            this.BtnRegistrarVenta.Text = "Registrar";
            this.BtnRegistrarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRegistrarVenta.UseVisualStyleBackColor = false;
            this.BtnRegistrarVenta.Click += new System.EventHandler(this.BtnRegistrarVenta_Click);
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
            this.PanelHorizontal.Size = new System.Drawing.Size(784, 25);
            this.PanelHorizontal.TabIndex = 91;
            this.PanelHorizontal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelHorizontal_MouseDown);
            // 
            // LblTituloVentana
            // 
            this.LblTituloVentana.AutoSize = true;
            this.LblTituloVentana.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloVentana.Location = new System.Drawing.Point(39, 4);
            this.LblTituloVentana.Name = "LblTituloVentana";
            this.LblTituloVentana.Size = new System.Drawing.Size(102, 16);
            this.LblTituloVentana.TabIndex = 7;
            this.LblTituloVentana.Text = "Agregar venta";
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
            this.BtnRestaurar.Location = new System.Drawing.Point(706, 3);
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
            this.BtnMaximizar.Location = new System.Drawing.Point(706, 3);
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
            this.BtnMinimizar.Location = new System.Drawing.Point(673, 1);
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
            this.BtnSalirBarra.Location = new System.Drawing.Point(748, 3);
            this.BtnSalirBarra.Name = "BtnSalirBarra";
            this.BtnSalirBarra.Size = new System.Drawing.Size(36, 18);
            this.BtnSalirBarra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnSalirBarra.TabIndex = 0;
            this.BtnSalirBarra.TabStop = false;
            this.BtnSalirBarra.Click += new System.EventHandler(this.BtnSalirBarra_Click);
            // 
            // FrmAgregarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(784, 590);
            this.Controls.Add(this.PanelHorizontal);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(784, 590);
            this.MinimumSize = new System.Drawing.Size(784, 590);
            this.Name = "FrmAgregarVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Venta";
            this.Load += new System.EventHandler(this.FrmAgregarVenta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalleVenta)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.PanelHorizontal.ResumeLayout(false);
            this.PanelHorizontal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicIconoVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalirBarra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.ComboBox CBClientes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RbTarjeta;
        private System.Windows.Forms.RadioButton RbEfectivo;
        private System.Windows.Forms.TextBox TxtMontoTotal;
        private System.Windows.Forms.Label LblMonto;
        private System.Windows.Forms.DataGridView DgvDetalleVenta;
        private System.Windows.Forms.Label LblProductos;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.Button BtnAgregarProducto;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BuscarProducto;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.TextBox TxtFechaVenta;
        private System.Windows.Forms.TextBox TxtCantidad;
        public System.Windows.Forms.TextBox TxtIDProducto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel PanelHorizontal;
        private System.Windows.Forms.Label LblTituloVentana;
        private System.Windows.Forms.PictureBox PicIconoVentana;
        private System.Windows.Forms.PictureBox BtnRestaurar;
        private System.Windows.Forms.PictureBox BtnMaximizar;
        private System.Windows.Forms.PictureBox BtnMinimizar;
        private System.Windows.Forms.PictureBox BtnSalirBarra;
        private System.Windows.Forms.Button BtnRegistrarVenta;
        private System.Windows.Forms.TextBox TxtOrden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEliminarFila;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
    }
}