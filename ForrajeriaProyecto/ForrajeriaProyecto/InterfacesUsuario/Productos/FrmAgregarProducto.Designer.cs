
namespace ForrajeriaProyecto.InterfacesUsuario.Productos
{
    partial class FrmAgregarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarProducto));
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.TxtDescripcionProducto = new System.Windows.Forms.TextBox();
            this.TxtPrecioProducto = new System.Windows.Forms.TextBox();
            this.TxtStockProducto = new System.Windows.Forms.TextBox();
            this.TxtMarcaProducto = new System.Windows.Forms.TextBox();
            this.TxtNombreProducto = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblMarca = new System.Windows.Forms.Label();
            this.LblStock = new System.Windows.Forms.Label();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.BtnRegistrarProducto = new System.Windows.Forms.Button();
            this.LblProveedor = new System.Windows.Forms.Label();
            this.CbProveedor = new System.Windows.Forms.ComboBox();
            this.PanelHorizontal = new System.Windows.Forms.Panel();
            this.LblTituloVentana = new System.Windows.Forms.Label();
            this.PicIconoVentana = new System.Windows.Forms.PictureBox();
            this.BtnRestaurar = new System.Windows.Forms.PictureBox();
            this.BtnMaximizar = new System.Windows.Forms.PictureBox();
            this.BtnMinimizar = new System.Windows.Forms.PictureBox();
            this.BtnSalirBarra = new System.Windows.Forms.PictureBox();
            this.PanelHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicIconoVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSalirBarra)).BeginInit();
            this.SuspendLayout();
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.LblDescripcion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblDescripcion.Location = new System.Drawing.Point(71, 258);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(119, 23);
            this.LblDescripcion.TabIndex = 89;
            this.LblDescripcion.Text = "Descripción";
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
            this.BtnCancelar.Location = new System.Drawing.Point(14, 382);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(110, 40);
            this.BtnCancelar.TabIndex = 88;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // TxtDescripcionProducto
            // 
            this.TxtDescripcionProducto.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.TxtDescripcionProducto.Location = new System.Drawing.Point(14, 281);
            this.TxtDescripcionProducto.Name = "TxtDescripcionProducto";
            this.TxtDescripcionProducto.Size = new System.Drawing.Size(248, 30);
            this.TxtDescripcionProducto.TabIndex = 87;
            // 
            // TxtPrecioProducto
            // 
            this.TxtPrecioProducto.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.TxtPrecioProducto.Location = new System.Drawing.Point(14, 225);
            this.TxtPrecioProducto.Name = "TxtPrecioProducto";
            this.TxtPrecioProducto.Size = new System.Drawing.Size(248, 30);
            this.TxtPrecioProducto.TabIndex = 86;
            // 
            // TxtStockProducto
            // 
            this.TxtStockProducto.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.TxtStockProducto.Location = new System.Drawing.Point(14, 169);
            this.TxtStockProducto.Name = "TxtStockProducto";
            this.TxtStockProducto.Size = new System.Drawing.Size(248, 30);
            this.TxtStockProducto.TabIndex = 85;
            this.TxtStockProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtStockProducto_KeyPress);
            // 
            // TxtMarcaProducto
            // 
            this.TxtMarcaProducto.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.TxtMarcaProducto.Location = new System.Drawing.Point(14, 113);
            this.TxtMarcaProducto.Name = "TxtMarcaProducto";
            this.TxtMarcaProducto.Size = new System.Drawing.Size(248, 30);
            this.TxtMarcaProducto.TabIndex = 84;
            // 
            // TxtNombreProducto
            // 
            this.TxtNombreProducto.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.TxtNombreProducto.Location = new System.Drawing.Point(14, 57);
            this.TxtNombreProducto.Name = "TxtNombreProducto";
            this.TxtNombreProducto.Size = new System.Drawing.Size(248, 30);
            this.TxtNombreProducto.TabIndex = 83;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.LblNombre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblNombre.Location = new System.Drawing.Point(87, 36);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(85, 23);
            this.LblNombre.TabIndex = 82;
            this.LblNombre.Text = "Nombre";
            // 
            // LblMarca
            // 
            this.LblMarca.AutoSize = true;
            this.LblMarca.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.LblMarca.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblMarca.Location = new System.Drawing.Point(92, 92);
            this.LblMarca.Name = "LblMarca";
            this.LblMarca.Size = new System.Drawing.Size(71, 23);
            this.LblMarca.TabIndex = 81;
            this.LblMarca.Text = "Marca";
            // 
            // LblStock
            // 
            this.LblStock.AutoSize = true;
            this.LblStock.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.LblStock.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblStock.Location = new System.Drawing.Point(94, 149);
            this.LblStock.Name = "LblStock";
            this.LblStock.Size = new System.Drawing.Size(61, 23);
            this.LblStock.TabIndex = 80;
            this.LblStock.Text = "Stock";
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.LblPrecio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblPrecio.Location = new System.Drawing.Point(91, 204);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(68, 23);
            this.LblPrecio.TabIndex = 79;
            this.LblPrecio.Text = "Precio";
            // 
            // BtnRegistrarProducto
            // 
            this.BtnRegistrarProducto.BackColor = System.Drawing.Color.White;
            this.BtnRegistrarProducto.FlatAppearance.BorderSize = 2;
            this.BtnRegistrarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrarProducto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.BtnRegistrarProducto.Image = ((System.Drawing.Image)(resources.GetObject("BtnRegistrarProducto.Image")));
            this.BtnRegistrarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRegistrarProducto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnRegistrarProducto.Location = new System.Drawing.Point(152, 382);
            this.BtnRegistrarProducto.Name = "BtnRegistrarProducto";
            this.BtnRegistrarProducto.Size = new System.Drawing.Size(110, 40);
            this.BtnRegistrarProducto.TabIndex = 78;
            this.BtnRegistrarProducto.Text = "Registrar";
            this.BtnRegistrarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRegistrarProducto.UseVisualStyleBackColor = false;
            this.BtnRegistrarProducto.Click += new System.EventHandler(this.BtnRegistrarProducto_Click);
            // 
            // LblProveedor
            // 
            this.LblProveedor.AutoSize = true;
            this.LblProveedor.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.LblProveedor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblProveedor.Location = new System.Drawing.Point(76, 314);
            this.LblProveedor.Name = "LblProveedor";
            this.LblProveedor.Size = new System.Drawing.Size(105, 23);
            this.LblProveedor.TabIndex = 91;
            this.LblProveedor.Text = "Proveedor";
            // 
            // CbProveedor
            // 
            this.CbProveedor.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.CbProveedor.FormattingEnabled = true;
            this.CbProveedor.Location = new System.Drawing.Point(14, 337);
            this.CbProveedor.Name = "CbProveedor";
            this.CbProveedor.Size = new System.Drawing.Size(249, 30);
            this.CbProveedor.TabIndex = 92;
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
            this.PanelHorizontal.Size = new System.Drawing.Size(275, 25);
            this.PanelHorizontal.TabIndex = 93;
            this.PanelHorizontal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelHorizontal_MouseDown);
            // 
            // LblTituloVentana
            // 
            this.LblTituloVentana.AutoSize = true;
            this.LblTituloVentana.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloVentana.Location = new System.Drawing.Point(35, 5);
            this.LblTituloVentana.Name = "LblTituloVentana";
            this.LblTituloVentana.Size = new System.Drawing.Size(126, 16);
            this.LblTituloVentana.TabIndex = 9;
            this.LblTituloVentana.Text = "Agregar producto";
            // 
            // PicIconoVentana
            // 
            this.PicIconoVentana.Image = ((System.Drawing.Image)(resources.GetObject("PicIconoVentana.Image")));
            this.PicIconoVentana.Location = new System.Drawing.Point(5, 3);
            this.PicIconoVentana.Name = "PicIconoVentana";
            this.PicIconoVentana.Size = new System.Drawing.Size(31, 21);
            this.PicIconoVentana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicIconoVentana.TabIndex = 8;
            this.PicIconoVentana.TabStop = false;
            // 
            // BtnRestaurar
            // 
            this.BtnRestaurar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("BtnRestaurar.Image")));
            this.BtnRestaurar.Location = new System.Drawing.Point(201, 3);
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
            this.BtnMaximizar.Location = new System.Drawing.Point(197, 3);
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
            this.BtnMinimizar.Location = new System.Drawing.Point(170, 1);
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
            this.BtnSalirBarra.Location = new System.Drawing.Point(239, 3);
            this.BtnSalirBarra.Name = "BtnSalirBarra";
            this.BtnSalirBarra.Size = new System.Drawing.Size(36, 18);
            this.BtnSalirBarra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnSalirBarra.TabIndex = 0;
            this.BtnSalirBarra.TabStop = false;
            this.BtnSalirBarra.Click += new System.EventHandler(this.BtnSalirBarra_Click);
            // 
            // FrmAgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(275, 434);
            this.Controls.Add(this.PanelHorizontal);
            this.Controls.Add(this.CbProveedor);
            this.Controls.Add(this.LblProveedor);
            this.Controls.Add(this.LblDescripcion);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.TxtDescripcionProducto);
            this.Controls.Add(this.TxtPrecioProducto);
            this.Controls.Add(this.TxtStockProducto);
            this.Controls.Add(this.TxtMarcaProducto);
            this.Controls.Add(this.TxtNombreProducto);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblMarca);
            this.Controls.Add(this.LblStock);
            this.Controls.Add(this.LblPrecio);
            this.Controls.Add(this.BtnRegistrarProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(275, 434);
            this.MinimumSize = new System.Drawing.Size(275, 434);
            this.Name = "FrmAgregarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgregarProducto";
            this.Load += new System.EventHandler(this.FrmAgregarProducto_Load);
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

        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TextBox TxtDescripcionProducto;
        private System.Windows.Forms.TextBox TxtPrecioProducto;
        private System.Windows.Forms.TextBox TxtStockProducto;
        private System.Windows.Forms.TextBox TxtMarcaProducto;
        private System.Windows.Forms.TextBox TxtNombreProducto;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblMarca;
        private System.Windows.Forms.Label LblStock;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.Button BtnRegistrarProducto;
        private System.Windows.Forms.Label LblProveedor;
        private System.Windows.Forms.ComboBox CbProveedor;
        private System.Windows.Forms.Panel PanelHorizontal;
        private System.Windows.Forms.Label LblTituloVentana;
        private System.Windows.Forms.PictureBox PicIconoVentana;
        private System.Windows.Forms.PictureBox BtnRestaurar;
        private System.Windows.Forms.PictureBox BtnMaximizar;
        private System.Windows.Forms.PictureBox BtnMinimizar;
        private System.Windows.Forms.PictureBox BtnSalirBarra;
    }
}