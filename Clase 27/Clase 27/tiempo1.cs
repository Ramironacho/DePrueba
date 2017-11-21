using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_27
{
    class tiempo1
    {
        private int hora; //0 -23
        private int minutos; //0 -59
        private int segundos;//0 - 59

        public void EstablecerTiempo(int h, int m,int s)
        {
            hora = ((h>=0 && h<24) ? h:0);
            minutos = ((m >= 0 && m < 60) ? m : 0);
            segundos = ((s >= 0 && s < 60) ? s : 0);
        }

        public string AstringUniversal()//HH:MM:SS
        {
            return string.Format("{0:D2}:{1:D2}:{2:D2}", hora, minutos, segundos);
        }

        public override string ToString() //H:MM:SS AM o PM
        {
            return string.Format("{0}:{1:D2}:{2:D2}{3}", ((hora == 0 || hora ==12)?12 : hora%12), minutos, segundos, (hora <12 ? "AM" : "PM"));
        }
    }
}
