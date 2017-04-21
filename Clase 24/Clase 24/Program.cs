using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_24
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] temperaturasPorHora = new double[24];
            //formas de pasar arreglos a metodos :
            //modificarArreglo(temperaturasPorHora);
            //modificarArreglo(double[] b);
            //modificarArreglo(temperaturasPorHora[5]); pasa el elemento al metodo
            int[] arreglo = { 1, 2, 3, 4, 5 };
            Console.WriteLine("pasamos un arreglo a los metodos, los valores del arreglo original son: ");
            foreach (int valor in arreglo)
                Console.Write("     {0}", valor);
            ModificarArreglo(arreglo);
            Console.WriteLine("\n\n Los valores del arreglo modificado son: ");

            //imprimimos el arreglo modificado
            foreach (int valor in arreglo)
                Console.Write("    {0}", valor);

            Console.WriteLine(" \n\n efectos de pasar el valor de un elemento del arreglo: \n" + "arreglo[3] antes de modificarElemento: {0}", arreglo[3]);
            ModificarElemento(arreglo[3]);
            Console.WriteLine("arreglo[3] después de modificar el elemento: {0}", arreglo[3]);
            arreglo[3] = ModificarElemento2(arreglo[3]);
            Console.WriteLine("arreglo[3] después de modificar el elemento por segunda vez: {0}", arreglo[3]);
            Console.ReadKey();
        }

        public static void ModificarArreglo(int[] arreglo2)
        {
            for (int i = 0; i < arreglo2.Length; i++)
            {
                arreglo2[i] *= 2;
            }
        }
        public static void ModificarElemento(int elemento)
        {
            elemento *= 2;
            Console.WriteLine("Valor del elemento en modificarElemento: {0}", elemento);
        }
        public static int  ModificarElemento2(int elemento)
        {
            elemento *= 2;
            Console.WriteLine("Valor del elemento en modificarElemento: {0}", elemento);
            return elemento;
        }
    }
}
