﻿
namespace ForrajeriaProyecto.InterfacesUsuario.Reportes
{
    partial class FrmReportesClientesMonto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportesClientesMonto));
            this.RwMonto = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BtnSalir = new System.Windows.Forms.Button();
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
            // RwMonto
            // 
            this.RwMonto.LocalReport.ReportEmbeddedResource = "ForrajeriaProyecto.InterfacesUsuario.Reportes.ReporteMontoPorCliente.rdlc";
            this.RwMonto.Location = new System.Drawing.Point(-1, 23);
            this.RwMonto.Name = "RwMonto";
            this.RwMonto.ServerReport.BearerToken = null;
            this.RwMonto.Size = new System.Drawing.Size(662, 393);
            this.RwMonto.TabIndex = 0;
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.White;
            this.BtnSalir.FlatAppearance.BorderSize = 2;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Image")));
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalir.Location = new System.Drawing.Point(551, 422);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(110, 40);
            this.BtnSalir.TabIndex = 27;
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
            this.PanelHorizontal.Size = new System.Drawing.Size(662, 25);
            this.PanelHorizontal.TabIndex = 28;
            this.PanelHorizontal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelHorizontal_MouseDown);
            // 
            // LblTituloVentana
            // 
            this.LblTituloVentana.AutoSize = true;
            this.LblTituloVentana.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTituloVentana.Location = new System.Drawing.Point(39, 4);
            this.LblTituloVentana.Name = "LblTituloVentana";
            this.LblTituloVentana.Size = new System.Drawing.Size(185, 16);
            this.LblTituloVentana.TabIndex = 7;
            this.LblTituloVentana.Text = "Reporte clientes por monto";
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
            this.BtnRestaurar.Location = new System.Drawing.Point(584, 3);
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
            this.BtnMaximizar.Location = new System.Drawing.Point(584, 3);
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
            this.BtnMinimizar.Location = new System.Drawing.Point(551, 1);
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
            this.BtnSalirBarra.Location = new System.Drawing.Point(626, 3);
            this.BtnSalirBarra.Name = "BtnSalirBarra";
            this.BtnSalirBarra.Size = new System.Drawing.Size(36, 18);
            this.BtnSalirBarra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnSalirBarra.TabIndex = 0;
            this.BtnSalirBarra.TabStop = false;
            this.BtnSalirBarra.Click += new System.EventHandler(this.BtnSalirBarra_Click);
            // 
            // FrmReportesClientesMonto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(662, 467);
            this.Controls.Add(this.PanelHorizontal);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.RwMonto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReportesClientesMonto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReportesClientesMonto";
            this.Load += new System.EventHandler(this.FrmReportesClientesMonto_Load);
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

        private Microsoft.Reporting.WinForms.ReportViewer RwMonto;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Panel PanelHorizontal;
        private System.Windows.Forms.Label LblTituloVentana;
        private System.Windows.Forms.PictureBox PicIconoVentana;
        private System.Windows.Forms.PictureBox BtnRestaurar;
        private System.Windows.Forms.PictureBox BtnMaximizar;
        private System.Windows.Forms.PictureBox BtnMinimizar;
        private System.Windows.Forms.PictureBox BtnSalirBarra;
    }
}