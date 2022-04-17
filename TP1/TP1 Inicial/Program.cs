using System;
using LibreriaCalculadora;

namespace TP1_Inicial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operando operando1 = new Operando();
            Operando operando2 = new Operando();
            char operador;
            double resultado = 0;
            bool condicion = true;

            do
            {
                
                Console.WriteLine("Ingrese primer numero: ");
                operando1.Numero = Console.ReadLine();
                Console.WriteLine("Ingrese segundo numero: ");
                operando2.Numero = Console.ReadLine();
                Console.WriteLine("Ingrese operador: ");
                operador = (char) Console.Read();


                resultado = Calculadora.Operar(operando1, operando2, operador);

                Console.WriteLine("Resultado en binario {0}", operando1.DecimalBinario(resultado));

                Console.WriteLine("Resultado de Binario a decimal {0}", operando1.BinarioDecimal("10010"));

                Console.WriteLine($"El resultado es {resultado}.\n Operando 1: {operando1}.\n Operando 2{operando2}.\n Operador: {operador} ");


            } while (condicion);

            Console.WriteLine("Hello World!");
        }
    }
}
