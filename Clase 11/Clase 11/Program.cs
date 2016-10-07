using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantAlumnos;
            string nombreAlumno;
            Console.WriteLine("Ingrese la cantidad de alumnos");
            cantAlumnos = Convert.ToInt32(Console.ReadLine());
            for (int contador = 1; contador <= cantAlumnos; contador++)
            {
                Console.WriteLine("{0} {1}","Ingrese el alumnos N: ",contador);
                nombreAlumno = Console.ReadLine();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
