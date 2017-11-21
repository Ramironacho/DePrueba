using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa06_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables
            string nombre= "";
            string apellido = "";
            // pedir nombre
            Console.WriteLine("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            // pedir apellido
            Console.WriteLine("Ingrese su apellido: ");
            apellido = Console.ReadLine();
            //mandar mensaje
            Console.WriteLine("Hola {0} {1}", nombre, apellido);
        }
    }
}
