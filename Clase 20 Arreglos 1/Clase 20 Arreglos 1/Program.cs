using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_20_Arreglos_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arreglo1 = new int[10];
            int[] arreglo1 = { 5, 14, 3, 45, 8, 12 };
            Console.WriteLine("{0}{1,8}", "indice", "valor");
            for (int contador = 0; contador < arreglo1.Length; contador++)
            {
                Console.WriteLine("{0,5}{1,8}", contador, arreglo1[contador]);
            }
            Console.ReadKey();
            
        }
    }
}
