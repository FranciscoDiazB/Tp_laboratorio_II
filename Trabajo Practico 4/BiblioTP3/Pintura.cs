using System;
using System.Text;

namespace BiblioTP3
{
    public enum TipoPintura
    {
        Latex, Esmalte, Cieloraso, Barniz
    }

    public enum ColorPintura
    {
        Blanco, Negro, Gris, Beige, Amarillo, Azul, Rosa, Marron, Verde
    }
    public class Pintura : IMostrarDatos
    {
        private string marca;
        private float precioVenta;
        private string codigoProducto;
        private int volumen;
        private TipoPintura tipo;
        private ColorPintura color;

        public ColorPintura Color
        {
            get { return this.color; }
            set
            {
                this.color = value;
            }
        }

        public TipoPintura Tipo
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }

        public int Volumen
        {
            get { return this.volumen; }
            set
            {
                if (ValidarVolumen(value))
                {
                    this.volumen = value;
                }
            }
        }

        public string Marca
        {
            get { return marca; }
            set
            {
                if(value != null)
                {
                    this.marca = value;
                }
            }
        }

        public float Precio
        {
            get { return precioVenta; }
            set 
            { 
                if(value > 0)
                {
                    precioVenta = value;
                }
            }
        }

        public string CodigoProducto
        {
            get { return codigoProducto; }
            set { codigoProducto = value; }
        }

        public Pintura()
        {

        }

        public Pintura(string marca, float precio, string codigo)    
        {
            this.Precio = precio;
            this.Marca = marca; 
            this.CodigoProducto = codigo;
        }

        public Pintura(string marca, string codigo, float precio, ColorPintura color, int volumen,
            TipoPintura tipo) : this(marca, precio, codigo)
        {
            this.Volumen = volumen;
            this.Tipo = tipo;
            this.Color = color;
        }

        /// <summary>
        /// Muestra los datos correspondientes a la pintura
        /// </summary>
        /// <returns>Devuelve una cadena de caracteres</returns>
        public string MostrarDatos()
        {
            return $"Marca: {this.Marca} - Codigo: {this.CodigoProducto} - {this.Tipo} {this.Color} - Litros: {this.Volumen} - ";
        }

        /// <summary>
        /// Metodo implementado en el set de la propiedad Precio. Valida si el numero es 1, 2 , 4, 10 o 20.
        /// </summary>
        /// <param name="volumen"></param>
        /// <returns>Devuelve true si lo es, false si no lo es</returns>
        private bool ValidarVolumen(int volumen)
        {
            bool retorno = false;

            if (volumen == 1 || volumen == 2 || volumen == 4 || volumen == 10 || volumen == 20)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
