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
            /*const int LONGITUD_ARREGLO = 10;
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
            */
            /* Sumar elementos de un arreglo
            int n ;
            int[] arreglo = { 98, 58, 36, 45, 72, 35, 0, 15, 2, 9, 7, 25 };
            int total = 0;
            for (int contador = 0; contador < arreglo.Length; contador++)
            {
                total += arreglo[contador];
            }
            Console.WriteLine("Total de los elementos del arreglo: {0}", total);
            */
            int[] arreglo = { 0, 0, 1, 2, 4, 0, 3, 8, 5, 3, 6 };
            Console.WriteLine("Distrubución de calificaciones:");
            for (int contador = 0; contador < arreglo.Length; contador++)
            {
                if (contador == 10)
                    Console.Write(" 100: ");
                else
                    Console.Write("{0:D2}-{1:D2}: ", contador * 10, contador * 10 + 9);

                for (int estrellas = 0; estrellas < arreglo[contador]; estrellas++)
                    Console.Write("*");
                Console.WriteLine();

            }

            Console.ReadKey();
        }
    }
}
