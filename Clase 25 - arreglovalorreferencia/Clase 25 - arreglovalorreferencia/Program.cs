using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_25___arreglovalorreferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //crea e inicializa el primer arreglo
            int[] arreglo1 = { 1, 2, 3 };
            //copiar la referencia en la variable primerArreglo
            int[] copiaArreglo1 = arreglo1;

            Console.WriteLine("Prueba: Paso de la referencia arreglo 1 por valor.");
            Console.WriteLine("\nContenido de arreglo1 antes de llamar a primerDoble");
            for (int i = 0; i < arreglo1.Length; i++)
            {
                Console.Write("{0}", arreglo1[i]);
            }
            Console.WriteLine("\nContenido de CopiaArreglo1 antes de llamar a primerDoble");
            for (int i = 0; i < copiaArreglo1.Length; i++)
            {
                Console.Write("{0}", copiaArreglo1[i]);
            }
            PrimerDoble(arreglo1);
            Console.WriteLine("\nContenido de arreglo1 despues de llamar a primerDoble");
            for (int i = 0; i< arreglo1.Length; i++)
            {
                Console.Write("{0}", arreglo1[i]);
            }
            Console.WriteLine("\nContenido de CopiaArreglo1 despues de llamar a primerDoble");
            for (int i = 0; i < copiaArreglo1.Length; i++)
            {
                Console.Write("{0}", copiaArreglo1[i]);
            }
            if (arreglo1 == copiaArreglo1)
                Console.WriteLine("\nLas referencias son el mismo arreglo");
            else
                Console.WriteLine("\nLas referencias son a distintos arreglos");

            Console.ReadKey();


        }
        public static void PrimerDoble(int[] arreglo)
        {
            
            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] *= 2;
            }
            //Creamos un nuevo objeto y asignamos su refrencia al arreglo
            arreglo = new int[] { 11, 12, 13 };
            //fin PrimerDoble
        }
    }
}
