using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Clase_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //carga nombre de medicamento con constructor
            medicamento bayaspirina = new medicamento("Bayaspirina");
            medicamento buscapina = new medicamento("Buscapina");
            Console.WriteLine("El Primer medicamento es: {0}", bayaspirina.NombreMedicamento);
            Console.WriteLine("El Segundo medicamento es: {0}", buscapina.NombreMedicamento);
            Console.ReadKey();

            //carga nombre de medicamento con propiedad set y y lo muestra con get
            Console.WriteLine("Por favor ingrese nombre del medicamento que desea");
            string miMedicamento = Console.ReadLine();
            bayaspirina.NombreMedicamento = miMedicamento;
            Console.WriteLine();
            bayaspirina.MostrarMensaje();
            Console.WriteLine("El valor obtenido mediante GET es: {0}", bayaspirina.NombreMedicamento);
            Console.ReadKey();
        }
    }
}
