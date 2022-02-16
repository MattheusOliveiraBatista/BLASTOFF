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
            Console.WriteLine(" QUESTÃO 11 - CONCATENAÇÃO DE LISTAS");
            Console.WriteLine("---------------------------------------\n");

            List<int> A = new List<int>() { 1, 2, 3, 4 };
            List<int> B = new List<int>() { 1, 2, 5, 8 };

            List<int> C = new List<int>();
            
            C.AddRange(A);
           
            foreach (int valor in C) Console.Write("{0} ", valor); //Apenas com concatenação da lista A

            Console.WriteLine("\n\n");
            
            C.AddRange(B);
            foreach (int valor in C) Console.Write("{0} ", valor); //Com concatenação da lista A + lista B

            Console.ReadKey();
        }
    }
}