
namespace ForrajeriaProyecto.InterfacesUsuario.Compras
{
    partial class FrmCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompras));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnDetalleCompra = new System.Windows.Forms.Button();
            this.DgvCompras = new System.Windows.Forms.DataGridView();
            this.NroOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtNroOrden = new System.Windows.Forms.TextBox();
            this.LblBienvenido = new System.Windows.Forms.Label();
            this.BtnConsultarCompra = new System.Windows.Forms.Button();
            this.BtnAgregarCompra = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.PanelHorizontal = new System.Windows.Forms.Panel();
            this.LblTituloVentana = new System.Windows.Forms.Label();
            this.PicIconoVentana = new System.Windows.Forms.PictureBox();
            this.BtnRestaurar = new System.Windows.Forms.PictureBox();
            this.BtnMaximizar = new System.Windows.Forms.PictureBox();
            this.BtnMinimizar = new System.Windows.Forms.PictureBox();
            this.BtnSalirBarra = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCompras)).BeginInit();
            this.PanelHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicIconoVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalirBarra)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnDetalleCompra
            // 
            this.BtnDetalleCompra.BackColor = System.Drawing.Color.White;
            this.BtnDetalleCompra.FlatAppearance.BorderSize = 2;
            this.BtnDetalleCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDetalleCompra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDetalleCompra.Image = ((System.Drawing.Image)(resources.GetObject("BtnDetalleCompra.Image")));
            this.BtnDetalleCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDetalleCompra.Location = new System.Drawing.Point(356, 262);
            this.BtnDetalleCompra.Name = "BtnDetalleCompra";
            this.BtnDetalleCompra.Size = new System.Drawing.Size(110, 40);
            this.BtnDetalleCompra.TabIndex = 83;
            this.BtnDetalleCompra.Text = "Detalle";
            this.BtnDetalleCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDetalleCompra.UseVisualStyleBackColor = false;
            this.BtnDetalleCompra.Click += new System.EventHandler(this.BtnDetalleCompra_Click);
            // 
            // DgvCompras
            // 
            this.DgvCompras.AllowUserToAddRows = false;
            this.DgvCompras.AllowUserToDeleteRows = false;
            this.DgvCompras.AllowUserToResizeRows = false;
            this.DgvCompras.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.DgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroOrden,
            this.RazonSocial,
            this.EstadoProveedor,
            this.TipoPago,
            this.NombreProveedor});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Century Gothic", 11F);
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvCompras.DefaultCellStyle = dataGridViewCellStyle23;
            this.DgvCompras.Location = new System.Drawing.Point(8, 79);
            this.DgvCompras.MultiSelect = false;
            this.DgvCompras.Name = "DgvCompras";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Century Gothic", 11F);
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCompras.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.DgvCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCompras.Size = new System.Drawing.Size(573, 176);
            this.DgvCompras.TabIndex = 82;
            // 
            // NroOrden
            // 
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.NroOrden.DefaultCellStyle = dataGridViewCellStyle18;
            this.NroOrden.HeaderText = "Nro orden";
            this.NroOrden.Name = "NroOrden";
            this.NroOrden.ReadOnly = true;
            this.NroOrden.Width = 111;
            // 
            // RazonSocial
            // 
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.RazonSocial.DefaultCellStyle = dataGridViewCellStyle19;
            this.RazonSocial.HeaderText = "Fecha";
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.Width = 88;
            // 
            // EstadoProveedor
            // 
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.EstadoProveedor.DefaultCellStyle = dataGridViewCellStyle20;
            this.EstadoProveedor.HeaderText = "Monto ";
            this.EstadoProveedor.Name = "EstadoProveedor";
            this.EstadoProveedor.ReadOnly = true;
            this.EstadoProveedor.Width = 75;
            // 
            // TipoPago
            // 
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.TipoPago.DefaultCellStyle = dataGridViewCellStyle21;
            this.TipoPago.HeaderText = "Tipo pago";
            this.TipoPago.Name = "TipoPago";
            this.TipoPago.ReadOnly = true;
            this.TipoPago.Width = 115;
            // 
            // NombreProveedor
            // 
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.NombreProveedor.DefaultCellStyle = dataGridViewCellStyle22;
            this.NombreProveedor.HeaderText = "Proveedor";
            this.NombreProveedor.Name = "NombreProveedor";
            this.NombreProveedor.ReadOnly = true;
            this.NombreProveedor.Width = 140;
            // 
            // TxtNroOrden
            // 
            this.TxtNroOrden.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.TxtNroOrden.Location = new System.Drawing.Point(251, 40);
            this.TxtNroOrden.Name = "TxtNroOrden";
            this.TxtNroOrden.Size = new System.Drawing.Size(115, 30);
            this.TxtNroOrden.TabIndex = 81;
            this.TxtNroOrden.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNroOrden_KeyPress);
            // 
            // LblBienvenido
            // 
            this.LblBienvenido.AutoSize = true;
            this.LblBienvenido.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBienvenido.Location = new System.Drawing.Point(92, 45);
            this.LblBienvenido.Name = "LblBienvenido";
            this.LblBienvenido.Size = new System.Drawing.Size(153, 25);
            this.LblBienvenido.TabIndex = 80;
            this.LblBienvenido.Text = "Nro de orden:";
            // 
            // BtnConsultarCompra
            // 
            this.BtnConsultarCompra.BackColor = System.Drawing.Color.White;
            this.BtnConsultarCompra.FlatAppearance.BorderSize = 2;
            this.BtnConsultarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultarCompra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultarCompra.Image = ((System.Drawing.Image)(resources.GetObject("BtnConsultarCompra.Image")));
            this.BtnConsultarCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsultarCompra.Location = new System.Drawing.Point(381, 33);
            this.BtnConsultarCompra.Name = "BtnConsultarCompra";
            this.BtnConsultarCompra.Size = new System.Drawing.Size(110, 40);
            this.BtnConsultarCompra.TabIndex = 79;
            this.BtnConsultarCompra.Text = "Consultar";
            this.BtnConsultarCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConsultarCompra.UseVisualStyleBackColor = false;
            this.BtnConsultarCompra.Click += new System.EventHandler(this.BtnConsultarCompra_Click);
            // 
            // BtnAgregarCompra
            // 
            this.BtnAgregarCompra.BackColor = System.Drawing.Color.White;
            this.BtnAgregarCompra.FlatAppearance.BorderSize = 2;
            this.BtnAgregarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarCompra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarCompra.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgregarCompra.Image")));
            this.BtnAgregarCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregarCompra.Location = new System.Drawing.Point(8, 262);
            this.BtnAgregarCompra.Name = "BtnAgregarCompra";
            this.BtnAgregarCompra.Size = new System.Drawing.Size(110, 40);
            this.BtnAgregarCompra.TabIndex = 78;
            this.BtnAgregarCompra.Text = "Agregar";
            this.BtnAgregarCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAgregarCompra.UseVisualStyleBackColor = false;
            this.BtnAgregarCompra.Click += new System.EventHandler(this.BtnAgregarCompra_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.White;
            this.BtnSalir.FlatAppearance.BorderSize = 2;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Image")));
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalir.Location = new System.Drawing.Point(471, 262);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(110, 40);
            this.BtnSalir.TabIndex = 77;
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
            this.PanelHorizontal.Size = new System.Drawing.Size(589, 25);
            this.PanelHorizontal.TabIndex = 84;
            this.PanelHorizontal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelHorizontal_MouseDown);
            // 
            // LblTituloVentana
            // 
            this.LblTituloVentana.AutoSize = true;
            this.LblTituloVentana.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloVentana.Location = new System.Drawing.Point(39, 4);
            this.LblTituloVentana.Name = "LblTituloVentana";
            this.LblTituloVentana.Size = new System.Drawing.Size(68, 16);
            this.LblTituloVentana.TabIndex = 7;
            this.LblTituloVentana.Text = "Compras";
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
            this.BtnRestaurar.Location = new System.Drawing.Point(511, 3);
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
            this.BtnMaximizar.Location = new System.Drawing.Point(511, 3);
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
            this.BtnMinimizar.Location = new System.Drawing.Point(478, 1);
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
            this.BtnSalirBarra.Location = new System.Drawing.Point(553, 3);
            this.BtnSalirBarra.Name = "BtnSalirBarra";
            this.BtnSalirBarra.Size = new System.Drawing.Size(36, 18);
            this.BtnSalirBarra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnSalirBarra.TabIndex = 0;
            this.BtnSalirBarra.TabStop = false;
            this.BtnSalirBarra.Click += new System.EventHandler(this.BtnSalirBarra_Click);
            // 
            // FrmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(589, 307);
            this.Controls.Add(this.PanelHorizontal);
            this.Controls.Add(this.BtnDetalleCompra);
            this.Controls.Add(this.DgvCompras);
            this.Controls.Add(this.TxtNroOrden);
            this.Controls.Add(this.LblBienvenido);
            this.Controls.Add(this.BtnConsultarCompra);
            this.Controls.Add(this.BtnAgregarCompra);
            this.Controls.Add(this.BtnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(589, 307);
            this.MinimumSize = new System.Drawing.Size(589, 307);
            this.Name = "FrmCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCompras";
            this.Load += new System.EventHandler(this.FrmCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCompras)).EndInit();
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

        private System.Windows.Forms.Button BtnDetalleCompra;
        private System.Windows.Forms.DataGridView DgvCompras;
        private System.Windows.Forms.TextBox TxtNroOrden;
        private System.Windows.Forms.Label LblBienvenido;
        private System.Windows.Forms.Button BtnConsultarCompra;
        private System.Windows.Forms.Button BtnAgregarCompra;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Panel PanelHorizontal;
        private System.Windows.Forms.Label LblTituloVentana;
        private System.Windows.Forms.PictureBox PicIconoVentana;
        private System.Windows.Forms.PictureBox BtnRestaurar;
        private System.Windows.Forms.PictureBox BtnMaximizar;
        private System.Windows.Forms.PictureBox BtnMinimizar;
        private System.Windows.Forms.PictureBox BtnSalirBarra;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProveedor;
    }
}