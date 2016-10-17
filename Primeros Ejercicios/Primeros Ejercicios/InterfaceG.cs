using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeros_Ejercicios
{
    class InterfaceG
    {
        private int opcionMenu;
        public int OpcionMenu
        {
            get
            {
                return opcionMenu;
            }
            set
            {
                opcionMenu = value;
            }
        }
        public void Menu()
        {
            Console.WriteLine("-------------------Menu Principal ------------------");
            Console.WriteLine("1 - Ejercio 1 - Saludo");
            Console.WriteLine("2 - Ejercio 2 - Circulos");
            Console.WriteLine("3 - Ejercio 3 - Promedio");
            Console.WriteLine("4 - Ejercio 4 - Conversión de Unidades de longitud");
            Console.WriteLine("5 - Ejercio 5 - Número invertido");
            Console.WriteLine("6 - Ejercio 6 - Pitagoras");
            Console.WriteLine("7 - Salir");
            Console.Write("Opción: ");
            OpcionMenu = Convert.ToInt32(Console.ReadLine());
        }

    }
}
