using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTP3
{
    public class Cliente : Persona
    {
        private string metodoPago;
        private int dni;

        public string MetodoPago { get => metodoPago;  set => metodoPago = value;}

        public int Dni { get => dni; set => dni = value; }

        public Cliente()
        {

        }

        public Cliente(string nombre, string apellido, string pago, int dni) : base(nombre, apellido)
        {
            this.metodoPago = pago;
            this.dni = dni;
        }

        /// <summary>
        /// Muestra los datos correspondientes a un Cliente
        /// </summary>
        /// <returns>Devuelve una cadena de caracteres que corresponden a los datos del Cliente</returns>
        public override string MostrarDatos()
        {
            return $"Cliente: {base.MostrarDatos()} - Pago: {this.MetodoPago} - Dni: {this.Dni}";
        }

        /// <summary>
        /// Sobrecarga del metodo ToString(). Muestra los datos del cliente
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Cliente: {this.Nombre} {this.Apellido} - Pago: {this.MetodoPago} - Dni: {this.Dni}";
        }
    }
}
