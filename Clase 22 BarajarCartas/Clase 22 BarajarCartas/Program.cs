using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_22_BarajarCartas
{
    class Program
    {
        static void Main(string[] args)
        {
            MazoDeCartas miMazo = new MazoDeCartas();
            
            miMazo.Barajar();
            for (int i = 0; i < 13; i++)
            {
                Console.WriteLine("{0, -20}, {1, -20}, {2, -20}, {3, -20}", miMazo.RepartirCarta(), miMazo.RepartirCarta(), miMazo.RepartirCarta(), miMazo.RepartirCarta());
            }

            Console.ReadKey();

        }
    }
}
