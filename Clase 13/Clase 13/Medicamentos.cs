using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_13
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
            Console.WriteLine("Usted está por ver la información de: {0}", NombreMedicamento);
            Console.ReadKey();
        }
        public void IngresarMedicamentos()
        {
            //int contador=1;
            char respuesta = 's';
            int cantMedicamentos;
            string medicamento;
            Console.WriteLine("Ingrese la cantidad de medicamentos que desea agregar en el sistema");
            cantMedicamentos = Convert.ToInt32(Console.ReadLine());

            /*while (contador <= cantMedicamentos)            
            {
                Console.WriteLine("Ingrese el medicamento N°: {0}", contador);
                medicamento = Console.ReadLine();
                Console.WriteLine(medicamento);
                contador = contador + 1;
            }*/
            while (respuesta != 'n')
            {
                Console.Write("Ingrese el medicamento: ");
                medicamento = Console.ReadLine();
                Console.WriteLine(medicamento);
                Console.WriteLine("Desea agregar otro medicamento? s/n");
                respuesta = Convert.ToChar(Console.ReadLine());

            }
        }
    }
}
