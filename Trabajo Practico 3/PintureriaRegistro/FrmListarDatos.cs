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

        public List<Ventas> Venta
        {
            get { return this.ventas; }
        }

        public FrmListarDatos()
        {
            InitializeComponent();
        }

        public FrmListarDatos(List<Ventas> venta) : this()
        {
            this.ventas = venta;
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
                foreach(Ventas ventas in this.Venta)
                {
                    lsbListadoVentas.Items.Add(ventas.ToString());
                }
            }
            MessageBox.Show("Tenga en cuenta que al guardar la lista en un Archivo Xml, se va a sobrescribir","Atencion",MessageBoxButtons.OK);
        }

        /// <summary>
        /// Evento relacionado con el click del Boton Agregar Datos a un Archivo txt. Agrega los datos de las ventas a un archivo
        /// txt, con determinado path. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarArchivo_Click(object sender, EventArgs e)
        {

            try
            {
                string path = "VentasTexto.txt";

                if(lsbListadoVentas.Items.Count > 0)
                {
                    foreach (Ventas ventas in this.ventas)
                    {
                        ManejarArchivos.GuardarArchivo(path, ventas.ToString(), true);
                    }
                    MessageBox.Show("Archivo Txt cargado con datos", "Exitos");
                }
                else
                {
                    MessageBox.Show("Debe tener datos cargados en la lista para poder cargar datos a un Archivo de Texto", "Error");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Excepcion Encontrada");
            }
        }


        /// <summary>
        /// Evento relacionado con el click del Boton Agregar Datos a un Archivo xml. Agrega la lista de ventas a un archivo xml
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarXml_Click(object sender, EventArgs e)
        {
           try
           {
                string path = "Ventas.xml";

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
        private void btnEliminarSeleccion_Click(object sender, EventArgs e)
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
