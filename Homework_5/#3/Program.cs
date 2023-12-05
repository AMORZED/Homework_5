namespace Homework_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер числа, которое надо найти:");
            int number = Fibonacci(int.Parse(Console.ReadLine()));

            Console.WriteLine("\nРезультат: " + number);
        }
        static int Fibonacci(int i)
        {
            if (i == 1 | i == 2) return 1;
            else return Fibonacci(i - 1) + Fibonacci(i - 2);
        }
    }
}
