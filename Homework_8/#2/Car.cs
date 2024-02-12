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
        
        public override void Move(bool isMove)
        {
            if (isMove == true & isMooving == false)
            {
                Console.WriteLine("Машина поехала!");
                Engine.SwitchEngine();
                isMooving = true;
            }
            else if (isMove == true & isMooving == true)
            {
                Console.WriteLine("Машина уже находится в движении!");
            }
            else if (isMove == false & isMooving == false)
            {
                Console.WriteLine("Машина уже стоит на месте!");
            }
            else
            {
                Console.WriteLine("Машина остановилась!");
                Engine.SwitchEngine();
                isMooving = false;
            }
        }

        private bool isMooving = false;
    }
}
