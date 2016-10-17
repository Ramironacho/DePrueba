using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_18
{
    class Program
    {
        //enum diasSemana { Lunes, Martes, Miercoles =19, Jueves, Viernes, Sabado, Domingo }
        static void Main(string[] args)
        {
            /*  //enumeraciones se usa cuando hay muchas constantes con valores enteros
              Console.WriteLine("En la enumeracion, miercoles tiene el valor: {0}", diasSemana.Miercoles);
              Console.WriteLine("Que equivale a: {0}", (int)diasSemana.Miercoles);
              Console.ReadKey();*/

            for (long contador = 0; contador <= 10; contador++)
                Console.WriteLine("{0}! = {1}", contador, Factorial(contador));
            Console.ReadKey();


        }
        public static long Factorial (long numero)
        {
            if (numero <= 1)
                return 1;
            else
                return numero * Factorial(numero - 1);
        }
    }
}
