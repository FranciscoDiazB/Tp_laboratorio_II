namespace PintureriaRegistro
{
    partial class FrmRegistroDatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistroDatos));
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCodigoProducto = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblLitros = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.cmbLitros = new System.Windows.Forms.ComboBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.lblDatosCliente = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.txtApellCliente = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblApellidoCliente = new System.Windows.Forms.Label();
            this.lblPago = new System.Windows.Forms.Label();
            this.cmbPago = new System.Windows.Forms.ComboBox();
            this.lblDatosExtra = new System.Windows.Forms.Label();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.lblCantidadDeProductos = new System.Windows.Forms.Label();
            this.txtUnidades = new System.Windows.Forms.TextBox();
            this.rtbVenta = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAgregarVenta = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.txtNombreVendedor = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtDniCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipoFactura = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIngresarPrimerVenta = new System.Windows.Forms.Button();
            this.btnIngresarSegundaVenta = new System.Windows.Forms.Button();
            this.btnIngresarTercerVenta = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnIngresarCuartaVenta = new System.Windows.Forms.Button();
            this.lblHorario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.Color.White;
            this.txtMarca.ForeColor = System.Drawing.Color.Black;
            this.txtMarca.Location = new System.Drawing.Point(20, 60);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(131, 23);
            this.txtMarca.TabIndex = 0;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblProducto.Location = new System.Drawing.Point(20, 10);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(97, 30);
            this.lblProducto.TabIndex = 1;
            this.lblProducto.Text = "Producto";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(20, 159);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(74, 23);
            this.txtPrecio.TabIndex = 3;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(20, 110);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(131, 23);
            this.txtCodigo.TabIndex = 4;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMarca.Location = new System.Drawing.Point(20, 38);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(50, 20);
            this.lblMarca.TabIndex = 5;
            this.lblMarca.Text = "Marca";
            // 
            // lblCodigoProducto
            // 
            this.lblCodigoProducto.AutoSize = true;
            this.lblCodigoProducto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCodigoProducto.Location = new System.Drawing.Point(18, 85);
            this.lblCodigoProducto.Name = "lblCodigoProducto";
            this.lblCodigoProducto.Size = new System.Drawing.Size(147, 20);
            this.lblCodigoProducto.TabIndex = 6;
            this.lblCodigoProducto.Text = "Codigo del Producto";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrecio.Location = new System.Drawing.Point(20, 137);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(139, 20);
            this.lblPrecio.TabIndex = 7;
            this.lblPrecio.Text = "Precio del Producto";
            // 
            // lblLitros
            // 
            this.lblLitros.AutoSize = true;
            this.lblLitros.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLitros.Location = new System.Drawing.Point(20, 184);
            this.lblLitros.Name = "lblLitros";
            this.lblLitros.Size = new System.Drawing.Size(45, 20);
            this.lblLitros.TabIndex = 8;
            this.lblLitros.Text = "Litros";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblColor.Location = new System.Drawing.Point(18, 277);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(132, 20);
            this.lblColor.TabIndex = 9;
            this.lblColor.Text = "Color de la Pintura";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTipo.Location = new System.Drawing.Point(18, 231);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(110, 20);
            this.lblTipo.TabIndex = 10;
            this.lblTipo.Text = "Tipo de Pintura";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(20, 252);
            this.cmbTipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(99, 23);
            this.cmbTipo.TabIndex = 11;
            // 
            // cmbLitros
            // 
            this.cmbLitros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLitros.FormattingEnabled = true;
            this.cmbLitros.Location = new System.Drawing.Point(20, 206);
            this.cmbLitros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbLitros.Name = "cmbLitros";
            this.cmbLitros.Size = new System.Drawing.Size(44, 23);
            this.cmbLitros.TabIndex = 12;
            // 
            // cmbColor
            // 
            this.cmbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(18, 299);
            this.cmbColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(99, 23);
            this.cmbColor.TabIndex = 13;
            // 
            // lblDatosCliente
            // 
            this.lblDatosCliente.AutoSize = true;
            this.lblDatosCliente.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblDatosCliente.Location = new System.Drawing.Point(214, 10);
            this.lblDatosCliente.Name = "lblDatosCliente";
            this.lblDatosCliente.Size = new System.Drawing.Size(137, 30);
            this.lblDatosCliente.TabIndex = 14;
            this.lblDatosCliente.Text = "Datos Cliente";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 452);
            this.splitter1.TabIndex = 15;
            this.splitter1.TabStop = false;
            // 
            // txtApellCliente
            // 
            this.txtApellCliente.Location = new System.Drawing.Point(218, 133);
            this.txtApellCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellCliente.Name = "txtApellCliente";
            this.txtApellCliente.Size = new System.Drawing.Size(130, 23);
            this.txtApellCliente.TabIndex = 16;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(218, 78);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(130, 23);
            this.txtCliente.TabIndex = 17;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombreCliente.Location = new System.Drawing.Point(216, 56);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(139, 20);
            this.lblNombreCliente.TabIndex = 18;
            this.lblNombreCliente.Text = "Nombre del Cliente";
            // 
            // lblApellidoCliente
            // 
            this.lblApellidoCliente.AutoSize = true;
            this.lblApellidoCliente.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblApellidoCliente.Location = new System.Drawing.Point(218, 109);
            this.lblApellidoCliente.Name = "lblApellidoCliente";
            this.lblApellidoCliente.Size = new System.Drawing.Size(141, 20);
            this.lblApellidoCliente.TabIndex = 19;
            this.lblApellidoCliente.Text = "Apellido del Cliente";
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPago.Location = new System.Drawing.Point(218, 158);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(120, 20);
            this.lblPago.TabIndex = 20;
            this.lblPago.Text = "Metodo de Pago";
            // 
            // cmbPago
            // 
            this.cmbPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPago.FormattingEnabled = true;
            this.cmbPago.Location = new System.Drawing.Point(218, 180);
            this.cmbPago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPago.Name = "cmbPago";
            this.cmbPago.Size = new System.Drawing.Size(130, 23);
            this.cmbPago.TabIndex = 21;
            // 
            // lblDatosExtra
            // 
            this.lblDatosExtra.AutoSize = true;
            this.lblDatosExtra.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblDatosExtra.Location = new System.Drawing.Point(214, 261);
            this.lblDatosExtra.Name = "lblDatosExtra";
            this.lblDatosExtra.Size = new System.Drawing.Size(162, 30);
            this.lblDatosExtra.TabIndex = 22;
            this.lblDatosExtra.Text = "Datos Vendedor";
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVendedor.Location = new System.Drawing.Point(216, 296);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(157, 20);
            this.lblVendedor.TabIndex = 23;
            this.lblVendedor.Text = "Nombre del Vendedor";
            // 
            // lblCantidadDeProductos
            // 
            this.lblCantidadDeProductos.AutoSize = true;
            this.lblCantidadDeProductos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCantidadDeProductos.Location = new System.Drawing.Point(18, 324);
            this.lblCantidadDeProductos.Name = "lblCantidadDeProductos";
            this.lblCantidadDeProductos.Size = new System.Drawing.Size(156, 20);
            this.lblCantidadDeProductos.TabIndex = 24;
            this.lblCantidadDeProductos.Text = "Cantidad de Unidades";
            // 
            // txtUnidades
            // 
            this.txtUnidades.Location = new System.Drawing.Point(18, 346);
            this.txtUnidades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUnidades.Name = "txtUnidades";
            this.txtUnidades.Size = new System.Drawing.Size(49, 23);
            this.txtUnidades.TabIndex = 27;
            // 
            // rtbVenta
            // 
            this.rtbVenta.BackColor = System.Drawing.SystemColors.Window;
            this.rtbVenta.Location = new System.Drawing.Point(423, 73);
            this.rtbVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbVenta.Name = "rtbVenta";
            this.rtbVenta.Size = new System.Drawing.Size(275, 156);
            this.rtbVenta.TabIndex = 29;
            this.rtbVenta.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(423, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 37);
            this.label1.TabIndex = 30;
            this.label1.Text = "Resumen de la Venta";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(423, 246);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 45);
            this.button1.TabIndex = 31;
            this.button1.Text = "Resumir Venta";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnVistaPreviaResumidaDeVenta_Click);
            // 
            // btnAgregarVenta
            // 
            this.btnAgregarVenta.BackColor = System.Drawing.Color.Black;
            this.btnAgregarVenta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarVenta.ForeColor = System.Drawing.Color.White;
            this.btnAgregarVenta.Location = new System.Drawing.Point(423, 299);
            this.btnAgregarVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarVenta.Name = "btnAgregarVenta";
            this.btnAgregarVenta.Size = new System.Drawing.Size(275, 45);
            this.btnAgregarVenta.TabIndex = 32;
            this.btnAgregarVenta.Text = "Realizar Venta";
            this.btnAgregarVenta.UseVisualStyleBackColor = false;
            this.btnAgregarVenta.Click += new System.EventHandler(this.btnAgregarVenta_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Black;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(423, 350);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(275, 45);
            this.btnVolver.TabIndex = 33;
            this.btnVolver.Text = "Volver al Inicio";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // txtNombreVendedor
            // 
            this.txtNombreVendedor.Location = new System.Drawing.Point(218, 318);
            this.txtNombreVendedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreVendedor.Name = "txtNombreVendedor";
            this.txtNombreVendedor.Size = new System.Drawing.Size(130, 23);
            this.txtNombreVendedor.TabIndex = 35;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDni.Location = new System.Drawing.Point(218, 205);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(162, 20);
            this.lblDni.TabIndex = 36;
            this.lblDni.Text = "Documento del Cliente";
            // 
            // txtDniCliente
            // 
            this.txtDniCliente.Location = new System.Drawing.Point(218, 228);
            this.txtDniCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDniCliente.Name = "txtDniCliente";
            this.txtDniCliente.Size = new System.Drawing.Size(130, 23);
            this.txtDniCliente.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(218, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 30);
            this.label2.TabIndex = 38;
            this.label2.Text = "Factura";
            // 
            // cmbTipoFactura
            // 
            this.cmbTipoFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoFactura.FormattingEnabled = true;
            this.cmbTipoFactura.Location = new System.Drawing.Point(218, 408);
            this.cmbTipoFactura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTipoFactura.Name = "cmbTipoFactura";
            this.cmbTipoFactura.Size = new System.Drawing.Size(44, 23);
            this.cmbTipoFactura.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(214, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Tipo de Factura";
            // 
            // btnIngresarPrimerVenta
            // 
            this.btnIngresarPrimerVenta.BackColor = System.Drawing.Color.Black;
            this.btnIngresarPrimerVenta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIngresarPrimerVenta.ForeColor = System.Drawing.Color.White;
            this.btnIngresarPrimerVenta.Location = new System.Drawing.Point(755, 194);
            this.btnIngresarPrimerVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIngresarPrimerVenta.Name = "btnIngresarPrimerVenta";
            this.btnIngresarPrimerVenta.Size = new System.Drawing.Size(275, 45);
            this.btnIngresarPrimerVenta.TabIndex = 41;
            this.btnIngresarPrimerVenta.Text = "Ingresar Primer Venta";
            this.btnIngresarPrimerVenta.UseVisualStyleBackColor = false;
            this.btnIngresarPrimerVenta.Click += new System.EventHandler(this.btnIngresarPrimerVenta_Click);
            // 
            // btnIngresarSegundaVenta
            // 
            this.btnIngresarSegundaVenta.BackColor = System.Drawing.Color.Black;
            this.btnIngresarSegundaVenta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIngresarSegundaVenta.ForeColor = System.Drawing.Color.White;
            this.btnIngresarSegundaVenta.Location = new System.Drawing.Point(755, 246);
            this.btnIngresarSegundaVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIngresarSegundaVenta.Name = "btnIngresarSegundaVenta";
            this.btnIngresarSegundaVenta.Size = new System.Drawing.Size(275, 45);
            this.btnIngresarSegundaVenta.TabIndex = 42;
            this.btnIngresarSegundaVenta.Text = "Ingresar Segunda Venta";
            this.btnIngresarSegundaVenta.UseVisualStyleBackColor = false;
            this.btnIngresarSegundaVenta.Click += new System.EventHandler(this.btnIngresarSegundaVenta_Click);
            // 
            // btnIngresarTercerVenta
            // 
            this.btnIngresarTercerVenta.BackColor = System.Drawing.Color.Black;
            this.btnIngresarTercerVenta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIngresarTercerVenta.ForeColor = System.Drawing.Color.White;
            this.btnIngresarTercerVenta.Location = new System.Drawing.Point(755, 299);
            this.btnIngresarTercerVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIngresarTercerVenta.Name = "btnIngresarTercerVenta";
            this.btnIngresarTercerVenta.Size = new System.Drawing.Size(275, 45);
            this.btnIngresarTercerVenta.TabIndex = 43;
            this.btnIngresarTercerVenta.Text = "Ingresar Tercer Venta";
            this.btnIngresarTercerVenta.UseVisualStyleBackColor = false;
            this.btnIngresarTercerVenta.Click += new System.EventHandler(this.btnIngresarTercerVenta_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(755, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 37);
            this.label4.TabIndex = 44;
            this.label4.Text = "Ventas HardCodeadas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(732, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(322, 120);
            this.label5.TabIndex = 45;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // btnIngresarCuartaVenta
            // 
            this.btnIngresarCuartaVenta.BackColor = System.Drawing.Color.Black;
            this.btnIngresarCuartaVenta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIngresarCuartaVenta.ForeColor = System.Drawing.Color.White;
            this.btnIngresarCuartaVenta.Location = new System.Drawing.Point(755, 350);
            this.btnIngresarCuartaVenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIngresarCuartaVenta.Name = "btnIngresarCuartaVenta";
            this.btnIngresarCuartaVenta.Size = new System.Drawing.Size(275, 45);
            this.btnIngresarCuartaVenta.TabIndex = 46;
            this.btnIngresarCuartaVenta.Text = "Ingresar Cuarta Venta";
            this.btnIngresarCuartaVenta.UseVisualStyleBackColor = false;
            this.btnIngresarCuartaVenta.Click += new System.EventHandler(this.btnIngresarCuartaVenta_Click);
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHorario.Location = new System.Drawing.Point(827, 408);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(51, 25);
            this.lblHorario.TabIndex = 47;
            this.lblHorario.Text = "Hora";
            // 
            // FrmRegistroDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1066, 452);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.btnIngresarCuartaVenta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnIngresarTercerVenta);
            this.Controls.Add(this.btnIngresarSegundaVenta);
            this.Controls.Add(this.btnIngresarPrimerVenta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTipoFactura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDniCliente);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.txtNombreVendedor);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAgregarVenta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbVenta);
            this.Controls.Add(this.txtUnidades);
            this.Controls.Add(this.lblCantidadDeProductos);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.lblDatosExtra);
            this.Controls.Add(this.cmbPago);
            this.Controls.Add(this.lblPago);
            this.Controls.Add(this.lblApellidoCliente);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtApellCliente);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.lblDatosCliente);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.cmbLitros);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblLitros);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCodigoProducto);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.txtMarca);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmRegistroDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Datos";
            this.Load += new System.EventHandler(this.FrmRegistroDatos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCodigoProducto;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblLitros;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ComboBox cmbLitros;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Label lblDatosCliente;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox txtApellCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblApellidoCliente;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.ComboBox cmbPago;
        private System.Windows.Forms.Label lblDatosExtra;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Label lblCantidadDeProductos;
        private System.Windows.Forms.TextBox txtUnidades;
        private System.Windows.Forms.RichTextBox rtbVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAgregarVenta;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox txtNombreVendedor;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDniCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTipoFactura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIngresarPrimerVenta;
        private System.Windows.Forms.Button btnIngresarSegundaVenta;
        private System.Windows.Forms.Button btnIngresarTercerVenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnIngresarCuartaVenta;
        private System.Windows.Forms.Label lblHorario;
    }
}