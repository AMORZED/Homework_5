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
        public Deer(HerbivoreAnimal herbivoreAnimal)
        {

        }

        public override void Live()
        {
            Console.WriteLine("Олени завелись в лесу!");
        }
    }
}
