using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_19
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parametros por Referencia
            //ref para pasar parametros por referencia
            //out para salida
            Class1 ejemplo = new Class1();
            int x = 7;
            int[] arreglo = new int[3];
            arreglo[0] = 1;
            arreglo[1] = 2;
            arreglo[2] = 3;

            Console.WriteLine(x);
            Cuadrado(x);
            Console.WriteLine(x);
            Console.WriteLine(arreglo[1]);
            CuadradoArreglo(arreglo);
            Console.WriteLine(arreglo[1]);
            //ejemplo.ParametrosReferencia();
            Console.ReadKey();
        }
        static void Cuadrado(int x)
        {
            x = x * x;
            Console.WriteLine("Valor de y despues de Cuadrado:{0}", x);

        }
        static void CuadradoArreglo(int[] lala)
        {
            for (int i = 0;i<lala.Length;i++)
                lala[i] *= 2;
            //Console.WriteLine("Valor de y despues de CuadradoArreglo:{0}", x);

        }
    }
}
