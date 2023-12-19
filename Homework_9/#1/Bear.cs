using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _Predator;

namespace _Bear
{
    internal class Bear : Predator
    {
        private Predator predator;
        public Bear(Predator predator) : base(predator)
        {
            this.predator = predator;
        }

        public override void Live()
        {
            Console.WriteLine("Медведи завелись в лесу!");
        }
    }
}
