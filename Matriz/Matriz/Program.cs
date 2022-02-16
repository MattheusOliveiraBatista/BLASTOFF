using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(" QUESTÃO 13 - MATRIZ");
            Console.WriteLine("---------------------------------------\n");
            Random randNum = new Random();

            int i = 0, j = 0;
            Console.Write("Digite o número de linha(s) da matriz: ");
            i = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o número de coluna(s) da matriz: ");
            j = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[i, j];
            
            for (int I = 0; I < i; I++)
            {
                for(int J = 0; J < j; J++)
                {
                    matrix[I, J] = randNum.Next(10);
                }
            }
            Console.WriteLine("\n");

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("MATRIZ COM {0} LINHAS E {1} COLUNAS.",i,j);
            Console.WriteLine("-----------------------------------------");

            for (int I = 0; I < i; I++)
            {
                for (int J = 0; J < j; J++)
                {
                    Console.Write("[{0}]", matrix[I, J]);
                }
                Console.WriteLine("\n");
            }

            Console.ReadKey();
        }
    }
}
