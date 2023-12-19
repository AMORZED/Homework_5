using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using _Herbivores;
using _Animal;
using _Predators;

namespace _Zoo 
{
    public class Zoo : Animal
    {
        public void Distribution(Animal animal) //Отправка животного в подходящий загон
        {
            if (animal.typeOfAnimal == typeof(Predators))
            {
                Console.WriteLine($"Хищник \"{animal.name}\" помещен в загон для хищников!");
            }
            else
            {
                Console.WriteLine($"Травоядный \"{animal.name}\" помещен в загон для травоядных!");
            }
        }
    }
}
