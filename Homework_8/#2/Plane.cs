using _Engine;
using _Transport;

namespace _Plane
{
    public class Plane : Transport
    {
        public override Engine Engine { get; set; }

        public Plane(Engine Engine)
        {
            this.Engine = Engine;
        }
        public override void Move(bool isMove)
        {
            if (isMove == true & isMooving == false)
            {
                Console.WriteLine("Самолет взлетел!");
                Engine.SwitchEngine();
                isMooving = true;
            }
            else if (isMove == true & isMooving == true)
            {
                Console.WriteLine("Самолет уже находится в движении!");
            }
            else if (isMove == false & isMooving == false)
            {
                Console.WriteLine("Самолет уже стоит на месте!");
            }
            else
            {
                Console.WriteLine("Самолет приземлился!");
                Engine.SwitchEngine();
                isMooving = false;
            }
        }

        private bool isMooving = false;
    }
}
