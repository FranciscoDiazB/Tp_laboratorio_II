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
using static System.Environment;

namespace PintureriaRegistro
{
    public partial class FrmListadoFacturasEmitidas : Form
    {
        List<Ventas> listaVentas;

        public FrmListadoFacturasEmitidas()
        {
            InitializeComponent();
        }

        public FrmListadoFacturasEmitidas(List<Ventas> lista) : this()
        {
            this.listaVentas = lista;
        }

        public List<Ventas> ListaVentas
        {
            get { return listaVentas; }
            set { listaVentas = value; }
        }

        private void FrmImportarArchivo_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Evento relacionado con el click del Boton Mostrar un Archivo de Texto. Muestra el archivo de texto en un RichTextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrarFacturasEmitidas_Click(object sender, EventArgs e)
        {
            try
            {
                string path = "FacturasEmitidas.txt";
                rtbMostrarTexto.Text = ManejarArchivos.LeerDatosDeUnArchivoTexto(path);
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
        private void btnInicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
