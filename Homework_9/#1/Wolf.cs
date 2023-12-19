using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _Predator;

namespace _Wolf
{
    internal class Wolf : Predator
    {
        private Predator predator;        
        public Wolf(Predator predator) : base(predator)
        {
            this.predator = predator;
        }

        public override void Live()
        {
            Console.WriteLine("Волки завелись в лесу!");
        }
    }
}
