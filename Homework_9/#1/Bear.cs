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
        public Bear(Predator predator)
        {

        }

        public override void Live()
        {
            Console.WriteLine("Медведи завелись в лесу!");
        }
    }
}
