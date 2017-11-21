using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa06_05
{
    class Program
    {
        static void Main(string[] args)
        {
            // Convierta de pesos a dolares

            //variables
            double cantidadP;
            double cantidadD;
            double valorCambio;
            //pido ingrese valor cambio
            Console.WriteLine("Ingrese el valor del dolar en pesos al día de hoy: ");
            valorCambio = Convert.ToDouble(Console.ReadLine());
            //pido ingrese cantidad pesos a convertir
            Console.WriteLine("Ingrese cantidad de pesos a convertir a dolares: ");
            cantidadP = Convert.ToDouble(Console.ReadLine());
            //calculo cantidad dolares
            cantidadD = cantidadP / valorCambio;
            //Muestro Resultados
            Console.WriteLine("{0} pesos son {1} dolares", cantidadP, cantidadD);


        }
    }
}
