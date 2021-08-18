using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancodoThiago
{
    class Program
    {
        private static bool saldo;

        static void Main(string[] args)
        {
            

        BancoDoThiago conta = new BancoDoThiago();

            conta.titular = "Thiago";
            conta.agencia = 123456;
            conta.numero = 78945;
            //conta.saldo = 500;

            conta.setSaldo(100);
            

            Console.WriteLine(saldo);


            Console.ReadLine();
        }
    }
}
