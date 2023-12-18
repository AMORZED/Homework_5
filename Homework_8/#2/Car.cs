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

        private bool isMoving;

        public Car() 
        { 
            this.Engine = new Engine();
        }
        
        public override void Move()
        {
            if (isMoving == false)
            {
                this.isMoving = true;
                Console.WriteLine("Машина начала ехать!");
                Engine.StartEngine();
            }
        }
    }
}
