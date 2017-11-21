using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_22_BarajarCartas
{
    class MazoDeCartas
    {
        private Carta[] paquete;
        private int cartaActual;
        private const int NUMERO_DE_CARTAS = 52;
        private Random numerosAleatorios;


        
        
        //Constructor que llena el paquete
        public MazoDeCartas()
        {
            
            Console.WriteLine("Aver que salio");
            string[] caras = { "As", "Dos", "Tres", "Cuatro", "Cinco", "Seis", "Siete", "Ocho", "Nueve", "Diez", "Jota", "Q", "K" };
            string[] palos = { "Corazones", "Diamantes", "Treboles", "Espadas" };

            paquete = new Carta[NUMERO_DE_CARTAS];
            cartaActual = 0; //paquete[0]
            numerosAleatorios = new Random();
            for (int contador = 0;contador<paquete.Length;contador++)
            {
                paquete[contador] = new Carta(caras[contador % 13], palos[contador / 13]);
            }
        } // fin del constructor

        public void Barajar()
        {                       
            cartaActual = 0;
            for (int primera = 0; primera < paquete.Length; primera++)
            {
                int segunda = numerosAleatorios.Next(NUMERO_DE_CARTAS);
                //intercambiar primera carta con la segunda
                Carta temp = paquete[primera];
                paquete[primera] = paquete[segunda];
                paquete[segunda] = temp;
                Console.WriteLine(temp);
            }

        }//fin metodo barajar

        public Carta RepartirCarta()
        {
            if (cartaActual < paquete.Length)
                return paquete[cartaActual++];
            else
                return null;


        }

    }
}
