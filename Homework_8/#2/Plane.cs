using _Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _Transport;
using System.Runtime.InteropServices;

namespace _Plane
{
    public class Plane : Transport
    {
        public override Engine Engine { get; set; }

        public Plane(Engine Engine)
        {
            this.Engine = Engine;
        }
        public override void Move()
        {
                Console.WriteLine("Самолет взлетел!");
                Engine.StartEngine();          
        }
    }
}
