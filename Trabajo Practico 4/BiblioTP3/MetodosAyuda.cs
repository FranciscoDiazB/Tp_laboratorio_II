using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTP3
{
    public static class MetodosAyuda
    {


        /// <summary>
        /// Resume una venta con los datos ingresado en el formulario FrmRegistrarDatos
        /// </summary>
        /// <param name="precio"></param>
        /// <param name="marca"></param>
        /// <param name="codigo"></param>
        /// <param name="pago"></param>
        /// <param name="nombreCliente"></param>
        /// <param name="apellidoCliente"></param>
        /// <param name="nombreVendedor"></param>
        /// <param name="unidades"></param>
        /// <returns>Una cadena de caracteres con los datos del resumen</returns>
        public static string ResumirVenta(string precio, string marca, string codigo, object pago, string nombreCliente, string apellidoCliente, string nombreVendedor, string unidades)
        {
            float total;
            StringBuilder sb = new StringBuilder();
            try
            {
                total = (float)float.Parse(precio) * float.Parse(unidades);
                sb.AppendLine($"{marca} {codigo}");
                sb.AppendLine($"Subtotal Pre Descuento: ${total}");
                sb.AppendLine($"Total: ${AplicarDescuentoCorrespondiente(total, pago.ToString())} Pago: {pago}");
                sb.AppendLine($"Cliente: {apellidoCliente}, {nombreCliente}");
                sb.AppendLine($"Vendedor: {nombreVendedor} "); 
            }
            catch (Exception)
            {
                throw;
            }
            return sb.ToString();
        }

        /// <summary>
        /// Valida que el numero sea positivo, recibiendo una cadena de caracteres por parametro. 
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>Retorna true si lo es, sino retorna false</returns>
        public static bool NumeroPositivo(string numero)
        {
            if(int.Parse(numero) > 0)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Recibe un flotante y calcula la comision que le corresponde al empleado, teniendo en cuenta el total de la venta
        /// </summary>
        /// <param name="total"></param>
        /// <returns>Retorna un flotante, correspondiente a la comision del empleado</returns>
        public static float CalcularComision(float total)
        {
            float comision;
   
            if (total > 0 && total < 15000)
            {
                comision = 0;
            }
            else if (total >= 15000 && total < 30000)
            {
                comision = (float)(total * 0.05);
            }
            else
            {
                comision = (float)(total * 0.1);
            }

            return comision;
        }

        /// <summary>
        /// Calcula el total de la venta, recibiendo un flotante y un string por parametros
        /// </summary>
        /// <param name="precio"></param>
        /// <param name="unidades"></param>
        /// <returns>Devuelve el total de la venta</returns>
        public static float CalcularTotal(float precio, string unidades)
        {
            return (float)precio * int.Parse(unidades);
        }

        /// <summary>
        /// Aplica el descuento en el caso correspondiente, recibiendo un flotante y un string relacionado al metodo de pago.
        /// </summary>
        /// <param name="precio"></param>
        /// <param name="pago"></param>
        /// <returns>El nuevo valor del total, con descuento aplicado</returns>
        public static float AplicarDescuentoCorrespondiente(float precio, string pago)
        {
            if(pago == "Efectivo")
            {
                precio = (float) (precio * 0.9);
            }
            else if(pago == "Transferencia" || pago == "Tarjeta de Debito")
            {
                precio = (float)(precio * 0.95);
            }
            return precio;
        }

        /// <summary>
        /// Agrega una venta a la lista, recibiendo un cliente, una pintura, un vendedor, un flotante, un string, un dato numerico y 
        /// la lista a donde va a ser agregada la nueva venta. 
        /// </summary>
        /// <param name="c"></param>
        /// <param name="p"></param>
        /// <param name="v"></param>
        /// <param name="total"></param>
        /// <param name="pago"></param>
        /// <param name="unidades"></param>
        /// <param name="ventas"></param>
        public static Ventas AgregarVenta(Cliente c, Pintura p, Vendedor v, float total, string pago, int unidades, List<Ventas> ventas)
        {

            if (c is not null &&  p is not null && v is not null)
            {
                Ventas nuevaVenta = new Ventas(c, p, v, MetodosAyuda.AplicarDescuentoCorrespondiente(total, pago), unidades);

                if (nuevaVenta != null)
                {
                    ventas.Add(nuevaVenta);
                    return nuevaVenta;
                }
            }
            return null;
        }

        /// <summary>
        /// Agregar un cliente pasado por parametro, a la lista tambien pasada por parametro
        /// </summary>
        /// <param name="c"></param>
        /// <param name="clientesLista"></param>
        public static void AgregarClientesLista(Cliente c, List<Cliente> clientesLista)
        {
            if(c is not null && clientesLista != null)
            {
                clientesLista.Add(c);
            }
        }

        /// <summary>
        /// Agrega una lista de clientes, los cuales fueron importados a traves de un archivo Xml
        /// </summary>
        /// <param name="clientes"></param>
        /// <param name="ventas"></param>
        public static void AgregarClientesImportados(List<Cliente> clientes, List<Ventas> ventas)
        {
            if(clientes != null && ventas != null)
            {
                foreach (Ventas ventasItem in ventas)
                {
                    Cliente nuevoCliente = new Cliente(ventasItem.Cliente.Nombre, ventasItem.Cliente.Apellido, ventasItem.Cliente.MetodoPago, ventasItem.Cliente.Dni);

                    clientes.Add(nuevoCliente);
                }
            }
        }

        /// <summary>
        /// Elimina una venta, la cual se le va a pasar por parametros de una lista, la cual tambien recibe por parametros
        /// </summary>
        /// <param name="ventas"></param>
        /// <param name="venta"></param>
        public static void EliminarVenta(List<Ventas> ventas, object venta)
        {
            Ventas ventaSeleccionada = venta as Ventas;

            if (ventaSeleccionada is not null)
            {
                ventas.Remove(ventaSeleccionada);
            }
        }

        /// <summary>
        /// Ordenara la lista de ventas por Precio total de la venta, en orden ascendente
        /// </summary>
        /// <param name="ventas"></param>
        public static void OrdenarListaDeVentas(List<Ventas> ventas)
        {
            ventas.Sort((a, b) =>
            {
                return (int)(a.PrecioTotal - b.PrecioTotal);
            });       
        }

        /// <summary>
        /// Ordenara la lista de clientes por Dni en orden ascendente
        /// </summary>
        /// <param name="clientes"></param>
        public static void OrdenarListaDeClientesDni(List<Cliente> clientes)
        {
            try
            {
                clientes.Sort((a, b) =>
                { 
                    return (int)(a.Dni - b.Dni);
                });
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
