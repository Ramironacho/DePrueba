using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa05_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que calcule el area y perimetro de un cuadrado
            // Variables
            double lado = 5.0;
            double area = 0.0;
            double perimetro = 0.0;

            // Calcular Area
            area = lado * lado;

            // Calcular perimetro

            perimetro = lado * 4;

            // Mostrar resultados

            Console.WriteLine("El area de un cuadrado de lado {0} es {1}", lado, area);
            Console.WriteLine("El perimetro de un cuadrado de lado {0} es {1}", lado, perimetro);

        }
    }
}
