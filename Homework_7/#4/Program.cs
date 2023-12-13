using _Queue;

namespace Homework_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Show();
            Console.WriteLine($"Удален элемент со значением \"{q.Pop()}\"");
            q.Show();
            q.Push("IT Academy");
            q.Push(":)");
            q.Show();
            Console.WriteLine($"Удален элемент со значением \"{q.Pop()}\"");
            q.Show();
        }
    }
}
