using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_16
{
    public class Maximo
    {
        public void DeterminarMaximo()
        {
            Console.WriteLine("Ingrese 3 Numeros, \n" +
                "Oprima 'Enter' después de cada uno: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            double num3 = Convert.ToDouble(Console.ReadLine());

            //Calcular valor maximo
            double resultado = Maximos(num1, num2, num3);
            Console.WriteLine("El máximo es: " + resultado);
            Console.ReadKey();
        }

        public double Maximos (double x, double y, double z)
        {
            double valorMaximo = x;
            if (y > valorMaximo)
                valorMaximo = y;
            if (z > valorMaximo)
                valorMaximo = z;
            return valorMaximo;
        }
    }
}
