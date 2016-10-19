using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_21_Arreglos_2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int LONGITUD_ARREGLO = 10;
            int[] arreglo = new int[LONGITUD_ARREGLO];
            for (int contador = 0; contador < arreglo.Length; contador++)
            {
                arreglo[contador] = 2 + 2 * contador;
            }
            Console.WriteLine("{0}{1,8}", "Indice", "Valor");
            for (int contador = 0; contador < arreglo.Length; contador++)
            {
                Console.WriteLine("{0,5}{1,8}", contador, arreglo[contador]);
            }
            
            Console.ReadKey();
        }
    }
}
