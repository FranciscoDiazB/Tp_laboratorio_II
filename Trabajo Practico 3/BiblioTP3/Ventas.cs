using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTP3
{
    public class Ventas 
    {
        DateTime fechaDeVenta;
        int cantidadUnidades; 
        Cliente cliente;
        Vendedor vendedor;
        Pintura pintura;
        float precioTotal;

        public int Unidades
        {
            get { return cantidadUnidades; }
            set 
            { 
                if(value > 0)
                {
                    cantidadUnidades = value;
                }
            }
        }

        public DateTime FechaVenta
        {
            get { return fechaDeVenta; }
            set 
            { 
               fechaDeVenta = value;
            }
        }

        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public Pintura Pintura
        {
            get { return pintura; }
            set { pintura = value; }
        }

        public Vendedor Vendedor
        {
           get { return vendedor; }
            set
            {
                vendedor = value;
            }
        }

        public float PrecioTotal
        {
            get { return precioTotal; }
            set
            {
                precioTotal = value;
            }
        }

        public Ventas()
        {

        }

        public Ventas(Cliente cliente, Pintura pintura, Vendedor vendedor, float precioTotal, int unidades)
        {
            this.FechaVenta = DateTime.Now;
            this.Unidades = unidades;
            this.Cliente = cliente;
            this.Vendedor = vendedor;
            this.Pintura = pintura;
            this.PrecioTotal = precioTotal;
        }

        /// <summary>
        /// Sobrecarga del metodo ToString para informar por pantalla los datos de la venta. 
        /// </summary>
        /// <returns>Devuelve una cadena de caracteres</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(this.Pintura.MostrarDatos());
            sb.Append($"Unidades: {this.cantidadUnidades} - Total: ${this.PrecioTotal} - ");
            sb.Append($"{this.Cliente.MostrarDatos()} - ");
            sb.Append(this.Vendedor.MostrarDatos());
            sb.Append($" - Fecha de la Venta: {this.fechaDeVenta}");

            return sb.ToString();
        }

    }
}
