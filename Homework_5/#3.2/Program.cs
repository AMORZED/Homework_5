namespace Homework_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int number = Factorial(int.Parse(Console.ReadLine()));

            Console.WriteLine($"\nФакториал этого числа: {number}");
        }
        static int Factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n *= Factorial(n - 1);
            }
        }
    }
}
