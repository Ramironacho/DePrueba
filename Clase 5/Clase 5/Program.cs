using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_5
{
    class Program
    {
        static void Main(string[] args)
        {
            medicamento bayaspirina = new medicamento();
            Console.WriteLine("Por favor ingrese nombre del medicamento que desea");
            string miMedicamento = Console.ReadLine();
            Console.WriteLine();
            bayaspirina.MostrarMensaje(miMedicamento);
            
        }
    }
}
