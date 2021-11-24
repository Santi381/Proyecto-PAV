
namespace Proyecto
{
    partial class AgregarVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarVenta));
            this.DgvDetalleVenta = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Totales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnConfirmarYGenerarFactura = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAgregarProducto = new System.Windows.Forms.Button();
            this.CBoxEfectivo = new System.Windows.Forms.CheckBox();
            this.CBoxTarjeta = new System.Windows.Forms.CheckBox();
            this.LblTipoDePago = new System.Windows.Forms.Label();
            this.LblDetalle = new System.Windows.Forms.Label();
            this.CBProductos = new System.Windows.Forms.ComboBox();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.LblProducto = new System.Windows.Forms.Label();
            this.NUpDownCantidad = new System.Windows.Forms.NumericUpDown();
            this.LblMontoTotal = new System.Windows.Forms.Label();
            this.LblNumMontoTotal = new System.Windows.Forms.Label();
            this.MCVentas = new System.Windows.Forms.MonthCalendar();
            this.LblFecha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalleVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUpDownCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvDetalleVenta
            // 
            this.DgvDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDetalleVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Producto,
            this.PrecioUnitario,
            this.Cantidad,
            this.Totales});
            this.DgvDetalleVenta.Location = new System.Drawing.Point(3, 103);
            this.DgvDetalleVenta.Name = "DgvDetalleVenta";
            this.DgvDetalleVenta.Size = new System.Drawing.Size(690, 369);
            this.DgvDetalleVenta.TabIndex = 0;
            this.DgvDetalleVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // Producto
            // 
            this.Producto.FillWeight = 200F;
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 50;
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 300;
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.HeaderText = "Precio Unitario";
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Totales
            // 
            this.Totales.HeaderText = "Totales";
            this.Totales.Name = "Totales";
            this.Totales.ReadOnly = true;
            // 
            // BtnConfirmarYGenerarFactura
            // 
            this.BtnConfirmarYGenerarFactura.BackColor = System.Drawing.Color.MintCream;
            this.BtnConfirmarYGenerarFactura.Location = new System.Drawing.Point(436, 660);
            this.BtnConfirmarYGenerarFactura.Name = "BtnConfirmarYGenerarFactura";
            this.BtnConfirmarYGenerarFactura.Size = new System.Drawing.Size(165, 23);
            this.BtnConfirmarYGenerarFactura.TabIndex = 1;
            this.BtnConfirmarYGenerarFactura.Text = "Confirmar y generar Factura";
            this.BtnConfirmarYGenerarFactura.UseVisualStyleBackColor = false;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.MintCream;
            this.BtnCancelar.Location = new System.Drawing.Point(607, 660);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 2;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // BtnAgregarProducto
            // 
            this.BtnAgregarProducto.BackColor = System.Drawing.Color.MintCream;
            this.BtnAgregarProducto.Location = new System.Drawing.Point(547, 56);
            this.BtnAgregarProducto.Name = "BtnAgregarProducto";
            this.BtnAgregarProducto.Size = new System.Drawing.Size(121, 23);
            this.BtnAgregarProducto.TabIndex = 3;
            this.BtnAgregarProducto.Text = "Agregar Producto";
            this.BtnAgregarProducto.UseVisualStyleBackColor = false;
            // 
            // CBoxEfectivo
            // 
            this.CBoxEfectivo.AutoSize = true;
            this.CBoxEfectivo.Location = new System.Drawing.Point(15, 516);
            this.CBoxEfectivo.Name = "CBoxEfectivo";
            this.CBoxEfectivo.Size = new System.Drawing.Size(65, 17);
            this.CBoxEfectivo.TabIndex = 4;
            this.CBoxEfectivo.Text = "Efectivo";
            this.CBoxEfectivo.UseVisualStyleBackColor = true;
            // 
            // CBoxTarjeta
            // 
            this.CBoxTarjeta.AutoSize = true;
            this.CBoxTarjeta.Location = new System.Drawing.Point(15, 539);
            this.CBoxTarjeta.Name = "CBoxTarjeta";
            this.CBoxTarjeta.Size = new System.Drawing.Size(59, 17);
            this.CBoxTarjeta.TabIndex = 5;
            this.CBoxTarjeta.Text = "Tarjeta";
            this.CBoxTarjeta.UseVisualStyleBackColor = true;
            // 
            // LblTipoDePago
            // 
            this.LblTipoDePago.AutoSize = true;
            this.LblTipoDePago.Location = new System.Drawing.Point(12, 490);
            this.LblTipoDePago.Name = "LblTipoDePago";
            this.LblTipoDePago.Size = new System.Drawing.Size(73, 13);
            this.LblTipoDePago.TabIndex = 6;
            this.LblTipoDePago.Text = "Tipo De Pago";
            // 
            // LblDetalle
            // 
            this.LblDetalle.AutoSize = true;
            this.LblDetalle.Location = new System.Drawing.Point(9, 87);
            this.LblDetalle.Name = "LblDetalle";
            this.LblDetalle.Size = new System.Drawing.Size(40, 13);
            this.LblDetalle.TabIndex = 7;
            this.LblDetalle.Text = "Detalle";
            // 
            // CBProductos
            // 
            this.CBProductos.FormattingEnabled = true;
            this.CBProductos.Location = new System.Drawing.Point(232, 58);
            this.CBProductos.Name = "CBProductos";
            this.CBProductos.Size = new System.Drawing.Size(181, 21);
            this.CBProductos.TabIndex = 8;
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Location = new System.Drawing.Point(419, 64);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(52, 13);
            this.LblCantidad.TabIndex = 10;
            this.LblCantidad.Text = "Cantidad:";
            // 
            // LblProducto
            // 
            this.LblProducto.AutoSize = true;
            this.LblProducto.Location = new System.Drawing.Point(176, 62);
            this.LblProducto.Name = "LblProducto";
            this.LblProducto.Size = new System.Drawing.Size(53, 13);
            this.LblProducto.TabIndex = 11;
            this.LblProducto.Text = "Producto:";
            // 
            // NUpDownCantidad
            // 
            this.NUpDownCantidad.Location = new System.Drawing.Point(477, 58);
            this.NUpDownCantidad.Name = "NUpDownCantidad";
            this.NUpDownCantidad.Size = new System.Drawing.Size(47, 20);
            this.NUpDownCantidad.TabIndex = 12;
            // 
            // LblMontoTotal
            // 
            this.LblMontoTotal.AutoSize = true;
            this.LblMontoTotal.Location = new System.Drawing.Point(507, 490);
            this.LblMontoTotal.Name = "LblMontoTotal";
            this.LblMontoTotal.Size = new System.Drawing.Size(67, 13);
            this.LblMontoTotal.TabIndex = 13;
            this.LblMontoTotal.Text = "Monto Total:";
            // 
            // LblNumMontoTotal
            // 
            this.LblNumMontoTotal.AutoSize = true;
            this.LblNumMontoTotal.BackColor = System.Drawing.Color.MintCream;
            this.LblNumMontoTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblNumMontoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumMontoTotal.Location = new System.Drawing.Point(583, 488);
            this.LblNumMontoTotal.Margin = new System.Windows.Forms.Padding(6, 1, 3, 0);
            this.LblNumMontoTotal.MaximumSize = new System.Drawing.Size(900, 100);
            this.LblNumMontoTotal.MinimumSize = new System.Drawing.Size(85, 0);
            this.LblNumMontoTotal.Name = "LblNumMontoTotal";
            this.LblNumMontoTotal.Size = new System.Drawing.Size(85, 19);
            this.LblNumMontoTotal.TabIndex = 14;
            this.LblNumMontoTotal.Text = "$0";
            this.LblNumMontoTotal.Click += new System.EventHandler(this.label6_Click);
            // 
            // MCVentas
            // 
            this.MCVentas.Location = new System.Drawing.Point(162, 488);
            this.MCVentas.Name = "MCVentas";
            this.MCVentas.TabIndex = 15;
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Location = new System.Drawing.Point(110, 494);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(40, 13);
            this.LblFecha.TabIndex = 16;
            this.LblFecha.Text = "Fecha:";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(705, 695);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.MCVentas);
            this.Controls.Add(this.LblNumMontoTotal);
            this.Controls.Add(this.LblMontoTotal);
            this.Controls.Add(this.NUpDownCantidad);
            this.Controls.Add(this.LblProducto);
            this.Controls.Add(this.LblCantidad);
            this.Controls.Add(this.CBProductos);
            this.Controls.Add(this.LblDetalle);
            this.Controls.Add(this.LblTipoDePago);
            this.Controls.Add(this.CBoxTarjeta);
            this.Controls.Add(this.CBoxEfectivo);
            this.Controls.Add(this.BtnAgregarProducto);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnConfirmarYGenerarFactura);
            this.Controls.Add(this.DgvDetalleVenta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form7";
            this.Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalleVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUpDownCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvDetalleVenta;
        private System.Windows.Forms.Button BtnConfirmarYGenerarFactura;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAgregarProducto;
        private System.Windows.Forms.CheckBox CBoxEfectivo;
        private System.Windows.Forms.CheckBox CBoxTarjeta;
        private System.Windows.Forms.Label LblTipoDePago;
        private System.Windows.Forms.Label LblDetalle;
        private System.Windows.Forms.ComboBox CBProductos;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.Label LblProducto;
        private System.Windows.Forms.NumericUpDown NUpDownCantidad;
        private System.Windows.Forms.Label LblMontoTotal;
        private System.Windows.Forms.Label LblNumMontoTotal;
        private System.Windows.Forms.MonthCalendar MCVentas;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Totales;
    }
}