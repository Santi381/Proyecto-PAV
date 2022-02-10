
namespace Proyecto
{
    partial class Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            this.DgvProductos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnConsultarUsuario = new System.Windows.Forms.Button();
            this.TxtNombreProducto = new System.Windows.Forms.TextBox();
            this.LblNombreProducto = new System.Windows.Forms.Label();
            this.BtnAgregarProducto = new System.Windows.Forms.Button();
            this.BtnEliminarProducto = new System.Windows.Forms.Button();
            this.BtnSalirProducto = new System.Windows.Forms.Button();
            this.BtnModificarProducto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvProductos
            // 
            this.DgvProductos.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.DgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nombre,
            this.Marca,
            this.Stock,
            this.Precio});
            this.DgvProductos.Location = new System.Drawing.Point(12, 102);
            this.DgvProductos.Name = "DgvProductos";
            this.DgvProductos.Size = new System.Drawing.Size(543, 156);
            this.DgvProductos.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // BtnConsultarUsuario
            // 
            this.BtnConsultarUsuario.BackColor = System.Drawing.Color.MintCream;
            this.BtnConsultarUsuario.Location = new System.Drawing.Point(410, 55);
            this.BtnConsultarUsuario.Name = "BtnConsultarUsuario";
            this.BtnConsultarUsuario.Size = new System.Drawing.Size(75, 23);
            this.BtnConsultarUsuario.TabIndex = 1;
            this.BtnConsultarUsuario.Text = "Consultar";
            this.BtnConsultarUsuario.UseVisualStyleBackColor = false;
            // 
            // TxtNombreProducto
            // 
            this.TxtNombreProducto.Location = new System.Drawing.Point(127, 58);
            this.TxtNombreProducto.Name = "TxtNombreProducto";
            this.TxtNombreProducto.Size = new System.Drawing.Size(264, 20);
            this.TxtNombreProducto.TabIndex = 2;
            // 
            // LblNombreProducto
            // 
            this.LblNombreProducto.AutoSize = true;
            this.LblNombreProducto.Location = new System.Drawing.Point(14, 61);
            this.LblNombreProducto.Name = "LblNombreProducto";
            this.LblNombreProducto.Size = new System.Drawing.Size(110, 13);
            this.LblNombreProducto.TabIndex = 3;
            this.LblNombreProducto.Text = "Nombre De Producto:";
            // 
            // BtnAgregarProducto
            // 
            this.BtnAgregarProducto.BackColor = System.Drawing.Color.White;
            this.BtnAgregarProducto.Location = new System.Drawing.Point(12, 285);
            this.BtnAgregarProducto.Name = "BtnAgregarProducto";
            this.BtnAgregarProducto.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregarProducto.TabIndex = 5;
            this.BtnAgregarProducto.Text = "Agregar";
            this.BtnAgregarProducto.UseVisualStyleBackColor = false;
            // 
            // BtnEliminarProducto
            // 
            this.BtnEliminarProducto.BackColor = System.Drawing.Color.White;
            this.BtnEliminarProducto.Location = new System.Drawing.Point(204, 285);
            this.BtnEliminarProducto.Name = "BtnEliminarProducto";
            this.BtnEliminarProducto.Size = new System.Drawing.Size(75, 23);
            this.BtnEliminarProducto.TabIndex = 9;
            this.BtnEliminarProducto.Text = "Eliminar";
            this.BtnEliminarProducto.UseVisualStyleBackColor = false;
            // 
            // BtnSalirProducto
            // 
            this.BtnSalirProducto.BackColor = System.Drawing.Color.White;
            this.BtnSalirProducto.Location = new System.Drawing.Point(480, 285);
            this.BtnSalirProducto.Name = "BtnSalirProducto";
            this.BtnSalirProducto.Size = new System.Drawing.Size(75, 23);
            this.BtnSalirProducto.TabIndex = 10;
            this.BtnSalirProducto.Text = "Salir";
            this.BtnSalirProducto.UseVisualStyleBackColor = false;
            // 
            // BtnModificarProducto
            // 
            this.BtnModificarProducto.BackColor = System.Drawing.Color.MintCream;
            this.BtnModificarProducto.Location = new System.Drawing.Point(105, 285);
            this.BtnModificarProducto.Name = "BtnModificarProducto";
            this.BtnModificarProducto.Size = new System.Drawing.Size(75, 23);
            this.BtnModificarProducto.TabIndex = 11;
            this.BtnModificarProducto.Text = "Modificar";
            this.BtnModificarProducto.UseVisualStyleBackColor = false;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(570, 331);
            this.Controls.Add(this.BtnModificarProducto);
            this.Controls.Add(this.BtnSalirProducto);
            this.Controls.Add(this.BtnEliminarProducto);
            this.Controls.Add(this.BtnAgregarProducto);
            this.Controls.Add(this.LblNombreProducto);
            this.Controls.Add(this.TxtNombreProducto);
            this.Controls.Add(this.BtnConsultarUsuario);
            this.Controls.Add(this.DgvProductos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Productos";
            this.Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvProductos;
        private System.Windows.Forms.Button BtnConsultarUsuario;
        private System.Windows.Forms.TextBox TxtNombreProducto;
        private System.Windows.Forms.Label LblNombreProducto;
        private System.Windows.Forms.Button BtnAgregarProducto;
        private System.Windows.Forms.Button BtnEliminarProducto;
        private System.Windows.Forms.Button BtnSalirProducto;
        private System.Windows.Forms.Button BtnModificarProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}