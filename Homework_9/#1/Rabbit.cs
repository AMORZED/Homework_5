using _HerbivoreAnimal;
using _Predator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Rabbit : HerbivoreAnimal
    {
        public Rabbit(HerbivoreAnimal herbivoreAnimal)
        {

        }

        public override void Live()
        {
            Console.WriteLine("Зайцы завелись в лесу!");
        }
    }
}
