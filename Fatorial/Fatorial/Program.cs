using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine(" QUESTÃO 10 - FATORIAL");
            Console.WriteLine("--------------------------------\n");

            int valor_fatorial = 0, numero = 0, fat = 0;
            
            Console.Write("Digite o valor a ser fatorado: ");
            valor_fatorial = Convert.ToInt32(Console.ReadLine());
            numero = valor_fatorial;
            
            for(fat = 1; valor_fatorial > 1; valor_fatorial = valor_fatorial -1)
            {
                fat = fat * valor_fatorial;

            }

            Console.WriteLine("\n--------------------------------");
            Console.WriteLine("O valor do fatorial de {0} é {1} ", numero, fat);
            Console.WriteLine("--------------------------------\n");

            Console.ReadKey();


        }
    }
}
