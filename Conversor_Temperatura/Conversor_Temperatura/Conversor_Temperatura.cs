using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_Temperatura
{
    class C_temp
    {
        private float celsius;

        public float Celsius
        {
            get { return this.celsius; }
            set { this.celsius = value; }

        }

        private float fahrenheit;

        public float Fahrenheit
        {
            get { return this.fahrenheit; }
            set { this.fahrenheit = value; }

        }

        public void ExibiTemperatura()
        {
            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine("A Temperatura em Fahrenheit é.: {0}", this.fahrenheit);
            Console.WriteLine("-------------------------------------------");
        }

    }
}
