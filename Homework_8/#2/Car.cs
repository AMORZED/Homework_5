using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _Engine;
using _Transport;

namespace _Car
{
    internal class Car : Transport
    {
        public override Engine Engine { get; set; }

        public Car(Engine Engine) 
        { 
            this.Engine = Engine;
        }
        
        public override void Move()
        {
            Console.WriteLine("Машина начала ехать!");
            this.Engine.StartEngine();            
        }
    }
}
