using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa07_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Estructuras selectivas
            // if(expresion) sentencia;
            // Operadores relacionales ==, >, <, >=, <=, !=
            int a = 5;
            int b = 8;
            int c = 5;

            if (a == c)
                Console.WriteLine("a y c son iguales");
            if(b > c)
                Console.WriteLine("b es mayor a c");
            if (a > c)
                Console.WriteLine("a es mayor a c");



        }
    }
}
