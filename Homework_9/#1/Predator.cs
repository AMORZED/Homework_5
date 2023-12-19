using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _Animal;

namespace _Predator
{
    public class Predator : Animal
    {
        private Animal animal;

        public Predator(Animal animal) 
        {
            this.animal = animal;
        }
        public override void Live()
        {
            Console.WriteLine("В лесу появились хищники!");
            this.Bite();
        }
        public void Bite()
        {
            Console.WriteLine("Хищники охотятся! Тикайте з лесу!");
        }
    }
}
