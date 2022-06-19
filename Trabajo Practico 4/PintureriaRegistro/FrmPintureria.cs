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
        List<Cliente> clienteList;

        public FrmPintureria()
        {
            InitializeComponent();
            listaVenta = new List<Ventas>();
            clienteList = new List<Cliente>();

        }

        private List<Ventas> Ventas
        {
            get { return listaVenta; }
        }

        private List<Cliente> ClienteList
        {
            get { return clienteList; }
        }

        private void FrmPintureria_Load(object sender, EventArgs e)
        {
         
        }

        /// <summary>
        /// Evento relacionado con el click del boton Ingresar Datos al Sistema. Instancia un formulario y lo muestra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRealizarVenta_Click(object sender, EventArgs e)
        {
            FrmRegistroDatos frmRegistrar = new FrmRegistroDatos(Ventas, ClienteList);

            frmRegistrar.Show();
        }

        /// <summary>
        /// Evento relacionado con el click del boton Listar Datos del Sistema. Instancia un formulario y lo muestra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrarListadoDeVentas_Click(object sender, EventArgs e)
        {
            FrmListarDatos frmListarDatos = new FrmListarDatos(Ventas, ClienteList);

            frmListarDatos.Show();
        }

        /// <summary>
        /// Evento relacionado con el click del boton Mostrar un Archivo de Texto. Instancia un formulario y lo muestra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /*private void btnMostrarArchivoTxt_Click(object sender, EventArgs e)
        {
            FrmImportarArchivo frmArchivo = new FrmImportarArchivo(Ventas);

            frmArchivo.Show();
        }*/

        /// <summary>
        /// Evento relacionado con el click del boton Importar un Archivo XML. Lee el archivo xml y asigna una lista de ventas
        /// al atributo del formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImportarVentasDeArchivoXml_Click(object sender, EventArgs e)
        {
            try
            {
                string path = "VentasArchivo.xml";
                this.listaVenta = Serializador<List<Ventas>>.LeerArchivoXml(path);
                MetodosAyuda.AgregarClientesImportados(ClienteList, Ventas);

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

        /// <summary>
        /// Evento relacionado con el click del boton Mostrar Listado de Clientes. Crea una nueva instancia de un formulario
        /// y muestra los clientes en el sistema.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrarListadoDeClientes_Click(object sender, EventArgs e)
        {
            FrmListadoClientes frmClientes = new FrmListadoClientes(Ventas, clienteList);

            frmClientes.Show();
        }

        /// <summary>
        /// Evento relacionado con el click del boton Mostrar Listado de Facturas Emitidas. Crea una nueva instancia de un formulario
        /// y uno dentro del formulario mismo, podra importar un archivo de texto el cual mostrara el listado de las facturas emitidas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrarListadoDeFacturasEmitidas_Click(object sender, EventArgs e)
        {
            FrmListadoFacturasEmitidas frmArchivo = new FrmListadoFacturasEmitidas(Ventas);

            frmArchivo.Show();
        }
    }
}
