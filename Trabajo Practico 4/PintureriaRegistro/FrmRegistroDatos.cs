using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiblioTP3;

namespace PintureriaRegistro
{
    public partial class FrmRegistroDatos : Form
    {
        List<Ventas> ventas;
        List<Cliente> clientes;


        public FrmRegistroDatos()
        {
            InitializeComponent();
        }

        public FrmRegistroDatos(List<Ventas> ventas, List<Cliente> clientes) : this()
        {
            this.ventas = ventas;
            this.clientes = clientes;
        }
        public List<Ventas> Ventas
        {
            get { return ventas; }
        }

        public List<Cliente> Clientes
        {
            get { return clientes; }
        }

        /// <summary>
        /// Evento relacionado con la carga y reseteo de los datos a ingresar. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmRegistroDatos_Load(object sender, EventArgs e)
        {
            Resetear();

            Task.Run(() =>
            {
                ComenzarHorarioActual();
            });

        }
        
        /// <summary>
        /// Evento que hace referencia al boton Resumir Venta. Resume la venta con los datos ingresados y los muestra
        /// en un RichBoxText
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVistaPreviaResumidaDeVenta_Click(object sender, EventArgs e)
        {
            try
            {
                if (CondicionValida())
                {
                    MessageBox.Show("Se deben ingresar todos los datos antes de poder continuar", "Errror en el ingreso de datos");                  
                }
                else
                {
                    if(MetodosAyuda.NumeroPositivo(txtPrecio.Text) && MetodosAyuda.NumeroPositivo(txtUnidades.Text))
                    {
                        rtbVenta.Text = MetodosAyuda.ResumirVenta(txtPrecio.Text, txtMarca.Text, txtCodigo.Text, cmbPago.SelectedItem,
                        txtCliente.Text, txtApellCliente.Text, txtNombreVendedor.Text, txtUnidades.Text);
                    }
                    else
                    {
                        MessageBox.Show("Tanto Precio como Unidades debe ser superior a 0", "Errror en el ingreso de datos");
                        txtPrecio.Text = string.Empty;
                        txtUnidades.Text = string.Empty;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Excepcion Encontrada");
            }
        }

        /// <summary>
        /// Evento relacionado con el click del boton Volver al Inicio. Cierra el formulario actual
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Evento que hace referencia al boton Agregar Datos al Sistema. Agrega los datos ingresados, validos, a la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
           float total = 0;

            try
            {
                if (CondicionValida())
                {
                    MessageBox.Show("Se deben ingresar todos los datos antes de poder continuar", "Errror en el ingreso de datos");
                }
                else
                {
                    if (MetodosAyuda.NumeroPositivo(txtPrecio.Text) && MetodosAyuda.NumeroPositivo(txtUnidades.Text))
                    {
                        total = MetodosAyuda.CalcularTotal(float.Parse(txtPrecio.Text), txtUnidades.Text);

                        Cliente nuevoCliente = new Cliente(txtCliente.Text, txtApellCliente.Text, cmbPago.SelectedItem.ToString(), int.Parse(txtDniCliente.Text));
                        Pintura nuevaPintura = new Pintura(txtMarca.Text, txtCodigo.Text, float.Parse(txtPrecio.Text), (ColorPintura)cmbColor.SelectedItem, (int)cmbLitros.SelectedItem, (TipoPintura)cmbTipo.SelectedItem);
                        Vendedor nuevoVendedor = new Vendedor(txtNombreVendedor.Text, "", MetodosAyuda.CalcularComision(total));

                        Ventas nuevaVenta = MetodosAyuda.AgregarVenta(nuevoCliente, nuevaPintura, nuevoVendedor, total, cmbPago.SelectedItem.ToString(), int.Parse(txtUnidades.Text), Ventas);
                        MetodosAyuda.AgregarClientesLista(nuevoCliente, Clientes);
                        
                        if(nuevaVenta != null)
                        {
                            Factura facturaNueva = new Factura(nuevaVenta, (TipoFactura)cmbTipoFactura.SelectedItem);
                            ManejarArchivos.GuardarDatosEnArchivoDeTexto("FacturasEmitidas.txt", facturaNueva.MostrarDatos(), true);

                            if (this.Ventas != null && Ventas.Count > 0 && facturaNueva != null)
                            {
                                MessageBox.Show($"La venta fue agregada a la lista. Se ha emitido una factura a la venta correspondiente\nEl horario de la venta fue {lblHorario.Text}", "EXITOS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                Resetear();
                            }
                        }       
                    }
                    else
                    {
                        MessageBox.Show("Tanto Precio como Unidades debe ser superior a 0", "Errror en el ingreso de datos");
                        txtPrecio.Text = string.Empty;
                        txtUnidades.Text = string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Excepcion Encontrada");
            }
        }

        /// <summary>
        /// Comienza el hilo secundario en donde se va a dar un bucle, llamando al metodo AsignarHorario() y durmiendo al hilo por 1 segundo.
        /// </summary>
        private void ComenzarHorarioActual()
        {
            Task.Run(() =>
            {
                do
                {
                    AsignarHorario();
                    Thread.Sleep(1000);
                } while (true);

            });
        }

        /// <summary>
        /// Invoca un delegado, con referencia al metodo AsignarHorario() o asigna el horario actual al Label lblHorario.
        /// </summary>
        private void AsignarHorario()
        {
            if (this.InvokeRequired)
            {
                Action delegadoHorario = AsignarHorario;
                this.Invoke(delegadoHorario);
            }
            else
            {
                lblHorario.Text = DateTime.Now.ToString();
            }
        }

        /// <summary>
        /// Resetea los valores de los campos para ingresar datos
        /// </summary>
        private void Resetear()
        {
            txtApellCliente.Text = string.Empty;
            txtCodigo.Text = string.Empty;
            txtCliente.Text = string.Empty;
            txtMarca.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtUnidades.Text = string.Empty;
            cmbTipo.Items.Clear();
            cmbColor.Items.Clear();
            cmbPago.Items.Clear();
            cmbLitros.Items.Clear();
            cmbTipoFactura.Items.Clear();
            txtNombreVendedor.Text = string.Empty;
            txtDniCliente.Text = string.Empty;
            rtbVenta.Text = string.Empty;

            cmbLitros.Items.Add(1);
            cmbLitros.Items.Add(2);
            cmbLitros.Items.Add(4);
            cmbLitros.Items.Add(10);
            cmbLitros.Items.Add(20);

            cmbTipoFactura.Items.Add(TipoFactura.A);
            cmbTipoFactura.Items.Add(TipoFactura.B);

            cmbPago.Items.Add("Tarjeta de Credito");
            cmbPago.Items.Add("Tarjeta de Debito");
            cmbPago.Items.Add("Efectivo");
            cmbPago.Items.Add("Transferencia");

            cmbColor.Items.Add(ColorPintura.Rosa);
            cmbColor.Items.Add(ColorPintura.Blanco);
            cmbColor.Items.Add(ColorPintura.Gris);
            cmbColor.Items.Add(ColorPintura.Beige);
            cmbColor.Items.Add(ColorPintura.Negro);
            cmbColor.Items.Add(ColorPintura.Azul);
            cmbColor.Items.Add(ColorPintura.Amarillo);
            cmbColor.Items.Add(ColorPintura.Verde);

            cmbTipo.Items.Add(TipoPintura.Latex);
            cmbTipo.Items.Add(TipoPintura.Esmalte);
            cmbTipo.Items.Add(TipoPintura.Cieloraso);
            cmbTipo.Items.Add(TipoPintura.Barniz);
        }

        /// <summary>
        /// Valida que alguna de estas condiciones sean verdaderas. Es para emprolijar el codigo en los formularios
        /// </summary>
        /// <returns>Devuelve true si se cumple la condicion, sino false</returns>
        private bool CondicionValida()
        {
            if(string.IsNullOrEmpty(txtApellCliente.Text) || string.IsNullOrEmpty(txtCliente.Text) ||
               string.IsNullOrEmpty(txtCodigo.Text) || string.IsNullOrEmpty(txtMarca.Text) ||
               string.IsNullOrEmpty(txtPrecio.Text) || string.IsNullOrEmpty(txtUnidades.Text) ||
               cmbTipo.SelectedItem == null || cmbPago.SelectedItem == null ||
               cmbColor.SelectedItem == null || cmbLitros.SelectedItem == null || string.IsNullOrEmpty(txtNombreVendedor.Text) ||
               string.IsNullOrEmpty(txtDniCliente.Text) || cmbTipoFactura.SelectedItem == null)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Evento que hace referencia al click del boton IngresarPrimeraVenta. Ingresa datos hardcodeados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIngresarPrimerVenta_Click(object sender, EventArgs e)
        {
            txtApellCliente.Text = "Mendoza";
            txtCodigo.Text = "SW995";
            txtCliente.Text = "Juan Pablo";
            txtMarca.Text = "Sherwin Williams";
            txtPrecio.Text = "2350";
            txtUnidades.Text = "1";
            cmbTipo.SelectedItem = TipoPintura.Esmalte;
            cmbColor.SelectedItem = ColorPintura.Beige;
            cmbPago.SelectedItem = "Efectivo";
            cmbLitros.SelectedItem = 1;
            cmbTipoFactura.SelectedItem = TipoFactura.B;
            txtNombreVendedor.Text = "Esteban";
            txtDniCliente.Text = "39854233";
        }

        /// <summary>
        /// Evento que hace referencia al click del boton IngresarSegundaVenta. Ingresa datos hardcodeados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIngresarSegundaVenta_Click(object sender, EventArgs e)
        {
            txtApellCliente.Text = "Costa";
            txtCodigo.Text = "AB199";
            txtCliente.Text = "Fabian";
            txtMarca.Text = "Alba";
            txtPrecio.Text = "15700";
            txtUnidades.Text = "2";
            cmbTipo.SelectedItem = TipoPintura.Latex;
            cmbColor.SelectedItem = ColorPintura.Blanco;
            cmbPago.SelectedItem = "Tarjeta de Credito";
            cmbLitros.SelectedItem = 20;
            cmbTipoFactura.SelectedItem = TipoFactura.B;
            txtNombreVendedor.Text = "Jose";
            txtDniCliente.Text = "21199878";

        }

        /// <summary>
        /// Evento que hace referencia al click del boton IngresarTercerVenta. Ingresa datos hardcodeados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIngresarTercerVenta_Click(object sender, EventArgs e)
        {
            txtApellCliente.Text = "Lopez Podesta";
            txtCodigo.Text = "RP089";
            txtCliente.Text = "Maria";
            txtMarca.Text = "Recuplast";
            txtPrecio.Text = "9500";
            txtUnidades.Text = "2";
            cmbTipo.SelectedItem = TipoPintura.Barniz;
            cmbColor.SelectedItem = ColorPintura.Negro;
            cmbPago.SelectedItem = "Transferencia";
            cmbLitros.SelectedItem = 10;
            cmbTipoFactura.SelectedItem = TipoFactura.A;
            txtNombreVendedor.Text = "Esteban";
            txtDniCliente.Text = "27009171";
        }

        /// <summary>
        /// Evento que hace referencia al click del boton IngresarCuartaVenta. Ingresa datos hardcodeados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIngresarCuartaVenta_Click(object sender, EventArgs e)
        {
            txtApellCliente.Text = "Perez Garcia";
            txtCodigo.Text = "CL576";
            txtCliente.Text = "Celeste";
            txtMarca.Text = "Colorin";
            txtPrecio.Text = "27460";
            txtUnidades.Text = "2";
            cmbTipo.SelectedItem = TipoPintura.Esmalte;
            cmbColor.SelectedItem = ColorPintura.Blanco;
            cmbPago.SelectedItem = "Efectivo";
            cmbLitros.SelectedItem = 10;
            cmbTipoFactura.SelectedItem = TipoFactura.A;
            txtNombreVendedor.Text = "Rodrigo";
            txtDniCliente.Text = "32127097";
        }
    }
}
