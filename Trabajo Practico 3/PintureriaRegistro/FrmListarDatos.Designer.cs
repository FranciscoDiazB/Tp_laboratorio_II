namespace PintureriaRegistro
{
    partial class FrmListarDatos
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
            this.lsbListadoVentas = new System.Windows.Forms.ListBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAgregarArchivo = new System.Windows.Forms.Button();
            this.lblListadoDeDatos = new System.Windows.Forms.Label();
            this.btnAgregarXml = new System.Windows.Forms.Button();
            this.btnEliminarSeleccion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsbListadoVentas
            // 
            this.lsbListadoVentas.FormattingEnabled = true;
            this.lsbListadoVentas.HorizontalScrollbar = true;
            this.lsbListadoVentas.ItemHeight = 15;
            this.lsbListadoVentas.Location = new System.Drawing.Point(10, 50);
            this.lsbListadoVentas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lsbListadoVentas.Name = "lsbListadoVentas";
            this.lsbListadoVentas.Size = new System.Drawing.Size(1166, 229);
            this.lsbListadoVentas.TabIndex = 0;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Black;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(10, 283);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(136, 47);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver al Inicio";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAgregarArchivo
            // 
            this.btnAgregarArchivo.BackColor = System.Drawing.Color.Black;
            this.btnAgregarArchivo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarArchivo.ForeColor = System.Drawing.Color.White;
            this.btnAgregarArchivo.Location = new System.Drawing.Point(926, 283);
            this.btnAgregarArchivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarArchivo.Name = "btnAgregarArchivo";
            this.btnAgregarArchivo.Size = new System.Drawing.Size(250, 47);
            this.btnAgregarArchivo.TabIndex = 2;
            this.btnAgregarArchivo.Text = "Agregar datos a un Archivo .txt";
            this.btnAgregarArchivo.UseVisualStyleBackColor = false;
            this.btnAgregarArchivo.Click += new System.EventHandler(this.btnAgregarArchivo_Click);
            // 
            // lblListadoDeDatos
            // 
            this.lblListadoDeDatos.AutoSize = true;
            this.lblListadoDeDatos.Font = new System.Drawing.Font("Times New Roman", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblListadoDeDatos.Location = new System.Drawing.Point(483, 7);
            this.lblListadoDeDatos.Name = "lblListadoDeDatos";
            this.lblListadoDeDatos.Size = new System.Drawing.Size(232, 34);
            this.lblListadoDeDatos.TabIndex = 15;
            this.lblListadoDeDatos.Text = "Listado de Ventas";
            // 
            // btnAgregarXml
            // 
            this.btnAgregarXml.BackColor = System.Drawing.Color.Black;
            this.btnAgregarXml.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarXml.ForeColor = System.Drawing.Color.White;
            this.btnAgregarXml.Location = new System.Drawing.Point(670, 283);
            this.btnAgregarXml.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarXml.Name = "btnAgregarXml";
            this.btnAgregarXml.Size = new System.Drawing.Size(250, 47);
            this.btnAgregarXml.TabIndex = 16;
            this.btnAgregarXml.Text = "Agregar datos a un Archivo .Xml";
            this.btnAgregarXml.UseVisualStyleBackColor = false;
            this.btnAgregarXml.Click += new System.EventHandler(this.btnAgregarXml_Click);
            // 
            // btnEliminarSeleccion
            // 
            this.btnEliminarSeleccion.BackColor = System.Drawing.Color.Black;
            this.btnEliminarSeleccion.ForeColor = System.Drawing.Color.White;
            this.btnEliminarSeleccion.Location = new System.Drawing.Point(394, 285);
            this.btnEliminarSeleccion.Name = "btnEliminarSeleccion";
            this.btnEliminarSeleccion.Size = new System.Drawing.Size(78, 47);
            this.btnEliminarSeleccion.TabIndex = 17;
            this.btnEliminarSeleccion.Text = "Eliminar Seleccion";
            this.btnEliminarSeleccion.UseVisualStyleBackColor = false;
            this.btnEliminarSeleccion.Click += new System.EventHandler(this.btnEliminarSeleccion_Click);
            // 
            // FrmListarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1186, 338);
            this.Controls.Add(this.btnEliminarSeleccion);
            this.Controls.Add(this.btnAgregarXml);
            this.Controls.Add(this.lblListadoDeDatos);
            this.Controls.Add(this.btnAgregarArchivo);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lsbListadoVentas);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmListarDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de las Ventas";
            this.Load += new System.EventHandler(this.FrmListarDatos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbListadoVentas;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAgregarArchivo;
        private System.Windows.Forms.Label lblListadoDeDatos;
        private System.Windows.Forms.Button btnAgregarXml;
        private System.Windows.Forms.Button btnEliminarSeleccion;
    }
}