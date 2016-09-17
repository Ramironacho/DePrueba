using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases1
{
    class Program
    {
        static void Main(string[] args)
        {
            Medicamento baya = new Medicamento();
            Console.WriteLine("Ingrese Nombre del medicamento que desea");
            String nombre = Console.ReadLine();
            baya.MostrarMensaje(nombre);
        }
    }
}
