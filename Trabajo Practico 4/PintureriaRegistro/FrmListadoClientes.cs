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
    public partial class FrmListadoClientes : Form
    {
        List<Ventas> ventas;
        List<Cliente> listaClientes;

        public FrmListadoClientes()
        {
            InitializeComponent();
        }

        public List<Cliente> ListaClientes
        {
            get { return this.listaClientes; }
        }

        public FrmListadoClientes(List<Ventas> venta, List<Cliente> clientes) : this()
        {
            this.ventas = venta;
            this.listaClientes = clientes;  
        }

        private void FrmListadoClientes_Load(object sender, EventArgs e)
        {
            try
            {
                if(this.ListaClientes != null && this.ventas != null)
                {
                    MetodosAyuda.OrdenarListaDeClientesDni(ListaClientes);

                    lsbListadoDeClientes.DataSource = this.ListaClientes;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Excepcion Encontrada");
            }
        }

        /// <summary>
        /// Referencia a un evento, el cual al realizar el click del boton Volver, cierra el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Hace referencia a un evento, el cual va a importar los clientes que ya estan en la base de datos y los va a mostrar
        /// en un listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImportarClientesBaseDatos_Click(object sender, EventArgs e)
        {
            try
            {
                CargarBarrra();

                ClienteDAO clienteDAO = new ClienteDAO();

                lsbListadoClientesBD.DataSource = clienteDAO.LeerClientesDesdeBaseDeDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Hace referencia a un evento, el cual va a eliminar el cliente seleccionado (de un listbox) de la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminarSeleccionDeBaseDeDatos_Click(object sender, EventArgs e)
        {
            try
            {
                if(lsbListadoClientesBD.SelectedItem is null)
                {
                    MessageBox.Show("Se debe seleccionar algun Cliente de la Lista","Error");
                }
                else
                {
                    ClienteDAO clienteDAO = new ClienteDAO();

                    Cliente cliente = (Cliente)lsbListadoClientesBD.SelectedItem;

                    if (cliente is not null)
                    {
                        clienteDAO.EliminarClienteSeleccionadoBD(cliente);
                        MessageBox.Show("Cliente eliminado de la Base de Datos", "Exitos");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Excepcion Encontrada");
            }
        }

        /// <summary>
        /// Hace referencia a un evento, el cual va a agregar el cliente seleccionado (de un listbox) a una base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarSeleccionABaseDatos_Click(object sender, EventArgs e)
        {
            try
            {
                if(lsbListadoDeClientes.SelectedItem is null)
                {
                    MessageBox.Show("Se debe seleccionar algun Cliente de la Lista", "Error");
                }
                else
                {
                    ClienteDAO clienteDAO = new ClienteDAO();

                    Cliente cliente = (Cliente) lsbListadoDeClientes.SelectedItem;

                    if(cliente is not null)
                    {
                        clienteDAO.GuardarClienteEnBaseDeDatos(cliente);
                        MessageBox.Show("Cliente añadido a la Base de Datos", "Exitos");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Excepcion Encontrada");
            }
        }

        /// <summary>
        /// Metodo el cual, asignara el valor recibido por un metodo. Este seria un subproceso. 
        /// </summary>
        private void AsignarValorDeBarra()
        {
            CargandoBarra cargandoBarra = new CargandoBarra();
            cargandoBarra.OnBarraCompleta += MostrarProgresoCompletado;

            if (this.InvokeRequired)
            {
                Action delegadoProgreso = AsignarValorDeBarra;
                this.Invoke(delegadoProgreso);
            }
            else
            {
                pBarCargando.Value = cargandoBarra.CargarBarra(pBarCargando.Value);
            }
        }

        /// <summary>
        /// Metodo el cual realiza una tarea.
        /// </summary>
        private void CargarBarrra()
        {
            Task.Run(() =>
            {
                AsignarValorDeBarra();
            });
        }

        /// <summary>
        /// Hace referencia a la emision del mensaje de un evento.
        /// </summary>
        private void MostrarProgresoCompletado()
        {
            MessageBox.Show("Finalizo la importacion de Clientes. Los datos estan cargados en el sistema", "Exitos", MessageBoxButtons.OK);
        }
    }
}
