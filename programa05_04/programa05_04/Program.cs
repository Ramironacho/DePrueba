using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa05_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calcular el area total de una casa con tres habitaciones

            //Variables
            double ancho1 = 4.3;
            double largo1 = 4.0;
            double area1 = 0.0;

            double ancho2 = 5.0;
            double largo2 = 6.7;
            double area2 = 0.0;

            double ancho3 = 2.89;
            double largo3 = 3.54;
            double area3 = 0.0;

            double areaTotal = 0.0;
            //Calcular area de hab1
            area1 = ancho1 * largo1;
            //Calcular area de hab2
            area2 = ancho2 * largo2;
            //Calcular area de hab3
            area3 = ancho3 * largo3;
            //Calcular area total
            areaTotal = area1 + area2 + area3;
            //Mostrar resultado
            Console.WriteLine("El area total es {0}", areaTotal);
        }
    }
}
