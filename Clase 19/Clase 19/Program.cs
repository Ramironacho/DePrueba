using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_19
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parametros por Referencia
            //ref para pasar parametros por referencia
            //out para salida
            Class1 ejemplo = new Class1();

            ejemplo.ParametrosReferencia();
            Console.ReadKey();
        }
    }
}
