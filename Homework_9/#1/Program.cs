using _Animal;
using _Predator;
using System.Reflection.Metadata;
using _Bear;
using _Wolf;
using _HerbivoreAnimal;
using _1;

namespace _Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal Animal = new Animal();
            Console.WriteLine();
            
            Predator Predator = new Predator(Animal);
            Console.WriteLine();

            Wolf Wolf = new Wolf(Predator);
            Bear Bear = new Bear(Predator);
            
            Console.WriteLine("----------");

            HerbivoreAnimal HerbivoreAnimal = new HerbivoreAnimal(Animal);
            Console.WriteLine();

            Rabbit Rabbit = new Rabbit(HerbivoreAnimal);
            Deer Deer = new Deer(HerbivoreAnimal);
        }
    }
}
