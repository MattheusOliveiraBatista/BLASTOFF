using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menor_Numero
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, c = 0;

            Console.WriteLine("-----------------------------------");
            Console.WriteLine(" QUESTÃO 03 - MENOR VALOR");
            Console.WriteLine("-----------------------------------\n\n");

            Console.Write("Digite o valor de a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor de b: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor de c: ");
            c = Convert.ToInt32(Console.ReadLine());


            if (a < b && a < c)
            {
                Console.WriteLine("\n-----------------------------------");
                Console.WriteLine("O menor valor, foi o valor de 'A'.");
                Console.WriteLine("-----------------------------------");

            }

            else if (b < a && b < c) 
            {
                Console.WriteLine("\n-----------------------------------");
                Console.WriteLine("O menor valor, foi o valor de 'B'.");
                Console.WriteLine("-----------------------------------");

            }
            else
            {
                Console.WriteLine("\n-----------------------------------");
                Console.WriteLine("O menor valor, foi o valor de 'C'.");
                Console.WriteLine("-----------------------------------");
            }

            Console.ReadKey();
        }
    }
}
