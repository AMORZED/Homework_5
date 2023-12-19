using _HerbivoreAnimal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Deer : HerbivoreAnimal
    {
        private HerbivoreAnimal herbivoreAnimal;
        public Deer(HerbivoreAnimal herbivoreAnimal) : base(herbivoreAnimal)
        {
            this.herbivoreAnimal = herbivoreAnimal;
        }

        public override void Live()
        {
            Console.WriteLine("Олени завелись в лесу!");
        }
    }
}
