using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _Herbivores;
using _Predators;
using _Zoo;

namespace _Animal
{
    public class Animal
    {
        public string name;
        public object typeOfAnimal;
        
        public Animal(Herbivores herbivore) 
        { 
            this.name = herbivore.name;
            this.typeOfAnimal = herbivore.GetType();
        }

        public Animal(Predators predator) 
        {
            this.name = predator.name;
            this.typeOfAnimal = predator.GetType();
        }

        public Animal() 
        { 
        
        }
    }


}
