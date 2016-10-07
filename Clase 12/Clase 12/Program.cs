using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_12
{
    class Program
    {
        static void Main(string[] args)
        {
            /*while (condicion)
            {
                instrucciones
            }*/
            int contador = 1;
            do
            {
                Console.WriteLine("{0} ", contador);
                contador++;
                
            } while (contador <= 10);
            Console.ReadKey();
            
        }
    }
}
