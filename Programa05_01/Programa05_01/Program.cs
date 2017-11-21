using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa05_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Operadores aritmeticos
            // + suma
            // - resta
            // * multiplicacion
            // / Division
            // % mod
            // = asignacion
            // ( ) agrupacion

            // Variables necesarias
            double valor1 = 1.5;
            double valor2 = 4.7;
            double resultado = 0.0;

            //Operacion

            resultado = valor1 + valor2;
            Console.WriteLine("{0} + {1} = {2}", valor1, valor2, resultado);

            resultado = valor1 - valor2;
            Console.WriteLine("{0} - {1} = {2}", valor1, valor2, resultado);

            resultado = valor1 * valor2;
            Console.WriteLine("{0} * {1} = {2}", valor1, valor2, resultado);

            resultado = valor1 / valor2;
            Console.WriteLine("{0} / {1} = {2}", valor1, valor2, resultado);

            resultado = valor1 % valor2;
            Console.WriteLine("{0} % {1} = {2}", valor1, valor2, resultado);
        }
    }
}
