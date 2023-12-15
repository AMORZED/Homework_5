using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using _Engine;

namespace _Transport
{
    public abstract class Transport
    {
        public abstract Engine Engine { get; set; }
        public abstract void Move();
    }
}
