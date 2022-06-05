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
    public partial class FrmPintureria : Form
    {
        List<Ventas> listaVenta;

        public FrmPintureria()
        {
            InitializeComponent();
            listaVenta = new List<Ventas>();

        }

        private List<Ventas> Ventas
        {
            get { return listaVenta; }
        }

        private void FrmPintureria_Load(object sender, EventArgs e)
        {
         
        }

        /// <summary>
        /// Evento relacionado con el click del boton Ingresar Datos al Sistema. Instancia un formulario y lo muestra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIngresoDatos_Click(object sender, EventArgs e)
        {
            FrmRegistroDatos frmRegistrar = new FrmRegistroDatos(Ventas);

            frmRegistrar.Show();
        }

        /// <summary>
        /// Evento relacionado con el click del boton Listar Datos del Sistema. Instancia un formulario y lo muestra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListarDatos_Click(object sender, EventArgs e)
        {
            FrmListarDatos frmListarDatos = new FrmListarDatos(Ventas);

            frmListarDatos.Show();
        }

        /// <summary>
        /// Evento relacionado con el click del boton Mostrar un Archivo de Texto. Instancia un formulario y lo muestra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrarArchivoTxt_Click(object sender, EventArgs e)
        {
            FrmImportarArchivo frmArchivo = new FrmImportarArchivo(Ventas);

            frmArchivo.Show();
        }

        /// <summary>
        /// Evento relacionado con el click del boton Importar un Archivo XML. Lee el archivo xml y asigna una lista de ventas
        /// al atributo del formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImportarXLM_Click(object sender, EventArgs e)
        {
            try
            {
                string path = "Ventas.xml";
                this.listaVenta = Serializador<List<Ventas>>.LeerArchivoXml(path);
                if (this.listaVenta.Count > 0)
                {
                    MessageBox.Show("Lista de Ventas Cargada desde el Archivo Xml", "Exitos");
                }
                else
                {
                    MessageBox.Show("Hubo un problema al realizar la carga da Datos", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Excepcion Encontrada");
            }
        }
    }
}
