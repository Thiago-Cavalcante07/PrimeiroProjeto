using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandocomQuociente
{
    class Program
    {
        static void Main(string[] args)
        {
            int divid, divis, quoci, rest;
            char escolha;

            incio:

            Console.Clear();

            Console.WriteLine("Mostrando o quociente e o resto de um número");
            Console.WriteLine("---------------------------------------------");
            
            Console.Write("\nDigite o dividendo: ");
            divid = int.Parse(Console.ReadLine());

            Console.Write("\nDigite o divisor: ");
            divis = int.Parse(Console.ReadLine());

            quoci = divide(divid, divis, out rest);

            Console.WriteLine("\n{0} / {1} = Quociente {2}. Resto = {3}",divid, divis, quoci, rest);

            Console.WriteLine("\nDeseja continuar com o progrma digite: [s/n]");
            escolha = char.Parse(Console.ReadLine());

            if (escolha == 's' || escolha == 'S')
            {
                goto incio;         
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Fim do programa, tchau Selena um beijo...");
            }

            Console.ReadLine();

        }
        static int divide(int dividendo, int divisor, out int resto)
        {
            int quociente = dividendo / divisor;
            resto = dividendo % divisor;
            return quociente; 
        }

        
    }
}
