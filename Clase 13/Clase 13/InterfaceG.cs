using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_13
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
            Console.WriteLine("1 - Ingresar Medicamentos");
            Console.WriteLine("2 - Consultar Medicamentos");
            Console.WriteLine("3 - Salir");
            Console.Write("Opción: ");
            OpcionMenu = Convert.ToInt32(Console.ReadLine());
        }
    }

}
