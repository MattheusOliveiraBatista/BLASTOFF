using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumo_Medio
{
    class Consumo
    {
        private double distancia;
        public Double Distancia
        {
            get { return this.distancia; }
            set { this.distancia = value; }
        }


        private double combustivel;
        public Double Combustivel
        {
            get { return this.combustivel; }
            set { this.combustivel = value; }
        }

        public void consumo()
        {
            Console.WriteLine("\n--------------------------------------------------------");
            Console.WriteLine("Combustivel (L): {0} | Distância (Km): {1}", this.combustivel, this.distancia);
            double consumo = this.distancia / this.combustivel;
            Console.WriteLine("Consumo Médio: {0}", consumo);
            Console.WriteLine("Logo.: São {0} Km por litro.", consumo);
            Console.WriteLine("--------------------------------------------------------");
        }

    }
}
