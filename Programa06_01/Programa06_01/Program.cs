using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa06_01
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables
            string nombre= "";
            // pedir el nombre
            Console.WriteLine("Ingrese su Nombre: ");
            nombre = Console.ReadLine();
            // mandar saludo
            Console.WriteLine("Hola {0}", nombre);
        }
    }
}
