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

        private bool isMoving;

        public Plane()
        {
            this.Engine = new Engine();
        }
        public override void Move()
        {
            if (isMoving == false)
            {
                this.isMoving = true;
                Console.WriteLine("Самолет взлетел!");
                Engine.StartEngine();
            }
        }
    }
}
