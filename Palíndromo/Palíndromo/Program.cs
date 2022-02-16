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
            Console.WriteLine(" QUESTÃO 14 - PALÍDROMO");
            Console.WriteLine("---------------------------------------\n");

            Console.Write("Digite a palavra que deseja verificar: ");
            string Palavra;

            Palavra = Console.ReadLine();

            int tamanho_palavra = Palavra.Length - 1;

            while(tamanho_palavra != -1)
            {
                for(int i = 0; i < Palavra.Length; i++)
                {
                    if(Palavra[i] == Palavra[tamanho_palavra])
                    {
                        if(tamanho_palavra == 0)
                        {
                            Console.WriteLine("\nÉ PALÍDROMO!");
                            Console.ReadKey();

                        }
                        tamanho_palavra--;
                    }
                    else
                    {
                        Console.WriteLine("\nNÃO É PALÍDROMO!");
                        i = Palavra.Length;
                        tamanho_palavra = -1;
                        Console.ReadKey();

                    }

                }
            }
        
        }

    }
}