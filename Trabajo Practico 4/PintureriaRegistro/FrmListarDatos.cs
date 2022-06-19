using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BiblioTP3;
using static System.Environment;

namespace PintureriaRegistro
{
    public partial class FrmListarDatos : Form
    {
        List<Ventas> ventas;
        List<Cliente> clientes;

        public List<Ventas> Venta
        {
            get { return this.ventas; }
        }

        public List<Cliente> Clientes
        {
            get { return this.clientes; }
        }

        public FrmListarDatos()
        {
            InitializeComponent();
        }

        public FrmListarDatos(List<Ventas> venta, List<Cliente> clientes) : this()
        {
            this.ventas = venta;
            this.clientes = clientes;
        }

        /// <summary>
        /// Aqui es donde se cargan los datos de la lista para que comience con la visualizacion de la misma, pero antes
        /// da un mensaje para tener en cuenta.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmListarDatos_Load(object sender, EventArgs e)
        {
            if( this.Venta != null)
            {
                MetodosAyuda.OrdenarListaDeVentas(this.ventas);

                foreach(Ventas ventas in this.Venta)
                {
                    lsbListadoVentas.Items.Add(ventas.ToString());
                }
            }
            MessageBox.Show("Tenga en cuenta que al guardar la lista en un Archivo Xml, se va a sobrescribir","Atencion",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

  


        /// <summary>
        /// Evento relacionado con el click del Boton Agregar Datos a un Archivo xml. Agrega la lista de ventas a un archivo xml
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarDatosArchivoXml_Click(object sender, EventArgs e)
        {
           try
           {
                string path = "VentasArchivo.xml";

                if (lsbListadoVentas.Items.Count > 0)
                {
                    Serializador<List<Ventas>>.GuardarArchivoXml(Venta, path);
                    MessageBox.Show("Archivo Xml cargado con datos","Exitos");
                }
                else
                {
                    MessageBox.Show("Debe tener datos cargados en la lista", "Error");
                }
           }
           catch (Exception ex)
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
        /// Evento relacionado con el click del boton Eliminar Seleccion. Elimina el elemento venta seleccionado en el list box.
        /// El proceso puede repetirse hasta que no haya elementos en la lista. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminarVentaSeleccionada_Click(object sender, EventArgs e)
        {
            try
            {
                if(lsbListadoVentas.Items.Count <= 0)
                {
                    MessageBox.Show("No puede acceder a esta opcion ya que no hay elementos en la lista", "Error");
                }
                else
                {
                    if(lsbListadoVentas.SelectedItem == null)
                    {
                        MessageBox.Show("No se puede realizar esta accion ya que debe seleccionar una venta para eliminar", "Error");
                    }
                    else
                    {

                        MetodosAyuda.EliminarVenta(this.ventas, lsbListadoVentas.SelectedItem);
                        lsbListadoVentas.DataSource = null;
                        lsbListadoVentas.DataSource = Venta;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Excepcion Encontrada");
            }
        }
    }
}
