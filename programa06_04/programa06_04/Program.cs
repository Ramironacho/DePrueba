using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa06_04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programa que calcule el area y el perimetro del rectangulo
            // variables
            int a;
            int b;
            int area = 0;
            int perimetro= 0;
            //pedir lado a
            Console.WriteLine("Ingrese el lado a del rectangulo: ");
            a = Convert.ToInt32(Console.ReadLine());
            //pedir lado b
            Console.WriteLine("Ingrese el lado b del rectangulo: ");
            b = Convert.ToInt32(Console.ReadLine());
            //Calcular el area
            area = a * b;
            //Calcular perimetro
            perimetro = a * 2 + b * 2;
            //Mostrar Resultados
            Console.WriteLine("El area del rectangulo de lados {0} y {1} es: {2}", a, b, area);
            Console.WriteLine("El perimetro del rectangulo de lados {0} y {1} es: {2}", a, b, perimetro);

        }
    }
}
