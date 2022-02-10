
namespace ForrajeriaProyecto.InterfacesUsuario.Presupuestos
{
    partial class FrmPresupuestos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPresupuestos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelHorizontal = new System.Windows.Forms.Panel();
            this.LblTituloVentana = new System.Windows.Forms.Label();
            this.PicIconoVentana = new System.Windows.Forms.PictureBox();
            this.BtnRestaurar = new System.Windows.Forms.PictureBox();
            this.BtnMaximizar = new System.Windows.Forms.PictureBox();
            this.BtnMinimizar = new System.Windows.Forms.PictureBox();
            this.BtnSalirBarra = new System.Windows.Forms.PictureBox();
            this.BtnDetallePresupuesto = new System.Windows.Forms.Button();
            this.DgvVentas = new System.Windows.Forms.DataGridView();
            this.NroOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblBienvenido = new System.Windows.Forms.Label();
            this.BtnConsultarPresupuestos = new System.Windows.Forms.Button();
            this.BtnAgregarPresupuesto = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.CBClientes = new System.Windows.Forms.ComboBox();
            this.PanelHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicIconoVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalirBarra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVentas)).BeginInit();
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
            this.PanelHorizontal.Size = new System.Drawing.Size(506, 25);
            this.PanelHorizontal.TabIndex = 24;
            this.PanelHorizontal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelHorizontal_MouseDown);
            // 
            // LblTituloVentana
            // 
            this.LblTituloVentana.AutoSize = true;
            this.LblTituloVentana.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloVentana.Location = new System.Drawing.Point(39, 4);
            this.LblTituloVentana.Name = "LblTituloVentana";
            this.LblTituloVentana.Size = new System.Drawing.Size(90, 16);
            this.LblTituloVentana.TabIndex = 7;
            this.LblTituloVentana.Text = "Presupuestos";
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
            this.BtnRestaurar.Location = new System.Drawing.Point(428, 3);
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
            this.BtnMaximizar.Location = new System.Drawing.Point(428, 3);
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
            this.BtnMinimizar.Location = new System.Drawing.Point(395, 1);
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
            this.BtnSalirBarra.Location = new System.Drawing.Point(470, 3);
            this.BtnSalirBarra.Name = "BtnSalirBarra";
            this.BtnSalirBarra.Size = new System.Drawing.Size(36, 18);
            this.BtnSalirBarra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnSalirBarra.TabIndex = 0;
            this.BtnSalirBarra.TabStop = false;
            this.BtnSalirBarra.Click += new System.EventHandler(this.BtnSalirBarra_Click);
            // 
            // BtnDetallePresupuesto
            // 
            this.BtnDetallePresupuesto.BackColor = System.Drawing.Color.White;
            this.BtnDetallePresupuesto.FlatAppearance.BorderSize = 2;
            this.BtnDetallePresupuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDetallePresupuesto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDetallePresupuesto.Image = ((System.Drawing.Image)(resources.GetObject("BtnDetallePresupuesto.Image")));
            this.BtnDetallePresupuesto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDetallePresupuesto.Location = new System.Drawing.Point(274, 262);
            this.BtnDetallePresupuesto.Name = "BtnDetallePresupuesto";
            this.BtnDetallePresupuesto.Size = new System.Drawing.Size(110, 40);
            this.BtnDetallePresupuesto.TabIndex = 83;
            this.BtnDetallePresupuesto.Text = "Detalle";
            this.BtnDetallePresupuesto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDetallePresupuesto.UseVisualStyleBackColor = false;
            this.BtnDetallePresupuesto.Click += new System.EventHandler(this.BtnDetallePresupuesto_Click);
            // 
            // DgvVentas
            // 
            this.DgvVentas.AllowUserToAddRows = false;
            this.DgvVentas.AllowUserToDeleteRows = false;
            this.DgvVentas.AllowUserToResizeRows = false;
            this.DgvVentas.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroOrden,
            this.RazonSocial,
            this.EstadoProveedor,
            this.NombreCliente});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Century Gothic", 11F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvVentas.DefaultCellStyle = dataGridViewCellStyle13;
            this.DgvVentas.Location = new System.Drawing.Point(9, 80);
            this.DgvVentas.MultiSelect = false;
            this.DgvVentas.Name = "DgvVentas";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 11F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.DgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvVentas.Size = new System.Drawing.Size(490, 176);
            this.DgvVentas.TabIndex = 82;
            // 
            // NroOrden
            // 
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.NroOrden.DefaultCellStyle = dataGridViewCellStyle9;
            this.NroOrden.HeaderText = "Nro";
            this.NroOrden.Name = "NroOrden";
            this.NroOrden.ReadOnly = true;
            this.NroOrden.Width = 80;
            // 
            // RazonSocial
            // 
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.RazonSocial.DefaultCellStyle = dataGridViewCellStyle10;
            this.RazonSocial.HeaderText = "Fecha";
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.Width = 90;
            // 
            // EstadoProveedor
            // 
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.EstadoProveedor.DefaultCellStyle = dataGridViewCellStyle11;
            this.EstadoProveedor.HeaderText = "Monto ";
            this.EstadoProveedor.Name = "EstadoProveedor";
            this.EstadoProveedor.ReadOnly = true;
            this.EstadoProveedor.Width = 90;
            // 
            // NombreCliente
            // 
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.NombreCliente.DefaultCellStyle = dataGridViewCellStyle12;
            this.NombreCliente.HeaderText = "Cliente";
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.ReadOnly = true;
            this.NombreCliente.Width = 187;
            // 
            // LblBienvenido
            // 
            this.LblBienvenido.AutoSize = true;
            this.LblBienvenido.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.LblBienvenido.Location = new System.Drawing.Point(12, 43);
            this.LblBienvenido.Name = "LblBienvenido";
            this.LblBienvenido.Size = new System.Drawing.Size(86, 23);
            this.LblBienvenido.TabIndex = 80;
            this.LblBienvenido.Text = "Cliente:";
            // 
            // BtnConsultarPresupuestos
            // 
            this.BtnConsultarPresupuestos.BackColor = System.Drawing.Color.White;
            this.BtnConsultarPresupuestos.FlatAppearance.BorderSize = 2;
            this.BtnConsultarPresupuestos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultarPresupuestos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultarPresupuestos.Image = ((System.Drawing.Image)(resources.GetObject("BtnConsultarPresupuestos.Image")));
            this.BtnConsultarPresupuestos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsultarPresupuestos.Location = new System.Drawing.Point(389, 34);
            this.BtnConsultarPresupuestos.Name = "BtnConsultarPresupuestos";
            this.BtnConsultarPresupuestos.Size = new System.Drawing.Size(110, 40);
            this.BtnConsultarPresupuestos.TabIndex = 79;
            this.BtnConsultarPresupuestos.Text = "Consultar";
            this.BtnConsultarPresupuestos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConsultarPresupuestos.UseVisualStyleBackColor = false;
            this.BtnConsultarPresupuestos.Click += new System.EventHandler(this.BtnConsultarPresupuestos_Click);
            // 
            // BtnAgregarPresupuesto
            // 
            this.BtnAgregarPresupuesto.BackColor = System.Drawing.Color.White;
            this.BtnAgregarPresupuesto.FlatAppearance.BorderSize = 2;
            this.BtnAgregarPresupuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarPresupuesto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarPresupuesto.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgregarPresupuesto.Image")));
            this.BtnAgregarPresupuesto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregarPresupuesto.Location = new System.Drawing.Point(9, 263);
            this.BtnAgregarPresupuesto.Name = "BtnAgregarPresupuesto";
            this.BtnAgregarPresupuesto.Size = new System.Drawing.Size(110, 40);
            this.BtnAgregarPresupuesto.TabIndex = 78;
            this.BtnAgregarPresupuesto.Text = "Agregar";
            this.BtnAgregarPresupuesto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAgregarPresupuesto.UseVisualStyleBackColor = false;
            this.BtnAgregarPresupuesto.Click += new System.EventHandler(this.BtnAgregarPresupuesto_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.White;
            this.BtnSalir.FlatAppearance.BorderSize = 2;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Image")));
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalir.Location = new System.Drawing.Point(389, 262);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(110, 40);
            this.BtnSalir.TabIndex = 77;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // CBClientes
            // 
            this.CBClientes.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.CBClientes.FormattingEnabled = true;
            this.CBClientes.Location = new System.Drawing.Point(96, 41);
            this.CBClientes.Name = "CBClientes";
            this.CBClientes.Size = new System.Drawing.Size(288, 30);
            this.CBClientes.TabIndex = 84;
            // 
            // FrmPresupuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(506, 307);
            this.Controls.Add(this.CBClientes);
            this.Controls.Add(this.BtnDetallePresupuesto);
            this.Controls.Add(this.DgvVentas);
            this.Controls.Add(this.LblBienvenido);
            this.Controls.Add(this.BtnConsultarPresupuestos);
            this.Controls.Add(this.BtnAgregarPresupuesto);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.PanelHorizontal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(506, 307);
            this.MinimumSize = new System.Drawing.Size(506, 307);
            this.Name = "FrmPresupuestos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPresupuestos";
            this.Load += new System.EventHandler(this.FrmPresupuestos_Load);
            this.PanelHorizontal.ResumeLayout(false);
            this.PanelHorizontal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicIconoVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalirBarra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelHorizontal;
        private System.Windows.Forms.Label LblTituloVentana;
        private System.Windows.Forms.PictureBox PicIconoVentana;
        private System.Windows.Forms.PictureBox BtnRestaurar;
        private System.Windows.Forms.PictureBox BtnMaximizar;
        private System.Windows.Forms.PictureBox BtnMinimizar;
        private System.Windows.Forms.PictureBox BtnSalirBarra;
        private System.Windows.Forms.Button BtnDetallePresupuesto;
        private System.Windows.Forms.DataGridView DgvVentas;
        private System.Windows.Forms.Label LblBienvenido;
        private System.Windows.Forms.Button BtnConsultarPresupuestos;
        private System.Windows.Forms.Button BtnAgregarPresupuesto;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.ComboBox CBClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
    }
}