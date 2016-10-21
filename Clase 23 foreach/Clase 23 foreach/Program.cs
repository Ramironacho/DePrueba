using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_23_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //foreach (tipodedato Identificador in nombredearreglo)
            int[] arreglo = { 87, 68, 94, 100, 83, 58, 96, 73, 21 };
            int total = 0;
            foreach (int numero in arreglo)
            {
                total += numero;
            }
            Console.WriteLine(total);
            Console.ReadKey();
        }
    }
}
