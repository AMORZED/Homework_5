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
            Engine Engine = new Engine();
            
            Car Porshe = new Car(Engine);
            Porshe.Move();
            
            Plane Plane = new Plane(Engine);
            Plane.Move();
        }
    }
}
