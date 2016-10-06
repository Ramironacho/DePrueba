using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Medicamentos
    {
        private string nombreMedicamento;

        public Medicamentos(string nombre)
        {
            nombreMedicamento = nombre;
        
        }
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
            Console.WriteLine("Usted esta por ver la inofrmacion de: {0}", NombreMedicamento);
            Console.ReadKey();
        }

        //nuevo clase 8 con while
        public void IngresarMedicamentos()
        {
            int contador = 1;
            int cantMedicamentos;
            string medicamento;
            Console.WriteLine("Ingrese la cantidad de medicamentos que desea agregar en el sistema");
            cantMedicamentos = Convert.ToInt32(Console.ReadLine());
            while (contador <= cantMedicamentos)
            {
                Console.WriteLine("Ingrese el medicamento N° {0}", contador);
                medicamento = Console.ReadLine();
                Console.WriteLine(medicamento);
                contador = contador + 1;

                
            }
        }
    }
}
