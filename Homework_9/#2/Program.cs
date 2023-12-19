using System.Security.Cryptography.X509Certificates;
using _Herbivores;
using _Zoo;
using _Predators;
using _Animal;

namespace _Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo();

            Herbivores Rabbit = new Herbivores("Кролик");
            Herbivores Horse = new Herbivores("Лошадь");
            Predators Wolf = new Predators("Волк");
            Predators Tiger = new Predators("Тигр");
            Animal Animal1 = new Animal(Rabbit);
            Animal Animal2 = new Animal(Horse);
            Animal Animal3 = new Animal(Wolf);
            Animal Animal4 = new Animal(Tiger);


            zoo.Distribution(Animal1);
            zoo.Distribution(Animal2);
            zoo.Distribution(Animal3);
            zoo.Distribution(Animal4);
        }
    }
}
