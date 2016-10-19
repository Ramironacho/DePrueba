using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_19
{
    class Class1
    {
        public void ParametrosReferencia()
        {
            int y = 5;
            int z;

            Console.WriteLine("Valor Original de y: {0}", y);
            //Console.WriteLine("Valor Original de z: {0}", z);
            CuadradoRef(ref y);
            CuadradoSal(out z);

            Console.WriteLine("Valor de y despues de CuadradoRef:{0}", y);
            Console.WriteLine("Valor de z despues de CuadradoSal:{0}", z);
            Cuadrado(y);
            Cuadrado(z);
            Console.WriteLine("Valor de y despues de Cuadrado:{0}", y);
            Console.WriteLine("Valor de z despues de Cuadrado:{0}", z);
        }

        void CuadradoRef(ref int x)
        {
            x = x * x;
        }

        void CuadradoSal(out int x)
        {
            x = 6;
            x = x * x;
        }
        void Cuadrado(int x)
        {
            x = x * x;
            Console.WriteLine("Valor de y despues de Cuadrado:{0}", x);
            
        }
    }
}
