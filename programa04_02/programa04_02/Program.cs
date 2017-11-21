using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa04_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaracion con inicializacion -> tipo nombre = x;
            double impuesto = 1.13;
            bool encendido = true;
            char letra = 'A';
            string palabra = "Hola";
            int numero = 19;

            Console.WriteLine("impuesto ={0}, numero ={1}", impuesto, numero);

            Console.WriteLine("Se tiene {1} en el bool y {0} en la letra", letra, encendido);

            Console.WriteLine("La cadena dice {0}", palabra);

            encendido = false;
            letra ='@';
            impuesto = -125.25;
            palabra = "adios";


            Console.WriteLine("impuesto ={0}, numero ={1}", impuesto, numero);

            Console.WriteLine("Se tiene {1} en el bool y {0} en la letra", letra, encendido);

            Console.WriteLine("La cadena dice {0}", palabra);
        }
    }
}
