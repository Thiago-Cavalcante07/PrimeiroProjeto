using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double n1;
            double n2;
            double media;

            Console.Write("Digite seu nome: ");

            nome = (Console.ReadLine());

            Console.WriteLine("\nOlá " + nome + " seja bem vindo(a)!!!");

            Console.Write("\nDigite a primeira nota: ");
            n1 = double.Parse(Console.ReadLine());

            Console.Write("\nDigite a segunda nota: ");
            n2 = double.Parse(Console.ReadLine());

            media = (n1 + n2) / 2;

            Console.WriteLine("\nSua média foi: " + media);

            if (media == 10)
            {
                Console.WriteLine("\nParabéns você tirou a melhor nota!!");
            }
            else if (media >= 6 && media < 10)
            {
                Console.WriteLine("Passou na média, Estude mais.");
            }
            else
            {
                Console.WriteLine("\nReprovado!!");
            }


            Console.ReadLine();
        }
    }
}
