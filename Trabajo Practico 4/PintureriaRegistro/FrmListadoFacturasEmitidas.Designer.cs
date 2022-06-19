namespace PintureriaRegistro
{
    partial class FrmListadoFacturasEmitidas
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
            this.btnMostrarArchivoTexto = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.rtbMostrarTexto = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMostrarArchivoTexto
            // 
            this.btnMostrarArchivoTexto.BackColor = System.Drawing.Color.Black;
            this.btnMostrarArchivoTexto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMostrarArchivoTexto.ForeColor = System.Drawing.Color.White;
            this.btnMostrarArchivoTexto.Location = new System.Drawing.Point(658, 235);
            this.btnMostrarArchivoTexto.Name = "btnMostrarArchivoTexto";
            this.btnMostrarArchivoTexto.Size = new System.Drawing.Size(299, 49);
            this.btnMostrarArchivoTexto.TabIndex = 0;
            this.btnMostrarArchivoTexto.Text = "Mostrar Facturas Emitidas";
            this.btnMostrarArchivoTexto.UseVisualStyleBackColor = false;
            this.btnMostrarArchivoTexto.Click += new System.EventHandler(this.btnMostrarFacturasEmitidas_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.Black;
            this.btnInicio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Location = new System.Drawing.Point(12, 235);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(299, 49);
            this.btnInicio.TabIndex = 3;
            this.btnInicio.Text = "Volver al Inicio";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // rtbMostrarTexto
            // 
            this.rtbMostrarTexto.Location = new System.Drawing.Point(12, 44);
            this.rtbMostrarTexto.Name = "rtbMostrarTexto";
            this.rtbMostrarTexto.Size = new System.Drawing.Size(945, 185);
            this.rtbMostrarTexto.TabIndex = 2;
            this.rtbMostrarTexto.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(217, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Listado de las Facturas Emitidas de las Ventas Realizadas";
            // 
            // FrmImportarArchivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(983, 295);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.rtbMostrarTexto);
            this.Controls.Add(this.btnMostrarArchivoTexto);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmImportarArchivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Archivo de Texto";
            this.Load += new System.EventHandler(this.FrmImportarArchivo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarArchivoTexto;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.RichTextBox rtbMostrarTexto;
        private System.Windows.Forms.Label label1;
    }
}