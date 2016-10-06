using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int producto = 3;
            while (producto<= 100)
            {
                producto = 3 * producto;
            }
            Console.WriteLine("Producto vale {0}", producto);
            Console.ReadKey();    
            */
            Medicamentos bayaspirina = new Medicamentos("bayaspirina");
            Medicamentos buscapina = new Medicamentos("Buscapina");
            Console.WriteLine("El primer medicamento es:{0}", bayaspirina.NombreMedicamento);
            Console.WriteLine("El segundo medicamento es:{0}", buscapina.NombreMedicamento);
            bayaspirina.IngresarMedicamentos();
            Console.ReadKey();
        }
    }
}
