using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Video 2
            Console.WriteLine("Empezando de nuevo");
            Console.ReadKey();
            Console.WriteLine("{0}\n{1}", "primero", "segundo");
            Console.ReadKey();
            //Comentario de linea
            /*comentario
             de 
             bloque
             */
             //Video 3
            int numero1;
            int numero2;
            int suma;
            Console.Write("Escriba el primer entero: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Escriba el segundo entero: ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            suma = numero1 + numero2;
            Console.WriteLine("La suma es {0}", suma);
            Console.ReadKey();
            //video 4
            /*Operadores
             * = igual
             * != distinto
             * < > >= <=
             */
            int numero3;
            int numero4;
            Console.Write("Escriba el tercer entero: ");
            numero3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Escriba el cuarto entero: ");
            numero4 = Convert.ToInt32(Console.ReadLine());
            //comparamos los dos valores
            if (numero3 == numero4)
                Console.WriteLine("{0} == {1}", numero3, numero4);
            if (numero3 != numero4)
                Console.WriteLine("{0} != {1}", numero3, numero4);
            if (numero3 < numero4)
                Console.WriteLine("{0} < {1}", numero3, numero4);
            if (numero3 > numero4)
                Console.WriteLine("{0} > {1}", numero3, numero4);
            Console.ReadKey();


        }
    }
}
