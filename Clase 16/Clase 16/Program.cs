using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Con los métodos estáticos no hace falta declarar un objeto de la clase para poder usar dicho metodo
            /*Math.Sqrt(x)raiz cuadrada de x
             *    .abs(x) valor absoluto de x
             *    .Ceiling(x) redondea x al entero mas pequeño no menor de x
             *    .Cos(x) Coseno de x, x está en radianes
             *    .Exp(x) metdodo exponencial e^x
             *    .floor(x) redondea x al entero mas grande no mayor de x
             *    .Log(x) Logaritmo natural de x (base e)
             *    .Max(x,y) El valor mayor de x e y
             *    .min(x,y) El valor menor de x e y
             *    .Pow(x,y) x elevada a la potencia y
             *    .sin(x) seno de x, x en radianes
             *    .tan(x) tangente de x, x en radianes
             */

            Maximo buscarMax = new Maximo();
            buscarMax.DeterminarMaximo();
            Console.WriteLine(Math.E);
            Console.ReadKey();
        }
    }
}
