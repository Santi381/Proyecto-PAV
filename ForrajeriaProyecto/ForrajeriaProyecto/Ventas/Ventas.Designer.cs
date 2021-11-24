
namespace Proyecto
{
    partial class Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
            this.DgvVentas = new System.Windows.Forms.DataGridView();
            this.Nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDeCobro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnConsultarVenta = new System.Windows.Forms.Button();
            this.TxtIdVentas = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.LblIdVentas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvVentas
            // 
            this.DgvVentas.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.DgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nro,
            this.Fecha,
            this.Monto,
            this.TipoDeCobro});
            this.DgvVentas.Location = new System.Drawing.Point(12, 90);
            this.DgvVentas.Name = "DgvVentas";
            this.DgvVentas.Size = new System.Drawing.Size(443, 150);
            this.DgvVentas.TabIndex = 0;
            // 
            // Nro
            // 
            this.Nro.HeaderText = "Nro Orden";
            this.Nro.Name = "Nro";
            this.Nro.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto Total";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // TipoDeCobro
            // 
            this.TipoDeCobro.HeaderText = "Tipo De Cobro";
            this.TipoDeCobro.Name = "TipoDeCobro";
            this.TipoDeCobro.ReadOnly = true;
            // 
            // BtnConsultarVenta
            // 
            this.BtnConsultarVenta.BackColor = System.Drawing.Color.MintCream;
            this.BtnConsultarVenta.Location = new System.Drawing.Point(380, 53);
            this.BtnConsultarVenta.Name = "BtnConsultarVenta";
            this.BtnConsultarVenta.Size = new System.Drawing.Size(75, 23);
            this.BtnConsultarVenta.TabIndex = 1;
            this.BtnConsultarVenta.Text = "Consultar";
            this.BtnConsultarVenta.UseVisualStyleBackColor = false;
            this.BtnConsultarVenta.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtIdVentas
            // 
            this.TxtIdVentas.Location = new System.Drawing.Point(236, 55);
            this.TxtIdVentas.Name = "TxtIdVentas";
            this.TxtIdVentas.Size = new System.Drawing.Size(125, 20);
            this.TxtIdVentas.TabIndex = 2;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.MintCream;
            this.BtnAgregar.Location = new System.Drawing.Point(286, 255);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 3;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.MintCream;
            this.BtnSalir.Location = new System.Drawing.Point(378, 255);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 4;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = false;
            // 
            // LblIdVentas
            // 
            this.LblIdVentas.AutoSize = true;
            this.LblIdVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdVentas.Location = new System.Drawing.Point(163, 56);
            this.LblIdVentas.Name = "LblIdVentas";
            this.LblIdVentas.Size = new System.Drawing.Size(67, 15);
            this.LblIdVentas.TabIndex = 5;
            this.LblIdVentas.Text = "Nro Orden:";
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(465, 286);
            this.Controls.Add(this.LblIdVentas);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.TxtIdVentas);
            this.Controls.Add(this.BtnConsultarVenta);
            this.Controls.Add(this.DgvVentas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ventas";
            this.Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.DgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDeCobro;
        private System.Windows.Forms.Button BtnConsultarVenta;
        private System.Windows.Forms.TextBox TxtIdVentas;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label LblIdVentas;
    }
}