using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_Temperatura
{
    class Program
    {
        static void Main(string[] args)
        {

            C_temp CT = new C_temp(); // C_temp = Conversor de temperatura

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine(" QUESTÃO 04 - CONVERSOR DE TEMPERATURA");
            Console.WriteLine("-------------------------------------------\n");
            
            Console.Write("Digite sua temperatura em Celsius: ");
           
            CT.Celsius = float.Parse(Console.ReadLine());
            CT.Fahrenheit = ((CT.Celsius) * 9 / 5 + 32);
           
            CT.ExibiTemperatura();
            Console.ReadKey();
        }
    }
}
