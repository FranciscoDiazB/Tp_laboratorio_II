using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        private double numero;
        
        public string Numero
        {
            set 
            {
                numero = ValidarOperando(value);            
            }
        }

        private static double ValidarOperando(string strNumero)
        {
            double retorno;

            if(double.TryParse(strNumero, out retorno) == false)
            {
                retorno = 0;
            }         
            return retorno;
        }

        private bool EsBinario(string binario)
        {
            bool retorno = false;
            int acuValidez = 0;

            foreach(char cadaCaracter in binario)
            {
                if(cadaCaracter == '0' || cadaCaracter == '1')
                {
                    acuValidez++;
                }
            }

            if(acuValidez == binario.Length)
            {
                retorno = true;
            }
            return retorno;
        }

        public string BinarioDecimal(string binario)
        {
            string nDecimalString = "Valor Invalido";
            int resto = 0;
            double nDecimalDouble = 0;
            int i = 0;

            if (EsBinario(binario))
            {
                int aux = int.Parse(binario);
                while (aux != 0)
                {
                    resto = aux % 10;
                    aux = aux / 10;
                    nDecimalDouble = nDecimalDouble + resto * Math.Pow(2, i);
                    i++;
                }
                nDecimalString = nDecimalDouble.ToString();
            }
            return nDecimalString;
        }

        public string DecimalBinario(double numero) 
        {
            return DecimalBinario(numero.ToString());
        }

        public string DecimalBinario(string numero)
        {
            string nBinarioString = string.Empty;
            int numeroAuxiliar; 
            int restoAuxiliar = 0;
            double auxNumero; 

            auxNumero = double.Parse(numero);

            numeroAuxiliar = (int) auxNumero;

            while (numeroAuxiliar > 0)
            {
                restoAuxiliar = numeroAuxiliar % 2;
                nBinarioString = restoAuxiliar.ToString() + nBinarioString;
                numeroAuxiliar = numeroAuxiliar / 2;
            }
            return nBinarioString;
        }

        public Operando() :this(0)
        {
            
        }

        public Operando(double numero) :this(numero.ToString())
        {
            
        }

        public Operando(string strNumero)
        {
            if(ValidarOperando(strNumero) != 0)
            {
                this.numero = double.Parse(strNumero);
            }
        }

        public static double operator +(Operando num1, Operando num2)
        {
            return num1.numero + num2.numero;
        }

        public static double operator -(Operando num1, Operando num2)
        {
            return num1.numero - num2.numero;
        }

        public static double operator /(Operando num1, Operando num2)
        {
            double retorno;

            if(num2.numero == 0)
            {
                retorno = double.MinValue;
            }
            else
            {
                retorno = num1.numero / num2.numero;
            }
            return retorno;
        }

        public static double operator *(Operando num1, Operando num2)
        {
            return num1.numero * num2.numero;
        }
    }
}
