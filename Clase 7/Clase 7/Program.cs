using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Numero de punto flotante y decimal
            //Los decimales tienen presicion 
            //punto flotante es con aproximación pero tienen mas escala de valores
            Cuenta cuenta1 = new Cuenta(50.00M);
            Cuenta cuenta2 = new Cuenta(-7.53M);
            //Pongo el :C para que muestre el simbolo $. el c muestra con valor de moneda
            Console.WriteLine("Saldo de cuenta 1: {0:C}", cuenta1.Saldo);
            Console.WriteLine("Saldo de cuenta 2: {0:C}", cuenta2.Saldo);
            Console.ReadKey();

            decimal montoDeposito;
            Console.Write("Ingrese monto que desea depositar: ");
            montoDeposito = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Se acreditaran {0:c} al saldo cuenta 1", montoDeposito);
            Console.ReadKey();
            cuenta1.Acredita(montoDeposito);
            Console.WriteLine("Se sumó {0:c} al saldo cuenta 1", montoDeposito);
            //muestro nuevo saldos
            Console.WriteLine("Saldo de cuenta 1: {0:C}", cuenta1.Saldo);
            Console.WriteLine("Saldo de cuenta 2: {0:C}", cuenta2.Saldo);
            Console.ReadKey();

            /*
             * hay q tratar de agregar un case para que
             * pueda elegir la cuenta y que valide los valores a sumar*/
        }
    }
}
