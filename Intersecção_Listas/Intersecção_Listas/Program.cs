using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intersecção_Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(" QUESTÃO 11 - INTERSECÇÃO DE LISTAS");
            Console.WriteLine("---------------------------------------\n");

            List<int> A = new List<int>() { 1, 2, 3, 4};
            List<int> B = new List<int>() { 1, 2, 5, 8};
            List<int> C = new List<int>();

            foreach(int valorA in A)
            {
                foreach(int valorB in B)
                {
                    if (valorA == valorB) C.Add(valorA);
                }
            }

           Console.WriteLine("---------------------------------");
           Console.WriteLine(" VALORES DA INTERSECÇÃO");
           Console.WriteLine("---------------------------------");

           foreach (int valores in C) Console.WriteLine(valores);
           
           Console.ReadKey();


        }
    }
}
