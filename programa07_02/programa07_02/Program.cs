using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa07_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Realizar la suma, resta, multiplicación o div de dos números, según lo desee el usuario
            //variables
            double opcion;
            double numero1;
            double numero2;
            double resultado;
            //pido numero1
            Console.Write("Ingrese el primer número: ");
            numero1 = Convert.ToDouble(Console.ReadLine());
            //pido numero2
            Console.Write("Ingrese el segundo número: ");
            numero2 = Convert.ToDouble(Console.ReadLine());
            //Elije operacion
            Console.WriteLine("¿Qué operación desea realizar?");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            opcion = Convert.ToDouble(Console.ReadLine());
            if (opcion == 1)
            {
                resultado = numero1 + numero2;
                Console.WriteLine("La suma de los numeros es: {0}", resultado);
            }
            if (opcion == 2)
            {
                resultado = numero1 - numero2;
                Console.WriteLine("La resta de los numeros es: {0}", resultado);
            }
            if (opcion == 3)
            {
                resultado = numero1 * numero2;
                Console.WriteLine("La multiplcación de los numeros es: {0}", resultado);
            }
            if (opcion == 4)
            {
                resultado = numero1 / numero2;
                Console.WriteLine("La división de los numeros es: {0}", resultado);
            }
        }
    }
}
