using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiblioTP3;

namespace PintureriaRegistro
{
    public partial class FrmRegistroDatos : Form
    {
        List<Ventas> ventas;


        public FrmRegistroDatos()
        {
            InitializeComponent();
        }

        public FrmRegistroDatos(List<Ventas> ventas) : this()
        {
            this.ventas = ventas;
        }
        public List<Ventas> Ventas
        {
            get { return ventas; }
        }

        /// <summary>
        /// Evento relacionado con la carga y reseteo de los datos a ingresar. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmRegistroDatos_Load(object sender, EventArgs e)
        {
            Resetear();
        }
        
        /// <summary>
        /// Evento que hace referencia al boton Resumir Venta. Resume la venta con los datos ingresados y los muestra
        /// en un RichBoxText
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
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

                        Cliente nuevoCliente = new Cliente(txtCliente.Text, txtApellCliente.Text, cmbPago.SelectedItem.ToString());
                        Pintura nuevaPintura = new Pintura(txtMarca.Text, txtCodigo.Text, float.Parse(txtPrecio.Text), (ColorPintura)cmbColor.SelectedItem, (int)cmbLitros.SelectedItem, (TipoPintura)cmbTipo.SelectedItem);
                        Vendedor nuevoVendedor = new Vendedor(txtNombreVendedor.Text, "", MetodosAyuda.CalcularComision(total));

                        MetodosAyuda.AgregarVenta(nuevoCliente, nuevaPintura, nuevoVendedor, total, cmbPago.SelectedItem.ToString(), int.Parse(txtUnidades.Text), Ventas);

                        if (this.Ventas != null && Ventas.Count > 0)
                        {
                            MessageBox.Show("La venta fue agregada a la lista", "EXITOS");
                            Resetear();
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
            txtNombreVendedor.Text = string.Empty;

            cmbLitros.Items.Add(1);
            cmbLitros.Items.Add(2);
            cmbLitros.Items.Add(4);
            cmbLitros.Items.Add(10);
            cmbLitros.Items.Add(20);

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
               cmbColor.SelectedItem == null || cmbLitros.SelectedItem == null || string.IsNullOrEmpty(txtNombreVendedor.Text))
            {
                return true;
            }
            return false;
        }
    }
}
