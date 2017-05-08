using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_26
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arreglo Rectangular
            int[,] rectangular = { { 1, 2, 3 }, { 4, 5, 6 } };
            //Arreglo "Dentado"
            int[][] dentado = {new int[] {1,2},
                               new int[] {3},
                               new int[] {4,5,6 } };
            imprimeRectangular(rectangular);
            Console.WriteLine();
            imprimeDentado(dentado);
            Console.ReadKey();
        }
        public static void imprimeRectangular (int[,] arreglo)
        {
            Console.WriteLine("Los valores del arreglo rectangular son: ");
            for (int fila = 0; fila < arreglo.GetLength(0); fila++)
            {
                for (int columna = 0; columna < arreglo.GetLength(1); columna++)
                {

                    Console.Write("{0} ", arreglo[fila, columna]);
                }
                Console.WriteLine();
            }

        }
        public static void imprimeDentado(int[][] arreglo)
        {
            Console.WriteLine("Los valores del arreglo dentado son: ");
            for (int fila = 0; fila < arreglo.Length; fila++)
            {
                for(int columna = 0; columna < arreglo[fila].Length; columna++)
                {
                    Console.Write("{0} ", arreglo[fila][columna]);
                }
                Console.WriteLine();
            }
        }
    }
}
