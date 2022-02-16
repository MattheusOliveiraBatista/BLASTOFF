using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_Duração_Partida
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine(" QUESTÃO 06 - CALCULAR DURAÇÃO DA PARTIDA");
            Console.WriteLine("--------------------------------------------\n");

            int horas = 0, minutos = 0, segundos = 0;

            Console.WriteLine("Digite abaixo a HORA, MINUTO E SEGUNDO que a partida iniciou.");

            Console.Write("Hora: ");
            horas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Minuto: ");
            minutos = Convert.ToInt32(Console.ReadLine());
            Console.Write("Segundo: ");
            segundos = Convert.ToInt32(Console.ReadLine());

            var dt1 = new TimeSpan(horas, minutos, segundos);

            horas = minutos = segundos = 0;

            Console.WriteLine("\n\nDigite abaixo a HORA, MINUTO E SEGUNDO que a partida finalizou.");

            Console.Write("Hora: ");
            horas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Minuto: ");
            minutos = Convert.ToInt32(Console.ReadLine());
            Console.Write("Segundo: ");
            segundos = Convert.ToInt32(Console.ReadLine());

            var dt2 = new TimeSpan(horas, minutos, segundos);


            Console.WriteLine("\nDuração da Partida: {0} ",dt2.Subtract(dt1).ToString());
            Console.ReadKey();
        }
    }
}
