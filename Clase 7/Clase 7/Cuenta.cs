using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_7
{
    class Cuenta
    {
        private decimal saldo;
        public Cuenta (decimal saldoInicial)
        {
            saldo = saldoInicial;
        }

        //metodo para acreditar monton a la cuenta
        public void Acredita(decimal monto)
        {
            saldo = saldo + monto;
        }

        //propiedad para obtener y establecer saldo de una cuenta
        public decimal Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                if (value > 0)
                    saldo = value;
            }
        }
    }
}
