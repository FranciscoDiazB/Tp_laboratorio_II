using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTP3
{
    public class Vendedor : Persona, IMostrarDatos
    {
        private float comision;

        public float Comision { get => comision; set => comision = value; }

        public Vendedor()
        {

        }

        public Vendedor(string nombre, string apellido, float numero) : base(nombre, apellido)
        {
            this.comision = numero;   
        }

        /// <summary>
        /// Muestra los datos del Vendedor
        /// </summary>
        /// <returns>Devuelve una cadena de caracteres con los datos del vendedor</returns>
        public override string MostrarDatos()
        {
            return $"Vendedor: {base.MostrarDatos()} - Comision: ${this.Comision}";
        }

    }
}
