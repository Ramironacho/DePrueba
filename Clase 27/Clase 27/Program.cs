using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_27
{
    class Program
    {
        static void Main(string[] args)
        {
            tiempo1 tiempo = new tiempo1();
            Console.Write("La hora universal inicial es: ");
            Console.WriteLine(tiempo.AstringUniversal());
            Console.Write("La hora inicial estandar es:");
            Console.WriteLine(tiempo.ToString());
            Console.WriteLine();

            tiempo.EstablecerTiempo(15, 27, 9);
            Console.Write("La hora universal inicial es: ");
            Console.WriteLine(tiempo.AstringUniversal());
            Console.Write("La hora inicial estandar es:");
            Console.WriteLine(tiempo.ToString());
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
