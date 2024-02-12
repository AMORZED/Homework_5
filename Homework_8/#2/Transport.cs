using _Engine;

namespace _Transport
{
    public abstract class Transport : Engine
    {
        public abstract Engine Engine { get; set; }
        public abstract void Move(bool isMove);
    }
}
