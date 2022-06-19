using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioTP3
{
    public class Persona : IMostrarDatos
    {
        string nombre;
        string apellido;

        public string Nombre { get => nombre; set => nombre = value; }

        public string Apellido { get => apellido; set => apellido = value; }

        public Persona()
        {

        }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
        
        /// <summary>
        /// Muestra los datos relacionados a una persona.
        /// </summary>
        /// <returns>Devuelve una cadena de caracteres con los datos de una persona</returns>
        public virtual string MostrarDatos()
        {
            return $"{this.nombre} {this.apellido}";
        }


    }
}
