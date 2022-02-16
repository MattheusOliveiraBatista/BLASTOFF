using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_Media_Idade
{
    class Idade
    {
        private int I;
        public int valorI
        {
            get { return this.I; }
            set { this.I = value; }
        }


        private int J;
        public int valorJ
        {
            get { return this.J; }
            set { this.J = value; }
        }

        private int K;
        public int valorK
        {
            get { return this.K; }
            set { this.K = value; }
        }
        private int X;
        public int valorX
        {
            get { return this.X; }
            set { this.X = value; }
        }


        private int Y;
        public int valorY
        {
            get { return this.Y; }
            set { this.Y = value; }
        }

        
        public void ExibirMediaIdade()
        {
            int media = (this.valorI + this.valorJ + this.valorK + this.valorX + this.valorY)/ 5;
            Console.WriteLine("\n----------------------------------");
            Console.WriteLine("Média das Idades: {0}", media);
            Console.WriteLine("----------------------------------\n");

        }

        public void MaiorIdade()
        {
            //Se o valorI for o mais velho
            if(this.valorI > this.valorJ && this.valorI > this.valorK && this.valorI > this.valorX && this.valorI > this.valorY)
            {
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("O usuário valorI é o mais velho e tem {0} anos.", this.valorI );
                Console.WriteLine("-------------------------------------------------\n");
            }

            //Se o valorJ for o mais velho
            else if (this.valorJ > this.valorI && this.valorJ > this.valorK && this.valorJ > this.valorX && this.valorJ > this.valorY)
            {
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine("O usuário valorJ é o mais velho e tem {0} anos.", this.valorJ);
                    Console.WriteLine("-------------------------------------------------\n");
            }
            
            //Se o valorK for o mais velho
            else if (this.valorK > this.valorI && this.valorK > this.valorJ && this.valorK > this.valorX && this.valorK > this.valorY)
            {
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("O usuário valorK é o mais velho e tem {0} anos.", this.valorK);
                Console.WriteLine("-------------------------------------------------\n");
            }

            //Se o valorX for o mais velho
            else if (this.valorX > this.valorI && this.valorX > this.valorJ && this.valorX > this.valorK && this.valorX > this.valorY)
            {
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("O usuário valorX é o mais velho e tem {0} anos.", this.valorX);
                Console.WriteLine("-------------------------------------------------\n");
            }

            //Se o valorY for o mais velho
            else
            {
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("O usuário valorY é o mais velho e tem {0} anos.", this.valorY);
                Console.WriteLine("-------------------------------------------------\n");
            }
        }


    }
}
