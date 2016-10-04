using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_6
{
    class medicamento
    {
        
        //variable de instancia
        private string nombreMedicamento;
        
        public medicamento(string nombre)
        {
            NombreMedicamento = nombre;
        }
        //Get Set Propeidad; No puede tener mismo nombre que variable de instancia
        public string NombreMedicamento
        {
            get
            {
                return nombreMedicamento;
            }
            set
            {
                nombreMedicamento = value;
            }
        }
        
        public void MostrarMensaje()
        {
            //se puede usar variable de instancia pero mejor usar propiedad
            Console.WriteLine("Usted está por ver la información de: {0}", NombreMedicamento);
            Console.ReadKey();
        }

    }
}
