using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal interface IHerbivore
    {
        string typeH { get; }
        string foodH { get; }

        void displayEatH();
    }
}
