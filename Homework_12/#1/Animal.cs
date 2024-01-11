using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    abstract class Animal
    {
        protected string name;
        protected int numOfLegs;

        public void setName(string name)
        {
            this.name = name;
        }
        public string getName() 
        { 
            return name; 
        }
        public void setNumOfLegs(int legs)
        {
            this.numOfLegs = legs;
        }
        public int getNumOfLegs()
        {
            return numOfLegs;
        }
        public virtual void displayAnimal()
        {

        }
    }
}
