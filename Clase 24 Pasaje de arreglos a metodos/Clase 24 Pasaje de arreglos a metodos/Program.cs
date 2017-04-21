using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_24_Pasaje_de_arreglos_a_metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            //double[] temperaturasPorHora = new double[24];
            //modificarArreglo(temperaturasPorHora[5]);
            //modificarArreglo(double[] b);
            //modificarArreglo(temperaturasPorHora);


            int[] arreglo = { 1, 2, 3, 4, 5 };
            Console.WriteLine("pasamos un arreglo a los metodos, los valores del arreglo original son: ");
            foreach(int valor in arreglo)
            {
                Console.Write("   {0}", valor);
            }
            ModificarArreglo(arreglo);
            Console.WriteLine("\n\n Los valoes del arreglo modificado son: ");

            //imprimimos el arreglo modificado

            foreach(int valor in arreglo)
            {
                Console.Write("   {0}", valor);
            }

            Console.ReadKey();
        }

        public static void ModificarArreglo(int[] arreglo2)
        {
            for (int contador=0; contador < arreglo2.Length; contador++)
            {
                arreglo2[contador] *= 2;
            }
        }
    }
}
