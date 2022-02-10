
namespace ForrajeriaProyecto
{
    partial class FrmVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvVentas = new System.Windows.Forms.DataGridView();
            this.TxtNroOrden = new System.Windows.Forms.TextBox();
            this.LblBienvenido = new System.Windows.Forms.Label();
            this.BtnConsultarProducto = new System.Windows.Forms.Button();
            this.BtnAgregarVenta = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.PanelHorizontal = new System.Windows.Forms.Panel();
            this.LblTituloVentana = new System.Windows.Forms.Label();
            this.PicIconoVentana = new System.Windows.Forms.PictureBox();
            this.BtnRestaurar = new System.Windows.Forms.PictureBox();
            this.BtnMaximizar = new System.Windows.Forms.PictureBox();
            this.BtnMinimizar = new System.Windows.Forms.PictureBox();
            this.BtnSalirBarra = new System.Windows.Forms.PictureBox();
            this.BtnDetalleVenta = new System.Windows.Forms.Button();
            this.NroOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCobro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVentas)).BeginInit();
            this.PanelHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicIconoVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalirBarra)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvVentas
            // 
            this.DgvVentas.AllowUserToAddRows = false;
            this.DgvVentas.AllowUserToDeleteRows = false;
            this.DgvVentas.AllowUserToResizeRows = false;
            this.DgvVentas.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroOrden,
            this.RazonSocial,
            this.EstadoProveedor,
            this.TipoCobro,
            this.NombreCliente});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 11F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvVentas.DefaultCellStyle = dataGridViewCellStyle7;
            this.DgvVentas.Location = new System.Drawing.Point(13, 77);
            this.DgvVentas.MultiSelect = false;
            this.DgvVentas.Name = "DgvVentas";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 11F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvVentas.Size = new System.Drawing.Size(573, 176);
            this.DgvVentas.TabIndex = 75;
            this.DgvVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvVentas_CellContentClick);
            // 
            // TxtNroOrden
            // 
            this.TxtNroOrden.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.TxtNroOrden.Location = new System.Drawing.Point(256, 38);
            this.TxtNroOrden.Name = "TxtNroOrden";
            this.TxtNroOrden.Size = new System.Drawing.Size(126, 30);
            this.TxtNroOrden.TabIndex = 74;
            // 
            // LblBienvenido
            // 
            this.LblBienvenido.AutoSize = true;
            this.LblBienvenido.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBienvenido.Location = new System.Drawing.Point(97, 38);
            this.LblBienvenido.Name = "LblBienvenido";
            this.LblBienvenido.Size = new System.Drawing.Size(153, 25);
            this.LblBienvenido.TabIndex = 73;
            this.LblBienvenido.Text = "Nro de orden:";
            // 
            // BtnConsultarProducto
            // 
            this.BtnConsultarProducto.BackColor = System.Drawing.Color.White;
            this.BtnConsultarProducto.FlatAppearance.BorderSize = 2;
            this.BtnConsultarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultarProducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultarProducto.Image = ((System.Drawing.Image)(resources.GetObject("BtnConsultarProducto.Image")));
            this.BtnConsultarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsultarProducto.Location = new System.Drawing.Point(388, 31);
            this.BtnConsultarProducto.Name = "BtnConsultarProducto";
            this.BtnConsultarProducto.Size = new System.Drawing.Size(110, 40);
            this.BtnConsultarProducto.TabIndex = 72;
            this.BtnConsultarProducto.Text = "Consultar";
            this.BtnConsultarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConsultarProducto.UseVisualStyleBackColor = false;
            this.BtnConsultarProducto.Click += new System.EventHandler(this.BtnConsultarProducto_Click);
            // 
            // BtnAgregarVenta
            // 
            this.BtnAgregarVenta.BackColor = System.Drawing.Color.White;
            this.BtnAgregarVenta.FlatAppearance.BorderSize = 2;
            this.BtnAgregarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarVenta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarVenta.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgregarVenta.Image")));
            this.BtnAgregarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregarVenta.Location = new System.Drawing.Point(13, 260);
            this.BtnAgregarVenta.Name = "BtnAgregarVenta";
            this.BtnAgregarVenta.Size = new System.Drawing.Size(110, 40);
            this.BtnAgregarVenta.TabIndex = 69;
            this.BtnAgregarVenta.Text = "Agregar";
            this.BtnAgregarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAgregarVenta.UseVisualStyleBackColor = false;
            this.BtnAgregarVenta.Click += new System.EventHandler(this.BtnAgregarVenta_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.White;
            this.BtnSalir.FlatAppearance.BorderSize = 2;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Image")));
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalir.Location = new System.Drawing.Point(476, 260);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(110, 40);
            this.BtnSalir.TabIndex = 68;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
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
            this.PanelHorizontal.Size = new System.Drawing.Size(598, 25);
            this.PanelHorizontal.TabIndex = 67;
            this.PanelHorizontal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelHorizontal_MouseDown);
            // 
            // LblTituloVentana
            // 
            this.LblTituloVentana.AutoSize = true;
            this.LblTituloVentana.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloVentana.Location = new System.Drawing.Point(39, 4);
            this.LblTituloVentana.Name = "LblTituloVentana";
            this.LblTituloVentana.Size = new System.Drawing.Size(52, 16);
            this.LblTituloVentana.TabIndex = 7;
            this.LblTituloVentana.Text = "Ventas";
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
            this.BtnRestaurar.Location = new System.Drawing.Point(520, 3);
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
            this.BtnMaximizar.Location = new System.Drawing.Point(520, 3);
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
            this.BtnMinimizar.Location = new System.Drawing.Point(487, 1);
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
            this.BtnSalirBarra.Location = new System.Drawing.Point(562, 3);
            this.BtnSalirBarra.Name = "BtnSalirBarra";
            this.BtnSalirBarra.Size = new System.Drawing.Size(36, 18);
            this.BtnSalirBarra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnSalirBarra.TabIndex = 0;
            this.BtnSalirBarra.TabStop = false;
            this.BtnSalirBarra.Click += new System.EventHandler(this.BtnSalirBarra_Click);
            // 
            // BtnDetalleVenta
            // 
            this.BtnDetalleVenta.BackColor = System.Drawing.Color.White;
            this.BtnDetalleVenta.FlatAppearance.BorderSize = 2;
            this.BtnDetalleVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDetalleVenta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDetalleVenta.Image = ((System.Drawing.Image)(resources.GetObject("BtnDetalleVenta.Image")));
            this.BtnDetalleVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDetalleVenta.Location = new System.Drawing.Point(361, 260);
            this.BtnDetalleVenta.Name = "BtnDetalleVenta";
            this.BtnDetalleVenta.Size = new System.Drawing.Size(110, 40);
            this.BtnDetalleVenta.TabIndex = 76;
            this.BtnDetalleVenta.Text = "Detalle";
            this.BtnDetalleVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDetalleVenta.UseVisualStyleBackColor = false;
            this.BtnDetalleVenta.Click += new System.EventHandler(this.BtnDetalleVenta_Click);
            // 
            // NroOrden
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.NroOrden.DefaultCellStyle = dataGridViewCellStyle2;
            this.NroOrden.HeaderText = "Nro orden";
            this.NroOrden.Name = "NroOrden";
            this.NroOrden.ReadOnly = true;
            this.NroOrden.Width = 109;
            // 
            // RazonSocial
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.RazonSocial.DefaultCellStyle = dataGridViewCellStyle3;
            this.RazonSocial.HeaderText = "Fecha";
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.Width = 75;
            // 
            // EstadoProveedor
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.EstadoProveedor.DefaultCellStyle = dataGridViewCellStyle4;
            this.EstadoProveedor.HeaderText = "Monto ";
            this.EstadoProveedor.Name = "EstadoProveedor";
            this.EstadoProveedor.ReadOnly = true;
            this.EstadoProveedor.Width = 75;
            // 
            // TipoCobro
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.TipoCobro.DefaultCellStyle = dataGridViewCellStyle5;
            this.TipoCobro.HeaderText = "Tipo cobro";
            this.TipoCobro.Name = "TipoCobro";
            this.TipoCobro.ReadOnly = true;
            this.TipoCobro.Width = 115;
            // 
            // NombreCliente
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.NombreCliente.DefaultCellStyle = dataGridViewCellStyle6;
            this.NombreCliente.HeaderText = "Cliente";
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.ReadOnly = true;
            this.NombreCliente.Width = 156;
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(598, 314);
            this.Controls.Add(this.BtnDetalleVenta);
            this.Controls.Add(this.DgvVentas);
            this.Controls.Add(this.TxtNroOrden);
            this.Controls.Add(this.LblBienvenido);
            this.Controls.Add(this.BtnConsultarProducto);
            this.Controls.Add(this.BtnAgregarVenta);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.PanelHorizontal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(598, 314);
            this.MinimumSize = new System.Drawing.Size(546, 314);
            this.Name = "FrmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVentas";
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvVentas)).EndInit();
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

        private System.Windows.Forms.DataGridView DgvVentas;
        private System.Windows.Forms.TextBox TxtNroOrden;
        private System.Windows.Forms.Label LblBienvenido;
        private System.Windows.Forms.Button BtnConsultarProducto;
        private System.Windows.Forms.Button BtnAgregarVenta;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Panel PanelHorizontal;
        private System.Windows.Forms.Label LblTituloVentana;
        private System.Windows.Forms.PictureBox PicIconoVentana;
        private System.Windows.Forms.PictureBox BtnRestaurar;
        private System.Windows.Forms.PictureBox BtnMaximizar;
        private System.Windows.Forms.PictureBox BtnMinimizar;
        private System.Windows.Forms.PictureBox BtnSalirBarra;
        private System.Windows.Forms.Button BtnDetalleVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCobro;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
    }
}