using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int producto = 3;
            while (producto <= 100)
            {
            producto = 3 * producto;
            Console.WriteLine("Producto vale {0}", producto);
            Console.ReadKey();
            }
            //Console.WriteLine("Producto vale {0}", producto);
            //Console.ReadKey();*/
            Medicamentos bayaspirina = new Medicamentos("Bayaspirina");
            Medicamentos buscapina = new Medicamentos("Buscapina");
            InterfaceG menu = new InterfaceG();
            menu.Menu();
            switch (menu.OpcionMenu)
            {
                case 1:
                    Console.WriteLine("Opción para Ingresar un nuevo medicamento");
                    break;
                case 2:
                    Console.WriteLine("Está por conusltar un medicamento");
                    break;
                case 3:
                    Console.WriteLine("Salir del programa");
                    break;
                //default va cuando no entra en ningún case.
                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }

            //Console.WriteLine("El primer medicamento es: {0}", bayaspirina.NombreMedicamento);
            //Console.WriteLine("El segundo medicamento es: {0}", buscapina.NombreMedicamento);
            //bayaspirina.IngresarMedicamentos();
            Console.ReadKey();
        }
    }
}
