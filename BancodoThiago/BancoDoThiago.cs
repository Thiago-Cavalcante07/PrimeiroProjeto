using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancodoThiago
{
    class BancoDoThiago
    {
        public string titular;
        public int agencia;
        public int numero;
        private double saldo = 200;


        public double getSaldo()
        {
            return this.saldo;
        }

        public void setSaldo(double valor)
        {
            this.saldo = valor;
        }

    }
}
