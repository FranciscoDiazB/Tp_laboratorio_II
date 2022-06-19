namespace PintureriaRegistro
{
    partial class FrmListadoClientes
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
            this.lsbListadoDeClientes = new System.Windows.Forms.ListBox();
            this.lblListadoDeClientes = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lsbListadoClientesBD = new System.Windows.Forms.ListBox();
            this.lblListadoClientesBD = new System.Windows.Forms.Label();
            this.btnAgregarSeleccionABaseDatos = new System.Windows.Forms.Button();
            this.btnImportarClientesBaseDatos = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pBarCargando = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lsbListadoDeClientes
            // 
            this.lsbListadoDeClientes.FormattingEnabled = true;
            this.lsbListadoDeClientes.HorizontalScrollbar = true;
            this.lsbListadoDeClientes.ItemHeight = 15;
            this.lsbListadoDeClientes.Location = new System.Drawing.Point(12, 51);
            this.lsbListadoDeClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lsbListadoDeClientes.Name = "lsbListadoDeClientes";
            this.lsbListadoDeClientes.Size = new System.Drawing.Size(512, 139);
            this.lsbListadoDeClientes.TabIndex = 1;
            // 
            // lblListadoDeClientes
            // 
            this.lblListadoDeClientes.AutoSize = true;
            this.lblListadoDeClientes.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblListadoDeClientes.Location = new System.Drawing.Point(141, 9);
            this.lblListadoDeClientes.Name = "lblListadoDeClientes";
            this.lblListadoDeClientes.Size = new System.Drawing.Size(257, 40);
            this.lblListadoDeClientes.TabIndex = 16;
            this.lblListadoDeClientes.Text = "Listado de Clientes";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Black;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(12, 567);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(512, 47);
            this.btnVolver.TabIndex = 17;
            this.btnVolver.Text = "Volver al Inicio";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lsbListadoClientesBD
            // 
            this.lsbListadoClientesBD.FormattingEnabled = true;
            this.lsbListadoClientesBD.HorizontalScrollbar = true;
            this.lsbListadoClientesBD.ItemHeight = 15;
            this.lsbListadoClientesBD.Location = new System.Drawing.Point(12, 285);
            this.lsbListadoClientesBD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lsbListadoClientesBD.Name = "lsbListadoClientesBD";
            this.lsbListadoClientesBD.Size = new System.Drawing.Size(512, 139);
            this.lsbListadoClientesBD.TabIndex = 19;
            // 
            // lblListadoClientesBD
            // 
            this.lblListadoClientesBD.AutoSize = true;
            this.lblListadoClientesBD.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblListadoClientesBD.Location = new System.Drawing.Point(8, 243);
            this.lblListadoClientesBD.Name = "lblListadoClientesBD";
            this.lblListadoClientesBD.Size = new System.Drawing.Size(516, 40);
            this.lblListadoClientesBD.TabIndex = 20;
            this.lblListadoClientesBD.Text = "Listado de Clientes de la Base de Datos";
            // 
            // btnAgregarSeleccionABaseDatos
            // 
            this.btnAgregarSeleccionABaseDatos.BackColor = System.Drawing.Color.Black;
            this.btnAgregarSeleccionABaseDatos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarSeleccionABaseDatos.ForeColor = System.Drawing.Color.White;
            this.btnAgregarSeleccionABaseDatos.Location = new System.Drawing.Point(12, 194);
            this.btnAgregarSeleccionABaseDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarSeleccionABaseDatos.Name = "btnAgregarSeleccionABaseDatos";
            this.btnAgregarSeleccionABaseDatos.Size = new System.Drawing.Size(512, 47);
            this.btnAgregarSeleccionABaseDatos.TabIndex = 21;
            this.btnAgregarSeleccionABaseDatos.Text = "Agregar Seleccion a Base de Datos";
            this.btnAgregarSeleccionABaseDatos.UseVisualStyleBackColor = false;
            this.btnAgregarSeleccionABaseDatos.Click += new System.EventHandler(this.btnAgregarSeleccionABaseDatos_Click);
            // 
            // btnImportarClientesBaseDatos
            // 
            this.btnImportarClientesBaseDatos.BackColor = System.Drawing.Color.Black;
            this.btnImportarClientesBaseDatos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnImportarClientesBaseDatos.ForeColor = System.Drawing.Color.White;
            this.btnImportarClientesBaseDatos.Location = new System.Drawing.Point(12, 428);
            this.btnImportarClientesBaseDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImportarClientesBaseDatos.Name = "btnImportarClientesBaseDatos";
            this.btnImportarClientesBaseDatos.Size = new System.Drawing.Size(512, 47);
            this.btnImportarClientesBaseDatos.TabIndex = 23;
            this.btnImportarClientesBaseDatos.Text = "Importar Clientes de una Base de Datos";
            this.btnImportarClientesBaseDatos.UseVisualStyleBackColor = false;
            this.btnImportarClientesBaseDatos.Click += new System.EventHandler(this.btnImportarClientesBaseDatos_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(12, 479);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(512, 47);
            this.button3.TabIndex = 24;
            this.button3.Text = "Eliminar Cliente seleccionado de una Base de Datos";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnEliminarSeleccionDeBaseDeDatos_Click);
            // 
            // pBarCargando
            // 
            this.pBarCargando.Location = new System.Drawing.Point(12, 531);
            this.pBarCargando.Name = "pBarCargando";
            this.pBarCargando.Size = new System.Drawing.Size(512, 31);
            this.pBarCargando.TabIndex = 25;
            // 
            // FrmListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(534, 621);
            this.Controls.Add(this.pBarCargando);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnImportarClientesBaseDatos);
            this.Controls.Add(this.btnAgregarSeleccionABaseDatos);
            this.Controls.Add(this.lblListadoClientesBD);
            this.Controls.Add(this.lsbListadoClientesBD);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblListadoDeClientes);
            this.Controls.Add(this.lsbListadoDeClientes);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FrmListadoClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmListadoClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbListadoDeClientes;
        private System.Windows.Forms.Label lblListadoDeClientes;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ListBox lsbListadoClientesBD;
        private System.Windows.Forms.Label lblListadoClientesBD;
        private System.Windows.Forms.Button btnAgregarSeleccionABaseDatos;
        private System.Windows.Forms.Button btnImportarClientesBaseDatos;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ProgressBar pBarCargando;
    }
}