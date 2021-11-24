﻿
namespace ForrajeriaProyecto.InterfacesUsuario.Ventas
{
    partial class FrmDetalleVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDetalleVenta));
            this.TxtFechaVenta = new System.Windows.Forms.TextBox();
            this.LblFecha = new System.Windows.Forms.Label();
            this.TxtNombreCliente = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.Detalle = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RbTarjeta = new System.Windows.Forms.RadioButton();
            this.RbEfectivo = new System.Windows.Forms.RadioButton();
            this.TxtMontoTotal = new System.Windows.Forms.TextBox();
            this.DgvDetVenta = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblMonto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelHorizontal = new System.Windows.Forms.Panel();
            this.LblTituloVentana = new System.Windows.Forms.Label();
            this.PicIconoVentana = new System.Windows.Forms.PictureBox();
            this.BtnRestaurar = new System.Windows.Forms.PictureBox();
            this.BtnMaximizar = new System.Windows.Forms.PictureBox();
            this.BtnMinimizar = new System.Windows.Forms.PictureBox();
            this.BtnSalirBarra = new System.Windows.Forms.PictureBox();
            this.BtnVolverAtras = new System.Windows.Forms.Button();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.Detalle.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetVenta)).BeginInit();
            this.PanelHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicIconoVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalirBarra)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtFechaVenta
            // 
            this.TxtFechaVenta.Enabled = false;
            this.TxtFechaVenta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFechaVenta.Location = new System.Drawing.Point(437, 43);
            this.TxtFechaVenta.Name = "TxtFechaVenta";
            this.TxtFechaVenta.ReadOnly = true;
            this.TxtFechaVenta.Size = new System.Drawing.Size(94, 27);
            this.TxtFechaVenta.TabIndex = 38;
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.LblFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblFecha.Location = new System.Drawing.Point(359, 44);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(72, 23);
            this.LblFecha.TabIndex = 37;
            this.LblFecha.Text = "Fecha:";
            // 
            // TxtNombreCliente
            // 
            this.TxtNombreCliente.Enabled = false;
            this.TxtNombreCliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreCliente.Location = new System.Drawing.Point(98, 43);
            this.TxtNombreCliente.Name = "TxtNombreCliente";
            this.TxtNombreCliente.ReadOnly = true;
            this.TxtNombreCliente.Size = new System.Drawing.Size(244, 27);
            this.TxtNombreCliente.TabIndex = 36;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.LblNombre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblNombre.Location = new System.Drawing.Point(11, 44);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(81, 23);
            this.LblNombre.TabIndex = 35;
            this.LblNombre.Text = "Cliente:";
            // 
            // Detalle
            // 
            this.Detalle.Controls.Add(this.groupBox1);
            this.Detalle.Controls.Add(this.TxtMontoTotal);
            this.Detalle.Controls.Add(this.DgvDetVenta);
            this.Detalle.Controls.Add(this.LblMonto);
            this.Detalle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Detalle.Location = new System.Drawing.Point(9, 79);
            this.Detalle.Name = "Detalle";
            this.Detalle.Size = new System.Drawing.Size(708, 465);
            this.Detalle.TabIndex = 34;
            this.Detalle.TabStop = false;
            this.Detalle.Text = "Detalle";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RbTarjeta);
            this.groupBox1.Controls.Add(this.RbEfectivo);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 393);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 62);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de cobro:";
            // 
            // RbTarjeta
            // 
            this.RbTarjeta.AutoSize = true;
            this.RbTarjeta.Enabled = false;
            this.RbTarjeta.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbTarjeta.Location = new System.Drawing.Point(149, 26);
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
            this.RbEfectivo.Enabled = false;
            this.RbEfectivo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbEfectivo.Location = new System.Drawing.Point(22, 26);
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
            this.TxtMontoTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMontoTotal.Location = new System.Drawing.Point(579, 419);
            this.TxtMontoTotal.Name = "TxtMontoTotal";
            this.TxtMontoTotal.ReadOnly = true;
            this.TxtMontoTotal.Size = new System.Drawing.Size(121, 27);
            this.TxtMontoTotal.TabIndex = 33;
            // 
            // DgvDetVenta
            // 
            this.DgvDetVenta.AllowUserToAddRows = false;
            this.DgvDetVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDetVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Producto,
            this.PrecioUnitario,
            this.Cantidad,
            this.Subtotal});
            this.DgvDetVenta.Location = new System.Drawing.Point(6, 19);
            this.DgvDetVenta.Name = "DgvDetVenta";
            this.DgvDetVenta.Size = new System.Drawing.Size(694, 369);
            this.DgvDetVenta.TabIndex = 0;
            // 
            // ID
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.DefaultCellStyle = dataGridViewCellStyle6;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // Producto
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.Producto.DefaultCellStyle = dataGridViewCellStyle7;
            this.Producto.FillWeight = 200F;
            this.Producto.HeaderText = "Nombre de producto";
            this.Producto.MinimumWidth = 50;
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 300;
            // 
            // PrecioUnitario
            // 
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.PrecioUnitario.DefaultCellStyle = dataGridViewCellStyle8;
            this.PrecioUnitario.HeaderText = "Precio Unitario";
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.ReadOnly = true;
            // 
            // Cantidad
            // 
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle9;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Subtotal
            // 
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.Subtotal.DefaultCellStyle = dataGridViewCellStyle10;
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // LblMonto
            // 
            this.LblMonto.AutoSize = true;
            this.LblMonto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMonto.Location = new System.Drawing.Point(421, 420);
            this.LblMonto.Name = "LblMonto";
            this.LblMonto.Size = new System.Drawing.Size(152, 23);
            this.LblMonto.TabIndex = 13;
            this.LblMonto.Text = "Monto Total ($):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Detalle";
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
            this.PanelHorizontal.Size = new System.Drawing.Size(729, 25);
            this.PanelHorizontal.TabIndex = 39;
            this.PanelHorizontal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelHorizontal_MouseDown);
            // 
            // LblTituloVentana
            // 
            this.LblTituloVentana.AutoSize = true;
            this.LblTituloVentana.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloVentana.Location = new System.Drawing.Point(39, 4);
            this.LblTituloVentana.Name = "LblTituloVentana";
            this.LblTituloVentana.Size = new System.Drawing.Size(116, 16);
            this.LblTituloVentana.TabIndex = 7;
            this.LblTituloVentana.Text = "Detalle de venta";
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
            this.BtnRestaurar.Location = new System.Drawing.Point(651, 3);
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
            this.BtnMaximizar.Location = new System.Drawing.Point(651, 3);
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
            this.BtnMinimizar.Location = new System.Drawing.Point(618, 1);
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
            this.BtnSalirBarra.Location = new System.Drawing.Point(693, 3);
            this.BtnSalirBarra.Name = "BtnSalirBarra";
            this.BtnSalirBarra.Size = new System.Drawing.Size(36, 18);
            this.BtnSalirBarra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnSalirBarra.TabIndex = 0;
            this.BtnSalirBarra.TabStop = false;
            this.BtnSalirBarra.Click += new System.EventHandler(this.BtnSalirBarra_Click);
            // 
            // BtnVolverAtras
            // 
            this.BtnVolverAtras.BackColor = System.Drawing.Color.White;
            this.BtnVolverAtras.FlatAppearance.BorderSize = 2;
            this.BtnVolverAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolverAtras.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolverAtras.Image = ((System.Drawing.Image)(resources.GetObject("BtnVolverAtras.Image")));
            this.BtnVolverAtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVolverAtras.Location = new System.Drawing.Point(559, 36);
            this.BtnVolverAtras.Name = "BtnVolverAtras";
            this.BtnVolverAtras.Size = new System.Drawing.Size(110, 40);
            this.BtnVolverAtras.TabIndex = 69;
            this.BtnVolverAtras.Text = "Volver";
            this.BtnVolverAtras.UseVisualStyleBackColor = false;
            this.BtnVolverAtras.Click += new System.EventHandler(this.BtnVolverAtras_Click);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.BackColor = System.Drawing.Color.White;
            this.BtnImprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnImprimir.BackgroundImage")));
            this.BtnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnImprimir.FlatAppearance.BorderSize = 2;
            this.BtnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnImprimir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnImprimir.Location = new System.Drawing.Point(675, 36);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(42, 40);
            this.BtnImprimir.TabIndex = 96;
            this.BtnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnImprimir.UseVisualStyleBackColor = false;
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.Imprimir);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // FrmDetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(729, 562);
            this.Controls.Add(this.BtnImprimir);
            this.Controls.Add(this.BtnVolverAtras);
            this.Controls.Add(this.PanelHorizontal);
            this.Controls.Add(this.TxtFechaVenta);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.TxtNombreCliente);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.Detalle);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(729, 553);
            this.Name = "FrmDetalleVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDetalleVenta";
            this.Load += new System.EventHandler(this.FrmDetalleVenta_Load);
            this.Detalle.ResumeLayout(false);
            this.Detalle.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetVenta)).EndInit();
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

        private System.Windows.Forms.TextBox TxtFechaVenta;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.TextBox TxtNombreCliente;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.GroupBox Detalle;
        private System.Windows.Forms.TextBox TxtMontoTotal;
        private System.Windows.Forms.DataGridView DgvDetVenta;
        private System.Windows.Forms.Label LblMonto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PanelHorizontal;
        private System.Windows.Forms.Label LblTituloVentana;
        private System.Windows.Forms.PictureBox PicIconoVentana;
        private System.Windows.Forms.PictureBox BtnRestaurar;
        private System.Windows.Forms.PictureBox BtnMaximizar;
        private System.Windows.Forms.PictureBox BtnMinimizar;
        private System.Windows.Forms.PictureBox BtnSalirBarra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RbTarjeta;
        private System.Windows.Forms.RadioButton RbEfectivo;
        private System.Windows.Forms.Button BtnVolverAtras;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.Button BtnImprimir;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}