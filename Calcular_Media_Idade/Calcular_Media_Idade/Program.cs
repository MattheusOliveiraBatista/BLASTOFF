using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_Media_Idade
{
    class Program
    {
        static void Main(string[] args)
        {
            Idade id = new Idade();

            Console.WriteLine("-----------------------------------");
            Console.WriteLine(" QUESTÃO 01 - MÉDIA DAS IDADES");
            Console.WriteLine("-----------------------------------\n\n");

            Console.Write("Digite a idade I: ");
            id.valorI = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a idade J: ");
            id.valorJ = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a idade K: ");
            id.valorK = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a idade X: ");
            id.valorX = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a idade Y: ");
            id.valorY = Convert.ToInt32(Console.ReadLine());


            id.ExibirMediaIdade(); // Retorna a média das idades
            id.MaiorIdade(); //Retorna o usuário mais velho


            Console.WriteLine("\n\nPressione Qualquer Tecla Para Sair...");
            Console.ReadKey();

        }
    }
}
