using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_15
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            AND o &&
            if (genero == femenino && edad >= 65)
                mujeresMayores++;

            OR o ||
            if((promedioSemestre >=90) || (examenFinal>=90))

            not se pone con !
            */

            Console.WriteLine("{0}\n{1}:{2}\n{3}:{4}\n{5}:{6}\n{7}:{8}\n", "AND CONDICIONAL(&&)",
                "false && false",(false && false),
                "false && true",(false && true),
                "true && false", (true && false),
                "true && true", (true && true));

            Console.ReadKey();
        }
    }
}
