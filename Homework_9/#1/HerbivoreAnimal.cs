using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _Animal;

namespace _HerbivoreAnimal
{
    public class HerbivoreAnimal : Animal
    {
        private Animal animal;

        public HerbivoreAnimal(Animal animal)
        {
            this.animal = animal;
        }
        public override void Live()
        {
            Console.WriteLine("В лесу появились травоядные!");
            this.Bite();
        }
        public void Bite()
        {
            Console.WriteLine("Травоядные едят траву! Не мешайте им!");
        }
    }
}
