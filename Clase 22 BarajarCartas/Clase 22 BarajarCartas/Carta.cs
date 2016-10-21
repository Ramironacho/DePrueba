using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_22_BarajarCartas
{
    class Carta
    {
        private string cara;//cara de la carta ("AS","DOS","TRES")
        private string palo; //Corazon, Trebol....

        //construct
        public Carta(string caraCarta, string paloCarta)
        {
            cara = caraCarta;
            palo = paloCarta;
        }
        public void Ramiro()
        {

        }
        public override string ToString()
        {
            return cara + " de " + palo;
        }
    }
}
