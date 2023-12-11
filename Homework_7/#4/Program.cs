using _Queue;

namespace Homework_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Show();
            q.Pop();
            q.Show();
            q.Push("IT Academy");
            q.Push(":)");
            q.Show();
            q.Pop();
            q.Show();
        }
    }
}
