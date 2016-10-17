using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeros_Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroEjercicio;
            EjerciciosSimples ej = new EjerciciosSimples();
            InterfaceG menu = new InterfaceG();
            menu.Menu();
            Console.WriteLine("Ingrese el numero de Ejercicio: ");
            numeroEjercicio = Convert.ToInt32(Console.ReadLine());
            if (numeroEjercicio == 1)
                ej.Ejercicio1();
            else if (numeroEjercicio == 2)
                ej.Ejercicio2();
            else if (numeroEjercicio == 3)
                ej.Ejercicio3();
            else if (numeroEjercicio == 4)
                ej.Ejercicio4();
            else if (numeroEjercicio == 5)
                ej.Ejercicio5();
            else if (numeroEjercicio == 6)
                ej.Ejercicio6();
            else
            {
                Console.WriteLine("Numero Invalido");
                Console.ReadKey();
            }
                


        }
    }
}
