using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine(" QUESTÃO 09 - TABUADA");
            Console.WriteLine("------------------------------\n");

            int numero = 0;
            Console.Write("Digite o número que deseja a tabuada: ");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n----------------------");
            Console.WriteLine("TABUADA DO NÚMERO {0}", numero);
            Console.WriteLine("----------------------");
            for (int i =  0; i <= 10; i++) 
            {
                if (numero * i < 100)
                {
                    Console.WriteLine("{0} x 0{1} = {2}", numero, i, numero * i);
                    if (i == 10) Console.WriteLine("{0} x {1} = {2}", numero, i, numero * i);
                }
                else 
                {
                    if (i == 10) Console.WriteLine("{0} x {1} = {2}", numero, i, numero * i);
                    else Console.WriteLine("{0} x 0{1} = {2}", numero, i, numero * i);
                }
            }
            Console.WriteLine("----------------------");
            Console.ReadKey();
        }
    }
}
