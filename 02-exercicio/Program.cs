using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto = "Glifage";
            double valorcompra = 5.50;
            double valorvenda;
            double lucro = 0.2;

            valorvenda = valorcompra + (valorcompra * lucro);

            Console.WriteLine("Produto.......:{0, 15}", produto);
            Console.WriteLine("Val.Compra....:{0, 15:c}", valorcompra);
            Console.WriteLine("val.Venda.....:{0, 15:c}", valorvenda);
            Console.WriteLine("Lucro.........:{0, 15:p}", lucro);
            
            
            Console.ReadLine();
        }
    }
}
