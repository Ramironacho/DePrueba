using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_5
{
    class medicamento
    {
        //Metodo que muestra mensaje de bienvenida
        public void MostrarMensaje(string nombreMedicamento)
        {
            Console.WriteLine("Usted está por ver la información de: {0}",nombreMedicamento);
            Console.ReadKey();
        }
            

    }
}
