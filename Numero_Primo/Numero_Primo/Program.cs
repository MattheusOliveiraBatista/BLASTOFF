using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero_Primo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine(" QUESTÃO 08 - NÚMERO PRIMO");
            Console.WriteLine("--------------------------------------------\n");

            int numero_primo = 0, divisores = 0;

            Console.Write("Digite o valor que deseja verificar: ");
            numero_primo = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= numero_primo; i++)
            {
                if (numero_primo % i == 0)
                {
                    divisores += 1;
                }
            }

            Console.WriteLine("\n----------------------------------------");
            if (divisores == 2) Console.WriteLine("É um número primo");
            else Console.WriteLine("Não é um número primo");
            Console.WriteLine("-----------------------------------------");

            Console.ReadKey();
        }
        
    }
}
