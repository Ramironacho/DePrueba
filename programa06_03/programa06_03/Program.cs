using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa06_03
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables
            int valor = 0;
            double valorpf = 0.0;

            // pedir un numero
            Console.WriteLine("Ingrese un numero");
            valor = Convert.ToInt32(Console.ReadLine());
            // mostrar
            Console.WriteLine("El numero ingresado es: {0}", valor);
            // pedir un numero punto flotante
            Console.WriteLine("Ingrese un numero de punto flotante");
            valorpf = Convert.ToDouble(Console.ReadLine());
            // mostrar
            Console.WriteLine("El numero ingresado es: {0}", valorpf);

        }
    }
}
