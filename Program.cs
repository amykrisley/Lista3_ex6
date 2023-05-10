using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, a, b, tab, cont;
            do
            {

                Console.Write("Digite um número positivo: ");
                x = int.Parse(Console.ReadLine());
            }
            while (x <= 0);
            
            Console.WriteLine("Tabuada do {0}", x);

            Console.Write("Digite o 1º número do intervalo: ");
            a = int.Parse(Console.ReadLine());

            do
            {

                Console.Write("Digite o 2º número do intervalo: : ");
                b = int.Parse(Console.ReadLine());
                if (a >= b)
                    Console.WriteLine("O 2º número tem que ser maior q o 1º");
            }
            while (a >= b);
            Console.Clear();
            Console.WriteLine("Tabuada do {0}\nNo intervalo de {1} para {2}", x, b, a);

            for (cont = b; cont >= a; cont--)
            {
                tab = x * cont;
                Console.WriteLine("{0} * {1} = {2}", x, cont, tab);
            }
            while (a <= b) ;
        }
    }
}
