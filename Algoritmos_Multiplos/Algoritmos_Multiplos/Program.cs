using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos_Multiplos
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("-----------------------------------");
            Console.WriteLine(" QUESTÃO 05 - VALORES MÚLIPLOS");
            Console.WriteLine("-----------------------------------\n");

            int valorA = 0, valorB = 0;

            Console.WriteLine("-----------------------------------");
            Console.Write("Digite o valor de A: ");
            valorA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o valor de B: ");
            valorB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------------------------------");

            if ( valorA > valorB && valorA % valorB == 0)Console.WriteLine("\nOs valores são múltiplos!!");
            else Console.WriteLine("\nOs valores  não são múltiplos!!");

            Console.ReadKey();
        }
    }
}
