using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa04_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // bool - booleanos v o f
            // char - caracteres
            // int - numeros enteros
            // float - numeros con punto decimal
            // double - numeros con punto decimal
            // string - colecciones de caracteres, frases, palabras, etc

            // decalaracion - creamos la variable
            // Inicializacion - cuando se le da su primer valor
            // Asignacion - cuando se le da un valor

            // Declaracion -> tipo nombre;
            int valor;

            // Inicializacion -> nombre = x;
            valor = 5;

            Console.WriteLine("Valor de inicio es: {0}",valor);
            // Asignacion -> nombre = y;

            valor = 7;

            Console.WriteLine("el valor de {0} es colocado en la variable",valor);

        }
    }
}
