using _Car;
using _Engine;
using _Plane;

namespace _2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Engine EngineOfCar = new Engine();
            Engine EngineOfPlane = new Engine();

            Car Porshe = new Car(EngineOfCar);
            Porshe.Move(true);

            Console.WriteLine();
            Plane Plane = new Plane(EngineOfPlane);
            Plane.Move(true);

            Console.WriteLine();
            Plane.Move(false);
        }
    }
}
