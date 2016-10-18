using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            Console.WriteLine("Escriba el primer numero: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escriba el segundo numero: ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            
            if (numero1 == numero2)
                Console.WriteLine("Los numeros son iguales");
            if (numero1 != numero2)
                Console.WriteLine("Los numeros son distinos");
            if (numero1 > numero2)
                Console.WriteLine("{0} es mayor que {1}", numero1,numero2);
            if (numero1 < numero2)
                Console.WriteLine("Los {0} es menor que {1}",numero1,numero2);
            
            Console.ReadKey();
        }
    }
}
