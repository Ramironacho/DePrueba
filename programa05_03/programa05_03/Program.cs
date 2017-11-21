using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa05_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Convertir de C a F

            //Variables
            double C = 38.3;
            double F = 0.0;

            //Convertir
            F = C * 1.8 + 32;
            //Mostrar Resultados

            Console.WriteLine("{0} grados celsius son {1} farenheit", C, F);
        }
    }
}
