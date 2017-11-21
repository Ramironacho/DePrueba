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
            char salir ='s';
            //int numeroEjercicio;
            EjerciciosSimples ej = new EjerciciosSimples();
            InterfaceG menu = new InterfaceG();
            
            //Console.WriteLine("Ingrese el numero de Ejercicio: ");

            //numeroEjercicio = Convert.ToInt32(Console.ReadLine());
            while (salir != 'n')
            {
                
                menu.Menu();
                //menu con switch
                switch (menu.OpcionMenu)
                {
                    case 1:
                        ej.Ejercicio1();
                        break;
                    case 2:
                        ej.Ejercicio2();
                        break;
                    case 3:
                        ej.Ejercicio3();
                        break;
                    case 4:
                        ej.Ejercicio4();
                        break;
                    case 5:
                        ej.Ejercicio5();
                        break;
                    case 6:
                        ej.Ejercicio6();
                        break;
                    case 7:
                        ej.Ejercicio7();
                        break;
                    case 8:
                        ej.Ejercicio8();
                        break;
                    case 10:
                        salir = 'n';
                        break;
                    default:
                        Console.WriteLine("Numero Invalido");
                        Console.ReadKey();
                        break;
                }
                /* Menu con if
                if (menu.OpcionMenu == 1)
                    ej.Ejercicio1();
                else if (menu.OpcionMenu == 2)
                    ej.Ejercicio2();
                else if (menu.OpcionMenu == 3)
                    ej.Ejercicio3();
                else if (menu.OpcionMenu == 4)
                    ej.Ejercicio4();
                else if (menu.OpcionMenu == 5)
                    ej.Ejercicio5();
                else if (menu.OpcionMenu == 6)
                    ej.Ejercicio6();
                else if (menu.OpcionMenu == 7)
                    salir = 'n';
                else
                {
                    Console.WriteLine("Numero Invalido");
                    Console.ReadKey();

                }*/
                if (salir == 's')
                {
                    Console.WriteLine("Desea continuar?: s/n");

                    salir = Convert.ToChar(Console.ReadLine());
                }

                
            }
                


        }
    }
}
