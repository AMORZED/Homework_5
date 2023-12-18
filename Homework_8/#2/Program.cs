using _Car;
using _Engine;
using _Transport;
using _Plane;

namespace _2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car Porshe = new Car();
            Porshe.Move();
            
            Plane Plane = new Plane();
            Plane.Move();
        }
    }
}
