using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//BREAK Y CONTINUE
namespace Clase_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int cuenta;

            for (cuenta = 1; cuenta <= 10; cuenta++)
            {
                if (cuenta == 5)//si cuenta = 5
                    //break;//Sale del bucle
                    continue;//omite el codigo restante
                Console.WriteLine("{0}", cuenta);
            }
            //Console.WriteLine(" \n Salio del ciclo cuando cuenta = {0}", cuenta);
            Console.WriteLine(" \n omite la impresión de un numero:");
            Console.ReadKey();
        }
    }
}
