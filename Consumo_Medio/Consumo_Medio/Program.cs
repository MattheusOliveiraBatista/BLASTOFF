using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumo_Medio
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("-----------------------------------");
            Console.WriteLine(" QUESTÃO 02 - CONSUMO MÉDIO");
            Console.WriteLine("-----------------------------------\n");
            Consumo cs = new Consumo();

            Console.Write("Digite a distância em (Km): ");
            cs.Distancia = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a quantidade de litros atual (L): ");
            cs.Combustivel = Convert.ToDouble(Console.ReadLine());


            cs.consumo();

            Console.ReadKey();
        }
    }
}
