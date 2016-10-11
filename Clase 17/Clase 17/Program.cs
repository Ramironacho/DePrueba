using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Tirar un dado 20 veces
namespace Clase_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numerosAleatorios = new Random();
            int cara;
            for (int contador = 1; contador <=20; contador ++)
            {
                //numero random entre 0 y el numero que se pasa por parametro
                cara = 1+numerosAleatorios.Next(6);
                //cara = 1 + numerosAleatorios.Next(1,7);
                Console.Write("{0} ",cara);
                if (contador % 5 == 0)
                    Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
