using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTP3
{

    public enum TipoFactura
    {
        A, B
    }
    public class Factura
    {

        private Ventas venta;
        private TipoFactura factura;
        private string consumidorFinal; 

        public Ventas Ventas
        {
            get { return venta; }
            set { venta = value; }
        }

        public TipoFactura Facturas
        {
            get { return factura; }
            set { factura = value; }
        }

        public string ConsumidorFinal
        {
            get { return consumidorFinal; }
        }

        public Factura(Ventas venta, TipoFactura factura)
        {
            this.venta = venta;
            this.factura = factura;
            this.consumidorFinal = ValidarConsumidorFinal(factura);
        }

        /// <summary>
        /// Muestra los datos presentes en la factura
        /// </summary>
        /// <returns></returns>
        public string MostrarDatos()
        {
            return $"{this.Ventas.Cliente.ToString()} - Codigo del Producto: {this.Ventas.Pintura.CodigoProducto} - Total: ${this.Ventas.PrecioTotal} - Tipo de Factura: {this.Facturas} - Consumidor Final: {this.ConsumidorFinal} - Fecha: {this.Ventas.FechaVenta}";
        }

        /// <summary>
        /// Validara, dependiendo el tipo de factura que se haya elegido para emitir, si el cliente es consumidor final o no
        /// </summary>
        /// <param name="factura"></param>
        /// <returns></returns>
        private string ValidarConsumidorFinal(TipoFactura factura)
        {
            string retorno;

            if (factura == TipoFactura.A)
            {
                retorno = "No";
            }
            else 
            {
                retorno = "Si";
            }

            return retorno;
        }
    }
}
