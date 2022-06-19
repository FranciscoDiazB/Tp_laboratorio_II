namespace PintureriaRegistro
{
    partial class FrmPintureria
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnIngresoDatos = new System.Windows.Forms.Button();
            this.btnListarDatos = new System.Windows.Forms.Button();
            this.btnMostrarListadoDeFacturasEmitidas = new System.Windows.Forms.Button();
            this.btnImportarXLM = new System.Windows.Forms.Button();
            this.btnListadoDeClientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(46, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(598, 86);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Pintureria FRADBAR";
            // 
            // btnIngresoDatos
            // 
            this.btnIngresoDatos.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIngresoDatos.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIngresoDatos.ForeColor = System.Drawing.Color.White;
            this.btnIngresoDatos.Location = new System.Drawing.Point(96, 115);
            this.btnIngresoDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIngresoDatos.Name = "btnIngresoDatos";
            this.btnIngresoDatos.Size = new System.Drawing.Size(488, 56);
            this.btnIngresoDatos.TabIndex = 2;
            this.btnIngresoDatos.Text = "Realizar Venta";
            this.btnIngresoDatos.UseVisualStyleBackColor = false;
            this.btnIngresoDatos.Click += new System.EventHandler(this.btnRealizarVenta_Click);
            // 
            // btnListarDatos
            // 
            this.btnListarDatos.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnListarDatos.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnListarDatos.ForeColor = System.Drawing.Color.White;
            this.btnListarDatos.Location = new System.Drawing.Point(96, 175);
            this.btnListarDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListarDatos.Name = "btnListarDatos";
            this.btnListarDatos.Size = new System.Drawing.Size(488, 56);
            this.btnListarDatos.TabIndex = 3;
            this.btnListarDatos.Text = "Listado de Ventas";
            this.btnListarDatos.UseVisualStyleBackColor = false;
            this.btnListarDatos.Click += new System.EventHandler(this.btnMostrarListadoDeVentas_Click);
            // 
            // btnMostrarListadoDeFacturasEmitidas
            // 
            this.btnMostrarListadoDeFacturasEmitidas.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMostrarListadoDeFacturasEmitidas.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMostrarListadoDeFacturasEmitidas.ForeColor = System.Drawing.Color.White;
            this.btnMostrarListadoDeFacturasEmitidas.Location = new System.Drawing.Point(96, 359);
            this.btnMostrarListadoDeFacturasEmitidas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMostrarListadoDeFacturasEmitidas.Name = "btnMostrarListadoDeFacturasEmitidas";
            this.btnMostrarListadoDeFacturasEmitidas.Size = new System.Drawing.Size(488, 56);
            this.btnMostrarListadoDeFacturasEmitidas.TabIndex = 4;
            this.btnMostrarListadoDeFacturasEmitidas.Text = "Listado de Facturas Emitidas ";
            this.btnMostrarListadoDeFacturasEmitidas.UseVisualStyleBackColor = false;
            this.btnMostrarListadoDeFacturasEmitidas.Click += new System.EventHandler(this.btnMostrarListadoDeFacturasEmitidas_Click);
            // 
            // btnImportarXLM
            // 
            this.btnImportarXLM.BackColor = System.Drawing.Color.Black;
            this.btnImportarXLM.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnImportarXLM.ForeColor = System.Drawing.Color.White;
            this.btnImportarXLM.Location = new System.Drawing.Point(96, 296);
            this.btnImportarXLM.Name = "btnImportarXLM";
            this.btnImportarXLM.Size = new System.Drawing.Size(488, 58);
            this.btnImportarXLM.TabIndex = 5;
            this.btnImportarXLM.Text = "Importar Ventas de un Archivo Xml";
            this.btnImportarXLM.UseVisualStyleBackColor = false;
            this.btnImportarXLM.Click += new System.EventHandler(this.btnImportarVentasDeArchivoXml_Click);
            // 
            // btnListadoDeClientes
            // 
            this.btnListadoDeClientes.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnListadoDeClientes.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnListadoDeClientes.ForeColor = System.Drawing.Color.White;
            this.btnListadoDeClientes.Location = new System.Drawing.Point(96, 235);
            this.btnListadoDeClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListadoDeClientes.Name = "btnListadoDeClientes";
            this.btnListadoDeClientes.Size = new System.Drawing.Size(488, 56);
            this.btnListadoDeClientes.TabIndex = 6;
            this.btnListadoDeClientes.Text = "Listado de Clientes";
            this.btnListadoDeClientes.UseVisualStyleBackColor = false;
            this.btnListadoDeClientes.Click += new System.EventHandler(this.btnMostrarListadoDeClientes_Click);
            // 
            // FrmPintureria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(700, 426);
            this.Controls.Add(this.btnListadoDeClientes);
            this.Controls.Add(this.btnImportarXLM);
            this.Controls.Add(this.btnMostrarListadoDeFacturasEmitidas);
            this.Controls.Add(this.btnListarDatos);
            this.Controls.Add(this.btnIngresoDatos);
            this.Controls.Add(this.lblTitulo);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPintureria";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pintureria FRADBAR";
            this.Load += new System.EventHandler(this.FrmPintureria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnIngresoDatos;
        private System.Windows.Forms.Button btnListarDatos;
        private System.Windows.Forms.Button btnMostrarListadoDeFacturasEmitidas;
        private System.Windows.Forms.Button btnImportarXLM;
        private System.Windows.Forms.Button btnListadoDeClientes;
    }
}
