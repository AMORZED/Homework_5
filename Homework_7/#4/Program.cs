using _Queue;

namespace Homework_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue(10);
            q.Show();
            q.Pop();
            q.Show();
            q.Push(666);
            q.Push(228);
            q.Show();
            q.Pop();
            q.Show();
        }
    }
}
