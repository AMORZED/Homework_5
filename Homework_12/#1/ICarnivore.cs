using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal interface ICarnivore
    {
        string typeC { get; }
        string foodC { get; }

        void displayEatC();
    }
}
