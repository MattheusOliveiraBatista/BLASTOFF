using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros_Pares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine(" QUESTÃO 07 - NÚMEROS PARES");
            Console.WriteLine("--------------------------------------------\n");

            int elementos = 0;

            Console.Write("Digite a quantidade de elementos que deseja verificar: ");
            elementos = Convert.ToInt32(Console.ReadLine());
            
            List<int> lista_aleatoria = new List<int>();
            List<int> lista_pares = new List<int>();
            List<int> lista_impares = new List<int>();

            Random randNum = new Random();

            //Gerando números aleatórios
            for (int i = 0; i < elementos; i++) lista_aleatoria.Add(randNum.Next(100));

            Console.WriteLine("\n----------------------------------------------------------------");
            //Valores da Lista
            foreach (int valor in lista_aleatoria)
            {
                Console.Write("{0} ", valor);
                if (valor % 2 == 0) lista_pares.Add(valor);
                else lista_impares.Add(valor);
            }
            Console.Write("\n");
            Console.WriteLine("----------------------------------------------------------------\n");


            Console.WriteLine("\n--------------------------");
            Console.WriteLine(" VALORES PARES");
            Console.WriteLine("--------------------------");
            foreach (int valor in lista_pares) Console.Write("{0} ",valor);
            Console.Write("\n");
            Console.WriteLine("--------------------------");



            Console.WriteLine("\n--------------------------");
            Console.WriteLine(" VALORES IMPARES");
            Console.WriteLine("--------------------------");
            foreach (int valor in lista_impares) Console.Write("{0} ", valor);
            Console.Write("\n");
            Console.WriteLine("--------------------------\n");

            Console.ReadKey();





        }
    }
}
